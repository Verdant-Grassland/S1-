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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            string sql = "Select BrandId,BrandName from AutoBrand";
            this.cboBrandName.DataSource = DBHelper.DoQuery(sql);
            this.cboBrandName.DisplayMember = "BrandName";
            this.cboBrandName.ValueMember = "BrandId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("车辆信息不完整！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            string DateBuy = dtpBuyDate.Value.ToString("yyyy-MM-dd");
            string sql = string.Format(@"Insert into AutoInfo(AutoNum,Instruction,BrandId,BuyDate,Price,InitKiloNum)
                    Values('{0}','{1}','{2}','{3}',{4},{5})",txtAutoNum.Text,txtInstruction.Text,cboBrandName.SelectedValue,DateBuy,txtPrice.Text,txtInitKiloNum.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("保存成功","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
