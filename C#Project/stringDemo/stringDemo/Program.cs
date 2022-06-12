using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDemo
{
    class MyClass
    {
        public string Show(string url)
        {
            string letter = null;
            Console.WriteLine("您请输入的地址使用的协议类型是：");
            int let = url.IndexOf(":");
            letter = url.Substring(0,let);
            return letter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass let = new MyClass();
            Console.WriteLine("请输入一个url网址：");
            string url = Console.ReadLine();
            string ter = let.Show(url);
            Console.WriteLine(ter);
            Console.ReadLine();
        }
    }
}
