using System.Linq;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    public static class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            int maxValue = ar.Max();
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (maxValue == ar[i]) count++;
            }
            return count;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine());
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int[] ar = { 3, 2, 1, 3 };
            int result = birthdayCakeCandles(ar);


            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
