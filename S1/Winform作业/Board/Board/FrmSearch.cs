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
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=BoardScheduleManager;User ID=sa;Password=123456";
        static SqlConnection con = new SqlConnection(conStr);

        public FrmSearch()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }
        public void SearchInfo()
        {
            if (this.dgvShow.Rows.Count > 0)
            {
                this.dgvShow.Rows.Clear();
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Select s.id,b.boardName,s.intendedName,s.startTime,s.duration,s.enteringName,s.reason");
            sb.AppendLine("from BoardroomInfo s");
            sb.AppendLine("Inner join Schedulelnfo b on s.boardroomId = b.id");
            sb.AppendLine("where 1 = 1");
            if (txtName.Text != "")
            {
                sb.AppendFormat("   and intendedName like '%{0}%'", txtName.Text);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(),con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BoardroomInfo");
            DataTable dt = ds.Tables["BoardroomInfo"];
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                   dgvShow.Rows.Add(
                      dr["id"].ToString(),
                      dr["boardName"].ToString(),
                      dr["intendedName"].ToString(),
                      dr["startTime"].ToString(),
                      dr["duration"].ToString(),
                      dr["enteringName"].ToString(),
                      dr["reason"].ToString()
                      );
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void btnClose_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
