using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacketBalanced
{
    public class Program
    {
        private static char[] backets = { '[', '{', '(', ')', '}', ']' };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an expression:");
            var inputString = Console.ReadLine();
            var b = IsBalanced(inputString);
            if (b)
            {
                Console.Write("Y");
            }
            else
            {
                Console.Write("N");
            }
            foreach (var ch in inputString)
            {
                if (backets.Contains(ch))
                {
                    Console.Write(ch);
                }
            }

           Console.ReadLine();
        }

        public static bool IsBalanced(string inputString)
        {
            List<char> list = new List<char>();
            List<char> list2 = new List<char>();

            foreach (var ch in inputString)
            {
                switch (ch)
                {
                    case '[':
                        list2.Add(ch);                        
                        break;
                    case '{':
                        list2.Add(ch);                       
                        break;
                    case '(':
                        list2.Add(ch);                       
                        break;
                    case ']':
                        if (list2[list2.Count - 1] == '[' && list2.Count > 0)
                        {
                            list2.Remove('[');
                        }
                        else
                        {
                            return false;
                        }                        
                        break;
                    case '}':
                        if (list2[list2.Count - 1] == '{' && list2.Count > 0)
                        {
                            list2.Remove('{');
                        }
                        else
                        {
                            return false;
                        }                        
                        break;
                    case ')':
                        if (list2[list2.Count - 1] == '(' && list2.Count > 0)
                        {
                            list2.Remove('(');
                        }
                        else
                        {
                            return false;
                        }                       
                        break;

                };
            }                  
            return list2.Count == 0;
        }
    }
}
