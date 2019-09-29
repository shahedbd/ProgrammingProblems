using System;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/day-of-the-programmer/problem
    public static class DayoftheProgrammer
    {
        // Complete the dayOfProgrammer function below.
        public static string dayOfProgrammer2(int year)
        {
            int feb = 0; //days in february
            if (year < 1918) //julian
                feb = (year % 4 == 0) ? 28 : 29;
            else if (year > 1918) //gregorian
                feb = (year % 400 != 0) || (year % 100 == 0) && (year % 4 != 0) ? 29 : 28;
            else //dreaded 1918
                feb = 15;
            feb = 256 - (feb + 215);
            return feb.ToString() + ".09." + year.ToString();
        }

        public static string dayOfProgrammer(int year)
        {
            int feb = 0;
            if (year < 1918)
            {
                if (JuliancalendarLY(year)) feb = 12;
                else feb = 13;
            }
            else if (year > 1918)
            {
                if (DateTime.IsLeapYear(year)) feb = 12;
                else feb = 13;
            }
            else
                feb = 26; //dreaded 1918: Eight month(215) + 15(Feb)=203  256-230=26
            return feb.ToString() + ".09." + year.ToString();
        }


        public static bool JuliancalendarLY(int year)
        {
            if (year % 400 == 0 || year % 100 == 0 || year % 4 == 0)
                return true;
            return false;
        }

        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int year = Convert.ToInt32(Console.ReadLine().Trim());


            //1918: 26.09.1918   and //2100:  13.09.2100
            int year = 1918;
            string result = dayOfProgrammer(year);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
