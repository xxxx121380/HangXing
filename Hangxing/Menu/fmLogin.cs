using System;
using System.Windows.Forms;
using System.Drawing;
using Sunny.UI;
using Hangxing;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using Common.Utility;
using Sunny.UI.Win32;

namespace Hangxing
{
    public partial class fmLogin : UIForm
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(UIMessageBox.Show("确定退出系统吗?","退出确认",UIStyle.Red,UIMessageBoxButtons.OKCancel,true,true))
            {
                System.Environment.Exit(0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region
            /*已弃用
             * SqlCon sh = new SqlCon();
            string sql = "select * from Users where UserName=@UserName and UserPassword=@UserPassword";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserName", edtUser.Text);
            dic.Add("@UserPassword", edtPassword.Text);
            ArrayList al = sh.SelectInfo(sql, dic);

            if (al!=null)
            {
                MessageBox.Show("登录成功！");
                Form_Menu fm = new Form_Menu();
                fm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！");
            }
            */
            #endregion
            string sql = "select * from Users where UserName=@UserName and UserPassword=@UserPassword";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName", edtUser.Text),
                new SqlParameter("@UserPassword", edtPassword.Text)
            };
            SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.connectionString, System.Data.CommandType.Text, sql, paras);
            if (dr.Read())
            {
                UIMessageTip.ShowOk("登录成功!",2000,true);
                fmMenu fm = new fmMenu();
                fm.Show();
                this.Visible = false;
            }
            else
            {
                UIMessageTip.ShowError("用户名或密码输入错误,请重新输入!",2000,true);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form_Register fr = new Form_Register();
            fr.Show();
            this.Visible = false;
        }

        private void edtUser_Enter(object sender, EventArgs e)
        {
            if (edtUser.Text.Trim() == "请输入用户名")
            {
                edtUser.Text = "";
                edtUser.ForeColor = Color.Black;
            }
        }

        private void edtUser_Leave(object sender, EventArgs e)
        {
            if (edtUser.Text.Trim() == "")
            {
                edtUser.Text = "请输入用户名";
                edtUser.ForeColor = Color.Gray;
            }
        }

        private void edtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                }
            }
        }

        private void edtPassword_Enter(object sender, EventArgs e)
        {
            if (edtPassword.Text.Trim() == "请输入密码")
            {
                edtPassword.Text = "";
                edtPassword.ForeColor = Color.Black;
                edtPassword.PasswordChar = '*';
            }
        }

        private void edtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                }
            }
        }

        private void edtPassword_Leave(object sender, EventArgs e)
        {
            if (edtPassword.Text.Trim() == "")
            {
                edtPassword.Text = "请输入密码";
                edtPassword.ForeColor = Color.Gray;
                edtPassword.PasswordChar = '\0';
            }
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
