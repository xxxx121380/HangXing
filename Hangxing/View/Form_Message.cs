using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.IO;
using System.Data.SqlClient;
using Common.Utility;
using System.Text.RegularExpressions;
using SharpCompress.Common;
using static System.Net.WebRequestMethods;

namespace Hangxing.View
{
    public partial class Form_Message : UIPage
    {
        public Form_Message()
        {
            InitializeComponent();
        }

        private void ubtInsert_Click(object sender, EventArgs e)
        {
            //弹出对话框选择文件
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;//等于true表示可以选择多个文件
            dlg.Title = "请选择需要导入的文件";
            dlg.Filter = "网页|*.html";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int count1 = 0;//用于成功的数量记录
                int count2 = 0;//用于失败的数量记录
                List<string> faillog=new List<string>();//导入失败的情况的日志
                foreach (string file in dlg.FileNames)
                {
                    bool flag = Regex.IsMatch(DirFile.GetFileName(file), @"^[\u4E00-\u9FA5A-Za-z0-9]+_\d{4}-\d{2}-\d{2}_[^\x22\n*\r]+$");//判断文件是否符合规范格式
                    if (flag)
                    {
                        string reason = null;
                        if (ImportFile.ImportHtml(file, out reason))
                        {
                            Form_Main.ShowInfo("【" + DirFile.GetFileName(file) + "】导入成功!");
                            count1++;
                        }
                        else
                        {
                            Form_Main.ShowInfo("【" + DirFile.GetFileName(file) + "】导入失败!" + "原因:" + reason);
                            count2++;
                            faillog.Add("【" + DirFile.GetFileName(file) + "】导入失败!" + "原因:" + reason);
                        }

                    }
                    else
                    {
                        Form_Main.ShowInfo("【" + DirFile.GetFileName(file) + "】导入的文件名格式不规范,正确的文件名格式为:公众号名称_yy-mm-dd_文章标题");
                        count2++;
                        faillog.Add("【" + DirFile.GetFileName(file) + "】导入的文件名格式不规范");
                    }
                }
                Form_Main.ShowInfo("本次导入成功"+count1+"个，失败"+count2+"个。");
                //如果失败的数量不为0,且需要打印失败日志
                if(count2!=0&& UIMessageBox.Show("检测到有导出失败,是否打印失败日志?", "打印日志", UIStyle.Red, UIMessageBoxButtons.OKCancel, true, true))
                {
                    List<string> faillogname = new List<string>();
                    for(int i=0;i<faillog.Count;i++)
                    {
                        faillogname.Add(SystemLog.WriteLogLine(faillog[i],SystemLog.pathfail));
                    }
                    if(UIMessageBox.Show("失败日志打印成功,是否打开?", "打印日志", UIStyle.Red, UIMessageBoxButtons.OKCancel, true, true))
                    {
                        for (int i = 0; i < faillog.Count; i++)
                        {
                            System.Diagnostics.Process.Start("explorer.exe", faillogname[i]);
                        }
                    }

                }

                    
            }
        }

        private void uiRadioButtonGroup1_ValueChanged(object sender, int index, string text)
        {

        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
