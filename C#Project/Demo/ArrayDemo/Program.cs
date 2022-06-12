using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "admin", "join", "halen", "joe", "lili" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + "\t");
            }
            char[] chs = new char[] {'A','B','C','D'};
            Console.WriteLine("\n定义字符型数组：");
            foreach(char ch in chs)
            {
                Console.Write(ch + "\t");
            }
            double[] scores = new double[5];
            Console.WriteLine("\n输入分数：");
            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个同学的分数：");
                scores[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n输出分数：");
            double sum = 0;
            Console.WriteLine("序号\t分数");
            for(int i = 0; i < scores.Length; i++)
            {
                sum = sum + scores[i];
                Console.WriteLine((i + 1) + "\t" + scores[i]);
            }
            double avg = sum / scores.Length;
            Console.WriteLine("总分是：{0},平均分：{1}",sum,avg);
            Console.ReadLine();
        }
    }
}
