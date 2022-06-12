using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class StuAge
    {
        static void Main(string[] args) 
        {
            int[] num = new int[5];
            int max = int.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "位同学的年龄：");
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("同学的年龄是：" + num[i] + "\t");
                if (num[i] >= max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("\n年龄最大值是：{0}", max);
            Console.ReadLine();
        }
    }
}
