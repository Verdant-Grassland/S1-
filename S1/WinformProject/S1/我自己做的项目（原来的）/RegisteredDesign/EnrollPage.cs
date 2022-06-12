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

namespace RegisteredDesign
{
    public partial class EnrollPage : Form
    {
        public EnrollPage()
        {
            InitializeComponent();
        }

        public bool CheckUsernameUnique(string PeoLogin)
        {
            string sql = "Select count(*) from PeopleTable where PeoLogin = " + PeoLogin;
            return sql == null;
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            if (Check()) 
            {
                // 检查用户名是否已存在
                string sql1 = "Select count(*) from PeopleTable  where PeoLogin = '" + UserName.Text + "'";
                int count = DBHelper.DoNonQuery(sql1);
                if (count <= 0)
                {
                    // 注册账号
                    string sql2 = @"Insert into PeopleTable(Peologin,PeoPwd) Values('" + UserName.Text + "', '" + PwdBox.Text + "')";
                    int result = DBHelper.DoNonQuery(sql2);
                    if (result > 0)
                    {
                        MessageBox.Show("注册成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginPage login = new LoginPage();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("注册失败，未知异常", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("用户名已存在，请重新用户名！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        public bool Check()
        {
            if (UserName.Text == "")
            {
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserName.Focus();
                return false;
            }
            else if (PwdBox.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PwdBox.Focus();
                return false;
            }
            else if (RepeatPwdBox.Text == "")
            {
                MessageBox.Show("确定密码不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RepeatPwdBox.Focus();
                return false;
            }
            else if (PwdBox.Text != RepeatPwdBox.Text)
            {
                MessageBox.Show("密码不一致，请重新确定密码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (PwdBox.Text.Length < 6)
            {
                MessageBox.Show("密码长度不能少于6位", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PwdBox.Focus();
                return false;
            }
            else if (RepeatPwdBox.Text.Length < 6)
            {
                MessageBox.Show("确定密码长度不能少于6位", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RepeatPwdBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}
