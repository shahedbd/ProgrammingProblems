using System;

namespace ProgrammingProblems.GeneralProblem
{
    static class FactorialNumber
    {

        public static void IMPFactorial()
        {
            while (true)
            {
                Console.Write("Please enter the number you wish to factorize: ");
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine("The number you entered was {0} and it's factorial is: {1}", number, GetFactorial(number));
                Console.WriteLine();
            }
        }



        //A function that calls itself is, as you suspect, called "recursive".
        //Factorial of a Number Using Recursion
        static long GetFactorial(long N)
        {
            if (N == 1) return 1;
            return N * GetFactorial(N - 1);
        }
    }
}
