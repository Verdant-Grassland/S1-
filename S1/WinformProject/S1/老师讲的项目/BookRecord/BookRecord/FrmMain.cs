using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRecord
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //遍历所有的控件
           /* foreach (Control item in Controls)
            {
                //如果是文本框
                if (item is TextBox)
                {
                    //文本框非空验证
                    if (item.Text=="")
                    {
                        MessageBox.Show("所有文本框均不能为空");
                        //返回窗体
                        return;
                    }
                }
            }*/
            //if (txtName.Text=="" || txtNote.Text=="" || txtPerson.Text=="" || txtReason.Text=="" || txtTime.Text=="")
            //{
            //    MessageBox.Show("所有文本框均不能为空 ");
            //    return;
            //}

            if (Check())
            {
                //添加功能
                //            string sql = string.Format(@"insert into BookRecord(RoomName,BookDate,BookPerson,BookReason,NotePerson) 
                //            values('{0}','{1}','{2}','{3}','{4}')",txtName.Text,txtTime.Text,txtPerson.Text,txtReason.Text,txtNote.Text);

                string sql = @"insert into BookRecord(RoomName,BookDate,BookPerson,BookReason,NotePerson) 
                         values('" + txtName.Text + "','" + txtTime.Text + "','" + txtPerson.Text + "','" + txtReason.Text + "','" + txtNote.Text + "')";
                //调用增删改方法
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

          
          
        }
        //非空验证方法
        public bool Check()
        {
            if (txtTime.Text=="")
            {
                MessageBox.Show("时间不能为空");
                return false;
            }
            else if (txtName.Text=="")
            {
                MessageBox.Show("会议室名称不能为空");
                return  false;
            }
            else if (txtReason.Text=="")
            {
                MessageBox.Show("原因不能为空");
                return false;
            }
            else if (txtPerson.Text=="")
            {
                MessageBox.Show("预订人员不能为空");
                return false;
            }
            else if (txtNote.Text=="")
            {
                 MessageBox.Show("录入人员不能为空");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //简单方法
            //txtName.Text = "";
            //txtNote.Text = "";
            //txtPerson.Text = "";
            //txtReason.Text = "";
            //txtTime.Text = "";
            //Controls表示所有的控件
            foreach (Control item in Controls)
            {
                //如果是文本框控件
                if (item is TextBox)
                {
                    //文本框清空
                    item.Text = "";
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //弹出提示的消息框
            DialogResult result = MessageBox.Show("确定要取消吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            //如果点击对话框中的确定
            if (result==DialogResult.OK)
            {
                //关闭窗体
                this.Close();
            }
            else
            {
                MessageBox.Show("你取消了操作");
            }
        }


    }
}
