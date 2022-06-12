using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        //添加按钮的事件
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //非空验证
            //if (txtName.Text=="" || txtPlace.Text=="" || txtPosition.Text=="")
            //{
            //    MessageBox.Show("请填写完整信息后提交","系统提示");
            //    return;
            //}
            //第二种非空验证方法
            foreach (Control item in Controls)
            {
                if (item  is TextBox)
                {
                    if (item.Text=="")
                    {
                         MessageBox.Show("请填写完整信息后提交","系统提示");
                         return;
                    }
                }
            }
            string sex = "";
            if (rbtnMale.Checked)
            {
                sex = "男";
            }
            else if (rbtnFemale.Checked)
            {
                sex = "女"; 
            }
            //添加
            string sql = string.Format(@"insert into Employees(employeeName,Position,JoinDate,PostRankId,birthday,NativePlace,sex) 
                                    values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",txtName.Text,txtPosition.Text,dtpJoinDate.Value,cboPostRank.SelectedValue,dtpBirthday.Value,txtPlace.Text,sex);

            //调用添加方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }

        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //建立SQL语句
            string sql = "select id,postRankName from PostRank";
            //下拉列表绑定
            cboPostRank.DataSource = DBHelper.DoQuery(sql);
            //下拉列表显示的内容
            cboPostRank.DisplayMember = "postRankName";
            //提交的值
            cboPostRank.ValueMember = "id";
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
            //男默认选中
            rbtnMale.Checked = true;
            //下拉列表第一个选中
            cboPostRank.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
