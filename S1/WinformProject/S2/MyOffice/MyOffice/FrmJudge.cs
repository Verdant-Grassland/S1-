using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class FrmJudge : Form
    {
        

        //填写评价的窗体类
        //保存父窗体的实例
        private FrmShow myParent;
        //要评价的员工对象
        private SE se;
        //父窗体的实例、被评分的员工在员工数组中的位置
        public FrmJudge(FrmShow frmShow, int index)
        {
            InitializeComponent();
            this.myParent = frmShow;
            //获取主窗体当前列表值
            this.se = frmShow.se[index];
        }

        private void FrmJudge_Load(object sender, EventArgs e)
        {
            //将列表值赋值给控件
            this.txtName.Text = se.Name;
            this.txtJudgement.Text = se.Judgement;
            this.txtScore.Text = se.Score.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                PM pm = new PM();
                //评分
                pm.Judge(se,this.txtJudgement.Text.Trim(),
                    int.Parse(txtScore.Text.Trim()));
                MessageBox.Show("评分成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //刷新主窗体
                this.myParent.UpdateView();
                //关闭窗体
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("评分失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information) + ex.ToString());
            }
        }
    }
}
