using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QQManage
{
    class Manage
    {
        DB db = new DB();

        #region 登录
        public void Login()
        {
            Console.WriteLine("输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            bool flag = db.Login(name, pwd);
            if (flag)
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
        }
        #endregion

        #region 菜单
        public void ShowMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("=======欢迎登录QQ用户信息管理系统======");
                Console.WriteLine("----------------请选择菜单项----------");
                Console.WriteLine("1、显示用户清单");
                Console.WriteLine("2、更新在线天数");
                Console.WriteLine("3、添加用户新记录");
                Console.WriteLine("4、更新用户等级");
                Console.WriteLine("5、删除用户记录");
                Console.WriteLine("0、退出");
                Console.WriteLine("=======================================");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        GetAllUser();
                        break;
                    case 2:
                        UpdateDayById();
                        break;
                    case 3:
                        AddUser();
                        break;
                    case 4:
                        SelectUser();
                        break;
                    case 5:
                        DeleteUser();
                        break;
                    case 0:
                        Console.WriteLine("是否要退出呢？(y/n)");
                        string answer = Console.ReadLine();
                        if (answer.ToLower()=="y")
                        {
                            Console.WriteLine("退出系统");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("你取消的退出操作");
                        }
                        break;  
                }
            } while (flag);
        }
        #endregion

        #region 读取所有数据
        public void GetAllUser()
        {
            SqlDataReader reader = db.GetAllUser();
            Console.WriteLine("编号\t用户名\t\t等级\t邮箱\t\t\t在线天数");
            //循环读取数据
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", reader["UserId"], reader["UserName"], GetDesign(Convert.ToInt32(reader["LevelId"])), reader["Email"], reader["OnLineDay"]);
            }
            reader.Close();
        }

        #endregion

        #region 根据等级编号查询等级图案
        public string GetDesign(int id)
        {
            string name = "";
            if (id==1)
            {
                name = "-";
            }
            else if (id==2)
            {
                name = "★";
            }
            else if (id==3)
            {
                name = "€";
            }
            else if (id==4)
            {
                name = "◎";
            }
            else
            {
                name = "";
            }
            return name;
        }
        #endregion

        #region 根据编号更新在线天数
        public void UpdateDayById()
        {
            Console.WriteLine("输入用户编号：");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("输入在线天数：");
            double day = double.Parse(Console.ReadLine());
            int result = db.UpdateDayById(id, day);
            if (result>0)
            {
                Console.WriteLine("更新成功");
            }
            else
            {
                Console.WriteLine("更新失败");
            }
        }
        #endregion

        #region 增加用户
        public void AddUser()
        {
            Console.WriteLine("输入用户名称：");
            string name = Console.ReadLine();
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            Console.WriteLine("输入邮箱地址：");
            string email = Console.ReadLine();
            //调用方法
            int result = db.AddUser(name,pwd,email);
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

        #region 删除用户
        public void DeleteUser()
        {
            Console.WriteLine("输入用户编号：");
            int id = int.Parse(Console.ReadLine());
            //调用方法
            int result = db.DeleteUser(id);
            if (result>0)
            {
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("删除失败");
            }
        }
        #endregion

        #region 查询用户编号，在线天数
        public void SelectUser()
        {
            SqlDataReader reader = db.SelectUser();
        
            int userId = 0;
            double onlineDay = 0;
            //等级
            int level = 0;
            //更新的数据个数
            int count = 0;
           
            while (reader.Read())
            {
                //读取用户编号
                userId = Convert.ToInt32(reader["UserId"]);
                //读取在线天数
                onlineDay = Convert.ToDouble(reader["OnLineDay"]);
                //获得等级
                level = GetLevel(onlineDay);
                //调用根据用户编号更用户等级
                count+=db.UpdateLevel(userId, level);
            }
            reader.Close();
            Console.WriteLine("共更新了" + count + "条数据");
           
        }
        #endregion

        #region 根据在线天数获得等级
        public int GetLevel(double onlineDay)
        {
            int level = 0;
            if (onlineDay>=5 && onlineDay<=32)
            {
                level = 2;
            }
            else if (onlineDay>32 && onlineDay<=320)
            {
                level = 3;
            }
            else if (onlineDay>320)
            {
                level = 4;
            }
            else
            {
                level = 1;
            }
            return level;

        }
        #endregion

      

    }
}
