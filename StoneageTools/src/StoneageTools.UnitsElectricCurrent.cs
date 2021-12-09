
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region electric - current, base: ampere

        /// <summary>
        /// kA -> A
        /// 1 kiloampere [kA] =  1000 ampere [A]
        /// </summary>
        public static double Kiloampere_2_Ampere(double inVal)                          => inVal * 1000;
        /// <summary>
        /// A -> kA
        /// vv: 1000 ampere [A] to 1 kiloampere [kA]
        /// </summary>
        public static double Ampere_2_Kiloampere(double inVal)                          => inVal / 1000;

        /// <summary>
        /// mA -> A
        /// 1 milliampere [mA] =  0.001 ampere [A]
        /// </summary>
        public static double Milliampere_2_Ampere(double inVal)                         => inVal * 0.001;
        /// <summary>
        /// A -> mA
        /// vv: 0.001 ampere [A] to 1 milliampere [mA]
        /// </summary>
        public static double Ampere_2_Milliampere(double inVal)                         => inVal / 0.001;

        /// <summary>
        /// Bi -> A
        /// 1 biot [Bi] =  10 ampere [A]
        /// </summary>
        public static double Biot_2_Ampere(double inVal)                                => inVal * 10;
        /// <summary>
        /// A -> Bi
        /// vv: 10 ampere [A] to 1 biot [Bi]
        /// </summary>
        public static double Ampere_2_Biot(double inVal)                                => inVal / 10;

        /// <summary>
        /// abA -> A
        /// 1 abampere [abA] =  10 ampere [A]
        /// </summary>
        public static double Abampere_2_Ampere(double inVal)                            => inVal * 10;
        /// <summary>
        /// A -> abA
        /// vv: 10 ampere [A] to 1 abampere [abA]
        /// </summary>
        public static double Ampere_2_Abampere(double inVal)                            => inVal / 10;

        /// <summary>
        /// EMUOfCurrent -> A
        /// 1 EMU of current =  10 ampere [A]
        /// </summary>
        public static double EMUOfCurrent_2_Ampere(double inVal)                        => inVal * 10;
        /// <summary>
        /// A -> EMUOfCurrent
        /// vv: 10 ampere [A] to 1 EMU of current
        /// </summary>
        public static double Ampere_2_EMUOfCurrent(double inVal)                        => inVal / 10;

        /// <summary>
        /// stA -> A
        /// 1 statampere [stA] =  3.335641E-10 ampere [A]
        /// </summary>
        public static double Statampere_2_Ampere(double inVal)                          => inVal * 3.335641E-10;
        /// <summary>
        /// A -> stA
        /// vv: 3.335641E-10 ampere [A] to 1 statampere [stA]
        /// </summary>
        public static double Ampere_2_Statampere(double inVal)                          => inVal / 3.335641E-10;

        /// <summary>
        /// ESUOfCurrent -> A
        /// 1 ESU of current =  3.335641E-10 ampere [A]
        /// </summary>
        public static double ESUOfCurrent_2_Ampere(double inVal)                        => inVal * 3.335641E-10;
        /// <summary>
        /// A -> ESUOfCurrent
        /// vv: 3.335641E-10 ampere [A] to 1 ESU of current
        /// </summary>
        public static double Ampere_2_ESUOfCurrent(double inVal)                        => inVal / 3.335641E-10;

        /// <summary>
        /// CG_e_m_Unit -> A
        /// 1 CGS e.m. unit =  10 ampere [A]
        /// </summary>
        public static double CG_e_m_Unit_2_Ampere(double inVal)                         => inVal * 10;
        /// <summary>
        /// A -> CG_e_m_Unit
        /// vv: 10 ampere [A] to 1 CGS e.m. unit
        /// </summary>
        public static double Ampere_2_CG_e_m_Unit(double inVal)                         => inVal / 10;

        /// <summary>
        /// CGS_e_s_Unit -> A
        /// 1 CGS e.s. unit =  3.335641E-10 ampere [A]
        /// </summary>
        public static double CGS_e_s_Unit_2_Ampere(double inVal)                         => inVal * 3.335641E-10;
        /// <summary>
        /// A -> CGS_e_s_Unit
        /// vv: 3.335641E-10 ampere [A] to 1 CGS e.s. unit
        /// </summary>
        public static double Ampere_2_CGS_e_s_Unit(double inVal)                         => inVal / 3.335641E-10;

        #endregion

        #region electric - linear current density, base: ampere/meter

        /// <summary>
        /// A/cm -> A/m
        /// 1 ampere/centimeter [A/cm] =  100 ampere/meter [A/m]
        /// </summary>
        public static double AmperePerCentimeter_2_AmperePerMeter(double inVal)         => inVal * 100;
        /// <summary>
        /// A/m -> A/cm
        /// vv: 100 ampere/meter [A/m] to 1 ampere/centimeter [A/cm]
        /// </summary>
        public static double AmperePerMeter_2_AmperePerCentimeter(double inVal)         => inVal / 100;

        /// <summary>
        /// A/in -> A/m
        /// 1 ampere/inch [A/in] =  39.3700787402 ampere/meter [A/m]
        /// </summary>
        public static double AmperePerInch_2_AmperePerMeter(double inVal)               => inVal * 39.3700787402;
        /// <summary>
        /// A/m -> A/in
        /// vv: 39.3700787402 ampere/meter [A/m] to 1 ampere/inch [A/in]
        /// </summary>
        public static double AmperePerMeter_2_AmperePerInch(double inVal)               => inVal / 39.3700787402;

        /// <summary>
        /// abA/m -> A/m
        /// 1 abampere/meter [abA/m] =  10 ampere/meter [A/m]
        /// </summary>
        public static double AbamperePerMeter_2_AmperePerMeter(double inVal)            => inVal * 10;
        /// <summary>
        /// A/m -> abA/m
        /// vv: 10 ampere/meter [A/m] to 1 abampere/meter [abA/m]
        /// </summary>
        public static double AmperePerMeter_2_AbamperePerMeter(double inVal)            => inVal / 10;

        /// <summary>
        /// AbamperePerCentimeter -> A/m
        /// 1 abampere/centimeter =  1000 ampere/meter [A/m]
        /// </summary>
        public static double AbamperePerCentimeter_2_AmperePerMeter(double inVal)       => inVal * 1000;
        /// <summary>
        /// A/m -> AbamperePerCentimeter
        /// vv: 1000 ampere/meter [A/m] to 1 abampere/centimeter
        /// </summary>
        public static double AmperePerMeter_2_AbamperePerCentimeter(double inVal)       => inVal / 1000;

        /// <summary>
        /// abA/in -> A/m
        /// 1 abampere/inch [abA/in] =  393.7007874016 ampere/meter [A/m]
        /// </summary>
        public static double AbamperePerInch_2_AmperePerMeter(double inVal)             => inVal * 393.7007874016;
        /// <summary>
        /// A/m -> abA/in
        /// vv: 393.7007874016 ampere/meter [A/m] to 1 abampere/inch [abA/in]
        /// </summary>
        public static double AmperePerMeter_2_AbamperePerInch(double inVal)             => inVal / 393.7007874016;

        /// <summary>
        /// Oe -> A/m
        /// 1 oersted [Oe] =  79.5774715102 ampere/meter [A/m]
        /// </summary>
        public static double Oersted_2_AmperePerMeter(double inVal)                     => inVal * 79.5774715102;
        /// <summary>
        /// A/m -> Oe
        /// vv: 79.5774715102 ampere/meter [A/m] to 1 oersted [Oe]
        /// </summary>
        public static double AmperePerMeter_2_Oersted(double inVal)                     => inVal / 79.5774715102;

        /// <summary>
        /// Gi/cm -> A/m
        /// 1 gilbert/centimeter [Gi/cm] =  79.5774715102 ampere/meter [A/m]
        /// </summary>
        public static double GilbertPerCentimeter_2_AmperePerMeter(double inVal)        => inVal * 79.5774715102;
        /// <summary>
        /// A/m -> Gi/cm
        /// vv: 79.5774715102 ampere/meter [A/m] to 1 gilbert/centimeter [Gi/cm]
        /// </summary>
        public static double AmperePerMeter_2_GilbertPerCentimeter(double inVal)        => inVal / 79.5774715102;

        #endregion

        #region electric - surface current density, base: ampere/square meter

        /// <summary>
        /// AmperePerSquareCentimeter -> A/m^2
        /// 1 ampere/square centimeter =  10000 ampere/square meter [A/m^2]
        /// </summary>
        public static double AmperePerSquareCentimeter_2_AmperePerSquareMeter(double inVal)=> inVal * 10000;
        /// <summary>
        /// A/m^2 -> AmperePerSquareCentimeter
        /// vv: 10000 ampere/square meter [A/m^2] to 1 ampere/square centimeter
        /// </summary>
        public static double AmperePerSquareMeter_2_AmperePerSquareCentimeter(double inVal)=> inVal / 10000;

        /// <summary>
        /// A/in^2 -> A/m^2
        /// 1 ampere/square inch [A/in^2] =  1550.0031000062 ampere/square meter [A/m^2]
        /// </summary>
        public static double AmperePerSquareInch_2_AmperePerSquareMeter(double inVal)   => inVal * 1550.0031000062;
        /// <summary>
        /// A/m^2 -> A/in^2
        /// vv: 1550.0031000062 ampere/square meter [A/m^2] to 1 ampere/square inch [A/in^2]
        /// </summary>
        public static double AmperePerSquareMeter_2_AmperePerSquareInch(double inVal)   => inVal / 1550.0031000062;

        /// <summary>
        /// A/mi^2 -> A/m^2
        /// 1 ampere/square mil [A/mi^2] =  1550003100.0062 ampere/square meter [A/m^2]
        /// </summary>
        public static double AmperePerSquareMil_2_AmperePerSquareMeter(double inVal)    => inVal * 1550003100.0062;
        /// <summary>
        /// A/m^2 -> A/mi^2
        /// vv: 1550003100.0062 ampere/square meter [A/m^2] to 1 ampere/square mil [A/mi^2]
        /// </summary>
        public static double AmperePerSquareMeter_2_AmperePerSquareMil(double inVal)    => inVal / 1550003100.0062;

        /// <summary>
        /// AmperePerCicularMil -> A/m^2
        /// 1 ampere/cicular mil =  1973525240.9908 ampere/square meter [A/m^2]
        /// </summary>
        public static double AmperePerCicularMil_2_AmperePerSquareMeter(double inVal)   => inVal * 1973525240.9908;
        /// <summary>
        /// A/m^2 -> AmperePerCicularMil
        /// vv: 1973525240.9908 ampere/square meter [A/m^2] to 1 ampere/cicular mil
        /// </summary>
        public static double AmperePerSquareMeter_2_AmperePerCicularMil(double inVal)   => inVal / 1973525240.9908;

        /// <summary>
        /// AbamperePerSquareCentimeter -> A/m^2
        /// 1 abampere/square centimeter =  100000 ampere/square meter [A/m^2]
        /// </summary>
        public static double AbamperePerSquareCentimeter_2_AmperePerSquareMeter(double inVal)=> inVal * 100000;
        /// <summary>
        /// A/m^2 -> AbamperePerSquareCentimeter
        /// vv: 100000 ampere/square meter [A/m^2] to 1 abampere/square centimeter
        /// </summary>
        public static double AmperePerSquareMeter_2_AbamperePerSquareCentimeter(double inVal)=> inVal / 100000;

        #endregion

        #region electric - field strength, base: volt/meter

        /// <summary>
        /// kV/m -> V/m
        /// 1 kilovolt/meter [kV/m] =  1000 volt/meter [V/m]
        /// </summary>
        public static double KilovoltPerMeter_2_VoltPerMeter(double inVal)              => inVal * 1000;
        /// <summary>
        /// V/m -> kV/m
        /// vv: 1000 volt/meter [V/m] to 1 kilovolt/meter [kV/m]
        /// </summary>
        public static double VoltPerMeter_2_KilovoltPerMeter(double inVal)              => inVal / 1000;

        /// <summary>
        /// kV/cm -> V/m
        /// 1 kilovolt/centimeter [kV/cm] =  100000 volt/meter [V/m]
        /// </summary>
        public static double KilovoltPerCentimeter_2_VoltPerMeter(double inVal)         => inVal * 100000;
        /// <summary>
        /// V/m -> kV/cm
        /// vv: 100000 volt/meter [V/m] to 1 kilovolt/centimeter [kV/cm]
        /// </summary>
        public static double VoltPerMeter_2_KilovoltPerCentimeter(double inVal)         => inVal / 100000;

        /// <summary>
        /// V/cm -> V/m
        /// 1 volt/centimeter [V/cm] =  100 volt/meter [V/m]
        /// </summary>
        public static double VoltPerCentimeter_2_VoltPerMeter(double inVal)             => inVal * 100;
        /// <summary>
        /// V/m -> V/cm
        /// vv: 100 volt/meter [V/m] to 1 volt/centimeter [V/cm]
        /// </summary>
        public static double VoltPerMeter_2_VoltPerCentimeter(double inVal)             => inVal / 100;

        /// <summary>
        /// mV/m -> V/m
        /// 1 millivolt/meter [mV/m] =  0.001 volt/meter [V/m]
        /// </summary>
        public static double MillivoltPerMeter_2_VoltPerMeter(double inVal)             => inVal * 0.001;
        /// <summary>
        /// V/m -> mV/m
        /// vv: 0.001 volt/meter [V/m] to 1 millivolt/meter [mV/m]
        /// </summary>
        public static double VoltPerMeter_2_MillivoltPerMeter(double inVal)             => inVal / 0.001;

        /// <summary>
        /// µ/m -> V/m
        /// 1 microvolt/meter [µ/m] =  1.0E-6 volt/meter [V/m]
        /// </summary>
        public static double MicrovoltPerMeter_2_VoltPerMeter(double inVal)             => inVal * 1.0E-6;
        /// <summary>
        /// V/m -> µ/m
        /// vv: 1.0E-6 volt/meter [V/m] to 1 microvolt/meter [µ/m]
        /// </summary>
        public static double VoltPerMeter_2_MicrovoltPerMeter(double inVal)             => inVal / 1.0E-6;

        /// <summary>
        /// kV/in -> V/m
        /// 1 kilovolt/inch [kV/in] =  39370.078740157 volt/meter [V/m]
        /// </summary>
        public static double KilovoltPerInch_2_VoltPerMeter(double inVal)               => inVal * 39370.078740157;
        /// <summary>
        /// V/m -> kV/in
        /// vv: 39370.078740157 volt/meter [V/m] to 1 kilovolt/inch [kV/in]
        /// </summary>
        public static double VoltPerMeter_2_KilovoltPerInch(double inVal)               => inVal / 39370.078740157;

        /// <summary>
        /// V/in -> V/m
        /// 1 volt/inch [V/in] =  39.3700787402 volt/meter [V/m]
        /// </summary>
        public static double VoltPerInch_2_VoltPerMeter(double inVal)                   => inVal * 39.3700787402;
        /// <summary>
        /// V/m -> V/in
        /// vv: 39.3700787402 volt/meter [V/m] to 1 volt/inch [V/in]
        /// </summary>
        public static double VoltPerMeter_2_VoltPerInch(double inVal)                   => inVal / 39.3700787402;

        /// <summary>
        /// V/mil -> V/m
        /// 1 volt/mil [V/mil] =  39370.078740157 volt/meter [V/m]
        /// </summary>
        public static double VoltPerMil_2_VoltPerMeter(double inVal)                    => inVal * 39370.078740157;
        /// <summary>
        /// V/m -> V/mil
        /// vv: 39370.078740157 volt/meter [V/m] to 1 volt/mil [V/mil]
        /// </summary>
        public static double VoltPerMeter_2_VoltPerMil(double inVal)                    => inVal / 39370.078740157;

        /// <summary>
        /// abV/cm -> V/m
        /// 1 abvolt/centimeter [abV/cm] =  1.0E-6 volt/meter [V/m]
        /// </summary>
        public static double AbvoltPerCentimeter_2_VoltPerMeter(double inVal)           => inVal * 1.0E-6;
        /// <summary>
        /// V/m -> abV/cm
        /// vv: 1.0E-6 volt/meter [V/m] to 1 abvolt/centimeter [abV/cm]
        /// </summary>
        public static double VoltPerMeter_2_AbvoltPerCentimeter(double inVal)           => inVal / 1.0E-6;

        /// <summary>
        /// stV/cm -> V/m
        /// 1 statvolt/centimeter [stV/cm] =  29979.19999934 volt/meter [V/m]
        /// </summary>
        public static double StatvoltPerCentimeter_2_VoltPerMeter(double inVal)         => inVal * 29979.19999934;
        /// <summary>
        /// V/m -> stV/cm
        /// vv: 29979.19999934 volt/meter [V/m] to 1 statvolt/centimeter [stV/cm]
        /// </summary>
        public static double VoltPerMeter_2_StatvoltPerCentimeter(double inVal)         => inVal / 29979.19999934;

        /// <summary>
        /// stV/in -> V/m
        /// 1 statvolt/inch [stV/in] =  11802.834645298 volt/meter [V/m]
        /// </summary>
        public static double StatvoltPerInch_2_VoltPerMeter(double inVal)               => inVal * 11802.834645298;
        /// <summary>
        /// V/m -> stV/in
        /// vv: 11802.834645298 volt/meter [V/m] to 1 statvolt/inch [stV/in]
        /// </summary>
        public static double VoltPerMeter_2_StatvoltPerInch(double inVal)               => inVal / 11802.834645298;

        /// <summary>
        /// N/C -> V/m
        /// 1 newton/coulomb [N/C] =  1 volt/meter [V/m]
        /// </summary>
        public static double NewtonPerCoulomb_2_VoltPerMeter(double inVal)              => inVal * 1;
        /// <summary>
        /// V/m -> N/C
        /// vv: 1 volt/meter [V/m] to 1 newton/coulomb [N/C]
        /// </summary>
        public static double VoltPerMeter_2_NewtonPerCoulomb(double inVal)              => inVal / 1;

        #endregion

        #region electric - potential, base: volt

        /// <summary>
        /// W/A -> V
        /// 1 watt/ampere [W/A] =  1 volt [V]
        /// </summary>
        public static double WattPerAmpere_2_Volt(double inVal)                         => inVal * 1;
        /// <summary>
        /// V -> W/A
        /// vv: 1 volt [V] to 1 watt/ampere [W/A]
        /// </summary>
        public static double Volt_2_WattPerAmpere(double inVal)                         => inVal / 1;

        /// <summary>
        /// abV -> V
        /// 1 abvolt [abV] =  1.0E-8 volt [V]
        /// </summary>
        public static double Abvolt_2_Volt(double inVal)                                => inVal * 1.0E-8;
        /// <summary>
        /// V -> abV
        /// vv: 1.0E-8 volt [V] to 1 abvolt [abV]
        /// </summary>
        public static double Volt_2_Abvolt(double inVal)                                => inVal / 1.0E-8;

        /// <summary>
        /// EMUOfElectricPotential -> V
        /// 1 EMU of electric potential =  1.0E-8 volt [V]
        /// </summary>
        public static double EMUOfElectricPotential_2_Volt(double inVal)                => inVal * 1.0E-8;
        /// <summary>
        /// V -> EMUOfElectricPotential
        /// vv: 1.0E-8 volt [V] to 1 EMU of electric potential
        /// </summary>
        public static double Volt_2_EMUOfElectricPotential(double inVal)                => inVal / 1.0E-8;

        /// <summary>
        /// stV -> V
        /// 1 statvolt [stV] =  299.7925 volt [V]
        /// </summary>
        public static double Statvolt_2_Volt(double inVal)                              => inVal * 299.7925;
        /// <summary>
        /// V -> stV
        /// vv: 299.7925 volt [V] to 1 statvolt [stV]
        /// </summary>
        public static double Volt_2_Statvolt(double inVal)                              => inVal / 299.7925;

        /// <summary>
        /// ESUOfElectricPotential -> V
        /// 1 ESU of electric potential =  299.7925 volt [V]
        /// </summary>
        public static double ESUOfElectricPotential_2_Volt(double inVal)                => inVal * 299.7925;
        /// <summary>
        /// V -> ESUOfElectricPotential
        /// vv: 299.7925 volt [V] to 1 ESU of electric potential
        /// </summary>
        public static double Volt_2_ESUOfElectricPotential(double inVal)                => inVal / 299.7925;

        #endregion

        #region electric - resistance, base: ohm

        /// <summary>
        /// Megohm -> Ohm
        /// 1 megohm =  1000000 ohm
        /// </summary>
        public static double Megohm_2_Ohm(double inVal)                                 => inVal * 1000000;
        /// <summary>
        /// Ohm -> Megohm
        /// vv: 1000000 ohm to 1 megohm
        /// </summary>
        public static double Ohm_2_Megohm(double inVal)                                 => inVal / 1000000;

        /// <summary>
        /// Microhm -> Ohm
        /// 1 microhm =  1.0E-6 ohm
        /// </summary>
        public static double Microhm_2_Ohm(double inVal)                                => inVal * 1.0E-6;
        /// <summary>
        /// Ohm -> Microhm
        /// vv: 1.0E-6 ohm to 1 microhm
        /// </summary>
        public static double Ohm_2_Microhm(double inVal)                                => inVal / 1.0E-6;

        /// <summary>
        /// V/A -> Ohm
        /// 1 volt/ampere [V/A] =  1 ohm
        /// </summary>
        public static double VoltPerAmpere_2_Ohm(double inVal)                          => inVal * 1;
        /// <summary>
        /// Ohm -> V/A
        /// vv: 1 ohm to 1 volt/ampere [V/A]
        /// </summary>
        public static double Ohm_2_VoltPerAmpere(double inVal)                          => inVal / 1;

        /// <summary>
        /// 1/S -> Ohm
        /// 1 reciprocal siemens [1/S] =  1 ohm
        /// </summary>
        public static double ReciprocalSiemens_2_Ohm(double inVal)                      => inVal * 1;
        /// <summary>
        /// Ohm -> 1/S
        /// vv: 1 ohm to 1 reciprocal siemens [1/S]
        /// </summary>
        public static double Ohm_2_ReciprocalSiemens(double inVal)                      => inVal / 1;

        /// <summary>
        /// Abohm -> Ohm
        /// 1 abohm =  1.0E-9 ohm
        /// </summary>
        public static double Abohm_2_Ohm(double inVal)                                  => inVal * 1.0E-9;
        /// <summary>
        /// Ohm -> Abohm
        /// vv: 1.0E-9 ohm to 1 abohm
        /// </summary>
        public static double Ohm_2_Abohm(double inVal)                                  => inVal / 1.0E-9;

        /// <summary>
        /// EMUOfResistance -> Ohm
        /// 1 EMU of resistance =  1.0E-9 ohm
        /// </summary>
        public static double EMUOfResistance_2_Ohm(double inVal)                        => inVal * 1.0E-9;
        /// <summary>
        /// Ohm -> EMUOfResistance
        /// vv: 1.0E-9 ohm to 1 EMU of resistance
        /// </summary>
        public static double Ohm_2_EMUOfResistance(double inVal)                        => inVal / 1.0E-9;

        /// <summary>
        /// Statohm -> Ohm
        /// 1 statohm =  898755200000 ohm
        /// </summary>
        public static double Statohm_2_Ohm(double inVal)                                => inVal * 898755200000;
        /// <summary>
        /// Ohm -> Statohm
        /// vv: 898755200000 ohm to 1 statohm
        /// </summary>
        public static double Ohm_2_Statohm(double inVal)                                => inVal / 898755200000;

        /// <summary>
        /// ESUOfResistance -> Ohm
        /// 1 ESU of resistance =  898755200000 ohm
        /// </summary>
        public static double ESUOfResistance_2_Ohm(double inVal)                        => inVal * 898755200000;
        /// <summary>
        /// Ohm -> ESUOfResistance
        /// vv: 898755200000 ohm to 1 ESU of resistance
        /// </summary>
        public static double Ohm_2_ESUOfResistance(double inVal)                        => inVal / 898755200000;

        /// <summary>
        /// QuantizedHallResistance -> Ohm
        /// 1 Quantized Hall resistance =  25812.8056 ohm
        /// </summary>
        public static double QuantizedHallResistance_2_Ohm(double inVal)                => inVal * 25812.8056;
        /// <summary>
        /// Ohm -> QuantizedHallResistance
        /// vv: 25812.8056 ohm to 1 Quantized Hall resistance
        /// </summary>
        public static double Ohm_2_QuantizedHallResistance(double inVal)                => inVal / 25812.8056;

        #endregion

        #region electric - resistivity, base: ohm meter

        /// <summary>
        /// OhmCentimeter -> OhmMeter
        /// 1 ohm centimeter =  0.01 ohm meter
        /// </summary>
        public static double OhmCentimeter_2_OhmMeter(double inVal)                     => inVal * 0.01;
        /// <summary>
        /// OhmMeter -> OhmCentimeter
        /// vv: 0.01 ohm meter to 1 ohm centimeter
        /// </summary>
        public static double OhmMeter_2_OhmCentimeter(double inVal)                     => inVal / 0.01;

        /// <summary>
        /// OhmInch -> OhmMeter
        /// 1 ohm inch =  0.0254 ohm meter
        /// </summary>
        public static double OhmInch_2_OhmMeter(double inVal)                           => inVal * 0.0254;
        /// <summary>
        /// OhmMeter -> OhmInch
        /// vv: 0.0254 ohm meter to 1 ohm inch
        /// </summary>
        public static double OhmMeter_2_OhmInch(double inVal)                           => inVal / 0.0254;

        /// <summary>
        /// MicrohmCentimeter -> OhmMeter
        /// 1 microhm centimeter =  1.0E-8 ohm meter
        /// </summary>
        public static double MicrohmCentimeter_2_OhmMeter(double inVal)                 => inVal * 1.0E-8;
        /// <summary>
        /// OhmMeter -> MicrohmCentimeter
        /// vv: 1.0E-8 ohm meter to 1 microhm centimeter
        /// </summary>
        public static double OhmMeter_2_MicrohmCentimeter(double inVal)                 => inVal / 1.0E-8;

        /// <summary>
        /// MicrohmInch -> OhmMeter
        /// 1 microhm inch =  2.5400000000102E-8 ohm meter
        /// </summary>
        public static double MicrohmInch_2_OhmMeter(double inVal)                       => inVal * 2.5400000000102E-8;
        /// <summary>
        /// OhmMeter -> MicrohmInch
        /// vv: 2.5400000000102E-8 ohm meter to 1 microhm inch
        /// </summary>
        public static double OhmMeter_2_MicrohmInch(double inVal)                       => inVal / 2.5400000000102E-8;

        /// <summary>
        /// AbohmCentimeter -> OhmMeter
        /// 1 abohm centimeter =  1.0E-11 ohm meter
        /// </summary>
        public static double AbohmCentimeter_2_OhmMeter(double inVal)                   => inVal * 1.0E-11;
        /// <summary>
        /// OhmMeter -> AbohmCentimeter
        /// vv: 1.0E-11 ohm meter to 1 abohm centimeter
        /// </summary>
        public static double OhmMeter_2_AbohmCentimeter(double inVal)                   => inVal / 1.0E-11;

        /// <summary>
        /// StatohmCentimeter -> OhmMeter
        /// 1 statohm centimeter =  8987524324.0156 ohm meter
        /// </summary>
        public static double StatohmCentimeter_2_OhmMeter(double inVal)                 => inVal * 8987524324.0156;
        /// <summary>
        /// OhmMeter -> StatohmCentimeter
        /// vv: 8987524324.0156 ohm meter to 1 statohm centimeter
        /// </summary>
        public static double OhmMeter_2_StatohmCentimeter(double inVal)                 => inVal / 8987524324.0156;

        /// <summary>
        /// CircularMilOhmPerFoot -> OhmMeter
        /// 1 circular mil ohm/foot =  1.6624261130101E-9 ohm meter
        /// </summary>
        public static double CircularMilOhmPerFoot_2_OhmMeter(double inVal)             => inVal * 1.6624261130101E-9;
        /// <summary>
        /// OhmMeter -> CircularMilOhmPerFoot
        /// vv: 1.6624261130101E-9 ohm meter to 1 circular mil ohm/foot
        /// </summary>
        public static double OhmMeter_2_CircularMilOhmPerFoot(double inVal)             => inVal / 1.6624261130101E-9;

        #endregion

        #region electric - conductance, base: siemens

        /// <summary>
        /// MS -> S
        /// 1 megasiemens [MS] =  1000000 siemens [S]
        /// </summary>
        public static double Megasiemens_2_Siemens(double inVal)                        => inVal * 1000000;
        /// <summary>
        /// S -> MS
        /// vv: 1000000 siemens [S] to 1 megasiemens [MS]
        /// </summary>
        public static double Siemens_2_Megasiemens(double inVal)                        => inVal / 1000000;

        /// <summary>
        /// kS -> S
        /// 1 kilosiemens [kS] =  1000 siemens [S]
        /// </summary>
        public static double Kilosiemens_2_Siemens(double inVal)                        => inVal * 1000;
        /// <summary>
        /// S -> kS
        /// vv: 1000 siemens [S] to 1 kilosiemens [kS]
        /// </summary>
        public static double Siemens_2_Kilosiemens(double inVal)                        => inVal / 1000;

        /// <summary>
        /// mS -> S
        /// 1 millisiemens [mS] =  0.001 siemens [S]
        /// </summary>
        public static double Millisiemens_2_Siemens(double inVal)                       => inVal * 0.001;
        /// <summary>
        /// S -> mS
        /// vv: 0.001 siemens [S] to 1 millisiemens [mS]
        /// </summary>
        public static double Siemens_2_Millisiemens(double inVal)                       => inVal / 0.001;

        /// <summary>
        /// µS -> S
        /// 1 microsiemens [µS] =  1.0E-6 siemens [S]
        /// </summary>
        public static double Microsiemens_2_Siemens(double inVal)                       => inVal * 1.0E-6;
        /// <summary>
        /// S -> µS
        /// vv: 1.0E-6 siemens [S] to 1 microsiemens [µS]
        /// </summary>
        public static double Siemens_2_Microsiemens(double inVal)                       => inVal / 1.0E-6;

        /// <summary>
        /// A/V -> S
        /// 1 ampere/volt [A/V] =  1 siemens [S]
        /// </summary>
        public static double AmperePerVolt_2_Siemens(double inVal)                      => inVal * 1;
        /// <summary>
        /// S -> A/V
        /// vv: 1 siemens [S] to 1 ampere/volt [A/V]
        /// </summary>
        public static double Siemens_2_AmperePerVolt(double inVal)                      => inVal / 1;

        /// <summary>
        /// Mho -> S
        /// 1 mho =  1 siemens [S]
        /// </summary>
        public static double Mho_2_Siemens(double inVal)                                => inVal * 1;
        /// <summary>
        /// S -> Mho
        /// vv: 1 siemens [S] to 1 mho
        /// </summary>
        public static double Siemens_2_Mho(double inVal)                                => inVal / 1;

        /// <summary>
        /// Gemmho -> S
        /// 1 gemmho =  1.0E-6 siemens [S]
        /// </summary>
        public static double Gemmho_2_Siemens(double inVal)                             => inVal * 1.0E-6;
        /// <summary>
        /// S -> Gemmho
        /// vv: 1.0E-6 siemens [S] to 1 gemmho
        /// </summary>
        public static double Siemens_2_Gemmho(double inVal)                             => inVal / 1.0E-6;

        /// <summary>
        /// Micromho -> S
        /// 1 micromho =  1.0E-6 siemens [S]
        /// </summary>
        public static double Micromho_2_Siemens(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// S -> Micromho
        /// vv: 1.0E-6 siemens [S] to 1 micromho
        /// </summary>
        public static double Siemens_2_Micromho(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// Abmho -> S
        /// 1 abmho =  1000000000 siemens [S]
        /// </summary>
        public static double Abmho_2_Siemens(double inVal)                              => inVal * 1000000000;
        /// <summary>
        /// S -> Abmho
        /// vv: 1000000000 siemens [S] to 1 abmho
        /// </summary>
        public static double Siemens_2_Abmho(double inVal)                              => inVal / 1000000000;

        /// <summary>
        /// Statmho -> S
        /// 1 statmho =  1.1123470522803E-12 siemens [S]
        /// </summary>
        public static double Statmho_2_Siemens(double inVal)                            => inVal * 1.1123470522803E-12;
        /// <summary>
        /// S -> Statmho
        /// vv: 1.1123470522803E-12 siemens [S] to 1 statmho
        /// </summary>
        public static double Siemens_2_Statmho(double inVal)                            => inVal / 1.1123470522803E-12;

        /// <summary>
        /// QuantizedHallConductance -> S
        /// 1 Quantized Hall conductance =  3.87405E-5 siemens [S]
        /// </summary>
        public static double QuantizedHallConductance_2_Siemens(double inVal)           => inVal * 3.87405E-5;
        /// <summary>
        /// S -> QuantizedHallConductance
        /// vv: 3.87405E-5 siemens [S] to 1 Quantized Hall conductance
        /// </summary>
        public static double Siemens_2_QuantizedHallConductance(double inVal)           => inVal / 3.87405E-5;

        #endregion

        #region electric - conductivity, base: siemens/meter

        /// <summary>
        /// pS/m -> S/m
        /// 1 picosiemens/meter [pS/m] =  1.0E-12 siemens/meter [S/m]
        /// </summary>
        public static double PicosiemensPerMeter_2_SiemensPerMeter(double inVal)        => inVal * 1.0E-12;
        /// <summary>
        /// S/m -> pS/m
        /// vv: 1.0E-12 siemens/meter [S/m] to 1 picosiemens/meter [pS/m]
        /// </summary>
        public static double SiemensPerMeter_2_PicosiemensPerMeter(double inVal)        => inVal / 1.0E-12;

        /// <summary>
        /// mho/m -> S/m
        /// 1 mho/meter [mho/m] =  1 siemens/meter [S/m]
        /// </summary>
        public static double MhoPerMeter_2_SiemensPerMeter(double inVal)                => inVal * 1;
        /// <summary>
        /// S/m -> mho/m
        /// vv: 1 siemens/meter [S/m] to 1 mho/meter [mho/m]
        /// </summary>
        public static double SiemensPerMeter_2_MhoPerMeter(double inVal)                => inVal / 1;

        /// <summary>
        /// mho/cm -> S/m
        /// 1 mho/centimeter [mho/cm] =  100 siemens/meter [S/m]
        /// </summary>
        public static double MhoPerCentimeter_2_SiemensPerMeter(double inVal)           => inVal * 100;
        /// <summary>
        /// S/m -> mho/cm
        /// vv: 100 siemens/meter [S/m] to 1 mho/centimeter [mho/cm]
        /// </summary>
        public static double SiemensPerMeter_2_MhoPerCentimeter(double inVal)           => inVal / 100;

        /// <summary>
        /// abmho/m -> S/m
        /// 1 abmho/meter [abmho/m] =  1000000000 siemens/meter [S/m]
        /// </summary>
        public static double AbmhoPerMeter_2_SiemensPerMeter(double inVal)              => inVal * 1000000000;
        /// <summary>
        /// S/m -> abmho/m
        /// vv: 1000000000 siemens/meter [S/m] to 1 abmho/meter [abmho/m]
        /// </summary>
        public static double SiemensPerMeter_2_AbmhoPerMeter(double inVal)              => inVal / 1000000000;

        /// <summary>
        /// AbmhoPerCentimeter -> S/m
        /// 1 abmho/centimeter =  100000000000 siemens/meter [S/m]
        /// </summary>
        public static double AbmhoPerCentimeter_2_SiemensPerMeter(double inVal)         => inVal * 100000000000;
        /// <summary>
        /// S/m -> AbmhoPerCentimeter
        /// vv: 100000000000 siemens/meter [S/m] to 1 abmho/centimeter
        /// </summary>
        public static double SiemensPerMeter_2_AbmhoPerCentimeter(double inVal)         => inVal / 100000000000;

        /// <summary>
        /// stmho/m -> S/m
        /// 1 statmho/meter [stmho/m] =  1.1126534560019E-12 siemens/meter [S/m]
        /// </summary>
        public static double StatmhoPerMeter_2_SiemensPerMeter(double inVal)            => inVal * 1.1126534560019E-12;
        /// <summary>
        /// S/m -> stmho/m
        /// vv: 1.1126534560019E-12 siemens/meter [S/m] to 1 statmho/meter [stmho/m]
        /// </summary>
        public static double SiemensPerMeter_2_StatmhoPerMeter(double inVal)            => inVal / 1.1126534560019E-12;

        /// <summary>
        /// StatmhoPerCentimeter -> S/m
        /// 1 statmho/centimeter =  1.1126534560019E-10 siemens/meter [S/m]
        /// </summary>
        public static double StatmhoPerCentimeter_2_SiemensPerMeter(double inVal)       => inVal * 1.1126534560019E-10;
        /// <summary>
        /// S/m -> StatmhoPerCentimeter
        /// vv: 1.1126534560019E-10 siemens/meter [S/m] to 1 statmho/centimeter
        /// </summary>
        public static double SiemensPerMeter_2_StatmhoPerCentimeter(double inVal)       => inVal / 1.1126534560019E-10;

       #endregion

        #region electric - electrostatic capacitance, base: farad

        /// <summary>
        /// EF -> F
        /// 1 exafarad [EF] =  1.0E+18 farad [F]
        /// </summary>
        public static double Exafarad_2_Farad(double inVal)                             => inVal * 1.0E+18;
        /// <summary>
        /// F -> EF
        /// vv: 1.0E+18 farad [F] to 1 exafarad [EF]
        /// </summary>
        public static double Farad_2_Exafarad(double inVal)                             => inVal / 1.0E+18;

        /// <summary>
        /// PF -> F
        /// 1 petafarad [PF] =  1.0E+15 farad [F]
        /// </summary>
        public static double Petafarad_2_Farad(double inVal)                            => inVal * 1.0E+15;
        /// <summary>
        /// F -> PF
        /// vv: 1.0E+15 farad [F] to 1 petafarad [PF]
        /// </summary>
        public static double Farad_2_Petafarad(double inVal)                            => inVal / 1.0E+15;

        /// <summary>
        /// TF -> F
        /// 1 terafarad [TF] =  1000000000000 farad [F]
        /// </summary>
        public static double Terafarad_2_Farad(double inVal)                            => inVal * 1000000000000;
        /// <summary>
        /// F -> TF
        /// vv: 1000000000000 farad [F] to 1 terafarad [TF]
        /// </summary>
        public static double Farad_2_Terafarad(double inVal)                            => inVal / 1000000000000;

        /// <summary>
        /// GF -> F
        /// 1 gigafarad [GF] =  1000000000 farad [F]
        /// </summary>
        public static double Gigafarad_2_Farad(double inVal)                            => inVal * 1000000000;
        /// <summary>
        /// F -> GF
        /// vv: 1000000000 farad [F] to 1 gigafarad [GF]
        /// </summary>
        public static double Farad_2_Gigafarad(double inVal)                            => inVal / 1000000000;

        /// <summary>
        /// MF -> F
        /// 1 megafarad [MF] =  1000000 farad [F]
        /// </summary>
        public static double Megafarad_2_Farad(double inVal)                            => inVal * 1000000;
        /// <summary>
        /// F -> MF
        /// vv: 1000000 farad [F] to 1 megafarad [MF]
        /// </summary>
        public static double Farad_2_Megafarad(double inVal)                            => inVal / 1000000;

        /// <summary>
        /// kF -> F
        /// 1 kilofarad [kF] =  1000 farad [F]
        /// </summary>
        public static double Kilofarad_2_Farad(double inVal)                            => inVal * 1000;
        /// <summary>
        /// F -> kF
        /// vv: 1000 farad [F] to 1 kilofarad [kF]
        /// </summary>
        public static double Farad_2_Kilofarad(double inVal)                            => inVal / 1000;

        /// <summary>
        /// hF -> F
        /// 1 hectofarad [hF] =  100 farad [F]
        /// </summary>
        public static double Hectofarad_2_Farad(double inVal)                           => inVal * 100;
        /// <summary>
        /// F -> hF
        /// vv: 100 farad [F] to 1 hectofarad [hF]
        /// </summary>
        public static double Farad_2_Hectofarad(double inVal)                           => inVal / 100;

        /// <summary>
        /// daF -> F
        /// 1 dekafarad [daF] =  10 farad [F]
        /// </summary>
        public static double Dekafarad_2_Farad(double inVal)                            => inVal * 10;
        /// <summary>
        /// F -> daF
        /// vv: 10 farad [F] to 1 dekafarad [daF]
        /// </summary>
        public static double Farad_2_Dekafarad(double inVal)                            => inVal / 10;

        /// <summary>
        /// dF -> F
        /// 1 decifarad [dF] =  0.1 farad [F]
        /// </summary>
        public static double Decifarad_2_Farad(double inVal)                            => inVal * 0.1;
        /// <summary>
        /// F -> dF
        /// vv: 0.1 farad [F] to 1 decifarad [dF]
        /// </summary>
        public static double Farad_2_Decifarad(double inVal)                            => inVal / 0.1;

        /// <summary>
        /// cF -> F
        /// 1 centifarad [cF] =  0.01 farad [F]
        /// </summary>
        public static double Centifarad_2_Farad(double inVal)                           => inVal * 0.01;
        /// <summary>
        /// F -> cF
        /// vv: 0.01 farad [F] to 1 centifarad [cF]
        /// </summary>
        public static double Farad_2_Centifarad(double inVal)                           => inVal / 0.01;

        /// <summary>
        /// mF -> F
        /// 1 millifarad [mF] =  0.001 farad [F]
        /// </summary>
        public static double Millifarad_2_Farad(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// F -> mF
        /// vv: 0.001 farad [F] to 1 millifarad [mF]
        /// </summary>
        public static double Farad_2_Millifarad(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// µF -> F
        /// 1 microfarad [µF] =  1.0E-6 farad [F]
        /// </summary>
        public static double Microfarad_2_Farad(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// F -> µF
        /// vv: 1.0E-6 farad [F] to 1 microfarad [µF]
        /// </summary>
        public static double Farad_2_Microfarad(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// nF -> F
        /// 1 nanofarad [nF] =  1.0E-9 farad [F]
        /// </summary>
        public static double Nanofarad_2_Farad(double inVal)                            => inVal * 1.0E-9;
        /// <summary>
        /// F -> nF
        /// vv: 1.0E-9 farad [F] to 1 nanofarad [nF]
        /// </summary>
        public static double Farad_2_Nanofarad(double inVal)                            => inVal / 1.0E-9;

        /// <summary>
        /// pF -> F
        /// 1 picofarad [pF] =  1.0E-12 farad [F]
        /// </summary>
        public static double Picofarad_2_Farad(double inVal)                            => inVal * 1.0E-12;
        /// <summary>
        /// F -> pF
        /// vv: 1.0E-12 farad [F] to 1 picofarad [pF]
        /// </summary>
        public static double Farad_2_Picofarad(double inVal)                            => inVal / 1.0E-12;

        /// <summary>
        /// fF -> F
        /// 1 femtofarad [fF] =  1.0E-15 farad [F]
        /// </summary>
        public static double Femtofarad_2_Farad(double inVal)                           => inVal * 1.0E-15;
        /// <summary>
        /// F -> fF
        /// vv: 1.0E-15 farad [F] to 1 femtofarad [fF]
        /// </summary>
        public static double Farad_2_Femtofarad(double inVal)                           => inVal / 1.0E-15;

        /// <summary>
        /// aF -> F
        /// 1 attofarad [aF] =  1.0E-18 farad [F]
        /// </summary>
        public static double Attofarad_2_Farad(double inVal)                            => inVal * 1.0E-18;
        /// <summary>
        /// F -> aF
        /// vv: 1.0E-18 farad [F] to 1 attofarad [aF]
        /// </summary>
        public static double Farad_2_Attofarad(double inVal)                            => inVal / 1.0E-18;

        /// <summary>
        /// C/V -> F
        /// 1 coulomb/volt [C/V] =  1 farad [F]
        /// </summary>
        public static double CoulombPerVolt_2_Farad(double inVal)                       => inVal * 1;
        /// <summary>
        /// F -> C/V
        /// vv: 1 farad [F] to 1 coulomb/volt [C/V]
        /// </summary>
        public static double Farad_2_CoulombPerVolt(double inVal)                       => inVal / 1;

        /// <summary>
        /// abF -> F
        /// 1 abfarad [abF] =  1000000000 farad [F]
        /// </summary>
        public static double Abfarad_2_Farad(double inVal)                              => inVal * 1000000000;
        /// <summary>
        /// F -> abF
        /// vv: 1000000000 farad [F] to 1 abfarad [abF]
        /// </summary>
        public static double Farad_2_Abfarad(double inVal)                              => inVal / 1000000000;

        /// <summary>
        /// EMUOfCapacitance -> F
        /// 1 EMU of capacitance =  1000000000 farad [F]
        /// </summary>
        public static double EMUOfCapacitance_2_Farad(double inVal)                     => inVal * 1000000000;
        /// <summary>
        /// F -> EMUOfCapacitance
        /// vv: 1000000000 farad [F] to 1 EMU of capacitance
        /// </summary>
        public static double Farad_2_EMUOfCapacitance(double inVal)                     => inVal / 1000000000;

        /// <summary>
        /// stF -> F
        /// 1 statfarad [stF] =  1.112650056054E-12 farad [F]
        /// </summary>
        public static double Statfarad_2_Farad(double inVal)                            => inVal * 1.112650056054E-12;
        /// <summary>
        /// F -> stF
        /// vv: 1.112650056054E-12 farad [F] to 1 statfarad [stF]
        /// </summary>
        public static double Farad_2_Statfarad(double inVal)                            => inVal / 1.112650056054E-12;

        /// <summary>
        /// ESUOfCapacitance -> F
        /// 1 ESU of capacitance =  1.112650056054E-12 farad [F]
        /// </summary>
        public static double ESUOfCapacitance_2_Farad(double inVal)                     => inVal * 1.112650056054E-12;
        /// <summary>
        /// F -> ESUOfCapacitance
        /// vv: 1.112650056054E-12 farad [F] to 1 ESU of capacitance
        /// </summary>
        public static double Farad_2_ESUOfCapacitance(double inVal)                     => inVal / 1.112650056054E-12;

        #endregion

        #region electric - inductance, base: henry

        /// <summary>
        /// EH -> H
        /// 1 exahenry [EH] =  1.0E+18 henry [H]
        /// </summary>
        public static double Exahenry_2_Henry(double inVal)                             => inVal * 1.0E+18;
        /// <summary>
        /// H -> EH
        /// vv: 1.0E+18 henry [H] to 1 exahenry [EH]
        /// </summary>
        public static double Henry_2_Exahenry(double inVal)                             => inVal / 1.0E+18;

        /// <summary>
        /// PH -> H
        /// 1 petahenry [PH] =  1.0E+15 henry [H]
        /// </summary>
        public static double Petahenry_2_Henry(double inVal)                            => inVal * 1.0E+15;
        /// <summary>
        /// H -> PH
        /// vv: 1.0E+15 henry [H] to 1 petahenry [PH]
        /// </summary>
        public static double Henry_2_Petahenry(double inVal)                            => inVal / 1.0E+15;

        /// <summary>
        /// TH -> H
        /// 1 terahenry [TH] =  1000000000000 henry [H]
        /// </summary>
        public static double Terahenry_2_Henry(double inVal)                            => inVal * 1000000000000;
        /// <summary>
        /// H -> TH
        /// vv: 1000000000000 henry [H] to 1 terahenry [TH]
        /// </summary>
        public static double Henry_2_Terahenry(double inVal)                            => inVal / 1000000000000;

        /// <summary>
        /// GH -> H
        /// 1 gigahenry [GH] =  1000000000 henry [H]
        /// </summary>
        public static double Gigahenry_2_Henry(double inVal)                            => inVal * 1000000000;
        /// <summary>
        /// H -> GH
        /// vv: 1000000000 henry [H] to 1 gigahenry [GH]
        /// </summary>
        public static double Henry_2_Gigahenry(double inVal)                            => inVal / 1000000000;

        /// <summary>
        /// MH -> H
        /// 1 megahenry [MH] =  1000000 henry [H]
        /// </summary>
        public static double Megahenry_2_Henry(double inVal)                            => inVal * 1000000;
        /// <summary>
        /// H -> MH
        /// vv: 1000000 henry [H] to 1 megahenry [MH]
        /// </summary>
        public static double Henry_2_Megahenry(double inVal)                            => inVal / 1000000;

        /// <summary>
        /// kH -> H
        /// 1 kilohenry [kH] =  1000 henry [H]
        /// </summary>
        public static double Kilohenry_2_Henry(double inVal)                            => inVal * 1000;
        /// <summary>
        /// H -> kH
        /// vv: 1000 henry [H] to 1 kilohenry [kH]
        /// </summary>
        public static double Henry_2_Kilohenry(double inVal)                            => inVal / 1000;

        /// <summary>
        /// hH -> H
        /// 1 hectohenry [hH] =  100 henry [H]
        /// </summary>
        public static double Hectohenry_2_Henry(double inVal)                           => inVal * 100;
        /// <summary>
        /// H -> hH
        /// vv: 100 henry [H] to 1 hectohenry [hH]
        /// </summary>
        public static double Henry_2_Hectohenry(double inVal)                           => inVal / 100;

        /// <summary>
        /// daH -> H
        /// 1 dekahenry [daH] =  10 henry [H]
        /// </summary>
        public static double Dekahenry_2_Henry(double inVal)                            => inVal * 10;
        /// <summary>
        /// H -> daH
        /// vv: 10 henry [H] to 1 dekahenry [daH]
        /// </summary>
        public static double Henry_2_Dekahenry(double inVal)                            => inVal / 10;

        /// <summary>
        /// dH -> H
        /// 1 decihenry [dH] =  0.1 henry [H]
        /// </summary>
        public static double Decihenry_2_Henry(double inVal)                            => inVal * 0.1;
        /// <summary>
        /// H -> dH
        /// vv: 0.1 henry [H] to 1 decihenry [dH]
        /// </summary>
        public static double Henry_2_Decihenry(double inVal)                            => inVal / 0.1;

        /// <summary>
        /// cH -> H
        /// 1 centihenry [cH] =  0.01 henry [H]
        /// </summary>
        public static double Centihenry_2_Henry(double inVal)                           => inVal * 0.01;
        /// <summary>
        /// H -> cH
        /// vv: 0.01 henry [H] to 1 centihenry [cH]
        /// </summary>
        public static double Henry_2_Centihenry(double inVal)                           => inVal / 0.01;

        /// <summary>
        /// mH -> H
        /// 1 millihenry [mH] =  0.001 henry [H]
        /// </summary>
        public static double Millihenry_2_Henry(double inVal)                           => inVal * 0.001;
        /// <summary>
        /// H -> mH
        /// vv: 0.001 henry [H] to 1 millihenry [mH]
        /// </summary>
        public static double Henry_2_Millihenry(double inVal)                           => inVal / 0.001;

        /// <summary>
        /// µH -> H
        /// 1 microhenry [µH] =  1.0E-6 henry [H]
        /// </summary>
        public static double Microhenry_2_Henry(double inVal)                           => inVal * 1.0E-6;
        /// <summary>
        /// H -> µH
        /// vv: 1.0E-6 henry [H] to 1 microhenry [µH]
        /// </summary>
        public static double Henry_2_Microhenry(double inVal)                           => inVal / 1.0E-6;

        /// <summary>
        /// nH -> H
        /// 1 nanohenry [nH] =  1.0E-9 henry [H]
        /// </summary>
        public static double Nanohenry_2_Henry(double inVal)                            => inVal * 1.0E-9;
        /// <summary>
        /// H -> nH
        /// vv: 1.0E-9 henry [H] to 1 nanohenry [nH]
        /// </summary>
        public static double Henry_2_Nanohenry(double inVal)                            => inVal / 1.0E-9;

        /// <summary>
        /// pH -> H
        /// 1 picohenry [pH] =  1.0E-12 henry [H]
        /// </summary>
        public static double Picohenry_2_Henry(double inVal)                            => inVal * 1.0E-12;
        /// <summary>
        /// H -> pH
        /// vv: 1.0E-12 henry [H] to 1 picohenry [pH]
        /// </summary>
        public static double Henry_2_Picohenry(double inVal)                            => inVal / 1.0E-12;

        /// <summary>
        /// fH -> H
        /// 1 femtohenry [fH] =  1.0E-15 henry [H]
        /// </summary>
        public static double Femtohenry_2_Henry(double inVal)                           => inVal * 1.0E-15;
        /// <summary>
        /// H -> fH
        /// vv: 1.0E-15 henry [H] to 1 femtohenry [fH]
        /// </summary>
        public static double Henry_2_Femtohenry(double inVal)                           => inVal / 1.0E-15;

        /// <summary>
        /// aH -> H
        /// 1 attohenry [aH] =  1.0E-18 henry [H]
        /// </summary>
        public static double Attohenry_2_Henry(double inVal)                            => inVal * 1.0E-18;
        /// <summary>
        /// H -> aH
        /// vv: 1.0E-18 henry [H] to 1 attohenry [aH]
        /// </summary>
        public static double Henry_2_Attohenry(double inVal)                            => inVal / 1.0E-18;

        /// <summary>
        /// Wb/A -> H
        /// 1 weber/ampere [Wb/A] =  1 henry [H]
        /// </summary>
        public static double WeberPerAmpere_2_Henry(double inVal)                       => inVal * 1;
        /// <summary>
        /// H -> Wb/A
        /// vv: 1 henry [H] to 1 weber/ampere [Wb/A]
        /// </summary>
        public static double Henry_2_WeberPerAmpere(double inVal)                       => inVal / 1;

        /// <summary>
        /// abH -> H
        /// 1 abhenry [abH] =  1.0E-9 henry [H]
        /// </summary>
        public static double Abhenry_2_Henry(double inVal)                              => inVal * 1.0E-9;
        /// <summary>
        /// H -> abH
        /// vv: 1.0E-9 henry [H] to 1 abhenry [abH]
        /// </summary>
        public static double Henry_2_Abhenry(double inVal)                              => inVal / 1.0E-9;

        /// <summary>
        /// EMUOfInductance -> H
        /// 1 EMU of inductance =  1.0E-9 henry [H]
        /// </summary>
        public static double EMUOfInductance_2_Henry(double inVal)                      => inVal * 1.0E-9;
        /// <summary>
        /// H -> EMUOfInductance
        /// vv: 1.0E-9 henry [H] to 1 EMU of inductance
        /// </summary>
        public static double Henry_2_EMUOfInductance(double inVal)                      => inVal / 1.0E-9;

        /// <summary>
        /// stH -> H
        /// 1 stathenry [stH] =  898755200000 henry [H]
        /// </summary>
        public static double Stathenry_2_Henry(double inVal)                            => inVal * 898755200000;
        /// <summary>
        /// H -> stH
        /// vv: 898755200000 henry [H] to 1 stathenry [stH]
        /// </summary>
        public static double Henry_2_Stathenry(double inVal)                            => inVal / 898755200000;

        /// <summary>
        /// ESUOfInductance -> H
        /// 1 ESU of inductance =  898755200000 henry [H]
        /// </summary>
        public static double ESUOfInductance_2_Henry(double inVal)                      => inVal * 898755200000;
        /// <summary>
        /// H -> ESUOfInductance
        /// vv: 898755200000 henry [H] to 1 ESU of inductance
        /// </summary>
        public static double Henry_2_ESUOfInductance(double inVal)                      => inVal / 898755200000;

        #endregion
    }
}
