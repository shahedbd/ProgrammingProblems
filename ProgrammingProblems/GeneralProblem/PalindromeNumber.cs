using System;
using System.Linq;

namespace ProgrammingProblems.GeneralProblem
{
    static class PalindromeNumber
    {
        public static void IMPPalindrome()
        {
            var input = Console.ReadLine();
            Console.WriteLine(IsPalindromeUsingLINQ(input.ToString()));
        }
        public static bool IsPalindromeUsingLINQ(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }



        public static void PalindromeRawLogic()
        {
            while (true)
            {
                int number, tempNumber, remainder, reverse = 0;
                Console.Write("Enter an integer: ");
                number = int.Parse(Console.ReadLine());

                tempNumber = number;

                //Main Logic
                while (number > 0)
                {
                    remainder = number % 10;
                    reverse = reverse * 10 + remainder;
                    number = number / 10;
                }

                Console.WriteLine("Given number is = {0}", tempNumber);
                Console.WriteLine("Its reverse is  = {0}", reverse);

                if (tempNumber == reverse)
                    Console.WriteLine("Given number is a palindrome.\n");
                else
                    Console.WriteLine("Given number is not a palindrome.\n");
            }

        }

    }
}
