using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
    internal class Shopping
    {
        static void Main(string[] args)
        {
			Console.WriteLine("输入您的积分：");
			int score = int.Parse(Console.ReadLine()); ;
			Console.WriteLine("输入您的金额：");
			int money = int.Parse(Console.ReadLine()); ;
			if (score >= 500 && score <= 1000)
			{
				Console.WriteLine(money * 0.9);
			}
			else if (score >= 1000 && score <= 2000)
			{
				Console.WriteLine(money * 0.8);
			}
			else if (score >= 2000 && score <= 5000)
			{
				Console.WriteLine(money * 0.75);
			}
			else if(score >= 5000)
			{
				Console.WriteLine(money * 0.7);
            }
            else
            {
				Console.WriteLine("没有打折优惠");
            }
			Console.ReadLine();
        }
    }
}
