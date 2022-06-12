using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList_Office
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //构建集合对象，使用Add方法添加元素
            //建立部门员工（工程师）集合
            Hashtable hashtable = new Hashtable();
            #region 初始化3个工程师员工
            SE se = new SE();
            se.Name = "王小毛";
            se.Age = 26;
            se.ID = "000";
            se.Popularity = 10;

            SE se1 = new SE();
            se1.Name = "周新雨";
            se1.Age = 22;
            se1.ID = "111";
            se1.Popularity = 20;

            SE se2 = new SE();
            se2.Name = "张烨";
            se2.Age = 30;
            se2.ID = "222";
            se2.Popularity = 20;
            #endregion

            #region 使用集合初始化器构建员工集合
            /*ArrayList array = new ArrayList()
            {
                new SE(){Name = "王小毛",Age = 26,ID = 000,Popularity = 10},
                new SE(){Name = "周新雨",Age = 22,ID = 111,Popularity = 20},
                new SE(){Name = "张烨",Age = 30,ID = 222,Popularity = 20}
            };*/
            #endregion

            #region 添加元素
            hashtable.Add(se.ID, se);
            hashtable.Add(se1.ID, se1);
            hashtable.Add(se2.ID, se2);

            //打印集合中元素的数量
            MessageBox.Show(string.Format("部门共包括{0}个工程师。", hashtable.Count.ToString()));
            #endregion

            #region 存取单个元素
            SE ses = (SE)hashtable["000"];
            MessageBox.Show(ses.SayHi());
            #endregion

            #region 元素遍历
            //遍历key
            foreach (Object obj in hashtable.Keys)
            {
                Console.WriteLine((string)obj);
            }

            //遍历value
            foreach (Object obj in hashtable.Values)
            {
                SE es = (SE)obj;
                Console.WriteLine(es.Name);
            }

            //遍历Hashtable的键/值对
            foreach (DictionaryEntry en in hashtable)
            {
                Console.WriteLine(en.Key);
                Console.WriteLine(((SE)en.Value).Name);
            }
            #endregion

            #region 删除元素
            //删除索引为0的元素
            /*hashtable.RemoveAt(0);*/
            //删除对象名为se2的元素
            /*hashtable.Remove(se2);*/
            //根据key删除元素
            hashtable.Remove("000");

            //打印当前集合数目
            MessageBox.Show(string.Format("部门共包括{0}个工程师。", hashtable.Count.ToString()));

            /*SE leave = (SE)hashtable[0];
            MessageBox.Show(leave.SayHi(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //清空集合中的元素
            hashtable.Clear();
            MessageBox.Show(string.Format("部门共包括{0}个工程师。", hashtable.Count.ToString()));*/
            #endregion
            }
        }
    }

