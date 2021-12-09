
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region radiology - units, base: gray/second

        /// <summary>
        /// EGy/s -> Gy/s
        /// 1 exagray/second [EGy/s] =  1.0E+18 gray/second [Gy/s]
        /// </summary>
        public static double ExagrayPerSecond_2_GrayPerSecond(double inVal)             => inVal * 1.0E+18;
        /// <summary>
        /// Gy/s -> EGy/s
        /// vv: 1.0E+18 gray/second [Gy/s] to 1 exagray/second [EGy/s]
        /// </summary>
        public static double GrayPerSecond_2_ExagrayPerSecond(double inVal)             => inVal / 1.0E+18;

        /// <summary>
        /// PGy/s -> Gy/s
        /// 1 petagray/second [PGy/s] =  1.0E+15 gray/second [Gy/s]
        /// </summary>
        public static double PetagrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1.0E+15;
        /// <summary>
        /// Gy/s -> PGy/s
        /// vv: 1.0E+15 gray/second [Gy/s] to 1 petagray/second [PGy/s]
        /// </summary>
        public static double GrayPerSecond_2_PetagrayPerSecond(double inVal)            => inVal / 1.0E+15;

        /// <summary>
        /// TGy/s -> Gy/s
        /// 1 teragray/second [TGy/s] =  1000000000000 gray/second [Gy/s]
        /// </summary>
        public static double TeragrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1000000000000;
        /// <summary>
        /// Gy/s -> TGy/s
        /// vv: 1000000000000 gray/second [Gy/s] to 1 teragray/second [TGy/s]
        /// </summary>
        public static double GrayPerSecond_2_TeragrayPerSecond(double inVal)            => inVal / 1000000000000;

        /// <summary>
        /// GGy/s -> Gy/s
        /// 1 gigagray/second [GGy/s] =  1000000000 gray/second [Gy/s]
        /// </summary>
        public static double GigagrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1000000000;
        /// <summary>
        /// Gy/s -> GGy/s
        /// vv: 1000000000 gray/second [Gy/s] to 1 gigagray/second [GGy/s]
        /// </summary>
        public static double GrayPerSecond_2_GigagrayPerSecond(double inVal)            => inVal / 1000000000;

        /// <summary>
        /// MGy/s -> Gy/s
        /// 1 megagray/second [MGy/s] =  1000000 gray/second [Gy/s]
        /// </summary>
        public static double MegagrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1000000;
        /// <summary>
        /// Gy/s -> MGy/s
        /// vv: 1000000 gray/second [Gy/s] to 1 megagray/second [MGy/s]
        /// </summary>
        public static double GrayPerSecond_2_MegagrayPerSecond(double inVal)            => inVal / 1000000;

        /// <summary>
        /// kGy/s -> Gy/s
        /// 1 kilogray/second [kGy/s] =  1000 gray/second [Gy/s]
        /// </summary>
        public static double KilograyPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1000;
        /// <summary>
        /// Gy/s -> kGy/s
        /// vv: 1000 gray/second [Gy/s] to 1 kilogray/second [kGy/s]
        /// </summary>
        public static double GrayPerSecond_2_KilograyPerSecond(double inVal)            => inVal / 1000;

        /// <summary>
        /// hGy/s -> Gy/s
        /// 1 hectogray/second [hGy/s] =  100 gray/second [Gy/s]
        /// </summary>
        public static double HectograyPerSecond_2_GrayPerSecond(double inVal)           => inVal * 100;
        /// <summary>
        /// Gy/s -> hGy/s
        /// vv: 100 gray/second [Gy/s] to 1 hectogray/second [hGy/s]
        /// </summary>
        public static double GrayPerSecond_2_HectograyPerSecond(double inVal)           => inVal / 100;

        /// <summary>
        /// daGy/s -> Gy/s
        /// 1 dekagray/second [daGy/s] =  10 gray/second [Gy/s]
        /// </summary>
        public static double DekagrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 10;
        /// <summary>
        /// Gy/s -> daGy/s
        /// vv: 10 gray/second [Gy/s] to 1 dekagray/second [daGy/s]
        /// </summary>
        public static double GrayPerSecond_2_DekagrayPerSecond(double inVal)            => inVal / 10;

        /// <summary>
        /// dGy/s -> Gy/s
        /// 1 decigray/second [dGy/s] =  0.1 gray/second [Gy/s]
        /// </summary>
        public static double DecigrayPerSecond_2_GrayPerSecond(double inVal)            => inVal * 0.1;
        /// <summary>
        /// Gy/s -> dGy/s
        /// vv: 0.1 gray/second [Gy/s] to 1 decigray/second [dGy/s]
        /// </summary>
        public static double GrayPerSecond_2_DecigrayPerSecond(double inVal)            => inVal / 0.1;

        /// <summary>
        /// cGy/s -> Gy/s
        /// 1 centigray/second [cGy/s] =  0.01 gray/second [Gy/s]
        /// </summary>
        public static double CentigrayPerSecond_2_GrayPerSecond(double inVal)           => inVal * 0.01;
        /// <summary>
        /// Gy/s -> cGy/s
        /// vv: 0.01 gray/second [Gy/s] to 1 centigray/second [cGy/s]
        /// </summary>
        public static double GrayPerSecond_2_CentigrayPerSecond(double inVal)           => inVal / 0.01;

        /// <summary>
        /// mGy/s -> Gy/s
        /// 1 milligray/second [mGy/s] =  0.001 gray/second [Gy/s]
        /// </summary>
        public static double MilligrayPerSecond_2_GrayPerSecond(double inVal)           => inVal * 0.001;
        /// <summary>
        /// Gy/s -> mGy/s
        /// vv: 0.001 gray/second [Gy/s] to 1 milligray/second [mGy/s]
        /// </summary>
        public static double GrayPerSecond_2_MilligrayPerSecond(double inVal)           => inVal / 0.001;

        /// <summary>
        /// µGy/s -> Gy/s
        /// 1 microgray/second [µGy/s] =  1.0E-6 gray/second [Gy/s]
        /// </summary>
        public static double MicrograyPerSecond_2_GrayPerSecond(double inVal)           => inVal * 1.0E-6;
        /// <summary>
        /// Gy/s -> µGy/s
        /// vv: 1.0E-6 gray/second [Gy/s] to 1 microgray/second [µGy/s]
        /// </summary>
        public static double GrayPerSecond_2_MicrograyPerSecond(double inVal)           => inVal / 1.0E-6;

        /// <summary>
        /// nGy/s -> Gy/s
        /// 1 nanogray/second [nGy/s] =  1.0E-9 gray/second [Gy/s]
        /// </summary>
        public static double NanograyPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1.0E-9;
        /// <summary>
        /// Gy/s -> nGy/s
        /// vv: 1.0E-9 gray/second [Gy/s] to 1 nanogray/second [nGy/s]
        /// </summary>
        public static double GrayPerSecond_2_NanograyPerSecond(double inVal)            => inVal / 1.0E-9;

        /// <summary>
        /// pGy/s -> Gy/s
        /// 1 picogray/second [pGy/s] =  1.0E-12 gray/second [Gy/s]
        /// </summary>
        public static double PicograyPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1.0E-12;
        /// <summary>
        /// Gy/s -> pGy/s
        /// vv: 1.0E-12 gray/second [Gy/s] to 1 picogray/second [pGy/s]
        /// </summary>
        public static double GrayPerSecond_2_PicograyPerSecond(double inVal)            => inVal / 1.0E-12;

        /// <summary>
        /// fGy/s -> Gy/s
        /// 1 femtogray/second [fGy/s] =  1.0E-15 gray/second [Gy/s]
        /// </summary>
        public static double FemtograyPerSecond_2_GrayPerSecond(double inVal)           => inVal * 1.0E-15;
        /// <summary>
        /// Gy/s -> fGy/s
        /// vv: 1.0E-15 gray/second [Gy/s] to 1 femtogray/second [fGy/s]
        /// </summary>
        public static double GrayPerSecond_2_FemtograyPerSecond(double inVal)           => inVal / 1.0E-15;

        /// <summary>
        /// aGy/s -> Gy/s
        /// 1 attogray/second [aGy/s] =  1.0E-18 gray/second [Gy/s]
        /// </summary>
        public static double AttograyPerSecond_2_GrayPerSecond(double inVal)            => inVal * 1.0E-18;
        /// <summary>
        /// Gy/s -> aGy/s
        /// vv: 1.0E-18 gray/second [Gy/s] to 1 attogray/second [aGy/s]
        /// </summary>
        public static double GrayPerSecond_2_AttograyPerSecond(double inVal)            => inVal / 1.0E-18;

        /// <summary>
        /// rd/s, rad/s -> Gy/s
        /// 1 rad/second [rd/s, rad/s] =  0.01 gray/second [Gy/s]
        /// </summary>
        public static double RadPerSecond_2_GrayPerSecond(double inVal)                 => inVal * 0.01;
        /// <summary>
        /// Gy/s -> rd/s, rad/s
        /// vv: 0.01 gray/second [Gy/s] to 1 rad/second [rd/s, rad/s]
        /// </summary>
        public static double GrayPerSecond_2_RadPerSecond(double inVal)                 => inVal / 0.01;

        /// <summary>
        /// JoulePerKilogramPerSecond -> Gy/s
        /// 1 joule/kilogram/second =  1 gray/second [Gy/s]
        /// </summary>
        public static double JoulePerKilogramPerSecond_2_GrayPerSecond(double inVal)    => inVal * 1;
        /// <summary>
        /// Gy/s -> JoulePerKilogramPerSecond
        /// vv: 1 gray/second [Gy/s] to 1 joule/kilogram/second
        /// </summary>
        public static double GrayPerSecond_2_JoulePerKilogramPerSecond(double inVal)    => inVal / 1;

        /// <summary>
        /// W/kg -> Gy/s
        /// 1 watt/kilogram [W/kg] =  1 gray/second [Gy/s]
        /// </summary>
        public static double WattPerKilogram_2_GrayPerSecond(double inVal)              => inVal * 1;
        /// <summary>
        /// Gy/s -> W/kg
        /// vv: 1 gray/second [Gy/s] to 1 watt/kilogram [W/kg]
        /// </summary>
        public static double GrayPerSecond_2_WattPerKilogram(double inVal)              => inVal / 1;

        /// <summary>
        /// Sv/s -> Gy/s
        /// 1 sievert/second [Sv/s] =  1 gray/second [Gy/s]
        /// </summary>
        public static double SievertPerSecond_2_GrayPerSecond(double inVal)             => inVal * 1;
        /// <summary>
        /// Gy/s -> Sv/s
        /// vv: 1 gray/second [Gy/s] to 1 sievert/second [Sv/s]
        /// </summary>
        public static double GrayPerSecond_2_SievertPerSecond(double inVal)             => inVal / 1;

        /// <summary>
        /// rem/s -> Gy/s
        /// 1 rem/second [rem/s] =  0.01 gray/second [Gy/s]
        /// </summary>
        public static double RemPerSecond_2_GrayPerSecond(double inVal)                 => inVal * 0.01;
        /// <summary>
        /// Gy/s -> rem/s
        /// vv: 0.01 gray/second [Gy/s] to 1 rem/second [rem/s]
        /// </summary>
        public static double GrayPerSecond_2_RemPerSecond(double inVal)                 => inVal / 0.01;

        #endregion

        #region radiology - radiation-activity, base: becquerel

        /// <summary>
        /// TBq -> Bq
        /// 1 terabecquerel [TBq] =  1000000000000 becquerel [Bq]
        /// </summary>
        public static double Terabecquerel_2_Becquerel(double inVal)                    => inVal * 1000000000000;
        /// <summary>
        /// Bq -> TBq
        /// vv: 1000000000000 becquerel [Bq] to 1 terabecquerel [TBq]
        /// </summary>
        public static double Becquerel_2_Terabecquerel(double inVal)                    => inVal / 1000000000000;

        /// <summary>
        /// GBq -> Bq
        /// 1 gigabecquerel [GBq] =  1000000000 becquerel [Bq]
        /// </summary>
        public static double Gigabecquerel_2_Becquerel(double inVal)                    => inVal * 1000000000;
        /// <summary>
        /// Bq -> GBq
        /// vv: 1000000000 becquerel [Bq] to 1 gigabecquerel [GBq]
        /// </summary>
        public static double Becquerel_2_Gigabecquerel(double inVal)                    => inVal / 1000000000;

        /// <summary>
        /// MBq -> Bq
        /// 1 megabecquerel [MBq] =  1000000 becquerel [Bq]
        /// </summary>
        public static double Megabecquerel_2_Becquerel(double inVal)                    => inVal * 1000000;
        /// <summary>
        /// Bq -> MBq
        /// vv: 1000000 becquerel [Bq] to 1 megabecquerel [MBq]
        /// </summary>
        public static double Becquerel_2_Megabecquerel(double inVal)                    => inVal / 1000000;

        /// <summary>
        /// kBq -> Bq
        /// 1 kilobecquerel [kBq] =  1000 becquerel [Bq]
        /// </summary>
        public static double Kilobecquerel_2_Becquerel(double inVal)                    => inVal * 1000;
        /// <summary>
        /// Bq -> kBq
        /// vv: 1000 becquerel [Bq] to 1 kilobecquerel [kBq]
        /// </summary>
        public static double Becquerel_2_Kilobecquerel(double inVal)                    => inVal / 1000;

        /// <summary>
        /// mBq -> Bq
        /// 1 millibecquerel [mBq] =  0.001 becquerel [Bq]
        /// </summary>
        public static double Millibecquerel_2_Becquerel(double inVal)                   => inVal * 0.001;
        /// <summary>
        /// Bq -> mBq
        /// vv: 0.001 becquerel [Bq] to 1 millibecquerel [mBq]
        /// </summary>
        public static double Becquerel_2_Millibecquerel(double inVal)                   => inVal / 0.001;

        /// <summary>
        /// Ci -> Bq
        /// 1 curie [Ci] =  37000000000 becquerel [Bq]
        /// </summary>
        public static double Curie_2_Becquerel(double inVal)                            => inVal * 37000000000;
        /// <summary>
        /// Bq -> Ci
        /// vv: 37000000000 becquerel [Bq] to 1 curie [Ci]
        /// </summary>
        public static double Becquerel_2_Curie(double inVal)                            => inVal / 37000000000;

        /// <summary>
        /// kCi -> Bq
        /// 1 kilocurie [kCi] =  37000000000000 becquerel [Bq]
        /// </summary>
        public static double Kilocurie_2_Becquerel(double inVal)                        => inVal * 37000000000000;
        /// <summary>
        /// Bq -> kCi
        /// vv: 37000000000000 becquerel [Bq] to 1 kilocurie [kCi]
        /// </summary>
        public static double Becquerel_2_Kilocurie(double inVal)                        => inVal / 37000000000000;

        /// <summary>
        /// mCi -> Bq
        /// 1 millicurie [mCi] =  37000000 becquerel [Bq]
        /// </summary>
        public static double Millicurie_2_Becquerel(double inVal)                       => inVal * 37000000;
        /// <summary>
        /// Bq -> mCi
        /// vv: 37000000 becquerel [Bq] to 1 millicurie [mCi]
        /// </summary>
        public static double Becquerel_2_Millicurie(double inVal)                       => inVal / 37000000;

        /// <summary>
        /// µCi -> Bq
        /// 1 microcurie [µCi] =  37000 becquerel [Bq]
        /// </summary>
        public static double Microcurie_2_Becquerel(double inVal)                       => inVal * 37000;
        /// <summary>
        /// Bq -> µCi
        /// vv: 37000 becquerel [Bq] to 1 microcurie [µCi]
        /// </summary>
        public static double Becquerel_2_Microcurie(double inVal)                       => inVal / 37000;

        /// <summary>
        /// nCi -> Bq
        /// 1 nanocurie [nCi] =  37 becquerel [Bq]
        /// </summary>
        public static double Nanocurie_2_Becquerel(double inVal)                        => inVal * 37;
        /// <summary>
        /// Bq -> nCi
        /// vv: 37 becquerel [Bq] to 1 nanocurie [nCi]
        /// </summary>
        public static double Becquerel_2_Nanocurie(double inVal)                        => inVal / 37;

        /// <summary>
        /// pCi -> Bq
        /// 1 picocurie [pCi] =  0.037 becquerel [Bq]
        /// </summary>
        public static double Picocurie_2_Becquerel(double inVal)                        => inVal * 0.037;
        /// <summary>
        /// Bq -> pCi
        /// vv: 0.037 becquerel [Bq] to 1 picocurie [pCi]
        /// </summary>
        public static double Becquerel_2_Picocurie(double inVal)                        => inVal / 0.037;

        /// <summary>
        /// Rutherford -> Bq
        /// 1 rutherford =  1000000 becquerel [Bq]
        /// </summary>
        public static double Rutherford_2_Becquerel(double inVal)                       => inVal * 1000000;
        /// <summary>
        /// Bq -> Rutherford
        /// vv: 1000000 becquerel [Bq] to 1 rutherford
        /// </summary>
        public static double Becquerel_2_Rutherford(double inVal)                       => inVal / 1000000;

        /// <summary>
        /// 1/s -> Bq
        /// 1 one/second [1/s] =  1 becquerel [Bq]
        /// </summary>
        public static double OnePerSecond_2_Becquerel(double inVal)                     => inVal * 1;
        /// <summary>
        /// Bq -> 1/s
        /// vv: 1 becquerel [Bq] to 1 one/second [1/s]
        /// </summary>
        public static double Becquerel_2_OnePerSecond(double inVal)                     => inVal / 1;

        /// <summary>
        /// DisintegrationsPerSecond -> Bq
        /// 1 disintegrations/second =  1 becquerel [Bq]
        /// </summary>
        public static double DisintegrationsPerSecond_2_Becquerel(double inVal)         => inVal * 1;
        /// <summary>
        /// Bq -> DisintegrationsPerSecond
        /// vv: 1 becquerel [Bq] to 1 disintegrations/second
        /// </summary>
        public static double Becquerel_2_DisintegrationsPerSecond(double inVal)         => inVal / 1;

        /// <summary>
        /// DisintegrationsPerMinute -> Bq
        /// 1 disintegrations/minute =  0.0166666667 becquerel [Bq]
        /// </summary>
        public static double DisintegrationsPerMinute_2_Becquerel(double inVal)         => inVal * 0.0166666667;
        /// <summary>
        /// Bq -> DisintegrationsPerMinute
        /// vv: 0.0166666667 becquerel [Bq] to 1 disintegrations/minute
        /// </summary>
        public static double Becquerel_2_DisintegrationsPerMinute(double inVal)         => inVal / 0.0166666667;

        #endregion

        #region radiology - radiation-exposure, base: coulomb/kilogram

        /// <summary>
        /// mC/kg -> C/kg
        /// 1 millicoulomb/kilogram [mC/kg] =  0.001 coulomb/kilogram [C/kg]
        /// </summary>
        public static double MillicoulombPerKilogram_2_CoulombPerKilogram(double inVal) => inVal * 0.001;
        /// <summary>
        /// C/kg -> mC/kg
        /// vv: 0.001 coulomb/kilogram [C/kg] to 1 millicoulomb/kilogram [mC/kg]
        /// </summary>
        public static double CoulombPerKilogram_2_MillicoulombPerKilogram(double inVal) => inVal / 0.001;

        /// <summary>
        /// µC/kg -> C/kg
        /// 1 microcoulomb/kilogram [µC/kg] =  1.0E-6 coulomb/kilogram [C/kg]
        /// </summary>
        public static double MicrocoulombPerKilogram_2_CoulombPerKilogram(double inVal) => inVal * 1.0E-6;
        /// <summary>
        /// C/kg -> µC/kg
        /// vv: 1.0E-6 coulomb/kilogram [C/kg] to 1 microcoulomb/kilogram [µC/kg]
        /// </summary>
        public static double CoulombPerKilogram_2_MicrocoulombPerKilogram(double inVal) => inVal / 1.0E-6;

        /// <summary>
        /// R -> C/kg
        /// 1 roentgen [R] =  0.000258 coulomb/kilogram [C/kg]
        /// </summary>
        public static double Roentgen_2_CoulombPerKilogram(double inVal)                => inVal * 0.000258;
        /// <summary>
        /// C/kg -> R
        /// vv: 0.000258 coulomb/kilogram [C/kg] to 1 roentgen [R]
        /// </summary>
        public static double CoulombPerKilogram_2_Roentgen(double inVal)                => inVal / 0.000258;

        /// <summary>
        /// TissueRoentgen -> C/kg
        /// 1 tissue roentgen =  0.000258 coulomb/kilogram [C/kg]
        /// </summary>
        public static double TissueRoentgen_2_CoulombPerKilogram(double inVal)          => inVal * 0.000258;
        /// <summary>
        /// C/kg -> TissueRoentgen
        /// vv: 0.000258 coulomb/kilogram [C/kg] to 1 tissue roentgen
        /// </summary>
        public static double CoulombPerKilogram_2_TissueRoentgen(double inVal)          => inVal / 0.000258;

        /// <summary>
        /// Parker -> C/kg
        /// 1 parker =  0.000258 coulomb/kilogram [C/kg]
        /// </summary>
        public static double Parker_2_CoulombPerKilogram(double inVal)                  => inVal * 0.000258;
        /// <summary>
        /// C/kg -> Parker
        /// vv: 0.000258 coulomb/kilogram [C/kg] to 1 parker
        /// </summary>
        public static double CoulombPerKilogram_2_Parker(double inVal)                  => inVal / 0.000258;

        /// <summary>
        /// Rep -> C/kg
        /// 1 rep =  0.000258 coulomb/kilogram [C/kg]
        /// </summary>
        public static double Rep_2_CoulombPerKilogram(double inVal)                     => inVal * 0.000258;
        /// <summary>
        /// C/kg -> Rep
        /// vv: 0.000258 coulomb/kilogram [C/kg] to 1 rep
        /// </summary>
        public static double CoulombPerKilogram_2_Rep(double inVal)                     => inVal / 0.000258;

        #endregion

        #region radiology - radiation-absorbed dose, base: rad

        /// <summary>
        /// mrd -> rd
        /// 1 millirad [mrd] =  0.001 rad [rd]
        /// </summary>
        public static double Millirad_2_Rad(double inVal)                               => inVal * 0.001;
        /// <summary>
        /// rd -> mrd
        /// vv: 0.001 rad [rd] to 1 millirad [mrd]
        /// </summary>
        public static double Rad_2_Millirad(double inVal)                               => inVal / 0.001;

        /// <summary>
        /// J/kg -> rd
        /// 1 joule/kilogram [J/kg] =  100 rad [rd]
        /// </summary>
        public static double JoulePerKilogram_2_Rad(double inVal)                       => inVal * 100;
        /// <summary>
        /// rd -> J/kg
        /// vv: 100 rad [rd] to 1 joule/kilogram [J/kg]
        /// </summary>
        public static double Rad_2_JoulePerKilogram(double inVal)                       => inVal / 100;

        /// <summary>
        /// J/g -> rd
        /// 1 joule/gram [J/g] =  100000 rad [rd]
        /// </summary>
        public static double JoulePerGram_2_Rad(double inVal)                           => inVal * 100000;
        /// <summary>
        /// rd -> J/g
        /// vv: 100000 rad [rd] to 1 joule/gram [J/g]
        /// </summary>
        public static double Rad_2_JoulePerGram(double inVal)                           => inVal / 100000;

        /// <summary>
        /// J/cg -> rd
        /// 1 joule/centigram [J/cg] =  10000000 rad [rd]
        /// </summary>
        public static double JoulePerCentigram_2_Rad(double inVal)                      => inVal * 10000000;
        /// <summary>
        /// rd -> J/cg
        /// vv: 10000000 rad [rd] to 1 joule/centigram [J/cg]
        /// </summary>
        public static double Rad_2_JoulePerCentigram(double inVal)                      => inVal / 10000000;

        /// <summary>
        /// J/mg -> rd
        /// 1 joule/milligram [J/mg] =  100000000 rad [rd]
        /// </summary>
        public static double JoulePerMilligram_2_Rad(double inVal)                      => inVal * 100000000;
        /// <summary>
        /// rd -> J/mg
        /// vv: 100000000 rad [rd] to 1 joule/milligram [J/mg]
        /// </summary>
        public static double Rad_2_JoulePerMilligram(double inVal)                      => inVal / 100000000;

        /// <summary>
        /// Gy -> rd
        /// 1 gray [Gy] =  100 rad [rd]
        /// </summary>
        public static double Gray_2_Rad(double inVal)                                   => inVal * 100;
        /// <summary>
        /// rd -> Gy
        /// vv: 100 rad [rd] to 1 gray [Gy]
        /// </summary>
        public static double Rad_2_Gray(double inVal)                                   => inVal / 100;

        /// <summary>
        /// EGy -> rd
        /// 1 exagray [EGy] =  1.0E+20 rad [rd]
        /// </summary>
        public static double Exagray_2_Rad(double inVal)                                => inVal * 1.0E+20;
        /// <summary>
        /// rd -> EGy
        /// vv: 1.0E+20 rad [rd] to 1 exagray [EGy]
        /// </summary>
        public static double Rad_2_Exagray(double inVal)                                => inVal / 1.0E+20;

        /// <summary>
        /// PGy -> rd
        /// 1 petagray [PGy] =  1.0E+17 rad [rd]
        /// </summary>
        public static double Petagray_2_Rad(double inVal)                               => inVal * 1.0E+17;
        /// <summary>
        /// rd -> PGy
        /// vv: 1.0E+17 rad [rd] to 1 petagray [PGy]
        /// </summary>
        public static double Rad_2_Petagray(double inVal)                               => inVal / 1.0E+17;

        /// <summary>
        /// TGy -> rd
        /// 1 teragray [TGy] =  1.0E+14 rad [rd]
        /// </summary>
        public static double Teragray_2_Rad(double inVal)                               => inVal * 1.0E+14;
        /// <summary>
        /// rd -> TGy
        /// vv: 1.0E+14 rad [rd] to 1 teragray [TGy]
        /// </summary>
        public static double Rad_2_Teragray(double inVal)                               => inVal / 1.0E+14;

        /// <summary>
        /// GGy -> rd
        /// 1 gigagray [GGy] =  100000000000 rad [rd]
        /// </summary>
        public static double Gigagray_2_Rad(double inVal)                               => inVal * 100000000000;
        /// <summary>
        /// rd -> GGy
        /// vv: 100000000000 rad [rd] to 1 gigagray [GGy]
        /// </summary>
        public static double Rad_2_Gigagray(double inVal)                               => inVal / 100000000000;

        /// <summary>
        /// MGy -> rd
        /// 1 megagray [MGy] =  100000000 rad [rd]
        /// </summary>
        public static double Megagray_2_Rad(double inVal)                               => inVal * 100000000;
        /// <summary>
        /// rd -> MGy
        /// vv: 100000000 rad [rd] to 1 megagray [MGy]
        /// </summary>
        public static double Rad_2_Megagray(double inVal)                               => inVal / 100000000;

        /// <summary>
        /// kGy -> rd
        /// 1 kilogray [kGy] =  100000 rad [rd]
        /// </summary>
        public static double Kilogray_2_Rad(double inVal)                               => inVal * 100000;
        /// <summary>
        /// rd -> kGy
        /// vv: 100000 rad [rd] to 1 kilogray [kGy]
        /// </summary>
        public static double Rad_2_Kilogray(double inVal)                               => inVal / 100000;

        /// <summary>
        /// hGy -> rd
        /// 1 hectogray [hGy] =  10000 rad [rd]
        /// </summary>
        public static double Hectogray_2_Rad(double inVal)                              => inVal * 10000;
        /// <summary>
        /// rd -> hGy
        /// vv: 10000 rad [rd] to 1 hectogray [hGy]
        /// </summary>
        public static double Rad_2_Hectogray(double inVal)                              => inVal / 10000;

        /// <summary>
        /// daGy -> rd
        /// 1 dekagray [daGy] =  1000 rad [rd]
        /// </summary>
        public static double Dekagray_2_Rad(double inVal)                               => inVal * 1000;
        /// <summary>
        /// rd -> daGy
        /// vv: 1000 rad [rd] to 1 dekagray [daGy]
        /// </summary>
        public static double Rad_2_Dekagray(double inVal)                               => inVal / 1000;

        /// <summary>
        /// dGy -> rd
        /// 1 decigray [dGy] =  10 rad [rd]
        /// </summary>
        public static double Decigray_2_Rad(double inVal)                               => inVal * 10;
        /// <summary>
        /// rd -> dGy
        /// vv: 10 rad [rd] to 1 decigray [dGy]
        /// </summary>
        public static double Rad_2_Decigray(double inVal)                               => inVal / 10;

        /// <summary>
        /// cGy -> rd
        /// 1 centigray [cGy] =  1 rad [rd]
        /// </summary>
        public static double Centigray_2_Rad(double inVal)                              => inVal * 1;
        /// <summary>
        /// rd -> cGy
        /// vv: 1 rad [rd] to 1 centigray [cGy]
        /// </summary>
        public static double Rad_2_Centigray(double inVal)                              => inVal / 1;

        /// <summary>
        /// mGy -> rd
        /// 1 milligray [mGy] =  0.1 rad [rd]
        /// </summary>
        public static double Milligray_2_Rad(double inVal)                              => inVal * 0.1;
        /// <summary>
        /// rd -> mGy
        /// vv: 0.1 rad [rd] to 1 milligray [mGy]
        /// </summary>
        public static double Rad_2_Milligray(double inVal)                              => inVal / 0.1;

        /// <summary>
        /// µGy -> rd
        /// 1 microgray [µGy] =  0.0001 rad [rd]
        /// </summary>
        public static double Microgray_2_Rad(double inVal)                              => inVal * 0.0001;
        /// <summary>
        /// rd -> µGy
        /// vv: 0.0001 rad [rd] to 1 microgray [µGy]
        /// </summary>
        public static double Rad_2_Microgray(double inVal)                              => inVal / 0.0001;

        /// <summary>
        /// nGy -> rd
        /// 1 nanogray [nGy] =  1.0E-7 rad [rd]
        /// </summary>
        public static double Nanogray_2_Rad(double inVal)                               => inVal * 1.0E-7;
        /// <summary>
        /// rd -> nGy
        /// vv: 1.0E-7 rad [rd] to 1 nanogray [nGy]
        /// </summary>
        public static double Rad_2_Nanogray(double inVal)                               => inVal / 1.0E-7;

        /// <summary>
        /// pGy -> rd
        /// 1 picogray [pGy] =  1.0E-10 rad [rd]
        /// </summary>
        public static double Picogray_2_Rad(double inVal)                               => inVal * 1.0E-10;
        /// <summary>
        /// rd -> pGy
        /// vv: 1.0E-10 rad [rd] to 1 picogray [pGy]
        /// </summary>
        public static double Rad_2_Picogray(double inVal)                               => inVal / 1.0E-10;

        /// <summary>
        /// fGy -> rd
        /// 1 femtogray [fGy] =  1.0E-13 rad [rd]
        /// </summary>
        public static double Femtogray_2_Rad(double inVal)                              => inVal * 1.0E-13;
        /// <summary>
        /// rd -> fGy
        /// vv: 1.0E-13 rad [rd] to 1 femtogray [fGy]
        /// </summary>
        public static double Rad_2_Femtogray(double inVal)                              => inVal / 1.0E-13;

        /// <summary>
        /// aGy -> rd
        /// 1 attogray [aGy] =  1.0E-16 rad [rd]
        /// </summary>
        public static double Attogray_2_Rad(double inVal)                               => inVal * 1.0E-16;
        /// <summary>
        /// rd -> aGy
        /// vv: 1.0E-16 rad [rd] to 1 attogray [aGy]
        /// </summary>
        public static double Rad_2_Attogray(double inVal)                               => inVal / 1.0E-16;

        #endregion
    }
}
