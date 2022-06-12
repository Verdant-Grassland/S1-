using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月26日周末作业
{
	class MyTime
	{
		public double Times;
        public string getInfo()
		{
			string time = "";
			if (Times >= 5 && Times <= 10)
			{
				time = "早晨";
			}
			else if (Times >= 11 && Times <= 13)
			{
				time = "中午";
			}
			else if (Times >= 13 && Times <= 19)
			{
				time = "下午";
			}
			else if (Times >= 18 && Times <= 24)
			{
				time = "晚上";
			}
			else
			{
				time = "清晨";
			}
			return time;
		}
	}

    class TestMyTime
    {
		static void Main(string[] args)
        {
			MyTime time = new MyTime();
			Console.WriteLine("请输入您的时间：");
			time.Times = int.Parse(Console.ReadLine());
			string Tim = time.getInfo();
			Console.WriteLine(Tim);
			Console.ReadLine();
		}
	}
}
