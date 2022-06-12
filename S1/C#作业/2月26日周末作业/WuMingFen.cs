using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
	class WuMingFen
	{
		public string theMa;
		public int quantity;
		public bool likeSoup;
		public void Display()
		{
			Console.WriteLine("面码是：{0}，粉的分量：{1}，是否带汤{2}", theMa, quantity, likeSoup);
		}
	}

    class TestWuMingFen
	{
		static void Main(string[] args)
		{
			WuMingFen wuMingFen = new WuMingFen();
			Console.WriteLine("输入面码：");
			wuMingFen.theMa = Console.ReadLine();
			Console.WriteLine("输入粉的分量：");
			wuMingFen.quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("输入您的是否带汤：");
			wuMingFen.likeSoup = bool.Parse(Console.ReadLine());
			wuMingFen.Display();
			Console.ReadLine();
		}
	}
}
