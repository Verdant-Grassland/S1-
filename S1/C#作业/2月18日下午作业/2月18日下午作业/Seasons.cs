using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    internal class Seasons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个月份：");
            int month = int.Parse(Console.ReadLine());
            if(month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("冬季");
            }
            else if(month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("春季");
            }
            else if(month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("夏季");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("秋季");
            }
            Console.ReadLine();
        }
    }
}
