using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManager
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("填写内容均不能为空！");
                    }
                }
            }
            string sql = string.Format(@"Insert into ComputerInfo(ComputerId,Brand,CPU,Memory,HardDisk,Employee)
                  values('{0}','{1}','{2}',{3},{4},'{5}')", txtComputerId.Text,txtBrand.Text,txtCPU.Text,txtMemory.Text,txtHardDisk.Text,txtEmployee.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("提交成功！");
            }
            else
            {
                MessageBox.Show("提交失败！");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
