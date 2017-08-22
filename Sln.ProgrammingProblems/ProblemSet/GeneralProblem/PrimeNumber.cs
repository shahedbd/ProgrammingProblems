using System;

namespace ProblemSet.GeneralProblem
{
    class PrimeNumber
    {

        public static void IMPPimeNumber()
        {
            while (true)
            {
                long input = long.Parse(Console.ReadLine());
                Console.WriteLine(IsPimeNumber1(input));
            }

        }


        public static void PrimeSUM()
        {
            int i, count = 0, sum = 0;
            for (i = 1; i <= 100; i++)
            {
                if (IsPimeNumber2(i) == 1)
                {
                    Console.WriteLine(i + "\t");
                    sum = sum + i;
                    count++;
                }
            }

            Console.WriteLine("Total number of prime: " + count);
            Console.WriteLine("Total sum of prime: " + sum);
        }



        static bool IsPimeNumber1(long N)
        {
            if (N == 1) return false;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) return false;
            }

            return true;
        }



        static int IsPimeNumber2(long N)
        {
            if (N == 1) return 0;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) return 0;
            }

            return 1;
        }

    }



}
