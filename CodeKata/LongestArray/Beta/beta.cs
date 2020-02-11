using System;
using System.Collections.Generic;
using System.Text;

namespace LongestArray.Beta
{
    class beta
    {
        public static string sayMeOperations(string stringNumbers)
        {
                string[] numberArray;
                string returnValue = string.Empty;

                numberArray = stringNumbers.Split(' ');
                for (int i = 0; i < numberArray.Length - 2; i++)
                {
                    if (int.TryParse(numberArray[i], out int a) &&
                        int.TryParse(numberArray[i + 1], out int b) &&
                        int.TryParse(numberArray[i + 2], out int c))
                    {
                        if (a + b == c)
                            returnValue += "addition, ";
                        else if (a - b == c)
                            returnValue += "subtraction, ";
                        else if (a * b == c)
                            returnValue += "multiplication, ";
                        else if (a / b == c)
                            returnValue += "division, ";
                    }
                }

                returnValue = returnValue.TrimEnd(new[] { ',', ' ' });

                return returnValue;
            }
            //int x = 0;
            //int add = 0;
            //int multi = 0;
            //int sub = 0;
            //int divi = 0;
            //int z = 0;
            //var v = stringNumbers.Split(' ').ToArray();
            //var list = stringNumbers.Split(' ').ToList();
            //string s = "";

            //for (int i = 0; i < v.Length; i++)
            //{
            //    int j = i + 1;
            //    int k = i + 2;
            //    if (k == v.Length)
            //    {
            //        break;
            //    }
            //    x = int.Parse(v[i]);
            //    z = int.Parse(v[j]);
            //    add = x + z;
            //    multi = x * z;
            //    sub = x - z;
            //    divi = x / z;

            //    if (add == int.Parse(v[k]))
            //    {
            //        s += "addition, ";
            //    }
            //    else if (sub == int.Parse(v[k]))
            //    {
            //        s += "subtraction, ";
            //    }
            //    else if (multi == int.Parse(v[k]))
            //    {
            //        s += "multiplication, ";
            //    }
            //    else if (divi == int.Parse(v[k]))
            //    {
            //        if (int.Parse(v[i]) != 0)

            //            s += "division, ";
            //    }
            //}


            //s = s.Remove(s.Length - 2, 2);
            //return s;
            //Other Solution
            // List<int> l = s.Split(' ').Select(Int32.Parse).ToList();
            //   return String.Join(", ", Enumerable.Range(0, l.Count - 2).Select(i => l[i] + l[i + 1] == l[i + 2] ? "addition" : l[i] - l[i + 1] == l[i + 2] ? "subtraction" : l[i] * l[i + 1] == l[i + 2] ? "multiplication" : "division"));
            //string buffer = "";
            //int n1 = 0;
            //int n2 = 0;
            //int n3 = 0;
            //string[] numbers = stringNumbers.Split(' ');
            //for (int i = 0; i < numbers.Length - 2; i++)
            //{
            //    n1 = Convert.ToInt32(numbers[i]);
            //    n2 = Convert.ToInt32(numbers[i + 1]);
            //    n3 = Convert.ToInt32(numbers[i + 2]);
            //    if ((n1 + n2) == n3)
            //        buffer += "addition";
            //    else if ((n1 - n2) == n3)
            //        buffer += "subtraction";
            //    else if ((n1 * n2) == n3)
            //        buffer += "multiplication";
            //    else
            //        buffer += "division";
            //    if (i != numbers.Length - 3)
            //        buffer += ", ";
            //}
            //return buffer;
        }
    }

