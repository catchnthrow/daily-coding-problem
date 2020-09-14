using System;
using System.Collections.Generic;

namespace daily_coding_problem.Problems
{
    public class Problem489
    {
        public static void Start()
        {
            try
            {
                Console.Write("enter the array space separated: ");
                var inputStr = Console.ReadLine();

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

        private static int Solve(string s)
        {
            var dict = new Dictionary<string, int>();
            var arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var start = 0;
            var substrLen = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    substrLen = substrLen < i - start ? i - start : substrLen;
                    var tempStart = dict[arr[i]] + 1;
                    for (var j = dict[arr[i]]; j > start; j--)
                    {
                        dict.Remove(arr[i]);
                    }

                    start = tempStart;
                    dict[arr[i]] = i;
                }
                else
                {
                    dict.Add(arr[i], i);
                }
            }

            return dict.Count;
        }
    }
}
