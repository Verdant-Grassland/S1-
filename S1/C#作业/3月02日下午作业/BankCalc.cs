using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class BankCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t银行活期储蓄存款计算器");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("请输入姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入存款金额<格式：元.角分>：");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入存款天数：");
            int day = int.Parse(Console.ReadLine());
            double rate = 0.36;
            double sum = money * day * rate / 360;
            double total = money + sum;
            Console.WriteLine("\n\t银行活期储蓄存款本息计算结果：");
            Console.WriteLine("==================================================");
            Console.WriteLine("姓\t名：" + string.Format("{0,-20}",name));
            Console.WriteLine("存款金额：" + string.Format("{0,20:C2}", money));
            Console.WriteLine("存款天数：" + string.Format("{0,20:D}", day));
            Console.WriteLine("存款年利率：" + string.Format("{0,20:P}", rate));
            Console.WriteLine("利息总额：" + string.Format("{0,20:C2}", sum));
            Console.WriteLine("本息合计：" + string.Format("{0,20:C2}", total));
            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
