using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirQuality
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            string sql = "Select StationID,StationName from StationInfo";
            this.cboStationID.ValueMember = "StationID";
            this.cboStationID.DisplayMember = "StationName";
            this.cboStationID.DataSource = DBHelper.DoQuery(sql);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("所有信息均不能为空，请完善！", "操作提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            string sql = string.Format(@"Insert into AirQualityInfo(StationID,InputName,StartDate,EndDate,PM,Level,Notes)
                            Values({0},'{1}','{2}','{3}',{4},{5},'{6}')",cboStationID.SelectedValue,txtInputName.Text,txtStartDate.Text,txtEndDate.Text,txtPM.Text,txtLevel.Text,txtNotes.Text);
            int result = DBHelper.DoNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("数据已经成功保存", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("数据保存失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
