using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月11日下午作业
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void EmptyEntry_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitEntry(object sender, EventArgs e)
        {
            if (PstTime.Text == "")
            {
                MessageBox.Show("预定时间不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                PstTime.Focus();
                return;
            }
            else if (SdoName.Text == "")
            {
                MessageBox.Show("录音室名称不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                SdoName.Focus();
                return;
            }
            else if (SedReasons.Text == "")
            {
                MessageBox.Show("预定原因不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                SedReasons.Focus();
                return;
            }
            else if (SedStaff.Text == "")
            {
                MessageBox.Show("预定人员不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                SedStaff.Focus();
                return;
            }
            else if (EntryStaff.Text == "")
            {
                MessageBox.Show("录入人员不能为空", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                EntryStaff.Focus();
                return;
            }
            string sql = string.Format(@"Insert BookRecord(RoomName,BookDate,BookPerson,BookReason,NotePerspm)
                Values('{0}','{1},'{2}','{3}','{4}')", PstTime.Text, SdoName.Text, SedReasons.Text, SedStaff.Text, EmptyEntry);
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

        private void CancelEntry_Click(object sender, EventArgs e)
        {
           
        }
    }
}
