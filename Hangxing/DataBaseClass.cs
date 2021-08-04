using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace Hangxing
{
    ///看看能不能提交
    /// <summary>
    /// 定义数据库操作类,用于查询和操作本地数据信息
    /// 示例：DataBase newDataBase3 = new DataBase("newDataBase3", "sa", "12345");
    /// </summary>
    public class DataBase
    {
        private string DBName = "";             // 数据库名称
        private string UserName = "";           // 数据库用户名
        private string Password = "";           // 数据库密码

        public bool isInitSuccess = false;      // 记录指定的数据库是否可以连接成功

        public string connectionString = "";       // 当前数据库连接串
        public string connectionString_master = "";// 连接到master数据库的连接串

        /// <summary>
        /// 创建指定数据库操作对象
        /// </summary>
        /// <param name="DBName">数据库名称</param>
        /// <param name="UserName">数据库用户名</param>
        /// <param name="Password">数据库密码</param>
        public DataBase(string DBName, string UserName, string Password)
        {
            if (DBName == null || DBName.Equals("") || UserName == null || UserName.Equals("") || Password == null || Password.Equals(""))
            {
                throw new Exception("DataBase()参数不可为空");
            }

            this.DBName = DBName;
            this.UserName = UserName;
            this.Password = Password;

            connectionString = DataBaseTool.getConnectString(DBName, UserName, Password);
            connectionString_master = DataBaseTool.getConnectString("", UserName, Password);

            //if (this.DBName != null && !this.DBName.Equals("") && !this.DBName.Equals("master"))
            {
                if (!DataBaseTool.Exist(DBName, connectionString_master))  // 判断数据库是否存在，若不存在则创建数据库
                {
                    isInitSuccess = DataBaseTool.Create(DBName, connectionString_master);
                }
                else isInitSuccess = true;
            }
        }

        /// <summary>
        /// 执行sql命令
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public ExecuteResult Execute(string sql)
        {
            return DataBaseTool.Execute(sql, connectionString);
        }

        /// <summary>
        /// 所有数据库名称
        /// </summary>
        public List<String> DataBaseNames()
        {
            return DataBaseTool.DataBaseNames(connectionString_master);
        }

        /// <summary>
        /// 当前数据中，所有表名称
        /// </summary>
        public List<String> TableNames()
        {
            string sql = "select name from sysobjects where xtype='U'";
            List<string> list = Execute(sql).ColmnList("name");

            return list;
        }

        /// <summary>
        /// 删除指定的数据库
        /// </summary>
        public bool DeletDataBase(string DataBaseName)
        {
            if (DataBaseName == null || DataBaseName.Equals("")) DataBaseName = DBName;
            return DataBaseTool.Delet(DataBaseName, connectionString_master);
        }


        #region 数据库表操作

        /// <summary>
        /// 判断当前数据库中，是否存在指定名称的表
        /// </summary>
        /// <param name="TAB">表名称</param>
        public bool ExistTab(string TAB)
        {
            return DataBaseTool.ExistTab(TAB, connectionString);
        }

        /// <summary>
        /// 在当前数据库中创建数据表
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="Colums">所有列名称</param>
        public bool CreateTable(String TAB, List<string> Colums)
        {
            if (Colums.Count == 0) Colums = new String[] { "KEY", "VALUE" }.ToList();  // 未指定列名称时，默认添加KEY、VALUE两列

            Dictionary<string, int> ColumnInfo = new Dictionary<string, int>();
            foreach (string col in Colums)
            {
                ColumnInfo.Add(col, 100);
            }
            //ColumnInfo.Add("EXT", 300);     // 默认添加一个拓展字段列

            return DataBaseTool.CreateTable(TAB, ColumnInfo, connectionString);
        }

        /// <summary>
        /// 在当前数据库中创建数据表
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="ColumnInfo">所有列信息</param>
        /// <returns></returns>
        public bool CreateTable(String TAB, Dictionary<string, int> ColumnInfo)
        {
            return DataBaseTool.CreateTable(TAB, ColumnInfo, connectionString);
        }

        /// <summary>
        /// 删除当前数据库中的TAB表
        /// </summary>
        public bool DeletTable(String TAB)
        {
            return DataBaseTool.DeletTable(TAB, connectionString);
        }

        /// <summary>
        /// 向表中插入新的数据
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="values">列数据</param>
        /// <returns>新生成的数据行ID</returns>
        public string InsetValue(string TAB, List<string> values)
        {
            return DataBaseTool.InsetValue(TAB, values, connectionString);
        }

        /// <summary>
        /// 删除TAB表中，KeyName为KeyValue的所有行
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="KeyValue">键值</param>
        /// <param name="KeyName">键名称</param>
        /// <returns></returns>
        public bool DeletValue(string TAB, string KeyValue, string KeyName = "ID")
        {
            return DataBaseTool.DeletValue(TAB, KeyValue, connectionString, KeyName);
        }

        /// <summary>
        /// 修改TAB表所有标签为KEY的所有数据
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="KeyValue">主键值</param>
        /// <param name="datas">待修改的数据信息</param>
        /// <param name="connectionString"></param>
        /// <param name="KeyName">主键名称</param>
        /// <returns></returns>
        public string UpdateValue(string TAB, string KeyValue, Dictionary<string, string> datas, string KeyName = "ID", string AppendCondition = "")
        {
            return DataBaseTool.UpdateValue(TAB, KeyValue, datas, connectionString, KeyName, AppendCondition);
        }


        //"select * from [Order] where isSuccess='True' and ext like '%author(test852)%'
        //string AppendCondition = "and ext like '%" + "author(" + Author + ")" + "%' ";
        /// <summary>
        /// 查询TAB表,KeyName为KeyValue的所有数据项
        /// </summary>
        /// <param name="TAB"></param>
        /// <param name="KeyValue"></param>
        /// <param name="connectionString"></param>
        /// <param name="KeyName"></param>
        /// <param name="columns">查询结果包含指定的列</param>
        /// <param name="ortherConditions">其他查询条件</param>
        /// <returns></returns>
        public ExecuteResult SelectValue(string TAB, string KeyValue, string KeyName = "ID", List<string> columns = null, Dictionary<string, string> ortherConditions = null, string AppendCondition = "")
        {
            return DataBaseTool.SelectValue(TAB, KeyValue, connectionString, KeyName, columns, ortherConditions, AppendCondition);
        }

        /// <summary>
        /// 获取TAB表中指定列数据
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public List<string> ColumnList(string TAB, string columnName)
        {
            List<string> list = SelectValue(TAB, "", "", new string[] { columnName }.ToList()).ColmnList();
            return list;
        }

        #endregion

    }


    /// <summary>
    /// 数据库Execute结果对象，将数据库Execute执行结果，转换为指定的数据格式
    /// </summary>
    public class ExecuteResult
    {
        SqlDataReader reader = null;
        SqlConnection connection = null;
        String ErrorInfo = "";

        public ExecuteResult(String ErrorInfo)
        {
            this.ErrorInfo = ErrorInfo;
        }

        /// <summary>
        /// 创建Result结果集对象
        /// </summary>
        /// <param name="reader"></param>
        public ExecuteResult(SqlDataReader reader, SqlConnection connection)
        {
            this.reader = reader;
            this.connection = connection;
        }

        /// <summary>
        /// SqlDataReader结果集
        /// </summary>
        /// <returns></returns>
        public SqlDataReader DataReader()
        {
            return reader;
        }

        /// <summary>
        /// Execute是否执行成功
        /// </summary>
        public bool Success()
        {
            bool result = (reader != null);

            if (reader != null) reader.Close();
            if (connection != null) connection.Close();

            return result;
        }

        /// <summary>
        /// Json字符串结果集
        /// </summary>
        public string ToString()
        {
            return ToJson(reader, connection);
        }

        /// <summary>
        /// 按列名称存储Dic结果集，包含所有列
        /// </summary>
        public Dictionary<String, List<String>> ColmnDictionary()
        {
            return ToColmnDictionary(reader, connection);
        }

        /// <summary>
        /// 获取列结果集合，clumnName列的所有数据
        /// </summary>
        /// <param name="columnName">列名称</param>
        public List<String> ColmnList(string columnName)
        {
            Dictionary<String, List<String>> Dic = ColmnDictionary();
            if (Dic.ContainsKey(columnName)) return Dic[columnName];
            else return new List<string>();
        }

        /// <summary>
        /// 获取列结果集合，index列的所有数据
        /// </summary>
        /// <param name="index">列索引值</param>
        public List<String> ColmnList(int index = 0)
        {
            Dictionary<String, List<String>> Dic = ColmnDictionary();
            List<String> Keys = Dic.Keys.ToList();
            if (index < Keys.Count)
            {
                string key = Keys[index];
                return Dic[key];
            }
            else return new List<string>();
        }

        /// <summary>
        /// 获取查询结果集的首个数据，第一列、第一行
        /// 无返回空串""
        /// </summary>
        public String FirstData()
        {
            List<String> list = ColmnList();
            if (list.Count == 0) return "";
            else return list[0];
        }

        /// <summary>
        /// 按行存储的Dic结果集,包含所有行
        /// </summary>
        public List<Dictionary<String, String>> RowList()
        {
            return ToRowList(reader, connection);
        }

        /// <summary>
        /// 按行存储的Dic结果集,获取第index行的数据。
        /// 默认获取第一项，index==-2时 获取最后一项
        /// </summary>
        public Dictionary<String, String> RowDic(int index = 0)
        {
            List<Dictionary<String, String>> Rows = RowList();

            if (index == -2 && Rows.Count > 0) return Rows[Rows.Count - 1];
            if (Rows.Count > index) return Rows[index];
            else return new Dictionary<string, string>();
        }

        /// <summary>
        /// Table对象结果集
        /// </summary>
        public Table Table()
        {
            return ToTable(reader, connection);
        }

        //----------------

        #region dataReader数据转换处理逻辑

        /// <summary>
        /// DataReader转换为Json串
        /// </summary>
        public static string ToJson(SqlDataReader dataReader, SqlConnection connection = null)
        {
            StringBuilder Builder = new StringBuilder();
            int rows = 0;

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    if (rows++ > 0) Builder.Append(",");

                    // 行数据转Json
                    Builder.Append("{");
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        if (i > 0) Builder.Append(",");

                        // 列名称
                        string strKey = dataReader.GetName(i);
                        strKey = "\"" + strKey + "\"";

                        // 列数据
                        Type type = dataReader.GetFieldType(i);
                        string strValue = dataReader[i].ToString();
                        strValue = String.Format(strValue, type).Trim();
                        if (type == typeof(string) || type == typeof(DateTime)) strValue = "\"" + strValue + "\"";

                        Builder.Append(strKey + ":" + strValue);
                    }
                    Builder.Append("}");
                }

                dataReader.Close();
            }
            if (connection != null) connection.Close();

            if (rows > 1) return "[" + Builder.ToString() + "]";
            else return Builder.ToString();
        }


        /// <summary>
        /// DataReader，转换为列名称标识的list数据
        /// </summary>
        public static Dictionary<String, List<String>> ToColmnDictionary(SqlDataReader dataReader, SqlConnection connection = null)
        {
            Dictionary<String, List<String>> Dic = new Dictionary<string, List<string>>();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    // 行数据转Json
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        // 列名称
                        string strKey = dataReader.GetName(i);

                        List<String> list = null;
                        if (!Dic.ContainsKey(strKey))
                        {
                            list = new List<string>();  // 生成新的list
                            Dic.Add(strKey, list);
                        }
                        else list = Dic[strKey];        // 获取列名对应的list

                        // 列数据
                        Type type = dataReader.GetFieldType(i);
                        string strValue = dataReader[i].ToString();
                        strValue = String.Format(strValue, type).Trim();

                        list.Add(strValue);
                    }
                }
                dataReader.Close();
            }
            if (connection != null) connection.Close();

            return Dic;
        }

        /// <summary>
        /// DataReader按行，转换为列List数据
        /// </summary>
        public static List<Dictionary<String, String>> ToRowList(SqlDataReader dataReader, SqlConnection connection = null)
        {
            List<Dictionary<String, String>> list = new List<Dictionary<string, string>>();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Dictionary<String, String> Dic = new Dictionary<string, string>();

                    // 行数据转Json
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        // 列名称
                        string strKey = dataReader.GetName(i);

                        // 列数据
                        Type type = dataReader.GetFieldType(i);
                        string strValue = dataReader[i].ToString();
                        strValue = String.Format(strValue, type).Trim();

                        Dic.Add(strKey, strValue);
                    }

                    list.Add(Dic);
                }
                dataReader.Close();
            }
            if (connection != null) connection.Close();

            return list;
        }

        /// <summary>
        /// DataReader转换为Table表
        /// </summary>
        public static Table ToTable(SqlDataReader dataReader, SqlConnection connection = null)
        {
            Table table = new Table();
            table.Attributes.Add("border", "1");    // 添加边框线
            table.Attributes.Add("BorderStyle", "Solid");
            table.Attributes.Add("width", "100%");  // 表格宽度
            table.Attributes.Add("cellspacing", "0");
            table.Attributes.Add("bordercolor", "DarkGray");

            TableHeaderRow header = new TableHeaderRow();

            bool firstrow = true;
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    try
                    {
                        TableRow row = new TableRow();

                        // 行数据转Json
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            // Tab表头
                            if (firstrow)
                            {
                                string strKey = dataReader.GetName(i);  // 列名称

                                TableHeaderCell headCell = new TableHeaderCell();
                                headCell.Text = strKey;

                                header.Cells.Add(headCell);
                            }

                            // Tab行数据
                            Type type = dataReader.GetFieldType(i);
                            string strValue = dataReader[i].ToString();
                            strValue = String.Format(strValue, type).Trim();

                            TableCell cell = new TableCell();
                            cell.Text = strValue;

                            row.Cells.Add(cell);
                        }

                        if (firstrow)
                        {
                            table.Rows.Add(header);
                            firstrow = false;
                        }
                        table.Rows.Add(row);
                    }
                    catch (Exception ex)
                    {

                    }
                }

                dataReader.Close();
            }

            if (connection != null) connection.Close();

            return table;
        }

        #endregion

    }

    /// <summary>
    /// 数据库静态操作函数
    /// </summary>
    public class DataBaseTool
    {
        /// <summary>
        /// 获取数据库的连接字符串
        /// </summary>
        /// <param name="DBName">数据库名称</param>
        /// <param name="UserName">用户名称</param>
        /// <param name="Password">密码</param>
        public static string getConnectString(string DBName, string UserName, string Password)
        {
            if (DBName == null || DBName.Equals("")) DBName = "master";

            if (UserName == null || UserName.Equals("")) return "UserName不可为空";
            if (Password == null || Password.Equals("")) return "Password不可为空";

            string connectionString = @"Data Source=.\JSQL2008;Initial Catalog=" + DBName + ";User ID=" + UserName + ";Password=" + Password + ""; // 连接本地数据库DBName
                                                                                                                                                   // connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\NoteBook.mdf;Integrated Security=True;User Instance=True";  // 连接附加数据库
                                                                                                                                                   // connectionString = @"Data Source=.\JSQL2008;Initial Catalog=DataBase1;User ID=sa;Password=12345"; // 连接本地数据库DataBase1

            return connectionString;
        }

        // 1、----------

        /// <summary>
        /// 连接数据库,执行sql语句
        /// </summary>
        public static ExecuteResult Execute(string queryString, string connectionString)
        {
            try
            {
                //string queryString =  "SELECT * FROM 数据表1";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();

                ExecuteResult result = new ExecuteResult(reader, connection);

                //String jsonData = ToJson(reader);   // 转化为Json数据
                //if (jsonData.Trim().Equals("")) jsonData = "success";

                //connection.Close();

                return result;
            }
            catch (Exception ex)
            {
                return new ExecuteResult(ex.ToString());
            }
        }


        /// <summary>
        /// 获取dic的指定列
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static List<String> getList(Dictionary<String, List<String>> dic, int index)
        {
            List<String> list = new List<string>();
            if (dic != null && dic.Count > 0 && 0 <= index && index < dic.Count)
            {
                List<string> keys = dic.Keys.ToList<string>();
                String key = keys[index];

                list = dic[key];
            }
            return list;
        }

        //----------

        /// <summary>
        /// 判断指定的数据库是否存在
        /// </summary>
        /// <param name="DataBaseName">数据库名称</param>
        public static bool Exist(string DataBaseName, string connectString)
        {
            string sql = "select count(*) From master.dbo.sysdatabases where name='" + DataBaseName + "'";
            String result = Execute(sql, connectString).ToString();

            return (!result.Equals("{\"\":0}") && !result.Equals("fail"));
        }

        /// <summary>
        /// 创建指定名称的数据库
        /// </summary>
        /// <param name="DataBaseName">数据库名称</param>
        public static bool Create(string DataBaseName, string connectionString)
        {
            string sql = "CREATE DATABASE \"" + DataBaseName + "\"";
            return Execute(sql, connectionString).Success();
        }

        /// <summary>
        /// 获取取所有数据库名称
        /// </summary>
        public static List<string> DataBaseNames(string connectionString)
        {
            string sql = "select name From master.dbo.sysdatabases";
            List<string> list = Execute(sql, connectionString).ColmnList(); ;

            return list;
        }

        /// <summary>
        /// 删除指定的数据库
        /// </summary>
        public static bool Delet(string DataBaseName, string connectionString)
        {
            string sql = "DROP DATABASE  \"" + DataBaseName + "\"";
            return Execute(sql, connectionString).Success();
        }


        #region 数据库表操作

        /// <summary>
        /// 判断数据库中是否存在指定名称的表
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="connectionString">数据库连接串</param>
        /// <returns></returns>
        public static Boolean ExistTab(string TAB, string connectionString)
        {
            // 查询表是否存在： select name from sys.tables where name='数据表1'
            String sql = "select name from sys.tables where name='" + TAB + "'";
            String name = Execute(sql, connectionString).FirstData();

            return (name.Equals(TAB));
        }

        /// <summary>
        /// 创建指定名称的表
        /// </summary>
        /// <param name="TAB">数据表名称</param>
        /// <param name="ColumnInfo">列名称，列长度信息</param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static bool CreateTable(String TAB, Dictionary<string, int> ColumnInfo, string connectionString)
        {
            //if (ExistTab(TAB, connectionString)) return true;   // 若已存在数据表，则无需再创建

            //CREATE TABLE [dbo].[Log_All]
            //(
            //    [ID] INT NOT NULL PRIMARY KEY IDENTITY(100,1), 
            //    [日期] NCHAR(30) NULL, 
            //    [信息] NCHAR(300) NULL
            //)

            // 生成数据表sql命令
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("CREATE TABLE [dbo].[" + TAB + "] ");
            builder.AppendLine("( ");
            builder.AppendLine("    [ID] INT NOT NULL PRIMARY KEY IDENTITY(100,1),  "); // 添加主键ID为自增，从100开始
            foreach (string key in ColumnInfo.Keys)
            {
                string Name = key.Trim();
                int Len = ColumnInfo[key];
                builder.AppendLine("    [" + Name + "] NCHAR(" + Len + ") NULL,  ");
            }
            builder.AppendLine(") ");

            // 执行
            String sql = builder.ToString();
            return Execute(sql, connectionString).Success();
        }

        /// <summary>
        /// 删除当前数据库中的TAB表
        /// </summary>
        public static bool DeletTable(String TAB, string connectionString)
        {
            string sql = "DROP TABLE \"" + TAB + "\"";
            return Execute(sql, connectionString).Success();
        }

        /// <summary>
        /// 向表中插入新的数据
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="values">列数据</param>
        /// <returns>新生成的数据行ID</returns>
        public static string InsetValue(string TAB, List<string> values, string connectionString)
        {
            //if (!ExistTab(TAB, connectionString)) return "fail";    // 若无数据表，则插入数据失败

            //insert into Log_All(日期, 信息) Values('日期1', '信息1')
            //insert into Log_All(日期, 信息) output inserted.id Values('日期4', '信息4')   
            //insert into Log_All output inserted.id Values('日期x', '信息x')

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("insert into  [dbo].[" + TAB + "] output inserted.id Values");
            builder.AppendLine("( ");
            bool isfirst = true;
            foreach (string value in values)
            {
                builder.Append((isfirst ? "\r\n" : ", \r\n") + "'" + value + "'");
                isfirst = false;
            }
            builder.AppendLine(") ");

            String sql = builder.ToString();
            String data = Execute(sql, connectionString).FirstData();

            return data;
        }

        /// <summary>
        /// 删除TAB表中，KeyName主键值为KeyValue的所有数据项
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="Key">主键值</param>
        /// <returns></returns>
        public static bool DeletValue(string TAB, string KeyValue, string connectionString, string KeyName = "ID")
        {
            String sql = "delete from " + TAB + " where " + KeyName + "='" + KeyValue + "'"; ;
            return Execute(sql, connectionString).Success();
        }

        /// <summary>
        /// 修改TAB表所有标签为KEY的所有数据
        /// </summary>
        /// <param name="TAB">表名称</param>
        /// <param name="KeyValue">主键值</param>
        /// <param name="datas">待修改的数据信息</param>
        /// <param name="connectionString"></param>
        /// <param name="KeyName">主键名称</param>
        /// <returns></returns>
        public static string UpdateValue(string TAB, string KeyValue, Dictionary<string, string> datas, string connectionString, string KeyName = "ID", string AppendCondition = "")
        {
            // UPDATE Person SET Address = 'Zhongshan 23', City = 'Nanjing' WHERE LastName = 'Wilson'
            StringBuilder builder = new StringBuilder();
            bool isFirst = true;
            foreach (string key in datas.Keys)
            {
                builder.Append((isFirst ? " " : ", ") + key + " = " + "'" + datas[key] + "'");
                isFirst = false;
            }

            String sql = "update [" + TAB + "] set " + builder.ToString() + " where " + KeyName + "='" + KeyValue + "'" + " " + AppendCondition;
            String data = Execute(sql, connectionString).Success() ? "success" : "fail";
            return data;
        }


        /// <summary>
        /// 查询TAB表,KeyName为KeyValue的所有数据项
        /// </summary>
        /// <param name="TAB"></param>
        /// <param name="KeyValue"></param>
        /// <param name="connectionString"></param>
        /// <param name="KeyName"></param>
        /// <param name="columns">查询结果包含指定的列</param>
        /// <param name="ortherConditions">其他查询条件</param>
        /// <returns></returns>
        public static ExecuteResult SelectValue(string TAB, string KeyValue, string connectionString, string KeyName = "ID", List<string> columns = null, Dictionary<string, string> ortherConditions = null, string AppendCondition = "")
        {
            string selectColumn = getColumnCondition(columns);
            string condition = getSeletCondition(ortherConditions);
            String sql = "select " + selectColumn + " from [" + TAB + "]" + (KeyName.Equals("") ? "" : " where " + KeyName + "='" + KeyValue + "'" + condition + " " + AppendCondition);

            return Execute(sql, connectionString);
        }

        /// <summary>
        /// 组合列名称条件paramList中的参数信息
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        private static string getColumnCondition(List<string> paramList = null)
        {
            string Condition = "*";
            if (paramList != null && paramList.Count > 0)
            {
                StringBuilder builder = new StringBuilder();
                bool isFirst = true;
                foreach (string key0 in paramList)
                {
                    string key = key0.Trim();
                    if (!key.Equals(""))
                    {
                        builder.Append((isFirst ? " " : ", ") + key);
                        isFirst = false;
                    }
                }
                Condition = builder.ToString();
                if (Condition.Trim().Equals("")) Condition = "*";
            }
            return Condition;
        }

        /// <summary>
        /// 组合查询条件ortherConditions中的参数信息
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        private static string getSeletCondition(Dictionary<string, string> ortherConditions = null)
        {
            string Condition = "";
            if (ortherConditions != null && ortherConditions.Count > 0)
            {
                StringBuilder builder = new StringBuilder();
                foreach (string key0 in ortherConditions.Keys)
                {
                    string key = key0.Trim();
                    if (!key.Equals(""))
                    {
                        builder.Append(" and " + key + "=" + "'" + ortherConditions[key] + "'");
                    }
                }
                Condition = builder.ToString();
            }
            return Condition;
        }

        #endregion

    }


}