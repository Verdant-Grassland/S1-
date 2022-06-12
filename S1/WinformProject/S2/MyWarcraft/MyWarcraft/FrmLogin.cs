using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWarcraft
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public LoginInfo[] array;
        //用于存储登录用户的信息

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //初始三个用户信息
            array = new LoginInfo[10];
            LoginInfo info1 = new LoginInfo();
            info1.Name = "孙丽丽";
            info1.Id = "120185198005088521";
            info1.Email = "lili@sohu.com";
            info1.Password = "lili1980";
            array[0] = info1;
            LoginInfo info2 = new LoginInfo();
            info2.Name = "范晶晶";
            info2.Id = "110186198111088725";
            info2.Email = "jingjing@sina.com";
            info2.Password = "jingjing";
            array[1] = info2;
            LoginInfo info3 = new LoginInfo();
            info3.Name = "陈小坤";
            info3.Id = "110125197905123571";
            info3.Email = "xiaokun@sohu.com";
            info3.Password = "chenkun";
            array[2] = info3;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }
            else
            {
                string userName = txtEmail.Text;
                string pwd = txtPwd.Text;
                bool isOK = false;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item.Email == userName && item.Password == pwd)
                        {
                            isOK = true;
                            FrmMain fm = new FrmMain();
                            fm.lblName.Text = "欢迎，" + item.Name;//将信息传递到主页面
                            fm.Show();
                            break;
                        }
                    }
                }
                if (isOK == false)
                {
                    txtPwd.Text = "";
                    txtPwd.Focus();
                }
            }
        }
    }
}
