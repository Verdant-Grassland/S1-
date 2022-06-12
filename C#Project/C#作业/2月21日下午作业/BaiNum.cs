using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    internal class BaiNum
    {
        static void Main(string[] args)
        {
            int a = 0;
            for(int i = 1 ; i <= 100 ; i++)
            {
                if(i%2 == 0)
                {
                    a = a + i;
                }
            }
            Console.WriteLine("个数是：" + a);
            Console.ReadLine();
        }
    }
}
