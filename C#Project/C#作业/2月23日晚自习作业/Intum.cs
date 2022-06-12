using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日晚自习作业
{
    class Intum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数：");
            int Tum = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            while (num != 9)
            {
                sum = Tum % 10;
                num = num + sum;
                Tum = num / 10;

            }
            Console.WriteLine(Tum);
            Console.ReadLine();
        }
    }
}
