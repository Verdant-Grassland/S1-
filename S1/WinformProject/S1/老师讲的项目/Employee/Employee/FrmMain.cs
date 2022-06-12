using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiAddEmp_Click(object sender, EventArgs e)
        {
            //创建添加员工的窗体
            FrmAdd frmAdd = new FrmAdd();
            //父窗体
            frmAdd.MdiParent = this;
            //显示窗体
            frmAdd.Show();
        }
    }
}
