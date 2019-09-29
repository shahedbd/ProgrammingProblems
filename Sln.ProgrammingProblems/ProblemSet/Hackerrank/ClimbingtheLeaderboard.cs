using System.Collections.Generic;
using System.Linq;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    public static class ClimbingtheLeaderboard
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            scores = scores.Distinct().ToArray();
            List<int> aliceRankList = new List<int>();

            for (int i = 0; i < alice.Length; i++)
            {
                for (int j = scores.Length - 1; j >= 0; j--)
                {
                    if (alice[i] < scores[j])
                    {
                        aliceRankList.Add(j + 2);
                        break;
                    }
                    else if (alice[i] == scores[j])
                        aliceRankList.Add(j + 1);

                }

                if (i == (alice.Length - 1) && alice[i] > scores[0])
                    aliceRankList.Add(1);
            }

            int[] result = aliceRankList.ToArray();
            return result.Distinct().ToArray();
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int scoresCount = Convert.ToInt32(Console.ReadLine());

            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            //int aliceCount = Convert.ToInt32(Console.ReadLine());

            //int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] scores = { 100, 90, 90, 80, 75, 60 };
            int[] alice = { 50, 65, 77, 90, 102 };

            //int[] scores = { 100, 100, 50, 40, 40, 20, 10 };
            //int[] alice = { 5, 25, 50, 120 };

            //int[] scores = { 1 };
            //int[] alice = { 1, 1 };

            int[] result = climbingLeaderboard(scores, alice);

            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
