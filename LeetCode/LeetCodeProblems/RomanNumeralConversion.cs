using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class RomanNumeralConversion
    {
        string s;
        public int RomanToInt(string s)
        {
            int num = 0;
            s = s + " ";
            char[] ca = s.ToCharArray();


            for (int count = 0; count < ca.Length; count++)
            {
                char ch = ca[count];
                switch (ch)
                {
                    case 'I':
                        if (ca[count + 1] == 'V')
                        {
                            num += 4;
                            count++;
                            continue;
                        }
                        if (ca[count + 1] == 'X')
                        {
                            num += 9;
                            count++;
                            continue;
                        }
                        else
                        {
                            num += 1;
                        }
                        break;

                    case 'V':
                        num += 5;
                        break;

                    case 'X':
                        if (ca[count + 1] == 'L')
                        {
                            num += 40;
                            count++;
                            continue;
                        }
                        if (ca[count + 1] == 'C')
                        {
                            num += 90;
                            count++;
                            continue;
                        }
                        else
                        {
                            num += 10;
                        }
                        break;

                    case 'L':
                        num += 50;
                        break;

                    case 'C':
                        if (ca[count + 1] == 'D')
                        {
                            num += 400;
                            count++;
                            continue;
                        }
                        if (ca[count + 1] == 'M')
                        {
                            num += 900;
                            count++;
                            continue;
                        }
                        else
                        {
                            num += 100;
                        }
                        break;

                    case 'D':
                        num += 500;
                        break;

                    case 'M':
                        num += 1000;
                        break;
                    case ' ':
                        break;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            RomanNumeralConversion r = new RomanNumeralConversion();
            Console.WriteLine(r.RomanToInt("MCMXCIV"));
            Console.ReadLine();
        }
    }
    
}

