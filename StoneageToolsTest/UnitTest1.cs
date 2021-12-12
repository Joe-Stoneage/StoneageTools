using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace StoneageToolsTest;

[TestClass]
public class UnitTest1
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
            Console.WriteLine("NEW TEST RUN");
        }
        Console.WriteLine(new string('=', 79));
    }

    [TestMethod]
    public void TestMethod()
    {
        NewSection("");
        // DataTextConverter.DoIt();

        NewSection("Start Strings");
        Test_strings.Test();

        NewSection("Start Math");
        Test_math.Test();

        NewSection("Start Coordinates");
        Test_coordinates.Test();
    }
}