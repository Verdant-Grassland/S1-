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
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {
            if (this.lvShow.Items.Count > 0)
            {
                this.lvShow.Items.Clear();
            }
            string sql = @"select s.ProductID,s.ProductName,s.RelaseDate,s.MarketDate,s.Price,s.Corporation,s.AddPerson,g.ProductTypeID
                            from ProductInfo s  
                            Inner join ProductTypeInfo g on s.ProductTypeID=g.ProductTypeID where 1=1";
            if (txtName.Text != "")
            {
                sql += "   and s.ProductName like '%" + txtName.Text + "%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ProductID"].ToString());
                item.SubItems.Add(reader["ProductName"].ToString());
                item.SubItems.Add(reader["ProductTypeID"].ToString());
                item.SubItems.Add(reader["RelaseDate"].ToString());
                item.SubItems.Add(reader["MarketDate"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["Corporation"].ToString());
                item.SubItems.Add(reader["AddPerson"].ToString());
                lvShow.Items.Add(item);
            }
            reader.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
