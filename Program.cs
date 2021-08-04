using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangxing
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        
        public static DataBase HangxingDB = new DataBase("DESKTOP-9HOLRJI", "sa", "123456");

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}
