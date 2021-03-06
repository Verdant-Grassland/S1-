using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewIcon
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.LargeIcon;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.SmallIcon;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.Details;
        }

        private void tsmiBigIcon_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.LargeIcon;
        }

        private void tsmiSmallIcon_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.SmallIcon;
        }

        private void tsmiDetails_Click(object sender, EventArgs e)
        {
            this.lvComputer.View = View.Details;
        }
    }
}
