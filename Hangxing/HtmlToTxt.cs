using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Hangxing
{ 
    class HtmlToText
{
    // Static data tables
    protected static Dictionary<string, string> _tags;
    protected static HashSet<string> _ignoreTags;

    // Instance variables
    protected TextBuilder _text;
    protected string _html;
    protected int _pos;

    // Static constructor (one time only)
    static HtmlToText()
    {
        _tags = new Dictionary<string, string>();
        _tags.Add("address", "\n");
        _tags.Add("blockquote", "\n");
        _tags.Add("div", "\n");
        _tags.Add("dl", "\n");
        _tags.Add("fieldset", "\n");
        _tags.Add("form", "\n");
        _tags.Add("h1", "\n");
        _tags.Add("/h1", "\n");
        _tags.Add("h2", "\n");
        _tags.Add("/h2", "\n");
        _tags.Add("h3", "\n");
        _tags.Add("/h3", "\n");
        _tags.Add("h4", "\n");
        _tags.Add("/h4", "\n");
        _tags.Add("h5", "\n");
        _tags.Add("/h5", "\n");
        _tags.Add("h6", "\n");
        _tags.Add("/h6", "\n");
        _tags.Add("p", "\n");
        _tags.Add("/p", "\n");
        _tags.Add("table", "\n");
        _tags.Add("/table", "\n");
        _tags.Add("ul", "\n");
        _tags.Add("/ul", "\n");
        _tags.Add("ol", "\n");
        _tags.Add("/ol", "\n");
        _tags.Add("/li", "\n");
        _tags.Add("br", "\n");
        _tags.Add("/td", "\t");
        _tags.Add("/tr", "\n");
        _tags.Add("/pre", "\n");

        _ignoreTags = new HashSet<string>();
        _ignoreTags.Add("script");
        _ignoreTags.Add("noscript");
        _ignoreTags.Add("style");
        _ignoreTags.Add("object");
    }

    /// <summary>
    /// Converts the given HTML to plain text and returns the result.
    /// </summary>
    /// <param name="html">HTML to be converted</param>
    /// <returns>Resulting plain text</returns>
    public string Convert(string html)
    {
        // Initialize state variables
        _text = new TextBuilder();
        _html = html;
        _pos = 0;

        // Process input
        while (!EndOfText)
        {
            if (Peek() == '<')
            {
                // HTML tag
                bool selfClosing;
                string tag = ParseTag(out selfClosing);

                // Handle special tag cases
                if (tag == "body")
                {
                    // Discard content before <body>
                    _text.Clear();
                }
                else if (tag == "/body")
                {
                    // Discard content after </body>
                    _pos = _html.Length;
                }
                else if (tag == "pre")
                {
                    // Enter preformatted mode
                    _text.Preformatted = true;
                    EatWhitespaceToNextLine();
                }
                else if (tag == "/pre")
                {
                    // Exit preformatted mode
                    _text.Preformatted = false;
                }

                string value;
                if (_tags.TryGetValue(tag, out value))
                    _text.Write(value);

                if (_ignoreTags.Contains(tag))
                    EatInnerContent(tag);
            }
            else if (Char.IsWhiteSpace(Peek()))
            {
                // Whitespace (treat all as space)
                _text.Write(_text.Preformatted ? Peek() : ' ');
                MoveAhead();
            }
            else
            {
                // Other text
                _text.Write(Peek());
                MoveAhead();
            }
        }
        // Return result
        return HttpUtility.HtmlDecode(_text.ToString());
    }

    // Eats all characters that are part of the current tag
    // and returns information about that tag
    protected string ParseTag(out bool selfClosing)
    {
        string tag = String.Empty;
        selfClosing = false;

        if (Peek() == '<')
        {
            MoveAhead();

            // Parse tag name
            EatWhitespace();
            int start = _pos;
            if (Peek() == '/')
                MoveAhead();
            while (!EndOfText && !Char.IsWhiteSpace(Peek()) &&
                Peek() != '/' && Peek() != '>')
                MoveAhead();
            tag = _html.Substring(start, _pos - start).ToLower();

            // Parse rest of tag
            while (!EndOfText && Peek() != '>')
            {
                if (Peek() == '"' || Peek() == '\'')
                    EatQuotedValue();
                else
                {
                    if (Peek() == '/')
                        selfClosing = true;
                    MoveAhead();
                }
            }
            MoveAhead();
        }
        return tag;
    }

    // Consumes inner content from the current tag
    protected void EatInnerContent(string tag)
    {
        string endTag = "/" + tag;

        while (!EndOfText)
        {
            if (Peek() == '<')
            {
                // Consume a tag
                bool selfClosing;
                if (ParseTag(out selfClosing) == endTag)
                    return;
                // Use recursion to consume nested tags
                if (!selfClosing && !tag.StartsWith("/"))
                    EatInnerContent(tag);
            }
            else MoveAhead();
        }
    }

    // Returns true if the current position is at the end of
    // the string
    protected bool EndOfText
    {
        get { return (_pos >= _html.Length); }
    }

    // Safely returns the character at the current position
    protected char Peek()
    {
        return (_pos < _html.Length) ? _html[_pos] : (char)0;
    }

    // Safely advances to current position to the next character
    protected void MoveAhead()
    {
        _pos = Math.Min(_pos + 1, _html.Length);
    }

    // Moves the current position to the next non-whitespace
    // character.
    protected void EatWhitespace()
    {
        while (Char.IsWhiteSpace(Peek()))
            MoveAhead();
    }

    // Moves the current position to the next non-whitespace
    // character or the start of the next line, whichever
    // comes first
    protected void EatWhitespaceToNextLine()
    {
        while (Char.IsWhiteSpace(Peek()))
        {
            char c = Peek();
            MoveAhead();
            if (c == '\n')
                break;
        }
    }

    // Moves the current position past a quoted value
    protected void EatQuotedValue()
    {
        char c = Peek();
        if (c == '"' || c == '\'')
        {
            // Opening quote
            MoveAhead();
            // Find end of value
            int start = _pos;
            _pos = _html.IndexOfAny(new char[] { c, '\r', '\n' }, _pos);
            if (_pos < 0)
                _pos = _html.Length;
            else
                MoveAhead();    // Closing quote
        }
    }

    /// <summary>
    /// A StringBuilder class that helps eliminate excess whitespace.
    /// </summary>
    protected class TextBuilder
    {
        private StringBuilder _text;
        private StringBuilder _currLine;
        private int _emptyLines;
        private bool _preformatted;

        // Construction
        public TextBuilder()
        {
            _text = new StringBuilder();
            _currLine = new StringBuilder();
            _emptyLines = 0;
            _preformatted = false;
        }

        /// <summary>
        /// Normally, extra whitespace characters are discarded.
        /// If this property is set to true, they are passed
        /// through unchanged.
        /// </summary>
        public bool Preformatted
        {
            get
            {
                return _preformatted;
            }
            set
            {
                if (value)
                {
                    // Clear line buffer if changing to
                    // preformatted mode
                    if (_currLine.Length > 0)
                        FlushCurrLine();
                    _emptyLines = 0;
                }
                _preformatted = value;
            }
        }

        /// <summary>
        /// Clears all current text.
        /// </summary>
        public void Clear()
        {
            _text.Length = 0;
            _currLine.Length = 0;
            _emptyLines = 0;
        }

        /// <summary>
        /// Writes the given string to the output buffer.
        /// </summary>
        /// <param name="s"></param>
        public void Write(string s)
        {
            foreach (char c in s)
                Write(c);
        }

        /// <summary>
        /// Writes the given character to the output buffer.
        /// </summary>
        /// <param name="c">Character to write</param>
        public void Write(char c)
        {
            if (_preformatted)
            {
                // Write preformatted character
                _text.Append(c);
            }
            else
            {
                if (c == '\r')
                {
                    // Ignore carriage returns. We'll process
                    // '\n' if it comes next
                }
                else if (c == '\n')
                {
                    // Flush current line
                    FlushCurrLine();
                }
                else if (Char.IsWhiteSpace(c))
                {
                    // Write single space character
                    int len = _currLine.Length;
                    if (len == 0 || !Char.IsWhiteSpace(_currLine[len - 1]))
                        _currLine.Append(' ');
                }
                else
                {
                    // Add character to current line
                    _currLine.Append(c);
                }
            }
        }

        // Appends the current line to output buffer
        protected void FlushCurrLine()
        {
            // Get current line
            string line = _currLine.ToString().Trim();

            // Determine if line contains non-space characters
            string tmp = line.Replace(" ", String.Empty);
            if (tmp.Length == 0)
            {
                // An empty line
                _emptyLines++;
                if (_emptyLines < 2 && _text.Length > 0)
                    _text.AppendLine(line);
            }
            else
            {
                // A non-empty line
                _emptyLines = 0;
                _text.AppendLine(line);
            }

            // Reset current line
            _currLine.Length = 0;
        }

        /// <summary>
        /// Returns the current output as a string.
        /// </summary>
        public override string ToString()
        {
            if (_currLine.Length > 0)
                FlushCurrLine();
            return _text.ToString();
        }
    }
}
}
 
 
 
 
 
