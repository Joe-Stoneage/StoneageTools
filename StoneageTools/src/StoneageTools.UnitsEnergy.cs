
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region energy, base: joule

        /// <summary>
        /// kJ -> J
        /// 1 kilojoule [kJ] to vv: 1000 joule [J]
        /// </summary>
        public static double Kilojoule_2_Joule(double inVal)                            => inVal * 1000;
        /// <summary>
        /// J -> kJ
        /// vv: 1000 joule [J] to 1 kilojoule [kJ]
        /// </summary>
        public static double Joule_2_Kilojoule(double inVal)                            => inVal / 1000;

        /// <summary>
        /// kW*h -> J
        /// 1 kilowatt-hour [kW*h] to vv: 3600000 joule [J]
        /// </summary>
        public static double KilowattHour_2_Joule(double inVal)                         => inVal * 3600000;
        /// <summary>
        /// J -> kW*h
        /// vv: 3600000 joule [J] to 1 kilowatt-hour [kW*h]
        /// </summary>
        public static double Joule_2_KilowattHour(double inVal)                         => inVal / 3600000;

        /// <summary>
        /// W*h -> J
        /// 1 watt-hour [W*h] to vv: 3600 joule [J]
        /// </summary>
        public static double WattHour_2_Joule(double inVal)                             => inVal * 3600;
        /// <summary>
        /// J -> W*h
        /// vv: 3600 joule [J] to 1 watt-hour [W*h]
        /// </summary>
        public static double Joule_2_WattHour(double inVal)                             => inVal / 3600;

        /// <summary>
        /// CalorieNutritional -> J
        /// 1 calorie (nutritional) to vv: 4186.8 joule [J]
        /// </summary>
        public static double CalorieNutritional_2_Joule(double inVal)                   => inVal * 4186.8;
        /// <summary>
        /// J -> CalorieNutritional
        /// vv: 4186.8 joule [J] to 1 calorie (nutritional)
        /// </summary>
        public static double Joule_2_CalorieNutritional(double inVal)                   => inVal / 4186.8;

        /// <summary>
        /// HorsepowerMetricHour -> J
        /// 1 horsepower (metric) hour to vv: 2647795.5 joule [J]
        /// </summary>
        public static double HorsepowerMetricHour_2_Joule(double inVal)                 => inVal * 2647795.5;
        /// <summary>
        /// J -> HorsepowerMetricHour
        /// vv: 2647795.5 joule [J] to 1 horsepower (metric) hour
        /// </summary>
        public static double Joule_2_HorsepowerMetricHour(double inVal)                 => inVal / 2647795.5;

        /// <summary>
        /// Btu (IT), Btu -> J
        /// 1 Btu (IT) [Btu (IT), Btu] to vv: 1055.05585262 joule [J]
        /// </summary>
        public static double BtuIT_2_Joule(double inVal)                                => inVal * 1055.05585262;
        /// <summary>
        /// J -> Btu (IT), Btu
        /// vv: 1055.05585262 joule [J] to 1 Btu (IT) [Btu (IT), Btu]
        /// </summary>
        public static double Joule_2_BtuIT(double inVal)                                => inVal / 1055.05585262;

        /// <summary>
        /// Btu (th) -> J
        /// 1 Btu (th) [Btu (th)] to vv: 1054.3499999744 joule [J]
        /// </summary>
        public static double BtuTh_2_Joule(double inVal)                                => inVal * 1054.3499999744;
        /// <summary>
        /// J -> Btu (th)
        /// vv: 1054.3499999744 joule [J] to 1 Btu (th) [Btu (th)]
        /// </summary>
        public static double Joule_2_BtuTh(double inVal)                                => inVal / 1054.3499999744;

        /// <summary>
        /// GJ -> J
        /// 1 gigajoule [GJ] to vv: 1000000000 joule [J]
        /// </summary>
        public static double Gigajoule_2_Joule(double inVal)                            => inVal * 1000000000;
        /// <summary>
        /// J -> GJ
        /// vv: 1000000000 joule [J] to 1 gigajoule [GJ]
        /// </summary>
        public static double Joule_2_Gigajoule(double inVal)                            => inVal / 1000000000;

        /// <summary>
        /// MJ -> J
        /// 1 megajoule [MJ] to vv: 1000000 joule [J]
        /// </summary>
        public static double Megajoule_2_Joule(double inVal)                            => inVal * 1000000;
        /// <summary>
        /// J -> MJ
        /// vv: 1000000 joule [J] to 1 megajoule [MJ]
        /// </summary>
        public static double Joule_2_Megajoule(double inVal)                            => inVal / 1000000;

        /// <summary>
        /// mJ -> J
        /// 1 millijoule [mJ] to vv: 0.001 joule [J]
        /// </summary>
        public static double Millijoule_2_Joule(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// J -> mJ
        /// vv: 0.001 joule [J] to 1 millijoule [mJ]
        /// </summary>
        public static double Joule_2_Millijoule(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// µJ -> J
        /// 1 microjoule [µJ] to vv: 1.0E-6 joule [J]
        /// </summary>
        public static double Microjoule_2_Joule(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// J -> µJ
        /// vv: 1.0E-6 joule [J] to 1 microjoule [µJ]
        /// </summary>
        public static double Joule_2_Microjoule(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// nJ -> J
        /// 1 nanojoule [nJ] to vv: 1.0E-9 joule [J]
        /// </summary>
        public static double Nanojoule_2_Joule(double inVal)                            => inVal * 1.0E-9;
        /// <summary>
        /// J -> nJ
        /// vv: 1.0E-9 joule [J] to 1 nanojoule [nJ]
        /// </summary>
        public static double Joule_2_Nanojoule(double inVal)                            => inVal / 1.0E-9;

        /// <summary>
        /// aJ -> J
        /// 1 attojoule [aJ] to vv: 1.0E-18 joule [J]
        /// </summary>
        public static double Attojoule_2_Joule(double inVal)                            => inVal * 1.0E-18;
        /// <summary>
        /// J -> aJ
        /// vv: 1.0E-18 joule [J] to 1 attojoule [aJ]
        /// </summary>
        public static double Joule_2_Attojoule(double inVal)                            => inVal / 1.0E-18;

        /// <summary>
        /// MeV -> J
        /// 1 megaelectron-volt [MeV] to vv: 1.60217733E-13 joule [J]
        /// </summary>
        public static double MegaelectronVolt_2_Joule(double inVal)                     => inVal * 1.60217733E-13;
        /// <summary>
        /// J -> MeV
        /// vv: 1.60217733E-13 joule [J] to 1 megaelectron-volt [MeV]
        /// </summary>
        public static double Joule_2_MegaelectronVolt(double inVal)                     => inVal / 1.60217733E-13;

        /// <summary>
        /// keV -> J
        /// 1 kiloelectron-volt [keV] to vv: 1.60217733E-16 joule [J]
        /// </summary>
        public static double KiloelectronVolt_2_Joule(double inVal)                     => inVal * 1.60217733E-16;
        /// <summary>
        /// J -> keV
        /// vv: 1.60217733E-16 joule [J] to 1 kiloelectron-volt [keV]
        /// </summary>
        public static double Joule_2_KiloelectronVolt(double inVal)                     => inVal / 1.60217733E-16;

        /// <summary>
        /// eV -> J
        /// 1 electron-volt [eV] to vv: 1.60217733E-19 joule [J]
        /// </summary>
        public static double ElectronVolt_2_Joule(double inVal)                         => inVal * 1.60217733E-19;
        /// <summary>
        /// J -> eV
        /// vv: 1.60217733E-19 joule [J] to 1 electron-volt [eV]
        /// </summary>
        public static double Joule_2_ElectronVolt(double inVal)                         => inVal / 1.60217733E-19;

        /// <summary>
        /// Erg -> J
        /// 1 erg to vv: 1.0E-7 joule [J]
        /// </summary>
        public static double Erg_2_Joule(double inVal)                                  => inVal * 1.0E-7;
        /// <summary>
        /// J -> Erg
        /// vv: 1.0E-7 joule [J] to 1 erg
        /// </summary>
        public static double Joule_2_Erg(double inVal)                                  => inVal / 1.0E-7;

        /// <summary>
        /// GW*h -> J
        /// 1 gigawatt-hour [GW*h] to vv: 3600000000000 joule [J]
        /// </summary>
        public static double GigawattHour_2_Joule(double inVal)                         => inVal * 3600000000000;
        /// <summary>
        /// J -> GW*h
        /// vv: 3600000000000 joule [J] to 1 gigawatt-hour [GW*h]
        /// </summary>
        public static double Joule_2_GigawattHour(double inVal)                         => inVal / 3600000000000;

        /// <summary>
        /// MW*h -> J
        /// 1 megawatt-hour [MW*h] to vv: 3600000000 joule [J]
        /// </summary>
        public static double MegawattHour_2_Joule(double inVal)                         => inVal * 3600000000;
        /// <summary>
        /// J -> MW*h
        /// vv: 3600000000 joule [J] to 1 megawatt-hour [MW*h]
        /// </summary>
        public static double Joule_2_MegawattHour(double inVal)                         => inVal / 3600000000;

        /// <summary>
        /// kW*s -> J
        /// 1 kilowatt-second [kW*s] to vv: 1000 joule [J]
        /// </summary>
        public static double KilowattSecond_2_Joule(double inVal)                       => inVal * 1000;
        /// <summary>
        /// J -> kW*s
        /// vv: 1000 joule [J] to 1 kilowatt-second [kW*s]
        /// </summary>
        public static double Joule_2_KilowattSecond(double inVal)                       => inVal / 1000;

        /// <summary>
        /// W*s -> J
        /// 1 watt-second [W*s] to vv: 1 joule [J]
        /// </summary>
        public static double WattSecond_2_Joule(double inVal)                           => inVal * 1;
        /// <summary>
        /// J -> W*s
        /// vv: 1 joule [J] to 1 watt-second [W*s]
        /// </summary>
        public static double Joule_2_WattSecond(double inVal)                           => inVal / 1;

        /// <summary>
        /// N*m -> J
        /// 1 newton meter [N*m] to vv: 1 joule [J]
        /// </summary>
        public static double NewtonMeter_2_Joule(double inVal)                          => inVal * 1;
        /// <summary>
        /// J -> N*m
        /// vv: 1 joule [J] to 1 newton meter [N*m]
        /// </summary>
        public static double Joule_2_NewtonMeter(double inVal)                          => inVal / 1;

        /// <summary>
        /// hp*h -> J
        /// 1 horsepower hour [hp*h] to vv: 2684519.5368856 joule [J]
        /// </summary>
        public static double HorsepowerHour_2_Joule(double inVal)                       => inVal * 2684519.5368856;
        /// <summary>
        /// J -> hp*h
        /// vv: 2684519.5368856 joule [J] to 1 horsepower hour [hp*h]
        /// </summary>
        public static double Joule_2_HorsepowerHour(double inVal)                       => inVal / 2684519.5368856;

        /// <summary>
        /// kcal (IT) -> J
        /// 1 kilocalorie (IT) [kcal (IT)] to vv: 4186.8 joule [J]
        /// </summary>
        public static double KilocalorieIT_2_Joule(double inVal)                        => inVal * 4186.8;
        /// <summary>
        /// J -> kcal (IT)
        /// vv: 4186.8 joule [J] to 1 kilocalorie (IT) [kcal (IT)]
        /// </summary>
        public static double Joule_2_KilocalorieIT(double inVal)                        => inVal / 4186.8;

        /// <summary>
        /// kcal (th) -> J
        /// 1 kilocalorie (th) [kcal (th)] to vv: 4184 joule [J]
        /// </summary>
        public static double KilocalorieTh_2_Joule(double inVal)                        => inVal * 4184;
        /// <summary>
        /// J -> kcal (th)
        /// vv: 4184 joule [J] to 1 kilocalorie (th) [kcal (th)]
        /// </summary>
        public static double Joule_2_KilocalorieTh(double inVal)                        => inVal / 4184;

        /// <summary>
        /// cal (IT), cal -> J
        /// 1 calorie (IT) [cal (IT), cal] to vv: 4.1868 joule [J]
        /// </summary>
        public static double CalorieIT_2_Joule(double inVal)                            => inVal * 4.1868;
        /// <summary>
        /// J -> cal (IT), cal
        /// vv: 4.1868 joule [J] to 1 calorie (IT) [cal (IT), cal]
        /// </summary>
        public static double Joule_2_CalorieIT(double inVal)                            => inVal / 4.1868;

        /// <summary>
        /// cal (th) -> J
        /// 1 calorie (th) [cal (th)] to vv: 4.184 joule [J]
        /// </summary>
        public static double CalorieTh_2_Joule(double inVal)                            => inVal * 4.184;
        /// <summary>
        /// J -> cal (th)
        /// vv: 4.184 joule [J] to 1 calorie (th) [cal (th)]
        /// </summary>
        public static double Joule_2_CalorieTh(double inVal)                            => inVal / 4.184;

        /// <summary>
        /// MBtu (IT) -> J
        /// 1 mega Btu (IT) [MBtu (IT)] to vv: 1055055852.62 joule [J]
        /// </summary>
        public static double MegaBtuIT_2_Joule(double inVal)                            => inVal * 1055055852.62;
        /// <summary>
        /// J -> MBtu (IT)
        /// vv: 1055055852.62 joule [J] to 1 mega Btu (IT) [MBtu (IT)]
        /// </summary>
        public static double Joule_2_MegaBtuIT(double inVal)                            => inVal / 1055055852.62;

        /// <summary>
        /// TonHourRefrigeration -> J
        /// 1 ton-hour (refrigeration) to vv: 12660670.23144 joule [J]
        /// </summary>
        public static double TonHourRefrigeration_2_Joule(double inVal)                 => inVal * 12660670.23144;
        /// <summary>
        /// J -> TonHourRefrigeration
        /// vv: 12660670.23144 joule [J] to 1 ton-hour (refrigeration)
        /// </summary>
        public static double Joule_2_TonHourRefrigeration(double inVal)                 => inVal / 12660670.23144;

        /// <summary>
        /// FuelOilEquivalentAtKiloliter -> J
        /// 1 fuel oil equivalent @kiloliter to vv: 40197627984.822 joule [J]
        /// </summary>
        public static double FuelOilEquivalentAtKiloliter_2_Joule(double inVal)         => inVal * 40197627984.822;
        /// <summary>
        /// J -> FuelOilEquivalentAtKiloliter
        /// vv: 40197627984.822 joule [J] to 1 fuel oil equivalent @kiloliter
        /// </summary>
        public static double Joule_2_FuelOilEquivalentAtKiloliter(double inVal)         => inVal / 40197627984.822;

        /// <summary>
        /// FuelOilEquivalentAtBarrelUS -> J
        /// 1 fuel oil equivalent @barrel (US) to vv: 6383087908.3509 joule [J]
        /// </summary>
        public static double FuelOilEquivalentAtBarrelUS_2_Joule(double inVal)          => inVal * 6383087908.3509;
        /// <summary>
        /// J -> FuelOilEquivalentAtBarrelUS
        /// vv: 6383087908.3509 joule [J] to 1 fuel oil equivalent @barrel (US)
        /// </summary>
        public static double Joule_2_FuelOilEquivalentAtBarrelUS(double inVal)          => inVal / 6383087908.3509;

        /// <summary>
        /// Gton -> J
        /// 1 gigaton [Gton] to vv: 4.184E+18 joule [J]
        /// </summary>
        public static double Gigaton_2_Joule(double inVal)                              => inVal * 4.184E+18;
        /// <summary>
        /// J -> Gton
        /// vv: 4.184E+18 joule [J] to 1 gigaton [Gton]
        /// </summary>
        public static double Joule_2_Gigaton(double inVal)                              => inVal / 4.184E+18;

        /// <summary>
        /// Mton -> J
        /// 1 megaton [Mton] to vv: 4.184E+15 joule [J]
        /// </summary>
        public static double Megaton_2_Joule(double inVal)                              => inVal * 4.184E+15;
        /// <summary>
        /// J -> Mton
        /// vv: 4.184E+15 joule [J] to 1 megaton [Mton]
        /// </summary>
        public static double Joule_2_Megaton(double inVal)                              => inVal / 4.184E+15;

        /// <summary>
        /// kton -> J
        /// 1 kiloton [kton] to vv: 4184000000000 joule [J]
        /// </summary>
        public static double Kiloton_2_Joule(double inVal)                              => inVal * 4184000000000;
        /// <summary>
        /// J -> kton
        /// vv: 4184000000000 joule [J] to 1 kiloton [kton]
        /// </summary>
        public static double Joule_2_Kiloton(double inVal)                              => inVal / 4184000000000;

        /// <summary>
        /// TonExplosives -> J
        /// 1 ton (explosives) to vv: 4184000000 joule [J]
        /// </summary>
        public static double TonExplosives_2_Joule(double inVal)                        => inVal * 4184000000;
        /// <summary>
        /// J -> TonExplosives
        /// vv: 4184000000 joule [J] to 1 ton (explosives)
        /// </summary>
        public static double Joule_2_TonExplosives(double inVal)                        => inVal / 4184000000;

        /// <summary>
        /// dyn*cm -> J
        /// 1 dyne centimeter [dyn*cm] to vv: 1.0E-7 joule [J]
        /// </summary>
        public static double DyneCentimeter_2_Joule(double inVal)                       => inVal * 1.0E-7;
        /// <summary>
        /// J -> dyn*cm
        /// vv: 1.0E-7 joule [J] to 1 dyne centimeter [dyn*cm]
        /// </summary>
        public static double Joule_2_DyneCentimeter(double inVal)                       => inVal / 1.0E-7;

        /// <summary>
        /// gf*m -> J
        /// 1 gram-force meter [gf*m] to vv: 0.00980665 joule [J]
        /// </summary>
        public static double GramForceMeter_2_Joule(double inVal)                       => inVal * 0.00980665;
        /// <summary>
        /// J -> gf*m
        /// vv: 0.00980665 joule [J] to 1 gram-force meter [gf*m]
        /// </summary>
        public static double Joule_2_GramForceMeter(double inVal)                       => inVal / 0.00980665;

        /// <summary>
        /// GramForceCentimeter -> J
        /// 1 gram-force centimeter to vv: 9.80665E-5 joule [J]
        /// </summary>
        public static double GramForceCentimeter_2_Joule(double inVal)                  => inVal * 9.80665E-5;
        /// <summary>
        /// J -> GramForceCentimeter
        /// vv: 9.80665E-5 joule [J] to 1 gram-force centimeter
        /// </summary>
        public static double Joule_2_GramForceCentimeter(double inVal)                  => inVal / 9.80665E-5;

        /// <summary>
        /// KilogramForceCentimeter -> J
        /// 1 kilogram-force centimeter to vv: 0.0980665 joule [J]
        /// </summary>
        public static double KilogramForceCentimeter_2_Joule(double inVal)              => inVal * 0.0980665;
        /// <summary>
        /// J -> KilogramForceCentimeter
        /// vv: 0.0980665 joule [J] to 1 kilogram-force centimeter
        /// </summary>
        public static double Joule_2_KilogramForceCentimeter(double inVal)              => inVal / 0.0980665;

        /// <summary>
        /// KilogramForceMeter -> J
        /// 1 kilogram-force meter to vv: 9.8066499997 joule [J]
        /// </summary>
        public static double KilogramForceMeter_2_Joule(double inVal)                   => inVal * 9.8066499997;
        /// <summary>
        /// J -> KilogramForceMeter
        /// vv: 9.8066499997 joule [J] to 1 kilogram-force meter
        /// </summary>
        public static double Joule_2_KilogramForceMeter(double inVal)                   => inVal / 9.8066499997;

        /// <summary>
        /// kp*m -> J
        /// 1 kilopond meter [kp*m] to vv: 9.8066499997 joule [J]
        /// </summary>
        public static double KilopondMeter_2_Joule(double inVal)                        => inVal * 9.8066499997;
        /// <summary>
        /// J -> kp*m
        /// vv: 9.8066499997 joule [J] to 1 kilopond meter [kp*m]
        /// </summary>
        public static double Joule_2_KilopondMeter(double inVal)                        => inVal / 9.8066499997;

        /// <summary>
        /// lbf*ft -> J
        /// 1 pound-force foot [lbf*ft] to vv: 1.3558179483 joule [J]
        /// </summary>
        public static double PoundForceFoot_2_Joule(double inVal)                       => inVal * 1.3558179483;
        /// <summary>
        /// J -> lbf*ft
        /// vv: 1.3558179483 joule [J] to 1 pound-force foot [lbf*ft]
        /// </summary>
        public static double Joule_2_PoundForceFoot(double inVal)                       => inVal / 1.3558179483;

        /// <summary>
        /// lbf*in -> J
        /// 1 pound-force inch [lbf*in] to vv: 0.112984829 joule [J]
        /// </summary>
        public static double PoundForceInch_2_Joule(double inVal)                       => inVal * 0.112984829;
        /// <summary>
        /// J -> lbf*in
        /// vv: 0.112984829 joule [J] to 1 pound-force inch [lbf*in]
        /// </summary>
        public static double Joule_2_PoundForceInch(double inVal)                       => inVal / 0.112984829;

        /// <summary>
        /// ozf*in -> J
        /// 1 ounce-force inch [ozf*in] to vv: 0.0070615518 joule [J]
        /// </summary>
        public static double OunceForceInch_2_Joule(double inVal)                       => inVal * 0.0070615518;
        /// <summary>
        /// J -> ozf*in
        /// vv: 0.0070615518 joule [J] to 1 ounce-force inch [ozf*in]
        /// </summary>
        public static double Joule_2_OunceForceInch(double inVal)                       => inVal / 0.0070615518;

        /// <summary>
        /// ft*lbf -> J
        /// 1 foot-pound [ft*lbf] to vv: 1.3558179483 joule [J]
        /// </summary>
        public static double FootPound_2_Joule(double inVal)                            => inVal * 1.3558179483;
        /// <summary>
        /// J -> ft*lbf
        /// vv: 1.3558179483 joule [J] to 1 foot-pound [ft*lbf]
        /// </summary>
        public static double Joule_2_FootPound(double inVal)                            => inVal / 1.3558179483;

        /// <summary>
        /// in*lbf -> J
        /// 1 inch-pound [in*lbf] to vv: 0.112984829 joule [J]
        /// </summary>
        public static double InchPound_2_Joule(double inVal)                            => inVal * 0.112984829;
        /// <summary>
        /// J -> in*lbf
        /// vv: 0.112984829 joule [J] to 1 inch-pound [in*lbf]
        /// </summary>
        public static double Joule_2_InchPound(double inVal)                            => inVal / 0.112984829;

        /// <summary>
        /// in*ozf -> J
        /// 1 inch-ounce [in*ozf] to vv: 0.0070615518 joule [J]
        /// </summary>
        public static double InchOunce_2_Joule(double inVal)                            => inVal * 0.0070615518;
        /// <summary>
        /// J -> in*ozf
        /// vv: 0.0070615518 joule [J] to 1 inch-ounce [in*ozf]
        /// </summary>
        public static double Joule_2_InchOunce(double inVal)                            => inVal / 0.0070615518;

        /// <summary>
        /// pdl*ft -> J
        /// 1 poundal foot [pdl*ft] to vv: 0.04214011 joule [J]
        /// </summary>
        public static double PoundalFoot_2_Joule(double inVal)                          => inVal * 0.04214011;
        /// <summary>
        /// J -> pdl*ft
        /// vv: 0.04214011 joule [J] to 1 poundal foot [pdl*ft]
        /// </summary>
        public static double Joule_2_PoundalFoot(double inVal)                          => inVal / 0.04214011;

        /// <summary>
        /// Therm -> J
        /// 1 therm to vv: 105505600 joule [J]
        /// </summary>
        public static double Therm_2_Joule(double inVal)                                => inVal * 105505600;
        /// <summary>
        /// J -> Therm
        /// vv: 105505600 joule [J] to 1 therm
        /// </summary>
        public static double Joule_2_Therm(double inVal)                                => inVal / 105505600;

        /// <summary>
        /// ThermEC -> J
        /// 1 therm (EC) to vv: 105505600 joule [J]
        /// </summary>
        public static double ThermEC_2_Joule(double inVal)                              => inVal * 105505600;
        /// <summary>
        /// J -> ThermEC
        /// vv: 105505600 joule [J] to 1 therm (EC)
        /// </summary>
        public static double Joule_2_ThermEC(double inVal)                              => inVal / 105505600;

        /// <summary>
        /// ThermUS -> J
        /// 1 therm (US) to vv: 105480400 joule [J]
        /// </summary>
        public static double ThermUS_2_Joule(double inVal)                              => inVal * 105480400;
        /// <summary>
        /// J -> ThermUS
        /// vv: 105480400 joule [J] to 1 therm (US)
        /// </summary>
        public static double Joule_2_ThermUS(double inVal)                              => inVal / 105480400;

        /// <summary>
        /// HartreeEnergy -> J
        /// 1 Hartree energy to vv: 4.3597482E-18 joule [J]
        /// </summary>
        public static double HartreeEnergy_2_Joule(double inVal)                        => inVal * 4.3597482E-18;
        /// <summary>
        /// J -> HartreeEnergy
        /// vv: 4.3597482E-18 joule [J] to 1 Hartree energy
        /// </summary>
        public static double Joule_2_HartreeEnergy(double inVal)                        => inVal / 4.3597482E-18;

        /// <summary>
        /// RydbergConstant -> J
        /// 1 Rydberg constant to vv: 2.1798741E-18 joule [J]
        /// </summary>
        public static double RydbergConstant_2_Joule(double inVal)                      => inVal * 2.1798741E-18;
        /// <summary>
        /// J -> RydbergConstant
        /// vv: 2.1798741E-18 joule [J] to 1 Rydberg constant
        /// </summary>
        public static double Joule_2_RydbergConstant(double inVal)                      => inVal / 2.1798741E-18;

        #endregion
    }
}
