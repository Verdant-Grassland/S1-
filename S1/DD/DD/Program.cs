using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd
{
    class Program
    {
        public int num;
        public int sum;
        public double scores;
        public string name;
        public string steam;
        public string colors;
        public void showInfo(int starte)
        {
            Console.WriteLine("数字总成绩：{0}，姓名/数字：{1}，颜色/数字：{2}，开始/结束时间：{3}", scores, name, colors, starte);
        }
    }

    class TestProgram
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("请输入第一次数字成绩：");
            program.num = int.Parse(Console.ReadLine());
            Console.Write("请输入第二次数字成绩：");
            program.sum = int.Parse(Console.ReadLine());
            program.scores = program.num + program.sum;
            Console.Write("请输入您的姓名：");
            program.name = Console.ReadLine();
            Console.Write("请输入您的喜欢颜色：");
            program.colors = Console.ReadLine();
            program.steam = program.name + 1;
            program.steam = program.colors + 1;
            Console.Write("请输入开始/结束时间：");
            int start = int.Parse(Console.ReadLine());
            program.showInfo(start);
            Console.ReadLine();
        }
    }
}
