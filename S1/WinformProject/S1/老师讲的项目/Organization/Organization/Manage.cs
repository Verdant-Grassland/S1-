using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Organization
{
    class Manage
    {
        DB db = new DB();

        #region 菜单
        public void ShowMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("====================请选择菜单项=============================");
                Console.WriteLine("\t\t1.显示所有信息");
                Console.WriteLine("\t\t2.添加信息");
                Console.WriteLine("\t\t3.修改信息");
                Console.WriteLine("\t\t4.删除信息");
                Console.WriteLine("\t\t5.退出");
                Console.WriteLine("============================================================");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        GetAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        flag = false;
                        Console.WriteLine("退出系统，谢谢使用！");
                        break;
                    default:
                        break;
                }
            } while (flag);

        }
        #endregion

        #region 查询所有
        public void GetAll()
        {
            SqlDataReader reader = db.GetAll();
            Console.WriteLine("编号\t社团名称\t负责任\t\t电话");
            //循环读取数据
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", reader["Id"], reader["name"], reader["principal"], reader["telephone"]);
            }
            reader.Close();
        }
        #endregion

        #region 增加功能
        public void Add()
        {
            Console.WriteLine("输入社团名称：");
            string name = Console.ReadLine();
            Console.WriteLine("输入社团的描述：");
            string desc = Console.ReadLine();
            Console.WriteLine("输入负责人的名称：");
            string principal = Console.ReadLine();
            Console.WriteLine("输入电话：");
            string phone = Console.ReadLine();
            Console.WriteLine("输入日期：");
            string date = Console.ReadLine();
            //调用DB中的增加方法
            int result = db.Add(name, desc, principal, phone, date);
            if (result>0)
            {
                Console.WriteLine("增加成功");
            }
            else
            {
                Console.WriteLine("增加失败");
            }
        }
        #endregion
    }
}
