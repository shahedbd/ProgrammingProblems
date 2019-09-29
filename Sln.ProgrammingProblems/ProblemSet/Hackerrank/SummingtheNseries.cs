using System;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/summing-the-n-series/problem
    //https://www.xarg.org/puzzle/hackerrank/summing-the-n-series/
    public static class SummingtheNseries
    {
        static long summingSeries(long n)
        {
            //long sum = 0;
            //for (long i = 1; i <= n; i++)
            //{
            //sum = sum + ((i * i) - (i - 1) * (i - 1));
            //}
            return (n * n % 1000000007);
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int t = Convert.ToInt32(Console.ReadLine());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    long n = Convert.ToInt64(Console.ReadLine());

            //    int result = summingSeries(n);

            //    textWriter.WriteLine(result);
            //}

            long result = summingSeries(5351871996120528);  //5351871996120528: 578351320
            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
