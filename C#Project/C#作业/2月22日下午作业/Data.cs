using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class Data
    {
        public int calcSum(int num)
        {
            int sum = 0;
            int qian = num / 1000;
            int bai = num / 100 % 10;
            int shi = num / 10 % 10;
            int ge = num % 10;
            sum = qian + bai + shi + ge;
            return sum;
        }
    }

    class TestData
    {
        static void Main(string[] args) 
        {
            Data data = new Data();
            Console.WriteLine("输入一个数：");
            int sum = int.Parse(Console.ReadLine());
		    int calCum = data.calcSum(sum);
            Console.WriteLine("各个位数之和是：" + calCum);
            Console.ReadLine();
        }
    }
}
