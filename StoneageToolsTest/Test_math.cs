using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using StoneageTools.Math;

namespace StoneageToolsTest
{
    [TestClass]
    public static class Test_math
    {
        [TestMethod]
        public static void Test()
        {
            const byte x = 129;
            Console.WriteLine("High-Nibble von {0} = {1}", x, StoneageToolsMath.HiNibble(x));
            Console.WriteLine("Low-Nibble von {0} = {1}", x, StoneageToolsMath.LoNibble(x));
        }
    }
}