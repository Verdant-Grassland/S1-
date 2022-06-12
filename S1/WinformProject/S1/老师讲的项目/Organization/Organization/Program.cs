using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            manage.ShowMenu();
            Console.ReadLine();
        }
    }
}
