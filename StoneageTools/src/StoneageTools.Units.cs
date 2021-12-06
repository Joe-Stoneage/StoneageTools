
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static class StoneageToolsUnits
    {
        #region pressure
        public static double PSI_2_Pa(double inVal)     => inVal * 6894.7572932;            // Pascal
        public static double PSI_2_APa(double inVal)    => inVal * 6.8947572938895E+21;     // attopascals
        public static double PSI_2_KGF(double inVal)    => inVal * 0.45359350099669;        // kilogram force
        public static double PSI_2_ATM(double inVal)    => inVal * 0.06804596391019;        // atmosphere
        public static double PSI_2_AT(double inVal)     => inVal * 0.070306957964239;       // atmosphere techical
        public static double PSI_2_mmHg(double inVal)   => inVal * 51.715075480416;         // millimeter of mercury
        public static double PSI_2_BAR(double inVal)    => inVal * 0.068947572932;          // bars
        public static double PSI_2_TORR(double inVal)   => inVal * 51.714932572153;         // torrs
        public static double PSI_2_ksi(double inVal)    => inVal * 0.001;                   // ksi
        public static double Kgf_2_BAR(double inVal)    => inVal / 1.0197;
        public static double BAR_2_Pa(double inVal)     => inVal * 1000;
        public static double BAR_2_KPa(double inVal)    => inVal * 100;
        public static double BAR_2_ATM(double inVal)    => inVal / 1.01325;
        public static double KPa_2_BAR(double inVal)    => inVal / 100;
        #endregion

        #region length
        public static double Mile_2_Kilometer(double inVal)     => inVal * 1.609344;
        public static double Kilometer_2_Mile(double inVal)     => inVal / 1.609344;
        public static double MegaParsec_2_Meter(double inVal)   => inVal * 3.08567758128E+22;
        public static double Meter_2_MegaParsec(double inVal)   => inVal / 3.08567758128E+22;
        public static double KiloParsec_2_Meter(double inVal)   => inVal * 3.08567758128E+19;
        public static double Meter_2_KiloParsec(double inVal)   => inVal / 3.08567758128E+19;
        public static double Parsec_2_Meter(double inVal)       => inVal * 3.08567758128E+16;
        public static double Meter_2_Parsec(double inVal)       => inVal / 3.08567758128E+16;
        public static double Lightyear_2_Meter(double inVal)    => inVal * 9.46073047258E+15;
        public static double Meter_2_Lightyear(double inVal)    => inVal / 9.46073047258E+15;
        public static double AstronomicalUnit_2_Meter(double inVal) => inVal * 149597870691;
        public static double Meter_2_AstronomicalUnit(double inVal) => inVal / 149597870691;
        public static double Mile_2_Meter(double inVal)         => inVal * 1609.344;
        public static double Meter_2_Mile(double inVal)         => inVal / 1609.344;
        public static double NauticUKMile_2_Meter(double inVal) => inVal * 1853.184;
        public static double Meter_2_NauticUKMile(double inVal) => inVal / 1853.184;
        public static double NauticIntMile_2_Meter(double inVal)    => inVal * 1852;
        public static double Meter_2_NauticIntMile(double inVal)    => inVal / 1852;
        public static double Yard_2_Meter(double inVal)         => inVal * 0.9144;
        public static double Meter_2_Yard(double inVal)         => inVal / 0.9144;
        public static double Food_2_Meter(double inVal)         => inVal * 0.3048;
        public static double Meter_2_Food(double inVal)         => inVal / 0.3048;
        public static double Inch_2_Meter(double inVal)         => inVal * 0.0254;
        public static double Meter_2_Inch(double inVal)         => inVal / 0.0254;
        public static double Kilometer_2_Meter(double inVal)    => inVal * 1000;
        public static double Meter_2_Kilometer(double inVal)    => inVal / 1000;
        public static double Decimeter_2_Meter(double inVal)    => inVal * 0.1;
        public static double Meter_2_Decimeter(double inVal)    => inVal / 0.1;
        public static double Centimeter_2_Meter(double inVal)   => inVal * 0.01;
        public static double Meter_2_Centimeter(double inVal)   => inVal / 0.01;
        public static double Millimeter_2_Meter(double inVal)   => inVal * 0.001;
        public static double Meter_2_Millimeter(double inVal)   => inVal / 0.001;
        public static double Micrometer_2_Meter(double inVal)   => inVal * 1.0E-6;
        public static double Meter_2_Micrometer(double inVal)   => inVal / 1.0E-6;
        public static double Nanometer_2_Meter(double inVal)   => inVal * 1.0E-9;
        public static double Meter_2_Nanometer(double inVal)   => inVal / 1.0E-9;
        public static double EarthEquatorialRadius_2_Meter(double inVal)    => inVal * 6378160;
        public static double Meter_2_EarthEquatorialRadius(double inVal)    => inVal / 6378160;
        public static double EarthPolarRadius_2_Meter(double inVal)         => inVal * 6356776.9999999;
        public static double Meter_2_EarthPolarRadius(double inVal)         => inVal / 6356776.9999999;
        public static double EarthDistanceFromSun_2_Meter(double inVal)     => inVal * 149600000000;
        public static double Meter_2_EarthDistanceFromSun(double inVal)     => inVal / 149600000000;
        public static double SunRadius_2_Meter(double inVal)        => inVal * 696000000;
        public static double Meter_2_SunRadius(double inVal)        => inVal / 696000000;

/* 
        yes, there is more on distances...
        1 exameter [Em] = 1.0E+18 meter [m]
        exameter to meter,   meter to exameter
        1 petameter [Pm] = 1.0E+15 meter [m]
        petameter to meter,   meter to petameter
        1 terameter [Tm] = 1000000000000 meter [m]
        terameter to meter,   meter to terameter
        1 gigameter [Gm] = 1000000000 meter [m]
        gigameter to meter,   meter to gigameter
        1 megameter [Mm] = 1000000 meter [m]
        megameter to meter,   meter to megameter
        1 hectometer [hm] = 100 meter [m]
        hectometer to meter,   meter to hectometer
        1 dekameter [dam] = 10 meter [m]
        dekameter to meter,   meter to dekameter
        1 micron [µ] = 1.0E-6 meter [m]
        micron to meter,   meter to micron
        1 picometer [pm] = 1.0E-12 meter [m]
        picometer to meter,   meter to picometer
        1 femtometer [fm] = 1.0E-15 meter [m]
        femtometer to meter,   meter to femtometer
        1 attometer [am] = 1.0E-18 meter [m]
        attometer to meter,   meter to attometer
        1 league [lea] = 4828.032 meter [m]
        league to meter,   meter to league
        1 nautical league (UK) = 5559.552 meter [m]
        nautical league (UK) to meter,   meter to nautical league (UK)
        1 nautical league (int.) = 5556 meter [m]
        nautical league (int.) to meter,   meter to nautical league (int.)
        1 league (statute) [st.league] = 4828.0416560833 meter [m]
        league (statute) to meter,   meter to league (statute)
        1 mile (statute) [mi, mi (US)] = 1609.3472186944 meter [m]
        mile (statute) to meter,   meter to mile (statute)
        1 mile (US survey) [mi] = 1609.3472186944 meter [m]
        mile (US survey) to meter,   meter to mile (US survey)
        1 mile (Roman) = 1479.804 meter [m]
        mile (Roman) to meter,   meter to mile (Roman)
        1 kiloyard [kyd] = 914.4 meter [m]
        kiloyard to meter,   meter to kiloyard
        1 furlong [fur] = 201.168 meter [m]
        furlong to meter,   meter to furlong
        1 furlong (US survey) [fur] = 201.1684023368 meter [m]
        furlong (US survey) to meter,   meter to furlong (US survey)
        1 chain [ch] = 20.1168 meter [m]
        chain to meter,   meter to chain
        1 chain (US survey) [ch] = 20.1168402337 meter [m]
        chain (US survey) to meter,   meter to chain (US survey)
        1 rope = 6.096 meter [m]
        rope to meter,   meter to rope
        1 rod [rd] = 5.0292 meter [m]
        rod to meter,   meter to rod
        1 rod (US survey) [rd] = 5.0292100584 meter [m]
        rod (US survey) to meter,   meter to rod (US survey)
        1 perch = 5.0292 meter [m]
        perch to meter,   meter to perch
        1 pole = 5.0292 meter [m]
        pole to meter,   meter to pole
        1 fathom [fath] = 1.8288 meter [m]
        fathom to meter,   meter to fathom
        1 fathom (US survey) [fath] = 1.8288036576 meter [m]
        fathom (US survey) to meter,   meter to fathom (US survey)
        1 ell = 1.143 meter [m]
        ell to meter,   meter to ell
        1 foot (US survey) [ft] = 0.3048006096 meter [m]
        foot (US survey) to meter,   meter to foot (US survey)
        1 link [li] = 0.201168 meter [m]
        link to meter,   meter to link
        1 link (US survey) [li] = 0.2011684023 meter [m]
        link (US survey) to meter,   meter to link (US survey)
        1 cubit (UK) = 0.4572 meter [m]
        cubit (UK) to meter,   meter to cubit (UK)
        1 hand = 0.1016 meter [m]
        hand to meter,   meter to hand
        1 span (cloth) = 0.2286 meter [m]
        span (cloth) to meter,   meter to span (cloth)
        1 finger (cloth) = 0.1143 meter [m]
        finger (cloth) to meter,   meter to finger (cloth)
        1 nail (cloth) = 0.05715 meter [m]
        nail (cloth) to meter,   meter to nail (cloth)
        1 inch (US survey) [in] = 0.0254000508 meter [m]
        inch (US survey) to meter,   meter to inch (US survey)
        1 barleycorn = 0.0084666667 meter [m]
        barleycorn to meter,   meter to barleycorn
        1 mil [mil, thou] = 2.54E-5 meter [m]
        mil to meter,   meter to mil
        1 microinch = 2.54E-8 meter [m]
        microinch to meter,   meter to microinch
        1 angstrom [A] = 1.0E-10 meter [m]
        angstrom to meter,   meter to angstrom
        1 a.u. of length [a.u., b] = 5.2917724900001E-11 meter [m]
        a.u. of length to meter,   meter to a.u. of length
        1 X-unit [X] = 1.00208E-13 meter [m]
        X-unit to meter,   meter to X-unit
        1 fermi [F, f] = 1.0E-15 meter [m]
        fermi to meter,   meter to fermi
        1 arpent = 58.5216 meter [m]
        arpent to meter,   meter to arpent
        1 pica = 0.0042333333 meter [m]
        pica to meter,   meter to pica
        1 point = 0.0003527778 meter [m]
        point to meter,   meter to point
        1 twip = 1.76389E-5 meter [m]
        twip to meter,   meter to twip
        1 aln = 0.5937777778 meter [m]
        aln to meter,   meter to aln
        1 famn = 1.7813333333 meter [m]
        famn to meter,   meter to famn
        1 caliber [cl] = 0.000254 meter [m]
        caliber to meter,   meter to caliber
        1 centiinch [cin] = 0.000254 meter [m]
        centiinch to meter,   meter to centiinch
        1 ken = 2.11836 meter [m]
        ken to meter,   meter to ken
        1 Russian archin = 0.7112 meter [m]
        Russian archin to meter,   meter to Russian archin
        1 Roman actus = 35.47872 meter [m]
        Roman actus to meter,   meter to Roman actus
        1 vara de tarea = 2.505456 meter [m]
        vara de tarea to meter,   meter to vara de tarea
        1 vara conuquera = 2.505456 meter [m]
        vara conuquera to meter,   meter to vara conuquera
        1 vara castellana = 0.835152 meter [m]
        vara castellana to meter,   meter to vara castellana
        1 cubit (Greek) = 0.462788 meter [m]
        cubit (Greek) to meter,   meter to cubit (Greek)
        1 long reed = 3.2004 meter [m]
        long reed to meter,   meter to long reed
        1 reed = 2.7432 meter [m]
        reed to meter,   meter to reed
        1 long cubit = 0.5334 meter [m]
        long cubit to meter,   meter to long cubit
        1 handbreadth = 0.0762 meter [m]
        handbreadth to meter,   meter to handbreadth
        1 fingerbreadth = 0.01905 meter [m]
        fingerbreadth to meter,   meter to fingerbreadth
        1 Planck length = 1.61605E-35 meter [m]
        Planck length to meter,   meter to Planck length
        1 Electron radius (classical) = 2.81794092E-15 meter [m]
        Electron radius (classical) to meter,   meter to Electron radius (classical)
        1 Bohr radius [b, a.u.] = 5.2917724900001E-11 meter [m]
        Bohr radius to meter,   meter to Bohr radius
        */
        #endregion

        #region temperature
        public static double Celsius_2_Kelvin(double inVal)     => inVal+273.15;
        public static double Kelvin_2_Celsius(double inVal)     => inVal-273.15;
        public static double Celsius_2_Fahrenheit(double inVal) => inVal*(9/5)+32;
        public static double Fahrenheit_2_Celsius(double inVal) => (inVal-32)*5/9;
        public static double Kelvin_2_Fahrenheit(double inVal)  => (inVal-273.15)*(9/5)+32;
        public static double Fahrenheit_2_Kelvin(double inVal)  => (inVal-32)*(5/9)+273.15;
        public static double Rankine_2_Fahrenheit(double inVal) => inVal+459.67;
        public static double Fahrenheit_2_Rankine(double inVal) => inVal-459.67;
        #endregion

        #region weight
        public static double Gram_2_Kilogram(double inVal)      => inVal * 0.001;
        public static double Kilogram_2_Gram(double inVal)      => inVal / 0.001;
        public static double Gram_2_Milligram(double inVal)     => inVal * 1000;
        public static double Milligram_2_Gram(double inVal)     => inVal / 1000;
        public static double Milligram_2_Kilogram(double inVal) => inVal * 1.0E-6;
        public static double Kilogram_2_Milligram(double inVal) => inVal / 1.0E-6;
        public static double Ton_2_Kilogram(double inVal)       => inVal * 1000;
        public static double Kilogram_2_Ton(double inVal)       => inVal / 1000;
        public static double TonShortUS_2_Kilogram(double inVal)    => inVal * 907.18474;
        public static double Kilogram_2_TonShortUs(double inVal)    => inVal / 907.18474;
        public static double TonLongUK_2_Kilogram(double inVal) => inVal * 1016.0469088;
        public static double Kilogram_2_TonLongUK(double inVal) => inVal / 1016.0469088;
        public static double Pound_2_Kilogram(double inVal)     => inVal * 0.45359237;
        public static double Kilogram_2_Pound(double inVal)     => inVal / 0.45359237;
        public static double Ounce_2_Kilogram(double inVal)     => inVal * 0.0283495231;
        public static double Kilogram_2_Ounce(double inVal)     => inVal / 0.0283495231;
        public static double Carat_2_Kilogram(double inVal)     => inVal * 0.0002;
        public static double Kilogram_2_Carat(double inVal)     => inVal / 0.0002;
        public static double TalentHebrew_2_Kilogram(double inVal)  => inVal * 34.2;
        public static double Kilogram_2_TalentHebrew(double inVal)  => inVal / 34.2;
        public static double MinaHebrew_2_Kilogram(double inVal)    => inVal * 0.57;
        public static double Kilogram_2_MinaHebrew(double inVal)    => inVal / 0.57;
        public static double ShekelHebrew_2_Kilogram(double inVal)  => inVal * 0.0114;
        public static double Kilogram_2_ShekelHebrew(double inVal)  => inVal / 0.0114;
        public static double BenanHebrew_2_Kilogram(double inVal)   => inVal * 0.0057;
        public static double Kilogram_2_BenanHebrew(double inVal)   => inVal / 0.0057;
        public static double GerahHebrew_2_Kilogram(double inVal)   => inVal * 0.00057;
        public static double Kilogram_2_GerahHebrew(double inVal)   => inVal / 0.00057;
        public static double TalentGreek_2_Kilogram(double inVal)   => inVal * 20.4;
        public static double Kilogram_2_TalentGreek(double inVal)   => inVal / 20.4;
        public static double MinaGreek_2_Kilogram(double inVal)     => inVal * 0.34;
        public static double Kilogram_2_MinaGreek(double inVal)     => inVal / 0.34;
        public static double TetraDrachmaGreek_2_Kilogram(double inVal) => inVal * 0.0136;
        public static double Kilogram_2_TetraDrachmaGreek(double inVal) => inVal / 0.0136;
        public static double DiDrachmaGreek_2_Kilogram(double inVal)    => inVal * 0.0068;
        public static double Kilogram_2_DiDrachmaGreek(double inVal)    => inVal / 0.0068;
        public static double DrachmaGreek_2_Kilogram(double inVal)  => inVal * 0.0034;
        public static double Kilogram_2_DrachmaGreek(double inVal)  => inVal / 0.0034;
        public static double DenariusRoman_2_Kilogram(double inVal) => inVal * 0.00385;
        public static double Kilogram_2_DenariusRoman(double inVal) => inVal / 0.00385;
        public static double AssarionRoman_2_Kilogram(double inVal) => inVal * 0.000240625;
        public static double Kilogram_2_AssarionRoman(double inVal) => inVal / 0.000240625;
        public static double QuadransRoman_2_Kilogram(double inVal) => inVal * 6.01563E-5;
        public static double Kilogram_2_QuadransRoman(double inVal) => inVal / 6.01563E-5;
        public static double LeptonRoman_2_Kilogram(double inVal)   => inVal * 3.00781E-5;
        public static double Kilogram_2_LeptonRoman(double inVal)   => inVal / 3.00781E-5;
        public static double AtomicMass_2_Kilogram(double inVal)    => inVal * 1.6605402E-27;
        public static double Kilogram_2_AtomicMass(double inVal)    => inVal / 1.6605402E-27;
        public static double PlanckMass_2_Kilogram(double inVal)    => inVal * 2.17671E-8;
        public static double Kilogram_2_PlanckMass(double inVal)    => inVal / 2.17671E-8;
        public static double ElectronMass_2_Kilogram(double inVal)  => inVal * 9.1093897E-31;
        public static double Kilogram_2_ElectronMass(double inVal)  => inVal / 9.1093897E-31;
        public static double MuonMass_2_Kilogram(double inVal)      => inVal * 1.8835327E-28;
        public static double Kilogram_2_MuonMass(double inVal)      => inVal / 1.8835327E-28;
        public static double ProtonMass_2_Kilogram(double inVal)    => inVal * 1.6726231E-27;
        public static double Kilogram_2_ProtonMass(double inVal)    => inVal / 1.6726231E-27;
        public static double NeutronMass_2_Kilogram(double inVal)   => inVal * 1.6749286E-27;
        public static double Kilogram_2_NeutronMass(double inVal)   => inVal / 1.6749286E-27;
        public static double DeutoronMass_2_Kilogram(double inVal)  => inVal * 3.343586E-27;
        public static double Kilogram_2_DeutoronMass(double inVal)  => inVal / 3.343586E-27;
        public static double EarthMass_2_Kilogram(double inVal)     => inVal * 5.9760000000002E+24;
        public static double Kilogram_2_EarthMass(double inVal)     => inVal / 5.9760000000002E+24;
        public static double SunMass_2_Kilogram(double inVal)       => inVal * 2.0E+30;
        public static double Kilogram_2_SunMass(double inVal)       => inVal / 2.0E+30;

        /* there are few more weights:
        1 exagram [Eg] = 1.0E+15 kilogram [kg]
        exagram to kilogram,   kilogram to exagram
        1 petagram [Pg] = 1000000000000 kilogram [kg]
        petagram to kilogram,   kilogram to petagram
        1 teragram [Tg] = 1000000000 kilogram [kg]
        teragram to kilogram,   kilogram to teragram
        1 gigagram [Gg] = 1000000 kilogram [kg]
        gigagram to kilogram,   kilogram to gigagram
        1 megagram [Mg] = 1000 kilogram [kg]
        megagram to kilogram,   kilogram to megagram
        1 hectogram [hg] = 0.1 kilogram [kg]
        hectogram to kilogram,   kilogram to hectogram
        1 dekagram [dag] = 0.01 kilogram [kg]
        dekagram to kilogram,   kilogram to dekagram
        1 decigram [dg] = 0.0001 kilogram [kg]
        decigram to kilogram,   kilogram to decigram
        1 centigram [cg] = 1.0E-5 kilogram [kg]
        centigram to kilogram,   kilogram to centigram
        1 microgram [µg] = 1.0E-9 kilogram [kg]
        microgram to kilogram,   kilogram to microgram
        1 nanogram [ng] = 1.0E-12 kilogram [kg]
        nanogram to kilogram,   kilogram to nanogram
        1 picogram [pg] = 1.0E-15 kilogram [kg]
        picogram to kilogram,   kilogram to picogram
        1 femtogram [fg] = 1.0E-18 kilogram [kg]
        femtogram to kilogram,   kilogram to femtogram
        1 attogram [ag] = 1.0E-21 kilogram [kg]
        attogram to kilogram,   kilogram to attogram
        1 dalton = 1.6605300000013E-27 kilogram [kg]
        dalton to kilogram,   kilogram to dalton
        1 kilogram-force square second/meter = 9.80665 kilogram [kg]
        kilogram-force square second/meter to kilogram,   kilogram to kilogram-force square second/meter
        1 kilopound [kip] = 453.59237 kilogram [kg]
        kilopound to kilogram,   kilogram to kilopound
        1 kip = 453.59237 kilogram [kg]
        kip to kilogram,   kilogram to kip
        1 slug = 14.5939029372 kilogram [kg]
        slug to kilogram,   kilogram to slug
        1 pound-force square second/foot = 14.5939029372 kilogram [kg]
        pound-force square second/foot to kilogram,   kilogram to pound-force square second/foot
        1 pound (troy or apothecary) = 0.3732417216 kilogram [kg]
        pound (troy or apothecary) to kilogram,   kilogram to pound (troy or apothecary)
        1 poundal [pdl] = 0.0140867196 kilogram [kg]
        poundal to kilogram,   kilogram to poundal
        1 ton (assay) (US) [AT (US)] = 0.02916667 kilogram [kg]
        ton (assay) (US) to kilogram,   kilogram to ton (assay) (US)
        1 ton (assay) (UK) [AT (UK)] = 0.0326666667 kilogram [kg]
        ton (assay) (UK) to kilogram,   kilogram to ton (assay) (UK)
        1 kiloton (metric) [kt] = 1000000 kilogram [kg]
        kiloton (metric) to kilogram,   kilogram to kiloton (metric)
        1 quintal (metric) [cwt] = 100 kilogram [kg]
        quintal (metric) to kilogram,   kilogram to quintal (metric)
        1 hundredweight (US) = 45.359237 kilogram [kg]
        hundredweight (US) to kilogram,   kilogram to hundredweight (US)
        1 hundredweight (UK) = 50.80234544 kilogram [kg]
        hundredweight (UK) to kilogram,   kilogram to hundredweight (UK)
        1 quarter (US) [qr (US)] = 11.33980925 kilogram [kg]
        quarter (US) to kilogram,   kilogram to quarter (US)
        1 quarter (UK) [qr (UK)] = 12.70058636 kilogram [kg]
        quarter (UK) to kilogram,   kilogram to quarter (UK)
        1 stone (US) = 5.669904625 kilogram [kg]
        stone (US) to kilogram,   kilogram to stone (US)
        1 stone (UK) = 6.35029318 kilogram [kg]
        stone (UK) to kilogram,   kilogram to stone (UK)
        1 tonne [t] = 1000 kilogram [kg]
        tonne to kilogram,   kilogram to tonne
        1 pennyweight [pwt] = 0.0015551738 kilogram [kg]
        pennyweight to kilogram,   kilogram to pennyweight
        1 scruple (apothecary) [s.ap] = 0.0012959782 kilogram [kg]
        scruple (apothecary) to kilogram,   kilogram to scruple (apothecary)
        1 grain [gr] = 6.47989E-5 kilogram [kg]
        grain to kilogram,   kilogram to grain
        1 gamma = 1.0E-9 kilogram [kg]
        gamma to kilogram,   kilogram to gamma

        */        
        #endregion
    }
}
