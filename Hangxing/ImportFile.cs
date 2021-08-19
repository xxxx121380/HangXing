using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Utility;
using System.Xml.Linq;
using Utilities;
using System.Web.UI.WebControls.WebParts;

namespace Hangxing
{
    public static class ImportFile
    {

        /* static Dictionary<string, string> insert_dic = new Dictionary<string, string>();
         static string insert_sql = "insert into Article (ArticleDate,ArticleAuthor，ArticleTitle，ArticleInfo，ArticleLocat，ArticleState) values(@ArticleDate,@ArticleAuthor,@ArticleTitle,@ArticleInfo,@ArticleLocat,@ArticleState)";
         static string ArticleDate = null;
         static string ArticleAuthor = null;
         static string ArticleTitle = null;
         static string ArticleInfo = null;
         static string ArticleLocat = null;
          public static bool ImportHtml(string strFilePath,string targetPath)
          {
              if (!File.Exists(strFilePath))
                  return false;
              HtmlToText convert = new HtmlToText();
              ArticleInfo = convert.Convert(System.IO.File.ReadAllText(strFilePath));
              ArticleLocat = @targetPath+"\\"+DirFile.GetFileName(strFilePath);
              string name=DirFile.GetFileNameNoExtension(strFilePath);
              string[] strArr = name.Split('_');
              if (strArr.Length == 3)
              {
                  ArticleAuthor = strArr[0];
                  ArticleDate = strArr[1];
                  ArticleTitle = strArr[2];
              }
              else
                  return false;
              if(ArticleDate!=null&& ArticleAuthor != null&& ArticleTitle != null&&ArticleInfo!=null&& ArticleLocat!=null)
              {
                  DirFile.CopyFile(strFilePath, ArticleLocat);
                  insert_dic.Add("@ArticleDate", ArticleDate);
                  insert_dic.Add("@ArticleAuthor", ArticleAuthor);
                  insert_dic.Add("@ArticleInfo", ArticleInfo);
                  insert_dic.Add("@ArticleLocat", ArticleLocat);
                  insert_dic.Add("@ArticleState", "已导入");
                  if (true)return true;
                  else return false;
              }
              else return false;
          }*/
        
        static DateTime Date = new DateTime();
        static string Author = null;
        static string Title = null;
        static string Text = null;
        static byte[] Bin = null;

        public static bool ImportHtml(string strFilePath,out string reason)
        {
            if (!File.Exists(strFilePath))
            {
                reason = "文件不存在!";
                return false;
            }
            else
            {
                //处理传入文件的数据,进行网页文本导出,字符串分割对其,网页二进制文件导出的任务
                HtmlToText convert = new HtmlToText();
                Text = convert.Convert(System.IO.File.ReadAllText(strFilePath));
                string name = DirFile.GetFileNameNoExtension(strFilePath);
                string[] strArr = name.Split('_');
                if (strArr.Length >= 3)
                {
                    Author = strArr[0];
                    //将日期字符串转为日期对象并且赋值给静态日期类型
                    string[] stringdate = strArr[1].Split('-');
                    int intyear = int.Parse(stringdate[0]);
                    int intmon = int.Parse(stringdate[1]);
                    int intdate = int.Parse(stringdate[2]);
                    DateTime date1 = new DateTime(intyear, intmon, intdate);
                    Date = date1;
                    //赋值标题
                    Title = strArr[2];
                    //赋值正文文本
                    Text = new HtmlToText().Convert(System.IO.File.ReadAllText(strFilePath));
                    //赋值二进制文件
                    FileStream fs = new FileStream(strFilePath, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    Bin = r.ReadBytes((int)fs.Length);
                    fs.Dispose();
                    //判断数据库是否存在相同的文件
                    string surplus_sql = "select count(*) from Article where Date=@Date and Author=@Author and Title=@Title";
                    SqlParameter[] surplus_paras =
                       {
                    new SqlParameter("@Date", Date),
                    new SqlParameter("@Author", Author),
                    new SqlParameter("@Title", Title),
};
                    int surplus_flag = Convert.ToInt16(SqlHelper.ExecuteScalarText(surplus_sql, surplus_paras));
                    if (surplus_flag >= 1)
                    {
                        reason = "重复导入!";
                        return false;
                    }
                    else
                    {
                        //文件不重复,进行导入工作
                        if (Date != null && Author != null && Title != null && Text != null)
                        {
                            string insert_sql = "insert into Article (Date,Author,Title,Text,Bin) values(@Date,@Author,@Title,@Text,@Bin)";
                            SqlParameter[] insert_paras =
                            {
                                new SqlParameter("@Date", Date),
                                new SqlParameter("@Author", Author),
                                new SqlParameter("@Title", Title),
                                new SqlParameter("@Text", Text),
                                new SqlParameter("@Bin", Bin)
                            };
                            int insert_res = 0;
                            insert_res = SqlHelper.ExecteNonQueryText(insert_sql, insert_paras);
                            if (insert_res > 0)
                            {
                                reason = "导入成功!";
                                return true;
                            }
                            else
                            {
                                reason = "数据库写入失败";
                                return false;
                            }
                        }
                        else
                        {
                            reason = "文件格式不正确!";
                            return false;
                        }
                    }

                }
                else
                {
                    reason = "文件格式不正确!";
                    return false;
                }
                

            }


        }
        

/*        已经弃用
 *        把文件转成二进制流出入数据库

      
      string str = "insert into pro_table (pro_name,pro_file) values('测试文件',@file)";
        SqlCommand mycomm = new SqlCommand(str, myconn);
        mycomm.Parameters.Add("@file", SqlDbType.Binary, byData.Length);
      mycomm.Parameters["@file"].Value = byData;
      mycomm.ExecuteNonQuery();
      myconn.Close();
  
 
    //从数据库中把二进制流读出写入还原成文件
    
      string conn = "server=.;database=testDB;Uid=sa;Pwd=sa ";
        string str = "select pro_file from pro_table where pro_name='测试文件' ";
        SqlConnection myconn = new SqlConnection(conn);
        SqlDataAdapter sda = new SqlDataAdapter(str, conn);
        DataSet myds = new DataSet();
        myconn.Open();
      sda.Fill(myds);
      myconn.Close();
      Byte[] Files = (Byte[])myds.Tables[0].Rows[0]["pro_file"];
        BinaryWriter bw = new BinaryWriter(File.Open("D:\\2.rdlc", FileMode.OpenOrCreate));
        bw.Write(Files);
      bw.Close();*/
    }

}
