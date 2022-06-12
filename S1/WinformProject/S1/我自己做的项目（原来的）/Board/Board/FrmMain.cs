using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            //建立新增窗体的对象
            FrmAdd frmAdd = new FrmAdd();
            //指向父窗体
            frmAdd.MdiParent = this;
            //显示窗体
            frmAdd.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }
    }
}
