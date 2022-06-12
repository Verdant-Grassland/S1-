using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月02日晚自习作业
{
    class Cust
    {
        public string discount(int intergral){
		string discount = "";
		if(intergral >= 8000)
        {
			discount = "6折";
		}
        else if(intergral >= 4000 && intergral <= 8000)
        {
			discount = "7折";
		}else if(intergral >= 2000 && intergral <= 4000)
        {
			discount = "8折";
		}
        else
        {
			discount = "9折";
		}
		return discount;
	}
    }

    class TestCust
    {
        static void Main(string[] args)
        {
            Cust cust = new Cust();
		    Console.WriteLine("输入您的积分:");
		    int num = int.Parse(Console.ReadLine());
		    string discount = cust.discount(num);
            Console.WriteLine("打折是：" + discount);
            Console.ReadLine();
        }
    }
}
