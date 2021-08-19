using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangxing
{
    public class SystemLog
    {
        public static string pathlog=ConfigurationManager.AppSettings["LogPath"];
        public static string pathfail = ConfigurationManager.AppSettings["FailLogPath"];
        public static string WriteLogLine(string exceptionMessage,string path)
        {
            string logFileName = null;
            try
            {

            }
            catch (Exception)
            {
                path = @"c:\temp";
            }
            if (string.IsNullOrEmpty(path))
                path = @"c:\temp";
            try
            {
                //如果日志目录不存在,则创建该目录
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                logFileName = path + "\\日志_" + DateTime.Now.ToString("yyyy_MM_dd_HH") + ".log";
                StringBuilder logContents = new StringBuilder();
                logContents.AppendLine(exceptionMessage);
                //当天的日志文件不存在则新建，否则追加内容
                StreamWriter sw = new StreamWriter(logFileName, true, System.Text.Encoding.Unicode);
                sw.Write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:sss") + " " + logContents.ToString());
                sw.Flush();
                sw.Close();
                return logFileName;
            }
            catch (Exception)
            {
                return logFileName;
            }
        }
       
    }
}
