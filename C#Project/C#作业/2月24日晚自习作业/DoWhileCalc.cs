using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月24日晚自习作业
{
    internal class DoWhileCalc
    {
        static void Main(string[] args)
        {
            bool studey = true;
            do
            {
                studey = false;
                Console.WriteLine("*******************欢迎青鸟学习管理系统*******************");
                Console.WriteLine("\t\t1.Java学习");
                Console.WriteLine("\t\t2.HTML网页设计");
                Console.WriteLine("\t\t3.SQL数据库基础");
                Console.WriteLine("\t\t4.注销");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("请输入选择数字：");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("执行Java学习");
                        break;
                    case 2:
                        Console.WriteLine("执行HTML网页设计");
                        break;
                    case 3:
                        Console.WriteLine("执行SQL数据库基础");
                        break;
                    case 4:
                        studey = false;
                        Console.WriteLine("退出系统，谢谢您使用！");
                        break;
                    default:
                        Console.WriteLine("输入数字错误，请你重新数字：");
                        break;
                }
            } while (studey ==false);
            Console.ReadLine();
        }
    }
}
