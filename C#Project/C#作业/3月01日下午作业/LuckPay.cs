using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class LuckPay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入4为会员卡号：");
		    int num = int.Parse(Console.ReadLine());
            int qianwei = num / 1000;
            int baiwei = num / 100 % 10;
            int shiwei = num / 10 % 10;
            int gewei = num % 10;
		    int sum = gewei + shiwei + baiwei + qianwei;
            Console.WriteLine("会员卡号" + num + "各位之和： " + sum);
		    bool isLuck = sum > 20;
		    Console.WriteLine("是幸运客户吗？" +isLuck);
            Console.ReadLine();
        }
    }
}
