using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class LoginCheck
    {
        static void Main(string[] args)
        {
            int i = 0;
		    string userName;
		    string password;
		    for(i = 0; i < 3; i++){
			    Console.Write("请输入用户名：");
			    userName = Console.ReadLine();
			    Console.Write("请输入密码：");
			    password = Console.ReadLine();
			    if("jim".Equals(userName) && "123456".Equals(password))
                {
				    Console.WriteLine("欢迎登录MyShopping系统！");
				    break;
			    }
                else
                {
				    Console.WriteLine("输入错误！您还有" +(2-i)+ "次机会！\n");
				    continue;
			    }
		    }
		    if(i == 3)
            {
			    Console.WriteLine("对不起，您3次均输入错误！");
		    }
            Console.ReadLine();
        }
    }
}
