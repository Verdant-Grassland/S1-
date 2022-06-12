using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class Xmscore
    {
        static void Main(string[] args)
        {
           Console.WriteLine("请输入小明的考试成绩：");
		   int score = int.Parse(Console.ReadLine());
           if (score == 100)
           {
               Console.WriteLine("爸爸给他买辆车");
           }
           else if (score >= 90 && score < 100)
           {
               Console.WriteLine("妈妈给他买MP4");
           }
           else if (score >= 60 && score < 90)
           {
               Console.WriteLine("妈妈给他买本参考书");
           }
           else
           {
               Console.WriteLine("什么都不买");
           }
           Console.ReadLine();
        }
    }
}
