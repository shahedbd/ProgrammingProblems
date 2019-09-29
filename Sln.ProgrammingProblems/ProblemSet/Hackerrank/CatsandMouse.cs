using System;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/cats-and-a-mouse
    public static class CatsandMouse
    {
        // Complete the catAndMouse function below.
        public static string catAndMouse(int x, int y, int z)
        {
            int Xdis = 0;
            if (x > z) Xdis = x - z;
            else Xdis = z - x;

            int Ydis = 0;
            if (y > z) Ydis = y - z;
            else Ydis = z - y;


            if (Xdis < Ydis)
                return "Cat A";
            else if (Xdis > Ydis)
                return "Cat B";
            else
                return "Mouse C";
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int q = Convert.ToInt32(Console.ReadLine());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string[] xyz = Console.ReadLine().Split(' ');

            //    int x = Convert.ToInt32(xyz[0]);

            //    int y = Convert.ToInt32(xyz[1]);

            //    int z = Convert.ToInt32(xyz[2]);

            //    string result = catAndMouse(x, y, z);

            //    textWriter.WriteLine(result);
            //}

            string result1 = catAndMouse(1, 2, 3);
            string result2 = catAndMouse(1, 3, 2);

            Console.WriteLine(result2);


            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
