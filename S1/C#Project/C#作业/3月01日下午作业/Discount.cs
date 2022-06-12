using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class Discount
    {
        static void Main(string[] args)
        {
          Console.WriteLine("请输入消费金额：");
		    double money = double.Parse(Console.ReadLine());
		    double extra = 0;
		    int choose = 0;
		    if(money >= 50)
            {
			   Console.WriteLine("是否参加优惠换购活动：");
			   Console.WriteLine("1：满50元，加2元换购百事可乐饮料1瓶");
			   Console.WriteLine("2：满100元，加3元换购500ml可乐一瓶");
			   Console.WriteLine("3：满100元，加10元换购5公斤面粉");
			   Console.WriteLine("4：满200元，加10元可换购1个苏泊尔炒菜锅");
			   Console.WriteLine("5：满200元，加20元可换购欧莱雅爽肤水一瓶");
			   Console.WriteLine("0：不换购");
			   Console.Write("请选择：");
			   
                    choose = int.Parse(Console.ReadLine());
				    switch(choose)
                    {
					    case 1:
						    if(money >= 50)
                            {
							    extra = 2;
						    }
						    break;
					    case 2:
						    if(money >= 100)
                            {
							    extra = 3;
						    }
						    break;
					    case 3:
						    if(money >= 100)
                            {
							    extra = 10;
						    }
						    break;
					    case 4:
						    if(money >= 200)
                            {
							    extra = 10;
						    }
						    break;
					    case 5:
						    if(money>200)
                            {
							    extra = 20;
						    }
						    break;
					    default:
						    break;
				    }
			    }
		
		    //结账
		    double total = money + extra;
		    Console.WriteLine("本次消费总金额："+ total);
		    if(choose == 1)
            {
			   Console.WriteLine("成功换购：百事可乐饮料1瓶。");
		    }
            else if(choose ==2 )
            {
			   Console.WriteLine("成功换购：500ml可乐一瓶。");
		    }
            else if(choose == 3)
            {
			   Console.WriteLine("成功换购：5公斤面粉。");
		    }
            else if(choose == 4)
            {
			   Console.WriteLine("成功换购：1个苏泊尔炒菜锅。");
		    }
            else if(choose == 5)
            {
			   Console.WriteLine("成功换购：欧莱雅爽肤水一瓶。");
		    }
            else 
            {
			   Console.WriteLine("无换购项目！");
		    }
           Console.ReadLine();
        }
    }
}
