using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4月25日下午作业
{
    public partial class BookManagementSysForm : Form
    {
        public BookManagementSysForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsmiAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.MdiParent = this;
            addBookForm.Show();
        }
    }
}
