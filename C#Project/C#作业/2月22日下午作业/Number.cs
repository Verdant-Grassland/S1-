using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class Number 
    {
        public void getMax(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("最大值是：" + a);
            }
            else
            {
                Console.WriteLine("最大值是：" + b);
            }
        }
    }
    
    class TestNumber
    {
        static void Main(string[] args)
        {
            Number num = new Number();
		    Console.WriteLine("输入a的值数：");
		    int a = int.Parse(Console.ReadLine());
		    Console.WriteLine("输入b的值数：");
		    int b = int.Parse(Console.ReadLine());
		    num.getMax(a, b);
            Console.ReadLine();
        }
    }
}
