
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region data storage , base: bit

        /// <summary>
        /// Nibble -> b
        /// 1 nibble to vv: 4 bit [b]
        /// </summary>
        public static double Nibble_2_Bit(double inVal)                                 => inVal * 4;
        /// <summary>
        /// b -> Nibble
        /// vv: 4 bit [b] to 1 nibble
        /// </summary>
        public static double Bit_2_Nibble(double inVal)                                 => inVal / 4;

        /// <summary>
        /// B -> b
        /// 1 byte [B] to vv: 8 bit [b]
        /// </summary>
        public static double Byte_2_Bit(double inVal)                                   => inVal * 8;
        /// <summary>
        /// b -> B
        /// vv: 8 bit [b] to 1 byte [B]
        /// </summary>
        public static double Bit_2_Byte(double inVal)                                   => inVal / 8;

        /// <summary>
        /// Character -> b
        /// 1 character to vv: 8 bit [b]
        /// </summary>
        public static double Character_2_Bit(double inVal)                              => inVal * 8;
        /// <summary>
        /// b -> Character
        /// vv: 8 bit [b] to 1 character
        /// </summary>
        public static double Bit_2_Character(double inVal)                              => inVal / 8;

        /// <summary>
        /// Word -> b
        /// 1 word to vv: 16 bit [b]
        /// </summary>
        public static double Word_2_Bit(double inVal)                                   => inVal * 16;
        /// <summary>
        /// b -> Word
        /// vv: 16 bit [b] to 1 word
        /// </summary>
        public static double Bit_2_Word(double inVal)                                   => inVal / 16;

        /// <summary>
        /// MAPMWord -> b
        /// 1 MAPM-word to vv: 32 bit [b]
        /// </summary>
        public static double MAPMWord_2_Bit(double inVal)                               => inVal * 32;
        /// <summary>
        /// b -> MAPMWord
        /// vv: 32 bit [b] to 1 MAPM-word
        /// </summary>
        public static double Bit_2_MAPMWord(double inVal)                               => inVal / 32;

        /// <summary>
        /// QuadrupleWord -> b
        /// 1 quadruple-word to vv: 64 bit [b]
        /// </summary>
        public static double QuadrupleWord_2_Bit(double inVal)                          => inVal * 64;
        /// <summary>
        /// b -> QuadrupleWord
        /// vv: 64 bit [b] to 1 quadruple-word
        /// </summary>
        public static double Bit_2_QuadrupleWord(double inVal)                          => inVal / 64;

        /// <summary>
        /// Block -> b
        /// 1 block to vv: 4096 bit [b]
        /// </summary>
        public static double Block_2_Bit(double inVal)                                  => inVal * 4096;
        /// <summary>
        /// b -> Block
        /// vv: 4096 bit [b] to 1 block
        /// </summary>
        public static double Bit_2_Block(double inVal)                                  => inVal / 4096;

        /// <summary>
        /// kb -> b
        /// 1 kilobit [kb] to vv: 1024 bit [b]
        /// </summary>
        public static double Kilobit_2_Bit(double inVal)                                => inVal * 1024;
        /// <summary>
        /// b -> kb
        /// vv: 1024 bit [b] to 1 kilobit [kb]
        /// </summary>
        public static double Bit_2_Kilobit(double inVal)                                => inVal / 1024;

        /// <summary>
        /// kB -> b
        /// 1 kilobyte [kB] to vv: 8192 bit [b]
        /// </summary>
        public static double Kilobyte_2_Bit(double inVal)                               => inVal * 8192;
        /// <summary>
        /// b -> kB
        /// vv: 8192 bit [b] to 1 kilobyte [kB]
        /// </summary>
        public static double Bit_2_Kilobyte(double inVal)                               => inVal / 8192;

        /// <summary>
        /// Kilobyte10^3Bytes -> b
        /// 1 kilobyte (10^3 bytes) to vv: 8000 bit [b]
        /// </summary>
        public static double KilobyteBytes_2_Bit(double inVal)                      => inVal * 8000;
        /// <summary>
        /// b -> Kilobyte10^3Bytes
        /// vv: 8000 bit [b] to 1 kilobyte (10^3 bytes)
        /// </summary>
        public static double Bit_2_KilobyteBytes(double inVal)                      => inVal / 8000;

        /// <summary>
        /// Mb -> b
        /// 1 megabit [Mb] to vv: 1048576 bit [b]
        /// </summary>
        public static double Megabit_2_Bit(double inVal)                                => inVal * 1048576;
        /// <summary>
        /// b -> Mb
        /// vv: 1048576 bit [b] to 1 megabit [Mb]
        /// </summary>
        public static double Bit_2_Megabit(double inVal)                                => inVal / 1048576;

        /// <summary>
        /// MB -> b
        /// 1 megabyte [MB] to vv: 8388608 bit [b]
        /// </summary>
        public static double Megabyte_2_Bit(double inVal)                               => inVal * 8388608;
        /// <summary>
        /// b -> MB
        /// vv: 8388608 bit [b] to 1 megabyte [MB]
        /// </summary>
        public static double Bit_2_Megabyte(double inVal)                               => inVal / 8388608;

        /// <summary>
        /// Megabyte10^6Bytes -> b
        /// 1 megabyte (10^6 bytes) to vv: 8000000 bit [b]
        /// </summary>
        public static double MegabyteBytes_2_Bit(double inVal)                      => inVal * 8000000;
        /// <summary>
        /// b -> Megabyte10^6Bytes
        /// vv: 8000000 bit [b] to 1 megabyte (10^6 bytes)
        /// </summary>
        public static double Bit_2_MegabyteBytes(double inVal)                      => inVal / 8000000;

        /// <summary>
        /// Gb -> b
        /// 1 gigabit [Gb] to vv: 1073741824 bit [b]
        /// </summary>
        public static double Gigabit_2_Bit(double inVal)                                => inVal * 1073741824;
        /// <summary>
        /// b -> Gb
        /// vv: 1073741824 bit [b] to 1 gigabit [Gb]
        /// </summary>
        public static double Bit_2_Gigabit(double inVal)                                => inVal / 1073741824;

        /// <summary>
        /// GB -> b
        /// 1 gigabyte [GB] to vv: 8589934592 bit [b]
        /// </summary>
        public static double Gigabyte_2_Bit(double inVal)                               => inVal * 8589934592;
        /// <summary>
        /// b -> GB
        /// vv: 8589934592 bit [b] to 1 gigabyte [GB]
        /// </summary>
        public static double Bit_2_Gigabyte(double inVal)                               => inVal / 8589934592;

        /// <summary>
        /// Gigabyte10^9Bytes -> b
        /// 1 gigabyte (10^9 bytes) to vv: 8000000000 bit [b]
        /// </summary>
        public static double GigabyteBytes_2_Bit(double inVal)                      => inVal * 8000000000;
        /// <summary>
        /// b -> Gigabyte10^9Bytes
        /// vv: 8000000000 bit [b] to 1 gigabyte (10^9 bytes)
        /// </summary>
        public static double Bit_2_GigabyteBytes(double inVal)                      => inVal / 8000000000;

        /// <summary>
        /// Tb -> b
        /// 1 terabit [Tb] to vv: 1099511627776 bit [b]
        /// </summary>
        public static double Terabit_2_Bit(double inVal)                                => inVal * 1099511627776;
        /// <summary>
        /// b -> Tb
        /// vv: 1099511627776 bit [b] to 1 terabit [Tb]
        /// </summary>
        public static double Bit_2_Terabit(double inVal)                                => inVal / 1099511627776;

        /// <summary>
        /// TB -> b
        /// 1 terabyte [TB] to vv: 8796093022208 bit [b]
        /// </summary>
        public static double Terabyte_2_Bit(double inVal)                               => inVal * 8796093022208;
        /// <summary>
        /// b -> TB
        /// vv: 8796093022208 bit [b] to 1 terabyte [TB]
        /// </summary>
        public static double Bit_2_Terabyte(double inVal)                               => inVal / 8796093022208;

        /// <summary>
        /// Terabyte10^12Bytes -> b
        /// 1 terabyte (10^12 bytes) to vv: 8000000000000 bit [b]
        /// </summary>
        public static double TerabyteBytes_2_Bit(double inVal)                     => inVal * 8000000000000;
        /// <summary>
        /// b -> Terabyte10^12Bytes
        /// vv: 8000000000000 bit [b] to 1 terabyte (10^12 bytes)
        /// </summary>
        public static double Bit_2_TerabyteBytes(double inVal)                     => inVal / 8000000000000;

        /// <summary>
        /// Pb -> b
        /// 1 petabit [Pb] to vv: 1.1258999068426E+15 bit [b]
        /// </summary>
        public static double Petabit_2_Bit(double inVal)                                => inVal * 1.1258999068426E+15;
        /// <summary>
        /// b -> Pb
        /// vv: 1.1258999068426E+15 bit [b] to 1 petabit [Pb]
        /// </summary>
        public static double Bit_2_Petabit(double inVal)                                => inVal / 1.1258999068426E+15;

        /// <summary>
        /// PB -> b
        /// 1 petabyte [PB] to vv: 9.007199254741E+15 bit [b]
        /// </summary>
        public static double Petabyte_2_Bit(double inVal)                               => inVal * 9.007199254741E+15;
        /// <summary>
        /// b -> PB
        /// vv: 9.007199254741E+15 bit [b] to 1 petabyte [PB]
        /// </summary>
        public static double Bit_2_Petabyte(double inVal)                               => inVal / 9.007199254741E+15;

        /// <summary>
        /// Petabyte10^15Bytes -> b
        /// 1 petabyte (10^15 bytes) to vv: 8.0E+15 bit [b]
        /// </summary>
        public static double PetabyteBytes_2_Bit(double inVal)                     => inVal * 8.0E+15;
        /// <summary>
        /// b -> Petabyte10^15Bytes
        /// vv: 8.0E+15 bit [b] to 1 petabyte (10^15 bytes)
        /// </summary>
        public static double Bit_2_PetabyteBytes(double inVal)                     => inVal / 8.0E+15;

        /// <summary>
        /// Eb -> b
        /// 1 exabit [Eb] to vv: 1.1529215046068E+18 bit [b]
        /// </summary>
        public static double Exabit_2_Bit(double inVal)                                 => inVal * 1.1529215046068E+18;
        /// <summary>
        /// b -> Eb
        /// vv: 1.1529215046068E+18 bit [b] to 1 exabit [Eb]
        /// </summary>
        public static double Bit_2_Exabit(double inVal)                                 => inVal / 1.1529215046068E+18;

        /// <summary>
        /// EB -> b
        /// 1 exabyte [EB] to vv: 9.2233720368548E+18 bit [b]
        /// </summary>
        public static double Exabyte_2_Bit(double inVal)                                => inVal * 9.2233720368548E+18;
        /// <summary>
        /// b -> EB
        /// vv: 9.2233720368548E+18 bit [b] to 1 exabyte [EB]
        /// </summary>
        public static double Bit_2_Exabyte(double inVal)                                => inVal / 9.2233720368548E+18;

        /// <summary>
        /// Exabyte10^18Bytes -> b
        /// 1 exabyte (10^18 bytes) to vv: 8.0E+18 bit [b]
        /// </summary>
        public static double ExabyteBytes_2_Bit(double inVal)                      => inVal * 8.0E+18;
        /// <summary>
        /// b -> Exabyte10^18Bytes
        /// vv: 8.0E+18 bit [b] to 1 exabyte (10^18 bytes)
        /// </summary>
        public static double Bit_2_ExabyteBytes(double inVal)                      => inVal / 8.0E+18;

        /// <summary>
        /// FloppyDisk3.5",DD -> b
        /// 1 floppy disk (3.5", DD) to vv: 5830656 bit [b]
        /// </summary>
        public static double FloppyDisk35ZollDD_2_Bit(double inVal)                      => inVal * 5830656;
        /// <summary>
        /// b -> FloppyDisk3.5",DD
        /// vv: 5830656 bit [b] to 1 floppy disk (3.5", DD)
        /// </summary>
        public static double Bit_2_FloppyDisk35ZollDD(double inVal)                      => inVal / 5830656;

        /// <summary>
        /// FloppyDisk3.5",HD -> b
        /// 1 floppy disk (3.5", HD) to vv: 11661312 bit [b]
        /// </summary>
        public static double FloppyDisk35ZollHD_2_Bit(double inVal)                      => inVal * 11661312;
        /// <summary>
        /// b -> FloppyDisk3.5",HD
        /// vv: 11661312 bit [b] to 1 floppy disk (3.5", HD)
        /// </summary>
        public static double Bit_2_FloppyDisk35ZollHD(double inVal)                      => inVal / 11661312;

        /// <summary>
        /// FloppyDisk3.5",ED -> b
        /// 1 floppy disk (3.5", ED) to vv: 23322624 bit [b]
        /// </summary>
        public static double FloppyDisk35ZollED_2_Bit(double inVal)                      => inVal * 23322624;
        /// <summary>
        /// b -> FloppyDisk3.5",ED
        /// vv: 23322624 bit [b] to 1 floppy disk (3.5", ED)
        /// </summary>
        public static double Bit_2_FloppyDisk35TollED(double inVal)                      => inVal / 23322624;

        /// <summary>
        /// FloppyDisk5.25",DD -> b
        /// 1 floppy disk (5.25", DD) to vv: 2915328 bit [b]
        /// </summary>
        public static double FloppyDisk525ZollDD_2_Bit(double inVal)                     => inVal * 2915328;
        /// <summary>
        /// b -> FloppyDisk5.25",DD
        /// vv: 2915328 bit [b] to 1 floppy disk (5.25", DD)
        /// </summary>
        public static double Bit_2_FloppyDisk525ZollDD(double inVal)                     => inVal / 2915328;

        /// <summary>
        /// FloppyDisk5.25",HD -> b
        /// 1 floppy disk (5.25", HD) to vv: 9711616 bit [b]
        /// </summary>
        public static double FloppyDisk525ZollHD_2_Bit(double inVal)                     => inVal * 9711616;
        /// <summary>
        /// b -> FloppyDisk5.25",HD
        /// vv: 9711616 bit [b] to 1 floppy disk (5.25", HD)
        /// </summary>
        public static double Bit_2_FloppyDisk525ZollHD(double inVal)                     => inVal / 9711616;

        /// <summary>
        /// Zip100 -> b
        /// 1 Zip 100 to vv: 803454976 bit [b]
        /// </summary>
        public static double Zip100_2_Bit(double inVal)                                 => inVal * 803454976;
        /// <summary>
        /// b -> Zip100
        /// vv: 803454976 bit [b] to 1 Zip 100
        /// </summary>
        public static double Bit_2_Zip100(double inVal)                                 => inVal / 803454976;

        /// <summary>
        /// Zip250 -> b
        /// 1 Zip 250 to vv: 2008637440 bit [b]
        /// </summary>
        public static double Zip250_2_Bit(double inVal)                                 => inVal * 2008637440;
        /// <summary>
        /// b -> Zip250
        /// vv: 2008637440 bit [b] to 1 Zip 250
        /// </summary>
        public static double Bit_2_Zip250(double inVal)                                 => inVal / 2008637440;

        /// <summary>
        /// Jaz1GB -> b
        /// 1 Jaz 1GB to vv: 8589934592 bit [b]
        /// </summary>
        public static double Jaz1GB_2_Bit(double inVal)                                 => inVal * 8589934592;
        /// <summary>
        /// b -> Jaz1GB
        /// vv: 8589934592 bit [b] to 1 Jaz 1GB
        /// </summary>
        public static double Bit_2_Jaz1GB(double inVal)                                 => inVal / 8589934592;

        /// <summary>
        /// Jaz2GB -> b
        /// 1 Jaz 2GB to vv: 17179869184 bit [b]
        /// </summary>
        public static double Jaz2GB_2_Bit(double inVal)                                 => inVal * 17179869184;
        /// <summary>
        /// b -> Jaz2GB
        /// vv: 17179869184 bit [b] to 1 Jaz 2GB
        /// </summary>
        public static double Bit_2_Jaz2GB(double inVal)                                 => inVal / 17179869184;

        /// <summary>
        /// CD74Minute -> b
        /// 1 CD (74 minute) to vv: 5448466432 bit [b]
        /// </summary>
        public static double CD74Minute_2_Bit(double inVal)                             => inVal * 5448466432;
        /// <summary>
        /// b -> CD74Minute
        /// vv: 5448466432 bit [b] to 1 CD (74 minute)
        /// </summary>
        public static double Bit_2_CD74Minute(double inVal)                             => inVal / 5448466432;

        /// <summary>
        /// CD80Minute -> b
        /// 1 CD (80 minute) to vv: 5890233976 bit [b]
        /// </summary>
        public static double CD80Minute_2_Bit(double inVal)                             => inVal * 5890233976;
        /// <summary>
        /// b -> CD80Minute
        /// vv: 5890233976 bit [b] to 1 CD (80 minute)
        /// </summary>
        public static double Bit_2_CD80Minute(double inVal)                             => inVal / 5890233976;

        /// <summary>
        /// DVD1Layer,1Side -> b
        /// 1 DVD (1 layer, 1 side) to vv: 40372692582.4 bit [b]
        /// </summary>
        public static double DVD1Layer1Side_2_Bit(double inVal)                        => inVal * 40372692582.4;
        /// <summary>
        /// b -> DVD1Layer,1Side
        /// vv: 40372692582.4 bit [b] to 1 DVD (1 layer, 1 side)
        /// </summary>
        public static double Bit_2_DVD1Layer1Side(double inVal)                        => inVal / 40372692582.4;

        /// <summary>
        /// DVD2Layer,1Side -> b
        /// 1 DVD (2 layer, 1 side) to vv: 73014444032 bit [b]
        /// </summary>
        public static double DVD2Layer1Side_2_Bit(double inVal)                        => inVal * 73014444032;
        /// <summary>
        /// b -> DVD2Layer,1Side
        /// vv: 73014444032 bit [b] to 1 DVD (2 layer, 1 side)
        /// </summary>
        public static double Bit_2_DVD2Layer1Side(double inVal)                        => inVal / 73014444032;

        /// <summary>
        /// DVD1Layer,2Side -> b
        /// 1 DVD (1 layer, 2 side) to vv: 80745385164.8 bit [b]
        /// </summary>
        public static double DVD1Layer2Side_2_Bit(double inVal)                        => inVal * 80745385164.8;
        /// <summary>
        /// b -> DVD1Layer,2Side
        /// vv: 80745385164.8 bit [b] to 1 DVD (1 layer, 2 side)
        /// </summary>
        public static double Bit_2_DVD1Layer2Side(double inVal)                        => inVal / 80745385164.8;

        /// <summary>
        /// DVD2Layer,2Side -> b
        /// 1 DVD (2 layer, 2 side) to vv: 146028888064 bit [b]
        /// </summary>
        public static double DVD2Layer2Side_2_Bit(double inVal)                        => inVal * 146028888064;
        /// <summary>
        /// b -> DVD2Layer,2Side
        /// vv: 146028888064 bit [b] to 1 DVD (2 layer, 2 side)
        /// </summary>
        public static double Bit_2_DVD2Layer2Side(double inVal)                        => inVal / 146028888064;

        #endregion
    }
}
