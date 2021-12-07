
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
    }
}
