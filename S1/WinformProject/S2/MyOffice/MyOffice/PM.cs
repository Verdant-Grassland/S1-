using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    public class PM
    {
        //编号访问器
        public int Id { get; set; }
        //姓名访问器
        public string Name { get; set; }
        public void Judge(SE se,string judgement,int score)
        {
            se.Judgement = judgement;
            se.Score = score;
        }
    }
}
