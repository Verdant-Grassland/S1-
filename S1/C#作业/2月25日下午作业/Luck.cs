using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class Luck
    {
        public string luckInfo(int mingCi)
        {
            string num = "";
            switch (mingCi)
            {
                case 1:
                    num = "将参加麻省理工大学组织的1个月夏令营";
                    break;
                case 2:
                    num = "将奖励惠普笔记本电脑一部";
                    break;
                case 3:
                    num = "将奖励移动硬盘一个";
                    break;
                default:
                    num = "没有任何奖励";
                    break;
            }
            return num;
        }
    }

    class TestLuck
    {
        static void Main(string[] args)
        {
            Luck luck = new Luck();
		    Console.WriteLine("输入您的名次:");
		    int num = int.Parse(Console.ReadLine());
		    string bum = luck.luckInfo(num);
            Console.WriteLine(bum);
            Console.ReadLine();
        }
    }
}
