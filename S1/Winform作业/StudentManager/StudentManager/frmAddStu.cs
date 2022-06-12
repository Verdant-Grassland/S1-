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

namespace StudentManager
{
    public partial class frmAddStu : Form
    {
        public frmAddStu()
        {
            InitializeComponent();
        }

        private void frmAddStu_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboInSearch.Text))
            {
                MessageBox.Show("请选择查询类型！", "类型", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtInSearch.Text))
            {
                MessageBox.Show("请输入查询条件！", "条件", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtInSearch.Text) && string.IsNullOrEmpty(cboInSearch.Text))
            {
                MessageBox.Show("没有满足条件的学员信息！","查询",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            SearchInfo();
        }

        public void SearchInfo()
        {
            string sql = "Select * from StuInfo";
            if (cboInSearch.Text == "")
            {
                sql = "Select * from StuInfo";
            }
            if (cboInSearch.Text == "学员姓名")
            {
                sql = string.Format("Select * from StuInfo where Name like '%" + txtInSearch.Text + "%'");
            }
            else if (cboInSearch.Text == "联系电话")
            {
                sql = string.Format("Select * from StuInfo where Telephone like '%" + txtInSearch.Text + "%'");
            }
            else if (cboInSearch.Text == "家庭住址")
            {
                sql = string.Format("Select * from StuInfo where Address like '%" + txtInSearch.Text + "%'");
            }
            else if (cboInSearch.Text == "身份证号")
            {
                sql = string.Format("Select * from StuInfo where IDCard like %'" + txtInSearch.Text + "%'");
            }
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInSearch.Text = "";
            cboInSearch.SelectedItem = null;
            SearchInfo();
        }
    }
}
