using System;
using System.Text;

namespace ProgrammingProblems.TestCode
{
    public static class StackOverflow
    {
        public static void UTF8toByte()
        {
            //Encoding _UTF8 = Encoding.UTF8;
            string[] _mainString = { "Héllo World" };
            Console.WriteLine("Main String: " + _mainString);

            //Convert a string to utf-8 bytes.
            byte[] _utf8Bytes = Encoding.UTF8.GetBytes(_mainString[0]);

            //Convert utf-8 bytes to a string.
            string _stringuUnicode = Encoding.UTF8.GetString(_utf8Bytes);
            Console.WriteLine("String Unicode: " + _stringuUnicode);
        }

        public static void RangeSum()
        {
            while (true)
            {
                Console.Write("Enter a number between 1 and 100: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 0 || Number > 100)
                    Console.WriteLine("Sorry. Try again.");
                else
                {
                    int sum = 0;
                    for (int i = 1; i <= Number; i++)
                    {
                        sum = sum + i;
                    }

                    Console.WriteLine("Sum of values: " + sum);
                }
            }
        }
    }
}
