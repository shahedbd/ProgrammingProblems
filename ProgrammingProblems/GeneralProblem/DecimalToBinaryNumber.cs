using System;

namespace ProgrammingProblems.GeneralProblem
{
    public static class DecimalToBinaryNumber
    {


        public static void DecimalToBinaryNumberRun()
        {
            while (true)
            {
                Console.Write("Please enter the number you wish to factorize: ");
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine("The number you entered was {0} and it's Binary is: {1}", number, DecimaltoBinaryCOnvertion(number));
                Console.WriteLine();
            }
        }

        public static string DecimaltoBinaryCOnvertion(long number)
        {
            long quot;
            string Remaining = "";

            while (number >= 1)
            {
                quot = number / 2;
                Remaining += (number % 2).ToString();
                number = quot;
            }

            string BinaryNumber = "";
            for (int i = Remaining.Length - 1; i >= 0; i--)
            {
                BinaryNumber = BinaryNumber + Remaining[i];
            }

            return BinaryNumber;
        }
    }
}
