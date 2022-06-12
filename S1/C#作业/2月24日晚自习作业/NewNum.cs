using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月24日晚自习作业
{
    internal class NewNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数：");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                sum++;
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else if (num == 1)
                {
                    Console.WriteLine("在执行了{0}次后为1了",sum);
                    break;
                }
                else
                {
                    num = (num * 3) + 1;
                }
            }
            Console.ReadLine();
        }
    }
}
