using System;
using StoneageTools.Coordinates;

namespace StoneageToolsTest
{
    public static class Test_coordinates
    {
        public static void Test()
        {
            StoneageCoordinates stoneageCoordinates = new();

            double lati = 0, loni = 0;
            int zoni = 0;
            Console.WriteLine("\n*** Geo-Koordinaten zu UTM ***");
            Console.WriteLine("Gesichert: 52.717297, 13.439137 = 33U 0394570 5841965");
            stoneageCoordinates.LL_2_UTM(22,52.717297, 13.439137, ref lati, ref loni, ref zoni);
            Console.WriteLine($"Routine: {zoni} {loni} {lati}\n");

            Console.WriteLine("\n*** UTM-Koordinaten zu Geo ***");
            Console.WriteLine("Gesichert: 33U 0394570 5841965 = 52.717297, 13.439137");
            double norting = 0, easting = 0;
            stoneageCoordinates.UTM_2_LL(22, lati, loni, zoni, ref norting, ref easting);
            Console.WriteLine($"Routine: {norting} {easting}\n");

            Console.WriteLine("\n*** DDD -> DMM ***");
            Console.WriteLine("Gesichert: 52.717297 = 52° 43.0374'");
            string erg = stoneageCoordinates.DDD_2_DMM("52.717297");
            Console.WriteLine("Routine: " + erg);
            erg = stoneageCoordinates.DDD_2_DMM("N52.717297");
            Console.WriteLine("Routine: " + erg);
            erg = stoneageCoordinates.DDD_2_DMM("N52.717297°");
            Console.WriteLine("Routine: " + erg);

            Console.WriteLine("\n*** DDD -> DMM ***");
            Console.WriteLine("Gesichert: 11.88141 = 11° 52.8846");
            erg = stoneageCoordinates.DDD_2_DMM("11.88141");
            Console.WriteLine("Routine: " + erg);
            erg = stoneageCoordinates.DDD_2_DMM("E11.88141");
            Console.WriteLine("Routine: " + erg);
            erg = stoneageCoordinates.DDD_2_DMM("E11.88141°");
            Console.WriteLine("Routine: " + erg);
    }
    }
}