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

namespace Mobile
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //SQL语句
            string sql = "Select brandId,brand from MobileBrand";
            DataTable dt = DBHelper.DoQuery(sql);
            //建立新行
            DataRow row = dt.NewRow();
            row[0] = -1;
            row[1] = "请选择";
            //将新行加入到DataTable
            dt.Rows.InsertAt(row, 0);
            //下了列表框数据源绑定
            cboBrand.DataSource = dt;
            //显示内容
            cboBrand.DisplayMember = "brand";
            //提交的值
            cboBrand.ValueMember = "brandId";

            //调用查询方法
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {
            //清空原有数据
            if (this.lvShow.Items.Count > 0)
            {
                this.lvShow.Items.Clear();
            }
            string sql = @"Select b.brand,i.id,i.type,i.price,i.size,i.weight,i.style
                        from MobileInfo i
                        Inner join MobileBrand b on i.brandId = b.brandId
                        Where 1 = 1";
            //条件处理
            if (cboBrand.Text != "请选择")
            {
                sql += "    and i.brandId = " + cboBrand.SelectedValue;
            }
            //ListView绑定数据
            SqlDataReader reader = DBHelper.DoReader(sql);
            //循环读取数据
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                //添加子项
                item.SubItems.Add(reader["brand"].ToString());
                item.SubItems.Add(reader["type"].ToString());
                item.SubItems.Add(reader["price"].ToString());
                item.SubItems.Add(reader["size"].ToString());
                item.SubItems.Add(reader["weight"].ToString());
                item.SubItems.Add(reader["style"].ToString());
                //将项添加ListView控件
                lvShow.Items.Add(item);
            }
            reader.Close();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除此条信息吗？", "提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //获得ID
                int id = Convert.ToInt32(this.lvShow.SelectedItems[0].Text);
                string sql = "Delete from MobileInfo Where id = " + id;
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
