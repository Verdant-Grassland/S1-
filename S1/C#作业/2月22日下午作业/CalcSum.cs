using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class CalcSum
    {
        public int calcSum(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("输入第" + (i + 1) + "个的分数：");
                scores[i] = int.Parse(Console.ReadLine());
                sum = sum + scores[i];
            }
            return sum;
        }

    }

    class TestCalcSum
    {
        static void Main(string[] args)
        {
            CalcSum sum = new CalcSum();
            int[] num = new int[5];
            int auter = sum.calcSum(num);
            Console.WriteLine("总分成绩是：" + auter);
            Console.ReadLine();
        }
    }
}
