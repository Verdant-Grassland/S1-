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

namespace _4月23日周末作业
{
    public partial class frmAddPhone : Form
    {
        public frmAddPhone()
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
                        MessageBox.Show("请输入所有手机信息！","提示");
                        return;
                    }
                }
            }
            AddPhone();
        }

        private void frmAddPhone_Load(object sender, EventArgs e)
        {
            string sql = "Select * from MobileBrand";
            SqlDataReader reader = DBHelper.DoReader(sql);
            cboName.Items.Add("请选择");
            cboName.SelectedIndex = 0;
            while (reader.Read())
            {
                cboName.Items.Add(reader["Brand"].ToString());
            }
            reader.Close();
        }

        public void AddPhone()
        {
            //手机品牌
            int BrandID = cboName.SelectedIndex;
            //添加功能
            string sql = @"Insert into MobileInfo(BrandID,Type,Price,Size,Weight,Style)
                Values ('" + BrandID + "','" + txtModel.Text + "','" + txtPrice.Text + "','" + txtSize.Text + "','" + txtWeight.Text + "','" + txtStyle.Text + "')";
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
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
