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

namespace UserManagerSys
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
            if (this.lvShow.Items.Count > 0)
            {
                this.lvShow.Items.Clear();
            }
            string sql = @"Select UserId,UserPass,Email,Address,Blood
                        from Users
                        Where 1 = 1";
            if (txtName.Text != "")
            {
                sql += "    and UserId like '%" + txtName.Text + "%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["UserId"].ToString());
                item.SubItems.Add(reader["UserPass"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(reader["Address"].ToString());
                item.SubItems.Add(reader["Blood"].ToString());
                lvShow.Items.Add(item);
            }
            reader.Close();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(this.lvShow.SelectedItems[0].Text);
            string sql = "Delete from Users Where UserId = '" + id + "'";
            int succ = DBHelper.DoNonQuery(sql);
            if (succ > 0)
            {
                MessageBox.Show("删除成功");
                SearchInfo();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
