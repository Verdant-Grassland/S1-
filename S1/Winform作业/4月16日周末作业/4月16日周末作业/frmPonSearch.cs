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
    public partial class frmPonSearch : Form
    {
        static string connStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=DigitalProductReleaseDB;User ID=sa;Password=123456";
        static SqlConnection conn = new SqlConnection(connStr);

        public frmPonSearch()
        {
            InitializeComponent();
        }

        private void frmPonSearch_Load(object sender, EventArgs e)
        {
            string sql = "Select * from ProductInfo";
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                DataSet ds = new DataSet();
                this.dgvProductInfo.DataSource = ds;
                this.dgvProductInfo.DataMember = "ProductInfo";
            }
            else
            {
                MessageBox.Show("出现异常！", "系统温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"Select * from ProductInfo where ProductName like '%{0}'",this.txtName.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                 DataSet ds = new DataSet();
                DataView dv = new DataView(ds.Tables["ProductInfo"]);
                dgvProductInfo.DataSource = dv;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
