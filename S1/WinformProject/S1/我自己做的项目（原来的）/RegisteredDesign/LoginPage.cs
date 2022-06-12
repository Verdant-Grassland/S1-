using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteredDesign
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Check()) 
            {
                string sql = "Select count(*) from PeopleTable where PeoLogin = '" + UserNameLogin.Text + "' and PeoPwd ='" + PwdBox.Text + "'";
                int count = Convert.ToInt32(DBHelper.DoScalar(sql));
                // 没有账号
                if (count <= 0)
                {
                    MessageBox.Show("您还没有账号， 请先注册", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnrollPage page = new EnrollPage();
                    page.Show();
                    this.Hide();
                }
                else if (count == 0)
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("登录成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManationDesignPage manation = new ManationDesignPage();
                    manation.Show();
                    this.Hide();
                }
            }
        }

        public bool Check()
        {
            if (UserNameLogin.Text == "")
            {
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserNameLogin.Focus();
                return false;
            }
            else if (PwdBox.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PwdBox.Focus();
                return false;
            }
            else if (PwdBox.Text.Length < 6)
            {
                MessageBox.Show("密码长度不能少于6位", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PwdBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            EnrollPage enroll = new EnrollPage();
            enroll.Show();
            this.Hide();
        }

        private void EnrollLink_Click(object sender, EventArgs e)
        {
            EnrollPage enroll = new EnrollPage();
            enroll.Show();
            this.Hide();
        }
    }
}
