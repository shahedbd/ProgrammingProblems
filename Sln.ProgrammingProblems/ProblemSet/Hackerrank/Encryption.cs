using System;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/encryption/problem
    public static class Encryption
    {
        static string encryption(string s)
        {
            int InitialLength = s.Length;
            s = s.Replace(" ", string.Empty);
            int RemoveSpaceLength = s.Length;

            int Row = (int)Math.Round(Math.Sqrt(RemoveSpaceLength));
            int Column = Row + 1;

            string[] ar = new string[Row];

            int Position = 0;
            for (int i = 0; i < Row; i++)
            {
                if (i == Row - 1)
                {
                    ar[i] = s.Substring(Position, (RemoveSpaceLength - Position));
                }
                else ar[i] = s.Substring(Position, Column);
                Position = Position + Row + 1;
            }

            return "";
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //string s = Console.ReadLine();

            string s = "if man was meant to stay on the ground god would have given us roots";
            string result = encryption(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