/*//2、提取html的正文 类
using System;
 using System.Text;
 namespace HtmlStrip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "<div>abc</div><span>efg</span><br /><script>888</script><!--<PA>WW</PA-->oo";
            //System.IO.StreamReader rd=new System.IO.StreamReader ("/home/lx/test.html");
            //str=rd.ReadToEnd ();
            HtmlParser t = new HtmlParser(str); //
            t.KeepTag(new string[] { "br" }); //设置br标签不过虑
            Console.Write(t.Text());
        }



    }
    class HtmlParser
    {
        private string[] htmlcode; //把html转为数组形式用于分析
        private StringBuilder result = new StringBuilder();  //输出的结果
        private int seek; //分析文本时候的指针位置
        private string[] keepTag;  //用于保存要保留的尖括号内容
        private bool _inTag;  //标记现在的指针是不是在尖括号内
        private bool needContent = true;  //是否要提取正文
        private string tagName;  //当前尖括号的名字
        private string[] specialTag = new string[] { "script", "style", "!--" };  //特殊的尖括号内容，一般这些标签的正文是不要的

        /// <summary>
        /// 当指针进入尖括号内，就会触发这个属性。这里主要逻辑是提取尖括号里的标签名字
        /// </summary>
        public bool inTag
        {
            get { return _inTag; }
            set
            {
                _inTag = value;
                if (!value)
                    return;
                bool ok = true;
                tagName = "";
                while (ok)
                {
                    string word = read();
                    if (word != " " && word != ">")
                    {
                        tagName += word;
                    }
                    else if (word == " " && tagName.Length > 0)
                    {
                        ok = false;
                    }
                    else if (word == ">")
                    {
                        ok = false;
                        inTag = false;
                        seek -= 1;
                    }
                }
            }
        }
        /// <summary>
        /// 初始化类
        /// </summary>
        /// <param name="html">
        ///  要分析的html代码
        /// </param>
        public HtmlParser(string html)
        {
            htmlcode = new string[html.Length];
            for (int i = 0; i < html.Length; i++)
            {
                htmlcode[i] = html[i].ToString();
            }
            KeepTag(new string[] { });
        }
        /// <summary>
        /// 设置要保存那些标签不要被过滤掉
        /// </summary>
        /// <param name="tags">
        ///
        /// </param>
        public void KeepTag(string[] tags)
        {
            keepTag = tags;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// 输出处理后的文本
        /// </returns>
        public string Text()
        {
            int startTag = 0;
            int endTag = 0;
            while (seek < htmlcode.Length)
            {
                string word = read();
                if (word.ToLower() == "<")
                {
                    startTag = seek;
                    inTag = true;
                }
                else if (word.ToLower() == ">")
                {
                    endTag = seek;
                    inTag = false;
                    if (iskeepTag(tagName.Replace("/", "")))
                    {
                        for (int i = startTag - 1; i < endTag; i++)
                        {
                            result.Append(htmlcode[i].ToString());
                        }
                    }
                    else if (tagName.StartsWith("!--"))
                    {
                        bool ok = true;
                        while (ok)
                        {
                            if (read() == "-")
                            {
                                if (read() == "-")
                                {
                                    if (read() == ">")
                                    {
                                        ok = false;
                                    }
                                    else
                                    {
                                        seek -= 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (string str in specialTag)
                        {
                            if (tagName == str)
                            {
                                needContent = false;
                                break;
                            }
                            else
                                needContent = true;
                        }
                    }
                }
                else if (!inTag && needContent)
                {
                    result.Append(word);
                }

            }
            return result.ToString();
        }
        /// <summary>
        /// 判断是否要保存这个标签
        /// </summary>
        /// <param name="tag">
        /// A <see cref="System.String"/>
        /// </param>
        /// <returns>
        /// A <see cref="System.Boolean"/>
        /// </returns>
        private bool iskeepTag(string tag)
        {
            foreach (string ta in keepTag)
            {
                if (tag.ToLower() == ta.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private string read()
        {
            return htmlcode[seek++];
        }

    }
}
*/