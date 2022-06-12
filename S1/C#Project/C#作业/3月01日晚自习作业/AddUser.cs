using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日晚自习作业
{
    class AddUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("青鸟迷你游戏平台 > 添加用户信息\n");
		    int custNo = 0;		
		    int age;
		    int points = 0;
		    Console.WriteLine("请输入要录入用户的数量：");
		    int count=int.Parse(Console.ReadLine());
		    for(int i=0;i<count;i++)
            {
			   Console.Write("请输入用户编号（<4位整数>）：");
			   custNo = int.Parse(Console.ReadLine());
			   Console.Write("请输入用户年龄：");
			    age = int.Parse(Console.ReadLine());
			    if(age<10 || age>100)
                {
				   Console.WriteLine("很抱歉，您的年龄不适宜玩游戏");
				   Console.WriteLine("录入信息失败\n");
				   continue;
			    }
			   Console.Write("请输入会员积分：");
			   points = int.Parse(Console.ReadLine());
			   Console.WriteLine("您录入的会员信息是：");
			   Console.WriteLine("用户编号："+custNo+ "\t年龄：" +age+ "\t积分：" +points);
            }
            Console.ReadLine();
        }
    }
}
