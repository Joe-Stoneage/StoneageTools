
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region surface tension, base: newton/meter

        /// <summary>
        /// mN/m -> N/m
        /// 1 millinewnon/meter [mN/m] =  0.001 newton/meter [N/m]
        /// </summary>
        public static double MillinewnonPerMeter_2_NewtonPerMeter(double inVal)         => inVal * 0.001;
        /// <summary>
        /// N/m -> mN/m
        /// vv: 0.001 newton/meter [N/m] to 1 millinewnon/meter [mN/m]
        /// </summary>
        public static double NewtonPerMeter_2_MillinewnonPerMeter(double inVal)         => inVal / 0.001;

        /// <summary>
        /// GramForcePerCentimeter -> N/m
        /// 1 gram-force/centimeter =  0.980665 newton/meter [N/m]
        /// </summary>
        public static double GramForcePerCentimeter_2_NewtonPerMeter(double inVal)      => inVal * 0.980665;
        /// <summary>
        /// N/m -> GramForcePerCentimeter
        /// vv: 0.980665 newton/meter [N/m] to 1 gram-force/centimeter
        /// </summary>
        public static double NewtonPerMeter_2_GramForcePerCentimeter(double inVal)      => inVal / 0.980665;

        /// <summary>
        /// dyn/cm -> N/m
        /// 1 dyne/centimeter [dyn/cm] =  0.001 newton/meter [N/m]
        /// </summary>
        public static double DynePerCentimeter_2_NewtonPerMeter(double inVal)           => inVal * 0.001;
        /// <summary>
        /// N/m -> dyn/cm
        /// vv: 0.001 newton/meter [N/m] to 1 dyne/centimeter [dyn/cm]
        /// </summary>
        public static double NewtonPerMeter_2_DynePerCentimeter(double inVal)           => inVal / 0.001;

        /// <summary>
        /// ErgPerSquareCentimeter -> N/m
        /// 1 erg/square centimeter =  0.001 newton/meter [N/m]
        /// </summary>
        public static double ErgPerSquareCentimeter_2_NewtonPerMeter(double inVal)      => inVal * 0.001;
        /// <summary>
        /// N/m -> ErgPerSquareCentimeter
        /// vv: 0.001 newton/meter [N/m] to 1 erg/square centimeter
        /// </summary>
        public static double NewtonPerMeter_2_ErgPerSquareCentimeter(double inVal)      => inVal / 0.001;

        /// <summary>
        /// ErgPerSquareMillimeter -> N/m
        /// 1 erg/square millimeter =  0.1 newton/meter [N/m]
        /// </summary>
        public static double ErgPerSquareMillimeter_2_NewtonPerMeter(double inVal)      => inVal * 0.1;
        /// <summary>
        /// N/m -> ErgPerSquareMillimeter
        /// vv: 0.1 newton/meter [N/m] to 1 erg/square millimeter
        /// </summary>
        public static double NewtonPerMeter_2_ErgPerSquareMillimeter(double inVal)      => inVal / 0.1;

        /// <summary>
        /// pdl/in -> N/m
        /// 1 poundal/inch [pdl/in] =  5.443108491 newton/meter [N/m]
        /// </summary>
        public static double PoundalPerInch_2_NewtonPerMeter(double inVal)              => inVal * 5.443108491;
        /// <summary>
        /// N/m -> pdl/in
        /// vv: 5.443108491 newton/meter [N/m] to 1 poundal/inch [pdl/in]
        /// </summary>
        public static double NewtonPerMeter_2_PoundalPerInch(double inVal)              => inVal / 5.443108491;

        /// <summary>
        /// lbf/in -> N/m
        /// 1 pound-force/inch [lbf/in] =  175.1268369864 newton/meter [N/m]
        /// </summary>
        public static double PoundForcePerInch_2_NewtonPerMeter(double inVal)           => inVal * 175.1268369864;
        /// <summary>
        /// N/m -> lbf/in
        /// vv: 175.1268369864 newton/meter [N/m] to 1 pound-force/inch [lbf/in]
        /// </summary>
        public static double NewtonPerMeter_2_PoundForcePerInch(double inVal)           => inVal / 175.1268369864;

        #endregion
    }
}
