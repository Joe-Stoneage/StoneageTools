
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region magnetic - magnetomotive force, base: ampere turn

        /// <summary>
        /// kAt -> At
        /// 1 kiloampere turn [kAt] =  1000 ampere turn [At]
        /// </summary>
        public static double KiloampereTurn_2_AmpereTurn(double inVal)                  => inVal * 1000;
        /// <summary>
        /// At -> kAt
        /// vv: 1000 ampere turn [At] to 1 kiloampere turn [kAt]
        /// </summary>
        public static double AmpereTurn_2_KiloampereTurn(double inVal)                  => inVal / 1000;

        /// <summary>
        /// mAt -> At
        /// 1 milliampere turn [mAt] =  0.001 ampere turn [At]
        /// </summary>
        public static double MilliampereTurn_2_AmpereTurn(double inVal)                 => inVal * 0.001;
        /// <summary>
        /// At -> mAt
        /// vv: 0.001 ampere turn [At] to 1 milliampere turn [mAt]
        /// </summary>
        public static double AmpereTurn_2_MilliampereTurn(double inVal)                 => inVal / 0.001;

        /// <summary>
        /// abAt -> At
        /// 1 abampere turn [abAt] =  10 ampere turn [At]
        /// </summary>
        public static double AbampereTurn_2_AmpereTurn(double inVal)                    => inVal * 10;
        /// <summary>
        /// At -> abAt
        /// vv: 10 ampere turn [At] to 1 abampere turn [abAt]
        /// </summary>
        public static double AmpereTurn_2_AbampereTurn(double inVal)                    => inVal / 10;

        /// <summary>
        /// Gi -> At
        /// 1 gilbert [Gi] =  0.7957747151 ampere turn [At]
        /// </summary>
        public static double Gilbert_2_AmpereTurn(double inVal)                         => inVal * 0.7957747151;
        /// <summary>
        /// At -> Gi
        /// vv: 0.7957747151 ampere turn [At] to 1 gilbert [Gi]
        /// </summary>
        public static double AmpereTurn_2_Gilbert(double inVal)                         => inVal / 0.7957747151;

        #endregion

        #region magnetic - field strength, base: ampere/meter
        /// <summary>
        /// At/m -> A/m
        /// 1 ampere turn/meter [At/m] =  1 ampere/meter [A/m]
        /// </summary>
        public static double AmpereTurnPerMeter_2_AmperePerMeter(double inVal)          => inVal * 1;
        /// <summary>
        /// A/m -> At/m
        /// vv: 1 ampere/meter [A/m] to 1 ampere turn/meter [At/m]
        /// </summary>
        public static double AmperePerMeter_2_AmpereTurnPerMeter(double inVal)          => inVal / 1;

        /// <summary>
        /// kA/m -> A/m
        /// 1 kiloampere/meter [kA/m] =  1000 ampere/meter [A/m]
        /// </summary>
        public static double KiloamperePerMeter_2_AmperePerMeter(double inVal)          => inVal * 1000;
        /// <summary>
        /// A/m -> kA/m
        /// vv: 1000 ampere/meter [A/m] to 1 kiloampere/meter [kA/m]
        /// </summary>
        public static double AmperePerMeter_2_KiloamperePerMeter(double inVal)          => inVal / 1000;

        #endregion

        #region magnetic - flux, base: weber

        /// <summary>
        /// mWb -> Wb
        /// 1 milliweber [mWb] =  0.001 weber [Wb]
        /// </summary>
        public static double Milliweber_2_Weber(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// Wb -> mWb
        /// vv: 0.001 weber [Wb] to 1 milliweber [mWb]
        /// </summary>
        public static double Weber_2_Milliweber(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// µWb -> Wb
        /// 1 microweber [µWb] =  1.0E-6 weber [Wb]
        /// </summary>
        public static double Microweber_2_Weber(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// Wb -> µWb
        /// vv: 1.0E-6 weber [Wb] to 1 microweber [µWb]
        /// </summary>
        public static double Weber_2_Microweber(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// V*s -> Wb
        /// 1 volt second [V*s] =  1 weber [Wb]
        /// </summary>
        public static double VoltSecond_2_Weber(double inVal)                           => inVal * 1;
        /// <summary>
        /// Wb -> V*s
        /// vv: 1 weber [Wb] to 1 volt second [V*s]
        /// </summary>
        public static double Weber_2_VoltSecond(double inVal)                           => inVal / 1;

        /// <summary>
        /// UnitPole -> Wb
        /// 1 unit pole =  1.256637061436E-7 weber [Wb]
        /// </summary>
        public static double UnitPole_2_Weber(double inVal)                             => inVal * 1.256637061436E-7;
        /// <summary>
        /// Wb -> UnitPole
        /// vv: 1.256637061436E-7 weber [Wb] to 1 unit pole
        /// </summary>
        public static double Weber_2_UnitPole(double inVal)                             => inVal / 1.256637061436E-7;

        /// <summary>
        /// Megaline -> Wb
        /// 1 megaline =  0.01 weber [Wb]
        /// </summary>
        public static double Megaline_2_Weber(double inVal)                             => inVal * 0.01;
        /// <summary>
        /// Wb -> Megaline
        /// vv: 0.01 weber [Wb] to 1 megaline
        /// </summary>
        public static double Weber_2_Megaline(double inVal)                             => inVal / 0.01;

        /// <summary>
        /// Kiloline -> Wb
        /// 1 kiloline =  1.0E-5 weber [Wb]
        /// </summary>
        public static double Kiloline_2_Weber(double inVal)                             => inVal * 1.0E-5;
        /// <summary>
        /// Wb -> Kiloline
        /// vv: 1.0E-5 weber [Wb] to 1 kiloline
        /// </summary>
        public static double Weber_2_Kiloline(double inVal)                             => inVal / 1.0E-5;

        /// <summary>
        /// Line -> Wb
        /// 1 line =  1.0E-8 weber [Wb]
        /// </summary>
        public static double Line_2_Weber(double inVal)                                 => inVal * 1.0E-8;
        /// <summary>
        /// Wb -> Line
        /// vv: 1.0E-8 weber [Wb] to 1 line
        /// </summary>
        public static double Weber_2_Line(double inVal)                                 => inVal / 1.0E-8;

        /// <summary>
        /// Mx -> Wb
        /// 1 maxwell [Mx] =  1.0E-8 weber [Wb]
        /// </summary>
        public static double Maxwell_2_Weber(double inVal)                              => inVal * 1.0E-8;
        /// <summary>
        /// Wb -> Mx
        /// vv: 1.0E-8 weber [Wb] to 1 maxwell [Mx]
        /// </summary>
        public static double Weber_2_Maxwell(double inVal)                              => inVal / 1.0E-8;

        /// <summary>
        /// T*m^2 -> Wb
        /// 1 tesla square meter [T*m^2] =  1 weber [Wb]
        /// </summary>
        public static double TeslaSquareMeter_2_Weber(double inVal)                     => inVal * 1;
        /// <summary>
        /// Wb -> T*m^2
        /// vv: 1 weber [Wb] to 1 tesla square meter [T*m^2]
        /// </summary>
        public static double Weber_2_TeslaSquareMeter(double inVal)                     => inVal / 1;

        /// <summary>
        /// TeslaSquareCentimeter -> Wb
        /// 1 tesla square centimeter =  0.0001 weber [Wb]
        /// </summary>
        public static double TeslaSquareCentimeter_2_Weber(double inVal)                => inVal * 0.0001;
        /// <summary>
        /// Wb -> TeslaSquareCentimeter
        /// vv: 0.0001 weber [Wb] to 1 tesla square centimeter
        /// </summary>
        public static double Weber_2_TeslaSquareCentimeter(double inVal)                => inVal / 0.0001;

        /// <summary>
        /// GaussSquareCentimeter -> Wb
        /// 1 gauss square centimeter =  1.0E-8 weber [Wb]
        /// </summary>
        public static double GaussSquareCentimeter_2_Weber(double inVal)                => inVal * 1.0E-8;
        /// <summary>
        /// Wb -> GaussSquareCentimeter
        /// vv: 1.0E-8 weber [Wb] to 1 gauss square centimeter
        /// </summary>
        public static double Weber_2_GaussSquareCentimeter(double inVal)                => inVal / 1.0E-8;

        /// <summary>
        /// MagneticFluxQuantum -> Wb
        /// 1 Magnetic flux quantum =  2.06783461E-15 weber [Wb]
        /// </summary>
        public static double MagneticFluxQuantum_2_Weber(double inVal)                  => inVal * 2.06783461E-15;
        /// <summary>
        /// Wb -> MagneticFluxQuantum
        /// vv: 2.06783461E-15 weber [Wb] to 1 Magnetic flux quantum
        /// </summary>
        public static double Weber_2_MagneticFluxQuantum(double inVal)                  => inVal / 2.06783461E-15;

        #endregion

        #region magnetic - flux density, base: tesla

        /// <summary>
        /// WeberPerSquareMeter -> T
        /// 1 weber/square meter =  1 tesla [T]
        /// </summary>
        public static double WeberPerSquareMeter_2_Tesla(double inVal)                  => inVal * 1;
        /// <summary>
        /// T -> WeberPerSquareMeter
        /// vv: 1 tesla [T] to 1 weber/square meter
        /// </summary>
        public static double Tesla_2_WeberPerSquareMeter(double inVal)                  => inVal / 1;

        /// <summary>
        /// WeberPerSquareCentimeter -> T
        /// 1 weber/square centimeter =  10000 tesla [T]
        /// </summary>
        public static double WeberPerSquareCentimeter_2_Tesla(double inVal)             => inVal * 10000;
        /// <summary>
        /// T -> WeberPerSquareCentimeter
        /// vv: 10000 tesla [T] to 1 weber/square centimeter
        /// </summary>
        public static double Tesla_2_WeberPerSquareCentimeter(double inVal)             => inVal / 10000;

        /// <summary>
        /// Wb/in^2 -> T
        /// 1 weber/square inch [Wb/in^2] =  1550.0031000062 tesla [T]
        /// </summary>
        public static double WeberPerSquareInch_2_Tesla(double inVal)                   => inVal * 1550.0031000062;
        /// <summary>
        /// T -> Wb/in^2
        /// vv: 1550.0031000062 tesla [T] to 1 weber/square inch [Wb/in^2]
        /// </summary>
        public static double Tesla_2_WeberPerSquareInch(double inVal)                   => inVal / 1550.0031000062;

        /// <summary>
        /// MaxwellPerSquareMeter -> T
        /// 1 maxwell/square meter =  1 tesla [T]
        /// </summary>
        public static double MaxwellPerSquareMeter_2_Tesla(double inVal)                => inVal * 1;
        /// <summary>
        /// T -> MaxwellPerSquareMeter
        /// vv: 1 tesla [T] to 1 maxwell/square meter
        /// </summary>
        public static double Tesla_2_MaxwellPerSquareMeter(double inVal)                => inVal / 1;

        /// <summary>
        /// MaxwellPerSquareCentimeter -> T
        /// 1 maxwell/square centimeter =  0.0001 tesla [T]
        /// </summary>
        public static double MaxwellPerSquareCentimeter_2_Tesla(double inVal)           => inVal * 0.0001;
        /// <summary>
        /// T -> MaxwellPerSquareCentimeter
        /// vv: 0.0001 tesla [T] to 1 maxwell/square centimeter
        /// </summary>
        public static double Tesla_2_MaxwellPerSquareCentimeter(double inVal)           => inVal / 0.0001;

        /// <summary>
        /// Mx/in^2 -> T
        /// 1 maxwell/square inch [Mx/in^2] =  1.55E-5 tesla [T]
        /// </summary>
        public static double MaxwellPerSquareInch_2_Tesla(double inVal)                 => inVal * 1.55E-5;
        /// <summary>
        /// T -> Mx/in^2
        /// vv: 1.55E-5 tesla [T] to 1 maxwell/square inch [Mx/in^2]
        /// </summary>
        public static double Tesla_2_MaxwellPerSquareInch(double inVal)                 => inVal / 1.55E-5;

        /// <summary>
        /// Gs, G -> T
        /// 1 gauss [Gs, G] =  0.0001 tesla [T]
        /// </summary>
        public static double Gauss_2_Tesla(double inVal)                                => inVal * 0.0001;
        /// <summary>
        /// T -> Gs, G
        /// vv: 0.0001 tesla [T] to 1 gauss [Gs, G]
        /// </summary>
        public static double Tesla_2_Gauss(double inVal)                                => inVal / 0.0001;

        /// <summary>
        /// LinePerSquareCentimeter -> T
        /// 1 line/square centimeter =  0.0001 tesla [T]
        /// </summary>
        public static double LinePerSquareCentimeter_2_Tesla(double inVal)              => inVal * 0.0001;
        /// <summary>
        /// T -> LinePerSquareCentimeter
        /// vv: 0.0001 tesla [T] to 1 line/square centimeter
        /// </summary>
        public static double Tesla_2_LinePerSquareCentimeter(double inVal)              => inVal / 0.0001;

        /// <summary>
        /// LinePerSquareInch -> T
        /// 1 line/square inch =  1.55E-5 tesla [T]
        /// </summary>
        public static double LinePerSquareInch_2_Tesla(double inVal)                    => inVal * 1.55E-5;
        /// <summary>
        /// T -> LinePerSquareInch
        /// vv: 1.55E-5 tesla [T] to 1 line/square inch
        /// </summary>
        public static double Tesla_2_LinePerSquareInch(double inVal)                    => inVal / 1.55E-5;

        /// <summary>
        /// Gamma -> T
        /// 1 gamma =  1.0E-9 tesla [T]
        /// </summary>
        public static double Gamma_2_Tesla(double inVal)                                => inVal * 1.0E-9;
        /// <summary>
        /// T -> Gamma
        /// vv: 1.0E-9 tesla [T] to 1 gamma
        /// </summary>
        public static double Tesla_2_Gamma(double inVal)                                => inVal / 1.0E-9;

        #endregion
    }
}
