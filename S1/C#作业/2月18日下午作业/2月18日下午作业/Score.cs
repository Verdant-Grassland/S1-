using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    internal class Score
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入java的成绩：");
            int num = int.Parse(Console.ReadLine());
            if(num >= 85 && num <= 100)
            {
                Console.WriteLine("优秀");
            }
            else if(num >= 75 && num <= 85)
            {
                Console.WriteLine("良好");
            }
            else if(num >= 75 && num <= 60)
            {
                Console.WriteLine("及格");
            }
            else
            {
                Console.WriteLine("不及格");
            }
            Console.ReadLine();
        }
    }
}
