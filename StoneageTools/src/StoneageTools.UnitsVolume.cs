
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region volume, base: cubic meter

        /// <summary>
        /// km^3 -> m^3
        /// 1 cubic kilometer [km^3] to vv: 1000000000 cubic meter [m^3]
        /// </summary>
        public static double CubicKilometer_2_CubicMeter(double inVal)                  => inVal * 1000000000;
        /// <summary>
        /// m^3 -> km^3
        /// vv: 1000000000 cubic meter [m^3] to 1 cubic kilometer [km^3]
        /// </summary>
        public static double CubicMeter_2_CubicKilometer(double inVal)                  => inVal / 1000000000;

        /// <summary>
        /// cm^3 -> m^3
        /// 1 cubic centimeter [cm^3] to vv: 1.0E-6 cubic meter [m^3]
        /// </summary>
        public static double CubicCentimeter_2_CubicMeter(double inVal)                 => inVal * 1.0E-6;
        /// <summary>
        /// m^3 -> cm^3
        /// vv: 1.0E-6 cubic meter [m^3] to 1 cubic centimeter [cm^3]
        /// </summary>
        public static double CubicMeter_2_CubicCentimeter(double inVal)                 => inVal / 1.0E-6;

        /// <summary>
        /// mm^3 -> m^3
        /// 1 cubic millimeter [mm^3] to vv: 1.0E-9 cubic meter [m^3]
        /// </summary>
        public static double CubicMillimeter_2_CubicMeter(double inVal)                 => inVal * 1.0E-9;
        /// <summary>
        /// m^3 -> mm^3
        /// vv: 1.0E-9 cubic meter [m^3] to 1 cubic millimeter [mm^3]
        /// </summary>
        public static double CubicMeter_2_CubicMillimeter(double inVal)                 => inVal / 1.0E-9;

        /// <summary>
        /// L, l -> m^3
        /// 1 liter [L, l] to vv: 0.001 cubic meter [m^3]
        /// </summary>
        public static double Liter_2_CubicMeter(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// m^3 -> L, l
        /// vv: 0.001 cubic meter [m^3] to 1 liter [L, l]
        /// </summary>
        public static double CubicMeter_2_Liter(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// mL -> m^3
        /// 1 milliliter [mL] to vv: 1.0E-6 cubic meter [m^3]
        /// </summary>
        public static double Milliliter_2_CubicMeter(double inVal)                      => inVal * 1.0E-6;
        /// <summary>
        /// m^3 -> mL
        /// vv: 1.0E-6 cubic meter [m^3] to 1 milliliter [mL]
        /// </summary>
        public static double CubicMeter_2_Milliliter(double inVal)                      => inVal / 1.0E-6;

        /// <summary>
        /// gal (US) -> m^3
        /// 1 gallon (US) [gal (US)] to vv: 0.0037854118 cubic meter [m^3]
        /// </summary>
        public static double GallonUS_2_CubicMeter(double inVal)                        => inVal * 0.0037854118;
        /// <summary>
        /// m^3 -> gal (US)
        /// vv: 0.0037854118 cubic meter [m^3] to 1 gallon (US) [gal (US)]
        /// </summary>
        public static double CubicMeter_2_GallonUS(double inVal)                        => inVal / 0.0037854118;

        /// <summary>
        /// qt (US) -> m^3
        /// 1 quart (US) [qt (US)] to vv: 0.0009463529 cubic meter [m^3]
        /// </summary>
        public static double QuartUS_2_CubicMeter(double inVal)                         => inVal * 0.0009463529;
        /// <summary>
        /// m^3 -> qt (US)
        /// vv: 0.0009463529 cubic meter [m^3] to 1 quart (US) [qt (US)]
        /// </summary>
        public static double CubicMeter_2_QuartUS(double inVal)                         => inVal / 0.0009463529;

        /// <summary>
        /// pt (US) -> m^3
        /// 1 pint (US) [pt (US)] to vv: 0.0004731765 cubic meter [m^3]
        /// </summary>
        public static double PintUS_2_CubicMeter(double inVal)                          => inVal * 0.0004731765;
        /// <summary>
        /// m^3 -> pt (US)
        /// vv: 0.0004731765 cubic meter [m^3] to 1 pint (US) [pt (US)]
        /// </summary>
        public static double CubicMeter_2_PintUS(double inVal)                          => inVal / 0.0004731765;

        /// <summary>
        /// CupUS -> m^3
        /// 1 cup (US) to vv: 0.0002365882 cubic meter [m^3]
        /// </summary>
        public static double CupUS_2_CubicMeter(double inVal)                           => inVal * 0.0002365882;
        /// <summary>
        /// m^3 -> CupUS
        /// vv: 0.0002365882 cubic meter [m^3] to 1 cup (US)
        /// </summary>
        public static double CubicMeter_2_CupUS(double inVal)                           => inVal / 0.0002365882;

        /// <summary>
        /// TablespoonUS -> m^3
        /// 1 tablespoon (US) to vv: 1.47868E-5 cubic meter [m^3]
        /// </summary>
        public static double TablespoonUS_2_CubicMeter(double inVal)                    => inVal * 1.47868E-5;
        /// <summary>
        /// m^3 -> TablespoonUS
        /// vv: 1.47868E-5 cubic meter [m^3] to 1 tablespoon (US)
        /// </summary>
        public static double CubicMeter_2_TablespoonUS(double inVal)                    => inVal / 1.47868E-5;

        /// <summary>
        /// TeaspoonUS -> m^3
        /// 1 teaspoon (US) to vv: 4.92892159375E-6 cubic meter [m^3]
        /// </summary>
        public static double TeaspoonUS_2_CubicMeter(double inVal)                      => inVal * 4.92892159375E-6;
        /// <summary>
        /// m^3 -> TeaspoonUS
        /// vv: 4.92892159375E-6 cubic meter [m^3] to 1 teaspoon (US)
        /// </summary>
        public static double CubicMeter_2_TeaspoonUS(double inVal)                      => inVal / 4.92892159375E-6;

        /// <summary>
        /// mi^3 -> m^3
        /// 1 cubic mile [mi^3] to vv: 4168181825.4406 cubic meter [m^3]
        /// </summary>
        public static double CubicMile_2_CubicMeter(double inVal)                       => inVal * 4168181825.4406;
        /// <summary>
        /// m^3 -> mi^3
        /// vv: 4168181825.4406 cubic meter [m^3] to 1 cubic mile [mi^3]
        /// </summary>
        public static double CubicMeter_2_CubicMile(double inVal)                       => inVal / 4168181825.4406;

        /// <summary>
        /// yd^3 -> m^3
        /// 1 cubic yard [yd^3] to vv: 0.764554858 cubic meter [m^3]
        /// </summary>
        public static double CubicYard_2_CubicMeter(double inVal)                       => inVal * 0.764554858;
        /// <summary>
        /// m^3 -> yd^3
        /// vv: 0.764554858 cubic meter [m^3] to 1 cubic yard [yd^3]
        /// </summary>
        public static double CubicMeter_2_CubicYard(double inVal)                       => inVal / 0.764554858;

        /// <summary>
        /// ft^3 -> m^3
        /// 1 cubic foot [ft^3] to vv: 0.0283168466 cubic meter [m^3]
        /// </summary>
        public static double CubicFoot_2_CubicMeter(double inVal)                       => inVal * 0.0283168466;
        /// <summary>
        /// m^3 -> ft^3
        /// vv: 0.0283168466 cubic meter [m^3] to 1 cubic foot [ft^3]
        /// </summary>
        public static double CubicMeter_2_CubicFoot(double inVal)                       => inVal / 0.0283168466;

        /// <summary>
        /// in^3 -> m^3
        /// 1 cubic inch [in^3] to vv: 1.63871E-5 cubic meter [m^3]
        /// </summary>
        public static double CubicInch_2_CubicMeter(double inVal)                       => inVal * 1.63871E-5;
        /// <summary>
        /// m^3 -> in^3
        /// vv: 1.63871E-5 cubic meter [m^3] to 1 cubic inch [in^3]
        /// </summary>
        public static double CubicMeter_2_CubicInch(double inVal)                       => inVal / 1.63871E-5;

        /// <summary>
        /// dm^3 -> m^3
        /// 1 cubic decimeter [dm^3] to vv: 0.001 cubic meter [m^3]
        /// </summary>
        public static double CubicDecimeter_2_CubicMeter(double inVal)                  => inVal * 0.001;
        /// <summary>
        /// m^3 -> dm^3
        /// vv: 0.001 cubic meter [m^3] to 1 cubic decimeter [dm^3]
        /// </summary>
        public static double CubicMeter_2_CubicDecimeter(double inVal)                  => inVal / 0.001;

        /// <summary>
        /// EL -> m^3
        /// 1 exaliter [EL] to vv: 1.0E+15 cubic meter [m^3]
        /// </summary>
        public static double Exaliter_2_CubicMeter(double inVal)                        => inVal * 1.0E+15;
        /// <summary>
        /// m^3 -> EL
        /// vv: 1.0E+15 cubic meter [m^3] to 1 exaliter [EL]
        /// </summary>
        public static double CubicMeter_2_Exaliter(double inVal)                        => inVal / 1.0E+15;

        /// <summary>
        /// PL -> m^3
        /// 1 petaliter [PL] to vv: 1000000000000 cubic meter [m^3]
        /// </summary>
        public static double Petaliter_2_CubicMeter(double inVal)                       => inVal * 1000000000000;
        /// <summary>
        /// m^3 -> PL
        /// vv: 1000000000000 cubic meter [m^3] to 1 petaliter [PL]
        /// </summary>
        public static double CubicMeter_2_Petaliter(double inVal)                       => inVal / 1000000000000;

        /// <summary>
        /// TL -> m^3
        /// 1 teraliter [TL] to vv: 1000000000 cubic meter [m^3]
        /// </summary>
        public static double Teraliter_2_CubicMeter(double inVal)                       => inVal * 1000000000;
        /// <summary>
        /// m^3 -> TL
        /// vv: 1000000000 cubic meter [m^3] to 1 teraliter [TL]
        /// </summary>
        public static double CubicMeter_2_Teraliter(double inVal)                       => inVal / 1000000000;

        /// <summary>
        /// GL -> m^3
        /// 1 gigaliter [GL] to vv: 1000000 cubic meter [m^3]
        /// </summary>
        public static double Gigaliter_2_CubicMeter(double inVal)                       => inVal * 1000000;
        /// <summary>
        /// m^3 -> GL
        /// vv: 1000000 cubic meter [m^3] to 1 gigaliter [GL]
        /// </summary>
        public static double CubicMeter_2_Gigaliter(double inVal)                       => inVal / 1000000;

        /// <summary>
        /// ML -> m^3
        /// 1 megaliter [ML] to vv: 1000 cubic meter [m^3]
        /// </summary>
        public static double Megaliter_2_CubicMeter(double inVal)                       => inVal * 1000;
        /// <summary>
        /// m^3 -> ML
        /// vv: 1000 cubic meter [m^3] to 1 megaliter [ML]
        /// </summary>
        public static double CubicMeter_2_Megaliter(double inVal)                       => inVal / 1000;

        /// <summary>
        /// kL -> m^3
        /// 1 kiloliter [kL] to vv: 1 cubic meter [m^3]
        /// </summary>
        public static double Kiloliter_2_CubicMeter(double inVal)                       => inVal * 1;
        /// <summary>
        /// m^3 -> kL
        /// vv: 1 cubic meter [m^3] to 1 kiloliter [kL]
        /// </summary>
        public static double CubicMeter_2_Kiloliter(double inVal)                       => inVal / 1;

        /// <summary>
        /// hL -> m^3
        /// 1 hectoliter [hL] to vv: 0.1 cubic meter [m^3]
        /// </summary>
        public static double Hectoliter_2_CubicMeter(double inVal)                      => inVal * 0.1;
        /// <summary>
        /// m^3 -> hL
        /// vv: 0.1 cubic meter [m^3] to 1 hectoliter [hL]
        /// </summary>
        public static double CubicMeter_2_Hectoliter(double inVal)                      => inVal / 0.1;

        /// <summary>
        /// daL -> m^3
        /// 1 dekaliter [daL] to vv: 0.01 cubic meter [m^3]
        /// </summary>
        public static double Dekaliter_2_CubicMeter(double inVal)                       => inVal * 0.01;
        /// <summary>
        /// m^3 -> daL
        /// vv: 0.01 cubic meter [m^3] to 1 dekaliter [daL]
        /// </summary>
        public static double CubicMeter_2_Dekaliter(double inVal)                       => inVal / 0.01;

        /// <summary>
        /// dL -> m^3
        /// 1 deciliter [dL] to vv: 0.0001 cubic meter [m^3]
        /// </summary>
        public static double Deciliter_2_CubicMeter(double inVal)                       => inVal * 0.0001;
        /// <summary>
        /// m^3 -> dL
        /// vv: 0.0001 cubic meter [m^3] to 1 deciliter [dL]
        /// </summary>
        public static double CubicMeter_2_Deciliter(double inVal)                       => inVal / 0.0001;

        /// <summary>
        /// cL -> m^3
        /// 1 centiliter [cL] to vv: 1.0E-5 cubic meter [m^3]
        /// </summary>
        public static double Centiliter_2_CubicMeter(double inVal)                      => inVal * 1.0E-5;
        /// <summary>
        /// m^3 -> cL
        /// vv: 1.0E-5 cubic meter [m^3] to 1 centiliter [cL]
        /// </summary>
        public static double CubicMeter_2_Centiliter(double inVal)                      => inVal / 1.0E-5;

        /// <summary>
        /// µL -> m^3
        /// 1 microliter [µL] to vv: 1.0E-9 cubic meter [m^3]
        /// </summary>
        public static double Microliter_2_CubicMeter(double inVal)                      => inVal * 1.0E-9;
        /// <summary>
        /// m^3 -> µL
        /// vv: 1.0E-9 cubic meter [m^3] to 1 microliter [µL]
        /// </summary>
        public static double CubicMeter_2_Microliter(double inVal)                      => inVal / 1.0E-9;

        /// <summary>
        /// nL -> m^3
        /// 1 nanoliter [nL] to vv: 1.0E-12 cubic meter [m^3]
        /// </summary>
        public static double Nanoliter_2_CubicMeter(double inVal)                       => inVal * 1.0E-12;
        /// <summary>
        /// m^3 -> nL
        /// vv: 1.0E-12 cubic meter [m^3] to 1 nanoliter [nL]
        /// </summary>
        public static double CubicMeter_2_Nanoliter(double inVal)                       => inVal / 1.0E-12;

        /// <summary>
        /// pL -> m^3
        /// 1 picoliter [pL] to vv: 1.0E-15 cubic meter [m^3]
        /// </summary>
        public static double Picoliter_2_CubicMeter(double inVal)                       => inVal * 1.0E-15;
        /// <summary>
        /// m^3 -> pL
        /// vv: 1.0E-15 cubic meter [m^3] to 1 picoliter [pL]
        /// </summary>
        public static double CubicMeter_2_Picoliter(double inVal)                       => inVal / 1.0E-15;

        /// <summary>
        /// fL -> m^3
        /// 1 femtoliter [fL] to vv: 1.0E-18 cubic meter [m^3]
        /// </summary>
        public static double Femtoliter_2_CubicMeter(double inVal)                      => inVal * 1.0E-18;
        /// <summary>
        /// m^3 -> fL
        /// vv: 1.0E-18 cubic meter [m^3] to 1 femtoliter [fL]
        /// </summary>
        public static double CubicMeter_2_Femtoliter(double inVal)                      => inVal / 1.0E-18;

        /// <summary>
        /// aL -> m^3
        /// 1 attoliter [aL] to vv: 1.0E-21 cubic meter [m^3]
        /// </summary>
        public static double Attoliter_2_CubicMeter(double inVal)                       => inVal * 1.0E-21;
        /// <summary>
        /// m^3 -> aL
        /// vv: 1.0E-21 cubic meter [m^3] to 1 attoliter [aL]
        /// </summary>
        public static double CubicMeter_2_Attoliter(double inVal)                       => inVal / 1.0E-21;

        /// <summary>
        /// cc, cm^3 -> m^3
        /// 1 cc [cc, cm^3] to vv: 1.0E-6 cubic meter [m^3]
        /// </summary>
        public static double Cc_2_CubicMeter(double inVal)                              => inVal * 1.0E-6;
        /// <summary>
        /// m^3 -> cc, cm^3
        /// vv: 1.0E-6 cubic meter [m^3] to 1 cc [cc, cm^3]
        /// </summary>
        public static double CubicMeter_2_Cc(double inVal)                              => inVal / 1.0E-6;

        /// <summary>
        /// Drop -> m^3
        /// 1 drop to vv: 5.0E-8 cubic meter [m^3]
        /// </summary>
        public static double Drop_2_CubicMeter(double inVal)                            => inVal * 5.0E-8;
        /// <summary>
        /// m^3 -> Drop
        /// vv: 5.0E-8 cubic meter [m^3] to 1 drop
        /// </summary>
        public static double CubicMeter_2_Drop(double inVal)                            => inVal / 5.0E-8;

        /// <summary>
        /// bbl (oil) -> m^3
        /// 1 barrel (oil) [bbl (oil)] to vv: 0.1589872949 cubic meter [m^3]
        /// </summary>
        public static double BarrelOil_2_CubicMeter(double inVal)                       => inVal * 0.1589872949;
        /// <summary>
        /// m^3 -> bbl (oil)
        /// vv: 0.1589872949 cubic meter [m^3] to 1 barrel (oil) [bbl (oil)]
        /// </summary>
        public static double CubicMeter_2_BarrelOil(double inVal)                       => inVal / 0.1589872949;

        /// <summary>
        /// bbl (US) -> m^3
        /// 1 barrel (US) [bbl (US)] to vv: 0.1192404712 cubic meter [m^3]
        /// </summary>
        public static double BarrelUS_2_CubicMeter(double inVal)                        => inVal * 0.1192404712;
        /// <summary>
        /// m^3 -> bbl (US)
        /// vv: 0.1192404712 cubic meter [m^3] to 1 barrel (US) [bbl (US)]
        /// </summary>
        public static double CubicMeter_2_BarrelUS(double inVal)                        => inVal / 0.1192404712;

        /// <summary>
        /// bbl (UK) -> m^3
        /// 1 barrel (UK) [bbl (UK)] to vv: 0.16365924 cubic meter [m^3]
        /// </summary>
        public static double BarrelUK_2_CubicMeter(double inVal)                        => inVal * 0.16365924;
        /// <summary>
        /// m^3 -> bbl (UK)
        /// vv: 0.16365924 cubic meter [m^3] to 1 barrel (UK) [bbl (UK)]
        /// </summary>
        public static double CubicMeter_2_BarrelUK(double inVal)                        => inVal / 0.16365924;

        /// <summary>
        /// gal (UK) -> m^3
        /// 1 gallon (UK) [gal (UK)] to vv: 0.00454609 cubic meter [m^3]
        /// </summary>
        public static double GallonUK_2_CubicMeter(double inVal)                        => inVal * 0.00454609;
        /// <summary>
        /// m^3 -> gal (UK)
        /// vv: 0.00454609 cubic meter [m^3] to 1 gallon (UK) [gal (UK)]
        /// </summary>
        public static double CubicMeter_2_GallonUK(double inVal)                        => inVal / 0.00454609;

        /// <summary>
        /// qt (UK) -> m^3
        /// 1 quart (UK) [qt (UK)] to vv: 0.0011365225 cubic meter [m^3]
        /// </summary>
        public static double QuartUK_2_CubicMeter(double inVal)                         => inVal * 0.0011365225;
        /// <summary>
        /// m^3 -> qt (UK)
        /// vv: 0.0011365225 cubic meter [m^3] to 1 quart (UK) [qt (UK)]
        /// </summary>
        public static double CubicMeter_2_QuartUK(double inVal)                         => inVal / 0.0011365225;

        /// <summary>
        /// pt (UK) -> m^3
        /// 1 pint (UK) [pt (UK)] to vv: 0.0005682613 cubic meter [m^3]
        /// </summary>
        public static double PintUK_2_CubicMeter(double inVal)                          => inVal * 0.0005682613;
        /// <summary>
        /// m^3 -> pt (UK)
        /// vv: 0.0005682613 cubic meter [m^3] to 1 pint (UK) [pt (UK)]
        /// </summary>
        public static double CubicMeter_2_PintUK(double inVal)                          => inVal / 0.0005682613;

        /// <summary>
        /// CupMetric -> m^3
        /// 1 cup (metric) to vv: 0.00025 cubic meter [m^3]
        /// </summary>
        public static double CupMetric_2_CubicMeter(double inVal)                       => inVal * 0.00025;
        /// <summary>
        /// m^3 -> CupMetric
        /// vv: 0.00025 cubic meter [m^3] to 1 cup (metric)
        /// </summary>
        public static double CubicMeter_2_CupMetric(double inVal)                       => inVal / 0.00025;

        /// <summary>
        /// CupUK -> m^3
        /// 1 cup (UK) to vv: 0.0002841306 cubic meter [m^3]
        /// </summary>
        public static double CupUK_2_CubicMeter(double inVal)                           => inVal * 0.0002841306;
        /// <summary>
        /// m^3 -> CupUK
        /// vv: 0.0002841306 cubic meter [m^3] to 1 cup (UK)
        /// </summary>
        public static double CubicMeter_2_CupUK(double inVal)                           => inVal / 0.0002841306;

        /// <summary>
        /// fl oz (US) -> m^3
        /// 1 fluid ounce (US) [fl oz (US)] to vv: 2.95735E-5 cubic meter [m^3]
        /// </summary>
        public static double FluidOunceUS_2_CubicMeter(double inVal)                    => inVal * 2.95735E-5;
        /// <summary>
        /// m^3 -> fl oz (US)
        /// vv: 2.95735E-5 cubic meter [m^3] to 1 fluid ounce (US) [fl oz (US)]
        /// </summary>
        public static double CubicMeter_2_FluidOunceUS(double inVal)                    => inVal / 2.95735E-5;

        /// <summary>
        /// fl oz (UK) -> m^3
        /// 1 fluid ounce (UK) [fl oz (UK)] to vv: 2.84131E-5 cubic meter [m^3]
        /// </summary>
        public static double FluidOunceUK_2_CubicMeter(double inVal)                    => inVal * 2.84131E-5;
        /// <summary>
        /// m^3 -> fl oz (UK)
        /// vv: 2.84131E-5 cubic meter [m^3] to 1 fluid ounce (UK) [fl oz (UK)]
        /// </summary>
        public static double CubicMeter_2_FluidOunceUK(double inVal)                    => inVal / 2.84131E-5;

        /// <summary>
        /// TablespoonMetric -> m^3
        /// 1 tablespoon (metric) to vv: 1.5E-5 cubic meter [m^3]
        /// </summary>
        public static double TablespoonMetric_2_CubicMeter(double inVal)                => inVal * 1.5E-5;
        /// <summary>
        /// m^3 -> TablespoonMetric
        /// vv: 1.5E-5 cubic meter [m^3] to 1 tablespoon (metric)
        /// </summary>
        public static double CubicMeter_2_TablespoonMetric(double inVal)                => inVal / 1.5E-5;

        /// <summary>
        /// TablespoonUK -> m^3
        /// 1 tablespoon (UK) to vv: 1.77582E-5 cubic meter [m^3]
        /// </summary>
        public static double TablespoonUK_2_CubicMeter(double inVal)                    => inVal * 1.77582E-5;
        /// <summary>
        /// m^3 -> TablespoonUK
        /// vv: 1.77582E-5 cubic meter [m^3] to 1 tablespoon (UK)
        /// </summary>
        public static double CubicMeter_2_TablespoonUK(double inVal)                    => inVal / 1.77582E-5;

        /// <summary>
        /// DessertspoonUS -> m^3
        /// 1 dessertspoon (US) to vv: 9.8578431875E-6 cubic meter [m^3]
        /// </summary>
        public static double DessertspoonUS_2_CubicMeter(double inVal)                  => inVal * 9.8578431875E-6;
        /// <summary>
        /// m^3 -> DessertspoonUS
        /// vv: 9.8578431875E-6 cubic meter [m^3] to 1 dessertspoon (US)
        /// </summary>
        public static double CubicMeter_2_DessertspoonUS(double inVal)                  => inVal / 9.8578431875E-6;

        /// <summary>
        /// DessertspoonUK -> m^3
        /// 1 dessertspoon (UK) to vv: 1.18388E-5 cubic meter [m^3]
        /// </summary>
        public static double DessertspoonUK_2_CubicMeter(double inVal)                  => inVal * 1.18388E-5;
        /// <summary>
        /// m^3 -> DessertspoonUK
        /// vv: 1.18388E-5 cubic meter [m^3] to 1 dessertspoon (UK)
        /// </summary>
        public static double CubicMeter_2_DessertspoonUK(double inVal)                  => inVal / 1.18388E-5;

        /// <summary>
        /// TeaspoonMetric -> m^3
        /// 1 teaspoon (metric) to vv: 5.0E-6 cubic meter [m^3]
        /// </summary>
        public static double TeaspoonMetric_2_CubicMeter(double inVal)                  => inVal * 5.0E-6;
        /// <summary>
        /// m^3 -> TeaspoonMetric
        /// vv: 5.0E-6 cubic meter [m^3] to 1 teaspoon (metric)
        /// </summary>
        public static double CubicMeter_2_TeaspoonMetric(double inVal)                  => inVal / 5.0E-6;

        /// <summary>
        /// TeaspoonUK -> m^3
        /// 1 teaspoon (UK) to vv: 5.9193880208333E-6 cubic meter [m^3]
        /// </summary>
        public static double TeaspoonUK_2_CubicMeter(double inVal)                      => inVal * 5.9193880208333E-6;
        /// <summary>
        /// m^3 -> TeaspoonUK
        /// vv: 5.9193880208333E-6 cubic meter [m^3] to 1 teaspoon (UK)
        /// </summary>
        public static double CubicMeter_2_TeaspoonUK(double inVal)                      => inVal / 5.9193880208333E-6;

        /// <summary>
        /// gi -> m^3
        /// 1 gill (US) [gi] to vv: 0.0001182941 cubic meter [m^3]
        /// </summary>
        public static double GillUS_2_CubicMeter(double inVal)                          => inVal * 0.0001182941;
        /// <summary>
        /// m^3 -> gi
        /// vv: 0.0001182941 cubic meter [m^3] to 1 gill (US) [gi]
        /// </summary>
        public static double CubicMeter_2_GillUS(double inVal)                          => inVal / 0.0001182941;

        /// <summary>
        /// gi (UK) -> m^3
        /// 1 gill (UK) [gi (UK)] to vv: 0.0001420653 cubic meter [m^3]
        /// </summary>
        public static double GillUK_2_CubicMeter(double inVal)                          => inVal * 0.0001420653;
        /// <summary>
        /// m^3 -> gi (UK)
        /// vv: 0.0001420653 cubic meter [m^3] to 1 gill (UK) [gi (UK)]
        /// </summary>
        public static double CubicMeter_2_GillUK(double inVal)                          => inVal / 0.0001420653;

        /// <summary>
        /// MinimUS -> m^3
        /// 1 minim (US) to vv: 6.1611519921875E-8 cubic meter [m^3]
        /// </summary>
        public static double MinimUS_2_CubicMeter(double inVal)                         => inVal * 6.1611519921875E-8;
        /// <summary>
        /// m^3 -> MinimUS
        /// vv: 6.1611519921875E-8 cubic meter [m^3] to 1 minim (US)
        /// </summary>
        public static double CubicMeter_2_MinimUS(double inVal)                         => inVal / 6.1611519921875E-8;

        /// <summary>
        /// MinimUK -> m^3
        /// 1 minim (UK) to vv: 5.9193880208333E-8 cubic meter [m^3]
        /// </summary>
        public static double MinimUK_2_CubicMeter(double inVal)                         => inVal * 5.9193880208333E-8;
        /// <summary>
        /// m^3 -> MinimUK
        /// vv: 5.9193880208333E-8 cubic meter [m^3] to 1 minim (UK)
        /// </summary>
        public static double CubicMeter_2_MinimUK(double inVal)                         => inVal / 5.9193880208333E-8;

        /// <summary>
        /// ton reg -> m^3
        /// 1 ton register [ton reg] to vv: 2.8316846592 cubic meter [m^3]
        /// </summary>
        public static double TonRegister_2_CubicMeter(double inVal)                     => inVal * 2.8316846592;
        /// <summary>
        /// m^3 -> ton reg
        /// vv: 2.8316846592 cubic meter [m^3] to 1 ton register [ton reg]
        /// </summary>
        public static double CubicMeter_2_TonRegister(double inVal)                     => inVal / 2.8316846592;

        /// <summary>
        /// Ccf -> m^3
        /// 1 ccf to vv: 2.8316846592 cubic meter [m^3]
        /// </summary>
        public static double Ccf_2_CubicMeter(double inVal)                             => inVal * 2.8316846592;
        /// <summary>
        /// m^3 -> Ccf
        /// vv: 2.8316846592 cubic meter [m^3] to 1 ccf
        /// </summary>
        public static double CubicMeter_2_Ccf(double inVal)                             => inVal / 2.8316846592;

        /// <summary>
        /// HundredCubicFoot -> m^3
        /// 1 hundred-cubic foot to vv: 2.8316846592 cubic meter [m^3]
        /// </summary>
        public static double HundredCubicFoot_2_CubicMeter(double inVal)                => inVal * 2.8316846592;
        /// <summary>
        /// m^3 -> HundredCubicFoot
        /// vv: 2.8316846592 cubic meter [m^3] to 1 hundred-cubic foot
        /// </summary>
        public static double CubicMeter_2_HundredCubicFoot(double inVal)                => inVal / 2.8316846592;

        /// <summary>
        /// ac*ft -> m^3
        /// 1 acre-foot [ac*ft] to vv: 1233.4818375475 cubic meter [m^3]
        /// </summary>
        public static double AcreFoot_2_CubicMeter(double inVal)                        => inVal * 1233.4818375475;
        /// <summary>
        /// m^3 -> ac*ft
        /// vv: 1233.4818375475 cubic meter [m^3] to 1 acre-foot [ac*ft]
        /// </summary>
        public static double CubicMeter_2_AcreFoot(double inVal)                        => inVal / 1233.4818375475;

        /// <summary>
        /// AcreFootUSSurvey -> m^3
        /// 1 acre-foot (US survey) to vv: 1233.4892384682 cubic meter [m^3]
        /// </summary>
        public static double AcreFootUSSurvey_2_CubicMeter(double inVal)                => inVal * 1233.4892384682;
        /// <summary>
        /// m^3 -> AcreFootUSSurvey
        /// vv: 1233.4892384682 cubic meter [m^3] to 1 acre-foot (US survey)
        /// </summary>
        public static double CubicMeter_2_AcreFootUSSurvey(double inVal)                => inVal / 1233.4892384682;

        /// <summary>
        /// ac*in -> m^3
        /// 1 acre-inch [ac*in] to vv: 102.790153129 cubic meter [m^3]
        /// </summary>
        public static double AcreInch_2_CubicMeter(double inVal)                        => inVal * 102.790153129;
        /// <summary>
        /// m^3 -> ac*in
        /// vv: 102.790153129 cubic meter [m^3] to 1 acre-inch [ac*in]
        /// </summary>
        public static double CubicMeter_2_AcreInch(double inVal)                        => inVal / 102.790153129;

        /// <summary>
        /// Dekastere -> m^3
        /// 1 dekastere to vv: 10 cubic meter [m^3]
        /// </summary>
        public static double Dekastere_2_CubicMeter(double inVal)                       => inVal * 10;
        /// <summary>
        /// m^3 -> Dekastere
        /// vv: 10 cubic meter [m^3] to 1 dekastere
        /// </summary>
        public static double CubicMeter_2_Dekastere(double inVal)                       => inVal / 10;

        /// <summary>
        /// st -> m^3
        /// 1 stere [st] to vv: 1 cubic meter [m^3]
        /// </summary>
        public static double Stere_2_CubicMeter(double inVal)                           => inVal * 1;
        /// <summary>
        /// m^3 -> st
        /// vv: 1 cubic meter [m^3] to 1 stere [st]
        /// </summary>
        public static double CubicMeter_2_Stere(double inVal)                           => inVal / 1;

        /// <summary>
        /// Decistere -> m^3
        /// 1 decistere to vv: 0.1 cubic meter [m^3]
        /// </summary>
        public static double Decistere_2_CubicMeter(double inVal)                       => inVal * 0.1;
        /// <summary>
        /// m^3 -> Decistere
        /// vv: 0.1 cubic meter [m^3] to 1 decistere
        /// </summary>
        public static double CubicMeter_2_Decistere(double inVal)                       => inVal / 0.1;

        /// <summary>
        /// cd -> m^3
        /// 1 cord [cd] to vv: 3.6245563638 cubic meter [m^3]
        /// </summary>
        public static double Cord_2_CubicMeter(double inVal)                            => inVal * 3.6245563638;
        /// <summary>
        /// m^3 -> cd
        /// vv: 3.6245563638 cubic meter [m^3] to 1 cord [cd]
        /// </summary>
        public static double CubicMeter_2_Cord(double inVal)                            => inVal / 3.6245563638;

        /// <summary>
        /// Tun -> m^3
        /// 1 tun to vv: 0.9539237696 cubic meter [m^3]
        /// </summary>
        public static double Tun_2_CubicMeter(double inVal)                             => inVal * 0.9539237696;
        /// <summary>
        /// m^3 -> Tun
        /// vv: 0.9539237696 cubic meter [m^3] to 1 tun
        /// </summary>
        public static double CubicMeter_2_Tun(double inVal)                             => inVal / 0.9539237696;

        /// <summary>
        /// Hogshead -> m^3
        /// 1 hogshead to vv: 0.2384809424 cubic meter [m^3]
        /// </summary>
        public static double Hogshead_2_CubicMeter(double inVal)                        => inVal * 0.2384809424;
        /// <summary>
        /// m^3 -> Hogshead
        /// vv: 0.2384809424 cubic meter [m^3] to 1 hogshead
        /// </summary>
        public static double CubicMeter_2_Hogshead(double inVal)                        => inVal / 0.2384809424;

        /// <summary>
        /// BoardFoot -> m^3
        /// 1 board foot to vv: 0.0023597372 cubic meter [m^3]
        /// </summary>
        public static double BoardFoot_2_CubicMeter(double inVal)                       => inVal * 0.0023597372;
        /// <summary>
        /// m^3 -> BoardFoot
        /// vv: 0.0023597372 cubic meter [m^3] to 1 board foot
        /// </summary>
        public static double CubicMeter_2_BoardFoot(double inVal)                       => inVal / 0.0023597372;

        /// <summary>
        /// dr -> m^3
        /// 1 dram [dr] to vv: 3.6966911953125E-6 cubic meter [m^3]
        /// </summary>
        public static double Dram_2_CubicMeter(double inVal)                            => inVal * 3.6966911953125E-6;
        /// <summary>
        /// m^3 -> dr
        /// vv: 3.6966911953125E-6 cubic meter [m^3] to 1 dram [dr]
        /// </summary>
        public static double CubicMeter_2_Dram(double inVal)                            => inVal / 3.6966911953125E-6;

        /// <summary>
        /// CorBiblical -> m^3
        /// 1 cor (Biblical) to vv: 0.22 cubic meter [m^3]
        /// </summary>
        public static double CorBiblical_2_CubicMeter(double inVal)                     => inVal * 0.22;
        /// <summary>
        /// m^3 -> CorBiblical
        /// vv: 0.22 cubic meter [m^3] to 1 cor (Biblical)
        /// </summary>
        public static double CubicMeter_2_CorBiblical(double inVal)                     => inVal / 0.22;

        /// <summary>
        /// HomerBiblical -> m^3
        /// 1 homer (Biblical) to vv: 0.22 cubic meter [m^3]
        /// </summary>
        public static double HomerBiblical_2_CubicMeter(double inVal)                   => inVal * 0.22;
        /// <summary>
        /// m^3 -> HomerBiblical
        /// vv: 0.22 cubic meter [m^3] to 1 homer (Biblical)
        /// </summary>
        public static double CubicMeter_2_HomerBiblical(double inVal)                   => inVal / 0.22;

        /// <summary>
        /// BathBiblical -> m^3
        /// 1 bath (Biblical) to vv: 0.022 cubic meter [m^3]
        /// </summary>
        public static double BathBiblical_2_CubicMeter(double inVal)                    => inVal * 0.022;
        /// <summary>
        /// m^3 -> BathBiblical
        /// vv: 0.022 cubic meter [m^3] to 1 bath (Biblical)
        /// </summary>
        public static double CubicMeter_2_BathBiblical(double inVal)                    => inVal / 0.022;

        /// <summary>
        /// HinBiblical -> m^3
        /// 1 hin (Biblical) to vv: 0.0036666667 cubic meter [m^3]
        /// </summary>
        public static double HinBiblical_2_CubicMeter(double inVal)                     => inVal * 0.0036666667;
        /// <summary>
        /// m^3 -> HinBiblical
        /// vv: 0.0036666667 cubic meter [m^3] to 1 hin (Biblical)
        /// </summary>
        public static double CubicMeter_2_HinBiblical(double inVal)                     => inVal / 0.0036666667;

        /// <summary>
        /// CabBiblical -> m^3
        /// 1 cab (Biblical) to vv: 0.0012222222 cubic meter [m^3]
        /// </summary>
        public static double CabBiblical_2_CubicMeter(double inVal)                     => inVal * 0.0012222222;
        /// <summary>
        /// m^3 -> CabBiblical
        /// vv: 0.0012222222 cubic meter [m^3] to 1 cab (Biblical)
        /// </summary>
        public static double CubicMeter_2_CabBiblical(double inVal)                     => inVal / 0.0012222222;

        /// <summary>
        /// LogBiblical -> m^3
        /// 1 log (Biblical) to vv: 0.0003055556 cubic meter [m^3]
        /// </summary>
        public static double LogBiblical_2_CubicMeter(double inVal)                     => inVal * 0.0003055556;
        /// <summary>
        /// m^3 -> LogBiblical
        /// vv: 0.0003055556 cubic meter [m^3] to 1 log (Biblical)
        /// </summary>
        public static double CubicMeter_2_LogBiblical(double inVal)                     => inVal / 0.0003055556;

        /// <summary>
        /// TazaSpanish -> m^3
        /// 1 Taza (Spanish) to vv: 0.0002365882 cubic meter [m^3]
        /// </summary>
        public static double TazaSpanish_2_CubicMeter(double inVal)                     => inVal * 0.0002365882;
        /// <summary>
        /// m^3 -> TazaSpanish
        /// vv: 0.0002365882 cubic meter [m^3] to 1 Taza (Spanish)
        /// </summary>
        public static double CubicMeter_2_TazaSpanish(double inVal)                     => inVal / 0.0002365882;

        /// <summary>
        /// EarthVolume -> m^3
        /// 1 Earth's volume to vv: 1.083E+21 cubic meter [m^3]
        /// </summary>
        public static double EarthVolume_2_CubicMeter(double inVal)                     => inVal * 1.083E+21;
        /// <summary>
        /// m^3 -> EarthVolume
        /// vv: 1.083E+21 cubic meter [m^3] to 1 Earth's volume
        /// </summary>
        public static double CubicMeter_2_EarthVolume(double inVal)                     => inVal / 1.083E+21;

        #endregion

        #region specific volume, base: cubic meter per kilogram

        /// <summary>
        /// CubicCentimeterPerGram -> CubicMeterPerKilogram
        /// 1 cubic centimeter/gram to vv: 0.001 cubic meter/kilogram
        /// </summary>
        public static double CubicCentimeterPerGram_2_CubicMeterPerKilogram(double inVal)=> inVal * 0.001;
        /// <summary>
        /// CubicMeterPerKilogram -> CubicCentimeterPerGram
        /// vv: 0.001 cubic meter/kilogram to 1 cubic centimeter/gram
        /// </summary>
        public static double CubicMeterPerKilogram_2_CubicCentimeterPerGram(double inVal)=> inVal / 0.001;

        /// <summary>
        /// L/kg -> CubicMeterPerKilogram
        /// 1 liter/kilogram [L/kg] to vv: 0.001 cubic meter/kilogram
        /// </summary>
        public static double LiterPerKilogram_2_CubicMeterPerKilogram(double inVal)     => inVal * 0.001;
        /// <summary>
        /// CubicMeterPerKilogram -> L/kg
        /// vv: 0.001 cubic meter/kilogram to 1 liter/kilogram [L/kg]
        /// </summary>
        public static double CubicMeterPerKilogram_2_LiterPerKilogram(double inVal)     => inVal / 0.001;

        /// <summary>
        /// L/g -> CubicMeterPerKilogram
        /// 1 liter/gram [L/g] to vv: 1 cubic meter/kilogram
        /// </summary>
        public static double LiterPerGram_2_CubicMeterPerKilogram(double inVal)         => inVal * 1;
        /// <summary>
        /// CubicMeterPerKilogram -> L/g
        /// vv: 1 cubic meter/kilogram to 1 liter/gram [L/g]
        /// </summary>
        public static double CubicMeterPerKilogram_2_LiterPerGram(double inVal)         => inVal / 1;

        /// <summary>
        /// ft^3/kg -> CubicMeterPerKilogram
        /// 1 cubic foot/kilogram [ft^3/kg] to vv: 0.0283168466 cubic meter/kilogram
        /// </summary>
        public static double CubicFootPerKilogram_2_CubicMeterPerKilogram(double inVal) => inVal * 0.0283168466;
        /// <summary>
        /// CubicMeterPerKilogram -> ft^3/kg
        /// vv: 0.0283168466 cubic meter/kilogram to 1 cubic foot/kilogram [ft^3/kg]
        /// </summary>
        public static double CubicMeterPerKilogram_2_CubicFootPerKilogram(double inVal) => inVal / 0.0283168466;

        /// <summary>
        /// ft^3/lb -> CubicMeterPerKilogram
        /// 1 cubic foot/pound [ft^3/lb] to vv: 0.06242796 cubic meter/kilogram
        /// </summary>
        public static double CubicFootPerPound_2_CubicMeterPerKilogram(double inVal)    => inVal * 0.06242796;
        /// <summary>
        /// CubicMeterPerKilogram -> ft^3/lb
        /// vv: 0.06242796 cubic meter/kilogram to 1 cubic foot/pound [ft^3/lb]
        /// </summary>
        public static double CubicMeterPerKilogram_2_CubicFootPerPound(double inVal)    => inVal / 0.06242796;

        /// <summary>
        /// GallonUSPerPound -> CubicMeterPerKilogram
        /// 1 gallon (US)/pound to vv: 0.0083454039 cubic meter/kilogram
        /// </summary>
        public static double GallonUSPerPound_2_CubicMeterPerKilogram(double inVal)     => inVal * 0.0083454039;
        /// <summary>
        /// CubicMeterPerKilogram -> GallonUSPerPound
        /// vv: 0.0083454039 cubic meter/kilogram to 1 gallon (US)/pound
        /// </summary>
        public static double CubicMeterPerKilogram_2_GallonUSPerPound(double inVal)     => inVal / 0.0083454039;

        /// <summary>
        /// GallonUKPerPound -> CubicMeterPerKilogram
        /// 1 gallon (UK)/pound to vv: 0.0100224128 cubic meter/kilogram
        /// </summary>
        public static double GallonUKPerPound_2_CubicMeterPerKilogram(double inVal)     => inVal * 0.0100224128;
        /// <summary>
        /// CubicMeterPerKilogram -> GallonUKPerPound
        /// vv: 0.0100224128 cubic meter/kilogram to 1 gallon (UK)/pound
        /// </summary>
        public static double CubicMeterPerKilogram_2_GallonUKPerPound(double inVal)     => inVal / 0.0100224128;

        #endregion

        #region lumber volume, base cubic meter

        /// <summary>
        /// BoardFeet -> m^3
        /// 1 board feet to vv: 0.0023597372 cubic meter [m^3]
        /// </summary>
        public static double BoardFeet_2_CubicMeter(double inVal)                       => inVal * 0.0023597372;
        /// <summary>
        /// m^3 -> BoardFeet
        /// vv: 0.0023597372 cubic meter [m^3] to 1 board feet
        /// </summary>
        public static double CubicMeter_2_BoardFeet(double inVal)                       => inVal / 0.0023597372;

        /// <summary>
        /// ThousandBoardFeet -> m^3
        /// 1 thousand board feet to vv: 2.3597372158 cubic meter [m^3]
        /// </summary>
        public static double ThousandBoardFeet_2_CubicMeter(double inVal)               => inVal * 2.3597372158;
        /// <summary>
        /// m^3 -> ThousandBoardFeet
        /// vv: 2.3597372158 cubic meter [m^3] to 1 thousand board feet
        /// </summary>
        public static double CubicMeter_2_ThousandBoardFeet(double inVal)               => inVal / 2.3597372158;

        /// <summary>
        /// Cord80CubicFt -> m^3
        /// 1 cord (80 cubic ft) to vv: 2.2653477275 cubic meter [m^3]
        /// </summary>
        public static double Cord80CubicFt_2_CubicMeter(double inVal)                   => inVal * 2.2653477275;
        /// <summary>
        /// m^3 -> Cord80CubicFt
        /// vv: 2.2653477275 cubic meter [m^3] to 1 cord (80 cubic ft)
        /// </summary>
        public static double CubicMeter_2_Cord80CubicFt(double inVal)                   => inVal / 2.2653477275;

        /// <summary>
        /// CordFeet -> m^3
        /// 1 cord feet to vv: 0.4530695455 cubic meter [m^3]
        /// </summary>
        public static double CordFeet_2_CubicMeter(double inVal)                        => inVal * 0.4530695455;
        /// <summary>
        /// m^3 -> CordFeet
        /// vv: 0.4530695455 cubic meter [m^3] to 1 cord feet
        /// </summary>
        public static double CubicMeter_2_CordFeet(double inVal)                        => inVal / 0.4530695455;

        /// <summary>
        /// Cunit -> m^3
        /// 1 cunit to vv: 2.8316846593 cubic meter [m^3]
        /// </summary>
        public static double Cunit_2_CubicMeter(double inVal)                           => inVal * 2.8316846593;
        /// <summary>
        /// m^3 -> Cunit
        /// vv: 2.8316846593 cubic meter [m^3] to 1 cunit
        /// </summary>
        public static double CubicMeter_2_Cunit(double inVal)                           => inVal / 2.8316846593;

        /// <summary>
        /// Pallet -> m^3
        /// 1 pallet to vv: 0.0401155327 cubic meter [m^3]
        /// </summary>
        public static double Pallet_2_CubicMeter(double inVal)                          => inVal * 0.0401155327;
        /// <summary>
        /// m^3 -> Pallet
        /// vv: 0.0401155327 cubic meter [m^3] to 1 pallet
        /// </summary>
        public static double CubicMeter_2_Pallet(double inVal)                          => inVal / 0.0401155327;

        /// <summary>
        /// CrossTie -> m^3
        /// 1 cross tie to vv: 0.0943894886 cubic meter [m^3]
        /// </summary>
        public static double CrossTie_2_CubicMeter(double inVal)                        => inVal * 0.0943894886;
        /// <summary>
        /// m^3 -> CrossTie
        /// vv: 0.0943894886 cubic meter [m^3] to 1 cross tie
        /// </summary>
        public static double CubicMeter_2_CrossTie(double inVal)                        => inVal / 0.0943894886;

        /// <summary>
        /// SwitchTie -> m^3
        /// 1 switch tie to vv: 0.1486634446 cubic meter [m^3]
        /// </summary>
        public static double SwitchTie_2_CubicMeter(double inVal)                       => inVal * 0.1486634446;
        /// <summary>
        /// m^3 -> SwitchTie
        /// vv: 0.1486634446 cubic meter [m^3] to 1 switch tie
        /// </summary>
        public static double CubicMeter_2_SwitchTie(double inVal)                       => inVal / 0.1486634446;

        /// <summary>
        /// ThousandSquareFeet1Per8InchPanels -> m^3
        /// 1 thousand square feet (1/8-inch panels) to vv: 0.294967152 cubic meter [m^3]
        /// </summary>
        public static double ThousandSquareFeet1Per8InchPanels_2_CubicMeter(double inVal)=> inVal * 0.294967152;
        /// <summary>
        /// m^3 -> ThousandSquareFeet1Per8InchPanels
        /// vv: 0.294967152 cubic meter [m^3] to 1 thousand square feet (1/8-inch panels)
        /// </summary>
        public static double CubicMeter_2_ThousandSquareFeet1Per8InchPanels(double inVal)=> inVal / 0.294967152;

        /// <summary>
        /// ThousandSquareFeet1Per4InchPanels -> m^3
        /// 1 thousand square feet (1/4-inch panels) to vv: 0.5899343039 cubic meter [m^3]
        /// </summary>
        public static double ThousandSquareFeet1Per4InchPanels_2_CubicMeter(double inVal)=> inVal * 0.5899343039;
        /// <summary>
        /// m^3 -> ThousandSquareFeet1Per4InchPanels
        /// vv: 0.5899343039 cubic meter [m^3] to 1 thousand square feet (1/4-inch panels)
        /// </summary>
        public static double CubicMeter_2_ThousandSquareFeet1Per4InchPanels(double inVal)=> inVal / 0.5899343039;

        /// <summary>
        /// ThousandSquareFeet3Per8InchPanels -> m^3
        /// 1 thousand square feet (3/8-inch panels) to vv: 0.8849014561 cubic meter [m^3]
        /// </summary>
        public static double ThousandSquareFeet3Per8InchPanels_2_CubicMeter(double inVal)=> inVal * 0.8849014561;
        /// <summary>
        /// m^3 -> ThousandSquareFeet3Per8InchPanels
        /// vv: 0.8849014561 cubic meter [m^3] to 1 thousand square feet (3/8-inch panels)
        /// </summary>
        public static double CubicMeter_2_ThousandSquareFeet3Per8InchPanels(double inVal)=> inVal / 0.8849014561;

        /// <summary>
        /// ThousandSquareFeet1Per2InchPanels -> m^3
        /// 1 thousand square feet (1/2-inch panels) to vv: 1.179868608 cubic meter [m^3]
        /// </summary>
        public static double ThousandSquareFeet1Per2InchPanels_2_CubicMeter(double inVal)=> inVal * 1.179868608;
        /// <summary>
        /// m^3 -> ThousandSquareFeet1Per2InchPanels
        /// vv: 1.179868608 cubic meter [m^3] to 1 thousand square feet (1/2-inch panels)
        /// </summary>
        public static double CubicMeter_2_ThousandSquareFeet1Per2InchPanels(double inVal)=> inVal / 1.179868608;

        /// <summary>
        /// ThousandSquareFeet3Per4InchPanels -> m^3
        /// 1 thousand square feet (3/4-inch panels) to vv: 1.7698029121 cubic meter [m^3]
        /// </summary>
        public static double ThousandSquareFeet3Per4InchPanels_2_CubicMeter(double inVal)=> inVal * 1.7698029121;
        /// <summary>
        /// m^3 -> ThousandSquareFeet3Per4InchPanels
        /// vv: 1.7698029121 cubic meter [m^3] to 1 thousand square feet (3/4-inch panels)
        /// </summary>
        public static double CubicMeter_2_ThousandSquareFeet3Per4InchPanels(double inVal)=> inVal / 1.7698029121;
    
        #endregion
    }
}
