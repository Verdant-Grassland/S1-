using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteredDesign
{
    public partial class ManationDesignPage : Form
    {
        public ManationDesignPage()
        {
            InitializeComponent();
        }

        private void 设计文件SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrsignDoucuments drsign = new DrsignDoucuments();
            drsign.MdiParent = this;
            drsign.Show();
        }
    }
}
