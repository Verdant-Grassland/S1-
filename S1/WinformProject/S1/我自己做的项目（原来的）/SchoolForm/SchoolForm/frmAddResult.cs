using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class frmAddResult : Form
    {
        //学号
        public int stuNo;
        public frmAddResult()
        {
            InitializeComponent();
        }

        private void frmAddResult_Load(object sender, EventArgs e)
        {
            //绑定科目
            string sql = "Select SubjectId,SubjectName from Subject";
            //下拉列表框绑定
            this.cboSubject.DataSource = DBHelper.DoQuery(sql);
            //显示的内容
            this.cboSubject.DisplayMember = "SubjectName";
            //提交的值
            this.cboSubject.ValueMember = "SubjectId";

            //调用查询方法
            SearchInfo();
        }
        #region 查询方法
        public void SearchInfo()
        {
            string sql = @"Select s.StudentName, j.SubjectName,r.StudentResult,r.ExamDate
                         from Student s
                         Inner join Result r on s.StudentNo = r.StudentNo
                         Inner join Subject j on j.SubjectId = r.SubjectId where s.StudentNo =" + stuNo;
            //数据绑定
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);

        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //sql语句
            string sql = string.Format(@"Insert into Result(StudentNo,SubjectId,StudentResult,ExamDate)
                         Values({0},{1},'{2}','{3}')",stuNo,cboSubject.SelectedValue,txtStudentResult.Text,dtpTime.Value);
            int result = DBHelper.DoNonQuery(sql);
            if (result >0)
            {
                MessageBox.Show("添加成绩成功");
                //调用查询方法
                SearchInfo();
            }
            else
            {
                MessageBox.Show("添加成绩失败");
            }
        }
    }
}
