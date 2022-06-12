using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    internal class Osum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数字：");
            int num = int.Parse(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("这个数是偶数");
            }
            else
            {
                Console.WriteLine("这个数不是偶数");
            }
            Console.ReadLine();
        }
    }
}
