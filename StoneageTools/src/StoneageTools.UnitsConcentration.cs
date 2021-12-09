
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region concentration modular, base: mol/cubic meter

        /// <summary>
        /// mol/L -> mol/m^3
        /// 1 mol/liter [mol/L] =  1000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MolPerLiter_2_MolPerCubicMeter(double inVal)               => inVal * 1000;
        /// <summary>
        /// mol/m^3 -> mol/L
        /// vv: 1000 mol/cubic meter [mol/m^3] to 1 mol/liter [mol/L]
        /// </summary>
        public static double MolPerCubicMeter_2_MolPerLiter(double inVal)               => inVal / 1000;

        /// <summary>
        /// MolPerCubicCentimeter -> mol/m^3
        /// 1 mol/cubic centimeter =  1000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MolPerCubicCentimeter_2_MolPerCubicMeter(double inVal)     => inVal * 1000000;
        /// <summary>
        /// mol/m^3 -> MolPerCubicCentimeter
        /// vv: 1000000 mol/cubic meter [mol/m^3] to 1 mol/cubic centimeter
        /// </summary>
        public static double MolPerCubicMeter_2_MolPerCubicCentimeter(double inVal)     => inVal / 1000000;

        /// <summary>
        /// MolPerCubicMillimeter -> mol/m^3
        /// 1 mol/cubic millimeter =  1000000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MolPerCubicMillimeter_2_MolPerCubicMeter(double inVal)     => inVal * 1000000000;
        /// <summary>
        /// mol/m^3 -> MolPerCubicMillimeter
        /// vv: 1000000000 mol/cubic meter [mol/m^3] to 1 mol/cubic millimeter
        /// </summary>
        public static double MolPerCubicMeter_2_MolPerCubicMillimeter(double inVal)     => inVal / 1000000000;

        /// <summary>
        /// KilomolPerCubicMeter -> mol/m^3
        /// 1 kilomol/cubic meter =  1000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double KilomolPerCubicMeter_2_MolPerCubicMeter(double inVal)      => inVal * 1000;
        /// <summary>
        /// mol/m^3 -> KilomolPerCubicMeter
        /// vv: 1000 mol/cubic meter [mol/m^3] to 1 kilomol/cubic meter
        /// </summary>
        public static double MolPerCubicMeter_2_KilomolPerCubicMeter(double inVal)      => inVal / 1000;

        /// <summary>
        /// kmol/L -> mol/m^3
        /// 1 kilomol/liter [kmol/L] =  1000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double KilomolPerLiter_2_MolPerCubicMeter(double inVal)           => inVal * 1000000;
        /// <summary>
        /// mol/m^3 -> kmol/L
        /// vv: 1000000 mol/cubic meter [mol/m^3] to 1 kilomol/liter [kmol/L]
        /// </summary>
        public static double MolPerCubicMeter_2_KilomolPerLiter(double inVal)           => inVal / 1000000;

        /// <summary>
        /// KilomolPerCubicCentimeter -> mol/m^3
        /// 1 kilomol/cubic centimeter =  1000000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double KilomolPerCubicCentimeter_2_MolPerCubicMeter(double inVal) => inVal * 1000000000;
        /// <summary>
        /// mol/m^3 -> KilomolPerCubicCentimeter
        /// vv: 1000000000 mol/cubic meter [mol/m^3] to 1 kilomol/cubic centimeter
        /// </summary>
        public static double MolPerCubicMeter_2_KilomolPerCubicCentimeter(double inVal) => inVal / 1000000000;

        /// <summary>
        /// KilomolPerCubicMillimeter -> mol/m^3
        /// 1 kilomol/cubic millimeter =  1000000000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double KilomolPerCubicMillimeter_2_MolPerCubicMeter(double inVal) => inVal * 1000000000000;
        /// <summary>
        /// mol/m^3 -> KilomolPerCubicMillimeter
        /// vv: 1000000000000 mol/cubic meter [mol/m^3] to 1 kilomol/cubic millimeter
        /// </summary>
        public static double MolPerCubicMeter_2_KilomolPerCubicMillimeter(double inVal) => inVal / 1000000000000;

        /// <summary>
        /// MillimolPerCubicMeter -> mol/m^3
        /// 1 millimol/cubic meter =  0.001 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MillimolPerCubicMeter_2_MolPerCubicMeter(double inVal)     => inVal * 0.001;
        /// <summary>
        /// mol/m^3 -> MillimolPerCubicMeter
        /// vv: 0.001 mol/cubic meter [mol/m^3] to 1 millimol/cubic meter
        /// </summary>
        public static double MolPerCubicMeter_2_MillimolPerCubicMeter(double inVal)     => inVal / 0.001;

        /// <summary>
        /// mmol/L -> mol/m^3
        /// 1 millimol/liter [mmol/L] =  1 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MillimolPerLiter_2_MolPerCubicMeter(double inVal)          => inVal * 1;
        /// <summary>
        /// mol/m^3 -> mmol/L
        /// vv: 1 mol/cubic meter [mol/m^3] to 1 millimol/liter [mmol/L]
        /// </summary>
        public static double MolPerCubicMeter_2_MillimolPerLiter(double inVal)          => inVal / 1;

        /// <summary>
        /// MillimolPerCubicCentimeter -> mol/m^3
        /// 1 millimol/cubic centimeter =  1000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MillimolPerCubicCentimeter_2_MolPerCubicMeter(double inVal)=> inVal * 1000;
        /// <summary>
        /// mol/m^3 -> MillimolPerCubicCentimeter
        /// vv: 1000 mol/cubic meter [mol/m^3] to 1 millimol/cubic centimeter
        /// </summary>
        public static double MolPerCubicMeter_2_MillimolPerCubicCentimeter(double inVal)=> inVal / 1000;

        /// <summary>
        /// MillimolPerCubicMillimeter -> mol/m^3
        /// 1 millimol/cubic millimeter =  1000000 mol/cubic meter [mol/m^3]
        /// </summary>
        public static double MillimolPerCubicMillimeter_2_MolPerCubicMeter(double inVal)=> inVal * 1000000;
        /// <summary>
        /// mol/m^3 -> MillimolPerCubicMillimeter
        /// vv: 1000000 mol/cubic meter [mol/m^3] to 1 millimol/cubic millimeter
        /// </summary>
        public static double MolPerCubicMeter_2_MillimolPerCubicMillimeter(double inVal)=> inVal / 1000000;

        #endregion

        #region concentration solution, base: kilogram/liter

        /// <summary>
        /// g/L -> kg/L
        /// 1 gram/liter [g/L] =  0.001 kilogram/liter [kg/L]
        /// </summary>
        public static double GramPerLiter_2_KilogramPerLiter(double inVal)              => inVal * 0.001;
        /// <summary>
        /// kg/L -> g/L
        /// vv: 0.001 kilogram/liter [kg/L] to 1 gram/liter [g/L]
        /// </summary>
        public static double KilogramPerLiter_2_GramPerLiter(double inVal)              => inVal / 0.001;

        /// <summary>
        /// mg/L -> kg/L
        /// 1 milligram/liter [mg/L] =  1.0E-6 kilogram/liter [kg/L]
        /// </summary>
        public static double MilligramPerLiter_2_KilogramPerLiter(double inVal)         => inVal * 1.0E-6;
        /// <summary>
        /// kg/L -> mg/L
        /// vv: 1.0E-6 kilogram/liter [kg/L] to 1 milligram/liter [mg/L]
        /// </summary>
        public static double KilogramPerLiter_2_MilligramPerLiter(double inVal)         => inVal / 1.0E-6;

        /// <summary>
        /// PartPerMillionPpm -> kg/L
        /// 1 part/million (ppm) =  9.988590003673E-7 kilogram/liter [kg/L]
        /// </summary>
        public static double PartPerMillionPpm_2_KilogramPerLiter(double inVal)         => inVal * 9.988590003673E-7;
        /// <summary>
        /// kg/L -> PartPerMillionPpm
        /// vv: 9.988590003673E-7 kilogram/liter [kg/L] to 1 part/million (ppm)
        /// </summary>
        public static double KilogramPerLiter_2_PartPerMillionPpm(double inVal)         => inVal / 9.988590003673E-7;

        /// <summary>
        /// gr/gal (US) -> kg/L
        /// 1 grain/gallon (US) [gr/gal (US)] =  1.71181E-5 kilogram/liter [kg/L]
        /// </summary>
        public static double GrainPerGallonUS_2_KilogramPerLiter(double inVal)          => inVal * 1.71181E-5;
        /// <summary>
        /// kg/L -> gr/gal (US)
        /// vv: 1.71181E-5 kilogram/liter [kg/L] to 1 grain/gallon (US) [gr/gal (US)]
        /// </summary>
        public static double KilogramPerLiter_2_GrainPerGallonUS(double inVal)          => inVal / 1.71181E-5;

        /// <summary>
        /// gr/gal (UK) -> kg/L
        /// 1 grain/gallon (UK) [gr/gal (UK)] =  1.42538E-5 kilogram/liter [kg/L]
        /// </summary>
        public static double GrainPerGallonUK_2_KilogramPerLiter(double inVal)          => inVal * 1.42538E-5;
        /// <summary>
        /// kg/L -> gr/gal (UK)
        /// vv: 1.42538E-5 kilogram/liter [kg/L] to 1 grain/gallon (UK) [gr/gal (UK)]
        /// </summary>
        public static double KilogramPerLiter_2_GrainPerGallonUK(double inVal)          => inVal / 1.42538E-5;

        /// <summary>
        /// PoundPerGallonUS -> kg/L
        /// 1 pound/gallon (US) =  0.1198264284 kilogram/liter [kg/L]
        /// </summary>
        public static double PoundPerGallonUS_2_KilogramPerLiter(double inVal)          => inVal * 0.1198264284;
        /// <summary>
        /// kg/L -> PoundPerGallonUS
        /// vv: 0.1198264284 kilogram/liter [kg/L] to 1 pound/gallon (US)
        /// </summary>
        public static double KilogramPerLiter_2_PoundPerGallonUS(double inVal)          => inVal / 0.1198264284;

        /// <summary>
        /// PoundPerGallonUK -> kg/L
        /// 1 pound/gallon (UK) =  0.0997763736 kilogram/liter [kg/L]
        /// </summary>
        public static double PoundPerGallonUK_2_KilogramPerLiter(double inVal)          => inVal * 0.0997763736;
        /// <summary>
        /// kg/L -> PoundPerGallonUK
        /// vv: 0.0997763736 kilogram/liter [kg/L] to 1 pound/gallon (UK)
        /// </summary>
        public static double KilogramPerLiter_2_PoundPerGallonUK(double inVal)          => inVal / 0.0997763736;

        /// <summary>
        /// PoundPerMillionGallonUS -> kg/L
        /// 1 pound/million gallon (US) =  1.1982642843713E-7 kilogram/liter [kg/L]
        /// </summary>
        public static double PoundPerMillionGallonUS_2_KilogramPerLiter(double inVal)   => inVal * 1.1982642843713E-7;
        /// <summary>
        /// kg/L -> PoundPerMillionGallonUS
        /// vv: 1.1982642843713E-7 kilogram/liter [kg/L] to 1 pound/million gallon (US)
        /// </summary>
        public static double KilogramPerLiter_2_PoundPerMillionGallonUS(double inVal)   => inVal / 1.1982642843713E-7;

        /// <summary>
        /// PoundPerMillionGallonUK -> kg/L
        /// 1 pound/million gallon (UK) =  9.9776373608464E-8 kilogram/liter [kg/L]
        /// </summary>
        public static double PoundPerMillionGallonUK_2_KilogramPerLiter(double inVal)   => inVal * 9.9776373608464E-8;
        /// <summary>
        /// kg/L -> PoundPerMillionGallonUK
        /// vv: 9.9776373608464E-8 kilogram/liter [kg/L] to 1 pound/million gallon (UK)
        /// </summary>
        public static double KilogramPerLiter_2_PoundPerMillionGallonUK(double inVal)   => inVal / 9.9776373608464E-8;

        /// <summary>
        /// lb/ft^3 -> kg/L
        /// 1 pound/cubic foot [lb/ft^3] =  0.0160184635 kilogram/liter [kg/L]
        /// </summary>
        public static double PoundPerCubicFoot_2_KilogramPerLiter(double inVal)         => inVal * 0.0160184635;
        /// <summary>
        /// kg/L -> lb/ft^3
        /// vv: 0.0160184635 kilogram/liter [kg/L] to 1 pound/cubic foot [lb/ft^3]
        /// </summary>
        public static double KilogramPerLiter_2_PoundPerCubicFoot(double inVal)         => inVal / 0.0160184635;

        #endregion

    }
}
