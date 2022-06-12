using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class GoodLuck
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("我行我素购物管理系统 > 幸运抽奖");
            Console.WriteLine("请输入4为会员卡号：");
		    int num = int.Parse(Console.ReadLine());
            int sum = random.Next(0,10);
            int baiwei = num / 100 % 10;
		    if (baiwei == sum) 
            {
                Console.WriteLine(num + "是幸运客户，获精美Mp3一个。");
            }
            else
            {
                 Console.WriteLine(num + "  谢谢您的支持！");
            }
            Console.ReadLine();
        }
    }
}
