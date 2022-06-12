using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class Employee
    {
       public int empNo;
       public string name;
       public string sex;
       public int popularity;
	   public void show()
       {
           Console.WriteLine("职工号：{0}，姓名：{1}，性别：{2}，人气值：{3}",empNo,sex ,popularity);
	   }
    }

    class VoterEmployee
    {
        public void VoterComputer(Employee emp)
        {
            char num;
            do
	        {
	            Console.WriteLine("您为他们投票吗？(y/n)");
                num = char.Parse(Console.ReadLine());
                emp.popularity = emp.popularity + 1;
	        } while (num == 'y');
        }
    }

    class TestEmployee
    {
        static void main(string[] args)
        {
           Employee Work = new Employee();
           Console.WriteLine("输入您的职工号:");
           Work.empNo = int.Parse(Console.ReadLine());
           Console.WriteLine("输入您的姓名:");
           Work.name = Console.ReadLine();
           Console.WriteLine("输入您的性别:");
           Work.sex = Console.ReadLine();
           Console.WriteLine("输入您的人气值:");
           Work.popularity = int.Parse(Console.ReadLine());
           Work.show();

           VoterEmployee emp = new VoterEmployee();
           Work.popularity = 0;
           emp.VoterComputer(Work);
           Console.WriteLine();
        }
    }
}
