using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Data
    {
        int i = 0;
        int j = 1;
        public bool ReturnTrue()
        {
            Console.WriteLine("return true");
            return j > i;
        }
        public bool ReturnFalse()
        {
            Console.WriteLine("return false");
            return i > j;
        }
    }
}
