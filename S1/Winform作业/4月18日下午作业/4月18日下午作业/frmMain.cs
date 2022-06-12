using _4月18日;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月18日下午作业
{
    public partial class frmMain : Form
    {
       public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiReg_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.MdiParent = this;
            frmAdd.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }
    }
}
