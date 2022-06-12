using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    public class Animal
    {
        public string name;
        public int legs;
        public void showInfo()
        {
            Console.WriteLine("动物的名字是：" + name + "，动物的条腿是：" + legs);
        }

    }

    class TestAnimal
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("输入动物的名字：");
            animal.name = Console.ReadLine();
            Console.WriteLine("输入动物的条腿：");
            animal.legs = int.Parse(Console.ReadLine());
            animal.showInfo();
            Console.ReadLine();
        }
    }
}
