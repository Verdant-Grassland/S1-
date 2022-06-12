using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3月02日晚自习作业
{
    class Student
    {
        public string result(string word)
        {
            string study = null;
            if (word == "学习")
            {
                study = "学习：选择更多的机会，成就未来";
            }
            else if(word =="不学习")
            {
                study = "不学习：一辈子吃生活的苦，只能干苦力";
            }
            return study;
        }
    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("请输入学习或者不学习的内容：");
            string study = Console.ReadLine();
            string result = student.result(study);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
