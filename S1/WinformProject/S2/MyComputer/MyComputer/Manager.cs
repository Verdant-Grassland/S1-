using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyComputer
{
    public class Manager
    {
        /// <summary>
        /// 设置计算机ID
        /// </summary>
        /// <param name="comps"></param>
        public void SetID(Computer[] comps)
        {
            Random rand = new Random();

            foreach (Computer cp in comps)
            {
                cp.ID = cp.Type + "-" + rand.Next(1000, 9999);
            }
        }
    }
}
