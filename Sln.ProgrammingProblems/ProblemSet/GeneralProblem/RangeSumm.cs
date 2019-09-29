using System;
using System.Collections.Generic;

namespace ProblemSet.GeneralProblem
{
    public static class RangeSumm
    {

        public static void Prep()
        {
            List<int> list = new List<int>();
            int[] number = { 10, 50, 20, 10, 10, };
            list.AddRange(number);

            var abc = RangeSumm.Execute(list);
            Console.WriteLine(abc);
        }

        public static int Execute(List<int> list)
        {
            int Summ = 0;
            for (int i = 0; i < list.Count; i++)
                Summ = Summ + list[i];
            return Summ;
        }
    }
}
