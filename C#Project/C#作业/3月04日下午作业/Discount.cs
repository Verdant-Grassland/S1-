using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月04日下午作业
{
    class Discount
    {
        static void Main(string[] args)
        {
            int[] score = new int[4];	
		    int num = 3;
		    double sum = 0.0;
		    double avg = 0.0;
		    int count = 0;							
		    for(int i = 0; i < num; i++)
            {
			    sum = 0.0f;
			   Console.WriteLine("请输入第" + (i+1) + "个班级的成绩");
			    for(int j = 0; j < score.Length; j++){
				   Console.Write("第" + (j+1) + "个学员的成绩：");
				    score[j] = int.Parse(Console.ReadLine());
				    sum = sum + score[j];
				
				    if(score[j] < 85)
                    {
					    continue;
				    }
				    count++;
			    }
			    avg = sum / score.Length;
			   Console.WriteLine("第" + (i+1) + "个班级参赛学员的平均分是：" + avg + "\n");
		    }
		   Console.WriteLine("成绩85分以上的学员人数有" + count + "人");
           Console.ReadLine();
        }
    }
}
