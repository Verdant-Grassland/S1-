using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class CalcDiscount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入是否是会员：是（y）/否（其他字符）");
		    String VIPScore = Console.ReadLine();
		    Console.WriteLine("请输入购物金额：");
            double money = double.Parse(Console.ReadLine());
            if (VIPScore.Equals("y"))
            {
			    if(money > 200)
                {
				    money = money * 0.75;
			    }
                else
                {
				    money = money * 0.8;
			    }
		    }
            else
            {
			    if(money > 100)
                {
				    money = money * 0.9;
			    }
		    }
		    Console.WriteLine("实际支付：" + money);
            Console.ReadLine();
        }
    }
}
