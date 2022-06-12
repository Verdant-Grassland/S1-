using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月05日周末作业
{
    class Student
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }

    class StudentBiz
    {
        Student[] student = new Student[3];
        public void stu()
        {
            Student student1 = new Student();
            student1.ID = 101001;
            student1.Name = "张丽丽";
            student1.Age = 15;
            student1.Sex = "女";
            student1.Score = 98;

            Student student2 = new Student();
            student2.ID = 101002;
            student2.Name = "李国强";
            student2.Age = 18;
            student2.Sex = "男";
            student2.Score = 76;

            Student student3 = new Student();
            student3.ID = 101003;
            student3.Name = "王思远";
            student3.Age = 17;
            student3.Sex = "男";
            student3.Score = 54;

            //将对象存到数组中
            student[0] = student1;
            student[1] = student2;
            student[2] = student3;
        }

        public void ShowStudent()
        {
            Console.WriteLine("学生基本信息列表");
            Console.WriteLine("-------------------------------");
            //遍历对象数组
            foreach (Student item in student)
            {
                Console.WriteLine("学生名称：" + item.Name);
            }
            Console.WriteLine("-------------------------------");
        }

        public void StuMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("\n=====================欢迎使用学生管理系统====================");
                Console.WriteLine(" 1:根据学生的考试成绩 2:取得学生的编号和年龄、性别  3:退出");
                Console.WriteLine("=============================================================");
                Console.WriteLine("请选择：");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("请输入学生的名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入学生的成绩分数：");
                        int score = int.Parse(Console.ReadLine());
                        string stu = GetStudent(name,score);
                        if (stu == null)
                        {
                            Console.WriteLine("没找到学生的名称");
                        }
                        else
                        {
                            Console.WriteLine(stu);
                        }
                        break;
                    case 2:
                        GetIDGex();
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("退出系统，谢谢使用！");
                        break;
                    default:
                        break;
                }
            } while (flag);
        }

        public string GetStudent(string name, int score)
        {
            foreach (Student stu in student)
            {
                if (stu.Name == name && stu.Score == score)
                {
                    return stu.Name + stu.Score;
                }
            }
            return null;
        }

        public void GetIDGex()
        {
            Student stu = new Student();
            foreach (Student item in student)
            {
                stu = item;
                Console.WriteLine("学生编号：" + item.ID + "，学生年龄：" + item.Age + "，学生性别：" + item.Sex);
            }
        }
    }

    class TestStudentBiz
    {
        static void Main(string[] args)
        {
            StudentBiz student = new StudentBiz();
            student.stu();
            student.ShowStudent();
            student.StuMenu();
            student.GetIDGex();
            Console.ReadLine();
        }
    }
}
