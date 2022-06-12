using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月28日下午作业
{
    class CharLetter
    {
        static void Main(string[] args)
        {
            int num = 32;
            Console.WriteLine("输入一个字符：");
            char Letter = char.Parse(Console.ReadLine());
            if (Letter >= 'a' && Letter<='z')
            {
                Letter = (char)(Letter -32);
                Console.WriteLine(Letter);
            }
            else if (Letter>='A'&& Letter<='Z')
	        {
                Letter = (char)(Letter + 32);
                Console.WriteLine(Letter);
	        }
            Console.ReadLine();
        }
    }
}
