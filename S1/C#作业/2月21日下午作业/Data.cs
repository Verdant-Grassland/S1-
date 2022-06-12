using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    class Data
    {
        public int swap(int num1,int num2)
        {
            int sum = 0;
            sum = num1;
            num1 = num2;
            num2 = sum;
            return sum;
        }
    }
    
    class TestData
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Console.WriteLine("输入第一个数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("输入第一个数：");
            int num2 = int.Parse(Console.ReadLine());
            int sum = data.swap(num1,num2);
            Console.WriteLine(sum);
            Console.WriteLine("两个数交换后是：{0}，{1}",num1,num2);
            Console.ReadLine();
        }
    }
}
