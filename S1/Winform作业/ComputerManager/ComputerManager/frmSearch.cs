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

namespace ComputerManager
{
    public partial class frmSearch : Form
    {
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=ComputerManagerDB;User ID=sa;Password=123456";
        static SqlConnection con = new SqlConnection(conStr);

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
            SearchInfo();
        }

        public void SearchInfo()
        {
            if (this.dgvShow.Rows.Count > 0)
            {
                this.dgvShow.Rows.Clear();
            }
            string sql = "Select * from ComputerInfo where ComputerId = ComputerId";
            if (txtId.Text != "")
            {
                sql += "    and ComputerId like '%" + txtId.Text + "%'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"ComputerInfo");
            this.dgvShow.DataSource = ds.Tables["ComputerInfo"];
            //DataTable dt = ds.Tables["ComputerInfo"];
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        dgvShow.Rows.Add(
            //            dr["ComputerId"].ToString(), 
            //            dr["Brand"].ToString(), 
            //            dr["CPU"].ToString(), 
            //            dr["Memory"].ToString(), 
            //            dr["HardDisk"].ToString(), 
            //            dr["Employee"].ToString()
            //            );
            //    }
            //}
        }
    }
}
