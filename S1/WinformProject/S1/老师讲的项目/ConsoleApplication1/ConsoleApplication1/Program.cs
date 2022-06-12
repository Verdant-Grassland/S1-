using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            DateTime dt = DateTime.Parse(num);
            int year = dt.Year;
            Console.WriteLine(year);
            Console.ReadLine();
            
        }
    }
}
