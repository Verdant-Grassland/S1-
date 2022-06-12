using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class NewCalc
    {
        public string ShowCalc(int num1, int num2)
        {
            int jia = num1 + num2;
            int jian = num1 - num2;
            int cheng = num1 * num2;
            int chu = num1 / num2;
            return "结果是：\n加法是：" + jia + "  减法是：" + jian + "  乘法是：" + cheng + "  除法是：" + chu;
        }
    }

    class TestNewCalc
    {
        static void Main(string[] args)
        {
            NewCalc newcalc = new NewCalc();
            Console.WriteLine("请输入第一个数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第一个数：");
            int num2 = int.Parse(Console.ReadLine());
            string calc = newcalc.ShowCalc(num1, num2);
            Console.WriteLine(calc);
            Console.ReadLine();
        }
    }
}
