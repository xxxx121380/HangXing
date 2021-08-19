using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangxing
{
    class FileTable
    {
          /// <summary>
          /// Upload files by FileTable
          /// </summary>
          /// <param name="strFilePath">the path of target file</param>
        public void UploadbyFileTable(string strFilePath)
        {
           if (!File.Exists(strFilePath))
                return;
            FileInfo file = new FileInfo(strFilePath);
            string strDBConnection =System.Configuration.ConfigurationManager.ConnectionStrings["strCon"].ToString();
            string strFileTableName = "FileTable";
            string strRootPath = GetFileTableRootPath(strDBConnection, strFileTableName);
            if (File.Exists(Path.Combine(strRootPath, file.Name)))
            {
                return;
            }
            file.MoveTo(Path.Combine(strRootPath, file.Name));
        }

        /// <summary>
        /// Get your Filetable's RootPath
        /// </summary>
        /// <param name="strDBConnection">your DB connection string</param>
        /// <param name="strFileTableName">your FileTable name</param>
        /// <returns>your Filetable's RootPath</returns>
        public string GetFileTableRootPath(string strDBConnection, string strFileTableName)
        {
            string strRootPath = string.Empty;
            try
            {
                SqlConnection sqlCon = new SqlConnection(strDBConnection);
                sqlCon.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("select FileTableRootPath('{0}') as [path]", strFileTableName);
                SqlCommand sqlCmd = new SqlCommand(sb.ToString(), sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                strRootPath = dt.Rows[0][0].ToString();
                sqlDa.Dispose();
                sqlCmd.Dispose();
                sqlCon.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return strRootPath;
        }
    }
}
