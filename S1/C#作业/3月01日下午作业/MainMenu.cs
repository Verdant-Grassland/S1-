using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用MyShopping管理系统");
		    Console.WriteLine("*******************************");
		    Console.WriteLine("\t1.客 户 信 息 管 理");
		    Console.WriteLine("\t2.购 物 结 算");
		    Console.WriteLine("\t3.真 情 回 馈");
		    Console.WriteLine("\t4.注 销");
		    Console.WriteLine("*******************************");
		    int choose;
		    bool Right;
            Console.Write("请选择，输入数字：");
		    do
            {
			    Right = true;
			    choose = int.Parse(Console.ReadLine());
			    if(choose == 1)
                {
				    Console.WriteLine("执行客户信息管理");
			    }
                else if(choose == 2)
                {
				    Console.WriteLine("执行购物结算");
			    }
                else if(choose == 3)
                {
				    Console.WriteLine("执行真情回馈");
			    }
                else if(choose == 4)
                {
				    Console.WriteLine("执行注销");
			    }
                else
                {
				    Console.Write("输入错误，请重新输入数字：");
				    Right = false;
			    }
		    } while(!Right);
		    Console.WriteLine("\n程序结束");
            Console.ReadLine();
        }
    }
}
