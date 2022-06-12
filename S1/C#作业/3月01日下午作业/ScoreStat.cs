using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月01日下午作业
{
    class ScoreStat
    {
        static void Main(string[] args)
        {
            
            Console.Write("STB的成绩是：");
		    int stb = int.Parse(Console.ReadLine());
		    Console.Write("Java的成绩是：");
		    int java = int.Parse(Console.ReadLine());
		    Console.Write("SQL的成绩是：");
		    int sql = int.Parse(Console.ReadLine());
		    Console.WriteLine("-----------------------");
		    Console.WriteLine("STB\tJava\tSQL");
		    Console.WriteLine(stb + "\t" + java + "\t" + sql);
		    Console.WriteLine("-----------------------");
            double avg = (stb + java + sql) / 3;
		    Console.WriteLine("Java和SQL的成绩差：" + (java - sql));
		    Console.WriteLine("3门课的平均分是: " + avg);
            Console.ReadLine();
        }
    }
}
