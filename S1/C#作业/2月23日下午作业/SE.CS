using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月23日下午作业
{
    class SE
    {
        public int id;
        public string name;
        public int age;
        public void ShowSE() 
        {
            Console.WriteLine("程序员编号:{0}，姓名:{1}，年龄:{2}",id,name,age);
        }
    }

    class SEBiz
    {
        SE[] se = new SE[10];
        public void add(SE num)
        {
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i] == null)
                {
                    se[i] = num;
                    break;
                }
            }
        }
        public bool searchName(string name)
        {
            bool flag = false;
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i].name.Equals(name))
                {
                    flag = true;
                    se[i].ShowSE();
                    break;
                }
            }
            return flag;
        }
        public void showInfo()
        {
            for (int i = 0; i < se.Length; i++)
            {
                if (se[i] != null)
                {
                    se[i].ShowSE();
                }
            }
        }
    }

    class TestSE
    {
        static void Main(string[] args)
        {
            SEBiz sbiz = new SEBiz();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n请输入第" + (i + 1) + "个用户的信息:");
                SE se = new SE();
                Console.WriteLine("输入用户编号:");
                se.id = int.Parse(Console.ReadLine());
			    Console.WriteLine("输入用户名字:");
                se.name = Console.ReadLine();
			    Console.WriteLine("输入用户年龄:");
                se.age = int.Parse(Console.ReadLine());
                sbiz.add(se);
            }
            sbiz.showInfo();
		    Console.WriteLine("输入一个名字:");
            string name = Console.ReadLine();
		    if(sbiz.searchName(name))
            {
			   Console.WriteLine("找到了");
		    }
            else
            {
			   Console.WriteLine("没找到");
		    }
            Console.ReadLine();
        }
    }
}
