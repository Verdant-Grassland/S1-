using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月24日晚自习作业
{
    internal class StuScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入学生考试等级：");
            int num = int.Parse(Console.ReadLine());
            if(num >= 90 == num <= 100)
            {
                Console.WriteLine("优秀");
            }else if(num >= 80 && num <= 89)
            {
                Console.WriteLine("良好");
            }else if(num >= 70 && num <= 79)
            {
                Console.WriteLine("中等");
            }else if(num >= 60 && num <= 69)
            {
                Console.WriteLine("及格");
            }else if(num >= 0 && num <= 59)
            {
                Console.WriteLine("不及格");
            }
            Console.ReadLine();
        }
    }
}
