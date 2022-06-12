using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager myManager = new Manager();

            //初始化计算机信息
            #region Init Computers
            Computer[] computers = new Computer[3]{
                                                    new Computer(),
                                                    new Computer(),
                                                    new Computer()
                                                    };
            computers[0].Type = "hpCQ-217TX";
            computers[0].BuyDate = "2013-10-5";
            computers[1].Type = "Mc240CH/A";
            computers[1].BuyDate = "2013-10-5";
            computers[2].Type = "SYNW18H/W";
            computers[2].BuyDate = "2013-10-5";
            #endregion

            //设置计算机ID之前的计算机信息
            Console.WriteLine("***************设置计算机ID前******************");
            Console.WriteLine("计算机型号\t计算机ID     \t购买时间");
            foreach (Computer item in computers)
            {
                Console.WriteLine("{0}\t{1}\t        {2}\t", item.Type, item.ID, item.BuyDate);

            }

            Console.WriteLine("\n***************设置计算机ID后******************");
            //设置计算机ID
            myManager.SetID(computers);


            //设置计算机ID之后的计算机信息
            Console.WriteLine("计算机型号\t计算机ID     \t购买时间");
            foreach (Computer item in computers)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", item.Type, item.ID, item.BuyDate);

            }
            Console.ReadLine();
        }
    }
}
