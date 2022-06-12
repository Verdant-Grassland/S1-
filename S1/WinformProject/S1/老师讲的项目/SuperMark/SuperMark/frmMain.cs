using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMark
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //显示数据
        public void ShowData()
        {
            string sql = @"select u.id,u.customerId,u.customerType,u.score,s.statesName
                        from UsersInfo u
                        inner join states s on u.statusId=s.id";
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            string sql = "select id,statesName from states";
            //下拉列表框绑定
            this.cboStates.DataSource = DBHelper.DoQuery(sql);
            //显示的内容
            this.cboStates.DisplayMember = "statesName";
            //实际提交的值
            this.cboStates.ValueMember = "id";
            
            txtScore.Text = "500";
            //查询数据
            ShowData();
        }
        //金卡单选按钮事件
        private void rbtnJk_CheckedChanged(object sender, EventArgs e)
        {
            //积分文本框的值
            txtScore.Text = "500";
        }
        //铂金卡单选按钮事件
        private void rbtnBoJin_CheckedChanged(object sender, EventArgs e)
        {
            txtScore.Text = "2000";
        }
        //钻石卡单选按钮事件
        private void rbtnZuanShi_CheckedChanged(object sender, EventArgs e)
        {
            txtScore.Text = "5000";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtCustomerId.Text=="" || txtPwd.Text=="")
            {
                MessageBox.Show("请输入账号和密码");
                return;
            }
            //获得类型
            string type = "";
            if (rbtnJk.Checked)
            {
                type = "金卡";
            }
            else if (rbtnBoJin.Checked)
            {
                type = "铂金卡";
            }
            else if (rbtnZuanShi.Checked)
            {
                type = "钻石卡";
            }
            string sql = string.Format(@"insert into UsersInfo(customerId,customerPassword,customerType,score,statusId)
                        values('{0}','{1}','{2}',{3},{4})",txtCustomerId.Text,txtPwd.Text,type,txtScore.Text,this.cboStates.SelectedValue);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
                ShowData();
                ClearData();
               
            }
            else
            {
                MessageBox.Show("添加失败");
            }

        }
        //清空方法
        public void ClearData()
        {
            //清空
            txtCustomerId.Text = "";
            txtPwd.Text = "";
            //单选按钮第一个按钮
            rbtnJk.Checked = true;
            //下拉列表第一个选中
            cboStates.SelectedIndex = 0;
            //积分恢复为500
            txtScore.Text = "500";
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvShow.CurrentRow.Cells["id"].Value);
            string sql = "delete from UsersInfo where id="+id;
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("删除成功");
                ShowData();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
