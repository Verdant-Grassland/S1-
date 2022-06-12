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
    public partial class FrmUpdate : Form
    {
        //创建一个员工编号
        public int id;
        //创建查询窗体的对象
        public FrmSearch frmSearch;
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {

        }
        //保存按钮的代码
        private void btnSave_Click(object sender, EventArgs e)
        {
            //修改
            string sql = string.Format(@"update Attendence 
                         set AttendIn='{0}',AttendOut='{1}',Remark='{2}' where AttendId={3}",txtIn.Text,txtOut.Text,txtRemark.Text,id);
            //调用通用方法
            int result = DBHelper.DoNonQuery(sql);
            if (result>0)
            {
                MessageBox.Show("修改成功");
                //隐藏当前窗体
                this.Hide();
                //刷新查询窗体数据显示
                frmSearch.SearchInfo();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
