using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6];
            Console.WriteLine("请输入第6个数字：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("请输 入第" + (i + 1) + "个数字：");
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n升序排序结果：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
