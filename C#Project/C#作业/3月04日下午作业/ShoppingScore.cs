using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class ShoppingScore
    {
        static void Main(string[] args)
        {
            int count = 0;
		    double price=0.0;
		    for(int i = 0; i < 3; i++)
            {
			    Console.WriteLine("请输入第"+(i+1) +"个人所购的三件商品的价格：");
			    for(int j = 0; j < 3; j++)
                {
				    price=double.Parse(Console.ReadLine());
				    if(price<300)
					    continue;
				    count++; 
			    }			
			    Console.WriteLine("第"+(i+1) +"个人共有" +count + "件商品享受8折优惠！");
			    count=0;
                Console.ReadLine();
		    }
        }
    }
}
