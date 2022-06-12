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

namespace _4月26日作业
{
    public partial class frmAddEmployee : Form
    {
        public int postID = -1;
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            string sql = "select * from PostRank";
            SqlDataReader reader = DBHelper.DoReader(sql);
            cboPostRankId.Items.Add("请选择");
            cboPostRankId.SelectedIndex = 0;
            while (reader.Read())
            {
                cboPostRankId.Items.Add(reader["PostRankName"].ToString());
            }
            reader.Close();
            if (postID != -1)
            {
                SearchInfo();
            }
        }

         public void SearchInfo()
        {
            string sql = "Select * from Employees where Id = " + postID;
            SqlDataReader reader =DBHelper.DoReader(sql);

            if (reader.Read())
            {
                txtName.Text = reader["EmployeeName"].ToString();
                txtPosition.Text = reader["Position"].ToString();
                txtNativePlace.Text = reader["NativePlace"].ToString();
                //性别
                int sex = Convert.ToInt32(reader["Sex"]);
                if (sex == 1)
                {
                    this.rbtnMale.Checked = true;
                }
                else if (sex == 0)
                {
                    this.rbtnFemale.Checked = true;
                }
                cboPostRankId.SelectedIndex = Convert.ToInt32(reader["PostRankId"]);
                dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                dtpJoinDate.Value = Convert.ToDateTime(reader["JoinDate"]);
            }
            reader.Close();
        }

        public void AddEmployee()
        {
            int Sex = 0;
            if (rbtnMale.Checked)
            {
                Sex = 1;
            }
            else if(rbtnFemale.Checked)
            {
                Sex = 0;
            }
            int PostRankId = cboPostRankId.SelectedIndex;
            DateTime dt = dtpBirthday.Value;
            DateTime dtd = dtpJoinDate.Value;
            string Birthday = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);
            string JoinDate = string.Format("{0}-{1}-{2}", dtd.Year, dtd.Month, dtd.Day);

            string sql = @"Insert into Employees(EmployeeName,Sex,Position,PostRankId,BirthDay,JoinDate,NativePlace)
                   Values('" + txtName.Text + "','" + Sex + "','" + txtPosition.Text + "','" + PostRankId + "','" + Birthday + "','" + JoinDate + "','" + txtNativePlace.Text + "')";
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("恭喜，添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("请填写完整所有信息后提交！","系统提示");
                        return;
                    }
                }
            }
            if (postID == -1)
            {
                AddEmployee();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            //清空性别控件不选中
            this.rbtnMale.Checked = false;
            this.rbtnFemale.Checked = false;
            //清空日期控件位当前默认时间
            this.dtpBirthday.Text = DateTime.Now.ToShortDateString();
            this.dtpJoinDate.Text = DateTime.Now.ToShortDateString();
            //清空选项控件选中为第一项
            this.cboPostRankId.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
