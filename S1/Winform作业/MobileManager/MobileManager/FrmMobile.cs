using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileManager
{
    public partial class FrmMobile : Form
    {
        public FrmMobile()
        {
            InitializeComponent();
        }

        private void FrmMobile_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text == "全部")
            {
                txtSearch.Enabled = false;
            }
            else
            {
                txtSearch.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "" )
            {
                MessageBox.Show("请选择查询种类","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if (txtSearch.Text == "" && cboType.Text !="全部")
            {
                MessageBox.Show("请输入查询条件", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SearchInfo();
        }

        public void SearchInfo()
        {
            string sql = @"Select m.Mid,m.Bland,c.Category,m.Type,m.Price
                        from MobileInfo m
                        Inner join CategoryInfo c on m.Cid = c.Cid";
            if (cboType.Text == "品牌")
            {
                sql += "    and m.Bland like '%" + txtSearch.Text + "%'";
            }
            else if (cboType.Text == "手机类型")
            {
                sql += "    and c.Category like '%" + txtSearch.Text + "%'";
            }
            DataTable dt = DBHelper.DoQuery(sql);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("没有你所要查询的手机！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.dgvShow.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
