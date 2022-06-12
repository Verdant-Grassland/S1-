using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class Animal 
    {
        public string cry(string word)
        {
            string name = "";
            if (word.Equals("狗"))
            {
                name = "旺旺";
            }
            else if (word.Equals("猪"))
            {
                name = "呼噜";
            }
            else if (word.Equals("猫"))
            {
                name = "喵喵";
            }
            return name;
        }
    }

    class TestAnimal
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
		    Console.WriteLine("输入动物的名称：");
            string name = Console.ReadLine();
            string onget = animal.cry(name);
		    Console.WriteLine(onget);
            Console.ReadLine();
        }
    }
}
