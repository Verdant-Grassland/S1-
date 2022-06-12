using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日晚自习作业
{
    class PayGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("青鸟迷你游戏平台 > 游戏币支付");
            Console.WriteLine("请选择您玩的游戏类型：");
		    Console.WriteLine("\t1.牌类");
		    Console.WriteLine("\t2.休闲竞技类\n");
            int choose = int.Parse(Console.ReadLine());
		    Console.WriteLine("请您输入游戏时长：");
            int time = int.Parse(Console.ReadLine());
		    int qm = 0;
		    switch (choose) 
            {
		        case 1:
			        if (time > 10) 
                    {
				        Console.WriteLine("您玩的是牌类游戏，时长是：" + time + "小时,可以享受5折优惠");
				        qm = (int) (10 * time * 0.5);
				        Console.WriteLine("您需要支付" + qm + "个游戏币");
			        }
                    else 
                    {
				        Console.WriteLine("您玩的是牌类游戏，时长是：" + time + "小时,可以享受8折优惠");
				        qm = (int) (10 * time * 0.8);
				        Console.WriteLine("您需要支付" + qm + "个游戏币");
			        }
			        break;
		        case 2:
			        if (time > 10) 
                    {
				        Console.WriteLine("您玩的是休闲竞技类游戏，时长是：" + time + "小时,可以享受5折优惠");
				        qm = (int) (20 * time * 0.5);
				        Console.WriteLine("您需要支付" + qm + "个游戏币");
			        } 
                    else 
                    {
				        Console.WriteLine("您玩的是休闲竞技类游戏，时长是：" + time + "小时,可以享受8折优惠");
				        qm = (int) (20 * time * 0.8);
				        Console.WriteLine("您需要支付" + qm + "个游戏币");
			        }
			        break;
		        default:
			         Console.Write("无效选择!");
                     break;
		    }
            Console.ReadLine();
        }
    }
}
