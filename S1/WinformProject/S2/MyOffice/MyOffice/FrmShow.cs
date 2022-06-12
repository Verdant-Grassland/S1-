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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
            //初始化SE集合
            this.Init();
            //刷新显示
            this.UpdateView();
        }
        //定义员工数组
        public SE[] se = new SE[3];
        //完成数据的初始化
        public void Init()
        {
            se[0] = new SE() { Id = 111, Name = "王小毛", Age = 26, Judgement = "未评价", Score = 0 };
            se[1] = new SE() { Id = 112, Name = "周新雨", Age = 22, Judgement = "未评价", Score = 0 };
            se[2] = new SE() { Id = 113, Name = "张烨", Age = 30, Judgement = "未评价", Score = 0 };
        }
        //省略初始化员工信息的Init方法
        //数据绑定到ListView对象lvShow上
        public void UpdateView()
        {
            //清空信息
            lvShow.Items.Clear();
            for (int i = 0; i < se.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = se[i].Id.ToString();
                //设置姓名
                item.SubItems.Add(se[i].Name);
                //设置年龄
                item.SubItems.Add(se[i].Age.ToString());
                //设置评分
                item.SubItems.Add(se[i].Score.ToString());
                //设置评价
                item.SubItems.Add(se[i].Judgement.ToString());
                //添加项
                this.lvShow.Items.Add(item);
            }
        }

        private void lvShow_DoubleClick(object sender, EventArgs e)
        {
            //获取当前选中的SE对象
            if (this.lvShow.SelectedItems.Count == 0)
            {
                //必须先选中一行
                return;
            }
            int index = 0;
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i].Id.ToString() == this.lvShow.SelectedItems[0].Text.Trim())
                {
                    index = i;
                    break;
                }
            }
            //对选中对象评分
            FrmJudge frm = new FrmJudge(this, index);
            frm.Show();
        }
    }
}
