
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region temperature

        public static double Celsius_2_Kelvin(double inVal)     => inVal+273.15;
        public static double Kelvin_2_Celsius(double inVal)     => inVal-273.15;
        public static double Celsius_2_Fahrenheit(double inVal) => inVal*(9/5)+32;
        public static double Fahrenheit_2_Celsius(double inVal) => (inVal-32)*5/9;
        public static double Kelvin_2_Fahrenheit(double inVal)  => (inVal-273.15)*(9/5)+32;
        public static double Fahrenheit_2_Kelvin(double inVal)  => (inVal-32)*(5/9)+273.15;
        public static double Rankine_2_Fahrenheit(double inVal) => inVal+459.67;
        public static double Fahrenheit_2_Rankine(double inVal) => inVal-459.67;

        #endregion

        #region temperature interval, base: kelvin
        /// <summary>
        /// °C -> K
        /// 1 degree Celsius [°C] =  1 kelvin [K]
        /// </summary>
        public static double DegreeCelsius_2_Kelvin(double inVal)                       => inVal * 1;
        /// <summary>
        /// K -> °C
        /// vv: 1 kelvin [K] to 1 degree Celsius [°C]
        /// </summary>
        public static double Kelvin_2_DegreeCelsius(double inVal)                       => inVal / 1;

        /// <summary>
        /// °C -> K
        /// 1 degree centigrade [°C] =  1 kelvin [K]
        /// </summary>
        public static double DegreeCentigrade_2_Kelvin(double inVal)                    => inVal * 1;
        /// <summary>
        /// K -> °C
        /// vv: 1 kelvin [K] to 1 degree centigrade [°C]
        /// </summary>
        public static double Kelvin_2_DegreeCentigrade(double inVal)                    => inVal / 1;

        /// <summary>
        /// °F -> K
        /// 1 degree Fahrenheit [°F] =  0.5555555556 kelvin [K]
        /// </summary>
        public static double DegreeFahrenheit_2_Kelvin(double inVal)                    => inVal * 0.5555555556;
        /// <summary>
        /// K -> °F
        /// vv: 0.5555555556 kelvin [K] to 1 degree Fahrenheit [°F]
        /// </summary>
        public static double Kelvin_2_DegreeFahrenheit(double inVal)                    => inVal / 0.5555555556;

        /// <summary>
        /// °R -> K
        /// 1 degree Rankine [°R] =  0.5555555556 kelvin [K]
        /// </summary>
        public static double DegreeRankine_2_Kelvin(double inVal)                       => inVal * 0.5555555556;
        /// <summary>
        /// K -> °R
        /// vv: 0.5555555556 kelvin [K] to 1 degree Rankine [°R]
        /// </summary>
        public static double Kelvin_2_DegreeRankine(double inVal)                       => inVal / 0.5555555556;

        /// <summary>
        /// °r -> K
        /// 1 degree Reaumur [°r] =  1.25 kelvin [K]
        /// </summary>
        public static double DegreeReaumur_2_Kelvin(double inVal)                       => inVal * 1.25;
        /// <summary>
        /// K -> °r
        /// vv: 1.25 kelvin [K] to 1 degree Reaumur [°r]
        /// </summary>
        public static double Kelvin_2_DegreeReaumur(double inVal)                       => inVal / 1.25;

        #endregion
    }
}
