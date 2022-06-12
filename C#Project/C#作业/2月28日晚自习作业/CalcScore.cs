using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日晚自习作业
{
    class CalcScore
    {
        public int calcAge(int[] numsal)
        {
            int nes = 0;
            for (int i = 0; i < numsal.Length; i++)
			{
			 nes = nes + numsal[i];
			}
            int age = nes / numsal.Length;
            return age;
        }
        public int calcMax(int[] numsal)
        {
            int max = numsal[0];
            for (int i = 0; i < numsal.Length; i++)
            {
                if (max < numsal[i])
                {
                    max = numsal[i];
                }
            }
            return max;
        }
        public int calcMin(int[] numsal)
        {
            int min = numsal[0];
            for (int i = 0; i < numsal.Length; i++)
            {
                if (min > numsal[i])
                {
                    min = numsal[i];
                }
            }
            return min;
        }
    }
    
    class TestCalcScore
    {
        static void Main(string[] args)
        {
            CalcScore calcscore = new CalcScore();
            int[] numsal = new int[5];
            for (int i = 0; i < numsal.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个同学的成绩：");
                numsal[i] = int.Parse(Console.ReadLine());
            }
            int score = calcscore.calcAge(numsal);
            int max = calcscore.calcMax(numsal);
            int min = calcscore.calcMin(numsal);
            Console.WriteLine("平均分是：" + score);
            Console.WriteLine("最大值是：" + max);
            Console.WriteLine("最小值是：" + min);
            Console.ReadLine();
        }
    }
}
