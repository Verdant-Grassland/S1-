using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月03日晚自习作业
{
    class Discount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("本次活动特价商品有:");
            string[] shopping = new String[] { "Nike背包", "Adidas运动衫", "李宁运动鞋", "Kappa外套", "361°腰包" };
            for (int i = 0; i < shopping.Length; i++)
            {
                Console.WriteLine(shopping[i]);
            }
            Console.ReadLine();
        }
    }
}
