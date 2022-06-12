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

namespace SchoolForm
{
    public partial class frmSearchGrade : Form
    {
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=MySchool0;User ID=sa;Password=123456";
        static SqlConnection con = new SqlConnection(conStr);
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        public frmSearchGrade()
        {
            InitializeComponent();
        }

        private void frmSearchGrade_Load(object sender, EventArgs e)
        {
            //填充年级
            string sql = "Select * from Grade";
            //创建一个DataSet临时数据集的对象
            DataSet ds = new DataSet();
            //建立SqlDataAdapter对象，作用是将数据库的信息运输到DataSet数据集
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //向DataSet中填充数据
            adapter.Fill(ds,"Grade");
            //建立一个数据表的对象
            DataTable dt = ds.Tables["Grade"];
            //建立新行
            DataRow row = dt.NewRow();
            row[0] = "-1";
            row[1] = "全部";
            //将新行插入到数据表里
            dt.Rows.InsertAt(row,0);
            //下拉列表绑定数据源
            this.cboGrade.DataSource = dt;
            //显示内容
            this.cboGrade.DisplayMember = "GradeName";
            //提交的内容
            this.cboGrade.ValueMember = "GradeID";
            //调用查询方法
            SearchInfo();
        }
        //查询按钮调用查询方法
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
        //查询方法
        public void SearchInfo()
        {
            //建立SQl语句
            string sql = @"Select s.StudentNo,s.StudentName,s.Gender,g.GradeName,s.Phone 
                           from Student s
                           Inner join Grade g on s.GradeId = g.GradeId
                           where 1 = 1";
            //按年级查询
            if (cboGrade.Text != "全部")
            {
                sql += "and s.GradeId = " + cboGrade.SelectedValue;   //SelectedValue提交下拉列表框的值
            }
            //数据绑定
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds, "Student");
            this.dgvShow.DataSource = ds.Tables["Student"];
            //this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
        //添加菜单的代码
        private void tsmiAddResult_Click(object sender, EventArgs e)
        {
            //获取学号
            int stuNo = Convert.ToInt32(this.dgvShow.CurrentRow.Cells["StudentNo"].Value);
            //创建添加成绩窗体的对象
            frmAddResult frmAdd = new frmAddResult();
            frmAdd.stuNo = stuNo;
            frmAdd.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要修改吗？", "提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Student");
                MessageBox.Show("修改成功");
            }
        }
        //当点中节点之后所发生的事件
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获得选中的节点
            TreeNode node = tvShow.SelectedNode;
            //如果节点是空的，返回到窗体
            if (node == null)
            {
                return;
            }
            //数据筛选的对象
            DataView dv = new DataView(ds.Tables["Student"]);
            //年级查询
            if (node.Level == 1)
            {
                //数据筛选
                dv.RowFilter = "GradeName = '" + node.Text + "'";
            }
            //性别
            if (node.Level == 2)
            {
                //获得选中的节点的tag值(male,female)
                string sex = node.Tag.ToString();
                //将sex值转换为枚举
                Gender gen = (Gender)Enum.Parse(typeof(Gender), sex);
                //node.Parent.Text父级文本
                dv.RowFilter = "GradeName = '" + node.Parent.Text + "' and Gender = " + (int)gen + "";
            }
            //dgv重新绑定数据
            this.dgvShow.DataSource = dv;
        }
    }
}
