using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    internal class Tranum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入整数：");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            if(x > 0)
            {
                y = 1;
            }else if(x == 0)
            {
                y = 0;
            }
            else
            {
                y = -1;
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
