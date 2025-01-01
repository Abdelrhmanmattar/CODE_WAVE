using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY12
{
    public class Question
    {
        public string Body { get; set; }
        public float mark { get; set; }
        public Question(string _body="not question added",int _mark = 10)
        {
            this.Body = _body;
            this.mark = _mark;
        }
        public override string ToString()
        {
            return $"Question: {Body} \nMark: {mark}";
        }
    }
}
