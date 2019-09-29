using System;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/electronics-shop/problem
    public static class ElectronicsShop
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxMoneySpend = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int TotalBuy = keyboards[i] + drives[j];
                    if (TotalBuy <= b && TotalBuy > maxMoneySpend) maxMoneySpend = TotalBuy;
                }
            }


            return maxMoneySpend;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] bnm = Console.ReadLine().Split(' ');
            //int b = Convert.ToInt32(bnm[0]);
            //int n = Convert.ToInt32(bnm[1]);
            //int m = Convert.ToInt32(bnm[2]);

            //int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            //int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));


            int[] keyboards = { 4 };
            int[] drives = { 5 };
            int b = 5;

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent);

            //textWriter.WriteLine(moneySpent);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
