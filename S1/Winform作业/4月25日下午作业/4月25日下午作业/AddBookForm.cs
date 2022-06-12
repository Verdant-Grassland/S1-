using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4月25日下午作业
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Categories";
            SqlDataReader reader = DBHelper.DoReader(sql);
            cboCategory.Items.Add("请选择");
            cboCategory.SelectedIndex = 0;
            while (reader.Read())
            {
                cboCategory.Items.Add(reader["CategoryName"].ToString());
            }
            reader.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("图书标题不能为空！");
                        return;
                    }
                }
            }
            //图书类别
            int CategoryID = cboCategory.SelectedIndex;
            //日期
            DateTime dt = dtpPublishDate.Value;
            //获得日期年月日
            string PublishDate = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);
            string sql = @"Insert into Books(Title,Author,CategoryId,PublishDate,UnitPrice)
                  Values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + CategoryID + "','" + PublishDate + "','" + txtPrice.Text + "')";
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("恭喜，添加成功！","系统提示");
            }
            else
            {
                MessageBox.Show("添加失败！","系统提示");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
