using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class Animal
    {
        public string name;
        public int legs;
        public void show()
        {
            Console.WriteLine("动物的名字：{0}，动物的腿的条数：{1}",name,legs);
        }
    }

    class TestAnimal
    {
        static void main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("请输入动物的名字：");
            animal.name = Console.ReadLine();
            animal.legs = int.Parse(Console.ReadLine());
            animal.show();
            Console.ReadLine();
        }
    }
}
