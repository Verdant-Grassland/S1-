using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日晚自习作业
{
    class StuScore
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "门课的同学成绩：");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] < 60)
                {
                    Console.WriteLine("Fail");
                }
                else
                {
                    Console.WriteLine("Pass");
                }
            }
            Console.ReadLine();
        }
    }
}
