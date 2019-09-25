using System;

namespace ProblemSet.GeneralProblem
{
    public static class FibonacciSeries
    {
        public static void ExampleOne()
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


        public static void Fibonacci_Iterative(int SeriesLimit)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < SeriesLimit; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }


        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }
        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int GetNthFibonacci_Rec(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }

    }
}
