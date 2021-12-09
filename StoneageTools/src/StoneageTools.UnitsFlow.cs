
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region fluids flow, base: cubic meter/second

        /// <summary>
        /// m^3/d -> m^3/s
        /// 1 cubic meter/day [m^3/d] =  1.15741E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicMeterPerDay_2_CubicMeterPerSecond(double inVal)       => inVal * 1.15741E-5;
        /// <summary>
        /// m^3/s -> m^3/d
        /// vv: 1.15741E-5 cubic meter/second [m^3/s] to 1 cubic meter/day [m^3/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicMeterPerDay(double inVal)       => inVal / 1.15741E-5;

        /// <summary>
        /// m^3/h -> m^3/s
        /// 1 cubic meter/hour [m^3/h] =  0.0002777778 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicMeterPerHour_2_CubicMeterPerSecond(double inVal)      => inVal * 0.0002777778;
        /// <summary>
        /// m^3/s -> m^3/h
        /// vv: 0.0002777778 cubic meter/second [m^3/s] to 1 cubic meter/hour [m^3/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicMeterPerHour(double inVal)      => inVal / 0.0002777778;

        /// <summary>
        /// CubicMeterPerMinute -> m^3/s
        /// 1 cubic meter/minute =  0.0166666667 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicMeterPerMinute_2_CubicMeterPerSecond(double inVal)    => inVal * 0.0166666667;
        /// <summary>
        /// m^3/s -> CubicMeterPerMinute
        /// vv: 0.0166666667 cubic meter/second [m^3/s] to 1 cubic meter/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicMeterPerMinute(double inVal)    => inVal / 0.0166666667;

        /// <summary>
        /// CubicCentimeterPerDay -> m^3/s
        /// 1 cubic centimeter/day =  1.1574074074074E-11 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicCentimeterPerDay_2_CubicMeterPerSecond(double inVal)  => inVal * 1.1574074074074E-11;
        /// <summary>
        /// m^3/s -> CubicCentimeterPerDay
        /// vv: 1.1574074074074E-11 cubic meter/second [m^3/s] to 1 cubic centimeter/day
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicCentimeterPerDay(double inVal)  => inVal / 1.1574074074074E-11;

        /// <summary>
        /// CubicCentimeterPerHour -> m^3/s
        /// 1 cubic centimeter/hour =  2.7777777777778E-10 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicCentimeterPerHour_2_CubicMeterPerSecond(double inVal) => inVal * 2.7777777777778E-10;
        /// <summary>
        /// m^3/s -> CubicCentimeterPerHour
        /// vv: 2.7777777777778E-10 cubic meter/second [m^3/s] to 1 cubic centimeter/hour
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicCentimeterPerHour(double inVal) => inVal / 2.7777777777778E-10;

        /// <summary>
        /// CubicCentimeterPerMinute -> m^3/s
        /// 1 cubic centimeter/minute =  1.6666666666667E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicCentimeterPerMinute_2_CubicMeterPerSecond(double inVal)=> inVal * 1.6666666666667E-8;
        /// <summary>
        /// m^3/s -> CubicCentimeterPerMinute
        /// vv: 1.6666666666667E-8 cubic meter/second [m^3/s] to 1 cubic centimeter/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicCentimeterPerMinute(double inVal)=> inVal / 1.6666666666667E-8;

        /// <summary>
        /// CubicCentimeterPerSecond -> m^3/s
        /// 1 cubic centimeter/second =  1.0E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicCentimeterPerSecond_2_CubicMeterPerSecond(double inVal)=> inVal * 1.0E-6;
        /// <summary>
        /// m^3/s -> CubicCentimeterPerSecond
        /// vv: 1.0E-6 cubic meter/second [m^3/s] to 1 cubic centimeter/second
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicCentimeterPerSecond(double inVal)=> inVal / 1.0E-6;

        /// <summary>
        /// L/d -> m^3/s
        /// 1 liter/day [L/d] =  1.1574074074074E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double LiterPerDay_2_CubicMeterPerSecond(double inVal)            => inVal * 1.1574074074074E-8;
        /// <summary>
        /// m^3/s -> L/d
        /// vv: 1.1574074074074E-8 cubic meter/second [m^3/s] to 1 liter/day [L/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_LiterPerDay(double inVal)            => inVal / 1.1574074074074E-8;

        /// <summary>
        /// L/h -> m^3/s
        /// 1 liter/hour [L/h] =  2.7777777777778E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double LiterPerHour_2_CubicMeterPerSecond(double inVal)           => inVal * 2.7777777777778E-7;
        /// <summary>
        /// m^3/s -> L/h
        /// vv: 2.7777777777778E-7 cubic meter/second [m^3/s] to 1 liter/hour [L/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_LiterPerHour(double inVal)           => inVal / 2.7777777777778E-7;

        /// <summary>
        /// L/min -> m^3/s
        /// 1 liter/minute [L/min] =  1.66667E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double LiterPerMinute_2_CubicMeterPerSecond(double inVal)         => inVal * 1.66667E-5;
        /// <summary>
        /// m^3/s -> L/min
        /// vv: 1.66667E-5 cubic meter/second [m^3/s] to 1 liter/minute [L/min]
        /// </summary>
        public static double CubicMeterPerSecond_2_LiterPerMinute(double inVal)         => inVal / 1.66667E-5;

        /// <summary>
        /// L/s -> m^3/s
        /// 1 liter/second [L/s] =  0.001 cubic meter/second [m^3/s]
        /// </summary>
        public static double LiterPerSecond_2_CubicMeterPerSecond(double inVal)         => inVal * 0.001;
        /// <summary>
        /// m^3/s -> L/s
        /// vv: 0.001 cubic meter/second [m^3/s] to 1 liter/second [L/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_LiterPerSecond(double inVal)         => inVal / 0.001;

        /// <summary>
        /// mL/d -> m^3/s
        /// 1 milliliter/day [mL/d] =  1.1574074074074E-11 cubic meter/second [m^3/s]
        /// </summary>
        public static double MilliliterPerDay_2_CubicMeterPerSecond(double inVal)       => inVal * 1.1574074074074E-11;
        /// <summary>
        /// m^3/s -> mL/d
        /// vv: 1.1574074074074E-11 cubic meter/second [m^3/s] to 1 milliliter/day [mL/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_MilliliterPerDay(double inVal)       => inVal / 1.1574074074074E-11;

        /// <summary>
        /// mL/h -> m^3/s
        /// 1 milliliter/hour [mL/h] =  2.7777777777778E-10 cubic meter/second [m^3/s]
        /// </summary>
        public static double MilliliterPerHour_2_CubicMeterPerSecond(double inVal)      => inVal * 2.7777777777778E-10;
        /// <summary>
        /// m^3/s -> mL/h
        /// vv: 2.7777777777778E-10 cubic meter/second [m^3/s] to 1 milliliter/hour [mL/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_MilliliterPerHour(double inVal)      => inVal / 2.7777777777778E-10;

        /// <summary>
        /// mL/min -> m^3/s
        /// 1 milliliter/minute [mL/min] =  1.6666666666667E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double MilliliterPerMinute_2_CubicMeterPerSecond(double inVal)    => inVal * 1.6666666666667E-8;
        /// <summary>
        /// m^3/s -> mL/min
        /// vv: 1.6666666666667E-8 cubic meter/second [m^3/s] to 1 milliliter/minute [mL/min]
        /// </summary>
        public static double CubicMeterPerSecond_2_MilliliterPerMinute(double inVal)    => inVal / 1.6666666666667E-8;

        /// <summary>
        /// mL/s -> m^3/s
        /// 1 milliliter/second [mL/s] =  1.0E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double MilliliterPerSecond_2_CubicMeterPerSecond(double inVal)    => inVal * 1.0E-6;
        /// <summary>
        /// m^3/s -> mL/s
        /// vv: 1.0E-6 cubic meter/second [m^3/s] to 1 milliliter/second [mL/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_MilliliterPerSecond(double inVal)    => inVal / 1.0E-6;

        /// <summary>
        /// gal (US)/d -> m^3/s
        /// 1 gallon (US)/day [gal (US)/d] =  4.3812636388889E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUSPerDay_2_CubicMeterPerSecond(double inVal)         => inVal * 4.3812636388889E-8;
        /// <summary>
        /// m^3/s -> gal (US)/d
        /// vv: 4.3812636388889E-8 cubic meter/second [m^3/s] to 1 gallon (US)/day [gal (US)/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUSPerDay(double inVal)         => inVal / 4.3812636388889E-8;

        /// <summary>
        /// gal (US)/h -> m^3/s
        /// 1 gallon (US)/hour [gal (US)/h] =  1.0515032733333E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUSPerHour_2_CubicMeterPerSecond(double inVal)        => inVal * 1.0515032733333E-6;
        /// <summary>
        /// m^3/s -> gal (US)/h
        /// vv: 1.0515032733333E-6 cubic meter/second [m^3/s] to 1 gallon (US)/hour [gal (US)/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUSPerHour(double inVal)        => inVal / 1.0515032733333E-6;

        /// <summary>
        /// GallonUSPerMinute -> m^3/s
        /// 1 gallon (US)/minute =  6.30902E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUSPerMinute_2_CubicMeterPerSecond(double inVal)      => inVal * 6.30902E-5;
        /// <summary>
        /// m^3/s -> GallonUSPerMinute
        /// vv: 6.30902E-5 cubic meter/second [m^3/s] to 1 gallon (US)/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUSPerMinute(double inVal)      => inVal / 6.30902E-5;

        /// <summary>
        /// GallonUSPerSecond -> m^3/s
        /// 1 gallon (US)/second =  0.0037854118 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUSPerSecond_2_CubicMeterPerSecond(double inVal)      => inVal * 0.0037854118;
        /// <summary>
        /// m^3/s -> GallonUSPerSecond
        /// vv: 0.0037854118 cubic meter/second [m^3/s] to 1 gallon (US)/second
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUSPerSecond(double inVal)      => inVal / 0.0037854118;

        /// <summary>
        /// gal (UK)/d -> m^3/s
        /// 1 gallon (UK)/day [gal (UK)/d] =  5.2616782407407E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUKPerDay_2_CubicMeterPerSecond(double inVal)         => inVal * 5.2616782407407E-8;
        /// <summary>
        /// m^3/s -> gal (UK)/d
        /// vv: 5.2616782407407E-8 cubic meter/second [m^3/s] to 1 gallon (UK)/day [gal (UK)/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUKPerDay(double inVal)         => inVal / 5.2616782407407E-8;

        /// <summary>
        /// gal (UK)/h -> m^3/s
        /// 1 gallon (UK)/hour [gal (UK)/h] =  1.2628027777778E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUKPerHour_2_CubicMeterPerSecond(double inVal)        => inVal * 1.2628027777778E-6;
        /// <summary>
        /// m^3/s -> gal (UK)/h
        /// vv: 1.2628027777778E-6 cubic meter/second [m^3/s] to 1 gallon (UK)/hour [gal (UK)/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUKPerHour(double inVal)        => inVal / 1.2628027777778E-6;

        /// <summary>
        /// GallonUKPerMinute -> m^3/s
        /// 1 gallon (UK)/minute =  7.57682E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUKPerMinute_2_CubicMeterPerSecond(double inVal)      => inVal * 7.57682E-5;
        /// <summary>
        /// m^3/s -> GallonUKPerMinute
        /// vv: 7.57682E-5 cubic meter/second [m^3/s] to 1 gallon (UK)/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUKPerMinute(double inVal)      => inVal / 7.57682E-5;

        /// <summary>
        /// GallonUKPerSecond -> m^3/s
        /// 1 gallon (UK)/second =  0.00454609 cubic meter/second [m^3/s]
        /// </summary>
        public static double GallonUKPerSecond_2_CubicMeterPerSecond(double inVal)      => inVal * 0.00454609;
        /// <summary>
        /// m^3/s -> GallonUKPerSecond
        /// vv: 0.00454609 cubic meter/second [m^3/s] to 1 gallon (UK)/second
        /// </summary>
        public static double CubicMeterPerSecond_2_GallonUKPerSecond(double inVal)      => inVal / 0.00454609;

        /// <summary>
        /// KilobarrelUSPerDay -> m^3/s
        /// 1 kilobarrel (US)/day =  0.0018401307 cubic meter/second [m^3/s]
        /// </summary>
        public static double KilobarrelUSPerDay_2_CubicMeterPerSecond(double inVal)     => inVal * 0.0018401307;
        /// <summary>
        /// m^3/s -> KilobarrelUSPerDay
        /// vv: 0.0018401307 cubic meter/second [m^3/s] to 1 kilobarrel (US)/day
        /// </summary>
        public static double CubicMeterPerSecond_2_KilobarrelUSPerDay(double inVal)     => inVal / 0.0018401307;

        /// <summary>
        /// bbl (US)/d -> m^3/s
        /// 1 barrel (US)/day [bbl (US)/d] =  1.8401307283333E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double BarrelUSPerDay_2_CubicMeterPerSecond(double inVal)         => inVal * 1.8401307283333E-6;
        /// <summary>
        /// m^3/s -> bbl (US)/d
        /// vv: 1.8401307283333E-6 cubic meter/second [m^3/s] to 1 barrel (US)/day [bbl (US)/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_BarrelUSPerDay(double inVal)         => inVal / 1.8401307283333E-6;

        /// <summary>
        /// bbl (US)/h -> m^3/s
        /// 1 barrel (US)/hour [bbl (US)/h] =  4.41631E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double BarrelUSPerHour_2_CubicMeterPerSecond(double inVal)        => inVal * 4.41631E-5;
        /// <summary>
        /// m^3/s -> bbl (US)/h
        /// vv: 4.41631E-5 cubic meter/second [m^3/s] to 1 barrel (US)/hour [bbl (US)/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_BarrelUSPerHour(double inVal)        => inVal / 4.41631E-5;

        /// <summary>
        /// BarrelUSPerMinute -> m^3/s
        /// 1 barrel (US)/minute =  0.0026497882 cubic meter/second [m^3/s]
        /// </summary>
        public static double BarrelUSPerMinute_2_CubicMeterPerSecond(double inVal)      => inVal * 0.0026497882;
        /// <summary>
        /// m^3/s -> BarrelUSPerMinute
        /// vv: 0.0026497882 cubic meter/second [m^3/s] to 1 barrel (US)/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_BarrelUSPerMinute(double inVal)      => inVal / 0.0026497882;

        /// <summary>
        /// BarrelUSPerSecond -> m^3/s
        /// 1 barrel (US)/second =  0.1589872949 cubic meter/second [m^3/s]
        /// </summary>
        public static double BarrelUSPerSecond_2_CubicMeterPerSecond(double inVal)      => inVal * 0.1589872949;
        /// <summary>
        /// m^3/s -> BarrelUSPerSecond
        /// vv: 0.1589872949 cubic meter/second [m^3/s] to 1 barrel (US)/second
        /// </summary>
        public static double CubicMeterPerSecond_2_BarrelUSPerSecond(double inVal)      => inVal / 0.1589872949;

        /// <summary>
        /// ac*ft/y -> m^3/s
        /// 1 acre-foot/year [ac*ft/y] =  3.91136E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double AcreFootPerYear_2_CubicMeterPerSecond(double inVal)        => inVal * 3.91136E-5;
        /// <summary>
        /// m^3/s -> ac*ft/y
        /// vv: 3.91136E-5 cubic meter/second [m^3/s] to 1 acre-foot/year [ac*ft/y]
        /// </summary>
        public static double CubicMeterPerSecond_2_AcreFootPerYear(double inVal)        => inVal / 3.91136E-5;

        /// <summary>
        /// ac*ft/d -> m^3/s
        /// 1 acre-foot/day [ac*ft/d] =  0.0142764673 cubic meter/second [m^3/s]
        /// </summary>
        public static double AcreFootPerDay_2_CubicMeterPerSecond(double inVal)         => inVal * 0.0142764673;
        /// <summary>
        /// m^3/s -> ac*ft/d
        /// vv: 0.0142764673 cubic meter/second [m^3/s] to 1 acre-foot/day [ac*ft/d]
        /// </summary>
        public static double CubicMeterPerSecond_2_AcreFootPerDay(double inVal)         => inVal / 0.0142764673;

        /// <summary>
        /// ac*ft/h -> m^3/s
        /// 1 acre-foot/hour [ac*ft/h] =  0.3426352143 cubic meter/second [m^3/s]
        /// </summary>
        public static double AcreFootPerHour_2_CubicMeterPerSecond(double inVal)        => inVal * 0.3426352143;
        /// <summary>
        /// m^3/s -> ac*ft/h
        /// vv: 0.3426352143 cubic meter/second [m^3/s] to 1 acre-foot/hour [ac*ft/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_AcreFootPerHour(double inVal)        => inVal / 0.3426352143;

        /// <summary>
        /// HundredCubicFootPerDay -> m^3/s
        /// 1 hundred-cubic foot/day =  3.27741E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double HundredCubicFootPerDay_2_CubicMeterPerSecond(double inVal) => inVal * 3.27741E-5;
        /// <summary>
        /// m^3/s -> HundredCubicFootPerDay
        /// vv: 3.27741E-5 cubic meter/second [m^3/s] to 1 hundred-cubic foot/day
        /// </summary>
        public static double CubicMeterPerSecond_2_HundredCubicFootPerDay(double inVal) => inVal / 3.27741E-5;

        /// <summary>
        /// HundredCubicFootPerHour -> m^3/s
        /// 1 hundred-cubic foot/hour =  0.0007865791 cubic meter/second [m^3/s]
        /// </summary>
        public static double HundredCubicFootPerHour_2_CubicMeterPerSecond(double inVal)=> inVal * 0.0007865791;
        /// <summary>
        /// m^3/s -> HundredCubicFootPerHour
        /// vv: 0.0007865791 cubic meter/second [m^3/s] to 1 hundred-cubic foot/hour
        /// </summary>
        public static double CubicMeterPerSecond_2_HundredCubicFootPerHour(double inVal)=> inVal / 0.0007865791;

        /// <summary>
        /// HundredCubicFootPerMinute -> m^3/s
        /// 1 hundred-cubic foot/minute =  0.0471947443 cubic meter/second [m^3/s]
        /// </summary>
        public static double HundredCubicFootPerMinute_2_CubicMeterPerSecond(double inVal)=> inVal * 0.0471947443;
        /// <summary>
        /// m^3/s -> HundredCubicFootPerMinute
        /// vv: 0.0471947443 cubic meter/second [m^3/s] to 1 hundred-cubic foot/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_HundredCubicFootPerMinute(double inVal)=> inVal / 0.0471947443;

        /// <summary>
        /// oz/h -> m^3/s
        /// 1 ounce/hour [oz/h] =  8.2148693229167E-9 cubic meter/second [m^3/s]
        /// </summary>
        public static double OuncePerHour_2_CubicMeterPerSecond(double inVal)           => inVal * 8.2148693229167E-9;
        /// <summary>
        /// m^3/s -> oz/h
        /// vv: 8.2148693229167E-9 cubic meter/second [m^3/s] to 1 ounce/hour [oz/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_OuncePerHour(double inVal)           => inVal / 8.2148693229167E-9;

        /// <summary>
        /// oz/min -> m^3/s
        /// 1 ounce/minute [oz/min] =  4.92892159375E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double OuncePerMinute_2_CubicMeterPerSecond(double inVal)         => inVal * 4.92892159375E-7;
        /// <summary>
        /// m^3/s -> oz/min
        /// vv: 4.92892159375E-7 cubic meter/second [m^3/s] to 1 ounce/minute [oz/min]
        /// </summary>
        public static double CubicMeterPerSecond_2_OuncePerMinute(double inVal)         => inVal / 4.92892159375E-7;

        /// <summary>
        /// oz/s -> m^3/s
        /// 1 ounce/second [oz/s] =  2.95735E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double OuncePerSecond_2_CubicMeterPerSecond(double inVal)         => inVal * 2.95735E-5;
        /// <summary>
        /// m^3/s -> oz/s
        /// vv: 2.95735E-5 cubic meter/second [m^3/s] to 1 ounce/second [oz/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_OuncePerSecond(double inVal)         => inVal / 2.95735E-5;

        /// <summary>
        /// oz (UK)/h -> m^3/s
        /// 1 ounce (UK)/hour [oz (UK)/h] =  7.8925178504774E-9 cubic meter/second [m^3/s]
        /// </summary>
        public static double OunceUKPerHour_2_CubicMeterPerSecond(double inVal)         => inVal * 7.8925178504774E-9;
        /// <summary>
        /// m^3/s -> oz (UK)/h
        /// vv: 7.8925178504774E-9 cubic meter/second [m^3/s] to 1 ounce (UK)/hour [oz (UK)/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_OunceUKPerHour(double inVal)         => inVal / 7.8925178504774E-9;

        /// <summary>
        /// OunceUKPerMinute -> m^3/s
        /// 1 ounce (UK)/minute =  4.7355107102865E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double OunceUKPerMinute_2_CubicMeterPerSecond(double inVal)       => inVal * 4.7355107102865E-7;
        /// <summary>
        /// m^3/s -> OunceUKPerMinute
        /// vv: 4.7355107102865E-7 cubic meter/second [m^3/s] to 1 ounce (UK)/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_OunceUKPerMinute(double inVal)       => inVal / 4.7355107102865E-7;

        /// <summary>
        /// OunceUKPerSecond -> m^3/s
        /// 1 ounce (UK)/second =  2.84131E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double OunceUKPerSecond_2_CubicMeterPerSecond(double inVal)       => inVal * 2.84131E-5;
        /// <summary>
        /// m^3/s -> OunceUKPerSecond
        /// vv: 2.84131E-5 cubic meter/second [m^3/s] to 1 ounce (UK)/second
        /// </summary>
        public static double CubicMeterPerSecond_2_OunceUKPerSecond(double inVal)       => inVal / 2.84131E-5;

        /// <summary>
        /// yd^3/h -> m^3/s
        /// 1 cubic yard/hour [yd^3/h] =  0.0002123763 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicYardPerHour_2_CubicMeterPerSecond(double inVal)       => inVal * 0.0002123763;
        /// <summary>
        /// m^3/s -> yd^3/h
        /// vv: 0.0002123763 cubic meter/second [m^3/s] to 1 cubic yard/hour [yd^3/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicYardPerHour(double inVal)       => inVal / 0.0002123763;

        /// <summary>
        /// CubicYardPerMinute -> m^3/s
        /// 1 cubic yard/minute =  0.012742581 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicYardPerMinute_2_CubicMeterPerSecond(double inVal)     => inVal * 0.012742581;
        /// <summary>
        /// m^3/s -> CubicYardPerMinute
        /// vv: 0.012742581 cubic meter/second [m^3/s] to 1 cubic yard/minute
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicYardPerMinute(double inVal)     => inVal / 0.012742581;

        /// <summary>
        /// yd^3/s -> m^3/s
        /// 1 cubic yard/second [yd^3/s] =  0.764554858 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicYardPerSecond_2_CubicMeterPerSecond(double inVal)     => inVal * 0.764554858;
        /// <summary>
        /// m^3/s -> yd^3/s
        /// vv: 0.764554858 cubic meter/second [m^3/s] to 1 cubic yard/second [yd^3/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicYardPerSecond(double inVal)     => inVal / 0.764554858;

        /// <summary>
        /// ft^3/h -> m^3/s
        /// 1 cubic foot/hour [ft^3/h] =  7.86579072E-6 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicFootPerHour_2_CubicMeterPerSecond(double inVal)       => inVal * 7.86579072E-6;
        /// <summary>
        /// m^3/s -> ft^3/h
        /// vv: 7.86579072E-6 cubic meter/second [m^3/s] to 1 cubic foot/hour [ft^3/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicFootPerHour(double inVal)       => inVal / 7.86579072E-6;

        /// <summary>
        /// ft^3/min -> m^3/s
        /// 1 cubic foot/minute [ft^3/min] =  0.0004719474 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicFootPerMinute_2_CubicMeterPerSecond(double inVal)     => inVal * 0.0004719474;
        /// <summary>
        /// m^3/s -> ft^3/min
        /// vv: 0.0004719474 cubic meter/second [m^3/s] to 1 cubic foot/minute [ft^3/min]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicFootPerMinute(double inVal)     => inVal / 0.0004719474;

        /// <summary>
        /// ft^3/s -> m^3/s
        /// 1 cubic foot/second [ft^3/s] =  0.0283168466 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicFootPerSecond_2_CubicMeterPerSecond(double inVal)     => inVal * 0.0283168466;
        /// <summary>
        /// m^3/s -> ft^3/s
        /// vv: 0.0283168466 cubic meter/second [m^3/s] to 1 cubic foot/second [ft^3/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicFootPerSecond(double inVal)     => inVal / 0.0283168466;

        /// <summary>
        /// in^3/h -> m^3/s
        /// 1 cubic inch/hour [in^3/h] =  4.5519622224454E-9 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicInchPerHour_2_CubicMeterPerSecond(double inVal)       => inVal * 4.5519622224454E-9;
        /// <summary>
        /// m^3/s -> in^3/h
        /// vv: 4.5519622224454E-9 cubic meter/second [m^3/s] to 1 cubic inch/hour [in^3/h]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicInchPerHour(double inVal)       => inVal / 4.5519622224454E-9;

        /// <summary>
        /// in^3/min -> m^3/s
        /// 1 cubic inch/minute [in^3/min] =  2.7311773333333E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicInchPerMinute_2_CubicMeterPerSecond(double inVal)     => inVal * 2.7311773333333E-7;
        /// <summary>
        /// m^3/s -> in^3/min
        /// vv: 2.7311773333333E-7 cubic meter/second [m^3/s] to 1 cubic inch/minute [in^3/min]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicInchPerMinute(double inVal)     => inVal / 2.7311773333333E-7;

        /// <summary>
        /// in^3/s -> m^3/s
        /// 1 cubic inch/second [in^3/s] =  1.63871E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double CubicInchPerSecond_2_CubicMeterPerSecond(double inVal)     => inVal * 1.63871E-5;
        /// <summary>
        /// m^3/s -> in^3/s
        /// vv: 1.63871E-5 cubic meter/second [m^3/s] to 1 cubic inch/second [in^3/s]
        /// </summary>
        public static double CubicMeterPerSecond_2_CubicInchPerSecond(double inVal)     => inVal / 1.63871E-5;

        /// <summary>
        /// PoundPerSecondGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 pound/second (Gasoline at 15p5DegreesCelsius) =  0.0006135189 cubic meter/second [m^3/s]
        /// </summary>
        public static double PoundPerSecondGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 0.0006135189;
        /// <summary>
        /// m^3/s -> PoundPerSecondGasolineAt15p5DegreesCelsius
        /// vv: 0.0006135189 cubic meter/second [m^3/s] to 1 pound/second (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_PoundPerSecondGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 0.0006135189;

        /// <summary>
        /// PoundPerMinuteGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 pound/minute (Gasoline at 15p5DegreesCelsius) =  1.02253E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double PoundPerMinuteGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 1.02253E-5;
        /// <summary>
        /// m^3/s -> PoundPerMinuteGasolineAt15p5DegreesCelsius
        /// vv: 1.02253E-5 cubic meter/second [m^3/s] to 1 pound/minute (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_PoundPerMinuteGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 1.02253E-5;

        /// <summary>
        /// PoundPerHourGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 pound/hour (Gasoline at 15p5DegreesCelsius) =  1.704219244213E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double PoundPerHourGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 1.704219244213E-7;
        /// <summary>
        /// m^3/s -> PoundPerHourGasolineAt15p5DegreesCelsius
        /// vv: 1.704219244213E-7 cubic meter/second [m^3/s] to 1 pound/hour (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_PoundPerHourGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 1.704219244213E-7;

        /// <summary>
        /// PoundPerDayGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 pound/day (Gasoline at 15p5DegreesCelsius) =  7.1009135150463E-9 cubic meter/second [m^3/s]
        /// </summary>
        public static double PoundPerDayGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 7.1009135150463E-9;
        /// <summary>
        /// m^3/s -> PoundPerDayGasolineAt15p5DegreesCelsius
        /// vv: 7.1009135150463E-9 cubic meter/second [m^3/s] to 1 pound/day (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_PoundPerDayGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 7.1009135150463E-9;

        /// <summary>
        /// KilogramPerSecondGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 kilogram/second (Gasoline at 15p5DegreesCelsius) =  0.0013525777 cubic meter/second [m^3/s]
        /// </summary>
        public static double KilogramPerSecondGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 0.0013525777;
        /// <summary>
        /// m^3/s -> KilogramPerSecondGasolineAt15p5DegreesCelsius
        /// vv: 0.0013525777 cubic meter/second [m^3/s] to 1 kilogram/second (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_KilogramPerSecondGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 0.0013525777;

        /// <summary>
        /// KilogramPerMinuteGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 kilogram/minute (Gasoline at 15p5DegreesCelsius) =  2.2543E-5 cubic meter/second [m^3/s]
        /// </summary>
        public static double KilogramPerMinuteGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 2.2543E-5;
        /// <summary>
        /// m^3/s -> KilogramPerMinuteGasolineAt15p5DegreesCelsius
        /// vv: 2.2543E-5 cubic meter/second [m^3/s] to 1 kilogram/minute (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_KilogramPerMinuteGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 2.2543E-5;

        /// <summary>
        /// KilogramPerHourGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 kilogram/hour (Gasoline at 15p5DegreesCelsius) =  3.7571602974537E-7 cubic meter/second [m^3/s]
        /// </summary>
        public static double KilogramPerHourGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 3.7571602974537E-7;
        /// <summary>
        /// m^3/s -> KilogramPerHourGasolineAt15p5DegreesCelsius
        /// vv: 3.7571602974537E-7 cubic meter/second [m^3/s] to 1 kilogram/hour (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_KilogramPerHourGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 3.7571602974537E-7;

        /// <summary>
        /// KilogramPerDayGasolineAt15p5DegreesCelsius -> m^3/s
        /// 1 kilogram/day (Gasoline at 15p5DegreesCelsius) =  1.5654834571759E-8 cubic meter/second [m^3/s]
        /// </summary>
        public static double KilogramPerDayGasolineAt15p5DegreesCelsius_2_CubicMeterPerSecond(double inVal)=> inVal * 1.5654834571759E-8;
        /// <summary>
        /// m^3/s -> KilogramPerDayGasolineAt15p5DegreesCelsius
        /// vv: 1.5654834571759E-8 cubic meter/second [m^3/s] to 1 kilogram/day (Gasoline at 15p5DegreesCelsius)
        /// </summary>
        public static double CubicMeterPerSecond_2_KilogramPerDayGasolineAt15p5DegreesCelsius(double inVal)=> inVal / 1.5654834571759E-8;

        #endregion

        #region flow - mass, base: kilogram/second

        /// <summary>
        /// g/s -> kg/s
        /// 1 gram/second [g/s] =  0.001 kilogram/second [kg/s]
        /// </summary>
        public static double GramPerSecond_2_KilogramPerSecond(double inVal)            => inVal * 0.001;
        /// <summary>
        /// kg/s -> g/s
        /// vv: 0.001 kilogram/second [kg/s] to 1 gram/second [g/s]
        /// </summary>
        public static double KilogramPerSecond_2_GramPerSecond(double inVal)            => inVal / 0.001;

        /// <summary>
        /// g/min -> kg/s
        /// 1 gram/minute [g/min] =  1.66667E-5 kilogram/second [kg/s]
        /// </summary>
        public static double GramPerMinute_2_KilogramPerSecond(double inVal)            => inVal * 1.66667E-5;
        /// <summary>
        /// kg/s -> g/min
        /// vv: 1.66667E-5 kilogram/second [kg/s] to 1 gram/minute [g/min]
        /// </summary>
        public static double KilogramPerSecond_2_GramPerMinute(double inVal)            => inVal / 1.66667E-5;

        /// <summary>
        /// g/h -> kg/s
        /// 1 gram/hour [g/h] =  2.7777777777778E-7 kilogram/second [kg/s]
        /// </summary>
        public static double GramPerHour_2_KilogramPerSecond(double inVal)              => inVal * 2.7777777777778E-7;
        /// <summary>
        /// kg/s -> g/h
        /// vv: 2.7777777777778E-7 kilogram/second [kg/s] to 1 gram/hour [g/h]
        /// </summary>
        public static double KilogramPerSecond_2_GramPerHour(double inVal)              => inVal / 2.7777777777778E-7;

        /// <summary>
        /// g/d -> kg/s
        /// 1 gram/day [g/d] =  1.1574074074074E-8 kilogram/second [kg/s]
        /// </summary>
        public static double GramPerDay_2_KilogramPerSecond(double inVal)               => inVal * 1.1574074074074E-8;
        /// <summary>
        /// kg/s -> g/d
        /// vv: 1.1574074074074E-8 kilogram/second [kg/s] to 1 gram/day [g/d]
        /// </summary>
        public static double KilogramPerSecond_2_GramPerDay(double inVal)               => inVal / 1.1574074074074E-8;

        /// <summary>
        /// mg/min -> kg/s
        /// 1 milligram/minute [mg/min] =  1.6666666666667E-8 kilogram/second [kg/s]
        /// </summary>
        public static double MilligramPerMinute_2_KilogramPerSecond(double inVal)       => inVal * 1.6666666666667E-8;
        /// <summary>
        /// kg/s -> mg/min
        /// vv: 1.6666666666667E-8 kilogram/second [kg/s] to 1 milligram/minute [mg/min]
        /// </summary>
        public static double KilogramPerSecond_2_MilligramPerMinute(double inVal)       => inVal / 1.6666666666667E-8;

        /// <summary>
        /// mg/h -> kg/s
        /// 1 milligram/hour [mg/h] =  2.7777777777778E-10 kilogram/second [kg/s]
        /// </summary>
        public static double MilligramPerHour_2_KilogramPerSecond(double inVal)         => inVal * 2.7777777777778E-10;
        /// <summary>
        /// kg/s -> mg/h
        /// vv: 2.7777777777778E-10 kilogram/second [kg/s] to 1 milligram/hour [mg/h]
        /// </summary>
        public static double KilogramPerSecond_2_MilligramPerHour(double inVal)         => inVal / 2.7777777777778E-10;

        /// <summary>
        /// mg/d -> kg/s
        /// 1 milligram/day [mg/d] =  1.1574074074074E-11 kilogram/second [kg/s]
        /// </summary>
        public static double MilligramPerDay_2_KilogramPerSecond(double inVal)          => inVal * 1.1574074074074E-11;
        /// <summary>
        /// kg/s -> mg/d
        /// vv: 1.1574074074074E-11 kilogram/second [kg/s] to 1 milligram/day [mg/d]
        /// </summary>
        public static double KilogramPerSecond_2_MilligramPerDay(double inVal)          => inVal / 1.1574074074074E-11;

        /// <summary>
        /// kg/min -> kg/s
        /// 1 kilogram/minute [kg/min] =  0.0166666667 kilogram/second [kg/s]
        /// </summary>
        public static double KilogramPerMinute_2_KilogramPerSecond(double inVal)        => inVal * 0.0166666667;
        /// <summary>
        /// kg/s -> kg/min
        /// vv: 0.0166666667 kilogram/second [kg/s] to 1 kilogram/minute [kg/min]
        /// </summary>
        public static double KilogramPerSecond_2_KilogramPerMinute(double inVal)        => inVal / 0.0166666667;

        /// <summary>
        /// kg/h -> kg/s
        /// 1 kilogram/hour [kg/h] =  0.0002777778 kilogram/second [kg/s]
        /// </summary>
        public static double KilogramPerHour_2_KilogramPerSecond(double inVal)          => inVal * 0.0002777778;
        /// <summary>
        /// kg/s -> kg/h
        /// vv: 0.0002777778 kilogram/second [kg/s] to 1 kilogram/hour [kg/h]
        /// </summary>
        public static double KilogramPerSecond_2_KilogramPerHour(double inVal)          => inVal / 0.0002777778;

        /// <summary>
        /// kg/d -> kg/s
        /// 1 kilogram/day [kg/d] =  1.15741E-5 kilogram/second [kg/s]
        /// </summary>
        public static double KilogramPerDay_2_KilogramPerSecond(double inVal)           => inVal * 1.15741E-5;
        /// <summary>
        /// kg/s -> kg/d
        /// vv: 1.15741E-5 kilogram/second [kg/s] to 1 kilogram/day [kg/d]
        /// </summary>
        public static double KilogramPerSecond_2_KilogramPerDay(double inVal)           => inVal / 1.15741E-5;

        /// <summary>
        /// Eg/s -> kg/s
        /// 1 exagram/second [Eg/s] =  1.0E+15 kilogram/second [kg/s]
        /// </summary>
        public static double ExagramPerSecond_2_KilogramPerSecond(double inVal)         => inVal * 1.0E+15;
        /// <summary>
        /// kg/s -> Eg/s
        /// vv: 1.0E+15 kilogram/second [kg/s] to 1 exagram/second [Eg/s]
        /// </summary>
        public static double KilogramPerSecond_2_ExagramPerSecond(double inVal)         => inVal / 1.0E+15;

        /// <summary>
        /// Pg/s -> kg/s
        /// 1 petagram/second [Pg/s] =  1000000000000 kilogram/second [kg/s]
        /// </summary>
        public static double PetagramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 1000000000000;
        /// <summary>
        /// kg/s -> Pg/s
        /// vv: 1000000000000 kilogram/second [kg/s] to 1 petagram/second [Pg/s]
        /// </summary>
        public static double KilogramPerSecond_2_PetagramPerSecond(double inVal)        => inVal / 1000000000000;

        /// <summary>
        /// Tg/s -> kg/s
        /// 1 teragram/second [Tg/s] =  1000000000 kilogram/second [kg/s]
        /// </summary>
        public static double TeragramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 1000000000;
        /// <summary>
        /// kg/s -> Tg/s
        /// vv: 1000000000 kilogram/second [kg/s] to 1 teragram/second [Tg/s]
        /// </summary>
        public static double KilogramPerSecond_2_TeragramPerSecond(double inVal)        => inVal / 1000000000;

        /// <summary>
        /// Gg/s -> kg/s
        /// 1 gigagram/second [Gg/s] =  1000000 kilogram/second [kg/s]
        /// </summary>
        public static double GigagramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 1000000;
        /// <summary>
        /// kg/s -> Gg/s
        /// vv: 1000000 kilogram/second [kg/s] to 1 gigagram/second [Gg/s]
        /// </summary>
        public static double KilogramPerSecond_2_GigagramPerSecond(double inVal)        => inVal / 1000000;

        /// <summary>
        /// Mg/s -> kg/s
        /// 1 megagram/second [Mg/s] =  1000 kilogram/second [kg/s]
        /// </summary>
        public static double MegagramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 1000;
        /// <summary>
        /// kg/s -> Mg/s
        /// vv: 1000 kilogram/second [kg/s] to 1 megagram/second [Mg/s]
        /// </summary>
        public static double KilogramPerSecond_2_MegagramPerSecond(double inVal)        => inVal / 1000;

        /// <summary>
        /// hg/s -> kg/s
        /// 1 hectogram/second [hg/s] =  0.1 kilogram/second [kg/s]
        /// </summary>
        public static double HectogramPerSecond_2_KilogramPerSecond(double inVal)       => inVal * 0.1;
        /// <summary>
        /// kg/s -> hg/s
        /// vv: 0.1 kilogram/second [kg/s] to 1 hectogram/second [hg/s]
        /// </summary>
        public static double KilogramPerSecond_2_HectogramPerSecond(double inVal)       => inVal / 0.1;

        /// <summary>
        /// dag/s -> kg/s
        /// 1 dekagram/second [dag/s] =  0.01 kilogram/second [kg/s]
        /// </summary>
        public static double DekagramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 0.01;
        /// <summary>
        /// kg/s -> dag/s
        /// vv: 0.01 kilogram/second [kg/s] to 1 dekagram/second [dag/s]
        /// </summary>
        public static double KilogramPerSecond_2_DekagramPerSecond(double inVal)        => inVal / 0.01;

        /// <summary>
        /// dg/s -> kg/s
        /// 1 decigram/second [dg/s] =  0.0001 kilogram/second [kg/s]
        /// </summary>
        public static double DecigramPerSecond_2_KilogramPerSecond(double inVal)        => inVal * 0.0001;
        /// <summary>
        /// kg/s -> dg/s
        /// vv: 0.0001 kilogram/second [kg/s] to 1 decigram/second [dg/s]
        /// </summary>
        public static double KilogramPerSecond_2_DecigramPerSecond(double inVal)        => inVal / 0.0001;

        /// <summary>
        /// cg/s -> kg/s
        /// 1 centigram/second [cg/s] =  1.0E-5 kilogram/second [kg/s]
        /// </summary>
        public static double CentigramPerSecond_2_KilogramPerSecond(double inVal)       => inVal * 1.0E-5;
        /// <summary>
        /// kg/s -> cg/s
        /// vv: 1.0E-5 kilogram/second [kg/s] to 1 centigram/second [cg/s]
        /// </summary>
        public static double KilogramPerSecond_2_CentigramPerSecond(double inVal)       => inVal / 1.0E-5;

        /// <summary>
        /// mg/s -> kg/s
        /// 1 milligram/second [mg/s] =  1.0E-6 kilogram/second [kg/s]
        /// </summary>
        public static double MilligramPerSecond_2_KilogramPerSecond(double inVal)       => inVal * 1.0E-6;
        /// <summary>
        /// kg/s -> mg/s
        /// vv: 1.0E-6 kilogram/second [kg/s] to 1 milligram/second [mg/s]
        /// </summary>
        public static double KilogramPerSecond_2_MilligramPerSecond(double inVal)       => inVal / 1.0E-6;

        /// <summary>
        /// µg/s -> kg/s
        /// 1 microgram/second [µg/s] =  1.0E-9 kilogram/second [kg/s]
        /// </summary>
        public static double MicrogramPerSecond_2_KilogramPerSecond(double inVal)       => inVal * 1.0E-9;
        /// <summary>
        /// kg/s -> µg/s
        /// vv: 1.0E-9 kilogram/second [kg/s] to 1 microgram/second [µg/s]
        /// </summary>
        public static double KilogramPerSecond_2_MicrogramPerSecond(double inVal)       => inVal / 1.0E-9;

        /// <summary>
        /// t/s -> kg/s
        /// 1 ton (metric)/second [t/s] =  1000 kilogram/second [kg/s]
        /// </summary>
        public static double TonMetricPerSecond_2_KilogramPerSecond(double inVal)       => inVal * 1000;
        /// <summary>
        /// kg/s -> t/s
        /// vv: 1000 kilogram/second [kg/s] to 1 ton (metric)/second [t/s]
        /// </summary>
        public static double KilogramPerSecond_2_TonMetricPerSecond(double inVal)       => inVal / 1000;

        /// <summary>
        /// t/min -> kg/s
        /// 1 ton (metric)/minute [t/min] =  16.6666666667 kilogram/second [kg/s]
        /// </summary>
        public static double TonMetricPerMinute_2_KilogramPerSecond(double inVal)       => inVal * 16.6666666667;
        /// <summary>
        /// kg/s -> t/min
        /// vv: 16.6666666667 kilogram/second [kg/s] to 1 ton (metric)/minute [t/min]
        /// </summary>
        public static double KilogramPerSecond_2_TonMetricPerMinute(double inVal)       => inVal / 16.6666666667;

        /// <summary>
        /// t/h -> kg/s
        /// 1 ton (metric)/hour [t/h] =  0.2777777778 kilogram/second [kg/s]
        /// </summary>
        public static double TonMetricPerHour_2_KilogramPerSecond(double inVal)         => inVal * 0.2777777778;
        /// <summary>
        /// kg/s -> t/h
        /// vv: 0.2777777778 kilogram/second [kg/s] to 1 ton (metric)/hour [t/h]
        /// </summary>
        public static double KilogramPerSecond_2_TonMetricPerHour(double inVal)         => inVal / 0.2777777778;

        /// <summary>
        /// t/d -> kg/s
        /// 1 ton (metric)/day [t/d] =  0.0115740741 kilogram/second [kg/s]
        /// </summary>
        public static double TonMetricPerDay_2_KilogramPerSecond(double inVal)          => inVal * 0.0115740741;
        /// <summary>
        /// kg/s -> t/d
        /// vv: 0.0115740741 kilogram/second [kg/s] to 1 ton (metric)/day [t/d]
        /// </summary>
        public static double KilogramPerSecond_2_TonMetricPerDay(double inVal)          => inVal / 0.0115740741;

        /// <summary>
        /// ton (US)/h -> kg/s
        /// 1 ton (short)/hour [ton (US)/h] =  0.2519957611 kilogram/second [kg/s]
        /// </summary>
        public static double TonShortPerHour_2_KilogramPerSecond(double inVal)          => inVal * 0.2519957611;
        /// <summary>
        /// kg/s -> ton (US)/h
        /// vv: 0.2519957611 kilogram/second [kg/s] to 1 ton (short)/hour [ton (US)/h]
        /// </summary>
        public static double KilogramPerSecond_2_TonShortPerHour(double inVal)          => inVal / 0.2519957611;

        /// <summary>
        /// lb/s -> kg/s
        /// 1 pound/second [lb/s] =  0.45359237 kilogram/second [kg/s]
        /// </summary>
        public static double PoundPerSecond_2_KilogramPerSecond(double inVal)           => inVal * 0.45359237;
        /// <summary>
        /// kg/s -> lb/s
        /// vv: 0.45359237 kilogram/second [kg/s] to 1 pound/second [lb/s]
        /// </summary>
        public static double KilogramPerSecond_2_PoundPerSecond(double inVal)           => inVal / 0.45359237;

        /// <summary>
        /// lb/min -> kg/s
        /// 1 pound/minute [lb/min] =  0.0075598728 kilogram/second [kg/s]
        /// </summary>
        public static double PoundPerMinute_2_KilogramPerSecond(double inVal)           => inVal * 0.0075598728;
        /// <summary>
        /// kg/s -> lb/min
        /// vv: 0.0075598728 kilogram/second [kg/s] to 1 pound/minute [lb/min]
        /// </summary>
        public static double KilogramPerSecond_2_PoundPerMinute(double inVal)           => inVal / 0.0075598728;

        /// <summary>
        /// lb/h -> kg/s
        /// 1 pound/hour [lb/h] =  0.0001259979 kilogram/second [kg/s]
        /// </summary>
        public static double PoundPerHour_2_KilogramPerSecond(double inVal)             => inVal * 0.0001259979;
        /// <summary>
        /// kg/s -> lb/h
        /// vv: 0.0001259979 kilogram/second [kg/s] to 1 pound/hour [lb/h]
        /// </summary>
        public static double KilogramPerSecond_2_PoundPerHour(double inVal)             => inVal / 0.0001259979;

        /// <summary>
        /// lb/d -> kg/s
        /// 1 pound/day [lb/d] =  5.2499116898148E-6 kilogram/second [kg/s]
        /// </summary>
        public static double PoundPerDay_2_KilogramPerSecond(double inVal)              => inVal * 5.2499116898148E-6;
        /// <summary>
        /// kg/s -> lb/d
        /// vv: 5.2499116898148E-6 kilogram/second [kg/s] to 1 pound/day [lb/d]
        /// </summary>
        public static double KilogramPerSecond_2_PoundPerDay(double inVal)              => inVal / 5.2499116898148E-6;

        #endregion


        #region flow molar, base: mol/second

        /// <summary>
        /// Emol/s -> mol/s
        /// 1 examol/second [Emol/s] =  1.0E+18 mol/second [mol/s]
        /// </summary>
        public static double ExamolPerSecond_2_MolPerSecond(double inVal)               => inVal * 1.0E+18;
        /// <summary>
        /// mol/s -> Emol/s
        /// vv: 1.0E+18 mol/second [mol/s] to 1 examol/second [Emol/s]
        /// </summary>
        public static double MolPerSecond_2_ExamolPerSecond(double inVal)               => inVal / 1.0E+18;

        /// <summary>
        /// Pmol/s -> mol/s
        /// 1 petamol/second [Pmol/s] =  1.0E+15 mol/second [mol/s]
        /// </summary>
        public static double PetamolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1.0E+15;
        /// <summary>
        /// mol/s -> Pmol/s
        /// vv: 1.0E+15 mol/second [mol/s] to 1 petamol/second [Pmol/s]
        /// </summary>
        public static double MolPerSecond_2_PetamolPerSecond(double inVal)              => inVal / 1.0E+15;

        /// <summary>
        /// Tmol/s -> mol/s
        /// 1 teramol/second [Tmol/s] =  1000000000000 mol/second [mol/s]
        /// </summary>
        public static double TeramolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1000000000000;
        /// <summary>
        /// mol/s -> Tmol/s
        /// vv: 1000000000000 mol/second [mol/s] to 1 teramol/second [Tmol/s]
        /// </summary>
        public static double MolPerSecond_2_TeramolPerSecond(double inVal)              => inVal / 1000000000000;

        /// <summary>
        /// Gmol/s -> mol/s
        /// 1 gigamol/second [Gmol/s] =  1000000000 mol/second [mol/s]
        /// </summary>
        public static double GigamolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1000000000;
        /// <summary>
        /// mol/s -> Gmol/s
        /// vv: 1000000000 mol/second [mol/s] to 1 gigamol/second [Gmol/s]
        /// </summary>
        public static double MolPerSecond_2_GigamolPerSecond(double inVal)              => inVal / 1000000000;

        /// <summary>
        /// Mmol/s -> mol/s
        /// 1 megamol/second [Mmol/s] =  1000000 mol/second [mol/s]
        /// </summary>
        public static double MegamolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1000000;
        /// <summary>
        /// mol/s -> Mmol/s
        /// vv: 1000000 mol/second [mol/s] to 1 megamol/second [Mmol/s]
        /// </summary>
        public static double MolPerSecond_2_MegamolPerSecond(double inVal)              => inVal / 1000000;

        /// <summary>
        /// kmol/s -> mol/s
        /// 1 kilomol/second [kmol/s] =  1000 mol/second [mol/s]
        /// </summary>
        public static double KilomolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1000;
        /// <summary>
        /// mol/s -> kmol/s
        /// vv: 1000 mol/second [mol/s] to 1 kilomol/second [kmol/s]
        /// </summary>
        public static double MolPerSecond_2_KilomolPerSecond(double inVal)              => inVal / 1000;

        /// <summary>
        /// hmol/s -> mol/s
        /// 1 hectomol/second [hmol/s] =  100 mol/second [mol/s]
        /// </summary>
        public static double HectomolPerSecond_2_MolPerSecond(double inVal)             => inVal * 100;
        /// <summary>
        /// mol/s -> hmol/s
        /// vv: 100 mol/second [mol/s] to 1 hectomol/second [hmol/s]
        /// </summary>
        public static double MolPerSecond_2_HectomolPerSecond(double inVal)             => inVal / 100;

        /// <summary>
        /// damol/s -> mol/s
        /// 1 dekamol/second [damol/s] =  10 mol/second [mol/s]
        /// </summary>
        public static double DekamolPerSecond_2_MolPerSecond(double inVal)              => inVal * 10;
        /// <summary>
        /// mol/s -> damol/s
        /// vv: 10 mol/second [mol/s] to 1 dekamol/second [damol/s]
        /// </summary>
        public static double MolPerSecond_2_DekamolPerSecond(double inVal)              => inVal / 10;

        /// <summary>
        /// dmol/s -> mol/s
        /// 1 decimol/second [dmol/s] =  0.1 mol/second [mol/s]
        /// </summary>
        public static double DecimolPerSecond_2_MolPerSecond(double inVal)              => inVal * 0.1;
        /// <summary>
        /// mol/s -> dmol/s
        /// vv: 0.1 mol/second [mol/s] to 1 decimol/second [dmol/s]
        /// </summary>
        public static double MolPerSecond_2_DecimolPerSecond(double inVal)              => inVal / 0.1;

        /// <summary>
        /// cmol/s -> mol/s
        /// 1 centimol/second [cmol/s] =  0.01 mol/second [mol/s]
        /// </summary>
        public static double CentimolPerSecond_2_MolPerSecond(double inVal)             => inVal * 0.01;
        /// <summary>
        /// mol/s -> cmol/s
        /// vv: 0.01 mol/second [mol/s] to 1 centimol/second [cmol/s]
        /// </summary>
        public static double MolPerSecond_2_CentimolPerSecond(double inVal)             => inVal / 0.01;

        /// <summary>
        /// mmol/s -> mol/s
        /// 1 millimol/second [mmol/s] =  0.001 mol/second [mol/s]
        /// </summary>
        public static double MillimolPerSecond_2_MolPerSecond(double inVal)             => inVal * 0.001;
        /// <summary>
        /// mol/s -> mmol/s
        /// vv: 0.001 mol/second [mol/s] to 1 millimol/second [mmol/s]
        /// </summary>
        public static double MolPerSecond_2_MillimolPerSecond(double inVal)             => inVal / 0.001;

        /// <summary>
        /// µmol/s -> mol/s
        /// 1 micromol/second [µmol/s] =  1.0E-6 mol/second [mol/s]
        /// </summary>
        public static double MicromolPerSecond_2_MolPerSecond(double inVal)             => inVal * 1.0E-6;
        /// <summary>
        /// mol/s -> µmol/s
        /// vv: 1.0E-6 mol/second [mol/s] to 1 micromol/second [µmol/s]
        /// </summary>
        public static double MolPerSecond_2_MicromolPerSecond(double inVal)             => inVal / 1.0E-6;

        /// <summary>
        /// nmol/s -> mol/s
        /// 1 nanomol/second [nmol/s] =  1.0E-9 mol/second [mol/s]
        /// </summary>
        public static double NanomolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1.0E-9;
        /// <summary>
        /// mol/s -> nmol/s
        /// vv: 1.0E-9 mol/second [mol/s] to 1 nanomol/second [nmol/s]
        /// </summary>
        public static double MolPerSecond_2_NanomolPerSecond(double inVal)              => inVal / 1.0E-9;

        /// <summary>
        /// pmol/s -> mol/s
        /// 1 picomol/second [pmol/s] =  1.0E-12 mol/second [mol/s]
        /// </summary>
        public static double PicomolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1.0E-12;
        /// <summary>
        /// mol/s -> pmol/s
        /// vv: 1.0E-12 mol/second [mol/s] to 1 picomol/second [pmol/s]
        /// </summary>
        public static double MolPerSecond_2_PicomolPerSecond(double inVal)              => inVal / 1.0E-12;

        /// <summary>
        /// fmol/s -> mol/s
        /// 1 femtomol/second [fmol/s] =  1.0E-15 mol/second [mol/s]
        /// </summary>
        public static double FemtomolPerSecond_2_MolPerSecond(double inVal)             => inVal * 1.0E-15;
        /// <summary>
        /// mol/s -> fmol/s
        /// vv: 1.0E-15 mol/second [mol/s] to 1 femtomol/second [fmol/s]
        /// </summary>
        public static double MolPerSecond_2_FemtomolPerSecond(double inVal)             => inVal / 1.0E-15;

        /// <summary>
        /// amol/s -> mol/s
        /// 1 attomol/second [amol/s] =  1.0E-18 mol/second [mol/s]
        /// </summary>
        public static double AttomolPerSecond_2_MolPerSecond(double inVal)              => inVal * 1.0E-18;
        /// <summary>
        /// mol/s -> amol/s
        /// vv: 1.0E-18 mol/second [mol/s] to 1 attomol/second [amol/s]
        /// </summary>
        public static double MolPerSecond_2_AttomolPerSecond(double inVal)              => inVal / 1.0E-18;

        /// <summary>
        /// mol/min -> mol/s
        /// 1 mol/minute [mol/min] =  0.0166666667 mol/second [mol/s]
        /// </summary>
        public static double MolPerMinute_2_MolPerSecond(double inVal)                  => inVal * 0.0166666667;
        /// <summary>
        /// mol/s -> mol/min
        /// vv: 0.0166666667 mol/second [mol/s] to 1 mol/minute [mol/min]
        /// </summary>
        public static double MolPerSecond_2_MolPerMinute(double inVal)                  => inVal / 0.0166666667;

        /// <summary>
        /// mol/h -> mol/s
        /// 1 mol/hour [mol/h] =  0.0002777778 mol/second [mol/s]
        /// </summary>
        public static double MolPerHour_2_MolPerSecond(double inVal)                    => inVal * 0.0002777778;
        /// <summary>
        /// mol/s -> mol/h
        /// vv: 0.0002777778 mol/second [mol/s] to 1 mol/hour [mol/h]
        /// </summary>
        public static double MolPerSecond_2_MolPerHour(double inVal)                    => inVal / 0.0002777778;

        /// <summary>
        /// mol/d -> mol/s
        /// 1 mol/day [mol/d] =  1.15741E-5 mol/second [mol/s]
        /// </summary>
        public static double MolPerDay_2_MolPerSecond(double inVal)                     => inVal * 1.15741E-5;
        /// <summary>
        /// mol/s -> mol/d
        /// vv: 1.15741E-5 mol/second [mol/s] to 1 mol/day [mol/d]
        /// </summary>
        public static double MolPerSecond_2_MolPerDay(double inVal)                     => inVal / 1.15741E-5;

        /// <summary>
        /// mmol/min -> mol/s
        /// 1 millimol/minute [mmol/min] =  1.66667E-5 mol/second [mol/s]
        /// </summary>
        public static double MillimolPerMinute_2_MolPerSecond(double inVal)             => inVal * 1.66667E-5;
        /// <summary>
        /// mol/s -> mmol/min
        /// vv: 1.66667E-5 mol/second [mol/s] to 1 millimol/minute [mmol/min]
        /// </summary>
        public static double MolPerSecond_2_MillimolPerMinute(double inVal)             => inVal / 1.66667E-5;

        /// <summary>
        /// mmol/h -> mol/s
        /// 1 millimol/hour [mmol/h] =  2.7777777777778E-7 mol/second [mol/s]
        /// </summary>
        public static double MillimolPerHour_2_MolPerSecond(double inVal)               => inVal * 2.7777777777778E-7;
        /// <summary>
        /// mol/s -> mmol/h
        /// vv: 2.7777777777778E-7 mol/second [mol/s] to 1 millimol/hour [mmol/h]
        /// </summary>
        public static double MolPerSecond_2_MillimolPerHour(double inVal)               => inVal / 2.7777777777778E-7;

        /// <summary>
        /// mmol/d -> mol/s
        /// 1 millimol/day [mmol/d] =  1.1574074074074E-8 mol/second [mol/s]
        /// </summary>
        public static double MillimolPerDay_2_MolPerSecond(double inVal)                => inVal * 1.1574074074074E-8;
        /// <summary>
        /// mol/s -> mmol/d
        /// vv: 1.1574074074074E-8 mol/second [mol/s] to 1 millimol/day [mmol/d]
        /// </summary>
        public static double MolPerSecond_2_MillimolPerDay(double inVal)                => inVal / 1.1574074074074E-8;

        /// <summary>
        /// kmol/min -> mol/s
        /// 1 kilomol/minute [kmol/min] =  16.6666666667 mol/second [mol/s]
        /// </summary>
        public static double KilomolPerMinute_2_MolPerSecond(double inVal)              => inVal * 16.6666666667;
        /// <summary>
        /// mol/s -> kmol/min
        /// vv: 16.6666666667 mol/second [mol/s] to 1 kilomol/minute [kmol/min]
        /// </summary>
        public static double MolPerSecond_2_KilomolPerMinute(double inVal)              => inVal / 16.6666666667;

        /// <summary>
        /// kmol/h -> mol/s
        /// 1 kilomol/hour [kmol/h] =  0.2777777778 mol/second [mol/s]
        /// </summary>
        public static double KilomolPerHour_2_MolPerSecond(double inVal)                => inVal * 0.2777777778;
        /// <summary>
        /// mol/s -> kmol/h
        /// vv: 0.2777777778 mol/second [mol/s] to 1 kilomol/hour [kmol/h]
        /// </summary>
        public static double MolPerSecond_2_KilomolPerHour(double inVal)                => inVal / 0.2777777778;

        /// <summary>
        /// kmol/d -> mol/s
        /// 1 kilomol/day [kmol/d] =  0.0115740741 mol/second [mol/s]
        /// </summary>
        public static double KilomolPerDay_2_MolPerSecond(double inVal)                 => inVal * 0.0115740741;
        /// <summary>
        /// mol/s -> kmol/d
        /// vv: 0.0115740741 mol/second [mol/s] to 1 kilomol/day [kmol/d]
        /// </summary>
        public static double MolPerSecond_2_KilomolPerDay(double inVal)                 => inVal / 0.0115740741;

        #endregion
    }
}
