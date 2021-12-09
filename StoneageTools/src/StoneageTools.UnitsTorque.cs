
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region torque, base: newton meter
        /// <summary>
        /// N*cm -> N*m
        /// 1 newton centimeter [N*cm] =  0.01 newton meter [N*m]
        /// </summary>
        public static double NewtonCentimeter_2_NewtonMeter(double inVal)               => inVal * 0.01;
        /// <summary>
        /// N*m -> N*cm
        /// vv: 0.01 newton meter [N*m] to 1 newton centimeter [N*cm]
        /// </summary>
        public static double NewtonMeter_2_NewtonCentimeter(double inVal)               => inVal / 0.01;

        /// <summary>
        /// N*mm -> N*m
        /// 1 newton millimeter [N*mm] =  0.001 newton meter [N*m]
        /// </summary>
        public static double NewtonMillimeter_2_NewtonMeter(double inVal)               => inVal * 0.001;
        /// <summary>
        /// N*m -> N*mm
        /// vv: 0.001 newton meter [N*m] to 1 newton millimeter [N*mm]
        /// </summary>
        public static double NewtonMeter_2_NewtonMillimeter(double inVal)               => inVal / 0.001;

        /// <summary>
        /// dyn*m -> N*m
        /// 1 dyne meter [dyn*m] =  1.0E-5 newton meter [N*m]
        /// </summary>
        public static double DyneMeter_2_NewtonMeter(double inVal)                      => inVal * 1.0E-5;
        /// <summary>
        /// N*m -> dyn*m
        /// vv: 1.0E-5 newton meter [N*m] to 1 dyne meter [dyn*m]
        /// </summary>
        public static double NewtonMeter_2_DyneMeter(double inVal)                      => inVal / 1.0E-5;

        /// <summary>
        /// dyn*cm -> N*m
        /// 1 dyne centimeter [dyn*cm] =  1.0E-7 newton meter [N*m]
        /// </summary>
        public static double DyneCentimeter_2_NewtonMeter(double inVal)                 => inVal * 1.0E-7;
        /// <summary>
        /// N*m -> dyn*cm
        /// vv: 1.0E-7 newton meter [N*m] to 1 dyne centimeter [dyn*cm]
        /// </summary>
        public static double NewtonMeter_2_DyneCentimeter(double inVal)                 => inVal / 1.0E-7;

        /// <summary>
        /// dyn*mm -> N*m
        /// 1 dyne millimeter [dyn*mm] =  1.0E-8 newton meter [N*m]
        /// </summary>
        public static double DyneMillimeter_2_NewtonMeter(double inVal)                 => inVal * 1.0E-8;
        /// <summary>
        /// N*m -> dyn*mm
        /// vv: 1.0E-8 newton meter [N*m] to 1 dyne millimeter [dyn*mm]
        /// </summary>
        public static double NewtonMeter_2_DyneMillimeter(double inVal)                 => inVal / 1.0E-8;

        /// <summary>
        /// KilogramForceCentimeter -> N*m
        /// 1 kilogram-force centimeter =  0.0980665 newton meter [N*m]
        /// </summary>
        public static double KilogramForceCentimeter_2_NewtonMeter(double inVal)        => inVal * 0.0980665;
        /// <summary>
        /// N*m -> KilogramForceCentimeter
        /// vv: 0.0980665 newton meter [N*m] to 1 kilogram-force centimeter
        /// </summary>
        public static double NewtonMeter_2_KilogramForceCentimeter(double inVal)        => inVal / 0.0980665;

        /// <summary>
        /// KilogramForceMillimeter -> N*m
        /// 1 kilogram-force millimeter =  0.00980665 newton meter [N*m]
        /// </summary>
        public static double KilogramForceMillimeter_2_NewtonMeter(double inVal)        => inVal * 0.00980665;
        /// <summary>
        /// N*m -> KilogramForceMillimeter
        /// vv: 0.00980665 newton meter [N*m] to 1 kilogram-force millimeter
        /// </summary>
        public static double NewtonMeter_2_KilogramForceMillimeter(double inVal)        => inVal / 0.00980665;

        /// <summary>
        /// gf*m -> N*m
        /// 1 gram-force meter [gf*m] =  0.00980665 newton meter [N*m]
        /// </summary>
        public static double GramForceMeter_2_NewtonMeter(double inVal)                 => inVal * 0.00980665;
        /// <summary>
        /// N*m -> gf*m
        /// vv: 0.00980665 newton meter [N*m] to 1 gram-force meter [gf*m]
        /// </summary>
        public static double NewtonMeter_2_GramForceMeter(double inVal)                 => inVal / 0.00980665;

        /// <summary>
        /// GramForceMillimeter -> N*m
        /// 1 gram-force millimeter =  9.80665E-6 newton meter [N*m]
        /// </summary>
        public static double GramForceMillimeter_2_NewtonMeter(double inVal)            => inVal * 9.80665E-6;
        /// <summary>
        /// N*m -> GramForceMillimeter
        /// vv: 9.80665E-6 newton meter [N*m] to 1 gram-force millimeter
        /// </summary>
        public static double NewtonMeter_2_GramForceMillimeter(double inVal)            => inVal / 9.80665E-6;

        /// <summary>
        /// ozf*ft -> N*m
        /// 1 ounce-force foot [ozf*ft] =  0.084738624 newton meter [N*m]
        /// </summary>
        public static double OunceForceFoot_2_NewtonMeter(double inVal)                 => inVal * 0.084738624;
        /// <summary>
        /// N*m -> ozf*ft
        /// vv: 0.084738624 newton meter [N*m] to 1 ounce-force foot [ozf*ft]
        /// </summary>
        public static double NewtonMeter_2_OunceForceFoot(double inVal)                 => inVal / 0.084738624;

        /// <summary>
        /// ozf*in -> N*m
        /// 1 ounce-force inch [ozf*in] =  0.007061552 newton meter [N*m]
        /// </summary>
        public static double OunceForceInch_2_NewtonMeter(double inVal)                 => inVal * 0.007061552;
        /// <summary>
        /// N*m -> ozf*in
        /// vv: 0.007061552 newton meter [N*m] to 1 ounce-force inch [ozf*in]
        /// </summary>
        public static double NewtonMeter_2_OunceForceInch(double inVal)                 => inVal / 0.007061552;

        /// <summary>
        /// lbf*in -> N*m
        /// 1 pound-force inch [lbf*in] =  0.1129848333 newton meter [N*m]
        /// </summary>
        public static double PoundForceInch_2_NewtonMeter(double inVal)                 => inVal * 0.1129848333;
        /// <summary>
        /// N*m -> lbf*in
        /// vv: 0.1129848333 newton meter [N*m] to 1 pound-force inch [lbf*in]
        /// </summary>
        public static double NewtonMeter_2_PoundForceInch(double inVal)                 => inVal / 0.1129848333;

        #endregion
    }
}
