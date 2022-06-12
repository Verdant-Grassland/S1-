using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月2日下午作业
{
    class ToLetter
    {
        public string Show(string UserName)
        {
            string[] stringName = UserName.Split(new char[] { ' ' });
            for (int i = 0; i < stringName.Length; i++)
            {
                stringName[i] = stringName[i].Substring(0,1).ToUpper() + stringName[i].Substring(1).ToLower();
            }
            string name = string.Join("", stringName);
            return name;
        }
    }

    class TestToLetter
    {
        static void Main(string[] args)
        {
            ToLetter user = new ToLetter();
            Console.WriteLine("请输入您的姓名：");
            string nameBefore = Console.ReadLine();
            string nameAfter = user.Show(nameBefore);
            Console.WriteLine("格式化处理后你的姓名：");
            Console.WriteLine(nameAfter);
            Console.ReadLine();

        }
    }
}
