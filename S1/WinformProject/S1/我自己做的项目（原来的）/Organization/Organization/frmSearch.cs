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

namespace Organization
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
            SearchInfo();
        }

        public void SearchInfo()
        {
            if (this.lvShow.Items.Count > 0)
            {
                this.lvShow.Items.Clear();
            }
            string sql = @"Select ID,Name,Principal,TelePhone from Organizations";
            if (txtName.Text != "")
            {
                sql += "  where Name like '%" + txtName.Text + "%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Principal"].ToString());
                item.SubItems.Add(reader["TelePhone"].ToString());
                lvShow.Items.Add(item);
            }
            reader.Close();
        }
    }
}
