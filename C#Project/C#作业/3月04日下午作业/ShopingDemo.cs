using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class ShopingDemo
    {
        static void Main(string[] args)
        {
            int count = 0;
		    string clothes;
		    for(int i = 0; i < 5; i++)
            {
			    Console.WriteLine("欢迎光临第" + (i+1) + "家专卖店");
			    for(int j = 0; j < 3; j++){
				    Console.Write("要离开吗（y/n）？");
				    clothes = Console.ReadLine();
				    if("y".Equals(clothes))
                    {
					    break;	
				    }
				    Console.WriteLine("买了一件衣服");
				    count++;
			    }
			    Console.WriteLine("离店结账\n");
		    }
		    Console.WriteLine("总共买了" + count + "件衣服");
            Console.ReadLine();
        }
    }
}
