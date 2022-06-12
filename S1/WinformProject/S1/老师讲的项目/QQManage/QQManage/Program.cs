using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            //manage.Login();
            manage.ShowMenu();
            Console.ReadLine();
        }
    }
}
