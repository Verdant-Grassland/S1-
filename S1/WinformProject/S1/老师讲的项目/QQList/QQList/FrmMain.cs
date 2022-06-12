using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立项
            ListViewItem itemA = new ListViewItem("小强");
            //项的图象编号
            itemA.ImageIndex = 0;
            //添加子项
            itemA.SubItems.Add("12364551");
            itemA.SubItems.Add("男");
            itemA.SubItems.Add("18");


            //建立项
            ListViewItem itemB = new ListViewItem("小云");
            itemB.ImageIndex = 1;
            //添加子项
            itemB.SubItems.Add("78965456");
            itemB.SubItems.Add("女");
            itemB.SubItems.Add("19");

            //建立项
            ListViewItem itemC = new ListViewItem("小刚");
            itemC.ImageIndex = 2;
            //添加子项
            itemC.SubItems.Add("12356989");
            itemC.SubItems.Add("男");
            itemC.SubItems.Add("20");

            //将项加入到ListView控件
            this.lvShow.Items.Add(itemA);
            this.lvShow.Items.Add(itemB);
            this.lvShow.Items.Add(itemC);
        }
    }
}
