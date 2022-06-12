using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日晚自习作业
{
    class StuHeight
    {
        static void Main(string[] args)
        {
            int[] sum = new int[5];
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "同学的身高：");
                sum[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n原顺序是：");
            Array.Sort(sum);
            for(int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i] + "\t");
            }
            Console.Write("\n逆顺序是：");
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sum[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
