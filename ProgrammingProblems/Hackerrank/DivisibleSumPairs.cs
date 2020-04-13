using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblems.Hackerrank
{
    public static class DivisibleSumPairs
    {
        public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;
                }
            }
            return count;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //string[] nk = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(nk[0]);
            //int k = Convert.ToInt32(nk[1]);
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));


            int n = 6;
            int k = 3;
            int[] ar = { 1, 3, 2, 6, 1, 2 };

            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
