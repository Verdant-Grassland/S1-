using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerSys
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {

            string sql = @"Select s.SaleId,s.FlowerId,f.FlowerName,s.SaleCount,s.SaleDate,s.SalePrice,s.SaleClerk,s.Remark
                        from FlowerSale s
                        Inner join Flower f on s.SaleId = f.FlowerId Where 1 = 1";
            if (txtName.Text != "")
            {
                sql += "    and f.FlowerName like '%" + txtName.Text + "%'";
            }
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvShow.CurrentRow.Cells["SaleId"].Value);
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.id = id;
            frmUpdate.lblId.Text = this.dgvShow.CurrentRow.Cells["SaleId"].Value.ToString();
            frmUpdate.txtCount.Text = this.dgvShow.CurrentRow.Cells["SaleCount"].Value.ToString();
            frmUpdate.txtPrice.Text = this.dgvShow.CurrentRow.Cells["SalePrice"].Value.ToString();
            frmUpdate.txtRemark.Text = this.dgvShow.CurrentRow.Cells["Remark"].Value.ToString();
            frmUpdate.frmSearch = this;
            frmUpdate.Show();
        }
    }
}
