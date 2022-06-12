using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FlowerProject
{
    class Manage
    {

        DB db = new DB();

        #region 菜单
        public void Menu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("=======================请选择操作==============================");
                Console.WriteLine("1.查看全部花蕊信息");
                Console.WriteLine("2.统计所有花的数量");
                Console.WriteLine("3.修改花蕊信息");
                Console.WriteLine("4.删除花蕊信息");
                Console.WriteLine("0.退出");
                Console.WriteLine("==============================================================");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        SelectAll();
                        break;
                    case 2:
                        GetCount();
                        break;
                    case 3:
                        UpdateFlower();
                        break;
                    case 4:
                        DeleteFlower();
                        break;
                    case 0:
                        flag = false;
                        Console.WriteLine("谢谢使用");
                        break; 
                    default:
                        break;
                }
            } while (flag);
        }
        #endregion

        #region 读取所有花
        public void SelectAll()
        {
            //调用DB类中的的查询方法
            SqlDataReader reader = db.GetAll();
            Console.WriteLine("编号\t花名\t别名\t\t价格\t产地");
            //循环读取数据
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}", reader["id"], reader["name"], reader["anothername"], reader["price"], reader["production"]);
            }
            reader.Close();
        }
        #endregion

        #region 统计所有花的信息
        public void GetCount()
        { 
            //调用方法
            int count = db.GetAllCount();
            Console.WriteLine("共有"+count+"条花的记录");
        }
        #endregion

        #region 修改花的信息
        public void UpdateFlower()
        {
            Console.WriteLine("输入编号：");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("输入花名：");
            string name = Console.ReadLine();
            Console.WriteLine("输入花的价格：");
            int price = int.Parse(Console.ReadLine());

            int result = db.UpdateFlower(id, name, price);
            if (result>0)
            {
                Console.WriteLine("修改成功");
                //调取查询所有花的方法
                SelectAll();
            }
            else
            {
                Console.WriteLine("修改失败");
            }
        }
        #endregion

        #region 删除
        public void DeleteFlower()
        {
            Console.WriteLine("输入编号：");
            int id = int.Parse(Console.ReadLine());
            //调用删除方法
            int result = db.DeleteFlower(id);
            if (result>0)
            {
                Console.WriteLine("删除成功");
                SelectAll();
            }
            else
            {
                Console.WriteLine("删除失败");
            }
        }
        #endregion
    }
}
