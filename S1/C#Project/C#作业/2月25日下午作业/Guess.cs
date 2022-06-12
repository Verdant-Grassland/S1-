using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月25日下午作业
{
    class GuessData
    {
        public string getGuessData(int sum, int num)
        {
            string GoodNew = null;
            if (sum == num)
            {
                GoodNew = "恭喜你，答对了";
            }
            else if (sum > num)
            {
                GoodNew = "猜错了，比这个数小";
            }
            else
            {
                GoodNew = "猜错了，比这个数大";
            }
            return GoodNew;
        }
    }

    class TestGuess
    {
        static void Main(string[] args)
        {
            GuessData Good = new GuessData();
            Console.Write("输入一个数字是：");
            int sum = int.Parse(Console.ReadLine());
            Random random = new Random();
            int num = random.Next(1, 10);
            string GoodTest = Good.getGuessData(sum, num);
            Console.WriteLine(GoodTest);
            Console.WriteLine("随机数字是：" + num);
            Console.ReadLine();
        }
    }
}
