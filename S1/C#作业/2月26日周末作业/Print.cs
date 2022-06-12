using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
    internal class Print
    {
        static void Main(string[] args)
        {
			int num = 0;
			for (int i = 100; i <= 999; i++)
			{
				int bai = i / 100 % 10;
				int shi = i / 10 % 10;
				int ge = i % 10;
				if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
				{
					Console.WriteLine(i + "是水仙花数");
				}
			}
			Console.ReadLine();
		}
    }
}
