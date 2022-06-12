using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月18日下午作业
{
    internal class Hnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入百位的数字：");
            int i = int.Parse(Console.ReadLine());
            int j = i / 100 % 10;
            int k = i / 10 % 10;
            int ijk= i % 10;
            int iijjkk = j * j * j * j + k * k * k + ijk * ijk * ijk;
            if(iijjkk == i)
            {
                Console.WriteLine("是水仙花");
            }
            else
            {
                Console.WriteLine("不是水仙花");
            }
            Console.ReadLine();
        }
    }
}
