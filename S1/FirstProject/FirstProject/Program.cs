using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            int r = 5;
            double girth = 2 * pi * r;
            double area = pi * r * r;
            Console.WriteLine("周长是：" + girth);
            Console.WriteLine("面积是：" + area);
            Console.ReadLine();
        }
    }
}
