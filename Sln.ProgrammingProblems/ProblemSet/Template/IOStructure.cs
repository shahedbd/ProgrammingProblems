using System;

namespace ProblemSet.Template
{
    public class IOStructure
    {
        public void IOPatternOne()
        {
            int intNoInput1 = Convert.ToInt16(Console.ReadLine());
            String[] inputArry1 = Console.ReadLine().Split(' ');

            //int intNoInput = Convert.ToInt16(Console.ReadLine());
            //string[] strOutPut = new string[intNoInput];

            //String elements = Console.ReadLine();
            //String[] split_elements = elements.Split(' ');


            for (int k = 0; k < inputArry1.Length; k++) Console.WriteLine(inputArry1[k]);
            Console.ReadKey();
        }




    }
}
