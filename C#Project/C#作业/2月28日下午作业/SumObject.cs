using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class SumObject
    {
        public int ShowInfo(int sum)
        {
            int num = 0;
            for (int i = 1; i <= sum; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                else num = num + i;
            }
            return num;
        }
    }

    class TestSumObject
    {
        static void Main(string[] args)
        {
            SumObject sumobject = new SumObject();
            Console.WriteLine("输入一个数字：");
            int dim = int.Parse(Console.ReadLine());
            int sin = sumobject.ShowInfo(dim);
            Console.WriteLine("累加和是：" + sin);
            Console.ReadLine();
        }
    }
}
