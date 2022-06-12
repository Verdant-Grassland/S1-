using System;

namespace _2月21日晚自习作业
{
    class StuAge
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("输入第" + (i + 1) + "位同学的成绩：");
                age[i] = int.Parse(Console.ReadLine());
            }
            int max = age[0];
            for (int i = 1; i < age.Length; i++)
            {
                if (age[0] <= age[i])
                {
                    age[0] = age[i];
                }
            }
            Console.WriteLine("最大值是：" + age[0]);
            Console.ReadLine();
        }
    }
}
