using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBack
{
    class User
    {
        //账号
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //密码
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //身份证号
        private string identityNum;

        public string IdentityNum
        {
            get { return identityNum; }
            set { identityNum = value; }
        }
        //余额
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private string account;

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        #region 存款
        ///<summary>
        ///存款
        ///</summary>
        ///<param name = "money">存的钱数</param>
        ///<returns>余额</returns>
        public double SaveMoney(int money)
        {
            if (money <= 0)
            {
                return -1;
            }
            else
            {
                balance = balance + money;
                return balance;
            }
        }
        #endregion 

        #region 取钱
        public double GetMoney(int money)
        {
            if (money > Balance)
            {
                return -2;
            }
            else if (money <= 0)
            {
                return -1;
            }
            else
            {
                Balance = Balance - money;
                return Balance;
            }
        }
        #endregion

        #region 转账
        
        #endregion
    }

    class Bank
    {
        User user = new User();
        User[] userGroup = new User[3];
        #region 开户
        public void CreateAccount()
        {
            Console.WriteLine("输入用户名：");
            user.Name = Console.ReadLine();
            Console.WriteLine("输入密码：");
            user.Password = Console.ReadLine();
            Console.WriteLine("输入身份证号：");
            user.IdentityNum = Console.ReadLine();
            Console.WriteLine("输入用户的存款金额：");
            user.Balance = double.Parse(Console.ReadLine());
            user.Account = user.Name;
            Console.WriteLine("账号：{0}，用户名：{1}，存款金额{2}", user.Account, user.Name, user.Balance);
        }
        #endregion

        #region 取钱

        public void GetMoney()
        {
            Console.WriteLine("输入账号");
            string account = Console.ReadLine();
            User user = CheckUser(account);
            if (user == null)
            {
                Console.WriteLine("没有此账号");
                return;
            }
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            if (user.Password != pwd)
            {
                Console.WriteLine("密码不正确");
                return;
            }
            Console.WriteLine("输入取款的金额：");
            int money = int.Parse(Console.ReadLine());
            double result = user.GetMoney(money);
            if (result == -1)
            {
                Console.WriteLine("取的钱数必须大于0");
            }
            else if (result == -2)
            {
                Console.WriteLine("余额不足");
            }
            else
            {
                Console.WriteLine("取钱成功!当前余额是：" + result);
            }
        }
        #endregion

        #region 菜单
        public void ShowMenu()
        {
            bool flag = true;
            do
	        {
	            Console.WriteLine("=========================欢迎使用自动银行服务=========================");
                Console.WriteLine("1.存款      2.取款     3.查询余额     4.转账     5.修改密码     6.退出");
                Console.WriteLine("======================================================================");
                Console.WriteLine("请选择：");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
	            {
                    case 1:
                        SaveMoney();
                        break;
                    case 2:
                        GetMoney();
                        break;
                    case 3:
                        SearchMoney();
                        break;
                    case 4:
                        ChangeMoney();
                        break;
                    case 5:
                        UpdatePwd();
                        break;
                    case 6:
                        flag =false;
                        Console.WriteLine("退出系统，谢谢使用！");
                        break;
		            default:
                        break;
	            }
	        } while (flag);
        }
        #endregion

        #region 初始化三个用户
        public void Initial()
        {
            User user1 = new User();
            user1.Name = "张丽";
            user1.Password = "154856";
            user1.IdentityNum = "210921198009087656";
            user1.Balance = 3000;
            user1.Account = "1111";

            User user2 = new User();
            user2.Name = "张丽";
            user2.Password = "123456";
            user2.IdentityNum = "210921188802098756";
            user2.Balance = 8000;
            user2.Account = "2222";

            User user3 = new User();
            user3.Name = "李玉";
            user3.Password = "1547852";
            user3.IdentityNum = "210921188802096789";
            user3.Balance = 4000;
            user3.Account = "3333";

            userGroup[0] = user1;
            userGroup[1] = user2;
            userGroup[2] = user3;
        }
        #endregion

        #region 编历对象数组的数据
        public void ShowInfo()
        {
            foreach (User user in userGroup)
            {
                Console.WriteLine("用户名：{0}，账号是：{1}，存款金额是：{2}",user.Name,user.Account,user.Balance);
            }
        }
        #endregion

        #region 检查账号
        public User CheckUser(string account)
        {
            foreach (User user in userGroup)
            {
                if (user.Account == account)
                {
                    return user;
                }
            }
            return null;
        }
        #endregion

        #region 存款
        public void SaveMoney()
        {
            Console.WriteLine("输入账号：");
            string account = Console.ReadLine();
            User user = CheckUser(account);
            if (user == null)
            {
                Console.WriteLine("没有此账号");
                return;
            }
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            if (pwd != user.Password)
	        {
                Console.WriteLine("密码不正确");
                return;
	        }
            Console.WriteLine("输入存款的金额：");
            int money = int.Parse(Console.ReadLine());
            double result = user.SaveMoney(money);
            if (result == -1)
            {
                Console.WriteLine("存款的金额不能小于等于0元");
            }
            else
            {
                Console.WriteLine("存款成功！账户余额是：" + result);
            }
        }
        #endregion

        #region 查询余额
        public void SearchMoney()
        {
            Console.WriteLine("输入账号：");
            string account = Console.ReadLine();
            User user = CheckUser(account);
            if (user == null)
            {
                Console.WriteLine("没有此账号");
                return;
            }
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            if (pwd != user.Password)
            {
                Console.WriteLine("密码不正确");
                return;
            }
            Console.WriteLine("账号余额是：" + user.Balance);
        }
        #endregion

        #region 转账
        public void ChangeMoney()
        {
            Console.WriteLine("输入转出账号：");
            string account = Console.ReadLine();
            User user = CheckUser(account);
            if (user == null)
            {
                Console.WriteLine("没有此账号");
                return;
            }
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            if (pwd != user.Password)
            {
                Console.WriteLine("密码不正确");
                return;
            }
            Console.WriteLine("输入被转入的账号：");
            string inAccount = Console.ReadLine();
            User inUser = CheckUser(inAccount);
            if (inUser == null)
            {
                Console.WriteLine("转入账号不存在");
                return;
            }
            Console.WriteLine("输入转账金额：");
            int money = int.Parse(Console.ReadLine());
            double outResult = user.GetMoney(money);
            if (outResult == -1)
            {
                Console.WriteLine("取的钱数必须大于0");
            }
            else
            {
                Console.WriteLine("转账成功!当前余额是：" + user.Balance);
            }
            double inResult = inUser.SaveMoney(money);
        }
        #endregion

        #region 修改密码
        public void UpdatePwd()
        {
            Console.WriteLine("输入账号：");
            string account = Console.ReadLine();
            User user = CheckUser(account);
            if (user == null)
            {
                Console.WriteLine("没有此账号");
                return;
            }
            Console.WriteLine("输入密码：");
            string pwd = Console.ReadLine();
            if (pwd != user.Password)
            {
                Console.WriteLine("密码不正确");
                return;
            }
            Console.WriteLine("输入新的密码：");
            string newPwd = Console.ReadLine();
            Console.WriteLine("输入确认密码：");
            string rePwd = Console.ReadLine();
            if (newPwd != rePwd)
            {
                Console.WriteLine("两次密码输入不一致！");
                return;
            }
            user.Password = newPwd;
            Console.WriteLine("修改密码成功");
        }
        #endregion
    }

        class MyBanck
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                /* bank.CreateAccount();
                 bank.GetMoney();*/
                bank.Initial();
                bank.ShowInfo();
                bank.ShowMenu();
                Console.ReadLine();
            }
        }
    }

