using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        //图象索引
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index<this.ilAbout.Images.Count-1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            //将imageList控件里的图片显示到PictureBox控件
            this.pcShow.Image = this.ilAbout.Images[index];
        }

        private void pbOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
