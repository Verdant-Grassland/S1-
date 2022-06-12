using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class Car
    {
        public string name;
        public string color;
        public void show()
        {
            Console.WriteLine("品牌名:" + name + "\n颜色:" + color);
        }
        public void Run()
        {
            Console.WriteLine("汽车以20000/秒的速度行驶着");
        }
        public void stop()
        {
            Console.WriteLine("汽车停止了");
        }
    }

    class TestCar
    { 
        static void Main(string[] args)
        {
            Car Drive = new Car();
		    Console.WriteLine("输入您的车品牌名称:");
		    Drive.name = Console.ReadLine();
		    Console.WriteLine("输入您的车颜色:");
            Drive.color = Console.ReadLine();
		    Drive.show();
		    Drive.Run();
		    Drive.stop();
            Console.ReadLine();
	    }
    }
}
