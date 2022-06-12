using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4月18日下午作业
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnSubmint_Click(object sender, EventArgs e)
        {
            //遍历所有的控件
            foreach (Control item in Controls)
            {
                //判断控件是否是文本框
                if (item is TextBox)
                {
                    //文本框为空
                    if (item.Text == "")
                    {
                        MessageBox.Show("所有项目均不能为空");
                        return;
                    }
                }
            }
            //添加功能
            string sql = String.Format(@"Insert into Organizations (Name,Description,Principal,Telephone,RegistrationDate)  
                        values('{0}','{1}','{2}', '{3}', '{4}')", txtName.Text,txtContent.Text,txtPerson.Text,txtPhone.Text,txtDate.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);    //添加成功之后，调用清空方法
                ClearData();
            }
            else
            {
                MessageBox.Show("注册失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //清空方法
        public void ClearData()
        {
            txtContent.Text = "";
            txtDate.Text = "";
            txtName.Text = "";
            txtPerson.Text = "";
            txtPhone.Text = "";
            //txtContent.Text = txtDate.Text = txtName.Text = txtPerson.Text = txtPhone.Text = "";
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            //取消，关闭当前窗体
            this.Close();
        }
    }
}
