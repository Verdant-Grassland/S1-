using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    public class Student
    {
        public int sno;
        public string sname;
        public int grade;
        public void showInfo()
        {
            Console.WriteLine("学号是：" + sno + "，姓名是：" + sname + "，成绩是：" + grade);
        }

    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("输入您的学号：");
            student.sno = int.Parse(Console.ReadLine());
            Console.WriteLine("输入您的姓名：");
            student.sname = Console.ReadLine();
            Console.WriteLine("输入您的成绩：");
            student.grade = int.Parse(Console.ReadLine());
            student.showInfo();
            Console.ReadLine();
        }
    }
}
