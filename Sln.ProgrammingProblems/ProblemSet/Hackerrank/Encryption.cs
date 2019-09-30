using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/encryption/problem
    public static class Encryption
    {
        static string encryption(string s)
        {
            int InitialLength = s.Length;
            s = s.Replace(" ", string.Empty);
            int RemobeSpaceLength = s.Length;

            int Row = (int)Math.Round(Math.Sqrt(RemobeSpaceLength));
            int Column = Row + 1;

            string[] ar = new string[Row];

            int Position = 0;
            for (int i = 0; i < Row; i++)
            {
                if (i == Row - 1) Column = RemobeSpaceLength;
                ar[i] = s.Substring(Position, Column);
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
