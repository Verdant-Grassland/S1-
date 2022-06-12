using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    public class Person
    {
        public string name;
        public int age;
        public string sex;
        public void showInfo()
        {
            Console.WriteLine("姓名是：" + name + "，年龄是：" + age + "，性别是：" + sex);
        }

    }

    class TestPerson
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("输入您的姓名：");
            person.name = Console.ReadLine();
            Console.WriteLine("输入您的年龄：");
            person.age = int.Parse(Console.ReadLine());
            Console.WriteLine("输入您的性别：");
            person.sex = Console.ReadLine();
            person.showInfo();
            Console.ReadLine();
        }
    }
}
