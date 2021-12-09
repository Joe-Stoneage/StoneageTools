
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region pressure, base: pascal

        /// <summary>
        /// kPa -> Pa
        /// 1 kilopascal [kPa] =  1000 pascal [Pa]
        /// </summary>
        public static double Kilopascal_2_Pascal(double inVal)                          => inVal * 1000;
        /// <summary>
        /// Pa -> kPa
        /// vv: 1000 pascal [Pa] to 1 kilopascal [kPa]
        /// </summary>
        public static double Pascal_2_Kilopascal(double inVal)                          => inVal / 1000;

        /// <summary>
        /// Bar -> Pa
        /// 1 bar =  100000 pascal [Pa]
        /// </summary>
        public static double Bar_2_Pascal(double inVal)                                 => inVal * 100000;
        /// <summary>
        /// Pa -> Bar
        /// vv: 100000 pascal [Pa] to 1 bar
        /// </summary>
        public static double Pascal_2_Bar(double inVal)                                 => inVal / 100000;

        /// <summary>
        /// psi -> Pa
        /// 1 psi [psi] =  6894.7572931783 pascal [Pa]
        /// </summary>
        public static double Psi_2_Pascal(double inVal)                                 => inVal * 6894.7572931783;
        /// <summary>
        /// Pa -> psi
        /// vv: 6894.7572931783 pascal [Pa] to 1 psi [psi]
        /// </summary>
        public static double Pascal_2_Psi(double inVal)                                 => inVal / 6894.7572931783;

        /// <summary>
        /// ksi -> Pa
        /// 1 ksi [ksi] =  6894757.2931783 pascal [Pa]
        /// </summary>
        public static double Ksi_2_Pascal(double inVal)                                 => inVal * 6894757.2931783;
        /// <summary>
        /// Pa -> ksi
        /// vv: 6894757.2931783 pascal [Pa] to 1 ksi [ksi]
        /// </summary>
        public static double Pascal_2_Ksi(double inVal)                                 => inVal / 6894757.2931783;

        /// <summary>
        /// atm -> Pa
        /// 1 Standard atmosphere [atm] =  101325 pascal [Pa]
        /// </summary>
        public static double StandardAtmosphere_2_Pascal(double inVal)                  => inVal * 101325;
        /// <summary>
        /// Pa -> atm
        /// vv: 101325 pascal [Pa] to 1 Standard atmosphere [atm]
        /// </summary>
        public static double Pascal_2_StandardAtmosphere(double inVal)                  => inVal / 101325;

        /// <summary>
        /// EPa -> Pa
        /// 1 exapascal [EPa] =  1.0E+18 pascal [Pa]
        /// </summary>
        public static double Exapascal_2_Pascal(double inVal)                           => inVal * 1.0E+18;
        /// <summary>
        /// Pa -> EPa
        /// vv: 1.0E+18 pascal [Pa] to 1 exapascal [EPa]
        /// </summary>
        public static double Pascal_2_Exapascal(double inVal)                           => inVal / 1.0E+18;

        /// <summary>
        /// PPa -> Pa
        /// 1 petapascal [PPa] =  1.0E+15 pascal [Pa]
        /// </summary>
        public static double Petapascal_2_Pascal(double inVal)                          => inVal * 1.0E+15;
        /// <summary>
        /// Pa -> PPa
        /// vv: 1.0E+15 pascal [Pa] to 1 petapascal [PPa]
        /// </summary>
        public static double Pascal_2_Petapascal(double inVal)                          => inVal / 1.0E+15;

        /// <summary>
        /// TPa -> Pa
        /// 1 terapascal [TPa] =  1000000000000 pascal [Pa]
        /// </summary>
        public static double Terapascal_2_Pascal(double inVal)                          => inVal * 1000000000000;
        /// <summary>
        /// Pa -> TPa
        /// vv: 1000000000000 pascal [Pa] to 1 terapascal [TPa]
        /// </summary>
        public static double Pascal_2_Terapascal(double inVal)                          => inVal / 1000000000000;

        /// <summary>
        /// GPa -> Pa
        /// 1 gigapascal [GPa] =  1000000000 pascal [Pa]
        /// </summary>
        public static double Gigapascal_2_Pascal(double inVal)                          => inVal * 1000000000;
        /// <summary>
        /// Pa -> GPa
        /// vv: 1000000000 pascal [Pa] to 1 gigapascal [GPa]
        /// </summary>
        public static double Pascal_2_Gigapascal(double inVal)                          => inVal / 1000000000;

        /// <summary>
        /// MPa -> Pa
        /// 1 megapascal [MPa] =  1000000 pascal [Pa]
        /// </summary>
        public static double Megapascal_2_Pascal(double inVal)                          => inVal * 1000000;
        /// <summary>
        /// Pa -> MPa
        /// vv: 1000000 pascal [Pa] to 1 megapascal [MPa]
        /// </summary>
        public static double Pascal_2_Megapascal(double inVal)                          => inVal / 1000000;

        /// <summary>
        /// hPa -> Pa
        /// 1 hectopascal [hPa] =  100 pascal [Pa]
        /// </summary>
        public static double Hectopascal_2_Pascal(double inVal)                         => inVal * 100;
        /// <summary>
        /// Pa -> hPa
        /// vv: 100 pascal [Pa] to 1 hectopascal [hPa]
        /// </summary>
        public static double Pascal_2_Hectopascal(double inVal)                         => inVal / 100;

        /// <summary>
        /// daPa -> Pa
        /// 1 dekapascal [daPa] =  10 pascal [Pa]
        /// </summary>
        public static double Dekapascal_2_Pascal(double inVal)                          => inVal * 10;
        /// <summary>
        /// Pa -> daPa
        /// vv: 10 pascal [Pa] to 1 dekapascal [daPa]
        /// </summary>
        public static double Pascal_2_Dekapascal(double inVal)                          => inVal / 10;

        /// <summary>
        /// dPa -> Pa
        /// 1 decipascal [dPa] =  0.1 pascal [Pa]
        /// </summary>
        public static double Decipascal_2_Pascal(double inVal)                          => inVal * 0.1;
        /// <summary>
        /// Pa -> dPa
        /// vv: 0.1 pascal [Pa] to 1 decipascal [dPa]
        /// </summary>
        public static double Pascal_2_Decipascal(double inVal)                          => inVal / 0.1;

        /// <summary>
        /// cPa -> Pa
        /// 1 centipascal [cPa] =  0.01 pascal [Pa]
        /// </summary>
        public static double Centipascal_2_Pascal(double inVal)                         => inVal * 0.01;
        /// <summary>
        /// Pa -> cPa
        /// vv: 0.01 pascal [Pa] to 1 centipascal [cPa]
        /// </summary>
        public static double Pascal_2_Centipascal(double inVal)                         => inVal / 0.01;

        /// <summary>
        /// mPa -> Pa
        /// 1 millipascal [mPa] =  0.001 pascal [Pa]
        /// </summary>
        public static double Millipascal_2_Pascal(double inVal)                         => inVal * 0.001;
        /// <summary>
        /// Pa -> mPa
        /// vv: 0.001 pascal [Pa] to 1 millipascal [mPa]
        /// </summary>
        public static double Pascal_2_Millipascal(double inVal)                         => inVal / 0.001;

        /// <summary>
        /// µPa -> Pa
        /// 1 micropascal [µPa] =  1.0E-6 pascal [Pa]
        /// </summary>
        public static double Micropascal_2_Pascal(double inVal)                         => inVal * 1.0E-6;
        /// <summary>
        /// Pa -> µPa
        /// vv: 1.0E-6 pascal [Pa] to 1 micropascal [µPa]
        /// </summary>
        public static double Pascal_2_Micropascal(double inVal)                         => inVal / 1.0E-6;

        /// <summary>
        /// nPa -> Pa
        /// 1 nanopascal [nPa] =  1.0E-9 pascal [Pa]
        /// </summary>
        public static double Nanopascal_2_Pascal(double inVal)                          => inVal * 1.0E-9;
        /// <summary>
        /// Pa -> nPa
        /// vv: 1.0E-9 pascal [Pa] to 1 nanopascal [nPa]
        /// </summary>
        public static double Pascal_2_Nanopascal(double inVal)                          => inVal / 1.0E-9;

        /// <summary>
        /// pPa -> Pa
        /// 1 picopascal [pPa] =  1.0E-12 pascal [Pa]
        /// </summary>
        public static double Picopascal_2_Pascal(double inVal)                          => inVal * 1.0E-12;
        /// <summary>
        /// Pa -> pPa
        /// vv: 1.0E-12 pascal [Pa] to 1 picopascal [pPa]
        /// </summary>
        public static double Pascal_2_Picopascal(double inVal)                          => inVal / 1.0E-12;

        /// <summary>
        /// fPa -> Pa
        /// 1 femtopascal [fPa] =  1.0E-15 pascal [Pa]
        /// </summary>
        public static double Femtopascal_2_Pascal(double inVal)                         => inVal * 1.0E-15;
        /// <summary>
        /// Pa -> fPa
        /// vv: 1.0E-15 pascal [Pa] to 1 femtopascal [fPa]
        /// </summary>
        public static double Pascal_2_Femtopascal(double inVal)                         => inVal / 1.0E-15;

        /// <summary>
        /// aPa -> Pa
        /// 1 attopascal [aPa] =  1.0E-18 pascal [Pa]
        /// </summary>
        public static double Attopascal_2_Pascal(double inVal)                          => inVal * 1.0E-18;
        /// <summary>
        /// Pa -> aPa
        /// vv: 1.0E-18 pascal [Pa] to 1 attopascal [aPa]
        /// </summary>
        public static double Pascal_2_Attopascal(double inVal)                          => inVal / 1.0E-18;

        /// <summary>
        /// NewtonPerSquareMeter -> Pa
        /// 1 newton/square meter =  1 pascal [Pa]
        /// </summary>
        public static double NewtonPerSquareMeter_2_Pascal(double inVal)                => inVal * 1;
        /// <summary>
        /// Pa -> NewtonPerSquareMeter
        /// vv: 1 pascal [Pa] to 1 newton/square meter
        /// </summary>
        public static double Pascal_2_NewtonPerSquareMeter(double inVal)                => inVal / 1;

        /// <summary>
        /// NewtonPerSquareCentimeter -> Pa
        /// 1 newton/square centimeter =  10000 pascal [Pa]
        /// </summary>
        public static double NewtonPerSquareCentimeter_2_Pascal(double inVal)           => inVal * 10000;
        /// <summary>
        /// Pa -> NewtonPerSquareCentimeter
        /// vv: 10000 pascal [Pa] to 1 newton/square centimeter
        /// </summary>
        public static double Pascal_2_NewtonPerSquareCentimeter(double inVal)           => inVal / 10000;

        /// <summary>
        /// NewtonPerSquareMillimeter -> Pa
        /// 1 newton/square millimeter =  1000000 pascal [Pa]
        /// </summary>
        public static double NewtonPerSquareMillimeter_2_Pascal(double inVal)           => inVal * 1000000;
        /// <summary>
        /// Pa -> NewtonPerSquareMillimeter
        /// vv: 1000000 pascal [Pa] to 1 newton/square millimeter
        /// </summary>
        public static double Pascal_2_NewtonPerSquareMillimeter(double inVal)           => inVal / 1000000;

        /// <summary>
        /// KilonewtonPerSquareMeter -> Pa
        /// 1 kilonewton/square meter =  1000 pascal [Pa]
        /// </summary>
        public static double KilonewtonPerSquareMeter_2_Pascal(double inVal)            => inVal * 1000;
        /// <summary>
        /// Pa -> KilonewtonPerSquareMeter
        /// vv: 1000 pascal [Pa] to 1 kilonewton/square meter
        /// </summary>
        public static double Pascal_2_KilonewtonPerSquareMeter(double inVal)            => inVal / 1000;

        /// <summary>
        /// mbar -> Pa
        /// 1 millibar [mbar] =  100 pascal [Pa]
        /// </summary>
        public static double Millibar_2_Pascal(double inVal)                            => inVal * 100;
        /// <summary>
        /// Pa -> mbar
        /// vv: 100 pascal [Pa] to 1 millibar [mbar]
        /// </summary>
        public static double Pascal_2_Millibar(double inVal)                            => inVal / 100;

        /// <summary>
        /// µbar -> Pa
        /// 1 microbar [µbar] =  0.1 pascal [Pa]
        /// </summary>
        public static double Microbar_2_Pascal(double inVal)                            => inVal * 0.1;
        /// <summary>
        /// Pa -> µbar
        /// vv: 0.1 pascal [Pa] to 1 microbar [µbar]
        /// </summary>
        public static double Pascal_2_Microbar(double inVal)                            => inVal / 0.1;

        /// <summary>
        /// DynePerSquareCentimeter -> Pa
        /// 1 dyne/square centimeter =  0.1 pascal [Pa]
        /// </summary>
        public static double DynePerSquareCentimeter_2_Pascal(double inVal)             => inVal * 0.1;
        /// <summary>
        /// Pa -> DynePerSquareCentimeter
        /// vv: 0.1 pascal [Pa] to 1 dyne/square centimeter
        /// </summary>
        public static double Pascal_2_DynePerSquareCentimeter(double inVal)             => inVal / 0.1;

        /// <summary>
        /// KilogramForcePerSquareMeter -> Pa
        /// 1 kilogram-force/square meter =  9.80665 pascal [Pa]
        /// </summary>
        public static double KilogramForcePerSquareMeter_2_Pascal(double inVal)         => inVal * 9.80665;
        /// <summary>
        /// Pa -> KilogramForcePerSquareMeter
        /// vv: 9.80665 pascal [Pa] to 1 kilogram-force/square meter
        /// </summary>
        public static double Pascal_2_KilogramForcePerSquareMeter(double inVal)         => inVal / 9.80665;

        /// <summary>
        /// KilogramForcePerSquareCm -> Pa
        /// 1 kilogram-force/Square cm =  98066.5 pascal [Pa]
        /// </summary>
        public static double KilogramForcePerSquareCm_2_Pascal(double inVal)               => inVal * 98066.5;
        /// <summary>
        /// Pa -> KilogramForcePerSquareCm
        /// vv: 98066.5 pascal [Pa] to 1 kilogram-force/Square cm
        /// </summary>
        public static double Pascal_2_KilogramForcePerSquareCm(double inVal)               => inVal / 98066.5;

        /// <summary>
        /// KilogramForcePerSquareMillimeter -> Pa
        /// 1 kilogram-force/Square millimeter =  9806650 pascal [Pa]
        /// </summary>
        public static double KilogramForcePerSquareMillimeter_2_Pascal(double inVal)       => inVal * 9806650;
        /// <summary>
        /// Pa -> KilogramForcePerSquareMillimeter
        /// vv: 9806650 pascal [Pa] to 1 kilogram-force/Square millimeter
        /// </summary>
        public static double Pascal_2_KilogramForcePerSquareMillimeter(double inVal)       => inVal / 9806650;

        /// <summary>
        /// GramForcePerSquareCentimeter -> Pa
        /// 1 gram-force/Square centimeter =  98.0665 pascal [Pa]
        /// </summary>
        public static double GramForcePerSquareCentimeter_2_Pascal(double inVal)           => inVal * 98.0665;
        /// <summary>
        /// Pa -> GramForcePerSquareCentimeter
        /// vv: 98.0665 pascal [Pa] to 1 gram-force/Square centimeter
        /// </summary>
        public static double Pascal_2_GramForcePerSquareCentimeter(double inVal)           => inVal / 98.0665;

        /// <summary>
        /// TonForceShortPerSquareFoot -> Pa
        /// 1 ton-force (short)/Square foot =  95760.517960678 pascal [Pa]
        /// </summary>
        public static double TonForceShortPerSquareFoot_2_Pascal(double inVal)             => inVal * 95760.517960678;
        /// <summary>
        /// Pa -> TonForceShortPerSquareFoot
        /// vv: 95760.517960678 pascal [Pa] to 1 ton-force (short)/Square foot
        /// </summary>
        public static double Pascal_2_TonForceShortPerSquareFoot(double inVal)             => inVal / 95760.517960678;

        /// <summary>
        /// TonForceShortPerSquareInch -> Pa
        /// 1 ton-force (short)/Square inch =  13789514.586338 pascal [Pa]
        /// </summary>
        public static double TonForceShortPerSquareInch_2_Pascal(double inVal)             => inVal * 13789514.586338;
        /// <summary>
        /// Pa -> TonForceShortPerSquareInch
        /// vv: 13789514.586338 pascal [Pa] to 1 ton-force (short)/Square inch
        /// </summary>
        public static double Pascal_2_TonForceShortPerSquareInch(double inVal)             => inVal / 13789514.586338;

        /// <summary>
        /// TonForceLongPerSquareFoot -> Pa
        /// 1 ton-force (long)/square foot =  107251.78011595 pascal [Pa]
        /// </summary>
        public static double TonForceLongPerSquareFoot_2_Pascal(double inVal)           => inVal * 107251.78011595;
        /// <summary>
        /// Pa -> TonForceLongPerSquareFoot
        /// vv: 107251.78011595 pascal [Pa] to 1 ton-force (long)/square foot
        /// </summary>
        public static double Pascal_2_TonForceLongPerSquareFoot(double inVal)           => inVal / 107251.78011595;

        /// <summary>
        /// TonForceLongPerSquareInch -> Pa
        /// 1 ton-force (long)/square inch =  15444256.336697 pascal [Pa]
        /// </summary>
        public static double TonForceLongPerSquareInch_2_Pascal(double inVal)           => inVal * 15444256.336697;
        /// <summary>
        /// Pa -> TonForceLongPerSquareInch
        /// vv: 15444256.336697 pascal [Pa] to 1 ton-force (long)/square inch
        /// </summary>
        public static double Pascal_2_TonForceLongPerSquareInch(double inVal)           => inVal / 15444256.336697;

        /// <summary>
        /// KipForcePerSquareInch -> Pa
        /// 1 kip-force/square inch =  6894757.2931783 pascal [Pa]
        /// </summary>
        public static double KipForcePerSquareInch_2_Pascal(double inVal)               => inVal * 6894757.2931783;
        /// <summary>
        /// Pa -> KipForcePerSquareInch
        /// vv: 6894757.2931783 pascal [Pa] to 1 kip-force/square inch
        /// </summary>
        public static double Pascal_2_KipForcePerSquareInch(double inVal)               => inVal / 6894757.2931783;

        /// <summary>
        /// PoundForcePerSquareFoot -> Pa
        /// 1 pound-force/square foot =  47.8802589804 pascal [Pa]
        /// </summary>
        public static double PoundForcePerSquareFoot_2_Pascal(double inVal)             => inVal * 47.8802589804;
        /// <summary>
        /// Pa -> PoundForcePerSquareFoot
        /// vv: 47.8802589804 pascal [Pa] to 1 pound-force/square foot
        /// </summary>
        public static double Pascal_2_PoundForcePerSquareFoot(double inVal)             => inVal / 47.8802589804;

        /// <summary>
        /// PoundForcePerSquareInch -> Pa
        /// 1 pound-force/square inch =  6894.7572931783 pascal [Pa]
        /// </summary>
        public static double PoundForcePerSquareInch_2_Pascal(double inVal)             => inVal * 6894.7572931783;
        /// <summary>
        /// Pa -> PoundForcePerSquareInch
        /// vv: 6894.7572931783 pascal [Pa] to 1 pound-force/square inch
        /// </summary>
        public static double Pascal_2_PoundForcePerSquareInch(double inVal)             => inVal / 6894.7572931783;

        /// <summary>
        /// PoundalPerSquareFoot -> Pa
        /// 1 poundal/square foot =  1.4881639436 pascal [Pa]
        /// </summary>
        public static double PoundalPerSquareFoot_2_Pascal(double inVal)                => inVal * 1.4881639436;
        /// <summary>
        /// Pa -> PoundalPerSquareFoot
        /// vv: 1.4881639436 pascal [Pa] to 1 poundal/square foot
        /// </summary>
        public static double Pascal_2_PoundalPerSquareFoot(double inVal)                => inVal / 1.4881639436;

        /// <summary>
        /// Torr -> Pa
        /// 1 torr [Torr] =  133.3223684211 pascal [Pa]
        /// </summary>
        public static double Torr_2_Pascal(double inVal)                                => inVal * 133.3223684211;
        /// <summary>
        /// Pa -> Torr
        /// vv: 133.3223684211 pascal [Pa] to 1 torr [Torr]
        /// </summary>
        public static double Pascal_2_Torr(double inVal)                                => inVal / 133.3223684211;

        /// <summary>
        /// CentimeterMercury0DegC -> Pa
        /// 1 centimeter mercury (0°C) =  1333.22 pascal [Pa]
        /// </summary>
        public static double CentimeterMercury0DegC_2_Pascal(double inVal)              => inVal * 1333.22;
        /// <summary>
        /// Pa -> CentimeterMercury0DegC
        /// vv: 1333.22 pascal [Pa] to 1 centimeter mercury (0°C)
        /// </summary>
        public static double Pascal_2_CentimeterMercury0DegC(double inVal)              => inVal / 1333.22;

        /// <summary>
        /// MillimeterMercury0DegC -> Pa
        /// 1 millimeter mercury (0°C) =  133.322 pascal [Pa]
        /// </summary>
        public static double MillimeterMercury0DegC_2_Pascal(double inVal)              => inVal * 133.322;
        /// <summary>
        /// Pa -> MillimeterMercury0DegC
        /// vv: 133.322 pascal [Pa] to 1 millimeter mercury (0°C)
        /// </summary>
        public static double Pascal_2_MillimeterMercury0DegC(double inVal)              => inVal / 133.322;

        /// <summary>
        /// inHg -> Pa
        /// 1 inch mercury (32°F) [inHg] =  3386.38 pascal [Pa]
        /// </summary>
        public static double InchMercury32DegF_2_Pascal(double inVal)                   => inVal * 3386.38;
        /// <summary>
        /// Pa -> inHg
        /// vv: 3386.38 pascal [Pa] to 1 inch mercury (32°F) [inHg]
        /// </summary>
        public static double Pascal_2_InchMercury32DegF(double inVal)                   => inVal / 3386.38;

        /// <summary>
        /// inHg -> Pa
        /// 1 inch mercury (60°F) [inHg] =  3376.85 pascal [Pa]
        /// </summary>
        public static double InchMercury60DegF_2_Pascal(double inVal)                   => inVal * 3376.85;
        /// <summary>
        /// Pa -> inHg
        /// vv: 3376.85 pascal [Pa] to 1 inch mercury (60°F) [inHg]
        /// </summary>
        public static double Pascal_2_InchMercury60DegF(double inVal)                   => inVal / 3376.85;

        /// <summary>
        /// CentimeterWater4DegC -> Pa
        /// 1 centimeter water (4°C) =  98.0638 pascal [Pa]
        /// </summary>
        public static double CentimeterWater4DegC_2_Pascal(double inVal)                => inVal * 98.0638;
        /// <summary>
        /// Pa -> CentimeterWater4DegC
        /// vv: 98.0638 pascal [Pa] to 1 centimeter water (4°C)
        /// </summary>
        public static double Pascal_2_CentimeterWater4DegC(double inVal)                => inVal / 98.0638;

        /// <summary>
        /// MillimeterWater4DegC -> Pa
        /// 1 millimeter water (4°C) =  9.80638 pascal [Pa]
        /// </summary>
        public static double MillimeterWater4DegC_2_Pascal(double inVal)                => inVal * 9.80638;
        /// <summary>
        /// Pa -> MillimeterWater4DegC
        /// vv: 9.80638 pascal [Pa] to 1 millimeter water (4°C)
        /// </summary>
        public static double Pascal_2_MillimeterWater4DegC(double inVal)                => inVal / 9.80638;

        /// <summary>
        /// inAq -> Pa
        /// 1 inch water (4°C) [inAq] =  249.082 pascal [Pa]
        /// </summary>
        public static double InchWater4DegC_2_Pascal(double inVal)                      => inVal * 249.082;
        /// <summary>
        /// Pa -> inAq
        /// vv: 249.082 pascal [Pa] to 1 inch water (4°C) [inAq]
        /// </summary>
        public static double Pascal_2_InchWater4DegC(double inVal)                      => inVal / 249.082;

        /// <summary>
        /// ftAq -> Pa
        /// 1 foot water (4°C) [ftAq] =  2988.98 pascal [Pa]
        /// </summary>
        public static double FootWater4DegC_2_Pascal(double inVal)                      => inVal * 2988.98;
        /// <summary>
        /// Pa -> ftAq
        /// vv: 2988.98 pascal [Pa] to 1 foot water (4°C) [ftAq]
        /// </summary>
        public static double Pascal_2_FootWater4DegC(double inVal)                      => inVal / 2988.98;

        /// <summary>
        /// inAq -> Pa
        /// 1 inch water (60°F) [inAq] =  248.843 pascal [Pa]
        /// </summary>
        public static double InchWater60DegF_2_Pascal(double inVal)                     => inVal * 248.843;
        /// <summary>
        /// Pa -> inAq
        /// vv: 248.843 pascal [Pa] to 1 inch water (60°F) [inAq]
        /// </summary>
        public static double Pascal_2_InchWater60DegF(double inVal)                     => inVal / 248.843;

        /// <summary>
        /// ftAq -> Pa
        /// 1 foot water (60°F) [ftAq] =  2986.116 pascal [Pa]
        /// </summary>
        public static double FootWater60DegF_2_Pascal(double inVal)                     => inVal * 2986.116;
        /// <summary>
        /// Pa -> ftAq
        /// vv: 2986.116 pascal [Pa] to 1 foot water (60°F) [ftAq]
        /// </summary>
        public static double Pascal_2_FootWater60DegF(double inVal)                     => inVal / 2986.116;

        /// <summary>
        /// at -> Pa
        /// 1 atmosphere technical [at] =  98066.500000003 pascal [Pa]
        /// </summary>
        public static double AtmosphereTechnical_2_Pascal(double inVal)                 => inVal * 98066.500000003;
        /// <summary>
        /// Pa -> at
        /// vv: 98066.500000003 pascal [Pa] to 1 atmosphere technical [at]
        /// </summary>
        public static double Pascal_2_AtmosphereTechnical(double inVal)                 => inVal / 98066.500000003;

        #endregion
    }
}
