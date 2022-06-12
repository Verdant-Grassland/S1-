using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4月16日周末作业
{
    public partial class frmPonetry : Form
    {
        public frmPonetry()
        {
            InitializeComponent();
        }

        private void frmPonetry_Load(object sender, EventArgs e)
        {
            string sql = "Select * from ProductTypeInfo";
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                cboType.Items.Add(reader["ProductTypeName"].ToString());
            }
            reader.Close();
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
            cboType.SelectedIndex = 0;
        }

        private void proSubmint_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("所有信息不能为空，请全部完善！", "系统温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
            }

            string name = this.txtName.Text;
            int type = Convert.ToInt32(this.cboType.SelectedValue);
            DateTime release = Convert.ToDateTime(this.txtPbsTime.Text);
            DateTime market = Convert.ToDateTime(this.txtLseTime.Text);
            double price = Convert.ToDouble(this.txtSelPrice.Text);
            string Corporation = this.txtCompany.Text;
            string AddPerson = this.txtWriter.Text;
            string sql = @"Insert into ProductInfo(ProductName,ProductTypeID,RelaseDate,MarketDate,Price,Corporation,AddPerson)
                 Values('" + name + "'," + type + ",'" + release + "','" + market + "','" + price + "','" + Corporation + "','" + AddPerson + "')";
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("产品信息已保存！", "系统温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("产品信息保存失败！", "系统温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
