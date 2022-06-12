using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiInput_Click(object sender, EventArgs e)
        {
            //创建录入商品的对象
            frmAdd frmAdd = new frmAdd();
            frmAdd.MdiParent = this;
            frmAdd.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            //创建查找窗体的对象
            frmSearch frmSearch = new frmSearch();
            //设置父窗人体
            frmSearch.MdiParent = this;
            //显示窗体
            frmSearch.Show();
        }
    }
}
