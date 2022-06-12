using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月16日周末作业
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void InputProducts_Click(object sender, EventArgs e)
        {
            frmPonetry Ponetry = new frmPonetry();
            Ponetry.MdiParent = this;
            Ponetry.Show();
        }

        private void EnquiryProduct_Click(object sender, EventArgs e)
        {
            frmPonSearch Search = new frmPonSearch();
            Search.MdiParent = this;
            Search.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
