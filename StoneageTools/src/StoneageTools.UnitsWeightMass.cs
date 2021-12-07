
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region weight and mass, base: kilogram

        /// <summary>
        /// g -> kg
        /// 1 gram [g] to vv: 0.001 kilogram [kg]
        /// </summary>
        public static double Gram_2_Kilogram(double inVal)                              => inVal * 0.001;
        /// <summary>
        /// kg -> g
        /// vv: 0.001 kilogram [kg] to 1 gram [g]
        /// </summary>
        public static double Kilogram_2_Gram(double inVal)                              => inVal / 0.001;

        /// <summary>
        /// mg -> kg
        /// 1 milligram [mg] to vv: 1.0E-6 kilogram [kg]
        /// </summary>
        public static double Milligram_2_Kilogram(double inVal)                         => inVal * 1.0E-6;
        /// <summary>
        /// kg -> mg
        /// vv: 1.0E-6 kilogram [kg] to 1 milligram [mg]
        /// </summary>
        public static double Kilogram_2_Milligram(double inVal)                         => inVal / 1.0E-6;

        /// <summary>
        /// t -> kg
        /// 1 ton (metric) [t] to vv: 1000 kilogram [kg]
        /// </summary>
        public static double TonMetric_2_Kilogram(double inVal)                         => inVal * 1000;
        /// <summary>
        /// kg -> t
        /// vv: 1000 kilogram [kg] to 1 ton (metric) [t]
        /// </summary>
        public static double Kilogram_2_TonMetric(double inVal)                         => inVal / 1000;

        /// <summary>
        /// lbs -> kg
        /// 1 pound [lbs] to vv: 0.45359237 kilogram [kg]
        /// </summary>
        public static double Pound_2_Kilogram(double inVal)                             => inVal * 0.45359237;
        /// <summary>
        /// kg -> lbs
        /// vv: 0.45359237 kilogram [kg] to 1 pound [lbs]
        /// </summary>
        public static double Kilogram_2_Pound(double inVal)                             => inVal / 0.45359237;

        /// <summary>
        /// oz -> kg
        /// 1 ounce [oz] to vv: 0.0283495231 kilogram [kg]
        /// </summary>
        public static double Ounce_2_Kilogram(double inVal)                             => inVal * 0.0283495231;
        /// <summary>
        /// kg -> oz
        /// vv: 0.0283495231 kilogram [kg] to 1 ounce [oz]
        /// </summary>
        public static double Kilogram_2_Ounce(double inVal)                             => inVal / 0.0283495231;

        /// <summary>
        /// car, ct -> kg
        /// 1 carat [car, ct] to vv: 0.0002 kilogram [kg]
        /// </summary>
        public static double Carat_2_Kilogram(double inVal)                             => inVal * 0.0002;
        /// <summary>
        /// kg -> car, ct
        /// vv: 0.0002 kilogram [kg] to 1 carat [car, ct]
        /// </summary>
        public static double Kilogram_2_Carat(double inVal)                             => inVal / 0.0002;

        /// <summary>
        /// ton (US) -> kg
        /// 1 ton (short) [ton (US)] to vv: 907.18474 kilogram [kg]
        /// </summary>
        public static double TonShort_2_Kilogram(double inVal)                          => inVal * 907.18474;
        /// <summary>
        /// kg -> ton (US)
        /// vv: 907.18474 kilogram [kg] to 1 ton (short) [ton (US)]
        /// </summary>
        public static double Kilogram_2_TonShort(double inVal)                          => inVal / 907.18474;

        /// <summary>
        /// ton (UK) -> kg
        /// 1 ton (long) [ton (UK)] to vv: 1016.0469088 kilogram [kg]
        /// </summary>
        public static double TonLong_2_Kilogram(double inVal)                           => inVal * 1016.0469088;
        /// <summary>
        /// kg -> ton (UK)
        /// vv: 1016.0469088 kilogram [kg] to 1 ton (long) [ton (UK)]
        /// </summary>
        public static double Kilogram_2_TonLong(double inVal)                           => inVal / 1016.0469088;

        /// <summary>
        /// u -> kg
        /// 1 Atomic mass unit [u] to vv: 1.6605402E-27 kilogram [kg]
        /// </summary>
        public static double AtomicMassUnit_2_Kilogram(double inVal)                    => inVal * 1.6605402E-27;
        /// <summary>
        /// kg -> u
        /// vv: 1.6605402E-27 kilogram [kg] to 1 Atomic mass unit [u]
        /// </summary>
        public static double Kilogram_2_AtomicMassUnit(double inVal)                    => inVal / 1.6605402E-27;

        /// <summary>
        /// Eg -> kg
        /// 1 exagram [Eg] to vv: 1.0E+15 kilogram [kg]
        /// </summary>
        public static double Exagram_2_Kilogram(double inVal)                           => inVal * 1.0E+15;
        /// <summary>
        /// kg -> Eg
        /// vv: 1.0E+15 kilogram [kg] to 1 exagram [Eg]
        /// </summary>
        public static double Kilogram_2_Exagram(double inVal)                           => inVal / 1.0E+15;

        /// <summary>
        /// Pg -> kg
        /// 1 petagram [Pg] to vv: 1000000000000 kilogram [kg]
        /// </summary>
        public static double Petagram_2_Kilogram(double inVal)                          => inVal * 1000000000000;
        /// <summary>
        /// kg -> Pg
        /// vv: 1000000000000 kilogram [kg] to 1 petagram [Pg]
        /// </summary>
        public static double Kilogram_2_Petagram(double inVal)                          => inVal / 1000000000000;

        /// <summary>
        /// Tg -> kg
        /// 1 teragram [Tg] to vv: 1000000000 kilogram [kg]
        /// </summary>
        public static double Teragram_2_Kilogram(double inVal)                          => inVal * 1000000000;
        /// <summary>
        /// kg -> Tg
        /// vv: 1000000000 kilogram [kg] to 1 teragram [Tg]
        /// </summary>
        public static double Kilogram_2_Teragram(double inVal)                          => inVal / 1000000000;

        /// <summary>
        /// Gg -> kg
        /// 1 gigagram [Gg] to vv: 1000000 kilogram [kg]
        /// </summary>
        public static double Gigagram_2_Kilogram(double inVal)                          => inVal * 1000000;
        /// <summary>
        /// kg -> Gg
        /// vv: 1000000 kilogram [kg] to 1 gigagram [Gg]
        /// </summary>
        public static double Kilogram_2_Gigagram(double inVal)                          => inVal / 1000000;

        /// <summary>
        /// Mg -> kg
        /// 1 megagram [Mg] to vv: 1000 kilogram [kg]
        /// </summary>
        public static double Megagram_2_Kilogram(double inVal)                          => inVal * 1000;
        /// <summary>
        /// kg -> Mg
        /// vv: 1000 kilogram [kg] to 1 megagram [Mg]
        /// </summary>
        public static double Kilogram_2_Megagram(double inVal)                          => inVal / 1000;

        /// <summary>
        /// hg -> kg
        /// 1 hectogram [hg] to vv: 0.1 kilogram [kg]
        /// </summary>
        public static double Hectogram_2_Kilogram(double inVal)                         => inVal * 0.1;
        /// <summary>
        /// kg -> hg
        /// vv: 0.1 kilogram [kg] to 1 hectogram [hg]
        /// </summary>
        public static double Kilogram_2_Hectogram(double inVal)                         => inVal / 0.1;

        /// <summary>
        /// dag -> kg
        /// 1 dekagram [dag] to vv: 0.01 kilogram [kg]
        /// </summary>
        public static double Dekagram_2_Kilogram(double inVal)                          => inVal * 0.01;
        /// <summary>
        /// kg -> dag
        /// vv: 0.01 kilogram [kg] to 1 dekagram [dag]
        /// </summary>
        public static double Kilogram_2_Dekagram(double inVal)                          => inVal / 0.01;

        /// <summary>
        /// dg -> kg
        /// 1 decigram [dg] to vv: 0.0001 kilogram [kg]
        /// </summary>
        public static double Decigram_2_Kilogram(double inVal)                          => inVal * 0.0001;
        /// <summary>
        /// kg -> dg
        /// vv: 0.0001 kilogram [kg] to 1 decigram [dg]
        /// </summary>
        public static double Kilogram_2_Decigram(double inVal)                          => inVal / 0.0001;

        /// <summary>
        /// cg -> kg
        /// 1 centigram [cg] to vv: 1.0E-5 kilogram [kg]
        /// </summary>
        public static double Centigram_2_Kilogram(double inVal)                         => inVal * 1.0E-5;
        /// <summary>
        /// kg -> cg
        /// vv: 1.0E-5 kilogram [kg] to 1 centigram [cg]
        /// </summary>
        public static double Kilogram_2_Centigram(double inVal)                         => inVal / 1.0E-5;

        /// <summary>
        /// µg -> kg
        /// 1 microgram [µg] to vv: 1.0E-9 kilogram [kg]
        /// </summary>
        public static double Microgram_2_Kilogram(double inVal)                         => inVal * 1.0E-9;
        /// <summary>
        /// kg -> µg
        /// vv: 1.0E-9 kilogram [kg] to 1 microgram [µg]
        /// </summary>
        public static double Kilogram_2_Microgram(double inVal)                         => inVal / 1.0E-9;

        /// <summary>
        /// ng -> kg
        /// 1 nanogram [ng] to vv: 1.0E-12 kilogram [kg]
        /// </summary>
        public static double Nanogram_2_Kilogram(double inVal)                          => inVal * 1.0E-12;
        /// <summary>
        /// kg -> ng
        /// vv: 1.0E-12 kilogram [kg] to 1 nanogram [ng]
        /// </summary>
        public static double Kilogram_2_Nanogram(double inVal)                          => inVal / 1.0E-12;

        /// <summary>
        /// pg -> kg
        /// 1 picogram [pg] to vv: 1.0E-15 kilogram [kg]
        /// </summary>
        public static double Picogram_2_Kilogram(double inVal)                          => inVal * 1.0E-15;
        /// <summary>
        /// kg -> pg
        /// vv: 1.0E-15 kilogram [kg] to 1 picogram [pg]
        /// </summary>
        public static double Kilogram_2_Picogram(double inVal)                          => inVal / 1.0E-15;

        /// <summary>
        /// fg -> kg
        /// 1 femtogram [fg] to vv: 1.0E-18 kilogram [kg]
        /// </summary>
        public static double Femtogram_2_Kilogram(double inVal)                         => inVal * 1.0E-18;
        /// <summary>
        /// kg -> fg
        /// vv: 1.0E-18 kilogram [kg] to 1 femtogram [fg]
        /// </summary>
        public static double Kilogram_2_Femtogram(double inVal)                         => inVal / 1.0E-18;

        /// <summary>
        /// ag -> kg
        /// 1 attogram [ag] to vv: 1.0E-21 kilogram [kg]
        /// </summary>
        public static double Attogram_2_Kilogram(double inVal)                          => inVal * 1.0E-21;
        /// <summary>
        /// kg -> ag
        /// vv: 1.0E-21 kilogram [kg] to 1 attogram [ag]
        /// </summary>
        public static double Kilogram_2_Attogram(double inVal)                          => inVal / 1.0E-21;

        /// <summary>
        /// Dalton -> kg
        /// 1 dalton to vv: 1.6605300000013E-27 kilogram [kg]
        /// </summary>
        public static double Dalton_2_Kilogram(double inVal)                            => inVal * 1.6605300000013E-27;
        /// <summary>
        /// kg -> Dalton
        /// vv: 1.6605300000013E-27 kilogram [kg] to 1 dalton
        /// </summary>
        public static double Kilogram_2_Dalton(double inVal)                            => inVal / 1.6605300000013E-27;

        /// <summary>
        /// KilogramForceSquareSecondPerMeter -> kg
        /// 1 kilogram-force square second/meter to vv: 9.80665 kilogram [kg]
        /// </summary>
        public static double KilogramForceSquareSecondPerMeter_2_Kilogram(double inVal) => inVal * 9.80665;
        /// <summary>
        /// kg -> KilogramForceSquareSecondPerMeter
        /// vv: 9.80665 kilogram [kg] to 1 kilogram-force square second/meter
        /// </summary>
        public static double Kilogram_2_KilogramForceSquareSecondPerMeter(double inVal) => inVal / 9.80665;

        /// <summary>
        /// kip -> kg
        /// 1 kilopound [kip] to vv: 453.59237 kilogram [kg]
        /// </summary>
        public static double Kilopound_2_Kilogram(double inVal)                         => inVal * 453.59237;
        /// <summary>
        /// kg -> kip
        /// vv: 453.59237 kilogram [kg] to 1 kilopound [kip]
        /// </summary>
        public static double Kilogram_2_Kilopound(double inVal)                         => inVal / 453.59237;

        /// <summary>
        /// Kip -> kg
        /// 1 kip to vv: 453.59237 kilogram [kg]
        /// </summary>
        public static double Kip_2_Kilogram(double inVal)                               => inVal * 453.59237;
        /// <summary>
        /// kg -> Kip
        /// vv: 453.59237 kilogram [kg] to 1 kip
        /// </summary>
        public static double Kilogram_2_Kip(double inVal)                               => inVal / 453.59237;

        /// <summary>
        /// Slug -> kg
        /// 1 slug to vv: 14.5939029372 kilogram [kg]
        /// </summary>
        public static double Slug_2_Kilogram(double inVal)                              => inVal * 14.5939029372;
        /// <summary>
        /// kg -> Slug
        /// vv: 14.5939029372 kilogram [kg] to 1 slug
        /// </summary>
        public static double Kilogram_2_Slug(double inVal)                              => inVal / 14.5939029372;

        /// <summary>
        /// PoundForceSquareSecondPerFoot -> kg
        /// 1 pound-force square second/foot to vv: 14.5939029372 kilogram [kg]
        /// </summary>
        public static double PoundForceSquareSecondPerFoot_2_Kilogram(double inVal)     => inVal * 14.5939029372;
        /// <summary>
        /// kg -> PoundForceSquareSecondPerFoot
        /// vv: 14.5939029372 kilogram [kg] to 1 pound-force square second/foot
        /// </summary>
        public static double Kilogram_2_PoundForceSquareSecondPerFoot(double inVal)     => inVal / 14.5939029372;

        /// <summary>
        /// PoundTroyOrApothecary -> kg
        /// 1 pound (troy or apothecary) to vv: 0.3732417216 kilogram [kg]
        /// </summary>
        public static double PoundTroyOrApothecary_2_Kilogram(double inVal)             => inVal * 0.3732417216;
        /// <summary>
        /// kg -> PoundTroyOrApothecary
        /// vv: 0.3732417216 kilogram [kg] to 1 pound (troy or apothecary)
        /// </summary>
        public static double Kilogram_2_PoundTroyOrApothecary(double inVal)             => inVal / 0.3732417216;

        /// <summary>
        /// pdl -> kg
        /// 1 poundal [pdl] to vv: 0.0140867196 kilogram [kg]
        /// </summary>
        public static double Poundal_2_Kilogram(double inVal)                           => inVal * 0.0140867196;
        /// <summary>
        /// kg -> pdl
        /// vv: 0.0140867196 kilogram [kg] to 1 poundal [pdl]
        /// </summary>
        public static double Kilogram_2_Poundal(double inVal)                           => inVal / 0.0140867196;

        /// <summary>
        /// AT (US) -> kg
        /// 1 ton (assay) (US) [AT (US)] to vv: 0.02916667 kilogram [kg]
        /// </summary>
        public static double TonAssayUS_2_Kilogram(double inVal)                        => inVal * 0.02916667;
        /// <summary>
        /// kg -> AT (US)
        /// vv: 0.02916667 kilogram [kg] to 1 ton (assay) (US) [AT (US)]
        /// </summary>
        public static double Kilogram_2_TonAssayUS(double inVal)                        => inVal / 0.02916667;

        /// <summary>
        /// AT (UK) -> kg
        /// 1 ton (assay) (UK) [AT (UK)] to vv: 0.0326666667 kilogram [kg]
        /// </summary>
        public static double TonAssayUK_2_Kilogram(double inVal)                        => inVal * 0.0326666667;
        /// <summary>
        /// kg -> AT (UK)
        /// vv: 0.0326666667 kilogram [kg] to 1 ton (assay) (UK) [AT (UK)]
        /// </summary>
        public static double Kilogram_2_TonAssayUK(double inVal)                        => inVal / 0.0326666667;

        /// <summary>
        /// kt -> kg
        /// 1 kiloton (metric) [kt] to vv: 1000000 kilogram [kg]
        /// </summary>
        public static double KilotonMetric_2_Kilogram(double inVal)                     => inVal * 1000000;
        /// <summary>
        /// kg -> kt
        /// vv: 1000000 kilogram [kg] to 1 kiloton (metric) [kt]
        /// </summary>
        public static double Kilogram_2_KilotonMetric(double inVal)                     => inVal / 1000000;

        /// <summary>
        /// cwt -> kg
        /// 1 quintal (metric) [cwt] to vv: 100 kilogram [kg]
        /// </summary>
        public static double QuintalMetric_2_Kilogram(double inVal)                     => inVal * 100;
        /// <summary>
        /// kg -> cwt
        /// vv: 100 kilogram [kg] to 1 quintal (metric) [cwt]
        /// </summary>
        public static double Kilogram_2_QuintalMetric(double inVal)                     => inVal / 100;

        /// <summary>
        /// HundredweightUS -> kg
        /// 1 hundredweight (US) to vv: 45.359237 kilogram [kg]
        /// </summary>
        public static double HundredweightUS_2_Kilogram(double inVal)                   => inVal * 45.359237;
        /// <summary>
        /// kg -> HundredweightUS
        /// vv: 45.359237 kilogram [kg] to 1 hundredweight (US)
        /// </summary>
        public static double Kilogram_2_HundredweightUS(double inVal)                   => inVal / 45.359237;

        /// <summary>
        /// HundredweightUK -> kg
        /// 1 hundredweight (UK) to vv: 50.80234544 kilogram [kg]
        /// </summary>
        public static double HundredweightUK_2_Kilogram(double inVal)                   => inVal * 50.80234544;
        /// <summary>
        /// kg -> HundredweightUK
        /// vv: 50.80234544 kilogram [kg] to 1 hundredweight (UK)
        /// </summary>
        public static double Kilogram_2_HundredweightUK(double inVal)                   => inVal / 50.80234544;

        /// <summary>
        /// qr (US) -> kg
        /// 1 quarter (US) [qr (US)] to vv: 11.33980925 kilogram [kg]
        /// </summary>
        public static double QuarterUS_2_Kilogram(double inVal)                         => inVal * 11.33980925;
        /// <summary>
        /// kg -> qr (US)
        /// vv: 11.33980925 kilogram [kg] to 1 quarter (US) [qr (US)]
        /// </summary>
        public static double Kilogram_2_QuarterUS(double inVal)                         => inVal / 11.33980925;

        /// <summary>
        /// qr (UK) -> kg
        /// 1 quarter (UK) [qr (UK)] to vv: 12.70058636 kilogram [kg]
        /// </summary>
        public static double QuarterUK_2_Kilogram(double inVal)                         => inVal * 12.70058636;
        /// <summary>
        /// kg -> qr (UK)
        /// vv: 12.70058636 kilogram [kg] to 1 quarter (UK) [qr (UK)]
        /// </summary>
        public static double Kilogram_2_QuarterUK(double inVal)                         => inVal / 12.70058636;

        /// <summary>
        /// StoneUS -> kg
        /// 1 stone (US) to vv: 5.669904625 kilogram [kg]
        /// </summary>
        public static double StoneUS_2_Kilogram(double inVal)                           => inVal * 5.669904625;
        /// <summary>
        /// kg -> StoneUS
        /// vv: 5.669904625 kilogram [kg] to 1 stone (US)
        /// </summary>
        public static double Kilogram_2_StoneUS(double inVal)                           => inVal / 5.669904625;

        /// <summary>
        /// StoneUK -> kg
        /// 1 stone (UK) to vv: 6.35029318 kilogram [kg]
        /// </summary>
        public static double StoneUK_2_Kilogram(double inVal)                           => inVal * 6.35029318;
        /// <summary>
        /// kg -> StoneUK
        /// vv: 6.35029318 kilogram [kg] to 1 stone (UK)
        /// </summary>
        public static double Kilogram_2_StoneUK(double inVal)                           => inVal / 6.35029318;

        /// <summary>
        /// t -> kg
        /// 1 tonne [t] to vv: 1000 kilogram [kg]
        /// </summary>
        public static double Tonne_2_Kilogram(double inVal)                             => inVal * 1000;
        /// <summary>
        /// kg -> t
        /// vv: 1000 kilogram [kg] to 1 tonne [t]
        /// </summary>
        public static double Kilogram_2_Tonne(double inVal)                             => inVal / 1000;

        /// <summary>
        /// pwt -> kg
        /// 1 pennyweight [pwt] to vv: 0.0015551738 kilogram [kg]
        /// </summary>
        public static double Pennyweight_2_Kilogram(double inVal)                       => inVal * 0.0015551738;
        /// <summary>
        /// kg -> pwt
        /// vv: 0.0015551738 kilogram [kg] to 1 pennyweight [pwt]
        /// </summary>
        public static double Kilogram_2_Pennyweight(double inVal)                       => inVal / 0.0015551738;

        /// <summary>
        /// s.ap -> kg
        /// 1 scruple (apothecary) [s.ap] to vv: 0.0012959782 kilogram [kg]
        /// </summary>
        public static double ScrupleApothecary_2_Kilogram(double inVal)                 => inVal * 0.0012959782;
        /// <summary>
        /// kg -> s.ap
        /// vv: 0.0012959782 kilogram [kg] to 1 scruple (apothecary) [s.ap]
        /// </summary>
        public static double Kilogram_2_ScrupleApothecary(double inVal)                 => inVal / 0.0012959782;

        /// <summary>
        /// gr -> kg
        /// 1 grain [gr] to vv: 6.47989E-5 kilogram [kg]
        /// </summary>
        public static double Grain_2_Kilogram(double inVal)                             => inVal * 6.47989E-5;
        /// <summary>
        /// kg -> gr
        /// vv: 6.47989E-5 kilogram [kg] to 1 grain [gr]
        /// </summary>
        public static double Kilogram_2_Grain(double inVal)                             => inVal / 6.47989E-5;

        /// <summary>
        /// Gamma -> kg
        /// 1 gamma to vv: 1.0E-9 kilogram [kg]
        /// </summary>
        public static double Gamma_2_Kilogram(double inVal)                             => inVal * 1.0E-9;
        /// <summary>
        /// kg -> Gamma
        /// vv: 1.0E-9 kilogram [kg] to 1 gamma
        /// </summary>
        public static double Kilogram_2_Gamma(double inVal)                             => inVal / 1.0E-9;

        /// <summary>
        /// TalentBiblicalHebrew -> kg
        /// 1 talent (Biblical Hebrew) to vv: 34.2 kilogram [kg]
        /// </summary>
        public static double TalentBiblicalHebrew_2_Kilogram(double inVal)              => inVal * 34.2;
        /// <summary>
        /// kg -> TalentBiblicalHebrew
        /// vv: 34.2 kilogram [kg] to 1 talent (Biblical Hebrew)
        /// </summary>
        public static double Kilogram_2_TalentBiblicalHebrew(double inVal)              => inVal / 34.2;

        /// <summary>
        /// MinaBiblicalHebrew -> kg
        /// 1 mina (Biblical Hebrew) to vv: 0.57 kilogram [kg]
        /// </summary>
        public static double MinaBiblicalHebrew_2_Kilogram(double inVal)                => inVal * 0.57;
        /// <summary>
        /// kg -> MinaBiblicalHebrew
        /// vv: 0.57 kilogram [kg] to 1 mina (Biblical Hebrew)
        /// </summary>
        public static double Kilogram_2_MinaBiblicalHebrew(double inVal)                => inVal / 0.57;

        /// <summary>
        /// ShekelBiblicalHebrew -> kg
        /// 1 shekel (Biblical Hebrew) to vv: 0.0114 kilogram [kg]
        /// </summary>
        public static double ShekelBiblicalHebrew_2_Kilogram(double inVal)              => inVal * 0.0114;
        /// <summary>
        /// kg -> ShekelBiblicalHebrew
        /// vv: 0.0114 kilogram [kg] to 1 shekel (Biblical Hebrew)
        /// </summary>
        public static double Kilogram_2_ShekelBiblicalHebrew(double inVal)              => inVal / 0.0114;

        /// <summary>
        /// BekanBiblicalHebrew -> kg
        /// 1 bekan (Biblical Hebrew) to vv: 0.0057 kilogram [kg]
        /// </summary>
        public static double BekanBiblicalHebrew_2_Kilogram(double inVal)               => inVal * 0.0057;
        /// <summary>
        /// kg -> BekanBiblicalHebrew
        /// vv: 0.0057 kilogram [kg] to 1 bekan (Biblical Hebrew)
        /// </summary>
        public static double Kilogram_2_BekanBiblicalHebrew(double inVal)               => inVal / 0.0057;

        /// <summary>
        /// GerahBiblicalHebrew -> kg
        /// 1 gerah (Biblical Hebrew) to vv: 0.00057 kilogram [kg]
        /// </summary>
        public static double GerahBiblicalHebrew_2_Kilogram(double inVal)               => inVal * 0.00057;
        /// <summary>
        /// kg -> GerahBiblicalHebrew
        /// vv: 0.00057 kilogram [kg] to 1 gerah (Biblical Hebrew)
        /// </summary>
        public static double Kilogram_2_GerahBiblicalHebrew(double inVal)               => inVal / 0.00057;

        /// <summary>
        /// TalentBiblicalGreek -> kg
        /// 1 talent (Biblical Greek) to vv: 20.4 kilogram [kg]
        /// </summary>
        public static double TalentBiblicalGreek_2_Kilogram(double inVal)               => inVal * 20.4;
        /// <summary>
        /// kg -> TalentBiblicalGreek
        /// vv: 20.4 kilogram [kg] to 1 talent (Biblical Greek)
        /// </summary>
        public static double Kilogram_2_TalentBiblicalGreek(double inVal)               => inVal / 20.4;

        /// <summary>
        /// MinaBiblicalGreek -> kg
        /// 1 mina (Biblical Greek) to vv: 0.34 kilogram [kg]
        /// </summary>
        public static double MinaBiblicalGreek_2_Kilogram(double inVal)                 => inVal * 0.34;
        /// <summary>
        /// kg -> MinaBiblicalGreek
        /// vv: 0.34 kilogram [kg] to 1 mina (Biblical Greek)
        /// </summary>
        public static double Kilogram_2_MinaBiblicalGreek(double inVal)                 => inVal / 0.34;

        /// <summary>
        /// TetradrachmaBiblicalGreek -> kg
        /// 1 tetradrachma (Biblical Greek) to vv: 0.0136 kilogram [kg]
        /// </summary>
        public static double TetradrachmaBiblicalGreek_2_Kilogram(double inVal)         => inVal * 0.0136;
        /// <summary>
        /// kg -> TetradrachmaBiblicalGreek
        /// vv: 0.0136 kilogram [kg] to 1 tetradrachma (Biblical Greek)
        /// </summary>
        public static double Kilogram_2_TetradrachmaBiblicalGreek(double inVal)         => inVal / 0.0136;

        /// <summary>
        /// DidrachmaBiblicalGreek -> kg
        /// 1 didrachma (Biblical Greek) to vv: 0.0068 kilogram [kg]
        /// </summary>
        public static double DidrachmaBiblicalGreek_2_Kilogram(double inVal)            => inVal * 0.0068;
        /// <summary>
        /// kg -> DidrachmaBiblicalGreek
        /// vv: 0.0068 kilogram [kg] to 1 didrachma (Biblical Greek)
        /// </summary>
        public static double Kilogram_2_DidrachmaBiblicalGreek(double inVal)            => inVal / 0.0068;

        /// <summary>
        /// DrachmaBiblicalGreek -> kg
        /// 1 drachma (Biblical Greek) to vv: 0.0034 kilogram [kg]
        /// </summary>
        public static double DrachmaBiblicalGreek_2_Kilogram(double inVal)              => inVal * 0.0034;
        /// <summary>
        /// kg -> DrachmaBiblicalGreek
        /// vv: 0.0034 kilogram [kg] to 1 drachma (Biblical Greek)
        /// </summary>
        public static double Kilogram_2_DrachmaBiblicalGreek(double inVal)              => inVal / 0.0034;

        /// <summary>
        /// DenariusBiblicalRoman -> kg
        /// 1 denarius (Biblical Roman) to vv: 0.00385 kilogram [kg]
        /// </summary>
        public static double DenariusBiblicalRoman_2_Kilogram(double inVal)             => inVal * 0.00385;
        /// <summary>
        /// kg -> DenariusBiblicalRoman
        /// vv: 0.00385 kilogram [kg] to 1 denarius (Biblical Roman)
        /// </summary>
        public static double Kilogram_2_DenariusBiblicalRoman(double inVal)             => inVal / 0.00385;

        /// <summary>
        /// AssarionBiblicalRoman -> kg
        /// 1 assarion (Biblical Roman) to vv: 0.000240625 kilogram [kg]
        /// </summary>
        public static double AssarionBiblicalRoman_2_Kilogram(double inVal)             => inVal * 0.000240625;
        /// <summary>
        /// kg -> AssarionBiblicalRoman
        /// vv: 0.000240625 kilogram [kg] to 1 assarion (Biblical Roman)
        /// </summary>
        public static double Kilogram_2_AssarionBiblicalRoman(double inVal)             => inVal / 0.000240625;

        /// <summary>
        /// QuadransBiblicalRoman -> kg
        /// 1 quadrans (Biblical Roman) to vv: 6.01563E-5 kilogram [kg]
        /// </summary>
        public static double QuadransBiblicalRoman_2_Kilogram(double inVal)             => inVal * 6.01563E-5;
        /// <summary>
        /// kg -> QuadransBiblicalRoman
        /// vv: 6.01563E-5 kilogram [kg] to 1 quadrans (Biblical Roman)
        /// </summary>
        public static double Kilogram_2_QuadransBiblicalRoman(double inVal)             => inVal / 6.01563E-5;

        /// <summary>
        /// LeptonBiblicalRoman -> kg
        /// 1 lepton (Biblical Roman) to vv: 3.00781E-5 kilogram [kg]
        /// </summary>
        public static double LeptonBiblicalRoman_2_Kilogram(double inVal)               => inVal * 3.00781E-5;
        /// <summary>
        /// kg -> LeptonBiblicalRoman
        /// vv: 3.00781E-5 kilogram [kg] to 1 lepton (Biblical Roman)
        /// </summary>
        public static double Kilogram_2_LeptonBiblicalRoman(double inVal)               => inVal / 3.00781E-5;

        /// <summary>
        /// PlanckMass -> kg
        /// 1 Planck mass to vv: 2.17671E-8 kilogram [kg]
        /// </summary>
        public static double PlanckMass_2_Kilogram(double inVal)                        => inVal * 2.17671E-8;
        /// <summary>
        /// kg -> PlanckMass
        /// vv: 2.17671E-8 kilogram [kg] to 1 Planck mass
        /// </summary>
        public static double Kilogram_2_PlanckMass(double inVal)                        => inVal / 2.17671E-8;

        /// <summary>
        /// ElectronMassRest -> kg
        /// 1 Electron mass (rest) to vv: 9.1093897E-31 kilogram [kg]
        /// </summary>
        public static double ElectronMassRest_2_Kilogram(double inVal)                  => inVal * 9.1093897E-31;
        /// <summary>
        /// kg -> ElectronMassRest
        /// vv: 9.1093897E-31 kilogram [kg] to 1 Electron mass (rest)
        /// </summary>
        public static double Kilogram_2_ElectronMassRest(double inVal)                  => inVal / 9.1093897E-31;

        /// <summary>
        /// MuonMass -> kg
        /// 1 Muon mass to vv: 1.8835327E-28 kilogram [kg]
        /// </summary>
        public static double MuonMass_2_Kilogram(double inVal)                          => inVal * 1.8835327E-28;
        /// <summary>
        /// kg -> MuonMass
        /// vv: 1.8835327E-28 kilogram [kg] to 1 Muon mass
        /// </summary>
        public static double Kilogram_2_MuonMass(double inVal)                          => inVal / 1.8835327E-28;

        /// <summary>
        /// ProtonMass -> kg
        /// 1 Proton mass to vv: 1.6726231E-27 kilogram [kg]
        /// </summary>
        public static double ProtonMass_2_Kilogram(double inVal)                        => inVal * 1.6726231E-27;
        /// <summary>
        /// kg -> ProtonMass
        /// vv: 1.6726231E-27 kilogram [kg] to 1 Proton mass
        /// </summary>
        public static double Kilogram_2_ProtonMass(double inVal)                        => inVal / 1.6726231E-27;

        /// <summary>
        /// NeutronMass -> kg
        /// 1 Neutron mass to vv: 1.6749286E-27 kilogram [kg]
        /// </summary>
        public static double NeutronMass_2_Kilogram(double inVal)                       => inVal * 1.6749286E-27;
        /// <summary>
        /// kg -> NeutronMass
        /// vv: 1.6749286E-27 kilogram [kg] to 1 Neutron mass
        /// </summary>
        public static double Kilogram_2_NeutronMass(double inVal)                       => inVal / 1.6749286E-27;

        /// <summary>
        /// DeuteronMass -> kg
        /// 1 Deuteron mass to vv: 3.343586E-27 kilogram [kg]
        /// </summary>
        public static double DeuteronMass_2_Kilogram(double inVal)                      => inVal * 3.343586E-27;
        /// <summary>
        /// kg -> DeuteronMass
        /// vv: 3.343586E-27 kilogram [kg] to 1 Deuteron mass
        /// </summary>
        public static double Kilogram_2_DeuteronMass(double inVal)                      => inVal / 3.343586E-27;

        /// <summary>
        /// EarthMass -> kg
        /// 1 Earth's mass to vv: 5.9760000000002E+24 kilogram [kg]
        /// </summary>
        public static double EarthMass_2_Kilogram(double inVal)                         => inVal * 5.9760000000002E+24;
        /// <summary>
        /// kg -> EarthMass
        /// vv: 5.9760000000002E+24 kilogram [kg] to 1 Earth's mass
        /// </summary>
        public static double Kilogram_2_EarthMass(double inVal)                         => inVal / 5.9760000000002E+24;

        /// <summary>
        /// SunMass -> kg
        /// 1 Sun's mass to vv: 2.0E+30 kilogram [kg]
        /// </summary>
        public static double SunMass_2_Kilogram(double inVal)                           => inVal * 2.0E+30;
        /// <summary>
        /// kg -> SunMass
        /// vv: 2.0E+30 kilogram [kg] to 1 Sun's mass
        /// </summary>
        public static double Kilogram_2_SunMass(double inVal)                           => inVal / 2.0E+30;

        #endregion
    }
}
