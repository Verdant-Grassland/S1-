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
    public partial class frmEmployeeSysMain : Form
    {
        public frmEmployeeSysMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsmiAddEmployee_Click(object sender, EventArgs e)
        {
            //创建添加员工的窗体
            frmAdd frmAdd = new frmAdd();
            //父窗体
            frmAdd.MdiParent = this;
            //显示窗体
            frmAdd.Show();
        }
    }
}
