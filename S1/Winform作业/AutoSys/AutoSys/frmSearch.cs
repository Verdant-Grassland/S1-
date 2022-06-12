using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSys
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAutoNum.Text == "")
            {
                MessageBox.Show("请输入车牌号码！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SearchInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SearchInfo()
        {
            string sql = @"Select i.AutoNum,b.BrandName,i.Instruction,i.BuyDate,i.Price,i.InitKiloNum
                           from AutoInfo i
                           Inner join AutoBrand b on b.BrandId = i.AutoId
                           Where 1 = 1";
            if (txtAutoNum.Text != "")
            {
                sql += "    and i.AutoNum like '%" + txtAutoNum.Text + "%'";
            }
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
    }
}
