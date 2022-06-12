using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Office
{
    public class SE
    {
        //编号
        public string ID { get; set; }
        //姓名
        public string Name { get; set; }
        //年龄
        public int Age { get; set; }
        //人气值
        public int Popularity { get; set; }

        public string SayHi()
        {
            string message = string.Format("大家好，我是 {0}, 今年 {1}岁，工号是 {2}，我的人气值高达 {3}!", this.Name, this.Age, this.ID, this.Popularity);
            return message;
        }
    }
}
