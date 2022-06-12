using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日晚自习作业
{
    internal class StuScore
    {
        static void Main(string[] args)
        {
            int[] sun = new int[5];
            int num = 0;
            for (int i = 0; i < sun.Length; i++)
            {
                Console.WriteLine("输入第" + (i + 1) + "同学的成绩：");
                sun[i] = int.Parse(Console.ReadLine());
                if (sun[i] >= 60)
                {
                    num++;
                }
            }
            double rate = num * 1.0 / sun.Length * 100;
            Console.WriteLine("个人数是：" + num + "\n比例是：" + rate + "%");
            Console.ReadLine();
        }
    }
}
