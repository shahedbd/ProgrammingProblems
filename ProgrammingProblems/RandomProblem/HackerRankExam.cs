using System;
using System.Collections.Generic;

namespace ProgrammingProblems.RandomProblem
{
    //Date: 28.09.2019
    public static class HackerRankExam
    {
        public static int Sum(int x, int y)
        {

            return x / y;
        }


        static List<int> oddNumbers(int l, int r)
        {
            List<int> list = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (IsOddNumber(i))
                    list.Add(i);
            }

            return list;
        }

        public static bool IsOddNumber(long Number)
        {
            return Number % 2 != 0;
        }



        public static string lastLetters(string word)
        {
            var abc = word.Substring(word.Length - 2, 2);

            abc = Reverse(abc);
            return abc;
        }



        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public static void CharectarPOS()
        {
            var intNoInput = Console.ReadLine();

            char[] charInput = intNoInput.ToCharArray();

            for (int i = 0; i < charInput.Length; i++)
            {

                if (i % 3 == 0 && i > 0)
                {
                    charInput[i - 1] = char.ToUpper(charInput[i - 1]);
                }
            }


            for (int i = 5; i < charInput.Length; i++)
            {
                if (i % 5 == 0 && i > 0)
                {
                    charInput[i - 1] = '\0';
                }
            }

            Console.WriteLine(charInput);
        }
    }
}
