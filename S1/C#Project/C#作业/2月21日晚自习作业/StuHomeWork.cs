using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日晚自习作业
{
    internal class StuHomeWork
    {
        static void Main(string[] args)
        {
            int jan = 0;
            double num = 0;
            int sum = 0;
            for(int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("请输入周" + (i + 1) + "的作业个数：");
                jan = int.Parse(Console.ReadLine());
                    sum = sum + jan;
            }
            num = (double)sum / 5;
            Console.WriteLine("每日平均的作业数量是：" + num);
            Console.ReadLine();
        }
    }
}
