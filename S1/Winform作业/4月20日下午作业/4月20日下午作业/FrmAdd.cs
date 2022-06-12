using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月20日下午作业
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Check();
            string sql = string.Format(@"Insert into Flower(name, anothername, property, price, production)
                    values('{0}','{1}','{2}',{3},'{4}')",txtName.Text,txtAlias.Text,txtGenus.Text,txtPrice.Text,txtOrigin.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("增加成功！","提示");
            }
            else
            {
                MessageBox.Show("增加失败！", "提示");
            }
            //非空验证
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("各项均不能为空", "提示");
                    }
                    return;
                }
            }
        }
        //格式必须数字
        public bool Check()
        {
            //判断是否位数字类型
            if (!int.TryParse(txtPrice.Text, out int value))
            {
                MessageBox.Show("格式必须为数字", "提示");
                //清空文本
                this.txtPrice.Text = "";
                //获取焦点
                this.txtPrice.Focus();
                return false;
            }
            //判断价格是否大于0
            else if (value < 0)
            {
                MessageBox.Show("价格必须大于0", "提示");
                this.txtPrice.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            //清空验证
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}
