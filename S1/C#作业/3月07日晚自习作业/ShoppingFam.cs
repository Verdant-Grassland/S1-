using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月07日晚自习作业
{
    class ShoppingFam
    {
        static void Main(string[] args)
        {
            int[] price = new int[] { 4000, 3800, 5000, 6000, 10000 };
            int min = price[0];
            for (int i = 0; i < price.Length; i++)
            {
                if (min > price[i])
                {
                    min = price[i];
                }
            }
            Console.WriteLine("最小值是：" + min);
            Console.ReadLine();
        }
    }
}
