using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class ZeroNum
    {
        static void Main(string[] args)
        {
            int sam;
            int num = 0;
            do
            {
                Console.WriteLine("请输入整数：");
                sam = int.Parse(Console.ReadLine());
                if (sam % 2 == 0) Console.WriteLine(sam);
                else num = sam + num;
            } while (sam > 0);
            Console.WriteLine("奇数的和是：" + num);
            Console.ReadLine();
        }
    }
}
