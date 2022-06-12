using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class AgeRate
    {
        static void Main(string[] args)
        {
            int young = 0;
            int age = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("请输入第" + (i + 1) + "位顾客的年龄：");
                age = int.Parse(Console.ReadLine());
                if (age > 0 && age <= 30)
                {
                    young++;
                }
            }
            Console.WriteLine("30岁以下的比例是：" + young / 10.0 * 100 + "%");
            Console.WriteLine("30岁以上的比例是：" + (1 - young / 10.0) * 100 + "%");
            Console.ReadLine();
        }
    }
}
