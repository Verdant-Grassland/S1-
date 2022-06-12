using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class Print04
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "X" + i + "=" + i * j + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
