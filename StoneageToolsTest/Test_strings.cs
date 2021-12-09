using System;

using StoneageTools.Strings;

namespace StoneageToolsTest
{
    public static class Test_strings
    {
        public static void Test()
        {
            Console.WriteLine($"Left {StoneageToolsStrings.Left ("StoneAge", 5)}");      // Stone
            Console.WriteLine($"Right {StoneageToolsStrings.Right("StoneAge", 3)}");     // Age
            Console.WriteLine($"Mid {StoneageToolsStrings.Mid("StoneAge", 5, 2)}");      // eA
            Console.WriteLine($"Mid {StoneageToolsStrings.Mid("StoneAge", 3, 3)}");      // one
            Console.WriteLine($"Mid {StoneageToolsStrings.Mid("StoneAge", 6, 3)}");      // Age
            Console.WriteLine($"Mid {StoneageToolsStrings.Mid("StoneAge", 6)}");         // Age
        }
    }
}