using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    class Persons
    {
        public string name;
        public string height;
        public string weapon;
        public void showInfo()
        {
            Console.WriteLine("名字是：{0}，身高是：{1}，武器是：{2}",name,height,weapon);
        }
    }

    class TestPersons
    {
        static void Main(string[] args)
        {
            Persons zhuBaJie = new Persons();
            zhuBaJie.name = "猪八戒";
            Console.WriteLine("输入猪八戒的身高：");
            zhuBaJie.height = Console.ReadLine();
            Console.WriteLine("输入猪八戒的武器：");
            zhuBaJie.weapon = Console.ReadLine();
            zhuBaJie.showInfo();

            Persons sunWuKong = new Persons();
            sunWuKong.name = "孙悟空";
            Console.WriteLine("输入孙悟空的身高：");
            sunWuKong.height = Console.ReadLine();
            Console.WriteLine("输入孙悟空的武器：");
            sunWuKong.weapon = Console.ReadLine();
            sunWuKong.showInfo();
            Console.ReadLine();
        }
    }
}
