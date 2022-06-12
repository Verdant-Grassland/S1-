using System.Windows.Forms;

namespace SchoolForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tsmiAddStudent_Click(object sender, System.EventArgs e)
        {
            //创建新增窗体的对象
            FrmAddStudent frmStudent = new FrmAddStudent();
            //设置父窗体
            frmStudent.MdiParent = this;
            //显示窗体
            frmStudent.Show();
        }

        private void tsmiExit_Click(object sender, System.EventArgs e)
        {
            //退出整个应用程序
            Application.Exit();
        }

        private void tsmiSearchByName_Click(object sender, System.EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void tsmiHelp_Click(object sender, System.EventArgs e)
        {
            frmAbout frmHelp = new frmAbout();
            //模式窗体
            frmHelp.Show();
        }

        private void tsbtnSearchGrade_Click(object sender, System.EventArgs e)
        {
            //创建按年级查询窗体对象
            frmSearchGrade frm = new frmSearchGrade();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
