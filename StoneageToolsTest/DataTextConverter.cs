
using StoneageTools.Strings;

namespace StoneageToolsTest
{
    public static class DataTextConverter
    {
        public static void DoIt()
        {
            string fileIn ="data-time-second";
            string fileOut ="result.txt";
            int t, len;
            double wert1, wert2;
            string a1, a2, wertstr;
            string u1, u2;
            string p1, p2;

            List<string> code = new();

            string[] lines = System.IO.File.ReadAllLines(@fileIn);
            foreach (string line in lines)
            {
                t = line.IndexOf("=");
                if (t != -1)
                {
                    len = line.Length;
                    a1 = line[..(t - 1)].Trim();
                    a2 = line[(t+1)..].Trim();

                    t = a1.IndexOf("[");
                    if (t != -1)
                    {
                        u1 = a1[t..].Trim();
                        a1 = a1[..(t-1)].Trim();
                    }
                    else
                    {
                        u1 = string.Empty;
                    }

                    t = a2.IndexOf("[");
                    u2 = a2[t..].Trim();
                    u2 = u2.Substring(1, u2.Length-2);
                    //u2 = u2.Capitalize();
                    a2 = a2[..(t-1)].Trim();

                    t = a1.IndexOf(" ");    // wert 1 links
                    wertstr = a1[..t].Trim();
                    wert1 = Double.Parse(wertstr);
                    a1 = a1[(t+1)..].Trim();

                    t = a2.IndexOf(" ");    // wert 2 rechts
                    wertstr = a2[..t].Trim();
                    wert2 = Double.Parse(wertstr);
                    a2 = a2[(t+1)..].Trim();

                    a1 = a1.Capitalize();
                    a1 = a1.Capitalize('(');

                    a1 = a1.RemoveCharacters('(', ')',' ');

                    if (u1 == string.Empty)
                    {
                        u1 = a1;
                        System.Console.WriteLine($"Extra {u1}");
                    }

                    a2 = a2.Capitalize();

                    System.Console.WriteLine($"{a1} \t {u1} {wert1}");
                    System.Console.WriteLine($"{a2} \t {u2} {wert2}");

                    p1 = $"public static double {a1}_2_{a2}(double inVal)";
                    while (p1.Length < 80)
                    {
                        p1 = p1 + " ";
                    }
                    p1 = p1 + $"=> inVal * {wert2};\t\t // {u1} -> {u2}";

                    System.Console.WriteLine($"{line}");
                    System.Console.WriteLine($"{p1}");

                    p2 = $"public static double {a2}_2_{a1}(double inVal)";
                    while (p2.Length < 80)
                    {
                        p2 = p2 + " ";
                    }
                    p2 = p2 + $"=> inVal / {wert2};\t\t // {u2} -> {u1}";
                    System.Console.WriteLine($"{p2}");

                    System.Console.WriteLine("\n");

                    code.Add(p1);
                    code.Add(p2);
                }
            }
            File.WriteAllLines(fileOut, code);
        }
    }
}