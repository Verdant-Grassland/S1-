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

namespace Employee
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        //添加按钮的事件
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ////非空验证
            //if (txtName.Text == "" || txtPlace.Text == "" ||txtPosition.Text == "")
            //{
            //    MessageBox.Show("请填写完整所有信息后提交！", "系统提示");
            //    return;
            //}
            //第二种非空验证方法
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("请填写完整所有信息后提交！", "系统提示");
                        return;
                    }
                }
            }
            string sex = "";
            if (rbtnMale.Checked)
            {
                sex = "男";
            }else if (rbtnFemale.Checked)
            {
                sex = "女";
            }
            //添加
            string sql = string.Format(@"Insert into Employees(EmployeeName,Position,JoinDate,PostRankId,Birthday,NativePlace,Sex)
                 Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txtName.Text,txtPosition.Text,dtpJoinDate.Value,cboPostRank.SelectedValue,dtpBirthday.Value,txtPlace.Text,sex);
            //调用添加方法
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

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //建立SQL语句
            string sql = "select * from PostRank";
            //下拉列表绑定
            cboPostRank.DataSource = DBHelper.DoQuery(sql);
            //下拉列表显示的内容
            cboPostRank.DisplayMember = "PostRankName";
            //提交的值
            cboPostRank.ValueMember = "Id";
        }
        //清空
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPlace.Text = "";
            txtPosition.Text = "";
            //日期控件是当前日期
            dtpBirthday.Value = DateTime.Now;
            dtpJoinDate.Value = DateTime.Now;
            //男默认选为不中
            rbtnMale.Checked = false;
            //女默认选为不中
            rbtnFemale.Checked = false;
            //下拉列表第一个选中
            cboPostRank.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
