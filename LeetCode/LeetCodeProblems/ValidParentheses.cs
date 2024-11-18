using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ValidParentheses
    {
        public string s = "()";
        //public string s = "()[]{}";
        //public string s = "(]";
        //public string s = "([])";
        //public string s = "({)}";
        //public string s = "]";
        //public string s = "(([]){})";
        //public string s = "[{([[]]})";
        //public string s = "[([]])";

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            try
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case '(':
                            stack.Push(c);
                            break;

                        case '[':
                            stack.Push(c);
                            break;

                        case '{':
                            stack.Push(c);
                            break;

                        case '}':
                            if (stack.Peek() != '{')
                            {
                                return false;
                            }
                            stack.Pop();
                            break;

                        case ']':
                            if (stack.Peek() != '[')
                            {
                                return false;
                            }
                            stack.Pop();
                            break;

                        case ')':
                            if (stack.Peek() != '(')
                            {
                                return false;
                            }
                            stack.Pop();
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            if (stack.Count > 0) { return false; }
            return true;
        }
        static void Main(string[] args)
        {
            ValidParentheses vp = new ValidParentheses();
            Console.WriteLine(vp.IsValid(vp.s));
            Console.ReadLine();
        }
    }
}
