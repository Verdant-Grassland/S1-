using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月07日晚自习作业
{
    class JianJe
    {
        public string name;
        public int age;
        public string Email;
        public double money;
        public string familyZZ;
        public void Show()
        {
            Console.WriteLine("我叫{0}，我住在{1}，我今年{2}，我的邮箱是{3}，我的工资{4}",name,familyZZ,age,Email,money);
        }
    }

    class Person
    {
        static void Main(string[] args)
        {
            JianJe j = new JianJe();
            j.name = "卡卡西";
            j.familyZZ = "沈阳市铁西区中央大街里丽新城一期";
            j.age = 36;
            j.Email = "244856935@qq.com";
            j.money = 6455.60;
            j.Show();
            Console.ReadLine();
        }
    }
}
