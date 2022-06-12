using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirQuality
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
            string sql = @"Select s.StationName,a.InputName,a.StartDate,a.EndDate,a.PM,a.Level,a.Notes
                        from AirQualityInfo a
                        Inner join StationInfo s on a.AirQualityID = s.StationID where 1 = 1";
            if (txtInputName.Text != "")
            {
                sql += "and a.InputName like '%" + txtInputName.Text + "%'";
            }
            this.dgvShow.DataSource = DBHelper.DoQuery(sql);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
