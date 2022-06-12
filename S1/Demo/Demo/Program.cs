using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第一个数：");
            int num2 = int.Parse(Console.ReadLine());
            Data data = new Data();
            int sum = data.calc(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2,sum);
            Console.ReadLine();
        }
    }
}
