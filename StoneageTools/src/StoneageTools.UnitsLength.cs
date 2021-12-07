
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region length, base: meter

        /// <summary>
        /// km -> m
        /// 1 kilometer [km] to vv: 1000 meter [m]
        /// </summary>
        public static double Kilometer_2_Meter(double inVal)                            => inVal * 1000;
        /// <summary>
        /// m -> km
        /// vv: 1000 meter [m] to 1 kilometer [km]
        /// </summary>
        public static double Meter_2_Kilometer(double inVal)                            => inVal / 1000;

        /// <summary>
        /// dm -> m
        /// 1 decimeter [dm] to vv: 0.1 meter [m]
        /// </summary>
        public static double Decimeter_2_Meter(double inVal)                            => inVal * 0.1;
        /// <summary>
        /// m -> dm
        /// vv: 0.1 meter [m] to 1 decimeter [dm]
        /// </summary>
        public static double Meter_2_Decimeter(double inVal)                            => inVal / 0.1;

        /// <summary>
        /// cm -> m
        /// 1 centimeter [cm] to vv: 0.01 meter [m]
        /// </summary>
        public static double Centimeter_2_Meter(double inVal)                           => inVal * 0.01;
        /// <summary>
        /// m -> cm
        /// vv: 0.01 meter [m] to 1 centimeter [cm]
        /// </summary>
        public static double Meter_2_Centimeter(double inVal)                           => inVal / 0.01;

        /// <summary>
        /// mm -> m
        /// 1 millimeter [mm] to vv: 0.001 meter [m]
        /// </summary>
        public static double Millimeter_2_Meter(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// m -> mm
        /// vv: 0.001 meter [m] to 1 millimeter [mm]
        /// </summary>
        public static double Meter_2_Millimeter(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// µm -> m
        /// 1 micrometer [µm] to vv: 1.0E-6 meter [m]
        /// </summary>
        public static double Micrometer_2_Meter(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// m -> µm
        /// vv: 1.0E-6 meter [m] to 1 micrometer [µm]
        /// </summary>
        public static double Meter_2_Micrometer(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// nm -> m
        /// 1 nanometer [nm] to vv: 1.0E-9 meter [m]
        /// </summary>
        public static double Nanometer_2_Meter(double inVal)                            => inVal * 1.0E-9;
        /// <summary>
        /// m -> nm
        /// vv: 1.0E-9 meter [m] to 1 nanometer [nm]
        /// </summary>
        public static double Meter_2_Nanometer(double inVal)                            => inVal / 1.0E-9;

        /// <summary>
        /// mi, mi(Int) -> m
        /// 1 mile [mi, mi(Int)] to vv: 1609.344 meter [m]
        /// </summary>
        public static double Mile_2_Meter(double inVal)                                 => inVal * 1609.344;
        /// <summary>
        /// m -> mi, mi(Int)
        /// vv: 1609.344 meter [m] to 1 mile [mi, mi(Int)]
        /// </summary>
        public static double Meter_2_Mile(double inVal)                                 => inVal / 1609.344;

        /// <summary>
        /// yd -> m
        /// 1 yard [yd] to vv: 0.9144 meter [m]
        /// </summary>
        public static double Yard_2_Meter(double inVal)                                 => inVal * 0.9144;
        /// <summary>
        /// m -> yd
        /// vv: 0.9144 meter [m] to 1 yard [yd]
        /// </summary>
        public static double Meter_2_Yard(double inVal)                                 => inVal / 0.9144;

        /// <summary>
        /// ft -> m
        /// 1 foot [ft] to vv: 0.3048 meter [m]
        /// </summary>
        public static double Foot_2_Meter(double inVal)                                 => inVal * 0.3048;
        /// <summary>
        /// m -> ft
        /// vv: 0.3048 meter [m] to 1 foot [ft]
        /// </summary>
        public static double Meter_2_Foot(double inVal)                                 => inVal / 0.3048;

        /// <summary>
        /// in -> m
        /// 1 inch [in] to vv: 0.0254 meter [m]
        /// </summary>
        public static double Inch_2_Meter(double inVal)                                 => inVal * 0.0254;
        /// <summary>
        /// m -> in
        /// vv: 0.0254 meter [m] to 1 inch [in]
        /// </summary>
        public static double Meter_2_Inch(double inVal)                                 => inVal / 0.0254;

        /// <summary>
        /// ly -> m
        /// 1 light year [ly] to vv: 9.46073047258E+15 meter [m]
        /// </summary>
        public static double LightYear_2_Meter(double inVal)                            => inVal * 9.46073047258E+15;
        /// <summary>
        /// m -> ly
        /// vv: 9.46073047258E+15 meter [m] to 1 light year [ly]
        /// </summary>
        public static double Meter_2_LightYear(double inVal)                            => inVal / 9.46073047258E+15;

        /// <summary>
        /// Em -> m
        /// 1 exameter [Em] to vv: 1.0E+18 meter [m]
        /// </summary>
        public static double Exameter_2_Meter(double inVal)                             => inVal * 1.0E+18;
        /// <summary>
        /// m -> Em
        /// vv: 1.0E+18 meter [m] to 1 exameter [Em]
        /// </summary>
        public static double Meter_2_Exameter(double inVal)                             => inVal / 1.0E+18;

        /// <summary>
        /// Pm -> m
        /// 1 petameter [Pm] to vv: 1.0E+15 meter [m]
        /// </summary>
        public static double Petameter_2_Meter(double inVal)                            => inVal * 1.0E+15;
        /// <summary>
        /// m -> Pm
        /// vv: 1.0E+15 meter [m] to 1 petameter [Pm]
        /// </summary>
        public static double Meter_2_Petameter(double inVal)                            => inVal / 1.0E+15;

        /// <summary>
        /// Tm -> m
        /// 1 terameter [Tm] to vv: 1000000000000 meter [m]
        /// </summary>
        public static double Terameter_2_Meter(double inVal)                            => inVal * 1000000000000;
        /// <summary>
        /// m -> Tm
        /// vv: 1000000000000 meter [m] to 1 terameter [Tm]
        /// </summary>
        public static double Meter_2_Terameter(double inVal)                            => inVal / 1000000000000;

        /// <summary>
        /// Gm -> m
        /// 1 gigameter [Gm] to vv: 1000000000 meter [m]
        /// </summary>
        public static double Gigameter_2_Meter(double inVal)                            => inVal * 1000000000;
        /// <summary>
        /// m -> Gm
        /// vv: 1000000000 meter [m] to 1 gigameter [Gm]
        /// </summary>
        public static double Meter_2_Gigameter(double inVal)                            => inVal / 1000000000;

        /// <summary>
        /// Mm -> m
        /// 1 megameter [Mm] to vv: 1000000 meter [m]
        /// </summary>
        public static double Megameter_2_Meter(double inVal)                            => inVal * 1000000;
        /// <summary>
        /// m -> Mm
        /// vv: 1000000 meter [m] to 1 megameter [Mm]
        /// </summary>
        public static double Meter_2_Megameter(double inVal)                            => inVal / 1000000;

        /// <summary>
        /// hm -> m
        /// 1 hectometer [hm] to vv: 100 meter [m]
        /// </summary>
        public static double Hectometer_2_Meter(double inVal)                           => inVal * 100;
        /// <summary>
        /// m -> hm
        /// vv: 100 meter [m] to 1 hectometer [hm]
        /// </summary>
        public static double Meter_2_Hectometer(double inVal)                           => inVal / 100;

        /// <summary>
        /// dam -> m
        /// 1 dekameter [dam] to vv: 10 meter [m]
        /// </summary>
        public static double Dekameter_2_Meter(double inVal)                            => inVal * 10;
        /// <summary>
        /// m -> dam
        /// vv: 10 meter [m] to 1 dekameter [dam]
        /// </summary>
        public static double Meter_2_Dekameter(double inVal)                            => inVal / 10;

        /// <summary>
        /// µ -> m
        /// 1 micron [µ] to vv: 1.0E-6 meter [m]
        /// </summary>
        public static double Micron_2_Meter(double inVal)                               => inVal * 1.0E-6;
        /// <summary>
        /// m -> µ
        /// vv: 1.0E-6 meter [m] to 1 micron [µ]
        /// </summary>
        public static double Meter_2_Micron(double inVal)                               => inVal / 1.0E-6;

        /// <summary>
        /// pm -> m
        /// 1 picometer [pm] to vv: 1.0E-12 meter [m]
        /// </summary>
        public static double Picometer_2_Meter(double inVal)                            => inVal * 1.0E-12;
        /// <summary>
        /// m -> pm
        /// vv: 1.0E-12 meter [m] to 1 picometer [pm]
        /// </summary>
        public static double Meter_2_Picometer(double inVal)                            => inVal / 1.0E-12;

        /// <summary>
        /// fm -> m
        /// 1 femtometer [fm] to vv: 1.0E-15 meter [m]
        /// </summary>
        public static double Femtometer_2_Meter(double inVal)                           => inVal * 1.0E-15;
        /// <summary>
        /// m -> fm
        /// vv: 1.0E-15 meter [m] to 1 femtometer [fm]
        /// </summary>
        public static double Meter_2_Femtometer(double inVal)                           => inVal / 1.0E-15;

        /// <summary>
        /// am -> m
        /// 1 attometer [am] to vv: 1.0E-18 meter [m]
        /// </summary>
        public static double Attometer_2_Meter(double inVal)                            => inVal * 1.0E-18;
        /// <summary>
        /// m -> am
        /// vv: 1.0E-18 meter [m] to 1 attometer [am]
        /// </summary>
        public static double Meter_2_Attometer(double inVal)                            => inVal / 1.0E-18;

        /// <summary>
        /// Mpc -> m
        /// 1 megaparsec [Mpc] to vv: 3.08567758128E+22 meter [m]
        /// </summary>
        public static double Megaparsec_2_Meter(double inVal)                           => inVal * 3.08567758128E+22;
        /// <summary>
        /// m -> Mpc
        /// vv: 3.08567758128E+22 meter [m] to 1 megaparsec [Mpc]
        /// </summary>
        public static double Meter_2_Megaparsec(double inVal)                           => inVal / 3.08567758128E+22;

        /// <summary>
        /// kpc -> m
        /// 1 kiloparsec [kpc] to vv: 3.08567758128E+19 meter [m]
        /// </summary>
        public static double Kiloparsec_2_Meter(double inVal)                           => inVal * 3.08567758128E+19;
        /// <summary>
        /// m -> kpc
        /// vv: 3.08567758128E+19 meter [m] to 1 kiloparsec [kpc]
        /// </summary>
        public static double Meter_2_Kiloparsec(double inVal)                           => inVal / 3.08567758128E+19;

        /// <summary>
        /// pc -> m
        /// 1 parsec [pc] to vv: 3.08567758128E+16 meter [m]
        /// </summary>
        public static double Parsec_2_Meter(double inVal)                               => inVal * 3.08567758128E+16;
        /// <summary>
        /// m -> pc
        /// vv: 3.08567758128E+16 meter [m] to 1 parsec [pc]
        /// </summary>
        public static double Meter_2_Parsec(double inVal)                               => inVal / 3.08567758128E+16;

        /// <summary>
        /// AU, UA -> m
        /// 1 astronomical unit [AU, UA] to vv: 149597870691 meter [m]
        /// </summary>
        public static double AstronomicalUnit_2_Meter(double inVal)                     => inVal * 149597870691;
        /// <summary>
        /// m -> AU, UA
        /// vv: 149597870691 meter [m] to 1 astronomical unit [AU, UA]
        /// </summary>
        public static double Meter_2_AstronomicalUnit(double inVal)                     => inVal / 149597870691;

        /// <summary>
        /// lea -> m
        /// 1 league [lea] to vv: 4828.032 meter [m]
        /// </summary>
        public static double League_2_Meter(double inVal)                               => inVal * 4828.032;
        /// <summary>
        /// m -> lea
        /// vv: 4828.032 meter [m] to 1 league [lea]
        /// </summary>
        public static double Meter_2_League(double inVal)                               => inVal / 4828.032;

        /// <summary>
        /// NauticalLeagueUK -> m
        /// 1 nautical league (UK) to vv: 5559.552 meter [m]
        /// </summary>
        public static double NauticalLeagueUK_2_Meter(double inVal)                     => inVal * 5559.552;
        /// <summary>
        /// m -> NauticalLeagueUK
        /// vv: 5559.552 meter [m] to 1 nautical league (UK)
        /// </summary>
        public static double Meter_2_NauticalLeagueUK(double inVal)                     => inVal / 5559.552;

        /// <summary>
        /// NauticalLeagueInt. -> m
        /// 1 nautical league (int.) to vv: 5556 meter [m]
        /// </summary>
        public static double NauticalLeagueInt_2_Meter(double inVal)                    => inVal * 5556;
        /// <summary>
        /// m -> NauticalLeagueInt.
        /// vv: 5556 meter [m] to 1 nautical league (int.)
        /// </summary>
        public static double Meter_2_NauticalLeagueInt(double inVal)                    => inVal / 5556;

        /// <summary>
        /// st.league -> m
        /// 1 league (statute) [st.league] to vv: 4828.0416560833 meter [m]
        /// </summary>
        public static double LeagueStatute_2_Meter(double inVal)                        => inVal * 4828.0416560833;
        /// <summary>
        /// m -> st.league
        /// vv: 4828.0416560833 meter [m] to 1 league (statute) [st.league]
        /// </summary>
        public static double Meter_2_LeagueStatute(double inVal)                        => inVal / 4828.0416560833;

        /// <summary>
        /// NM (UK) -> m
        /// 1 nautical mile (UK) [NM (UK)] to vv: 1853.184 meter [m]
        /// </summary>
        public static double NauticalMileUK_2_Meter(double inVal)                       => inVal * 1853.184;
        /// <summary>
        /// m -> NM (UK)
        /// vv: 1853.184 meter [m] to 1 nautical mile (UK) [NM (UK)]
        /// </summary>
        public static double Meter_2_NauticalMileUK(double inVal)                       => inVal / 1853.184;

        /// <summary>
        /// NauticalMileInternational -> m
        /// 1 nautical mile (international) to vv: 1852 meter [m]
        /// </summary>
        public static double NauticalMileInternational_2_Meter(double inVal)            => inVal * 1852;
        /// <summary>
        /// m -> NauticalMileInternational
        /// vv: 1852 meter [m] to 1 nautical mile (international)
        /// </summary>
        public static double Meter_2_NauticalMileInternational(double inVal)            => inVal / 1852;

        /// <summary>
        /// mi, mi (US) -> m
        /// 1 mile (statute) [mi, mi (US)] to vv: 1609.3472186944 meter [m]
        /// </summary>
        public static double MileStatute_2_Meter(double inVal)                          => inVal * 1609.3472186944;
        /// <summary>
        /// m -> mi, mi (US)
        /// vv: 1609.3472186944 meter [m] to 1 mile (statute) [mi, mi (US)]
        /// </summary>
        public static double Meter_2_MileStatute(double inVal)                          => inVal / 1609.3472186944;

        /// <summary>
        /// mi -> m
        /// 1 mile (US survey) [mi] to vv: 1609.3472186944 meter [m]
        /// </summary>
        public static double MileUSSurvey_2_Meter(double inVal)                         => inVal * 1609.3472186944;
        /// <summary>
        /// m -> mi
        /// vv: 1609.3472186944 meter [m] to 1 mile (US survey) [mi]
        /// </summary>
        public static double Meter_2_MileUSSurvey(double inVal)                         => inVal / 1609.3472186944;

        /// <summary>
        /// MileRoman -> m
        /// 1 mile (Roman) to vv: 1479.804 meter [m]
        /// </summary>
        public static double MileRoman_2_Meter(double inVal)                            => inVal * 1479.804;
        /// <summary>
        /// m -> MileRoman
        /// vv: 1479.804 meter [m] to 1 mile (Roman)
        /// </summary>
        public static double Meter_2_MileRoman(double inVal)                            => inVal / 1479.804;

        /// <summary>
        /// kyd -> m
        /// 1 kiloyard [kyd] to vv: 914.4 meter [m]
        /// </summary>
        public static double Kiloyard_2_Meter(double inVal)                             => inVal * 914.4;
        /// <summary>
        /// m -> kyd
        /// vv: 914.4 meter [m] to 1 kiloyard [kyd]
        /// </summary>
        public static double Meter_2_Kiloyard(double inVal)                             => inVal / 914.4;

        /// <summary>
        /// fur -> m
        /// 1 furlong [fur] to vv: 201.168 meter [m]
        /// </summary>
        public static double Furlong_2_Meter(double inVal)                              => inVal * 201.168;
        /// <summary>
        /// m -> fur
        /// vv: 201.168 meter [m] to 1 furlong [fur]
        /// </summary>
        public static double Meter_2_Furlong(double inVal)                              => inVal / 201.168;

        /// <summary>
        /// fur -> m
        /// 1 furlong (US survey) [fur] to vv: 201.1684023368 meter [m]
        /// </summary>
        public static double FurlongUSSurvey_2_Meter(double inVal)                      => inVal * 201.1684023368;
        /// <summary>
        /// m -> fur
        /// vv: 201.1684023368 meter [m] to 1 furlong (US survey) [fur]
        /// </summary>
        public static double Meter_2_FurlongUSSurvey(double inVal)                      => inVal / 201.1684023368;

        /// <summary>
        /// ch -> m
        /// 1 chain [ch] to vv: 20.1168 meter [m]
        /// </summary>
        public static double Chain_2_Meter(double inVal)                                => inVal * 20.1168;
        /// <summary>
        /// m -> ch
        /// vv: 20.1168 meter [m] to 1 chain [ch]
        /// </summary>
        public static double Meter_2_Chain(double inVal)                                => inVal / 20.1168;

        /// <summary>
        /// ch -> m
        /// 1 chain (US survey) [ch] to vv: 20.1168402337 meter [m]
        /// </summary>
        public static double ChainUSSurvey_2_Meter(double inVal)                        => inVal * 20.1168402337;
        /// <summary>
        /// m -> ch
        /// vv: 20.1168402337 meter [m] to 1 chain (US survey) [ch]
        /// </summary>
        public static double Meter_2_ChainUSSurvey(double inVal)                        => inVal / 20.1168402337;

        /// <summary>
        /// Rope -> m
        /// 1 rope to vv: 6.096 meter [m]
        /// </summary>
        public static double Rope_2_Meter(double inVal)                                 => inVal * 6.096;
        /// <summary>
        /// m -> Rope
        /// vv: 6.096 meter [m] to 1 rope
        /// </summary>
        public static double Meter_2_Rope(double inVal)                                 => inVal / 6.096;

        /// <summary>
        /// rd -> m
        /// 1 rod [rd] to vv: 5.0292 meter [m]
        /// </summary>
        public static double Rod_2_Meter(double inVal)                                  => inVal * 5.0292;
        /// <summary>
        /// m -> rd
        /// vv: 5.0292 meter [m] to 1 rod [rd]
        /// </summary>
        public static double Meter_2_Rod(double inVal)                                  => inVal / 5.0292;

        /// <summary>
        /// rd -> m
        /// 1 rod (US survey) [rd] to vv: 5.0292100584 meter [m]
        /// </summary>
        public static double RodUSSurvey_2_Meter(double inVal)                          => inVal * 5.0292100584;
        /// <summary>
        /// m -> rd
        /// vv: 5.0292100584 meter [m] to 1 rod (US survey) [rd]
        /// </summary>
        public static double Meter_2_RodUSSurvey(double inVal)                          => inVal / 5.0292100584;

        /// <summary>
        /// Perch -> m
        /// 1 perch to vv: 5.0292 meter [m]
        /// </summary>
        public static double Perch_2_Meter(double inVal)                                => inVal * 5.0292;
        /// <summary>
        /// m -> Perch
        /// vv: 5.0292 meter [m] to 1 perch
        /// </summary>
        public static double Meter_2_Perch(double inVal)                                => inVal / 5.0292;

        /// <summary>
        /// Pole -> m
        /// 1 pole to vv: 5.0292 meter [m]
        /// </summary>
        public static double Pole_2_Meter(double inVal)                                 => inVal * 5.0292;
        /// <summary>
        /// m -> Pole
        /// vv: 5.0292 meter [m] to 1 pole
        /// </summary>
        public static double Meter_2_Pole(double inVal)                                 => inVal / 5.0292;

        /// <summary>
        /// fath -> m
        /// 1 fathom [fath] to vv: 1.8288 meter [m]
        /// </summary>
        public static double Fathom_2_Meter(double inVal)                               => inVal * 1.8288;
        /// <summary>
        /// m -> fath
        /// vv: 1.8288 meter [m] to 1 fathom [fath]
        /// </summary>
        public static double Meter_2_Fathom(double inVal)                               => inVal / 1.8288;

        /// <summary>
        /// fath -> m
        /// 1 fathom (US survey) [fath] to vv: 1.8288036576 meter [m]
        /// </summary>
        public static double FathomUSSurvey_2_Meter(double inVal)                       => inVal * 1.8288036576;
        /// <summary>
        /// m -> fath
        /// vv: 1.8288036576 meter [m] to 1 fathom (US survey) [fath]
        /// </summary>
        public static double Meter_2_FathomUSSurvey(double inVal)                       => inVal / 1.8288036576;

        /// <summary>
        /// Ell -> m
        /// 1 ell to vv: 1.143 meter [m]
        /// </summary>
        public static double Ell_2_Meter(double inVal)                                  => inVal * 1.143;
        /// <summary>
        /// m -> Ell
        /// vv: 1.143 meter [m] to 1 ell
        /// </summary>
        public static double Meter_2_Ell(double inVal)                                  => inVal / 1.143;

        /// <summary>
        /// ft -> m
        /// 1 foot (US survey) [ft] to vv: 0.3048006096 meter [m]
        /// </summary>
        public static double FootUSSurvey_2_Meter(double inVal)                         => inVal * 0.3048006096;
        /// <summary>
        /// m -> ft
        /// vv: 0.3048006096 meter [m] to 1 foot (US survey) [ft]
        /// </summary>
        public static double Meter_2_FootUSSurvey(double inVal)                         => inVal / 0.3048006096;

        /// <summary>
        /// li -> m
        /// 1 link [li] to vv: 0.201168 meter [m]
        /// </summary>
        public static double Link_2_Meter(double inVal)                                 => inVal * 0.201168;
        /// <summary>
        /// m -> li
        /// vv: 0.201168 meter [m] to 1 link [li]
        /// </summary>
        public static double Meter_2_Link(double inVal)                                 => inVal / 0.201168;

        /// <summary>
        /// li -> m
        /// 1 link (US survey) [li] to vv: 0.2011684023 meter [m]
        /// </summary>
        public static double LinkUSSurvey_2_Meter(double inVal)                         => inVal * 0.2011684023;
        /// <summary>
        /// m -> li
        /// vv: 0.2011684023 meter [m] to 1 link (US survey) [li]
        /// </summary>
        public static double Meter_2_LinkUSSurvey(double inVal)                         => inVal / 0.2011684023;

        /// <summary>
        /// CubitUK -> m
        /// 1 cubit (UK) to vv: 0.4572 meter [m]
        /// </summary>
        public static double CubitUK_2_Meter(double inVal)                              => inVal * 0.4572;
        /// <summary>
        /// m -> CubitUK
        /// vv: 0.4572 meter [m] to 1 cubit (UK)
        /// </summary>
        public static double Meter_2_CubitUK(double inVal)                              => inVal / 0.4572;

        /// <summary>
        /// Hand -> m
        /// 1 hand to vv: 0.1016 meter [m]
        /// </summary>
        public static double Hand_2_Meter(double inVal)                                 => inVal * 0.1016;
        /// <summary>
        /// m -> Hand
        /// vv: 0.1016 meter [m] to 1 hand
        /// </summary>
        public static double Meter_2_Hand(double inVal)                                 => inVal / 0.1016;

        /// <summary>
        /// SpanCloth -> m
        /// 1 span (cloth) to vv: 0.2286 meter [m]
        /// </summary>
        public static double SpanCloth_2_Meter(double inVal)                            => inVal * 0.2286;
        /// <summary>
        /// m -> SpanCloth
        /// vv: 0.2286 meter [m] to 1 span (cloth)
        /// </summary>
        public static double Meter_2_SpanCloth(double inVal)                            => inVal / 0.2286;

        /// <summary>
        /// FingerCloth -> m
        /// 1 finger (cloth) to vv: 0.1143 meter [m]
        /// </summary>
        public static double FingerCloth_2_Meter(double inVal)                          => inVal * 0.1143;
        /// <summary>
        /// m -> FingerCloth
        /// vv: 0.1143 meter [m] to 1 finger (cloth)
        /// </summary>
        public static double Meter_2_FingerCloth(double inVal)                          => inVal / 0.1143;

        /// <summary>
        /// NailCloth -> m
        /// 1 nail (cloth) to vv: 0.05715 meter [m]
        /// </summary>
        public static double NailCloth_2_Meter(double inVal)                            => inVal * 0.05715;
        /// <summary>
        /// m -> NailCloth
        /// vv: 0.05715 meter [m] to 1 nail (cloth)
        /// </summary>
        public static double Meter_2_NailCloth(double inVal)                            => inVal / 0.05715;

        /// <summary>
        /// in -> m
        /// 1 inch (US survey) [in] to vv: 0.0254000508 meter [m]
        /// </summary>
        public static double InchUSSurvey_2_Meter(double inVal)                         => inVal * 0.0254000508;
        /// <summary>
        /// m -> in
        /// vv: 0.0254000508 meter [m] to 1 inch (US survey) [in]
        /// </summary>
        public static double Meter_2_InchUSSurvey(double inVal)                         => inVal / 0.0254000508;

        /// <summary>
        /// Barleycorn -> m
        /// 1 barleycorn to vv: 0.0084666667 meter [m]
        /// </summary>
        public static double Barleycorn_2_Meter(double inVal)                           => inVal * 0.0084666667;
        /// <summary>
        /// m -> Barleycorn
        /// vv: 0.0084666667 meter [m] to 1 barleycorn
        /// </summary>
        public static double Meter_2_Barleycorn(double inVal)                           => inVal / 0.0084666667;

        /// <summary>
        /// mil, thou -> m
        /// 1 mil [mil, thou] to vv: 2.54E-5 meter [m]
        /// </summary>
        public static double Mil_2_Meter(double inVal)                                  => inVal * 2.54E-5;
        /// <summary>
        /// m -> mil, thou
        /// vv: 2.54E-5 meter [m] to 1 mil [mil, thou]
        /// </summary>
        public static double Meter_2_Mil(double inVal)                                  => inVal / 2.54E-5;

        /// <summary>
        /// Microinch -> m
        /// 1 microinch to vv: 2.54E-8 meter [m]
        /// </summary>
        public static double Microinch_2_Meter(double inVal)                            => inVal * 2.54E-8;
        /// <summary>
        /// m -> Microinch
        /// vv: 2.54E-8 meter [m] to 1 microinch
        /// </summary>
        public static double Meter_2_Microinch(double inVal)                            => inVal / 2.54E-8;

        /// <summary>
        /// A -> m
        /// 1 angstrom [A] to vv: 1.0E-10 meter [m]
        /// </summary>
        public static double Angstrom_2_Meter(double inVal)                             => inVal * 1.0E-10;
        /// <summary>
        /// m -> A
        /// vv: 1.0E-10 meter [m] to 1 angstrom [A]
        /// </summary>
        public static double Meter_2_Angstrom(double inVal)                             => inVal / 1.0E-10;

        /// <summary>
        /// a.u., b -> m
        /// 1 a.u. of length [a.u., b] to vv: 5.2917724900001E-11 meter [m]
        /// </summary>
//TODO        public static double A.u.OfLength_2_Meter(double inVal)                         => inVal * 5.2917724900001E-11;
        /// <summary>
        /// m -> a.u., b
        /// vv: 5.2917724900001E-11 meter [m] to 1 a.u. of length [a.u., b]
        /// </summary>
//TODO        public static double Meter_2_A.u.OfLength(double inVal)                         => inVal / 5.2917724900001E-11;

        /// <summary>
        /// X -> m
        /// 1 X-unit [X] to vv: 1.00208E-13 meter [m]
        /// </summary>
        public static double XUnit_2_Meter(double inVal)                                => inVal * 1.00208E-13;
        /// <summary>
        /// m -> X
        /// vv: 1.00208E-13 meter [m] to 1 X-unit [X]
        /// </summary>
        public static double Meter_2_XUnit(double inVal)                                => inVal / 1.00208E-13;

        /// <summary>
        /// F, f -> m
        /// 1 fermi [F, f] to vv: 1.0E-15 meter [m]
        /// </summary>
        public static double Fermi_2_Meter(double inVal)                                => inVal * 1.0E-15;
        /// <summary>
        /// m -> F, f
        /// vv: 1.0E-15 meter [m] to 1 fermi [F, f]
        /// </summary>
        public static double Meter_2_Fermi(double inVal)                                => inVal / 1.0E-15;

        /// <summary>
        /// Arpent -> m
        /// 1 arpent to vv: 58.5216 meter [m]
        /// </summary>
        public static double Arpent_2_Meter(double inVal)                               => inVal * 58.5216;
        /// <summary>
        /// m -> Arpent
        /// vv: 58.5216 meter [m] to 1 arpent
        /// </summary>
        public static double Meter_2_Arpent(double inVal)                               => inVal / 58.5216;

        /// <summary>
        /// Pica -> m
        /// 1 pica to vv: 0.0042333333 meter [m]
        /// </summary>
        public static double Pica_2_Meter(double inVal)                                 => inVal * 0.0042333333;
        /// <summary>
        /// m -> Pica
        /// vv: 0.0042333333 meter [m] to 1 pica
        /// </summary>
        public static double Meter_2_Pica(double inVal)                                 => inVal / 0.0042333333;

        /// <summary>
        /// Point -> m
        /// 1 point to vv: 0.0003527778 meter [m]
        /// </summary>
        public static double Point_2_Meter(double inVal)                                => inVal * 0.0003527778;
        /// <summary>
        /// m -> Point
        /// vv: 0.0003527778 meter [m] to 1 point
        /// </summary>
        public static double Meter_2_Point(double inVal)                                => inVal / 0.0003527778;

        /// <summary>
        /// Aln -> m
        /// 1 aln to vv: 0.5937777778 meter [m]
        /// </summary>
        public static double Aln_2_Meter(double inVal)                                  => inVal * 0.5937777778;
        /// <summary>
        /// m -> Aln
        /// vv: 0.5937777778 meter [m] to 1 aln
        /// </summary>
        public static double Meter_2_Aln(double inVal)                                  => inVal / 0.5937777778;

        /// <summary>
        /// Famn -> m
        /// 1 famn to vv: 1.7813333333 meter [m]
        /// </summary>
        public static double Famn_2_Meter(double inVal)                                 => inVal * 1.7813333333;
        /// <summary>
        /// m -> Famn
        /// vv: 1.7813333333 meter [m] to 1 famn
        /// </summary>
        public static double Meter_2_Famn(double inVal)                                 => inVal / 1.7813333333;

        /// <summary>
        /// cl -> m
        /// 1 caliber [cl] to vv: 0.000254 meter [m]
        /// </summary>
        public static double Caliber_2_Meter(double inVal)                              => inVal * 0.000254;
        /// <summary>
        /// m -> cl
        /// vv: 0.000254 meter [m] to 1 caliber [cl]
        /// </summary>
        public static double Meter_2_Caliber(double inVal)                              => inVal / 0.000254;

        /// <summary>
        /// cin -> m
        /// 1 centiinch [cin] to vv: 0.000254 meter [m]
        /// </summary>
        public static double Centiinch_2_Meter(double inVal)                            => inVal * 0.000254;
        /// <summary>
        /// m -> cin
        /// vv: 0.000254 meter [m] to 1 centiinch [cin]
        /// </summary>
        public static double Meter_2_Centiinch(double inVal)                            => inVal / 0.000254;

        /// <summary>
        /// Ken -> m
        /// 1 ken to vv: 2.11836 meter [m]
        /// </summary>
        public static double Ken_2_Meter(double inVal)                                  => inVal * 2.11836;
        /// <summary>
        /// m -> Ken
        /// vv: 2.11836 meter [m] to 1 ken
        /// </summary>
        public static double Meter_2_Ken(double inVal)                                  => inVal / 2.11836;

        /// <summary>
        /// RussianArchin -> m
        /// 1 Russian archin to vv: 0.7112 meter [m]
        /// </summary>
        public static double RussianArchin_2_Meter(double inVal)                        => inVal * 0.7112;
        /// <summary>
        /// m -> RussianArchin
        /// vv: 0.7112 meter [m] to 1 Russian archin
        /// </summary>
        public static double Meter_2_RussianArchin(double inVal)                        => inVal / 0.7112;

        /// <summary>
        /// RomanActus -> m
        /// 1 Roman actus to vv: 35.47872 meter [m]
        /// </summary>
        public static double RomanActus_2_Meter(double inVal)                           => inVal * 35.47872;
        /// <summary>
        /// m -> RomanActus
        /// vv: 35.47872 meter [m] to 1 Roman actus
        /// </summary>
        public static double Meter_2_RomanActus(double inVal)                           => inVal / 35.47872;

        /// <summary>
        /// VaraDeTarea -> m
        /// 1 vara de tarea to vv: 2.505456 meter [m]
        /// </summary>
        public static double VaraDeTarea_2_Meter(double inVal)                          => inVal * 2.505456;
        /// <summary>
        /// m -> VaraDeTarea
        /// vv: 2.505456 meter [m] to 1 vara de tarea
        /// </summary>
        public static double Meter_2_VaraDeTarea(double inVal)                          => inVal / 2.505456;

        /// <summary>
        /// VaraConuquera -> m
        /// 1 vara conuquera to vv: 2.505456 meter [m]
        /// </summary>
        public static double VaraConuquera_2_Meter(double inVal)                        => inVal * 2.505456;
        /// <summary>
        /// m -> VaraConuquera
        /// vv: 2.505456 meter [m] to 1 vara conuquera
        /// </summary>
        public static double Meter_2_VaraConuquera(double inVal)                        => inVal / 2.505456;

        /// <summary>
        /// VaraCastellana -> m
        /// 1 vara castellana to vv: 0.835152 meter [m]
        /// </summary>
        public static double VaraCastellana_2_Meter(double inVal)                       => inVal * 0.835152;
        /// <summary>
        /// m -> VaraCastellana
        /// vv: 0.835152 meter [m] to 1 vara castellana
        /// </summary>
        public static double Meter_2_VaraCastellana(double inVal)                       => inVal / 0.835152;

        /// <summary>
        /// CubitGreek -> m
        /// 1 cubit (Greek) to vv: 0.462788 meter [m]
        /// </summary>
        public static double CubitGreek_2_Meter(double inVal)                           => inVal * 0.462788;
        /// <summary>
        /// m -> CubitGreek
        /// vv: 0.462788 meter [m] to 1 cubit (Greek)
        /// </summary>
        public static double Meter_2_CubitGreek(double inVal)                           => inVal / 0.462788;

        /// <summary>
        /// LongReed -> m
        /// 1 long reed to vv: 3.2004 meter [m]
        /// </summary>
        public static double LongReed_2_Meter(double inVal)                             => inVal * 3.2004;
        /// <summary>
        /// m -> LongReed
        /// vv: 3.2004 meter [m] to 1 long reed
        /// </summary>
        public static double Meter_2_LongReed(double inVal)                             => inVal / 3.2004;

        /// <summary>
        /// Reed -> m
        /// 1 reed to vv: 2.7432 meter [m]
        /// </summary>
        public static double Reed_2_Meter(double inVal)                                 => inVal * 2.7432;
        /// <summary>
        /// m -> Reed
        /// vv: 2.7432 meter [m] to 1 reed
        /// </summary>
        public static double Meter_2_Reed(double inVal)                                 => inVal / 2.7432;

        /// <summary>
        /// LongCubit -> m
        /// 1 long cubit to vv: 0.5334 meter [m]
        /// </summary>
        public static double LongCubit_2_Meter(double inVal)                            => inVal * 0.5334;
        /// <summary>
        /// m -> LongCubit
        /// vv: 0.5334 meter [m] to 1 long cubit
        /// </summary>
        public static double Meter_2_LongCubit(double inVal)                            => inVal / 0.5334;

        /// <summary>
        /// Handbreadth -> m
        /// 1 handbreadth to vv: 0.0762 meter [m]
        /// </summary>
        public static double Handbreadth_2_Meter(double inVal)                          => inVal * 0.0762;
        /// <summary>
        /// m -> Handbreadth
        /// vv: 0.0762 meter [m] to 1 handbreadth
        /// </summary>
        public static double Meter_2_Handbreadth(double inVal)                          => inVal / 0.0762;

        /// <summary>
        /// Fingerbreadth -> m
        /// 1 fingerbreadth to vv: 0.01905 meter [m]
        /// </summary>
        public static double Fingerbreadth_2_Meter(double inVal)                        => inVal * 0.01905;
        /// <summary>
        /// m -> Fingerbreadth
        /// vv: 0.01905 meter [m] to 1 fingerbreadth
        /// </summary>
        public static double Meter_2_Fingerbreadth(double inVal)                        => inVal / 0.01905;

        /// <summary>
        /// PlanckLength -> m
        /// 1 Planck length to vv: 1.61605E-35 meter [m]
        /// </summary>
        public static double PlanckLength_2_Meter(double inVal)                         => inVal * 1.61605E-35;
        /// <summary>
        /// m -> PlanckLength
        /// vv: 1.61605E-35 meter [m] to 1 Planck length
        /// </summary>
        public static double Meter_2_PlanckLength(double inVal)                         => inVal / 1.61605E-35;

        /// <summary>
        /// ElectronRadiusClassical -> m
        /// 1 Electron radius (classical) to vv: 2.81794092E-15 meter [m]
        /// </summary>
        public static double ElectronRadiusClassical_2_Meter(double inVal)              => inVal * 2.81794092E-15;
        /// <summary>
        /// m -> ElectronRadiusClassical
        /// vv: 2.81794092E-15 meter [m] to 1 Electron radius (classical)
        /// </summary>
        public static double Meter_2_ElectronRadiusClassical(double inVal)              => inVal / 2.81794092E-15;

        /// <summary>
        /// b, a.u. -> m
        /// 1 Bohr radius [b, a.u.] to vv: 5.2917724900001E-11 meter [m]
        /// </summary>
        public static double BohrRadius_2_Meter(double inVal)                           => inVal * 5.2917724900001E-11;
        /// <summary>
        /// m -> b, a.u.
        /// vv: 5.2917724900001E-11 meter [m] to 1 Bohr radius [b, a.u.]
        /// </summary>
        public static double Meter_2_BohrRadius(double inVal)                           => inVal / 5.2917724900001E-11;

        /// <summary>
        /// EarthEquatorialRadius -> m
        /// 1 Earth's equatorial radius to vv: 6378160 meter [m]
        /// </summary>
        public static double EarthEquatorialRadius_2_Meter(double inVal)                => inVal * 6378160;
        /// <summary>
        /// m -> EarthEquatorialRadius
        /// vv: 6378160 meter [m] to 1 Earth's equatorial radius
        /// </summary>
        public static double Meter_2_EarthEquatorialRadius(double inVal)                => inVal / 6378160;

        /// <summary>
        /// EarthPolarRadius -> m
        /// 1 Earth's polar radius to vv: 6356776.9999999 meter [m]
        /// </summary>
        public static double EarthPolarRadius_2_Meter(double inVal)                     => inVal * 6356776.9999999;
        /// <summary>
        /// m -> EarthPolarRadius
        /// vv: 6356776.9999999 meter [m] to 1 Earth's polar radius
        /// </summary>
        public static double Meter_2_EarthPolarRadius(double inVal)                     => inVal / 6356776.9999999;

        /// <summary>
        /// EarthDistanceFromSun -> m
        /// 1 Earth's distance from sun to vv: 149600000000 meter [m]
        /// </summary>
        public static double EarthDistanceFromSun_2_Meter(double inVal)                 => inVal * 149600000000;
        /// <summary>
        /// m -> EarthDistanceFromSun
        /// vv: 149600000000 meter [m] to 1 Earth's distance from sun
        /// </summary>
        public static double Meter_2_EarthDistanceFromSun(double inVal)                 => inVal / 149600000000;

        /// <summary>
        /// SunRadius -> m
        /// 1 Sun's radius to vv: 696000000 meter [m]
        /// </summary>
        public static double SunRadius_2_Meter(double inVal)                            => inVal * 696000000;
        /// <summary>
        /// m -> SunRadius
        /// vv: 696000000 meter [m] to 1 Sun's radius
        /// </summary>
        public static double Meter_2_SunRadius(double inVal)                            => inVal / 696000000;

        #endregion
    }
}
