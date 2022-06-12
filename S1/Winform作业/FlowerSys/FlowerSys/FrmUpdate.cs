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
    public partial class FrmUpdate : Form
    {
        public int id;
        public FrmSearch frmSearch;
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"Update FlowerSale
                            Set SaleCount = {0}, SalePrice = {1}, Remark = '{2}'
                            Where SaleId = {3}", txtCount.Text,txtPrice.Text,txtRemark.Text,id);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("信息修改成功！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("信息修改失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
