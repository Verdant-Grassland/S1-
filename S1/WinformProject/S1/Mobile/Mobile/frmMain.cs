using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            //创建增加窗体的对象
            frmAdd frmAdd = new frmAdd();
            //设置父窗体为当前窗体
            frmAdd.MdiParent = this;
            frmAdd.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
