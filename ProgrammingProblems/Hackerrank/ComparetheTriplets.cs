using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblems.Hackerrank
{
    //Problem: https://www.hackerrank.com/challenges/compare-the-triplets/problem
    public static class ComparetheTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int aliceCount = 0;
            int bobCount = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) aliceCount++;
                else if (a[i] < b[i]) bobCount++;
            }

            result.Add(aliceCount);
            result.Add(bobCount);

            return result;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            int[] arr1 = { 5, 6, 7 };
            int[] arr2 = { 3, 6, 10 };

            List<int> a = arr1.ToList();
            List<int> b = arr2.ToList();




            List<int> result = compareTriplets(a, b);


            foreach (var item in result)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
