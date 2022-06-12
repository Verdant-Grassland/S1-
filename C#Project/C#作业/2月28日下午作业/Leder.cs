using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class Leder
    {
        public int show(int sum)
        {
            int num = 0;
            for (int i = 1 ; i <= sum ; i++)
            {
                num = num + i;
            }
            return num;
        }
    }

    class TestLeder
    {
        static void Main(string[] args)
        {
            Leder leder = new Leder();
            Console.WriteLine("输入一个数字：");
            int tim = int.Parse(Console.ReadLine());
            int sim = leder.show(tim);
            Console.WriteLine("累加和是：" + sim);
            Console.ReadLine();
        }
    }
}
