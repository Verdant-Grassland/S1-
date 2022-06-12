using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class StuScore
    {
        static void Main(string[] args)
        {
            int[] score = new int[4];
		    float sum = 0.0f;
		    float avg = 0.0f;
		    Console.WriteLine("请输入4位学员的成绩");
		    for(int i = 0; i < score.Length; i++){
			    Console.Write("第"+ (i+1) +"位学员的成绩：");
                score[i] = int.Parse(Console.ReadLine());
			    sum = sum + score[i];
		    }
		    avg = sum / score.Length;
		    Console.WriteLine("参赛学员的平均分是：" + avg);
            Console.ReadLine();
        }
    }
}
