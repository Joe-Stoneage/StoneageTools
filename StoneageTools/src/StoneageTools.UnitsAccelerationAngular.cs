
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region acceleration - angular, base: radian per square second

        /// <summary>
        /// RadianPerSquareMinute -> RadianPerSquareSecond
        /// 1 radian/square minute =  0.0002777778 radian/square second
        /// </summary>
        public static double RadianPerSquareMinute_2_RadianPerSquareSecond(double inVal)=> inVal * 0.0002777778;
        /// <summary>
        /// RadianPerSquareSecond -> RadianPerSquareMinute
        /// vv: 0.0002777778 radian/square second to 1 radian/square minute
        /// </summary>
        public static double RadianPerSquareSecond_2_RadianPerSquareMinute(double inVal)=> inVal / 0.0002777778;

        /// <summary>
        /// RevolutionPerSquareSecond -> RadianPerSquareSecond
        /// 1 revolution/square second =  6.2831853069 radian/square second
        /// </summary>
        public static double RevolutionPerSquareSecond_2_RadianPerSquareSecond(double inVal)=> inVal * 6.2831853069;
        /// <summary>
        /// RadianPerSquareSecond -> RevolutionPerSquareSecond
        /// vv: 6.2831853069 radian/square second to 1 revolution/square second
        /// </summary>
        public static double RadianPerSquareSecond_2_RevolutionPerSquareSecond(double inVal)=> inVal / 6.2831853069;

        /// <summary>
        /// RevolutionPerMinutePerSecond -> RadianPerSquareSecond
        /// 1 revolution/minute/second =  0.1047197551 radian/square second
        /// </summary>
        public static double RevolutionPerMinutePerSecond_2_RadianPerSquareSecond(double inVal)=> inVal * 0.1047197551;
        /// <summary>
        /// RadianPerSquareSecond -> RevolutionPerMinutePerSecond
        /// vv: 0.1047197551 radian/square second to 1 revolution/minute/second
        /// </summary>
        public static double RadianPerSquareSecond_2_RevolutionPerMinutePerSecond(double inVal)=> inVal / 0.1047197551;

        /// <summary>
        /// RevolutionPerSquareMinute -> RadianPerSquareSecond
        /// 1 revolution/square minute =  0.0017453293 radian/square second
        /// </summary>
        public static double RevolutionPerSquareMinute_2_RadianPerSquareSecond(double inVal)=> inVal * 0.0017453293;
        /// <summary>
        /// RadianPerSquareSecond -> RevolutionPerSquareMinute
        /// vv: 0.0017453293 radian/square second to 1 revolution/square minute
        /// </summary>
        public static double RadianPerSquareSecond_2_RevolutionPerSquareMinute(double inVal)=> inVal / 0.0017453293;

        #endregion
    }
}
