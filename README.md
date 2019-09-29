# ProgrammingProblems


#### Programming Problems practice using C# code.
1. General Problem
2. HackerRank
3. Others



#### Sample IO Pattern
```csharp
public void IOPatternOne()
{
    int intNoInput1 = Convert.ToInt16(Console.ReadLine());
    String[] inputArry1 = Console.ReadLine().Split(' ');

    for (int k = 0; k < inputArry1.Length; k++) Console.WriteLine(inputArry1[k]);


    int intNoInput2 = Convert.ToInt16(Console.ReadLine());
    string[] strOutPut = new string[intNoInput2];

    Console.ReadKey();
}

public static void IOPatternTwo()
{
    while (true)
    {
        Console.Write("Enter a number between 1 and 100: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number < 0 || Number > 100)
            Console.WriteLine("Sorry. Try again.");
        else
        {
            int sum = 0;
            for (int i = 1; i <= Number; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum of values: " + sum);
        }
    }
}
```
