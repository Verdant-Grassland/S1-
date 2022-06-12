using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class GuessNumGame
    {
        static void Main(string[] args)
        {
            int[] lim = new int[] { 8, 4, 2, 1, 23, 344, 12 }; 
		    Console.Write("请输入一个整数： ");
		    int num = int.Parse(Console.ReadLine());
		    bool sum = false;
		    for (int i = 0; i < lim.Length; i++) 
            {
			    if (num == lim[i]) 
                {
				    sum = true;
				    break;
			    }
		    }
		    if (sum) 
            {
			   Console.WriteLine("是包含此数");
		    }
            else
            {
                Console.WriteLine("不是包含此数");
		    }
            Console.ReadLine();
        }
    }
}
