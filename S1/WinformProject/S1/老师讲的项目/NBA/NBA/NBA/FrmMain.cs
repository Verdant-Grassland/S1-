using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            //创建添加窗体的对象
            FrmAdd frmAdd = new FrmAdd();
            //指向父窗体
            frmAdd.MdiParent = this;
            frmAdd.Show();

        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            //创建查询窗体的对象
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            //退出系统，关闭整个应用
            Application.Exit();
        }
    }
}
