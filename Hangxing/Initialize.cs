using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangxing
{
    /// <summary>
    /// 应用程序初始化
    /// </summary>
    public static class Initialize
    {
        public static void Initial()
        {

        }
        
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="txtInfo"></param>
        /// <param name="Info"></param>
        public static void ShowInfo(System.Windows.Forms.TextBox txtInfo, string Info)
        {
            txtInfo.AppendText(Info);
            txtInfo.AppendText(Environment.NewLine);
            txtInfo.ScrollToCaret();
        }
    }
}
