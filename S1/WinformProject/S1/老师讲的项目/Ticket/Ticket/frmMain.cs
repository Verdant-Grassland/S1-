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
            string sql = "select Id,CityName from CityInfo";
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
            string sql=@"select  f.FlightNO,a.Airways,f.LeaveTime,f.LandTime,f.Price
                        from AirwaysInfo a
                        inner join FlightInfo f on a.Id=f.AirwaysId
                        where 1=1";
            if (cboLeave.Text!="请选择" && cboDest.Text!="请选择")
            {
                sql += "   and LeaveCity="+this.cboLeave.SelectedValue+"   and  Destination="+this.cboDest.SelectedValue+"";
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
            if (cboLeave.Text=="请选择" || cboDest.Text=="请选择") 
            {
                MessageBox.Show("请选择出发地和目的地");
                return;
            }
            SearchInfo();
        }

        private void dgvShow_Click(object sender, EventArgs e)
        {
            txtNo.Text = this.dgvShow.CurrentRow.Cells["FlightNO"].Value.ToString();
            txtAirWays.Text = this.dgvShow.CurrentRow.Cells["Airways"].Value.ToString();
            txtLeave.Text = this.cboLeave.Text;
            txtDest.Text = this.cboDest.Text;
            txtTime.Text = this.dgvShow.CurrentRow.Cells["LeaveTime"].Value.ToString();
            txtLandTime.Text = this.dgvShow.CurrentRow.Cells["LandTime"].Value.ToString();
            txtPrice.Text = this.dgvShow.CurrentRow.Cells["price"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空验证，出发日期要大于当前日期
            //DateTime.Now当前日期
            if (dtpLeaveDate.Value<DateTime.Now)
            {
                MessageBox.Show("出发日期要晚于当前日期");
                return;
            }
            
            //随机数对象
            Random random = new Random();
            //订单号获取 100000-999999之间
            int orderId = random.Next(100000, 999999);
            DateTime dt=dtpLeaveDate.Value;
            string leaveDate=string.Format("{0}-{1}-{2}",dt.Year,dt.Month,dt.Day);
            //添加sql语句
            string sql = string.Format(@"insert into OrderInfo(OrderId,FlightNo,LeaveDate,Number) 
                        values({0},'{1}','{2}',{3})", orderId, txtNo.Text, leaveDate, nudNumber.Value);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("添加成功");
                //刷新数据显示
                SearchInfo();
            }
            else
            {
                MessageBox.Show("添加失败");
            }

        }
    }
}
