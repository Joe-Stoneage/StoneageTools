
using System.Collections.Generic;
using System.IO;

using StoneageTools.Strings;

namespace StoneageToolsTest
{
    // Taking a units list from UnitConverters.net and creates c#-source (static methods)
    public static class DataTextConverter
    {
        public static void DoIt()
        {
            const string fileIn ="data";
            const string fileOut ="result.txt";
            int t, len;
            string wert1, wert2;
            string a1, a2, wertstr;
            string oa1, oa2;
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
                    oa1 = a1;
                    a2 = line[(t+1)..].Trim();
                    oa2 = "vv: " + a2;

                    t = a1.IndexOf("[");
                    if (t != -1)
                    {
                        u1 = a1[t..].Trim();
                        u1 = u1.Substring(1, u1.Length-2);
                        a1 = a1[..(t-1)].Trim();
                    }
                    else
                    {
                        u1 = string.Empty;
                    }

                    t = a2.IndexOf("[");
                    if (t != -1)
                    {
                        u2 = a2[t..].Trim();
                        u2 = u2.Substring(1, u2.Length-2);
                        a2 = a2[..(t-1)].Trim();
                    }
                    else
                    {
                        u2 = string.Empty;
                    }

                    t = a1.IndexOf(" ");
                    wertstr = a1[..t].Trim();
                    wert1 = wertstr;
                    a1 = a1[(t+1)..].Trim();

                    t = a2.IndexOf(" ");
                    wertstr = a2[..t].Trim();
                    wert2 = wertstr;
                    a2 = a2[(t+1)..].Trim();

                    a1 = a1.Capitalize();
                    a1 = a1.Capitalize('(');
                    a1 = a1.Capitalize('/');
                    a1 = a1.Capitalize('@');
                    a1 = a1.Replace("@","At");
                    a1 = a1.Replace("/","Per");
                    a1 = a1.Replace("°","Deg");
                    a1 = a1.Replace("'s","");
                    a1 = a1.Capitalize('-');
                    a1 = a1.RemoveCharacters('(', ')','-',' ');

                    a2 = a2.Capitalize();
                    a2 = a2.Capitalize('(');
                    a2 = a2.Capitalize('/');
                    a2 = a2.Capitalize('@');
                    a2 = a2.Replace("@","At");
                    a2 = a2.Replace("/","Per");
                    a2 = a2.Replace("°","Deg");
                    a2 = a2.Replace("'s","");
                    a2 = a2.Capitalize('-');
                    a2 = a2.RemoveCharacters('(', ')','-',' ');

                    if (u1?.Length == 0)
                    {
                        u1 = a1;
                    }
                    if (u2?.Length == 0)
                    {
                        u2 = a2;
                    }

                    a2 = a2.Capitalize();

                    System.Console.WriteLine($"{a1} \t {u1} {wert1}");
                    System.Console.WriteLine($"{a2} \t {u2} {wert2}");

                    p1 = $"public static double {a1}_2_{a2}(double inVal)";
                    while (p1.Length < 80)
                    {
                        p1 += " ";
                    }
                    p1 += $"=> inVal * {wert2};";

                    System.Console.WriteLine($"{line}");
                    System.Console.WriteLine($"{p1}");

                    p2 = $"public static double {a2}_2_{a1}(double inVal)";
                    while (p2.Length < 80)
                    {
                        p2 += " ";
                    }
                    p2 += $"=> inVal / {wert2};";
                    System.Console.WriteLine($"{p2}");

                    System.Console.WriteLine("\n");

                    code.Add("/// <summary>");
                    code.Add($"/// {u1} -> {u2}");
                    code.Add("/// "+ oa1 + " to " + oa2);
                    code.Add("/// </summary>");
                    code.Add(p1);
                    code.Add("/// <summary>");
                    code.Add($"/// {u2} -> {u1}");
                    code.Add("/// "+ oa2 + " to " + oa1);
                    code.Add("/// </summary>");
                    code.Add(p2);
                    code.Add("");
                }
            }
            File.WriteAllLines(fileOut, code);
        }
    }
}