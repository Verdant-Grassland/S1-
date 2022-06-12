using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //非空验证:第一种方式
            /*if (txtAddPerson.Text == "" || txtCorporation.Text == "" || txtMarketDate.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtSendTime.Text == "")
            {
                MessageBox.Show("所有文本框均不能为空,请认真填写!");
                return;
            }*/
            //第二种非空验证
            foreach (Control item in Controls)
            {
                //如果控件是文本框
                if (item is TextBox)
                {
                    //如果文本框为空
                    if (item.Text=="")
                    {
                        MessageBox.Show("所有文本框均不能为空,请认真填写!");
                        return;
                    }
                }
            }
            //添加代码
            string sql = string.Format(@"insert into ProductInfo(productName,productTypeId,releaseDate,marketDate,price,Corporation,AddPerson)
                            values('{0}',{1},'{2}','{3}',{4},'{5}','{6}')",txtName.Text,cboType.SelectedValue,txtSendTime.Text,txtMarketDate.Text,txtPrice.Text,txtCorporation.Text,txtAddPerson.Text);

            //调用增加方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("产品信息已保存","系统温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("产品信息保存失败", "系统温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //清空
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddPerson.Text = "";
            txtCorporation.Text = "";
            txtMarketDate.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtSendTime.Text = "";
            //下拉列表框第一个选中
            cboType.SelectedIndex = 0;

        }
        //关闭代码
        private void btnClose_Click(object sender, EventArgs e)
        {
            //提示信息对话框
            DialogResult result = MessageBox.Show("确定要关闭吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result==DialogResult.OK)
            {
                //关闭窗体
                this.Close();
            }
        }
        //窗体启动的事件
        private void frmAdd_Load(object sender, EventArgs e)
        {
            
            string sql = "select productTypeId,productTypeName from productTypeInfo";
            //绑定下拉列表框
            this.cboType.DataSource = DBHelper.DoQuery(sql);
            //显示的内容
            this.cboType.DisplayMember = "productTypeName";
            //提交的值
            this.cboType.ValueMember = "productTypeId";
        }
    }
}
