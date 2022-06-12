using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class Car
    {
        public string goodLuck(int money)
        {
            string name = "";
            if (money >= 500)
            {
                name = "买凯迪拉克";
            }
            else if (money >= 100 && money <= 500)
            {
                name = "买帕萨特";
            }
            else if (money >= 50 && money <= 100)
            {
                name = "买依兰特";
            }
            else if (money >= 10 && money <= 50)
            {
                name = "买奥托";
            }
            else if (money <= 10)
            {
                name = "买捷安特";
            }
            return name;
        }
    }

    class TestCar 
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("输入我的存款：");
            int num = int.Parse(Console.ReadLine());
            String carest = car.goodLuck(num);
            Console.WriteLine(carest);
            Console.ReadLine();
        }
    }
}
