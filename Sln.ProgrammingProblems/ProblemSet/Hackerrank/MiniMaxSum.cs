using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSet.Hackerrank
{
    //Problem: https://www.hackerrank.com/challenges/mini-max-sum/problem
    public static class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            List<long> sumList = new List<long>();
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        sum = sum + arr[j];
                }
                sumList.Add(sum);
                sum = 0;
            }

            Console.Write(sumList.Min());
            Console.Write(" ");
            Console.Write(sumList.Max());

        }

        public static void Execute()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
