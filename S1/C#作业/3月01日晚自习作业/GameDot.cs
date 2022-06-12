using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日晚自习作业
{
    class GameDot
    {
        static void Main(string[] args)
        {
            int score; 
	        int total; 
	        int num = 0; 
	       Console.WriteLine("青鸟迷你游戏平台 > 游戏点击率\n");

	        for (int i = 0; i < 4; i++) 
            {
	           Console.Write("请输入第" + (i + 1) + "个游戏的点击率: ");
	            score = int.Parse(Console.ReadLine());
	            if (score <= 100) 
                {
	                continue;
	            }
	            num++;
	        }        
	       Console.WriteLine("点击率大于100的游戏数是: " + num);
	       double rate =  (double)num / 4 * 100;
	       Console.WriteLine("点击率大于100的游戏所占的比例为:" + rate + "%");
           Console.ReadLine();
        }
    }
}
