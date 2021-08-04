using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Hangxing
{
    public class DBHelper
    {
        //连接字符串
        private static readonly string Constr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        SqlConnection conn = null;
        //执行T-Sql，返回受影响的行数 int CommandType
        public static int ExecuteNonQuery(string sql, int cmdType, params SqlParameter[] paras)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(Constr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                { 
                    cmd.CommandType = CommandType.StoredProcedure; 
                }
                if(paras!=null && paras.Length>0)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                count=cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return count;
        }
        //执行查询，返回第一行、第一列的值，忽略其他行或者列，返回object
        public static object ExecuteScalar(string sql, int cmdType, params SqlParameter[] paras)
        {
            object o = null;
            using (SqlConnection conn = new SqlConnection(Constr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (paras != null && paras.Length > 0)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                o = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return o;
        }
        //执行查询，生成SqlDataReader
        public static SqlDataReader ExecuteReader(string sql, int cmdType, params SqlParameter[] paras)
        {
            SqlDataReader dr = null;
            SqlConnection conn = new SqlConnection(Constr);
            SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (paras != null && paras.Length > 0)
                {
                    cmd.Parameters.AddRange(paras);
                }
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                conn.Close();
                throw new Exception("执行查询异常", ex);
            }
            return dr;
        }
        /// <summary>
        /// 填充DataSet 一个或多个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, int cmdType, params SqlParameter[] paras)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(Constr))
            {
               
                SqlCommand cmd = new SqlCommand(sql, conn);
                if(cmdType==2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (paras != null && paras.Length > 0)
                {
                    cmd.Parameters.AddRange(paras);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            return ds;
        }
        /// <summary>
        /// 填充dataTable 一个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, int cmdType, params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Constr))
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmdType == 2)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (paras != null && paras.Length > 0)
                {
                    cmd.Parameters.AddRange(paras);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

    }
}
