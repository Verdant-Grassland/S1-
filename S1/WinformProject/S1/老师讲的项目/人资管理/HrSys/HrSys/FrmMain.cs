using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrSys
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            //查询窗体对象
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
