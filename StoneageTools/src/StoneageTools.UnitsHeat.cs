
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region heat capacity, base: joule/kilogram/K ([)J/(kg*K))

        /// <summary>
        /// J/(kg*°C) -> J/(kg*K)
        /// 1 joule/kilogram/°C [J/(kg*°C)] =  1 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double JoulePerKilogramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 1;
        /// <summary>
        /// J/(kg*K) -> J/(kg*°C)
        /// vv: 1 joule/kilogram/K [J/(kg*K)] to 1 joule/kilogram/°C [J/(kg*°C)]
        /// </summary>
        public static double JoulePerKilogramPerK_2_JoulePerKilogramPerZeroDegreeCelsius(double inVal)=> inVal / 1;

        /// <summary>
        /// J/(g*°C) -> J/(kg*K)
        /// 1 joule/gram/°C [J/(g*°C)] =  1000 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double JoulePerGramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)   => inVal * 1000;
        /// <summary>
        /// J/(kg*K) -> J/(g*°C)
        /// vv: 1000 joule/kilogram/K [J/(kg*K)] to 1 joule/gram/°C [J/(g*°C)]
        /// </summary>
        public static double JoulePerKilogramPerK_2_JoulePerGramPerZeroDegreeCelsius(double inVal)   => inVal / 1000;

        /// <summary>
        /// KilojoulePerKilogramPerK -> J/(kg*K)
        /// 1 kilojoule/kilogram/K =  1000 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilojoulePerKilogramPerK_2_JoulePerKilogramPerK(double inVal)=> inVal * 1000;
        /// <summary>
        /// J/(kg*K) -> KilojoulePerKilogramPerK
        /// vv: 1000 joule/kilogram/K [J/(kg*K)] to 1 kilojoule/kilogram/K
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilojoulePerKilogramPerK(double inVal)=> inVal / 1000;

        /// <summary>
        /// KilojoulePerKilogramPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 kilojoule/kilogram/°C =  1000 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilojoulePerKilogramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 1000;
        /// <summary>
        /// J/(kg*K) -> KilojoulePerKilogramPerZeroDegreeCelsius
        /// vv: 1000 joule/kilogram/K [J/(kg*K)] to 1 kilojoule/kilogram/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilojoulePerKilogramPerZeroDegreeCelsius(double inVal)=> inVal / 1000;

        /// <summary>
        /// CalorieITPerGramPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 calorie (IT)/gram/°C =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double CalorieITPerGramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> CalorieITPerGramPerZeroDegreeCelsius
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 calorie (IT)/gram/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_CalorieITPerGramPerZeroDegreeCelsius(double inVal)=> inVal / 4186.8000000087;

        /// <summary>
        /// CalorieITPerGramPerDegF -> J/(kg*K)
        /// 1 calorie (IT)/gram/°F =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double CalorieITPerGramPerDegF_2_JoulePerKilogramPerK(double inVal)=> inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> CalorieITPerGramPerDegF
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 calorie (IT)/gram/°F
        /// </summary>
        public static double JoulePerKilogramPerK_2_CalorieITPerGramPerDegF(double inVal)=> inVal / 4186.8000000087;

        /// <summary>
        /// CalorieThPerGramPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 calorie (th)/gram/°C =  4184 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double CalorieThPerGramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 4184;
        /// <summary>
        /// J/(kg*K) -> CalorieThPerGramPerZeroDegreeCelsius
        /// vv: 4184 joule/kilogram/K [J/(kg*K)] to 1 calorie (th)/gram/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_CalorieThPerGramPerZeroDegreeCelsius(double inVal)=> inVal / 4184;

        /// <summary>
        /// KilocalorieITPerKilogramPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 kilocalorie (IT)/kilogram/°C =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilocalorieITPerKilogramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> KilocalorieITPerKilogramPerZeroDegreeCelsius
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 kilocalorie (IT)/kilogram/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilocalorieITPerKilogramPerZeroDegreeCelsius(double inVal)=> inVal / 4186.8000000087;

        /// <summary>
        /// KilocalorieThPerKilogramPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 kilocalorie (th)/kilogram/°C =  4184 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilocalorieThPerKilogramPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)=> inVal * 4184;
        /// <summary>
        /// J/(kg*K) -> KilocalorieThPerKilogramPerZeroDegreeCelsius
        /// vv: 4184 joule/kilogram/K [J/(kg*K)] to 1 kilocalorie (th)/kilogram/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilocalorieThPerKilogramPerZeroDegreeCelsius(double inVal)=> inVal / 4184;

        /// <summary>
        /// KilocalorieITPerKilogramPerK -> J/(kg*K)
        /// 1 kilocalorie (IT)/kilogram/K =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilocalorieITPerKilogramPerK_2_JoulePerKilogramPerK(double inVal)=> inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> KilocalorieITPerKilogramPerK
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 kilocalorie (IT)/kilogram/K
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilocalorieITPerKilogramPerK(double inVal)=> inVal / 4186.8000000087;

        /// <summary>
        /// KilocalorieThPerKilogramPerK -> J/(kg*K)
        /// 1 kilocalorie (th)/kilogram/K =  4184 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilocalorieThPerKilogramPerK_2_JoulePerKilogramPerK(double inVal)=> inVal * 4184;
        /// <summary>
        /// J/(kg*K) -> KilocalorieThPerKilogramPerK
        /// vv: 4184 joule/kilogram/K [J/(kg*K)] to 1 kilocalorie (th)/kilogram/K
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilocalorieThPerKilogramPerK(double inVal)=> inVal / 4184;

        /// <summary>
        /// KilogramForceMeterPerKilogramPerK -> J/(kg*K)
        /// 1 kilogram-force meter/kilogram/K =  9.80665 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double KilogramForceMeterPerKilogramPerK_2_JoulePerKilogramPerK(double inVal)=> inVal * 9.80665;
        /// <summary>
        /// J/(kg*K) -> KilogramForceMeterPerKilogramPerK
        /// vv: 9.80665 joule/kilogram/K [J/(kg*K)] to 1 kilogram-force meter/kilogram/K
        /// </summary>
        public static double JoulePerKilogramPerK_2_KilogramForceMeterPerKilogramPerK(double inVal)=> inVal / 9.80665;

        /// <summary>
        /// PoundForceFootPerPoundPerDegR -> J/(kg*K)
        /// 1 pound-force foot/pound/°R =  5.380320456 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double PoundForceFootPerPoundPerDegR_2_JoulePerKilogramPerK(double inVal)=> inVal * 5.380320456;
        /// <summary>
        /// J/(kg*K) -> PoundForceFootPerPoundPerDegR
        /// vv: 5.380320456 joule/kilogram/K [J/(kg*K)] to 1 pound-force foot/pound/°R
        /// </summary>
        public static double JoulePerKilogramPerK_2_PoundForceFootPerPoundPerDegR(double inVal)=> inVal / 5.380320456;

        /// <summary>
        /// BtuITPerPoundPerDegF -> J/(kg*K)
        /// 1 Btu (IT)/pound/°F =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double BtuITPerPoundPerDegF_2_JoulePerKilogramPerK(double inVal)  => inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> BtuITPerPoundPerDegF
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 Btu (IT)/pound/°F
        /// </summary>
        public static double JoulePerKilogramPerK_2_BtuITPerPoundPerDegF(double inVal)  => inVal / 4186.8000000087;

        /// <summary>
        /// BtuThPerPoundPerDegF -> J/(kg*K)
        /// 1 Btu (th)/pound/°F =  4184 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double BtuThPerPoundPerDegF_2_JoulePerKilogramPerK(double inVal)  => inVal * 4184;
        /// <summary>
        /// J/(kg*K) -> BtuThPerPoundPerDegF
        /// vv: 4184 joule/kilogram/K [J/(kg*K)] to 1 Btu (th)/pound/°F
        /// </summary>
        public static double JoulePerKilogramPerK_2_BtuThPerPoundPerDegF(double inVal)  => inVal / 4184;

        /// <summary>
        /// BtuITPerPoundPerDegR -> J/(kg*K)
        /// 1 Btu (IT)/pound/°R =  4186.8000000087 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double BtuITPerPoundPerDegR_2_JoulePerKilogramPerK(double inVal)  => inVal * 4186.8000000087;
        /// <summary>
        /// J/(kg*K) -> BtuITPerPoundPerDegR
        /// vv: 4186.8000000087 joule/kilogram/K [J/(kg*K)] to 1 Btu (IT)/pound/°R
        /// </summary>
        public static double JoulePerKilogramPerK_2_BtuITPerPoundPerDegR(double inVal)  => inVal / 4186.8000000087;

        /// <summary>
        /// BtuThPerPoundPerDegR -> J/(kg*K)
        /// 1 Btu (th)/pound/°R =  4184 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double BtuThPerPoundPerDegR_2_JoulePerKilogramPerK(double inVal)  => inVal * 4184;
        /// <summary>
        /// J/(kg*K) -> BtuThPerPoundPerDegR
        /// vv: 4184 joule/kilogram/K [J/(kg*K)] to 1 Btu (th)/pound/°R
        /// </summary>
        public static double JoulePerKilogramPerK_2_BtuThPerPoundPerDegR(double inVal)  => inVal / 4184;

        /// <summary>
        /// BtuITPerPoundPerZeroDegreeCelsius -> J/(kg*K)
        /// 1 Btu (IT)/pound/°C =  2326.0000001596 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double BtuITPerPoundPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)  => inVal * 2326.0000001596;
        /// <summary>
        /// J/(kg*K) -> BtuITPerPoundPerZeroDegreeCelsius
        /// vv: 2326.0000001596 joule/kilogram/K [J/(kg*K)] to 1 Btu (IT)/pound/°C
        /// </summary>
        public static double JoulePerKilogramPerK_2_BtuITPerPoundPerZeroDegreeCelsius(double inVal)  => inVal / 2326.0000001596;

        /// <summary>
        /// CHU/(lb*°C) -> J/(kg*K)
        /// 1 CHU/pound/°C [CHU/(lb*°C)] =  4186.800000482 joule/kilogram/K [J/(kg*K)]
        /// </summary>
        public static double CHUPerPoundPerZeroDegreeCelsius_2_JoulePerKilogramPerK(double inVal)    => inVal * 4186.800000482;
        /// <summary>
        /// J/(kg*K) -> CHU/(lb*°C)
        /// vv: 4186.800000482 joule/kilogram/K [J/(kg*K)] to 1 CHU/pound/°C [CHU/(lb*°C)]
        /// </summary>
        public static double JoulePerKilogramPerK_2_CHUPerPoundPerZeroDegreeCelsius(double inVal)    => inVal / 4186.800000482;

        #endregion

        #region heat density, base: joule/square meter

        /// <summary>
        /// CalorieThPerSquareCentimeter -> J/m^2
        /// 1 calorie (th)/square centimeter =  41839.999999999 joule/square meter [J/m^2]
        /// </summary>
        public static double CalorieThPerSquareCentimeter_2_JoulePerSquareMeter(double inVal)=> inVal * 41839.999999999;
        /// <summary>
        /// J/m^2 -> CalorieThPerSquareCentimeter
        /// vv: 41839.999999999 joule/square meter [J/m^2] to 1 calorie (th)/square centimeter
        /// </summary>
        public static double JoulePerSquareMeter_2_CalorieThPerSquareCentimeter(double inVal)=> inVal / 41839.999999999;

        /// <summary>
        /// Langley -> J/m^2
        /// 1 langley =  41839.999999999 joule/square meter [J/m^2]
        /// </summary>
        public static double Langley_2_JoulePerSquareMeter(double inVal)                => inVal * 41839.999999999;
        /// <summary>
        /// J/m^2 -> Langley
        /// vv: 41839.999999999 joule/square meter [J/m^2] to 1 langley
        /// </summary>
        public static double JoulePerSquareMeter_2_Langley(double inVal)                => inVal / 41839.999999999;

        /// <summary>
        /// BtuITPerSquareFoot -> J/m^2
        /// 1 Btu (IT)/square foot =  11356.526682227 joule/square meter [J/m^2]
        /// </summary>
        public static double BtuITPerSquareFoot_2_JoulePerSquareMeter(double inVal)     => inVal * 11356.526682227;
        /// <summary>
        /// J/m^2 -> BtuITPerSquareFoot
        /// vv: 11356.526682227 joule/square meter [J/m^2] to 1 Btu (IT)/square foot
        /// </summary>
        public static double JoulePerSquareMeter_2_BtuITPerSquareFoot(double inVal)     => inVal / 11356.526682227;

        /// <summary>
        /// BtuThPerSquareFoot -> J/m^2
        /// 1 Btu (th)/square foot =  11348.931794793 joule/square meter [J/m^2]
        /// </summary>
        public static double BtuThPerSquareFoot_2_JoulePerSquareMeter(double inVal)     => inVal * 11348.931794793;
        /// <summary>
        /// J/m^2 -> BtuThPerSquareFoot
        /// vv: 11348.931794793 joule/square meter [J/m^2] to 1 Btu (th)/square foot
        /// </summary>
        public static double JoulePerSquareMeter_2_BtuThPerSquareFoot(double inVal)     => inVal / 11348.931794793;

        #endregion

        #region heat flux density, base: watt/square meter

        /// <summary>
        /// KilowattPerSquareMeter -> W/m^2
        /// 1 kilowatt/square meter =  1000 watt/square meter [W/m^2]
        /// </summary>
        public static double KilowattPerSquareMeter_2_WattPerSquareMeter(double inVal)  => inVal * 1000;
        /// <summary>
        /// W/m^2 -> KilowattPerSquareMeter
        /// vv: 1000 watt/square meter [W/m^2] to 1 kilowatt/square meter
        /// </summary>
        public static double WattPerSquareMeter_2_KilowattPerSquareMeter(double inVal)  => inVal / 1000;

        /// <summary>
        /// WattPerSquareCentimeter -> W/m^2
        /// 1 watt/square centimeter =  10000 watt/square meter [W/m^2]
        /// </summary>
        public static double WattPerSquareCentimeter_2_WattPerSquareMeter(double inVal) => inVal * 10000;
        /// <summary>
        /// W/m^2 -> WattPerSquareCentimeter
        /// vv: 10000 watt/square meter [W/m^2] to 1 watt/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_WattPerSquareCentimeter(double inVal) => inVal / 10000;

        /// <summary>
        /// W/in^2 -> W/m^2
        /// 1 watt/square inch [W/in^2] =  1550.0031012075 watt/square meter [W/m^2]
        /// </summary>
        public static double WattPerSquareInch_2_WattPerSquareMeter(double inVal)       => inVal * 1550.0031012075;
        /// <summary>
        /// W/m^2 -> W/in^2
        /// vv: 1550.0031012075 watt/square meter [W/m^2] to 1 watt/square inch [W/in^2]
        /// </summary>
        public static double WattPerSquareMeter_2_WattPerSquareInch(double inVal)       => inVal / 1550.0031012075;

        /// <summary>
        /// JoulePerSecondPerSquareMeter -> W/m^2
        /// 1 joule/second/square meter =  1 watt/square meter [W/m^2]
        /// </summary>
        public static double JoulePerSecondPerSquareMeter_2_WattPerSquareMeter(double inVal)=> inVal * 1;
        /// <summary>
        /// W/m^2 -> JoulePerSecondPerSquareMeter
        /// vv: 1 watt/square meter [W/m^2] to 1 joule/second/square meter
        /// </summary>
        public static double WattPerSquareMeter_2_JoulePerSecondPerSquareMeter(double inVal)=> inVal / 1;

        /// <summary>
        /// KilocalorieITPerHourPerSquareMeter -> W/m^2
        /// 1 kilocalorie (IT)/hour/square meter =  1.1629999999 watt/square meter [W/m^2]
        /// </summary>
        public static double KilocalorieITPerHourPerSquareMeter_2_WattPerSquareMeter(double inVal)=> inVal * 1.1629999999;
        /// <summary>
        /// W/m^2 -> KilocalorieITPerHourPerSquareMeter
        /// vv: 1.1629999999 watt/square meter [W/m^2] to 1 kilocalorie (IT)/hour/square meter
        /// </summary>
        public static double WattPerSquareMeter_2_KilocalorieITPerHourPerSquareMeter(double inVal)=> inVal / 1.1629999999;

        /// <summary>
        /// KilocalorieITPerHourPerSquareFoot -> W/m^2
        /// 1 kilocalorie (IT)/hour/square foot =  12.5184278205 watt/square meter [W/m^2]
        /// </summary>
        public static double KilocalorieITPerHourPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 12.5184278205;
        /// <summary>
        /// W/m^2 -> KilocalorieITPerHourPerSquareFoot
        /// vv: 12.5184278205 watt/square meter [W/m^2] to 1 kilocalorie (IT)/hour/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_KilocalorieITPerHourPerSquareFoot(double inVal)=> inVal / 12.5184278205;

        /// <summary>
        /// CalorieITPerSecondPerSquareCentimeter -> W/m^2
        /// 1 calorie (IT)/second/square centimeter =  41868.00000482 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieITPerSecondPerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 41868.00000482;
        /// <summary>
        /// W/m^2 -> CalorieITPerSecondPerSquareCentimeter
        /// vv: 41868.00000482 watt/square meter [W/m^2] to 1 calorie (IT)/second/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieITPerSecondPerSquareCentimeter(double inVal)=> inVal / 41868.00000482;

        /// <summary>
        /// CalorieITPerMinutePerSquareCentimeter -> W/m^2
        /// 1 calorie (IT)/minute/square centimeter =  697.8000000803 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieITPerMinutePerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 697.8000000803;
        /// <summary>
        /// W/m^2 -> CalorieITPerMinutePerSquareCentimeter
        /// vv: 697.8000000803 watt/square meter [W/m^2] to 1 calorie (IT)/minute/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieITPerMinutePerSquareCentimeter(double inVal)=> inVal / 697.8000000803;

        /// <summary>
        /// CalorieITPerHourPerSquareCentimeter -> W/m^2
        /// 1 calorie (IT)/hour/square centimeter =  11.6300000008 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieITPerHourPerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 11.6300000008;
        /// <summary>
        /// W/m^2 -> CalorieITPerHourPerSquareCentimeter
        /// vv: 11.6300000008 watt/square meter [W/m^2] to 1 calorie (IT)/hour/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieITPerHourPerSquareCentimeter(double inVal)=> inVal / 11.6300000008;

        /// <summary>
        /// CalorieThPerSecondPerSquareCentimeter -> W/m^2
        /// 1 calorie (th)/second/square centimeter =  41839.999999942 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieThPerSecondPerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 41839.999999942;
        /// <summary>
        /// W/m^2 -> CalorieThPerSecondPerSquareCentimeter
        /// vv: 41839.999999942 watt/square meter [W/m^2] to 1 calorie (th)/second/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieThPerSecondPerSquareCentimeter(double inVal)=> inVal / 41839.999999942;

        /// <summary>
        /// CalorieThPerMinutePerSquareCentimeter -> W/m^2
        /// 1 calorie (th)/minute/square centimeter =  697.3333333314 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieThPerMinutePerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 697.3333333314;
        /// <summary>
        /// W/m^2 -> CalorieThPerMinutePerSquareCentimeter
        /// vv: 697.3333333314 watt/square meter [W/m^2] to 1 calorie (th)/minute/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieThPerMinutePerSquareCentimeter(double inVal)=> inVal / 697.3333333314;

        /// <summary>
        /// CalorieThPerHourPerSquareCentimeter -> W/m^2
        /// 1 calorie (th)/hour/square centimeter =  11.6222222222 watt/square meter [W/m^2]
        /// </summary>
        public static double CalorieThPerHourPerSquareCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 11.6222222222;
        /// <summary>
        /// W/m^2 -> CalorieThPerHourPerSquareCentimeter
        /// vv: 11.6222222222 watt/square meter [W/m^2] to 1 calorie (th)/hour/square centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_CalorieThPerHourPerSquareCentimeter(double inVal)=> inVal / 11.6222222222;

        /// <summary>
        /// DynePerHourPerCentimeter -> W/m^2
        /// 1 dyne/hour/centimeter =  2.7777777777778E-7 watt/square meter [W/m^2]
        /// </summary>
        public static double DynePerHourPerCentimeter_2_WattPerSquareMeter(double inVal)=> inVal * 2.7777777777778E-7;
        /// <summary>
        /// W/m^2 -> DynePerHourPerCentimeter
        /// vv: 2.7777777777778E-7 watt/square meter [W/m^2] to 1 dyne/hour/centimeter
        /// </summary>
        public static double WattPerSquareMeter_2_DynePerHourPerCentimeter(double inVal)=> inVal / 2.7777777777778E-7;

        /// <summary>
        /// ErgPerHourPerSquareMillimeter -> W/m^2
        /// 1 erg/hour/square millimeter =  2.77778E-5 watt/square meter [W/m^2]
        /// </summary>
        public static double ErgPerHourPerSquareMillimeter_2_WattPerSquareMeter(double inVal)=> inVal * 2.77778E-5;
        /// <summary>
        /// W/m^2 -> ErgPerHourPerSquareMillimeter
        /// vv: 2.77778E-5 watt/square meter [W/m^2] to 1 erg/hour/square millimeter
        /// </summary>
        public static double WattPerSquareMeter_2_ErgPerHourPerSquareMillimeter(double inVal)=> inVal / 2.77778E-5;

        /// <summary>
        /// FootPoundPerMinutePerSquareFoot -> W/m^2
        /// 1 foot pound/minute/square foot =  0.2432317156 watt/square meter [W/m^2]
        /// </summary>
        public static double FootPoundPerMinutePerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 0.2432317156;
        /// <summary>
        /// W/m^2 -> FootPoundPerMinutePerSquareFoot
        /// vv: 0.2432317156 watt/square meter [W/m^2] to 1 foot pound/minute/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_FootPoundPerMinutePerSquareFoot(double inVal)=> inVal / 0.2432317156;

        /// <summary>
        /// HorsepowerPerSquareFoot -> W/m^2
        /// 1 horsepower/square foot =  8026.6466174305 watt/square meter [W/m^2]
        /// </summary>
        public static double HorsepowerPerSquareFoot_2_WattPerSquareMeter(double inVal) => inVal * 8026.6466174305;
        /// <summary>
        /// W/m^2 -> HorsepowerPerSquareFoot
        /// vv: 8026.6466174305 watt/square meter [W/m^2] to 1 horsepower/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_HorsepowerPerSquareFoot(double inVal) => inVal / 8026.6466174305;

        /// <summary>
        /// HorsepowerMetricPerSquareFoot -> W/m^2
        /// 1 horsepower (metric)/square foot =  7916.8426564296 watt/square meter [W/m^2]
        /// </summary>
        public static double HorsepowerMetricPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 7916.8426564296;
        /// <summary>
        /// W/m^2 -> HorsepowerMetricPerSquareFoot
        /// vv: 7916.8426564296 watt/square meter [W/m^2] to 1 horsepower (metric)/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_HorsepowerMetricPerSquareFoot(double inVal)=> inVal / 7916.8426564296;

        /// <summary>
        /// BtuITPerSecondPerSquareFoot -> W/m^2
        /// 1 Btu (IT)/second/square foot =  11356.526682221 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuITPerSecondPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 11356.526682221;
        /// <summary>
        /// W/m^2 -> BtuITPerSecondPerSquareFoot
        /// vv: 11356.526682221 watt/square meter [W/m^2] to 1 Btu (IT)/second/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuITPerSecondPerSquareFoot(double inVal)=> inVal / 11356.526682221;

        /// <summary>
        /// BtuITPerMinutePerSquareFoot -> W/m^2
        /// 1 Btu (IT)/minute/square foot =  189.2754465477 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuITPerMinutePerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 189.2754465477;
        /// <summary>
        /// W/m^2 -> BtuITPerMinutePerSquareFoot
        /// vv: 189.2754465477 watt/square meter [W/m^2] to 1 Btu (IT)/minute/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuITPerMinutePerSquareFoot(double inVal)=> inVal / 189.2754465477;

        /// <summary>
        /// BtuITPerHourPerSquareFoot -> W/m^2
        /// 1 Btu (IT)/hour/square foot =  3.1545907451 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuITPerHourPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 3.1545907451;
        /// <summary>
        /// W/m^2 -> BtuITPerHourPerSquareFoot
        /// vv: 3.1545907451 watt/square meter [W/m^2] to 1 Btu (IT)/hour/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuITPerHourPerSquareFoot(double inVal)=> inVal / 3.1545907451;

        /// <summary>
        /// BtuThPerSecondPerSquareInch -> W/m^2
        /// 1 Btu (th)/second/square inch =  1634246.1784508 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuThPerSecondPerSquareInch_2_WattPerSquareMeter(double inVal)=> inVal * 1634246.1784508;
        /// <summary>
        /// W/m^2 -> BtuThPerSecondPerSquareInch
        /// vv: 1634246.1784508 watt/square meter [W/m^2] to 1 Btu (th)/second/square inch
        /// </summary>
        public static double WattPerSquareMeter_2_BtuThPerSecondPerSquareInch(double inVal)=> inVal / 1634246.1784508;

        /// <summary>
        /// BtuThPerSecondPerSquareFoot -> W/m^2
        /// 1 Btu (th)/second/square foot =  11348.93179479 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuThPerSecondPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 11348.93179479;
        /// <summary>
        /// W/m^2 -> BtuThPerSecondPerSquareFoot
        /// vv: 11348.93179479 watt/square meter [W/m^2] to 1 Btu (th)/second/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuThPerSecondPerSquareFoot(double inVal)=> inVal / 11348.93179479;

        /// <summary>
        /// BtuThPerMinutePerSquareFoot -> W/m^2
        /// 1 Btu (th)/minute/square foot =  189.1488632466 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuThPerMinutePerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 189.1488632466;
        /// <summary>
        /// W/m^2 -> BtuThPerMinutePerSquareFoot
        /// vv: 189.1488632466 watt/square meter [W/m^2] to 1 Btu (th)/minute/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuThPerMinutePerSquareFoot(double inVal)=> inVal / 189.1488632466;

        /// <summary>
        /// BtuThPerHourPerSquareFoot -> W/m^2
        /// 1 Btu (th)/hour/square foot =  3.1524810541 watt/square meter [W/m^2]
        /// </summary>
        public static double BtuThPerHourPerSquareFoot_2_WattPerSquareMeter(double inVal)=> inVal * 3.1524810541;
        /// <summary>
        /// W/m^2 -> BtuThPerHourPerSquareFoot
        /// vv: 3.1524810541 watt/square meter [W/m^2] to 1 Btu (th)/hour/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_BtuThPerHourPerSquareFoot(double inVal)=> inVal / 3.1524810541;

        /// <summary>
        /// CHUPerHourPerSquareFoot -> W/m^2
        /// 1 CHU/hour/square foot =  5.6782633986 watt/square meter [W/m^2]
        /// </summary>
        public static double CHUPerHourPerSquareFoot_2_WattPerSquareMeter(double inVal) => inVal * 5.6782633986;
        /// <summary>
        /// W/m^2 -> CHUPerHourPerSquareFoot
        /// vv: 5.6782633986 watt/square meter [W/m^2] to 1 CHU/hour/square foot
        /// </summary>
        public static double WattPerSquareMeter_2_CHUPerHourPerSquareFoot(double inVal) => inVal / 5.6782633986;

        #endregion

        #region heat flux density, base: watt/square meter/K

        /// <summary>
        /// WattPerSquareMeterPerPerZeroDegreeCelsius -> WattPerSquareMeterPerK
        /// 1 watt/square meter/PerZeroDegreeCelsius =  1 watt/square meter/K
        /// </summary>
        public static double WattPerSquareMeterPerPerZeroDegreeCelsius_2_WattPerSquareMeterPerK(double inVal)=> inVal * 1;
        /// <summary>
        /// WattPerSquareMeterPerK -> WattPerSquareMeterPerPerZeroDegreeCelsius
        /// vv: 1 watt/square meter/K to 1 watt/square meter/PerZeroDegreeCelsius
        /// </summary>
        public static double WattPerSquareMeterPerK_2_WattPerSquareMeterPerPerZeroDegreeCelsius(double inVal)=> inVal / 1;

        /// <summary>
        /// JoulePerSecondPerSquareMeterPerK -> WattPerSquareMeterPerK
        /// 1 joule/second/square meter/K =  1 watt/square meter/K
        /// </summary>
        public static double JoulePerSecondPerSquareMeterPerK_2_WattPerSquareMeterPerK(double inVal)=> inVal * 1;
        /// <summary>
        /// WattPerSquareMeterPerK -> JoulePerSecondPerSquareMeterPerK
        /// vv: 1 watt/square meter/K to 1 joule/second/square meter/K
        /// </summary>
        public static double WattPerSquareMeterPerK_2_JoulePerSecondPerSquareMeterPerK(double inVal)=> inVal / 1;

        /// <summary>
        /// CalorieITPerSecondPerSquareCentimeterPerPerZeroDegreeCelsius -> WattPerSquareMeterPerK
        /// 1 calorie (IT)/second/square centimeter/PerZeroDegreeCelsius =  41868.00000482 watt/square meter/K
        /// </summary>
        public static double CalorieITPerSecondPerSquareCentimeterPerPerZeroDegreeCelsius_2_WattPerSquareMeterPerK(double inVal)=> inVal * 41868.00000482;
        /// <summary>
        /// WattPerSquareMeterPerK -> CalorieITPerSecondPerSquareCentimeterPerPerZeroDegreeCelsius
        /// vv: 41868.00000482 watt/square meter/K to 1 calorie (IT)/second/square centimeter/PerZeroDegreeCelsius
        /// </summary>
        public static double WattPerSquareMeterPerK_2_CalorieITPerSecondPerSquareCentimeterPerPerZeroDegreeCelsius(double inVal)=> inVal / 41868.00000482;

        /// <summary>
        /// KilocalorieITPerHourPerSquareMeterPerPerZeroDegreeCelsius -> WattPerSquareMeterPerK
        /// 1 kilocalorie (IT)/hour/square meter/PerZeroDegreeCelsius =  1.163 watt/square meter/K
        /// </summary>
        public static double KilocalorieITPerHourPerSquareMeterPerPerZeroDegreeCelsius_2_WattPerSquareMeterPerK(double inVal)=> inVal * 1.163;
        /// <summary>
        /// WattPerSquareMeterPerK -> KilocalorieITPerHourPerSquareMeterPerPerZeroDegreeCelsius
        /// vv: 1.163 watt/square meter/K to 1 kilocalorie (IT)/hour/square meter/PerZeroDegreeCelsius
        /// </summary>
        public static double WattPerSquareMeterPerK_2_KilocalorieITPerHourPerSquareMeterPerPerZeroDegreeCelsius(double inVal)=> inVal / 1.163;

        /// <summary>
        /// KilocalorieITPerHourPerSquareFootPerPerZeroDegreeCelsius -> WattPerSquareMeterPerK
        /// 1 kilocalorie (IT)/hour/square foot/PerZeroDegreeCelsius =  12.5184278205 watt/square meter/K
        /// </summary>
        public static double KilocalorieITPerHourPerSquareFootPerPerZeroDegreeCelsius_2_WattPerSquareMeterPerK(double inVal)=> inVal * 12.5184278205;
        /// <summary>
        /// WattPerSquareMeterPerK -> KilocalorieITPerHourPerSquareFootPerPerZeroDegreeCelsius
        /// vv: 12.5184278205 watt/square meter/K to 1 kilocalorie (IT)/hour/square foot/PerZeroDegreeCelsius
        /// </summary>
        public static double WattPerSquareMeterPerK_2_KilocalorieITPerHourPerSquareFootPerPerZeroDegreeCelsius(double inVal)=> inVal / 12.5184278205;

        /// <summary>
        /// BtuITPerSecondPerSquareFootPerZeroDegreeFahrenheit -> WattPerSquareMeterPerK
        /// 1 Btu (IT)/second/square foot/%b0F =  20441.748028012 watt/square meter/K
        /// </summary>
        public static double BtuITPerSecondPerSquareFootPerZeroDegreeFahrenheit_2_WattPerSquareMeterPerK(double inVal)=> inVal * 20441.748028012;
        /// <summary>
        /// WattPerSquareMeterPerK -> BtuITPerSecondPerSquareFootPerZeroDegreeFahrenheit
        /// vv: 20441.748028012 watt/square meter/K to 1 Btu (IT)/second/square foot/%b0F
        /// </summary>
        public static double WattPerSquareMeterPerK_2_BtuITPerSecondPerSquareFootPerZeroDegreeFahrenheit(double inVal)=> inVal / 20441.748028012;

        /// <summary>
        /// BtuThPerSecondPerSquareFootPerZeroDegreeFahrenheit -> WattPerSquareMeterPerK
        /// 1 Btu (th)/second/square foot/%b0F =  20428.077230618 watt/square meter/K
        /// </summary>
        public static double BtuThPerSecondPerSquareFootPerZeroDegreeFahrenheit_2_WattPerSquareMeterPerK(double inVal)=> inVal * 20428.077230618;
        /// <summary>
        /// WattPerSquareMeterPerK -> BtuThPerSecondPerSquareFootPerZeroDegreeFahrenheit
        /// vv: 20428.077230618 watt/square meter/K to 1 Btu (th)/second/square foot/%b0F
        /// </summary>
        public static double WattPerSquareMeterPerK_2_BtuThPerSecondPerSquareFootPerZeroDegreeFahrenheit(double inVal)=> inVal / 20428.077230618;

        /// <summary>
        /// BtuITPerHourPerSquareFootPerZeroDegreeFahrenheit -> WattPerSquareMeterPerK
        /// 1 Btu (IT)/hour/square foot/%b0F =  5.6782633411 watt/square meter/K
        /// </summary>
        public static double BtuITPerHourPerSquareFootPerZeroDegreeFahrenheit_2_WattPerSquareMeterPerK(double inVal)=> inVal * 5.6782633411;
        /// <summary>
        /// WattPerSquareMeterPerK -> BtuITPerHourPerSquareFootPerZeroDegreeFahrenheit
        /// vv: 5.6782633411 watt/square meter/K to 1 Btu (IT)/hour/square foot/%b0F
        /// </summary>
        public static double WattPerSquareMeterPerK_2_BtuITPerHourPerSquareFootPerZeroDegreeFahrenheit(double inVal)=> inVal / 5.6782633411;

        /// <summary>
        /// BtuThPerHourPerSquareFootPerZeroDegreeFahrenheit -> WattPerSquareMeterPerK
        /// 1 Btu (th)/hour/square foot/%b0F =  5.6744658974 watt/square meter/K
        /// </summary>
        public static double BtuThPerHourPerSquareFootPerZeroDegreeFahrenheit_2_WattPerSquareMeterPerK(double inVal)=> inVal * 5.6744658974;
        /// <summary>
        /// WattPerSquareMeterPerK -> BtuThPerHourPerSquareFootPerZeroDegreeFahrenheit
        /// vv: 5.6744658974 watt/square meter/K to 1 Btu (th)/hour/square foot/%b0F
        /// </summary>
        public static double WattPerSquareMeterPerK_2_BtuThPerHourPerSquareFootPerZeroDegreeFahrenheit(double inVal)=> inVal / 5.6744658974;

        /// <summary>
        /// CHUPerHourPerSquareFootPerPerZeroDegreeCelsius -> WattPerSquareMeterPerK
        /// 1 CHU/hour/square foot/PerZeroDegreeCelsius =  5.6782633411 watt/square meter/K
        /// </summary>
        public static double CHUPerHourPerSquareFootPerPerZeroDegreeCelsius_2_WattPerSquareMeterPerK(double inVal)=> inVal * 5.6782633411;
        /// <summary>
        /// WattPerSquareMeterPerK -> CHUPerHourPerSquareFootPerPerZeroDegreeCelsius
        /// vv: 5.6782633411 watt/square meter/K to 1 CHU/hour/square foot/PerZeroDegreeCelsius
        /// </summary>
        public static double WattPerSquareMeterPerK_2_CHUPerHourPerSquareFootPerPerZeroDegreeCelsius(double inVal)=> inVal / 5.6782633411;

        #endregion

    }
}
