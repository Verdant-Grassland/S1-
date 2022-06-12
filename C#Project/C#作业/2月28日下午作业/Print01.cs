using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class Print01
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int k = 1; k <= 3; k++)
            {
                for (int l = k * 2 - 1; l <= 5; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
