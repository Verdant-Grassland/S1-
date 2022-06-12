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

namespace Board
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //下拉列表的填充
            string sql = "Select * from Schedulelnfo";
            //调用通用方法
            SqlDataReader reader = DBHelper.DoReader(sql);
            while (reader.Read())
            {
                //将读取的字段填充到下拉列表框的项中
                cboName.Items.Add(reader["boardName"]);
            }
            reader.Close();
            //第一个项默认选中
            cboName.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtDate.Text == "" || txtDuration.Text == "" || txtEnteringName.Text == "" ||txtName.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("所有文本框均不能为空");
                return;
            }
            string sql = string.Format(@"Insert into BoardroomInfo(boardroomId,intendedName,startTime,duration,enteringName,reason)
                    Values({0},'{1}','{2}','{3}','{4}','{5}')", cboName.SelectedIndex + 1,txtName.Text,txtDate.Text,txtDuration.Text,txtEnteringName.Text,txtReason.Text);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭吗？", "提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //关闭当前窗体
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDuration.Text = "";
            txtEnteringName.Text = "";
            txtName.Text = "";
            txtReason.Text = "";
            //下拉列表框第一个选中
            cboName.SelectedIndex = 0;
        }
    }
}
