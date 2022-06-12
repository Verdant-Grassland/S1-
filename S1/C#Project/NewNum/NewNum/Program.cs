using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNum
{
    class NewNum
    {
        public int NewInfo(int tus, int Sun)
        {
            if (tus > Sun)
            {
                return 1;
            }
            else if (tus == Sun)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

    class TestNewNum
    {
        static void Main(string[] args)
        {
            NewNum newnum = new NewNum();
            Console.WriteLine("输入第一个数：");
            int tus = int.Parse(Console.ReadLine());
            Console.WriteLine("输入第二个数：");
            int Sun = int.Parse(Console.ReadLine());
            int witch = newnum.NewInfo(tus,Sun);
            Console.WriteLine(witch);
            Console.ReadLine();
        }
    }
}
