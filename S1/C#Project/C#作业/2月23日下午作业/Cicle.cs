using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class Cicle
    {
        public double r;
        public double Circular()
        {
		double area = 0;
		area = 3.14 * r * r;
		Console.WriteLine(area);
		return area;
	    }
    }

    class TestCicle
    {
        static void Main(string[] args)
        {
            Cicle cocle = new Cicle();
		    Console.WriteLine("输入半径:");
		    cocle.r = int.Parse(Console.ReadLine());
		    double radius = cocle.Circular();
		    Console.WriteLine(radius);
            Console.ReadLine();
        }
    }
}
