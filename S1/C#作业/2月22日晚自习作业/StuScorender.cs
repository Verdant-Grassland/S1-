using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日晚自习作业
{
    class StuScorender
    {
        static void Main(string[] args)
        { 
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "位选手的分数：");
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + "\t");
            }
            double avg = num[1] + num[2] + num[3];
            Console.WriteLine("\n总分数是：" + avg);
            Console.ReadLine();
        }
    }
}
