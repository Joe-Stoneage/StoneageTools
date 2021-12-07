
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region fuel consumption , base: meter/liter

        /// <summary>
        /// Em/L -> m/L
        /// 1 exameter/liter [Em/L] to vv: 1.0E+18 meter/liter [m/L]
        /// </summary>
        public static double ExameterPerLiter_2_MeterPerLiter(double inVal)             => inVal * 1.0E+18;
        /// <summary>
        /// m/L -> Em/L
        /// vv: 1.0E+18 meter/liter [m/L] to 1 exameter/liter [Em/L]
        /// </summary>
        public static double MeterPerLiter_2_ExameterPerLiter(double inVal)             => inVal / 1.0E+18;

        /// <summary>
        /// Pm/L -> m/L
        /// 1 petameter/liter [Pm/L] to vv: 1.0E+15 meter/liter [m/L]
        /// </summary>
        public static double PetameterPerLiter_2_MeterPerLiter(double inVal)            => inVal * 1.0E+15;
        /// <summary>
        /// m/L -> Pm/L
        /// vv: 1.0E+15 meter/liter [m/L] to 1 petameter/liter [Pm/L]
        /// </summary>
        public static double MeterPerLiter_2_PetameterPerLiter(double inVal)            => inVal / 1.0E+15;

        /// <summary>
        /// Tm/L -> m/L
        /// 1 terameter/liter [Tm/L] to vv: 1000000000000 meter/liter [m/L]
        /// </summary>
        public static double TerameterPerLiter_2_MeterPerLiter(double inVal)            => inVal * 1000000000000;
        /// <summary>
        /// m/L -> Tm/L
        /// vv: 1000000000000 meter/liter [m/L] to 1 terameter/liter [Tm/L]
        /// </summary>
        public static double MeterPerLiter_2_TerameterPerLiter(double inVal)            => inVal / 1000000000000;

        /// <summary>
        /// Gm/L -> m/L
        /// 1 gigameter/liter [Gm/L] to vv: 1000000000 meter/liter [m/L]
        /// </summary>
        public static double GigameterPerLiter_2_MeterPerLiter(double inVal)            => inVal * 1000000000;
        /// <summary>
        /// m/L -> Gm/L
        /// vv: 1000000000 meter/liter [m/L] to 1 gigameter/liter [Gm/L]
        /// </summary>
        public static double MeterPerLiter_2_GigameterPerLiter(double inVal)            => inVal / 1000000000;

        /// <summary>
        /// Mm/L -> m/L
        /// 1 megameter/liter [Mm/L] to vv: 1000000 meter/liter [m/L]
        /// </summary>
        public static double MegameterPerLiter_2_MeterPerLiter(double inVal)            => inVal * 1000000;
        /// <summary>
        /// m/L -> Mm/L
        /// vv: 1000000 meter/liter [m/L] to 1 megameter/liter [Mm/L]
        /// </summary>
        public static double MeterPerLiter_2_MegameterPerLiter(double inVal)            => inVal / 1000000;

        /// <summary>
        /// km/L -> m/L
        /// 1 kilometer/liter [km/L] to vv: 1000 meter/liter [m/L]
        /// </summary>
        public static double KilometerPerLiter_2_MeterPerLiter(double inVal)            => inVal * 1000;
        /// <summary>
        /// m/L -> km/L
        /// vv: 1000 meter/liter [m/L] to 1 kilometer/liter [km/L]
        /// </summary>
        public static double MeterPerLiter_2_KilometerPerLiter(double inVal)            => inVal / 1000;

        /// <summary>
        /// hm/L -> m/L
        /// 1 hectometer/liter [hm/L] to vv: 100 meter/liter [m/L]
        /// </summary>
        public static double HectometerPerLiter_2_MeterPerLiter(double inVal)           => inVal * 100;
        /// <summary>
        /// m/L -> hm/L
        /// vv: 100 meter/liter [m/L] to 1 hectometer/liter [hm/L]
        /// </summary>
        public static double MeterPerLiter_2_HectometerPerLiter(double inVal)           => inVal / 100;

        /// <summary>
        /// dam/L -> m/L
        /// 1 dekameter/liter [dam/L] to vv: 10 meter/liter [m/L]
        /// </summary>
        public static double DekameterPerLiter_2_MeterPerLiter(double inVal)            => inVal * 10;
        /// <summary>
        /// m/L -> dam/L
        /// vv: 10 meter/liter [m/L] to 1 dekameter/liter [dam/L]
        /// </summary>
        public static double MeterPerLiter_2_DekameterPerLiter(double inVal)            => inVal / 10;

        /// <summary>
        /// cm/L -> m/L
        /// 1 centimeter/liter [cm/L] to vv: 0.01 meter/liter [m/L]
        /// </summary>
        public static double CentimeterPerLiter_2_MeterPerLiter(double inVal)           => inVal * 0.01;
        /// <summary>
        /// m/L -> cm/L
        /// vv: 0.01 meter/liter [m/L] to 1 centimeter/liter [cm/L]
        /// </summary>
        public static double MeterPerLiter_2_CentimeterPerLiter(double inVal)           => inVal / 0.01;

        /// <summary>
        /// mi/L -> m/L
        /// 1 mile (US)/liter [mi/L] to vv: 1609.344 meter/liter [m/L]
        /// </summary>
        public static double MileUSPerLiter_2_MeterPerLiter(double inVal)               => inVal * 1609.344;
        /// <summary>
        /// m/L -> mi/L
        /// vv: 1609.344 meter/liter [m/L] to 1 mile (US)/liter [mi/L]
        /// </summary>
        public static double MeterPerLiter_2_MileUSPerLiter(double inVal)               => inVal / 1609.344;

        /// <summary>
        /// n.mile/L -> m/L
        /// 1 nautical mile/liter [n.mile/L] to vv: 1853.24496 meter/liter [m/L]
        /// </summary>
        public static double NauticalMilePerLiter_2_MeterPerLiter(double inVal)         => inVal * 1853.24496;
        /// <summary>
        /// m/L -> n.mile/L
        /// vv: 1853.24496 meter/liter [m/L] to 1 nautical mile/liter [n.mile/L]
        /// </summary>
        public static double MeterPerLiter_2_NauticalMilePerLiter(double inVal)         => inVal / 1853.24496;

        /// <summary>
        /// NauticalMilePerGallonUS -> m/L
        /// 1 nautical mile/gallon (US) to vv: 489.5755247 meter/liter [m/L]
        /// </summary>
        public static double NauticalMilePerGallonUS_2_MeterPerLiter(double inVal)      => inVal * 489.5755247;
        /// <summary>
        /// m/L -> NauticalMilePerGallonUS
        /// vv: 489.5755247 meter/liter [m/L] to 1 nautical mile/gallon (US)
        /// </summary>
        public static double MeterPerLiter_2_NauticalMilePerGallonUS(double inVal)      => inVal / 489.5755247;

        /// <summary>
        /// KilometerPerGallonUS -> m/L
        /// 1 kilometer/gallon (US) to vv: 264.1720524 meter/liter [m/L]
        /// </summary>
        public static double KilometerPerGallonUS_2_MeterPerLiter(double inVal)         => inVal * 264.1720524;
        /// <summary>
        /// m/L -> KilometerPerGallonUS
        /// vv: 264.1720524 meter/liter [m/L] to 1 kilometer/gallon (US)
        /// </summary>
        public static double MeterPerLiter_2_KilometerPerGallonUS(double inVal)         => inVal / 264.1720524;

        /// <summary>
        /// MeterPerGallonUS -> m/L
        /// 1 meter/gallon (US) to vv: 0.2641720524 meter/liter [m/L]
        /// </summary>
        public static double MeterPerGallonUS_2_MeterPerLiter(double inVal)             => inVal * 0.2641720524;
        /// <summary>
        /// m/L -> MeterPerGallonUS
        /// vv: 0.2641720524 meter/liter [m/L] to 1 meter/gallon (US)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerGallonUS(double inVal)             => inVal / 0.2641720524;

        /// <summary>
        /// MeterPerGallonUK -> m/L
        /// 1 meter/gallon (UK) to vv: 0.2199687986 meter/liter [m/L]
        /// </summary>
        public static double MeterPerGallonUK_2_MeterPerLiter(double inVal)             => inVal * 0.2199687986;
        /// <summary>
        /// m/L -> MeterPerGallonUK
        /// vv: 0.2199687986 meter/liter [m/L] to 1 meter/gallon (UK)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerGallonUK(double inVal)             => inVal / 0.2199687986;

        /// <summary>
        /// MilePerGallonUS -> m/L
        /// 1 mile/gallon (US) to vv: 425.1437075 meter/liter [m/L]
        /// </summary>
        public static double MilePerGallonUS_2_MeterPerLiter(double inVal)              => inVal * 425.1437075;
        /// <summary>
        /// m/L -> MilePerGallonUS
        /// vv: 425.1437075 meter/liter [m/L] to 1 mile/gallon (US)
        /// </summary>
        public static double MeterPerLiter_2_MilePerGallonUS(double inVal)              => inVal / 425.1437075;

        /// <summary>
        /// MilePerGallonUK -> m/L
        /// 1 mile/gallon (UK) to vv: 354.00619 meter/liter [m/L]
        /// </summary>
        public static double MilePerGallonUK_2_MeterPerLiter(double inVal)              => inVal * 354.00619;
        /// <summary>
        /// m/L -> MilePerGallonUK
        /// vv: 354.00619 meter/liter [m/L] to 1 mile/gallon (UK)
        /// </summary>
        public static double MeterPerLiter_2_MilePerGallonUK(double inVal)              => inVal / 354.00619;

        /// <summary>
        /// m/m^3 -> m/L
        /// 1 meter/cubic meter [m/m^3] to vv: 0.001 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCubicMeter_2_MeterPerLiter(double inVal)           => inVal * 0.001;
        /// <summary>
        /// m/L -> m/m^3
        /// vv: 0.001 meter/liter [m/L] to 1 meter/cubic meter [m/m^3]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCubicMeter(double inVal)           => inVal / 0.001;

        /// <summary>
        /// MeterPerCubicCentimeter -> m/L
        /// 1 meter/cubic centimeter to vv: 1000 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCubicCentimeter_2_MeterPerLiter(double inVal)      => inVal * 1000;
        /// <summary>
        /// m/L -> MeterPerCubicCentimeter
        /// vv: 1000 meter/liter [m/L] to 1 meter/cubic centimeter
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCubicCentimeter(double inVal)      => inVal / 1000;

        /// <summary>
        /// m/yd^3 -> m/L
        /// 1 meter/cubic yard [m/yd^3] to vv: 0.0013079506 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCubicYard_2_MeterPerLiter(double inVal)            => inVal * 0.0013079506;
        /// <summary>
        /// m/L -> m/yd^3
        /// vv: 0.0013079506 meter/liter [m/L] to 1 meter/cubic yard [m/yd^3]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCubicYard(double inVal)            => inVal / 0.0013079506;

        /// <summary>
        /// m/ft^3 -> m/L
        /// 1 meter/cubic foot [m/ft^3] to vv: 0.0353146667 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCubicFoot_2_MeterPerLiter(double inVal)            => inVal * 0.0353146667;
        /// <summary>
        /// m/L -> m/ft^3
        /// vv: 0.0353146667 meter/liter [m/L] to 1 meter/cubic foot [m/ft^3]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCubicFoot(double inVal)            => inVal / 0.0353146667;

        /// <summary>
        /// m/in^3 -> m/L
        /// 1 meter/cubic inch [m/in^3] to vv: 61.02374409 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCubicInch_2_MeterPerLiter(double inVal)            => inVal * 61.02374409;
        /// <summary>
        /// m/L -> m/in^3
        /// vv: 61.02374409 meter/liter [m/L] to 1 meter/cubic inch [m/in^3]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCubicInch(double inVal)            => inVal / 61.02374409;

        /// <summary>
        /// MeterPerQuartUS -> m/L
        /// 1 meter/quart (US) to vv: 1.056688209 meter/liter [m/L]
        /// </summary>
        public static double MeterPerQuartUS_2_MeterPerLiter(double inVal)              => inVal * 1.056688209;
        /// <summary>
        /// m/L -> MeterPerQuartUS
        /// vv: 1.056688209 meter/liter [m/L] to 1 meter/quart (US)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerQuartUS(double inVal)              => inVal / 1.056688209;

        /// <summary>
        /// MeterPerQuartUK -> m/L
        /// 1 meter/quart (UK) to vv: 0.8798751948 meter/liter [m/L]
        /// </summary>
        public static double MeterPerQuartUK_2_MeterPerLiter(double inVal)              => inVal * 0.8798751948;
        /// <summary>
        /// m/L -> MeterPerQuartUK
        /// vv: 0.8798751948 meter/liter [m/L] to 1 meter/quart (UK)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerQuartUK(double inVal)              => inVal / 0.8798751948;

        /// <summary>
        /// m/pt (US) -> m/L
        /// 1 meter/pint (US) [m/pt (US)] to vv: 2.113376419 meter/liter [m/L]
        /// </summary>
        public static double MeterPerPintUS_2_MeterPerLiter(double inVal)               => inVal * 2.113376419;
        /// <summary>
        /// m/L -> m/pt (US)
        /// vv: 2.113376419 meter/liter [m/L] to 1 meter/pint (US) [m/pt (US)]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerPintUS(double inVal)               => inVal / 2.113376419;

        /// <summary>
        /// m/pt (UK) -> m/L
        /// 1 meter/pint (UK) [m/pt (UK)] to vv: 1.759750389 meter/liter [m/L]
        /// </summary>
        public static double MeterPerPintUK_2_MeterPerLiter(double inVal)               => inVal * 1.759750389;
        /// <summary>
        /// m/L -> m/pt (UK)
        /// vv: 1.759750389 meter/liter [m/L] to 1 meter/pint (UK) [m/pt (UK)]
        /// </summary>
        public static double MeterPerLiter_2_MeterPerPintUK(double inVal)               => inVal / 1.759750389;

        /// <summary>
        /// MeterPerCupUS -> m/L
        /// 1 meter/cup (US) to vv: 4.226752838 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCupUS_2_MeterPerLiter(double inVal)                => inVal * 4.226752838;
        /// <summary>
        /// m/L -> MeterPerCupUS
        /// vv: 4.226752838 meter/liter [m/L] to 1 meter/cup (US)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCupUS(double inVal)                => inVal / 4.226752838;

        /// <summary>
        /// MeterPerCupUK -> m/L
        /// 1 meter/cup (UK) to vv: 3.519500777 meter/liter [m/L]
        /// </summary>
        public static double MeterPerCupUK_2_MeterPerLiter(double inVal)                => inVal * 3.519500777;
        /// <summary>
        /// m/L -> MeterPerCupUK
        /// vv: 3.519500777 meter/liter [m/L] to 1 meter/cup (UK)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerCupUK(double inVal)                => inVal / 3.519500777;

        /// <summary>
        /// MeterPerFluidOunceUS -> m/L
        /// 1 meter/fluid ounce (US) to vv: 33.8140227 meter/liter [m/L]
        /// </summary>
        public static double MeterPerFluidOunceUS_2_MeterPerLiter(double inVal)         => inVal * 33.8140227;
        /// <summary>
        /// m/L -> MeterPerFluidOunceUS
        /// vv: 33.8140227 meter/liter [m/L] to 1 meter/fluid ounce (US)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerFluidOunceUS(double inVal)         => inVal / 33.8140227;

        /// <summary>
        /// MeterPerFluidOunceUK -> m/L
        /// 1 meter/fluid ounce (UK) to vv: 35.19500777 meter/liter [m/L]
        /// </summary>
        public static double MeterPerFluidOunceUK_2_MeterPerLiter(double inVal)         => inVal * 35.19500777;
        /// <summary>
        /// m/L -> MeterPerFluidOunceUK
        /// vv: 35.19500777 meter/liter [m/L] to 1 meter/fluid ounce (UK)
        /// </summary>
        public static double MeterPerLiter_2_MeterPerFluidOunceUK(double inVal)         => inVal / 35.19500777;

        /// <summary>
        /// L/m -> m/L
        /// 1 liter/meter [L/m] to vv: 1 meter/liter [m/L]
        /// </summary>
        public static double LiterPerMeter_2_MeterPerLiter(double inVal)                => inVal * 1;
        /// <summary>
        /// m/L -> L/m
        /// vv: 1 meter/liter [m/L] to 1 liter/meter [L/m]
        /// </summary>
        public static double MeterPerLiter_2_LiterPerMeter(double inVal)                => inVal / 1;

        /// <summary>
        /// L/100 km -> m/L
        /// 1 liter/100 km [L/100 km] to vv: 100000 meter/liter [m/L]
        /// </summary>
        public static double LiterPer100Km_2_MeterPerLiter(double inVal)                => inVal * 100000;
        /// <summary>
        /// m/L -> L/100 km
        /// vv: 100000 meter/liter [m/L] to 1 liter/100 km [L/100 km]
        /// </summary>
        public static double MeterPerLiter_2_LiterPer100Km(double inVal)                => inVal / 100000;

        /// <summary>
        /// GallonUSPerMile -> m/L
        /// 1 gallon (US)/mile to vv: 425.1437074976 meter/liter [m/L]
        /// </summary>
        public static double GallonUSPerMile_2_MeterPerLiter(double inVal)              => inVal * 425.1437074976;
        /// <summary>
        /// m/L -> GallonUSPerMile
        /// vv: 425.1437074976 meter/liter [m/L] to 1 gallon (US)/mile
        /// </summary>
        public static double MeterPerLiter_2_GallonUSPerMile(double inVal)              => inVal / 425.1437074976;

        /// <summary>
        /// GallonUSPer100Mi -> m/L
        /// 1 gallon (US)/100 mi to vv: 42514.370749763 meter/liter [m/L]
        /// </summary>
        public static double GallonUSPer100Mi_2_MeterPerLiter(double inVal)             => inVal * 42514.370749763;
        /// <summary>
        /// m/L -> GallonUSPer100Mi
        /// vv: 42514.370749763 meter/liter [m/L] to 1 gallon (US)/100 mi
        /// </summary>
        public static double MeterPerLiter_2_GallonUSPer100Mi(double inVal)             => inVal / 42514.370749763;

        /// <summary>
        /// GallonUKPerMile -> m/L
        /// 1 gallon (UK)/mile to vv: 354.0061899559 meter/liter [m/L]
        /// </summary>
        public static double GallonUKPerMile_2_MeterPerLiter(double inVal)              => inVal * 354.0061899559;
        /// <summary>
        /// m/L -> GallonUKPerMile
        /// vv: 354.0061899559 meter/liter [m/L] to 1 gallon (UK)/mile
        /// </summary>
        public static double MeterPerLiter_2_GallonUKPerMile(double inVal)              => inVal / 354.0061899559;

        /// <summary>
        /// GallonUKPer100Mi -> m/L
        /// 1 gallon (UK)/100 mi to vv: 35400.618995592 meter/liter [m/L]
        /// </summary>
        public static double GallonUKPer100Mi_2_MeterPerLiter(double inVal)             => inVal * 35400.618995592;
        /// <summary>
        /// m/L -> GallonUKPer100Mi
        /// vv: 35400.618995592 meter/liter [m/L] to 1 gallon (UK)/100 mi
        /// </summary>
        public static double MeterPerLiter_2_GallonUKPer100Mi(double inVal)             => inVal / 35400.618995592;

        #endregion
    }
}
