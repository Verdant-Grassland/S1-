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

namespace _4月23日周末作业
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
            SearchInfoLoad();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {
            if (this.lvShow.Items.Count > 0)
            {
                this.lvShow.Items.Clear();
            }
            string sql = @"Select s.ID,s.BrandID,s.Type,s.Price,s.Size,s.Weight,s.Style,g.Brand
                           from MobileInfo s 
                           Inner join MobileBrand g on s.BrandID = g.BrandID";
            if (cboName.SelectedIndex != 0)
            {
                sql += "    and s.BrandID like '%" + cboName.SelectedIndex + "%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Brand"].ToString());
                item.SubItems.Add(reader["BrandID"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["Size"].ToString());
                item.SubItems.Add(reader["Style"].ToString());
                item.SubItems.Add(reader["Weight"].ToString());
                lvShow.Items.Add(item);
            }
            reader.Close();
        }

        public void SearchInfoLoad()
        {
            string sql = "select * from MobileBrand";
            //执行查询操作
            DataTable dt = DBHelper.ExcuteQuery(sql);
            //绑定下拉框分别设置Value值与Text值
            cboName.DisplayMember = "Brand";
            cboName.ValueMember = "BrandID";
            //在下拉框中插入一行并放在第0行中
            DataRow row = dt.NewRow();
            row[0] = "-99";
            row[1] = "请选择";
            dt.Rows.InsertAt(row, 0);
            cboName.DataSource = dt;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
