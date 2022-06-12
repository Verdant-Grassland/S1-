using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBack
{
     class User
    {
        public string name;
        public string password;
        public string identityNum;
        public double balance;
        public string account;
    }

    class Bank
    {
        User user = new User();
        #region 开户
        public void CreateAccount()
        {
            Console.WriteLine("输入用户名：");
            user.name = Console.ReadLine();
            Console.WriteLine("输入密码：");
            user.password = Console.ReadLine();
            Console.WriteLine("输入身份证号：");
            user.identityNum = Console.ReadLine();
            Console.WriteLine("输入用户的存款金额：");
            user.balance = double.Parse(Console.ReadLine());
            user.account = "1458632487963";
            Console.WriteLine("账号：{0}，用户名：{1}，存款金额{2}",user.account,user.name,user.balance);
        }
        #endregion
    }
    class MyBanck
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.CreateAccount();
            Console.ReadLine();
        }
    }
}
