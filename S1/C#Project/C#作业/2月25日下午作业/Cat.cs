using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class Cat
    {
        private int cid;

        public int Cid
        {
            get { return cid; }
            set
            {
                cid = value;
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    age = value;
                }
                else
                {
                    age = 5;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("您的/动物编号是：{0} ，您的/动物编名字是：{1} ，您的/动物编年龄是：{2}", cid, name, age);
        }
    }

    class TestCat
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.Write("输入您的/动物编号：");
            cat.Cid = int.Parse(Console.ReadLine());
            Console.Write("输入您的/动物名字：");
            cat.Name = Console.ReadLine();
            Console.Write("输入您的/动物年龄：");
            cat.Age = int.Parse(Console.ReadLine());
            cat.show();
            Console.ReadLine();
        }
    }
}
