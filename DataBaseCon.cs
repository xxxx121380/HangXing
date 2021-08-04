using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hangxing
{
    class DataBaseCon
    {
        private static string MySqlCon ="Data Source=DESKTOP-9HOLRJI;Initial Catalog = Hangxing; Integrated Security = True";
        public static SqlConnection con= new SqlConnection(@MySqlCon);
        public static SqlCommand cmd = new SqlCommand();
        public DataTable ExecuteQuery(string sqlStr)      
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            DataTable dt = new DataTable();
            SqlDataAdapter msda;
            msda = new SqlDataAdapter(cmd);
            msda.Fill(dt);
            con.Close();
            return dt;
        }
        public int ExecuteUpdate(string sqlStr)      //用于增删改;
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            int iud = 0;
            iud = cmd.ExecuteNonQuery();
            con.Close();
            return iud;
        }
        
        //测试数据库是否连接成功
          public static void testdata()
        {
            try
            {
                SqlConnection conn = new SqlConnection(MySqlCon);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！");
                }
            }
            catch
            {
                MessageBox.Show("失败！");
            }
        }

    }
}
