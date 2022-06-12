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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

      

        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            //创建新增窗体的对象
            FrmAddStudent frmStudent = new FrmAddStudent();
            //设置父窗体
            frmStudent.MdiParent = this;
            //显示窗体
            frmStudent.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            //退出整个应用程序
            Application.Exit();
        }

        private void tsmiSearchByName_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            //模式窗体
            frm.ShowDialog();
        }

        private void tsbtnSearchGrade_Click(object sender, EventArgs e)
        {
            //创建按年级查询窗体对象
            FrmSearchGrade frm = new FrmSearchGrade();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
