using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySchool
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolManage school = new SchoolManage();
            //school.Login();
            school.ShowMenu();
            Console.ReadLine();
        }
    }
}
