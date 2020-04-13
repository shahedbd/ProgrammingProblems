using System;
using System.Collections.Generic;

namespace ProgrammingProblems.Hackerrank
{
    //Problem: https://www.hackerrank.com/challenges/sock-merchant/problem
    public static class SockMerchant
    {

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));


            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = sockMerchantAAA(ar);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }



        static int sockMerchantAAA(int[] socksPile)
        {
            var pairsFound = 0;
            var sockColorHash = new Dictionary<int, int>();

            foreach (var sock in socksPile)
            {
                if (sockColorHash.ContainsKey(sock))
                {
                    pairsFound++;
                    sockColorHash.Remove(sock);
                }
                else
                    sockColorHash.Add(sock, 1);
            }
            return pairsFound;
        }


    }
}
