using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class Print03
    {
        static void Main(string[] args)
        {
            Console.Write("请输入直角三角形的行数：");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
