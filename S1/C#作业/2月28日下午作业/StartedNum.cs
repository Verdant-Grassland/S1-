using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class StartedNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入开始的数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("输入结束的数：");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                if (i % 3 == 0 && i % 4 == 0 && i % 5 == 0)  Console.WriteLine("可以被3 4 5同时整除的数是：" + i);
            }
            Console.ReadLine();
        }
    }
}
