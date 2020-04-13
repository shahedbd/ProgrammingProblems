using System;

namespace ProgrammingProblems.GeneralProblem
{
    public static class SwapTwoNumbers
    {
        public static void Execute()
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            a = a + b; //15
            b = a - b; //5
            a = a - b; //10

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

        }
    }
}
