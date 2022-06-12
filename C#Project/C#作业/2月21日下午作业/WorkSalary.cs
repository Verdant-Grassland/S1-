
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    internal class WorkSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入您的工资：");
            int salary = int.Parse(Console.ReadLine());
            double rate = 0.0;
            if(salary <= 850)
            {
                rate = 0;
            }else if(salary >= 850 && salary <= 1350)
            {
                rate = 0.05;
            }else if(salary >= 1350 && salary <= 2850)
            {
                rate = 0.1;
            }else if(salary >= 2850 && salary <= 5850)
            {
                rate = 0.15;
            }else if(salary > 5850)
            {
                rate = 0.25;
            }
            double tax = rate * (salary - 850);
            Console.WriteLine("您的工资税率是：" + tax);
            Console.ReadLine();
        }
    }
}
