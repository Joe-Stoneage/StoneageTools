
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region sound, base: bel

        /// <summary>
        /// dB -> B
        /// 1 decibel [dB] to vv: 0.1 bel [B]
        /// </summary>
        public static double Decibel_2_Bel(double inVal)                                => inVal * 0.1;
        /// <summary>
        /// B -> dB
        /// vv: 0.1 bel [B] to 1 decibel [dB]
        /// </summary>
        public static double Bel_2_Decibel(double inVal)                                => inVal / 0.1;

        /// <summary>
        /// Np -> B
        /// 1 neper [Np] to vv: 0.8686000004 bel [B]
        /// </summary>
        public static double Neper_2_Bel(double inVal)                                  => inVal * 0.8686000004;
        /// <summary>
        /// B -> Np
        /// vv: 0.8686000004 bel [B] to 1 neper [Np]
        /// </summary>
        public static double Bel_2_Neper(double inVal)                                  => inVal / 0.8686000004;
        #endregion
    }
}
