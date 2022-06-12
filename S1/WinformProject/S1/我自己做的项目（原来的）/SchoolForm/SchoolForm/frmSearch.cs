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

namespace SchoolForm
{
    public partial class frmSearch : Form
    {
        public frmSearch()
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

        //查询方法
        public void SearchInfo()
        {
            //清除所有数据
            if (this.lvShow.Items.Count>0)
            { 
                //清除所有的项，即清除所有的行
                this.lvShow.Items.Clear();
            }
            string sql = @"Select s.StudentNo,s.StudentName,s.Gender,g.GradeName
                              from Student s Inner join Grade g on s.GradeId = g.GradeId";
            if (txtName.Text != "")
            {
                sql += "    and s.StudentName like '%" + txtName.Text + "%'";
            }
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["StudentNo"].ToString());
                //添加子项
                item.SubItems.Add(reader["StudentName"].ToString());
                item.SubItems.Add(reader["Gender"].ToString());
                item.SubItems.Add(reader["GradeName"].ToString());
                //将项添加到ListView控件
                lvShow.Items.Add(item);
            }
            reader.Close();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //学号
            int stuNo = Convert.ToInt32(this.lvShow.SelectedItems[0].Text);

            //删除SQL语句
            string sql = "delete from Result where StudentNo='"+stuNo+"'";
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            //删除学生表的SQL语句
            sql = "Delete from Student where StudentNo = " + stuNo;
            //调用通用方法
            result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("删除成功");
                //刷新数据显示，重新调用查询方法
                SearchInfo();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            //学号
            int StudentNo = Convert.ToInt32(this.lvShow.SelectedItems[0].Text);
            FrmAddStudent frmAdd = new FrmAddStudent();
            //传递学号
            frmAdd.stuNo = StudentNo;
            frmAdd.Show();
        }
    }
}
