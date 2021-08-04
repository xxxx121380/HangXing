using System;
using System.Drawing;
using System.Windows.Forms;
using Hangxing.View;
using Sunny.UI;

namespace Hangxing
{
    public partial class Form_Main : UIForm
    {
        public Form_Main()
        {
            InitializeComponent();
            CreateTreeNode();
        }
        /// <summary>
        /// 创建左侧菜单节点
        /// </summary>
        private void CreateTreeNode()
        {
            int pageIndex = 1000;
            TreeNode parent1 = Aside.CreateNode("控制台", 22, pageIndex);
            TreeNode parent2 = Aside.CreateNode("数据库维护", 22, pageIndex);
            TreeNode parent3 = Aside.CreateNode("用户信息", 22, pageIndex);
            TreeNode parent4 = Aside.CreateNode("微信文章管理", 22, pageIndex);
            Aside.CreateChildNode(parent4, "微信文章1", ++pageIndex);
            Aside.CreateChildNode(parent4, "微信文章2", ++pageIndex);
            Aside.CreateChildNode(parent4, "微信文章3", ++pageIndex);
            TreeNode parent5 = Aside.CreateNode("视频管理", 22, pageIndex);
            Aside.CreateChildNode(parent5, "视频文章1", ++pageIndex);
            Aside.CreateChildNode(parent5, "视频文章2", ++pageIndex);
            Aside.CreateChildNode(parent5, "视频文章3", ++pageIndex);
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
                    case "控制台":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_ControlTab));
                        break;
                    case "数据库维护":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_DataBase));
                        break;
                    case "用户信息":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_UserInformation));
                        break;
                    case "微信文章1":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Wechat1));
                        break;
                    case "微信文章2":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Wechat2));
                        break;
                    case "微信文章3":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Wechat3));
                        break;
                    case "视频文章1":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Video1));
                        break;
                    case "视频文章2":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Video2));
                        break;
                    case "视频文章3":
                        LoadMdiForm(MainTabControl, menuText, typeof(Form_Video3));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
