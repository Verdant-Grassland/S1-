﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月20日下午作业
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.MdiParent = this;
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
