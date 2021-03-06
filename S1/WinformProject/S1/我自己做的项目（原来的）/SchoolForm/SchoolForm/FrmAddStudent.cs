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
    public partial class FrmAddStudent : Form
    {
        public int stuNo = -1;
        public FrmAddStudent()
        {
            InitializeComponent();
        }
        //读取信息
        public void SearchInfo()
        {
            string sql = "Select * from Student where StudentNo = " + stuNo;
            //调用通用方法
            SqlDataReader reader =DBHelper.DoReader(sql);

            if (reader.Read())
            {
                //将字段的信息读到控件上
                txtStudentNo.Text = reader["StudentNo"].ToString();
                txtPwd.Text = reader["LoginPwd"].ToString();
                txtRePwd.Text = reader["LoginPwd"].ToString();
                txtName.Text = reader["StudentName"].ToString();
                //性别
                int gender = Convert.ToInt32(reader["Gender"]);
                if (gender == 1)
                {
                    //性别男的单选按钮选中
                    this.rbtnMale.Checked = true;
                }
                else if (gender == 0)
                {
                    //女的选中
                    this.rbtnFemale.Checked = true;
                }
                //下拉列表读取
                cboGrade.SelectedIndex = Convert.ToInt32(reader["GradeId"]);
                txtPhone.Text = reader["Phone"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                //出生年月
                dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                txtEmail.Text = reader["Email"].ToString();
            }
            reader.Close();
        }
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            string sql = "select * from Grade";
            //调用通用方法
            SqlDataReader reader = DBHelper.DoReader(sql);
            cboGrade.Items.Add("请选择");
            //第1个选项选中
            cboGrade.SelectedIndex = 0;
            while (reader.Read())
            {
                //下接列表框选项添加
                cboGrade.Items.Add(reader["GradeName"].ToString());
            }
            reader.Close();

            //如果学号不是-1，窗体显示学生信息
            if (stuNo != -1)
            {
                SearchInfo();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtPwd.Text == "" || txtRePwd.Text == "")
            {
                MessageBox.Show("所有文本不能为空");
                return;
            }
            //如果学号是-1，做添加，否则，做修改
            if (stuNo == -1)
            {
                //添加
                AddStudent();
            }
            else
            {
                //修改
                UpdateStudent();
            }
        }
        //添加方法
        public void AddStudent()
        {
            //性别
            int Gender = 0;
            //如果性别是男的单选按钮选中
            if (rbtnMale.Checked)
            {
                Gender = 1;
            }
            else if (rbtnMale.Checked)
            {
                Gender = 0;
            }
            //年级
            int gradeId = cboGrade.SelectedIndex;
            //日期
            DateTime dt = dtpBirthday.Value;
            //获得日期年月日
            string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);

            //建立sql语句
            string sql = @"insert into Student(LoginPwd,StudentName,Gender,gradeId,Phone,Address,birthday,email)
                        values('" + txtPwd.Text + "','" + txtName.Text + "','" + Gender + "','" + gradeId + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + date + "','" + txtEmail.Text + "')";
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        //修改方法
        public void UpdateStudent()
        {
            //性别
            int Gender = 0;
            //如果性别是男的单选按钮选中
            if (rbtnMale.Checked)
            {
                Gender = 1;
            }
            else if (rbtnMale.Checked)
            {
                Gender = 0;
            }
            //年级
            int gradeId = cboGrade.SelectedIndex;
            //日期
            DateTime dt = dtpBirthday.Value;
            //获得日期年月日
            string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);

            //建立sql语句
            string sql = @"Update Student
                           set LoginPwd='" + txtPwd.Text + "',StudentName='" + txtName.Text + "',Gender=" + Gender + ",GradeId=" + gradeId + ",Phone='" + txtPhone.Text + "',Address='" + txtAddress.Text + "',Birthday='" + date + "',Email='" + txtEmail.Text + "'  where StudentNo=" + stuNo;
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
