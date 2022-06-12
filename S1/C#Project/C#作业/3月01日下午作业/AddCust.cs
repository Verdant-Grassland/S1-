using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class AddCust
    {
        static void Main(string[] args)
        {
           Console.WriteLine("我行我素购物管理系统 > 客户信息管理 > 添加客户信息\n");
		   Console.Write("请输入会员号(<4位整数>)：");
		   int VIPScore = int.Parse(Console.ReadLine());
		   Console.Write("请输入会员生日（月/日<用两位数表示>）：");
		   string birthday = Console.ReadLine();
		   Console.Write("请输入积分：");
		   int custScore = int.Parse(Console.ReadLine());
           if (VIPScore >= 1000 && VIPScore <= 9999)
            {
			   Console.WriteLine("\n已录入的会员信息是： ");
               Console.WriteLine(VIPScore + "\t" + birthday + "\t" + custScore);
	        }
            else
            {
                Console.WriteLine("\n客户号" + VIPScore + "是无效会员号！");
	           Console.WriteLine("录入信息失败！");
	        }
            Console.ReadLine();
        }
    }
}
