
namespace StoneageTools.Math
{
    public static class StoneageToolsMath
    {
        public static int LoNibble(byte x)
        {
            return x & 0x0F;
        }

        public static int HiNibble(byte x)
        {
            return x >> 4;
        }
    }
}
