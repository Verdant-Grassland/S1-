using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日晚自习作业
{
    class TexNum
    {
        static void Main(string[] args)
        {
            int Tim;
            int sql = 0;
            int num = 0;
            do
            {
                Console.WriteLine("请输入第" + (sql + 1) + "个数字：");
                Tim = int.Parse(Console.ReadLine());
                if (Tim == 999)
                {
                    Console.WriteLine("终止程序");
                    break;
                }
                else if (Tim > 0)
                {
                    num = num + Tim;
                }
                sql++;
            } while (Tim != 999 && sql != 10);
            Console.WriteLine("正数的和是：" + num);
            Console.ReadLine();
        }
    }
}
