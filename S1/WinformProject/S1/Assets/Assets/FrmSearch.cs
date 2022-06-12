using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
        //窗体启动事件
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            //下拉列表框第一个选中
            cboType.SelectedIndex = 0;
            //查询方法
            SearchInfo();
        }
        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
        //查询方法
        public void SearchInfo()
        {
            string sql = "Select id,assetId,assetName,assetType,intoDate from assets where 1 = 1";
            //资产编号查询
            if (txtId.Text != "")
            {
                sql += "    and assetId like '%" + txtId.Text + "%'";
            }
            //下拉列表查询
            if (cboType.Text != "请选择类型")
            {
                sql += "    and assetType = '" + cboType.Text + "'";
            }
            //绑定dgv
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
    }
}
