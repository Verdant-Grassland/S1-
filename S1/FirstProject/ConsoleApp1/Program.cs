using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入你的虚拟机数字：");
            int num = int.Parse(Console.ReadLine());
            if(num >= 10 && num <= 15)
            {
                Random input = new Random();
                Console.WriteLine("您的虚拟机随数数字是：" + input.Next().ToString());
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine("请输入第" + i + 1 + "个的虚拟机循环数字：");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num.ToString());
                    Console.WriteLine("您的数字是："+num);
                }
                Console.WriteLine(Console.ReadLine());
            }
            else if(num >= 15 && num <= 20)
            {
                Random input = new Random();
                Console.WriteLine("您的虚拟机随数数字是：" + input.Next().ToString());
                for (int i = 1; i < num; i++)
                {
                    Console.WriteLine("请输入第" + i + "个的虚拟机循环数字：");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num.ToString());
                    Console.WriteLine("您的数字是：" + num);
                }
                Console.WriteLine(Console.ReadLine());
            }
            else
            {
                Random input = new Random();
                Console.WriteLine("您的虚拟机随数数字是：" + input.Next().ToString());
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("请输入第" + i + 1 + "个的虚拟机循环数字：");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num.ToString());
                    Console.WriteLine("您的数字是：" + num);
                }
                Console.WriteLine(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
