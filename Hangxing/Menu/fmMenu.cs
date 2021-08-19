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
    public partial class fmMenu : UIHeaderAsideMainFrame
    {
        public static fmMenu fmmenu;
        public fmMenu()
        {
            InitializeComponent();
            CreateTreeNode();
            fmmenu = this;
            Initial();
        }
        /// <summary>
        /// 主界面初始化
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
                throw ex;
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

        private void exit(int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="Info"></param>
        public static void ShowInfo(string Info)
        {
            fmmenu.txtInfo.AppendText(DateTime.Now.ToString() + ":" + Info+ Environment.NewLine);
            //fmmenu.txtInfo.AppendText();
            fmmenu.txtInfo.ScrollToCaret();
            SystemLog.WriteLogLine(Info, SystemLog.pathlog);
        }
        private void CreateTreeNode()
        {
            //设置关联
            Aside.TabControl = MainTabControl;
            //创建左侧结点
            int pageIndex = 1000;
            TreeNode parent1 = Aside.CreateNode("首页", 22, ++pageIndex);
            AddPage(new fmFront(),pageIndex);
            TreeNode parent3 = Aside.CreateNode("声像档案管理", 22, ++pageIndex);
            AddPage(new fmPSData(), pageIndex);
            TreeNode parent4 = Aside.CreateNode("文章管理", 22, ++pageIndex);
            AddPage(new fmArticle(), pageIndex);
            TreeNode parent5 = Aside.CreateNode("视频管理", 22, ++pageIndex);
            AddPage(new fmVideo(), pageIndex);

            //增加孩子结点
            //Aside.CreateChildNode(parent5, "视频1", ++pageIndex);

            //显示默认界面
            Aside.SelectFirst();
        }

        private void fmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIMessageBox.Show("确定退出系统吗?", "退出确认", UIStyle.Red, UIMessageBoxButtons.OKCancel, true, true))
            {
                System.Environment.Exit(0);
            }
        }

        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
