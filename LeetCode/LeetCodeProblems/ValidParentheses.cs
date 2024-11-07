using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ValidParentheses
    {
        //public string s = "()";
        //public string s = "()[]{}";
        //public string s = "(]";
        //public string s = "([])";
        //public string s = "({)}";
        //public string s = "]";
        //public string s = "(([]){})";
        //public string s = "[{([[]]})";
        public string s = "[([]])";

        public bool IsValid(string s)
        {
            
        }
        static void Main(string[] args)
        {
            ValidParentheses vp = new ValidParentheses();
            vp.IsValid(vp.s);
        }
    }
}
