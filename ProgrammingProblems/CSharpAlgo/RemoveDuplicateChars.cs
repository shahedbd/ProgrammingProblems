using System;

namespace ProgrammingProblems.CSharpAlgo {
    public static class RemoveDuplicateChars {
        public static void Execute () {
            string value1 = RemDuplicate ("Csharpstar");
            string value2 = RemDuplicate ("Google");
            string value3 = RemDuplicate ("Yahoo");
            string value4 = RemDuplicate ("CNN");
            string value5 = RemDuplicate ("Line1\nLine2\nLine3");

            Console.WriteLine (value1);
            Console.WriteLine (value2);
            Console.WriteLine (value3);
            Console.WriteLine (value4);
            Console.WriteLine (value5);
        }

        public static string RemDuplicate (string key) {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key) {
                // See if character is in the table.
                if (table.IndexOf (value) == -1) {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}