using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //SQL语句
            string sql = "Select brandId,brand from MobileBrand";
            //下了列表框数据源绑定
            cboBrand.DataSource = DBHelper.DoQuery(sql);
            //显示内容
            cboBrand.DisplayMember = "brand";
            //提交的值
            cboBrand.ValueMember = "brandId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空验证
            //if (txtPrice.Text == "" || txtSize.Text == "" || txtStyle.Text == "" || txtType.Text == "" || txtWeight.Text == "")
            //{
            //    MessageBox.Show("所有文本框均不能为空");
            //    return;
            //}
            //非空验证的第二种方式
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("所有文本框均不能为空");
                        return;
                    }
                }
            }
            //添加代码
            string sql = string.Format(@" insert into MobileInfo (brandId, type, price, size, weight, style) 
                            Values({0},'{1}', '{2}','{3}',{4},'{5}')", cboBrand.SelectedValue,txtType.Text,txtPrice.Text,txtSize.Text,txtWeight.Text,txtStyle.Text);
            //调用通用方法
            int succ = DBHelper.DoNonQuery(sql);
            if (succ > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtSize.Text = "";
            txtType.Text = "";
            txtWeight.Text = "";
            //下了列表恢复第一个选中
            cboBrand.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭此窗体吗？", "提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
