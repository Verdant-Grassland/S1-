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
    public partial class FrmAddResult : Form
    {
        //学号
        public int stuNo;
        public FrmAddResult()
        {
            InitializeComponent();
        }

        private void FrmAddResult_Load(object sender, EventArgs e)
        {
            //绑定科目
            string sql = "select SubjectId,SubjectName from Subject";
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
            string sql = @"select s.StudentName,j.SubjectName,r.StudentResult,r.ExamDate
                        from Student s
                        inner join Result r on s.StudentNo=r.StudentNo
                        inner join Subject j on j.SubjectId=r.SubjectId where s.studentNo="+stuNo;
            //数据绑定
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //sql语句
            string sql = string.Format(@"insert into Result(studentno,SubjectId,StudentResult,ExamDate) 
                         values({0},{1},'{2}','{3}')",stuNo,cboSubject.SelectedValue,txtStudentResult.Text,dtpTime.Value);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
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
