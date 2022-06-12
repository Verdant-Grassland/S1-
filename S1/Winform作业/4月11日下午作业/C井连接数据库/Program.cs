using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C井连接数据库
{
    class DB
    {
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=BookStudioRecordingRoom;User ID=sa;Password=123456";
        SqlConnection con = new SqlConnection(conStr);

        #region 查询所有数据
        public SqlDataReader AllData()
        {
            try
            {
                con.Open();
                string sql = "Select * from BookRecord";
                SqlCommand command = new SqlCommand(sql, con);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 增加数据信息
        public int AddData(string name,string time,string Person,string Reason,string NotePerson)
        {
            try
            {
                con.Open();
                string sql = "Insert into BookRecord(RoomName, BookDate, BookPerson, BookReason, NotePerson) values('" + name + "'," + time +",'" + Person + "','"+Reason + "','" + NotePerson + "')";


                SqlCommand command = new SqlCommand(sql, con);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }

    class Manage
    {
        DB db = new DB();
        #region 菜单
        public void Menu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("=============欢迎录音室系统=============");
                Console.WriteLine("1.查询录音室所有数据");
                Console.WriteLine("2.添加用户");
                Console.WriteLine("3.退出系统");
                Console.WriteLine("========================================");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        AllData();
                        break;
                    case 2:
                        AddData();
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("退出系统，谢谢使用！");
                        break;
                }
            } while (true);
        }
        #endregion

        #region 查询所有数据
        public void AllData()
        {
            SqlDataReader reader = db.AllData();
            Console.WriteLine("编号\t名称\t预定时间\t预定人员\t预定原因\t录入人员"); 
            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}"
                    ,reader["RoomID"],reader["RoomName"],reader["BookDate"],reader["BookPerson"]
                    ,reader["BookReason"],reader["NotePerson"]);
            }
            reader.Close();
                    }
        #endregion

        #region 添加用户
        public void AddData()
        {
            Console.WriteLine("输入录音室名称：");
            string name = Console.ReadLine();
            Console.WriteLine("输入预定时间：");
            string time = Console.ReadLine();
            Console.WriteLine("输入预定人员：");
            string Person = Console.ReadLine();
            Console.WriteLine("输入预定原因：");
            string Reason = Console.ReadLine();
            Console.WriteLine("输入录入人员：");
            string NotePerson = Console.ReadLine();
            int result = db.AddData(name, time, Person, Reason, NotePerson);
            if (result > 0)
            {
                Console.WriteLine("添加成功");
            }
            else
            {
                Console.WriteLine("添加失败");
            }
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            manage.Menu();
            Console.ReadLine();
        }
    }
}
