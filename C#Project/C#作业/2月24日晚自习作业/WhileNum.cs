using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月24日晚自习作业
{
    internal class WhileNum
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 1;
            while (i <= 200)
            {
                if (i%3 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
