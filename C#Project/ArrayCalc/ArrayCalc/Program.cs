using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCalc
{
    class Data
    {
        public void Calc(int[] nums,ref  int even,ref int odd)     
        {
            nums[0] = 1;
            nums[1] = 1;
            Console.WriteLine(nums[0] + "\n" + nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
                Console.WriteLine(nums[i]);
            }
            foreach (int item in nums)
            {
                if (item%2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            int[] nums = new int[20];
            int even = 0,odd = 0;
            data.Calc(nums,ref even,ref odd);
            Console.WriteLine("偶数个数是：{0}，奇数个数是：{1}", even, odd);
            Console.ReadLine();
        }
    }
}
