using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class FlipFlop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tFlipFlop");
		    for (int i = 1 ; i <= 100 ; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FlipFlop" + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Flop" + i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Flip" + i);
                }
                Console.ReadLine();
		    }
        }
    }
}
