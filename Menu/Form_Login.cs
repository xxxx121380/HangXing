using System;
using System.Windows.Forms;
using System.Drawing;
using Sunny.UI;
using Hangxing;
using System.Data.SqlClient;
namespace Hangxing
{
    public partial class Form_Login : UIForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出系统?", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtUser.ForeColor == Color.Gray || edtPassword.ForeColor == Color.Gray)
            {
                MessageBox.Show("用户名或密码为空，请重新输入！");
            }
            else
            {
                string name = this.edtUser.Text;
                string password = this.edtPassword.Text;
                string sql= "select * from Admins where AUid='" + name + "' and Apassword='" + password + "'";
                
            }
            DataBaseCon.testdata();
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
    }
}
