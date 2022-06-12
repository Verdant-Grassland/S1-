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

namespace Board
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
        //当窗体启动时发生的事件
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
            DataSet ds = new DataSet();
            
                
        }
        //查询方法
        public void SearchInfo()
        {
            //如果ListView控件中有数据，先将数据删除，然后在查询
            if (this.lvShow.Items.Count>0)
            {
                //清空数据
                this.lvShow.Items.Clear();
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select s.id,b.boardName,s.intendedName,s.startTime,s.duration,s.enteringName,s.reason");
            sb.AppendLine("from ScheduleInfo s");
            sb.AppendLine("inner join BoardroomInfo b on s.boardroomId=b.id");
            sb.AppendLine("where 1=1");
            //文本框查询
            if (txtName.Text!="")
            {
                sb.AppendFormat("  and intendedName like '%{0}%'",txtName.Text);
            }
            /*string sql = @"select s.id,b.boardName,s.intendedName,s.startTime,s.duration,s.enteringName,s.reason from ScheduleInfo s
                            inner join BoardroomInfo b on s.boardroomId=b.id 
                            where 1=1";
            if (txtName.Text!="")
            {
                sql += " and intendedName like '%"+txtName.Text+"%'";
            }*/
            //调用查询方法
            SqlDataReader reader = DBHelper.DoReader(sb.ToString());
            //循环读取数据
            while (reader.Read())
            {
                //建立ListViewItem的项
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                //添加子项
                item.SubItems.Add(reader["boardName"].ToString());
                item.SubItems.Add(reader["intendedName"].ToString());
                item.SubItems.Add(reader["startTime"].ToString());
                item.SubItems.Add(reader["duration"].ToString());
                item.SubItems.Add(reader["enteringName"].ToString());
                item.SubItems.Add(reader["reason"].ToString());
              // item.SubItems.AddRange(new string[] { reader["boardName"].ToString(), reader["intendedName"].ToString(), 
                  // reader["startTime"].ToString(), reader["duration"].ToString(), reader["enteringName"].ToString(), reader["reason"].ToString() });
                //将项添加到ListView控件
                this.lvShow.Items.Add(item);

            }
            reader.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }
    }
}
