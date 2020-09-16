using System;
using System.Collections.Generic;
using System.Text;

namespace daily_coding_problem.Problems
{
    public class Problem491
    {
        public static void Start()
        {
            try
            {
                Console.Write("enter the number(int): ");
                var number = Convert.ToInt32(Console.ReadLine());

                var output = Solve(number);
                Console.WriteLine(output);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static bool Solve(int s)
        {
            if (s < 0)
                return false;
            if (s < 10)
                return true;
            if (s % 10 == 0)
                return false;

            var div = 10;
            while (s / div > 9)
            {
                div *= 10;
            }

            while (s > 10 || div >= 1)
            {
                if ((s / div) != (s % 10))
                    return false;

                s = (s % div) / 10;
                div /= 100;
            }

            return true;

        }


        //FAster solution <from leetcode>
        private static bool SolveFaster(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int xx = x;
            int digit, remain;
            int i = 0;

            int[] digits = new int[10];
            while (xx > 0)
            {
                remain = xx / 10;
                digit = xx - 10 * remain;
                digits[i] = digit;
                xx = remain;
                i++;
            }

            i -= 1;
            for (int j = 0; j <= i; j++)
            {
                if (digits[j] != digits[i - j])
                    return false;
            }

            return true;
        }

        // Lesson learned: '/' and '%' operations are costlier that '+', '-', '*' and using arrays is faster than doing calculations
    }
}
