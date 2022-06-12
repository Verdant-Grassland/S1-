using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日晚自习作业
{
    class StuScore02
    {
        static void Main(string[] args) 
        {
            int[] num = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "位同学的分数：");
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("分数是：" + num[i] + "\t");
                if (num[i] <= min)
                {
                    min = num[i];
                }
                if (num[i] >= max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("\n最大值是：{0}，最小值是：{1}", max, min);
            Console.ReadLine();
        }
    }
}
