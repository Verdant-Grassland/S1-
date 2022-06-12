using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月03日晚自习作业
{
    class CalcShopping
    {
        static void Main(string[] args)
        {
			double[] num = new double[5];
			double sum = 0.0;
			Console.WriteLine("请输入会员本月的消费记录");
			for (int i = 0; i < num.Length; i++)
			{
				Console.Write("请输入第" + (i + 1) + "笔购物金额：");
				num[i] = double.Parse(Console.ReadLine());
				sum = sum + num[i];
			}
			Console.WriteLine("\n序号\t\t金额(元)");
			for (int i = 0; i < num.Length; i++)
			{
				Console.WriteLine((i + 1) + "\t\t" + num[i]);
			}
			Console.WriteLine("总金额\t\t" + sum);
			Console.ReadLine();
		}
    }
}
