using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class CalcSums
    {
        public int calc(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }

    class TestCalcSums
    {
        static void Main(string[] args)
        {
            CalcSums calc = new CalcSums();
            Console.WriteLine("输入数字：");
            int sum = int.Parse(Console.ReadLine());
            int able = calc.calc(sum);
            Console.WriteLine(able);
        }
    }
}
