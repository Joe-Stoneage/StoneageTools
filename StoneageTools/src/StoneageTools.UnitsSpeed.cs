
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region speed, base: meter per second

        /// <summary>
        /// km/h -> m/s
        /// 1 kilometer/hour [km/h] =  0.2777777778 meter/second [m/s]
        /// </summary>
        public static double KilometerPerHour_2_MeterPerSecond(double inVal)            => inVal * 0.2777777778;
        /// <summary>
        /// m/s -> km/h
        /// vv: 0.2777777778 meter/second [m/s] to 1 kilometer/hour [km/h]
        /// </summary>
        public static double MeterPerSecond_2_KilometerPerHour(double inVal)            => inVal / 0.2777777778;

        /// <summary>
        /// mi/h -> m/s
        /// 1 mile/hour [mi/h] =  0.44704 meter/second [m/s]
        /// </summary>
        public static double MilePerHour_2_MeterPerSecond(double inVal)                 => inVal * 0.44704;
        /// <summary>
        /// m/s -> mi/h
        /// vv: 0.44704 meter/second [m/s] to 1 mile/hour [mi/h]
        /// </summary>
        public static double MeterPerSecond_2_MilePerHour(double inVal)                 => inVal / 0.44704;

        /// <summary>
        /// m/h -> m/s
        /// 1 meter/hour [m/h] =  0.0002777778 meter/second [m/s]
        /// </summary>
        public static double MeterPerHour_2_MeterPerSecond(double inVal)                => inVal * 0.0002777778;
        /// <summary>
        /// m/s -> m/h
        /// vv: 0.0002777778 meter/second [m/s] to 1 meter/hour [m/h]
        /// </summary>
        public static double MeterPerSecond_2_MeterPerHour(double inVal)                => inVal / 0.0002777778;

        /// <summary>
        /// m/min -> m/s
        /// 1 meter/minute [m/min] =  0.0166666667 meter/second [m/s]
        /// </summary>
        public static double MeterPerMinute_2_MeterPerSecond(double inVal)              => inVal * 0.0166666667;
        /// <summary>
        /// m/s -> m/min
        /// vv: 0.0166666667 meter/second [m/s] to 1 meter/minute [m/min]
        /// </summary>
        public static double MeterPerSecond_2_MeterPerMinute(double inVal)              => inVal / 0.0166666667;

        /// <summary>
        /// km/min -> m/s
        /// 1 kilometer/minute [km/min] =  16.6666666667 meter/second [m/s]
        /// </summary>
        public static double KilometerPerMinute_2_MeterPerSecond(double inVal)          => inVal * 16.6666666667;
        /// <summary>
        /// m/s -> km/min
        /// vv: 16.6666666667 meter/second [m/s] to 1 kilometer/minute [km/min]
        /// </summary>
        public static double MeterPerSecond_2_KilometerPerMinute(double inVal)          => inVal / 16.6666666667;

        /// <summary>
        /// km/s -> m/s
        /// 1 kilometer/second [km/s] =  1000 meter/second [m/s]
        /// </summary>
        public static double KilometerPerSecond_2_MeterPerSecond(double inVal)          => inVal * 1000;
        /// <summary>
        /// m/s -> km/s
        /// vv: 1000 meter/second [m/s] to 1 kilometer/second [km/s]
        /// </summary>
        public static double MeterPerSecond_2_KilometerPerSecond(double inVal)          => inVal / 1000;

        /// <summary>
        /// cm/h -> m/s
        /// 1 centimeter/hour [cm/h] =  2.7777777777778E-6 meter/second [m/s]
        /// </summary>
        public static double CentimeterPerHour_2_MeterPerSecond(double inVal)           => inVal * 2.7777777777778E-6;
        /// <summary>
        /// m/s -> cm/h
        /// vv: 2.7777777777778E-6 meter/second [m/s] to 1 centimeter/hour [cm/h]
        /// </summary>
        public static double MeterPerSecond_2_CentimeterPerHour(double inVal)           => inVal / 2.7777777777778E-6;

        /// <summary>
        /// cm/min -> m/s
        /// 1 centimeter/minute [cm/min] =  0.0001666667 meter/second [m/s]
        /// </summary>
        public static double CentimeterPerMinute_2_MeterPerSecond(double inVal)         => inVal * 0.0001666667;
        /// <summary>
        /// m/s -> cm/min
        /// vv: 0.0001666667 meter/second [m/s] to 1 centimeter/minute [cm/min]
        /// </summary>
        public static double MeterPerSecond_2_CentimeterPerMinute(double inVal)         => inVal / 0.0001666667;

        /// <summary>
        /// cm/s -> m/s
        /// 1 centimeter/second [cm/s] =  0.01 meter/second [m/s]
        /// </summary>
        public static double CentimeterPerSecond_2_MeterPerSecond(double inVal)         => inVal * 0.01;
        /// <summary>
        /// m/s -> cm/s
        /// vv: 0.01 meter/second [m/s] to 1 centimeter/second [cm/s]
        /// </summary>
        public static double MeterPerSecond_2_CentimeterPerSecond(double inVal)         => inVal / 0.01;

        /// <summary>
        /// mm/h -> m/s
        /// 1 millimeter/hour [mm/h] =  2.7777777777778E-7 meter/second [m/s]
        /// </summary>
        public static double MillimeterPerHour_2_MeterPerSecond(double inVal)           => inVal * 2.7777777777778E-7;
        /// <summary>
        /// m/s -> mm/h
        /// vv: 2.7777777777778E-7 meter/second [m/s] to 1 millimeter/hour [mm/h]
        /// </summary>
        public static double MeterPerSecond_2_MillimeterPerHour(double inVal)           => inVal / 2.7777777777778E-7;

        /// <summary>
        /// mm/min -> m/s
        /// 1 millimeter/minute [mm/min] =  1.66667E-5 meter/second [m/s]
        /// </summary>
        public static double MillimeterPerMinute_2_MeterPerSecond(double inVal)         => inVal * 1.66667E-5;
        /// <summary>
        /// m/s -> mm/min
        /// vv: 1.66667E-5 meter/second [m/s] to 1 millimeter/minute [mm/min]
        /// </summary>
        public static double MeterPerSecond_2_MillimeterPerMinute(double inVal)         => inVal / 1.66667E-5;

        /// <summary>
        /// mm/s -> m/s
        /// 1 millimeter/second [mm/s] =  0.001 meter/second [m/s]
        /// </summary>
        public static double MillimeterPerSecond_2_MeterPerSecond(double inVal)         => inVal * 0.001;
        /// <summary>
        /// m/s -> mm/s
        /// vv: 0.001 meter/second [m/s] to 1 millimeter/second [mm/s]
        /// </summary>
        public static double MeterPerSecond_2_MillimeterPerSecond(double inVal)         => inVal / 0.001;

        /// <summary>
        /// ft/h -> m/s
        /// 1 foot/hour [ft/h] =  8.46667E-5 meter/second [m/s]
        /// </summary>
        public static double FootPerHour_2_MeterPerSecond(double inVal)                 => inVal * 8.46667E-5;
        /// <summary>
        /// m/s -> ft/h
        /// vv: 8.46667E-5 meter/second [m/s] to 1 foot/hour [ft/h]
        /// </summary>
        public static double MeterPerSecond_2_FootPerHour(double inVal)                 => inVal / 8.46667E-5;

        /// <summary>
        /// ft/min -> m/s
        /// 1 foot/minute [ft/min] =  0.00508 meter/second [m/s]
        /// </summary>
        public static double FootPerMinute_2_MeterPerSecond(double inVal)               => inVal * 0.00508;
        /// <summary>
        /// m/s -> ft/min
        /// vv: 0.00508 meter/second [m/s] to 1 foot/minute [ft/min]
        /// </summary>
        public static double MeterPerSecond_2_FootPerMinute(double inVal)               => inVal / 0.00508;

        /// <summary>
        /// ft/s -> m/s
        /// 1 foot/second [ft/s] =  0.3048 meter/second [m/s]
        /// </summary>
        public static double FootPerSecond_2_MeterPerSecond(double inVal)               => inVal * 0.3048;
        /// <summary>
        /// m/s -> ft/s
        /// vv: 0.3048 meter/second [m/s] to 1 foot/second [ft/s]
        /// </summary>
        public static double MeterPerSecond_2_FootPerSecond(double inVal)               => inVal / 0.3048;

        /// <summary>
        /// yd/h -> m/s
        /// 1 yard/hour [yd/h] =  0.000254 meter/second [m/s]
        /// </summary>
        public static double YardPerHour_2_MeterPerSecond(double inVal)                 => inVal * 0.000254;
        /// <summary>
        /// m/s -> yd/h
        /// vv: 0.000254 meter/second [m/s] to 1 yard/hour [yd/h]
        /// </summary>
        public static double MeterPerSecond_2_YardPerHour(double inVal)                 => inVal / 0.000254;

        /// <summary>
        /// yd/min -> m/s
        /// 1 yard/minute [yd/min] =  0.01524 meter/second [m/s]
        /// </summary>
        public static double YardPerMinute_2_MeterPerSecond(double inVal)               => inVal * 0.01524;
        /// <summary>
        /// m/s -> yd/min
        /// vv: 0.01524 meter/second [m/s] to 1 yard/minute [yd/min]
        /// </summary>
        public static double MeterPerSecond_2_YardPerMinute(double inVal)               => inVal / 0.01524;

        /// <summary>
        /// yd/s -> m/s
        /// 1 yard/second [yd/s] =  0.9144 meter/second [m/s]
        /// </summary>
        public static double YardPerSecond_2_MeterPerSecond(double inVal)               => inVal * 0.9144;
        /// <summary>
        /// m/s -> yd/s
        /// vv: 0.9144 meter/second [m/s] to 1 yard/second [yd/s]
        /// </summary>
        public static double MeterPerSecond_2_YardPerSecond(double inVal)               => inVal / 0.9144;

        /// <summary>
        /// mi/min -> m/s
        /// 1 mile/minute [mi/min] =  26.8224 meter/second [m/s]
        /// </summary>
        public static double MilePerMinute_2_MeterPerSecond(double inVal)               => inVal * 26.8224;
        /// <summary>
        /// m/s -> mi/min
        /// vv: 26.8224 meter/second [m/s] to 1 mile/minute [mi/min]
        /// </summary>
        public static double MeterPerSecond_2_MilePerMinute(double inVal)               => inVal / 26.8224;

        /// <summary>
        /// mi/s -> m/s
        /// 1 mile/second [mi/s] =  1609.344 meter/second [m/s]
        /// </summary>
        public static double MilePerSecond_2_MeterPerSecond(double inVal)               => inVal * 1609.344;
        /// <summary>
        /// m/s -> mi/s
        /// vv: 1609.344 meter/second [m/s] to 1 mile/second [mi/s]
        /// </summary>
        public static double MeterPerSecond_2_MilePerSecond(double inVal)               => inVal / 1609.344;

        /// <summary>
        /// kt, kn -> m/s
        /// 1 knot [kt, kn] =  0.5144444444 meter/second [m/s]
        /// </summary>
        public static double Knot_2_MeterPerSecond(double inVal)                        => inVal * 0.5144444444;
        /// <summary>
        /// m/s -> kt, kn
        /// vv: 0.5144444444 meter/second [m/s] to 1 knot [kt, kn]
        /// </summary>
        public static double MeterPerSecond_2_Knot(double inVal)                        => inVal / 0.5144444444;

        /// <summary>
        /// kt (UK) -> m/s
        /// 1 knot (UK) [kt (UK)] =  0.5147733333 meter/second [m/s]
        /// </summary>
        public static double KnotUK_2_MeterPerSecond(double inVal)                      => inVal * 0.5147733333;
        /// <summary>
        /// m/s -> kt (UK)
        /// vv: 0.5147733333 meter/second [m/s] to 1 knot (UK) [kt (UK)]
        /// </summary>
        public static double MeterPerSecond_2_KnotUK(double inVal)                      => inVal / 0.5147733333;

        /// <summary>
        /// VelocityOfLightInVacuum -> m/s
        /// 1 Velocity of light in vacuum =  299792458 meter/second [m/s]
        /// </summary>
        public static double VelocityOfLightInVacuum_2_MeterPerSecond(double inVal)     => inVal * 299792458;
        /// <summary>
        /// m/s -> VelocityOfLightInVacuum
        /// vv: 299792458 meter/second [m/s] to 1 Velocity of light in vacuum
        /// </summary>
        public static double MeterPerSecond_2_VelocityOfLightInVacuum(double inVal)     => inVal / 299792458;

        /// <summary>
        /// CosmicVelocityFirst -> m/s
        /// 1 Cosmic velocity - first =  7899.9999999999 meter/second [m/s]
        /// </summary>
        public static double CosmicVelocityFirst_2_MeterPerSecond(double inVal)         => inVal * 7899.9999999999;
        /// <summary>
        /// m/s -> CosmicVelocityFirst
        /// vv: 7899.9999999999 meter/second [m/s] to 1 Cosmic velocity - first
        /// </summary>
        public static double MeterPerSecond_2_CosmicVelocityFirst(double inVal)         => inVal / 7899.9999999999;

        /// <summary>
        /// CosmicVelocitySecond -> m/s
        /// 1 Cosmic velocity - second =  11200 meter/second [m/s]
        /// </summary>
        public static double CosmicVelocitySecond_2_MeterPerSecond(double inVal)        => inVal * 11200;
        /// <summary>
        /// m/s -> CosmicVelocitySecond
        /// vv: 11200 meter/second [m/s] to 1 Cosmic velocity - second
        /// </summary>
        public static double MeterPerSecond_2_CosmicVelocitySecond(double inVal)        => inVal / 11200;

        /// <summary>
        /// CosmicVelocityThird -> m/s
        /// 1 Cosmic velocity - third =  16670 meter/second [m/s]
        /// </summary>
        public static double CosmicVelocityThird_2_MeterPerSecond(double inVal)         => inVal * 16670;
        /// <summary>
        /// m/s -> CosmicVelocityThird
        /// vv: 16670 meter/second [m/s] to 1 Cosmic velocity - third
        /// </summary>
        public static double MeterPerSecond_2_CosmicVelocityThird(double inVal)         => inVal / 16670;

        /// <summary>
        /// EarthVelocity -> m/s
        /// 1 Earth's velocity =  29765 meter/second [m/s]
        /// </summary>
        public static double EarthVelocity_2_MeterPerSecond(double inVal)               => inVal * 29765;
        /// <summary>
        /// m/s -> EarthVelocity
        /// vv: 29765 meter/second [m/s] to 1 Earth's velocity
        /// </summary>
        public static double MeterPerSecond_2_EarthVelocity(double inVal)               => inVal / 29765;

        /// <summary>
        /// VelocityOfSoundInPureWater -> m/s
        /// 1 Velocity of sound in pure water =  1482.6999999998 meter/second [m/s]
        /// </summary>
        public static double VelocityOfSoundInPureWater_2_MeterPerSecond(double inVal)  => inVal * 1482.6999999998;
        /// <summary>
        /// m/s -> VelocityOfSoundInPureWater
        /// vv: 1482.6999999998 meter/second [m/s] to 1 Velocity of sound in pure water
        /// </summary>
        public static double MeterPerSecond_2_VelocityOfSoundInPureWater(double inVal)  => inVal / 1482.6999999998;

        /// <summary>
        /// VelocityOfSoundInSeaWater20DegC,10MeterDeep -> m/s
        /// 1 Velocity of sound in sea water (20°C, 10 meter deep) =  1521.6 meter/second [m/s]
        /// </summary>
        public static double VelocityOfSoundInSeaWater20DegC10MeterDeep_2_MeterPerSecond(double inVal)=> inVal * 1521.6;
        /// <summary>
        /// m/s -> VelocityOfSoundInSeaWater20DegC,10MeterDeep
        /// vv: 1521.6 meter/second [m/s] to 1 Velocity of sound in sea water (20°C, 10 meter deep)
        /// </summary>
        public static double MeterPerSecond_2_VelocityOfSoundInSeaWater20DegC10MeterDeep(double inVal)=> inVal / 1521.6;

        /// <summary>
        /// Mach20DegC,1Atm -> m/s
        /// 1 Mach (20°C, 1 atm) =  343.6 meter/second [m/s]
        /// </summary>
        public static double Mach20DegC1Atm_2_MeterPerSecond(double inVal)             => inVal * 343.6;
        /// <summary>
        /// m/s -> Mach20DegC,1Atm
        /// vv: 343.6 meter/second [m/s] to 1 Mach (20°C, 1 atm)
        /// </summary>
        public static double MeterPerSecond_2_Mach20DegC1Atm(double inVal)             => inVal / 343.6;

        /// <summary>
        /// MachSIStandard -> m/s
        /// 1 Mach (SI standard) =  295.0464000003 meter/second [m/s]
        /// </summary>
        public static double MachSIStandard_2_MeterPerSecond(double inVal)              => inVal * 295.0464000003;
        /// <summary>
        /// m/s -> MachSIStandard
        /// vv: 295.0464000003 meter/second [m/s] to 1 Mach (SI standard)
        /// </summary>
        public static double MeterPerSecond_2_MachSIStandard(double inVal)              => inVal / 295.0464000003;

        #endregion
    }
}
