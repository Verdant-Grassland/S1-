using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //非空验证
            //用户名文本框为空
            if (txtName.Text == "")
            {
                //文本框不能为空
                //MessageBox.Show(提示信息,标题栏上显示的文字，消息框中的按钮，消息框中的图标)
                //MessageBoxButtons.OKCancel显示确定和取消按钮,MessageBoxIcon.Information(i信息的图标)
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //光标回到文本框
                txtName.Focus();
                return;
            }
            else if (txtPwd.Text == "")
            {
                //密码为空时的提示消息
                MessageBox.Show("密码不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }
            else if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show("密码长度不能少于6位", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }
            else if (cboType.Text == "")
            {
                MessageBox.Show("请选择登录类型", "提示信息");
                return;
            }
            //登录功能实现
            //SQL语句
            if (cboType.Text == "管理员")
            {
                //string sql = "Select count(*) from admin where LoginId = '" + txtName.Text + "' and LoginPwd = '" + txtPwd.Text + "'";
                string sql = string.Format("Select count(*) from admin where LoginId = '{0}' and LoginPwd = '{1}'", txtName.Text, txtPwd.Text);
                //调用通用方法
                int succ = Convert.ToInt32(DBHelper.DoScalar(sql));
                if (succ > 0)
                {
                    //登录成功
                    //创建frmMain窗体的对象
                    frmMain frm = new frmMain();
                    //显示窗体
                    frm.Show();
                    //隐藏当前窗体
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }

        private void btnCalce_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭窗人本吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //当点击了Yes按钮，关闭窗体
            if (result == DialogResult.Yes)
            {
                //关闭窗体
                this.Close();
            }
            else
            {
                MessageBox.Show("你取消了关闭窗体的操作");
            }
        }
    }
}
