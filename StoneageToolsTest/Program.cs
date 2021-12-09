using System;

namespace StoneageToolsTest
{
    internal static class Program
    {
        private static void NewSection(string info)
        {
            Console.WriteLine("\n");
            Console.WriteLine(new string('=', 79));
            if (!string.IsNullOrEmpty(info))
            {
                Console.WriteLine(info.ToUpper());
            }
            else
            {
                Console.WriteLine("NEW TESTRUN");
            }
            Console.WriteLine(new string('=', 79));
        }

        private static void Main()
        {
            NewSection("");
            // DataTextConverter.DoIt();

            NewSection("Start Strings");
            Test_strings.Test();

            // NewSection("Start Math");
            // Test_math.Test();

            // NewSection("Start Coordinates");
            // Test_coordinates.Test();
        }
    }
}
