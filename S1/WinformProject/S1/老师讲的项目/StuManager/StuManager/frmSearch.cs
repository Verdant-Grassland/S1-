using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManager
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        //窗体启动的事件
        private void frmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {
            string sql = "select * from StuInfo where 1=1";
            //条件判断
            if (cboType.Text=="学员姓名")
            {
                sql += "  and name like '%"+txtSearch.Text+"%'";
            }
            else if (cboType.Text=="联系电话")
            {
                sql += "  and telephone like '%"+txtSearch.Text+"%'";
            }
            else if (cboType.Text=="家庭住址")
            {
                sql += "  and address like '%"+txtSearch.Text+"%'";
            }
            else if (cboType.Text=="身份证号")
            {
                sql += "  and idCard like '%"+txtSearch.Text+"%'";
            }
            DataTable dt=DBHelper.DoQuery(sql);
            if (dt==null || dt.Rows.Count==0)
            {
                MessageBox.Show("没有满足条件的学员信息！", "查询", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //数据源
            this.dgvShow.DataSource =dt ;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //非空验证
            if (cboType.Text=="")
            {
                MessageBox.Show("请选择查询类型！","类型",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (txtSearch.Text=="")
            {
                MessageBox.Show("请输入查询条件","条件",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            SearchInfo();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //获得id   Cells[0]获处第1列的数据
            int id = Convert.ToInt32(this.dgvShow.CurrentRow.Cells[0].Value);
            string sql = "delete from StuInfo where id="+id;
            DialogResult result = MessageBox.Show("确定要删除此条信息吗？","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result==DialogResult.OK)
            {
                //调用增，删，改方法
                int succ = DBHelper.DoNonQuery(sql);
                if (succ>0)
                {
                    MessageBox.Show("删除成功");
                    //调用查询方法
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
