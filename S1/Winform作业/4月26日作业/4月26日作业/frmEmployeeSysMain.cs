using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月26日作业
{
    public partial class frmEmployeeSysMain : Form
    {
        public frmEmployeeSysMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsmiAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAdd = new frmAddEmployee();
            frmAdd.MdiParent = this;
            frmAdd.Show();
        }
    }
}
