using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月22日下午作业
{
    class Calc
    {
        public int calcMin(int[] scores)
        {
            int min = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (min > scores[i])
                {
                    min = scores[i];
                }
            }
            return min;
        }
    }

    class TestCalc 
    {
        static void Main(string[] args) 
        { 
            Calc calc = new Calc();
		    int[] nums = new int[5];
		    for(int i = 0 ; i < nums.Length ; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个同学的分数：");
			    nums[i] = int.Parse(Console.ReadLine());
		    }
		    double avg = calc.calcMin(nums);
            int min = calc.calcMin(nums);
            Console.WriteLine("最小值是：" + min);
            Console.ReadLine();
        }
    }
}
