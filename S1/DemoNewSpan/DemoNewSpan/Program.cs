using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNewSpan
{
    class Program
    {
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 16 && value <= 40)
                {
                    age = value;
                }
                else
                {
                    age = 18;
                }
            }
        }
        private string idCard;

        public string IdCard
        {
            get { return idCard; }
            set 
            {
                if (value.Length != 18)
                {
                    idCard = "00-0000-0000-0000-0000";
                }
                else
                {
                    idCard = value;
                }
            }
        } 
    }

    /*class Student 
    {
        private string name;
        private int age;
        public string GetName()
        {
            return name;
        }
        public void 
    }*/

    class TestProgram
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.Write("输入您的年龄：");
            program.Age = int.Parse(Console.ReadLine());
            Console.Write("输入您的身份证号：");
            program.IdCard = Console.ReadLine();
            Console.WriteLine("您的年龄是：{0} -------- 您的身份证是：{1}",program.Age,program.IdCard);
            Console.ReadLine();
        }
    }
}
