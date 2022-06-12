using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class Employee
    {
        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }
        private string name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sex;

        public String Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private int popularity;

        public int Popularity
        {
            get { return popularity; }
            set { popularity = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("职工号：{0}，姓名：{1}，性别：{2}，人气值：{3}",empNo,name,sex,popularity);
	    }
    }

    class TestEmployee
    {
        static void Main(string[] args) 
        {
            Employee work = new Employee();
            Console.WriteLine("输入您的职工号:");
            work.EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("输入您的姓名:");
            work.Name = Console.ReadLine();
            Console.WriteLine("输入您的性别:");
            work.Sex = Console.ReadLine();
            Console.WriteLine("输入您的人气值:");
            work.Popularity = int.Parse(Console.ReadLine());
            work.SayHi();
            Console.ReadLine();
        }
    }
}
