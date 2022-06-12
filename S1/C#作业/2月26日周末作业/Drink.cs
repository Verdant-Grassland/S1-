using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
    class Drink
    {
        public string DrinkName;
        public string name = "";
        public string Taste()
        {
            if (DrinkName.Equals("咖啡"))
            {
                name = "苦";
            }
            else if (DrinkName.Equals("牛奶"))
            {
                name = "甜";
            }
            else if (DrinkName.Equals("柠檬"))
            {
                name = "酸";
            }
            return name;
        }
    }

    class TestDrink
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink();
            Console.WriteLine("输入饮料类型：");
            drink.DrinkName = Console.ReadLine();
            string RinkName = drink.Taste();
            Console.WriteLine(RinkName);
            Console.ReadLine();
        }
    }
}