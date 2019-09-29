using System;
using System.Collections.Generic;

namespace ProblemSet.Hackerrank
{
    //https://www.hackerrank.com/challenges/grading/problem
    public static class GradingStudents
    {

        public static List<int> gradingStudents(List<int> grades)
        {

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] > 37 && grades[i] % 5 != 0)
                {
                    int remainder = grades[i] % 5;
                    if ((5 - remainder) < 3)
                        grades[i] = grades[i] + (5 - remainder);
                }
            }

            return grades;
        }


        public static void Execute()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());          

            //for (int i = 0; i < gradesCount; i++)
            //{
            //    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    grades.Add(gradesItem);
            //}

            List<int> grades = new List<int>();
            grades.Add(73);
            grades.Add(67);
            grades.Add(38);
            grades.Add(33);

            List<int> result = gradingStudents(grades);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
