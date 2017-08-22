using System;

namespace ProblemSet.GeneralProblem
{
    public static class FibonacciSeries
    {
        public static void IMPFibonacciSeries()
        {
            while (true)
            {
                long SeriesLimit, fibo0 = 0, fibo1 = 1, fibo2 = 0;

                Console.Write("Enter the Limit : ");
                SeriesLimit = long.Parse(Console.ReadLine());

                Console.Write(fibo0 + " " + fibo1);

                for (long i = 0; i <= SeriesLimit; i++)
                {
                    fibo2 = fibo0 + fibo1;
                    Console.Write(" " + fibo2);

                    fibo0 = fibo1;
                    fibo1 = fibo2;
                }

                Console.WriteLine();
            }

        }
    }
}
