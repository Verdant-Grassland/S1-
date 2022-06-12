using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            string sql = "select id,teamName from TeamInfo";
            //调用通用方法，绑定数据源
            //绑定主队下拉列表
            this.cboHost.DataSource = DBHelper.DoQuery(sql);
            this.cboHost.DisplayMember = "teamName";
            this.cboHost.ValueMember = "id";

            //绑定客队下拉列表
            this.cboAway.DataSource = DBHelper.DoQuery(sql);
            this.cboAway.DisplayMember = "teamName";
            this.cboAway.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //非空第二种方式
            //if (txtAwayScore.Text=="" || txtCount.Text=="" || txtHostScore.Text=="" || txtPastScore.Text=="" || txtTime.Text=="")
            //{
            //    MessageBox.Show("所有文本框均不能为空");
            //    return;
            //}
            //第二种方式:item代码每一个控件,Controls是所有控件的集合.
            foreach (Control item in Controls)
            {
                //如果是文本框
                if (item is TextBox)
                {
                    if (item.Text=="")
                    {
                        MessageBox.Show("所有文本框均不能为空");
                        return;
                    }
                }
            }
            //添加的SQL语句
            string sql=string.Format(@"insert into ScheduleInfo([count],hostTeamId,awayTeamId,pastScore,competitionTime,hostTeamScore,awayTeamScore)
                                    values({0},{1},{2},'{3}','{4}',{5},{6})",txtCount.Text,cboHost.SelectedValue,cboAway.SelectedValue,
                                                                            txtPastScore.Text,txtTime.Text,txtHostScore.Text,txtAwayScore.Text);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
                ClearData();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
        //清空的按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //清空方法
        public void ClearData()
        {
            //文本框清空
            /*txtAwayScore.Text = "";
            txtCount.Text = "";
            txtHostScore.Text = "";
            txtPastScore.Text = "";
            txtTime.Text = "";*/
            //清空文本框第二种方法
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            //下拉列表框第一个显示
            cboAway.SelectedIndex = 0;
            cboHost.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //弹出消息框
            DialogResult result = MessageBox.Show("确定要关闭吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            //如果点击了对话框中的确定
            if (result==DialogResult.OK)
            {
                //关闭窗体
                this.Close();   
            }
            else
            {
                MessageBox.Show("您取消了关闭窗口操作");
            }
        }
    }
}
