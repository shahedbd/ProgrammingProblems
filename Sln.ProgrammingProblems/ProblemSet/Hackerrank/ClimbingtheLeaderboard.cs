using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    //int[] scores = { 100, 90, 90, 80, 75, 60 };
    //int[] alice = { 50, 65, 77, 90, 102 };
    public static class ClimbingtheLeaderboard
    {
        static long[] climbingLeaderboard(int[] scores, int[] alice)
        {
            scores = scores.Distinct().ToArray();

            List<long> aliceRankList = new List<long>();

            for (long i = 0; i < alice.Length; i++)
            {
                for (long j = scores.Length - 1; j >= 0; j--)
                {
                    if (alice[i] < scores[j])
                    {
                        aliceRankList.Add(j + 2);
                        scores.RemoveFromArray((int)j);
                        break;
                    }
                    else if (alice[i] == scores[j])
                    {
                        aliceRankList.Add(j + 1);
                        scores.RemoveFromArray((int)j);
                        break;
                    }
                    else if (j == 0 && alice[i] > scores[0])
                        aliceRankList.Add(1);
                }
            }
            return aliceRankList.ToArray();
        }

        public static T[] RemoveFromArray<T>(this T[] original, T itemToRemove)
        {
            int numIdx = Array.IndexOf(original, itemToRemove);
            if (numIdx == -1) return original;
            List<T> tmp = new List<T>(original);
            tmp.RemoveAt(numIdx);
            return tmp.ToArray();
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int scoresCount = Convert.ToInt32(Console.ReadLine());

            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            //int aliceCount = Convert.ToInt32(Console.ReadLine());

            //int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            //int[] scores = { 100, 90, 90, 80, 75, 60 };
            //int[] alice = { 50, 65, 77, 90, 102 };
            //6,5,4,2,1

            int[] scores = { 100, 100, 50, 40, 40, 20, 10 };
            int[] alice = { 5, 25, 50, 120 };
            //6,4,2,1

            //int[] scores = { 1 };
            //int[] alice = { 1, 1 };

            //int[] scores = { 20, 10 };
            //int[] alice = { 5, 10, 50, 100, 20 };

            long[] result = climbingLeaderboard(scores, alice);

            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);


            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
