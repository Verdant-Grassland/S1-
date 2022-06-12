using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class CalcDiscount02
    {
        static void Main(string[] args)
        {
            Console.Write("请输入会员积分： ");
		    int VIPScore = int.Parse(Console.ReadLine());
		    double discount;
		    if (VIPScore < 2000) 
            {
			    discount = 0.9;
		    }
            else if (2000 <= VIPScore && VIPScore < 4000) 
            {
			    discount = 0.8;
		    } 
            else if (4000 <= VIPScore && VIPScore < 8000) 
            {
			    discount = 0.7;
		    } else 
            {
			    discount = 0.6;
		    }
		    Console.WriteLine("该会员享受的折扣是：" + discount);
           Console.ReadLine();
        }
    }
}
