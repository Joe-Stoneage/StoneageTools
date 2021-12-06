
namespace StoneageTools.Numbers
{
    public static class StoneageToolsNumbers
    {
        public static double ConvertMegabytes_2_Gigabytes(double megabytes) // SMALLER
        {
            return megabytes / 1024.0;
        }

        public static double ConvertMegabytes_2_Terabytes(double megabytes) // SMALLER
        {
            return megabytes / (1024.0 * 1024.0);
        }

        public static double ConvertGigabytes_2_Megabytes(double gigabytes) // BIGGER
        {
            return gigabytes * 1024.0;
        }

        public static double ConvertGigabytes_2_Terabytes(double gigabytes) // SMALLER
        {
            return gigabytes / 1024.0;
        }

        public static double ConvertTerabytes_2_Megabytes(double terabytes) // BIGGER
        {
            return terabytes * (1024.0 * 1024.0);
        }

        public static double ConvertTerabytes_2_Gigabytes(double terabytes) // BIGGER
        {
            return terabytes * 1024.0;
        }
    }
}
