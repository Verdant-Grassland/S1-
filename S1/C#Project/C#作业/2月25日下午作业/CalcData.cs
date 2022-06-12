using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class CalcData
    {
        public int Data(int num)
        {
            int sum = 0;
            if (num%2 == 0)
            {
                Console.WriteLine(num + "是偶数");
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine("偶数1到100的累加和是：" + sum);
            }
            else
            {
                Console.WriteLine(num + "是奇数");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine("奇数1到100的累加和是：" + sum);
            }
            return sum;
        }
    }

    class TestCalcData
    {
        static void Main(string[] args)
        {
            CalcData data = new CalcData();
            Console.WriteLine("输入一个数是：");
            int sum = int.Parse(Console.ReadLine());
            int newa = data.Data(sum);
            Console.WriteLine(newa);
            Console.ReadLine();
        }
    }
}
