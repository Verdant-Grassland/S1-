using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
