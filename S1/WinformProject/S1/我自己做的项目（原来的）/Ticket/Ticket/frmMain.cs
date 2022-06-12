using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //绑定下拉列表框
            string sql = "Select Id,CityName from CityInfo";
            //调用通用方法
            DataTable dt1 = DBHelper.DoQuery(sql);
            DataRow row = dt1.NewRow();
            row[0] = "-1";
            row[1] = "请选择";
            //将建立的新行插入到第一行
            dt1.Rows.InsertAt(row, 0);
            //组合框绑定数据
            this.cboLeave.DataSource = dt1;
            //显示的文字
            this.cboLeave.DisplayMember = "CityName";
            //提交的值
            this.cboLeave.ValueMember = "id";

            //第二个下拉列表框
            DataTable dt2 = DBHelper.DoQuery(sql);
            DataRow row2 = dt2.NewRow();
            row2[0] = "-1";
            row2[1] = "请选择";
            //将建立的新行插入到第一行
            dt2.Rows.InsertAt(row2, 0);
            //组合框绑定数据
            this.cboDest.DataSource = dt2;
            //显示的文字
            this.cboDest.DisplayMember = "CityName";
            //提交的值
            this.cboDest.ValueMember = "id";

            SearchInfo();
        }
        public void SearchInfo()
        {
            string sql = @"Select f.FlightNO,a.Airways,f.LeaveTime,f.LandTime,f.Price
                            from AirwaysInfo a
                            Inner join FlightInfo f on a.Id = f.AirwaysId
                            where 1 = 1";
            if (cboLeave.Text != "请选择" && cboDest.Text != "请选择")
            {
                sql += "    and LeaveCity = " + this.cboLeave.SelectedValue + "    and Destination = " + this.cboDest.SelectedValue + "";
            }
            DataTable dt = DBHelper.DoQuery(sql);
            //dgv数据源绑定
            this.dgvShow.DataSource = dt;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("没有查询到数据");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboLeave.Text == "请选择" || cboDest.Text == "请选择")
            {
                MessageBox.Show("请选择出发地和目的地");
                return;
            }
            SearchInfo();
        }

        private void dgvShow_Click(object sender, EventArgs e)
        {
            txtNo.Text = this.dgvShow.CurrentRow.Cells["FlightNO"].Value.ToString();
            txtAirways.Text = this.dgvShow.CurrentRow.Cells["Airways"].Value.ToString();
            txtLeave.Text = this.cboLeave.Text;
            txtDest.Text = this.cboDest.Text;
            txtTime.Text = this.dgvShow.CurrentRow.Cells["LeaveTime"].Value.ToString();
            txtLandTime.Text = this.dgvShow.CurrentRow.Cells["LandTime"].Value.ToString();
            txtPrice.Text = this.dgvShow.CurrentRow.Cells["Price"].Value.ToString();
        }
    }
}
