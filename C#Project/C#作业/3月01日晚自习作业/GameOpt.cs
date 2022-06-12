using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日晚自习作业
{
    class GameOpt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎进入青鸟游迷你戏平台");
		    Console.WriteLine("请选择您喜爱的游戏：");
		    Console.WriteLine("*******************************");
		    Console.WriteLine("\t1.斗地主");
		    Console.WriteLine("\t2.斗牛");
		    Console.WriteLine("\t3.泡泡龙");
		    Console.WriteLine("\t4.连连看");
		    Console.WriteLine("*******************************");
		    int choose;
		    bool isRight;
		    Console.Write("请选择，输入数字：");
		    do{
			    isRight = true;
			    choose = int.Parse(Console.ReadLine());
			    switch (choose) 
                {
			        case 1:
				        Console.WriteLine("您已进入斗地主房间！");
				        break;
			        case 2:
				        Console.WriteLine("您已进入斗牛房间！");
				        break;
			        case 3:
				        Console.WriteLine("您已进入泡泡龙房间！");
				        break;
			        case 4:
				        Console.WriteLine("您已进入连连看房间！");
				        break;
			        default:
				        Console.Write("输入错误，请重新输入数字：");
				        isRight = false;
				        break;
			    }
		    }while(!isRight);
            Console.ReadLine();
        }
    }
}
