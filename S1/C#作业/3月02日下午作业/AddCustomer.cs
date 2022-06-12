using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class AddCustomer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyShopping管理系统 > 客户信息管理 > 添加客户信息\n");
		    int VIPno = 0;					
		    String birthday;
		    int score = 0;
		    for(int i = 0; i < 3; i++)
            {
			    Console.Write("请输入会员号（<4位整数>）：");
                VIPno = int.Parse(Console.ReadLine());
			    Console.Write("请输入会员生日（月/日<用两位整数表示>）：");
			    birthday = Console.ReadLine();
			    Console.Write("请输入会员积分：");
                score = int.Parse(Console.ReadLine());
			    if(VIPno < 1000 || VIPno > 9999)
                {
				    Console.WriteLine("客户号" + VIPno + "是无效会员号！");
				    Console.WriteLine("录入信息失败\n");
				    continue;
			    }
			    Console.WriteLine("您录入的会员信息是：");
			    Console.WriteLine(VIPno+ " " + birthday + " " + score + "\n");
		    }
		    Console.WriteLine("程序结束！");
            Console.ReadLine();
        }
    }
}
