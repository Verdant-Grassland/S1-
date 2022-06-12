using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日晚自习作业
{
    class Print
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < i - 5; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("22");
            }
            Console.ReadLine();
        }
    }
}
