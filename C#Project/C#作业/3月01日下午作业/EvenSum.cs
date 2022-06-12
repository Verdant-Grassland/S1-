using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class EvenSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
		    int num = 2;
		    while(num <= 100)
            {
			    sum = sum + num;
			    num = num + 2;
		    }
            Console.WriteLine("100以内的偶数之和是：" + sum);
            Console.ReadLine();
        }
    }
}
