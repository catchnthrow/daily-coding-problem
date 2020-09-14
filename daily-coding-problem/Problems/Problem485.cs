/*
 Given an integer k and a string s, find the length of the longest substring that contains at most k distinct characters.
 For example, given s = "abcba" and k = 2, the longest substring with k distinct characters is "bcb".
*/

using System;
using System.Collections.Generic;

namespace daily_coding_problem.Problems
{
    public class Problem485
    {
        public static void Start()
        {
            try
            {
                Console.WriteLine("enter string");
                var inputStr = Console.ReadLine();
                Console.WriteLine("enter k");
                var k = Convert.ToInt32(Console.ReadLine());

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

        private static string Solve(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var subStr = string.Empty;
            var dict = new Dictionary<char, int>();
            var start = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    if (dict.Count < k)
                    {
                        dict.Add(s[i], 1);
                    }
                    else // this will run when there is a new character after k unique characters
                    {
                        //Check if the new substring is greater than the old one, then update subStr var.
                        var newSubStr = s.Substring(start, i - start);
                        if (subStr.Length < newSubStr.Length)
                            subStr = newSubStr;

                        var uniqueChars = new List<char>();
                        dict.Clear(); // need to clean this up, as now we will find new list of unique characters
                        var j = i - 1;


                        //Now we have to traverse back from the index where we found the (k+1)th new alphabet to decide whick (k -1) will be part of the new substring.
                        for (; j > start; j--)
                        {
                            if (uniqueChars.Contains(s[j]))
                                continue;

                            //if we already found k-1 unique characters then we should stop traversing back.
                            if (uniqueChars.Count == k - 1)
                                break;

                            uniqueChars.Add(s[j]);
                            dict.Add(s[j], 1);
                        }

                        start = j + 1;
                        dict.Add(s[i], 1);
                    }
                }
            }
            //condition to handle the scenario when the substring is in the end of the input string.
            return subStr.Length > s.Substring(start, s.Length - start).Length ? subStr : s.Substring(start, s.Length - start);
        }
    }
}
