using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class StringAddBinary
    {
        public string AddBinary(string a, string b)
        {
            int indexA = a.Length - 1;
            int indexB = b.Length - 1;

            string sumString = "";
            bool carry = false;

            // 
            while (indexA >= 0 && indexB >= 0)
            {
                string substrA = a.Substring(indexA,1);
                string substrB = b.Substring(indexB,1);

                if (substrA == "0" && substrB == "0")
                {
                    if (carry) 
                    {
                        sumString = sumString.Insert(0, "1");
                        carry = false;                      
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                    indexA--; indexB--;
                    continue;
                }
                if ((substrA == "1" && substrB == "0") || (substrA == "0" && substrB == "1"))
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "1");
                    }
                    indexA--; indexB--;
                    continue;
                }
                if (substrA == "1" && substrB == "1")
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "1");
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "0");
                        carry = true;
                    }
                    indexA--; indexB--;
                    continue;                  
                }
            }


            while (indexA > 0)
            {
                if (a.Substring(indexA,1) == "1")
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                    else
                    {
                        sumString = sumString.Insert(0,"1");
                        carry = false;
                    }
                }
                if (a.Substring(indexA, 1) == "0")
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "1");
                        carry = false;
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                }
                indexA--;
            }
            while (indexB > 0)
            {
                if (b.Substring(indexB, 1) == "1")
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "1");
                        carry = false;
                    }
                }
                if (b.Substring(indexB, 1) == "0")
                {
                    if (carry)
                    {
                        sumString = sumString.Insert(0, "1");
                        carry = false;
                    }
                    else
                    {
                        sumString = sumString.Insert(0, "0");
                    }
                }
                indexB--;
            }

            if (indexA == 0)
            {
                if (carry)
                {
                    sumString = sumString.Insert(0, "0");
                    sumString = sumString.Insert(0, "1");
                    return sumString;
                }
                else
                {
                    sumString = sumString.Insert(0, "1");
                    return sumString;
                }
            }
            if (indexB == 0)
            {
                if (carry)
                {
                    sumString = sumString.Insert(0, "0");
                    sumString = sumString.Insert(0, "1");
                    return sumString;
                }
                else
                {
                    sumString = sumString.Insert(0, "1");
                    return sumString;
                }
            }

            if (indexA == -1 & indexB == -1 && carry)
            {
                sumString = sumString.Insert(0, "1");
            }
            return sumString;
        }
        static void Main(string[] args)
        {
            StringAddBinary obj = new StringAddBinary();
            obj.AddBinary("110010", "10111");
            Console.ReadLine();
        }
    }
}
