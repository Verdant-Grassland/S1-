using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class Wages
    {
        public double ShowInfo(int salary)
        {
            double rate = 0.0;
            if (salary <= 850)
            {
                rate = 0;
            }
            else if (salary >= 850 && salary <= 1350)
            {
                rate = 0.05;
            }
            else if (salary >= 1350 && salary <= 2850)
            {
                rate = 0.1;
            }
            else if (salary >= 2850 && salary <= 5850)
            {
                rate = 0.15;
            }
            else if (salary > 5850)
            {
                rate = 0.20;
            }
            double tax = rate * (salary - 850);
            return tax;
        }
    }
    
    class TestWages
    {
        static void Main(string[] args)
        {
            Wages wages = new Wages();
            Console.WriteLine("输入您的工资：");
            int salary = int.Parse(Console.ReadLine());
            double money = wages.ShowInfo(salary);
            Console.WriteLine("您的工资税率是：" + money);
            Console.ReadLine();
        }
    }
}
