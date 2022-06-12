using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtDate.Text == "" || txtId.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("所有文本框均不能为空");
                return;
            }
            //添加
            string sql = string.Format(@"Insert into assets(assetId,assetName,assetType,intoDate)
                                    Values('{0}','{1}','{2}','{3}')",txtId.Text,txtName.Text,cboType.Text,txtDate.Text);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("添加成功","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加失败","提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空
            txtDate.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            //下拉列表框显示第一个
            cboType.SelectedIndex = 0;
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //下拉列表第一选中
            cboType.SelectedIndex = 0;
        }
    }
}
