using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2月21日下午作业
{
    class Arayys
    {
       static void Main(string[] args)
        {
            int[] a = new int[] { 3, 4, 5, 6, 7 };
            int[] b = new int[] { 1, 2, 3, 4, 5 };
            for(int i = 0; i <b.Length; i++)
            {
                for(int j = 0; j <a.Length; j++)
                {
                    if(a[i] == b[j])
                    {
                        b[j] = a[i] * b[j];
                    }
                }
            }
            Console.Write("数组b的数组是：");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
