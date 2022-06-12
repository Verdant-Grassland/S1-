using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInfo();
        }

        public void SearchInfo()
        {
            string sql = @"select  s.count,t.teamName hostTeamName,t1.teamName awayTeamName,s.pastScore,s.competitionTime,s.hostTeamScore,s.awayTeamScore
                    from   ScheduleInfo s
                    inner join TeamInfo t on s.hostTeamId=t.id
                    inner join TeamInfo t1 on s.awayTeamId=t1.id
                    where 1=1";
            if (txtName.Text!="")
            {
                sql += "  and t.teamName like '%" + txtName.Text + "%'";
            }
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }
    }
}
