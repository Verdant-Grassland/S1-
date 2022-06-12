using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class QNum
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    
                }
                else
                {
                    num = num + i;
                }
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
