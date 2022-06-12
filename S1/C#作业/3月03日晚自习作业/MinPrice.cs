using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月03日晚自习作业
{
    class MinPrice
    {
        static void Main(string[] args)
        {
			Console.WriteLine("请输入4家店的价格");
			int[] num = new int[5];
			for (int i = 0; i < num.Length; i++)
			{
				Console.Write("第" + (i + 1) + "家店的价格：");
				num[i] = int.Parse(Console.ReadLine());
			}
			int min = num[0];
			for (int i = 1; i < num.Length; i++)
			{
				if (num[i] < min)
				{
					min = num[i];
				}
			}
			Console.WriteLine("最低价格是：" + min);
			Console.ReadLine();
        }
    }
}
