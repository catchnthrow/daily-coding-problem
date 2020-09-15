using System;
using System.Collections.Generic;
using System.Text;

namespace daily_coding_problem.Problems
{
    public class Problem490
    {
        public static void Start()
        {
            try
            {
                Console.Write(
                    "enter the tree as a string with no spaces (single character for each node, unique node values): ");
                var inputStr = Console.ReadLine().ToCharArray();

                var output = Solve(inputStr);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static string Solve(char[] s)
        {
            var tempDict = new Dictionary<char, int>();
            var bottomViewDict = new Dictionary<int, char>();

            tempDict.Add(s[0], 0);
            bottomViewDict.Add(0, s[0]);
            var minDepthOfNode = int.MaxValue;
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i].Equals(string.Empty) || s[i] == ' ')
                {
                    continue;
                }

                int depthOfNode;
                if (i % 2 == 0) //right child
                {
                    var parentNodeIndex = (i - 2) / 2;
                    depthOfNode = tempDict[s[parentNodeIndex]] + 1;
                }
                else //left child
                {
                    var parentNodeIndex = (i - 1) / 2;
                    depthOfNode = tempDict[s[parentNodeIndex]] - 1;
                }

                if (bottomViewDict.ContainsKey(depthOfNode))
                {
                    bottomViewDict[depthOfNode] = s[i];
                }
                else
                {
                    bottomViewDict.Add(depthOfNode, s[i]);
                }

                //Add the ith element's depth in tempDict
                tempDict.Add(s[i], depthOfNode);
                if (minDepthOfNode > depthOfNode)
                {
                    minDepthOfNode = depthOfNode;
                }
            }

            var output = new StringBuilder(string.Empty);
            for (int i = 0; i < tempDict.Count; i++)
            {
                if(bottomViewDict.ContainsKey(minDepthOfNode))
                {
                    output.Append(bottomViewDict[minDepthOfNode++]).Append(" ");
                }
            }

            return output.ToString();

        }
    }
}
