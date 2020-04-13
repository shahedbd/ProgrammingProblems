using System;
using System.Collections.Generic;

namespace ProgrammingProblems.GeneralProblem {
    public static class RangeSumm {

        public static void Execute () {
            List<int> list = new List<int> ();
            int[] number = { 10, 50, 20, 10, 10 };
            list.AddRange (number);

            var abc = RangeSumm.Prep (list);
            Console.WriteLine (abc);
        }

        public static int Prep (List<int> list) {
            int Summ = 0;
            for (int i = 0; i < list.Count; i++)
                Summ = Summ + list[i];
            return Summ;
        }
    }
}