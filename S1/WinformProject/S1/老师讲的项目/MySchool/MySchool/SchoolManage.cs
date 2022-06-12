using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySchool
{
   
    class SchoolManage
    {
        DB db = new DB();

        #region 登录
        public void Login()
        {
            Console.WriteLine("输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            //调用登录方法
            if (db.Login(name,pwd))
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
        }
        #endregion

        #region 统计记录
        public void GetCount()
        { 
            //调用方法
            int count = db.GetCount();
            Console.WriteLine("学生人数是:"+count+"人");
        }
        #endregion

        #region 菜单
        public void ShowMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("=====================请选择操作键=========================");
                Console.WriteLine("1.查询学生数量");
                Console.WriteLine("2.查询指定学生用户列表");
                Console.WriteLine("3.查询指定学生姓名");
                Console.WriteLine("4.查询制定学生的所有基本信息");
                Console.WriteLine("5.插入年级信息");
                Console.WriteLine("6.修改学生生日信息");
                Console.WriteLine("7.删除学生信息");
                Console.WriteLine("8.计算所有同学的平均分");
                Console.WriteLine("9.根据电话查询");
                Console.WriteLine("0.退出");
                Console.WriteLine("=============================================================");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case  1:
                        GetCount();
                        break;
                    case 2:
                        GetAllStudent();
                        break;
                    case 3:
                        GetStudentByNo();
                        break;
                    case 4:
                        SearchByName();
                        break;
                    case 5:
                        AddGrade();
                        break;
                    case 6:
                        UpdateDate();
                        break;
                    case 7:
                        DeleteStudent();
                        break;
                    case 8:
                        GetAvg();
                        break;
                    case 9:
                        SearchPhone();
                        break;
                    case 0:
                        flag = false;
                        Console.WriteLine("谢谢使用");
                        break;
                }
            } while (flag);
        }
        #endregion

        #region 计算平均分
        public void GetAvg()
        {
            int avg = db.GetAvg();
            Console.WriteLine("平均分是："+avg);
        }
        #endregion

        #region 读取数据
        public void GetAllStudent()
        {
            SqlDataReader reader = db.GetStudentList();
            Console.WriteLine("学号\t\t姓名\t\t\t电话");
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}", reader["StudentNo"], reader["StudentName"],reader["phone"]);
            }
            reader.Close();
        }
        #endregion

        #region 按学号读名字
        public void GetStudentByNo()
        {
            Console.WriteLine("输入学号：");
            string stuNo = Console.ReadLine();
            string name = db.GetNameByNo(stuNo);
            if (name==null || name=="")
            {
                Console.WriteLine("没有此人");
            }
            else
            {
                Console.WriteLine(stuNo+"的学生名字是:"+name);
            }
        }
        #endregion

        #region 按名字读数据
        public void SearchByName()
        {
            Console.WriteLine("输入名字：");
            string name = Console.ReadLine();
            SqlDataReader reader = db.SearchByName(name);
            Console.WriteLine("学号\t\t名字\t\t电话\t\t地址");
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}",reader["studentNo"],reader["studentName"],reader["phone"],reader["address"]);
            }
            reader.Close();
        }
        #endregion

        #region 按电话读取信息
        public void SearchPhone()
        {
            Console.WriteLine("输入电话：");
            string phone = Console.ReadLine();
            //调用业务方法
            SqlDataReader reader = db.GetStudentByPhone(phone);
            Console.WriteLine("学号\t\t名字\t\t电话\t\t地址");
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", reader["studentNo"], reader["studentName"], reader["phone"], reader["address"]);
            }
            reader.Close();
        }
        #endregion

        #region 增加年级
        public void AddGrade()
        {
            Console.WriteLine("输入年级：");
            string gradeName = Console.ReadLine();
            int result = db.AddGrade(gradeName);
            if (result>0)
            {
                Console.WriteLine("增加年级成功");
            }
            else
            {
                Console.WriteLine("增加年级失败");
            }
        }
        #endregion

        #region 修改日期
        public void UpdateDate()
        {
            Console.WriteLine("输入学号：");
            string stuNo = Console.ReadLine();
            Console.WriteLine("输入日期：");
            string date = Console.ReadLine();
            int result = db.UpdateDate(stuNo, date);
            if (result>0)
            {
                Console.WriteLine("修改成功");
            }
            else
            {
                Console.WriteLine("修改失败");
            }
        }
        #endregion

        #region 删除学生
        public void DeleteStudent()
        {
            Console.WriteLine("输入学号：");
            string stuNo = Console.ReadLine();
            //调用通过学号查询学生的方法
            string name = db.GetNameByNo(stuNo);
            Console.WriteLine("确实要删除学号是"+stuNo+",学生名字是:"+name+"的记录吗？(y/n)");
            string answer = Console.ReadLine();
            if (answer=="y")
            {
                //调用业务方法
                int result = db.DeleteStudent(stuNo);
                if (result>0)
                {
                    Console.WriteLine("删除成功");
                }
                else
                {
                    Console.WriteLine("删除失败");
                }
            }
            else
            {
                Console.WriteLine("你取消了删除操作");
            }
        }
        #endregion

    }
}
