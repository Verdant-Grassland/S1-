using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizations
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //遍历所有的控件
            foreach (Control item in Controls)
            {
                //判断控件是否是文本框
                if (item is TextBox)
                {
                    //文本框为空
                    if (item.Text=="")
                    {
                        MessageBox.Show("所有文本框均不能为空");
                        return;
                    }
                }
            }
            //添加功能
            string sql = string.Format(@"insert into Organizations(name,description,principal,telephone,registrationDate) 
                        values('{0}','{1}','{2}','{3}','{4}')",txtName.Text,txtContent.Text,txtPerson.Text,txtPhone.Text,txtDate.Text);
            //调用增删改方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
                ClearData();    //添加成功之后,调用清空方法
            }
            else
            {
                MessageBox.Show("添加失败");
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
            //取消,关闭当前窗体
            this.Close();
        }

      
    }
}
