using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace daily_coding_problem.Problems
{
    public class Problem487
    {
        public static void Start()
        {
            try
            {
                Console.Write("enter the tree (single char as one node without spaces) (array implementation): ");
                var inputStr = Console.ReadLine().ToCharArray();
                Console.Write("enter the node whose cousins needs to be found: ");
                var k = Convert.ToChar(Console.ReadLine());

                var output = Solve(inputStr, k);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;

            }
        }

        private static string Solve(char[] s, char k)
        {
            var output = new StringBuilder(string.Empty);
            var index = Array.IndexOf(s, k);
            var treeLevel = 0;
            
            //Find the level of tree that we are talking about
            for (int i = 0; i < 2024; i++)
            {
                if (index < Math.Pow(2, i))
                {
                    treeLevel = i;
                    break;
                }
            }

            treeLevel--; // now we are at one level above the level we are concerned about.
            var startIndexAtLevel = Math.Pow(2, treeLevel - 1) - 1;
            var endIndexAtLevel = startIndexAtLevel * 2;
            
            for (var i = startIndexAtLevel; i <= endIndexAtLevel; i++)
            {
                var t1 = Convert.ToInt32((2 * i) + 1);
                var t2 = Convert.ToInt32((2 * i) + 2);
                if (s[t1] == k || s[t2] == k)
                {
                    continue;
                }

                output.Append(s[t1]).Append(" ").Append(s[t2]).Append(" ");
            }

            return output.ToString();
        }
    }
}
