using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrSys
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            string sql = "select DeptId,DeptName from DepartMent";
            //调用查询的通用方法
            DataTable dt = DBHelper.DoQuery(sql);
            //DataTable增加一行
            DataRow row = dt.NewRow();
            row[0] = -1;
            row[1] = "全部";
            //将行加入到DataTable的第一行上
            dt.Rows.InsertAt(row, 0);
            //下拉列表框数据绑定
            this.cboDept.DataSource = dt;
            //显示的内容
            this.cboDept.DisplayMember = "DeptName";
            //实际提交的值
            this.cboDept.ValueMember = "DeptId";

            SearchInfo();
        }
        //查询方法
        public void SearchInfo()
        {
            string sql = @"select d.DeptName,a.StaffName,a.AttendDate,a.AttendIn,a.AttendOut,a.Remark,a.AttendId
                        from Attendence a
                        inner join DepartMent d on a.DeptId=d.DeptId where 1=1";
            //部门查询
            if (cboDept.Text!="全部")
            {
                sql += "  and a.DeptId="+this.cboDept.SelectedValue;
            }
            //姓名查询
            if (txtName.Text!="")
            {
                sql += "  and StaffName like '%"+txtName.Text+"%'";
            }
            //dgv数据绑定
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
        //修改菜单
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            //获得编号
            int id = Convert.ToInt32(this.dgvShow.CurrentRow.Cells["AttendId"].Value);
            FrmUpdate frm = new FrmUpdate();
            //编号赋值
            frm.id = id;
            //名字
            frm.lblUser.Text = this.dgvShow.CurrentRow.Cells["StaffName"].Value.ToString();
            //部门
            frm.lblDeptName.Text = this.dgvShow.CurrentRow.Cells["DeptName"].Value.ToString();
            //日期
            frm.lblShowDate.Text=this.dgvShow.CurrentRow.Cells["AttendDate"].Value.ToString();
            //签到日期
            frm.txtIn.Text=this.dgvShow.CurrentRow.Cells["AttendIn"].Value.ToString();
            //签退日期
            frm.txtOut.Text=this.dgvShow.CurrentRow.Cells["AttendOut"].Value.ToString();
            //备注
            frm.txtRemark.Text = this.dgvShow.CurrentRow.Cells["Remark"].Value.ToString();
            //修改窗体中frmSearch对象赋值
            frm.frmSearch = this;
            frm.Show();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //获得ID
            int id = Convert.ToInt32(this.dgvShow.CurrentRow.Cells["AttendId"].Value);
            //SQL语句
            string sql = "delete from Attendence where AttendId="+id;
            //删除提示
            DialogResult result = MessageBox.Show("确定要删除此条信息吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result==DialogResult.OK)
            {
                //调用通用方法
                int succ = DBHelper.DoNonQuery(sql);
                if (succ > 0)
                {
                    MessageBox.Show("删除成功");
                    //刷新数据显示
                    SearchInfo();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
}
