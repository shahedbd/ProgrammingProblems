using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblems.Hackerrank
{
    public static class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {
            int maxSubarrayLength = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int count = 0;
                int countEqualLess = 0;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1 && a[i] <= a[j]) countEqualLess++;
                }

                int countEqualGreater = 0;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1 && a[i] >= a[j]) countEqualGreater++;
                }


                if (countEqualLess > countEqualGreater) count = countEqualLess;
                else count = countEqualGreater;

                if (count > maxSubarrayLength)
                    maxSubarrayLength = count;
            }
            return maxSubarrayLength + 1;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            //int result = Result.pickingNumbers(a);



            int[] arr1 = { 1, 1, 2, 2, 4, 4, 5, 5, 5 };
            int[] arr2 = { 4, 6, 5, 3, 3, 1 };
            int[] arr3 = { 1, 2, 2, 3, 1, 2 };

            int result1 = pickingNumbers(arr1.ToList());
            int result2 = pickingNumbers(arr2.ToList());
            int result3 = pickingNumbers(arr3.ToList());


            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
