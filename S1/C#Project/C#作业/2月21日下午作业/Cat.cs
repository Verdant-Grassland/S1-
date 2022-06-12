using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    class Cat
    {
        public string name;
        public string color;
        public int age;
        public void showCat()
        {
            Console.WriteLine("名字是：{0}，毛色是：{1}，年龄是：{2}",name,color,age);
        }
        public void ShowCatSout()
        {
            Console.WriteLine("猫的喊叫：喵喵喵～");
        }

        class TestCat
        {
            static void Main(string[] args)
            {
                Cat cat = new Cat();
                Console.WriteLine("输入猫的名字：");
                cat.name = Console.ReadLine();
                Console.WriteLine("输入猫的毛色：");
                cat.color = Console.ReadLine();
                Console.WriteLine("输入猫的年龄：");
                cat.age = int.Parse(Console.ReadLine());
                cat.showCat();
                cat.ShowCatSout();
                Console.ReadLine();
            }
        }
    }
}
