using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Common.Utility;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hangxing
{
    public partial class Form_Register : UIForm
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fmLogin fl  = new fmLogin();
            fl.Show();
            this.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region
            //已经弃用

            /*//查询数据库是否有重复用户名
            SqlCon sh = new SqlCon();
            string sel = "select * from Users where UserName=@UserName";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserName", edtUser.Text);
            ArrayList al = sh.SelectInfo(sel, dic);
            int flag=0;
            if(al==null)
            {
                flag = 0;
            }
            if(al!=null)
            {
                flag = al.Count;
            }

            if (edtUser.Text.Trim() == "" || edtPassword.Text.Trim() == "" || edtPassword2.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不得为空！", "提示", MessageBoxButtons.OK);
            }
            else if (edtPassword.Text != edtPassword2.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "提示", MessageBoxButtons.OK);
            }
            else if (flag==1)
            {
                MessageBox.Show("用户名已经存在！", "提示", MessageBoxButtons.OK);
                al.Clear();
            }
            
            else if (flag == 0 && edtPassword.Text == edtPassword2.Text)
            {
                SqlCon insert_sh = new SqlCon();
                Dictionary<string, string> insert_dic = new Dictionary<string, string>();
                string insert_sql = "insert into Users (UserName,UserPassword) values(@UserName,@UserPassword)"; //放置占位符
                insert_dic.Add("@UserName",edtUser.Text);    //将其放入字典（类似JSON，采用键值对的方式传递）
                insert_dic.Add("@UserPassword",edtPassword.Text);
                if (insert_sh.SqlPour(insert_sql, insert_dic)) 
                { 
                    MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK);
                    fmLogin fl = new fmLogin();
                    fl.Show();
                    this.Visible = false;
                }
            }*/
            #endregion
            //查询数据库是否有重复用户名

            string sel = "select count(*) from Users where UserName=@UserName";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName", edtUser.Text),
            };
            int flag = Convert.ToInt16(SqlHelper.ExecuteScalar(SqlHelper.connectionString, System.Data.CommandType.Text, sel, paras));

            if (edtUser.Text.Trim() == "" || edtPassword.Text.Trim() == "" || edtPassword2.Text.Trim() == "")
            {
                UIMessageTip.ShowError("用户名或密码不得为空！", 2000, true);
            }
            else if (edtPassword.Text != edtPassword2.Text)
            {
                UIMessageTip.ShowError("两次输入的密码不一致！", 2000, true);
            }
            else if (flag == 1)
            {
                UIMessageTip.ShowError("用户名已经存在！", 2000, true);
            }

            else if (flag == 0 && edtPassword.Text == edtPassword2.Text)
            {
                string insert_sql = "insert into Users (UserName,UserPassword) values(@UserName,@UserPassword)";
                SqlParameter[] paras1 =
           {
                new SqlParameter("@UserName", edtUser.Text),
                new SqlParameter("@UserPassword", edtPassword.Text)
            };
                int res=SqlHelper.ExecteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text, insert_sql, paras1);
                if (res==1)
                {
                    UIMessageTip.ShowError("注册成功", 2000, true);
                    fmLogin fl = new fmLogin();
                    fl.Show();
                    this.Visible = false;
                }
            }

        }
    }
}