using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class Vehicle
    {
        public int speed;
        public int Size;
        public void show()
        {
            Console.WriteLine("汽车的速度是：{0}，汽车的体积是：{1}", speed, Size);
        }

        public void SpeedUp(int spe)
        {
            speed = speed + spe;
            Console.WriteLine("汽车的速度是：{0}，汽车的体积是：{1}", speed, Size);
        }

        public void SpeedDown(int spe)
        {
            speed = speed - spe;
            Console.WriteLine("汽车的速度是：{0}，汽车的体积是：{1}", speed, Size);
        }
    }

    class TestVehicle
    {
        static void Main(string[] args)
        {
            Vehicle bux = new Vehicle();
            bux.show();
            Console.WriteLine("输入您的汽车速度:");
            bux.speed = int.Parse(Console.ReadLine());
            bux.SpeedUp(bux.speed);
            Console.WriteLine("输入您的汽车体积:");
            bux.Size = int.Parse(Console.ReadLine());
            bux.SpeedDown(bux.Size);
            Console.ReadLine();
        }
    }
 }
