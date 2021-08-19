using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using Common.Utility;
using Hangxing.View;
using Sunny.UI;

namespace Hangxing
{
    public partial class Form_Main : UIForm
    {
        public static Form_Main form_main;
        public Form_Main()
        {
            InitializeComponent();
            CreateTreeNode();
            form_main = this;
            Initial();
        }
 
        /// <summary>
        /// 窗口初始化
        /// </summary>
        public void Initial()
        {
            ShowInfo("程序初始化中.......");
            int count = -1;
            try
            {
                string countsql = "select count(*) from Article";
                SqlConnection con = new SqlConnection(SqlHelper.connectionString);
                SqlCommand cmd = new SqlCommand(countsql, con);
                con.Open();
                count = Convert.ToInt16(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (count >= 0)
                {
                    ShowInfo("数据库连接成功!");
                    ShowInfo("本地数据库共有" + count + "篇文章!");
                }
                else
                {
                    ShowInfo("数据库连接失败!,请检查连接字符串!");
                }
            }
        }
        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="txtInfo"></param>
        /// <param name="Info"></param>
        public static void ShowInfo(string Info)
        {
            form_main.txtInfo.AppendText(DateTime.Now.ToString()+":"+Info);
            form_main.txtInfo.AppendText(Environment.NewLine);
            form_main.txtInfo.ScrollToCaret();
            SystemLog.WriteLogLine(Info, SystemLog.pathlog);
        }
        /// <summary>
        /// 创建左侧菜单节点
        /// </summary>
        private void CreateTreeNode()
        {
            int pageIndex = 1000;
            TreeNode parent1 = Aside.CreateNode("首页", 22, pageIndex);
            TreeNode parent3 = Aside.CreateNode("用户信息", 22, pageIndex);
            TreeNode parent4 = Aside.CreateNode("文章管理", 22, pageIndex);
            TreeNode parent5 = Aside.CreateNode("视频管理", 22, pageIndex);
            //Aside.CreateChildNode(parent5, "视频1", ++pageIndex);
            Aside.SelectFirst();
        }
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="MainTabControl"></param>
        /// <param name="menuText"></param>
        /// <param name="formType"></param>
        /// <returns></returns>
        private Form LoadMdiForm(TabControl MainTabControl, string menuText, Type formType)
        {
            Form frm = (Form)Activator.CreateInstance(formType);
            frm.Text = menuText;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            TabPage sTabPag = new TabPage(menuText);
            sTabPag.Font = new Font("微软雅黑", 9F);
            sTabPag.Controls.Add(frm);
            MainTabControl.Controls.Add(sTabPag);
            MainTabControl.SelectedTab = sTabPag;
            frm.Show();
            return frm;
        }

        private void Aside_MenuItemClick_1(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (item != null)
            {
                string menuText = item.Text;
                foreach (TabPage tab in MainTabControl.TabPages)
                {
                    if (tab.Text == menuText)
                    {
                        MainTabControl.SelectedTab = tab;
                        return;
                    }
                }

                switch (menuText)
                {
                    case "首页":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Front));
                        break;
                    case "用户信息":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_User));
                        break;
                    case "文章管理":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Article));
                        break;
                    case "视频管理":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Video));
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            this.Visible = false;
            fl.Show();
        }

    }
}
