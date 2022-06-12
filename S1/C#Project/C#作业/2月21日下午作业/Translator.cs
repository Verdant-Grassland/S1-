using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    internal class Translator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* * * * * *欢迎使用Mini转换器* * * * * *");
            bool weather = false;
            do
            {
                Console.Write("请输入天气状况的第一个英文字母：");
                char sun = char.Parse(Console.ReadLine());
                switch (sun)
                {
                    case 'D':
                        Console.WriteLine("干燥");
                        break;
                    case 'M':
                        Console.WriteLine("潮湿");
                        break;
                    case 'H':
                        Console.WriteLine("炎热");
                        break;
                    case 'R':
                        Console.WriteLine("下雨");
                        break;
                    default:
                        Console.WriteLine("输入错误，无法转换！");
                        break;
                }
                Console.WriteLine("您想继续吗？（y/n）");
                char jx = char.Parse(Console.ReadLine());
                if(jx == 'n')
                {
                    weather = true;
                    Console.WriteLine("退出系统!");
                    break;
                }
            } while (weather == false);
            Console.ReadLine();
        }
    }
}
