using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
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
            string sql = "select productId,productName,releaseDate,marketDate,price,Corporation,AddPerson from ProductInfo where 1=1";
            //文本框不为空
            if (txtName.Text!="")
            {
                sql += "   and productName like '%"+txtName.Text+"%'";
            }
            //dgv数据源绑定
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
    }
}
