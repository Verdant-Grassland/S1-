using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class TestSame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***原歌词格式***");
            Console.WriteLine("长亭外 古道边 芳草碧连天 晚风扶 柳笛声残 夕阳山外山\n");
            Console.WriteLine("***拆分后歌词格式***");
            string name = "长亭外 古道边 芳草碧连天 晚风扶 柳笛声残 夕阳山外山";
            string[] ate = name.Split(' ');
            foreach (string num in ate)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
