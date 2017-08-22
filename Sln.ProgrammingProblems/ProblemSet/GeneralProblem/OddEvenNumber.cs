using System;

namespace ProblemSet.GeneralProblem
{
    static class OddEvenNumber
    {

        public static void PrintOddAndEvenNumber()
        {
            long SeriesLimit, eveneCount = 0, oddCount = 0;
            while (true)
            {
                Console.Write("Enter the Limit : ");
                SeriesLimit = long.Parse(Console.ReadLine());


                Console.Write("Given range even numbers are: ");
                for (int i = 1; i <= SeriesLimit; i++)
                {
                    if (IsEvenNumber(i))
                    {
                        Console.Write(i + " ");
                        eveneCount++;
                    }


                }

                Console.WriteLine();
                Console.Write("Total Even Number: " + eveneCount);
                Console.WriteLine();

                Console.Write("Given range odd numbers are: ");
                for (int i = 0; i <= SeriesLimit; i++)
                {
                    if (IsOddNumber(i))
                    {
                        Console.Write(i + " ");
                        oddCount++;
                    }

                }

                Console.WriteLine();
                Console.Write("Total Odd Number: " + oddCount);
                Console.WriteLine();
            }
        }



        public static bool IsOddNumber(long Number)
        {
            return Number % 2 != 0;
        }

        public static bool IsEvenNumber(long Number)
        {
            return Number % 2 == 0;
        }
    }
}
