using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
    internal class OutputSix
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 300; i++)
            {
                int sum = i / 100 + i / 10 % 10 + i % 10;
                if (sum != 6) Console.WriteLine(i);
                else sum = 0;
            }
            Console.ReadLine();
        }
    }
}
