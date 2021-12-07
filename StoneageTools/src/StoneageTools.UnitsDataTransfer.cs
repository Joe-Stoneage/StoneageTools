
// Reference: https://www.unitconverters.net/

namespace StoneageTools.Units
{
    public static partial class StoneageToolsUnits
    {
        #region data transfer, base: bit/second

        /// <summary>
        /// B/s -> b/s
        /// 1 byte/second [B/s] to vv: 8 bit/second [b/s]
        /// </summary>
        public static double BytePerSecond_2_BitPerSecond(double inVal)                 => inVal * 8;
        /// <summary>
        /// b/s -> B/s
        /// vv: 8 bit/second [b/s] to 1 byte/second [B/s]
        /// </summary>
        public static double BitPerSecond_2_BytePerSecond(double inVal)                 => inVal / 8;

        /// <summary>
        /// KilobitPerSecondSIDef. -> b/s
        /// 1 kilobit/second (SI def.) to vv: 1000 bit/second [b/s]
        /// </summary>
        public static double KilobitPerSecondSIDef_2_BitPerSecond(double inVal)         => inVal * 1000;
        /// <summary>
        /// b/s -> KilobitPerSecondSIDef.
        /// vv: 1000 bit/second [b/s] to 1 kilobit/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_KilobitPerSecondSIDef(double inVal)         => inVal / 1000;

        /// <summary>
        /// KilobytePerSecondSIDef. -> b/s
        /// 1 kilobyte/second (SI def.) to vv: 8000 bit/second [b/s]
        /// </summary>
        public static double KilobytePerSecondSIDef_2_BitPerSecond(double inVal)        => inVal * 8000;
        /// <summary>
        /// b/s -> KilobytePerSecondSIDef.
        /// vv: 8000 bit/second [b/s] to 1 kilobyte/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_KilobytePerSecondSIDef(double inVal)        => inVal / 8000;

        /// <summary>
        /// kb/s -> b/s
        /// 1 kilobit/second [kb/s] to vv: 1024 bit/second [b/s]
        /// </summary>
        public static double KilobitPerSecond_2_BitPerSecond(double inVal)              => inVal * 1024;
        /// <summary>
        /// b/s -> kb/s
        /// vv: 1024 bit/second [b/s] to 1 kilobit/second [kb/s]
        /// </summary>
        public static double BitPerSecond_2_KilobitPerSecond(double inVal)              => inVal / 1024;

        /// <summary>
        /// kB/s -> b/s
        /// 1 kilobyte/second [kB/s] to vv: 8192 bit/second [b/s]
        /// </summary>
        public static double KilobytePerSecond_2_BitPerSecond(double inVal)             => inVal * 8192;
        /// <summary>
        /// b/s -> kB/s
        /// vv: 8192 bit/second [b/s] to 1 kilobyte/second [kB/s]
        /// </summary>
        public static double BitPerSecond_2_KilobytePerSecond(double inVal)             => inVal / 8192;

        /// <summary>
        /// MegabitPerSecondSIDef. -> b/s
        /// 1 megabit/second (SI def.) to vv: 1000000 bit/second [b/s]
        /// </summary>
        public static double MegabitPerSecondSIDef_2_BitPerSecond(double inVal)         => inVal * 1000000;
        /// <summary>
        /// b/s -> MegabitPerSecondSIDef.
        /// vv: 1000000 bit/second [b/s] to 1 megabit/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_MegabitPerSecondSIDef(double inVal)         => inVal / 1000000;

        /// <summary>
        /// MegabytePerSecondSIDef. -> b/s
        /// 1 megabyte/second (SI def.) to vv: 8000000 bit/second [b/s]
        /// </summary>
        public static double MegabytePerSecondSIDef_2_BitPerSecond(double inVal)        => inVal * 8000000;
        /// <summary>
        /// b/s -> MegabytePerSecondSIDef.
        /// vv: 8000000 bit/second [b/s] to 1 megabyte/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_MegabytePerSecondSIDef(double inVal)        => inVal / 8000000;

        /// <summary>
        /// Mb/s -> b/s
        /// 1 megabit/second [Mb/s] to vv: 1048576 bit/second [b/s]
        /// </summary>
        public static double MegabitPerSecond_2_BitPerSecond(double inVal)              => inVal * 1048576;
        /// <summary>
        /// b/s -> Mb/s
        /// vv: 1048576 bit/second [b/s] to 1 megabit/second [Mb/s]
        /// </summary>
        public static double BitPerSecond_2_MegabitPerSecond(double inVal)              => inVal / 1048576;

        /// <summary>
        /// MB/s -> b/s
        /// 1 megabyte/second [MB/s] to vv: 8388608 bit/second [b/s]
        /// </summary>
        public static double MegabytePerSecond_2_BitPerSecond(double inVal)             => inVal * 8388608;
        /// <summary>
        /// b/s -> MB/s
        /// vv: 8388608 bit/second [b/s] to 1 megabyte/second [MB/s]
        /// </summary>
        public static double BitPerSecond_2_MegabytePerSecond(double inVal)             => inVal / 8388608;

        /// <summary>
        /// GigabitPerSecondSIDef. -> b/s
        /// 1 gigabit/second (SI def.) to vv: 1000000000 bit/second [b/s]
        /// </summary>
        public static double GigabitPerSecondSIDef_2_BitPerSecond(double inVal)         => inVal * 1000000000;
        /// <summary>
        /// b/s -> GigabitPerSecondSIDef.
        /// vv: 1000000000 bit/second [b/s] to 1 gigabit/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_GigabitPerSecondSIDef(double inVal)         => inVal / 1000000000;

        /// <summary>
        /// GigabytePerSecondSIDef. -> b/s
        /// 1 gigabyte/second (SI def.) to vv: 8000000000 bit/second [b/s]
        /// </summary>
        public static double GigabytePerSecondSIDef_2_BitPerSecond(double inVal)        => inVal * 8000000000;
        /// <summary>
        /// b/s -> GigabytePerSecondSIDef.
        /// vv: 8000000000 bit/second [b/s] to 1 gigabyte/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_GigabytePerSecondSIDef(double inVal)        => inVal / 8000000000;

        /// <summary>
        /// Gb/s -> b/s
        /// 1 gigabit/second [Gb/s] to vv: 1073741824 bit/second [b/s]
        /// </summary>
        public static double GigabitPerSecond_2_BitPerSecond(double inVal)              => inVal * 1073741824;
        /// <summary>
        /// b/s -> Gb/s
        /// vv: 1073741824 bit/second [b/s] to 1 gigabit/second [Gb/s]
        /// </summary>
        public static double BitPerSecond_2_GigabitPerSecond(double inVal)              => inVal / 1073741824;

        /// <summary>
        /// GB/s -> b/s
        /// 1 gigabyte/second [GB/s] to vv: 8589934592 bit/second [b/s]
        /// </summary>
        public static double GigabytePerSecond_2_BitPerSecond(double inVal)             => inVal * 8589934592;
        /// <summary>
        /// b/s -> GB/s
        /// vv: 8589934592 bit/second [b/s] to 1 gigabyte/second [GB/s]
        /// </summary>
        public static double BitPerSecond_2_GigabytePerSecond(double inVal)             => inVal / 8589934592;

        /// <summary>
        /// TerabitPerSecondSIDef. -> b/s
        /// 1 terabit/second (SI def.) to vv: 1000000000000 bit/second [b/s]
        /// </summary>
        public static double TerabitPerSecondSIDef_2_BitPerSecond(double inVal)         => inVal * 1000000000000;
        /// <summary>
        /// b/s -> TerabitPerSecondSIDef.
        /// vv: 1000000000000 bit/second [b/s] to 1 terabit/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_TerabitPerSecondSIDef(double inVal)         => inVal / 1000000000000;

        /// <summary>
        /// TerabytePerSecondSIDef. -> b/s
        /// 1 terabyte/second (SI def.) to vv: 8000000000000 bit/second [b/s]
        /// </summary>
        public static double TerabytePerSecondSIDef_2_BitPerSecond(double inVal)        => inVal * 8000000000000;
        /// <summary>
        /// b/s -> TerabytePerSecondSIDef.
        /// vv: 8000000000000 bit/second [b/s] to 1 terabyte/second (SI def.)
        /// </summary>
        public static double BitPerSecond_2_TerabytePerSecondSIDef(double inVal)        => inVal / 8000000000000;

        /// <summary>
        /// Tb/s -> b/s
        /// 1 terabit/second [Tb/s] to vv: 1099511627776 bit/second [b/s]
        /// </summary>
        public static double TerabitPerSecond_2_BitPerSecond(double inVal)              => inVal * 1099511627776;
        /// <summary>
        /// b/s -> Tb/s
        /// vv: 1099511627776 bit/second [b/s] to 1 terabit/second [Tb/s]
        /// </summary>
        public static double BitPerSecond_2_TerabitPerSecond(double inVal)              => inVal / 1099511627776;

        /// <summary>
        /// TB/s -> b/s
        /// 1 terabyte/second [TB/s] to vv: 8796093022208 bit/second [b/s]
        /// </summary>
        public static double TerabytePerSecond_2_BitPerSecond(double inVal)             => inVal * 8796093022208;
        /// <summary>
        /// b/s -> TB/s
        /// vv: 8796093022208 bit/second [b/s] to 1 terabyte/second [TB/s]
        /// </summary>
        public static double BitPerSecond_2_TerabytePerSecond(double inVal)             => inVal / 8796093022208;

        /// <summary>
        /// Ethernet -> b/s
        /// 1 ethernet to vv: 10000000 bit/second [b/s]
        /// </summary>
        public static double Ethernet_2_BitPerSecond(double inVal)                      => inVal * 10000000;
        /// <summary>
        /// b/s -> Ethernet
        /// vv: 10000000 bit/second [b/s] to 1 ethernet
        /// </summary>
        public static double BitPerSecond_2_Ethernet(double inVal)                      => inVal / 10000000;

        /// <summary>
        /// EthernetFast -> b/s
        /// 1 ethernet (fast) to vv: 100000000 bit/second [b/s]
        /// </summary>
        public static double EthernetFast_2_BitPerSecond(double inVal)                  => inVal * 100000000;
        /// <summary>
        /// b/s -> EthernetFast
        /// vv: 100000000 bit/second [b/s] to 1 ethernet (fast)
        /// </summary>
        public static double BitPerSecond_2_EthernetFast(double inVal)                  => inVal / 100000000;

        /// <summary>
        /// EthernetGigabit -> b/s
        /// 1 ethernet (gigabit) to vv: 1000000000 bit/second [b/s]
        /// </summary>
        public static double EthernetGigabit_2_BitPerSecond(double inVal)               => inVal * 1000000000;
        /// <summary>
        /// b/s -> EthernetGigabit
        /// vv: 1000000000 bit/second [b/s] to 1 ethernet (gigabit)
        /// </summary>
        public static double BitPerSecond_2_EthernetGigabit(double inVal)               => inVal / 1000000000;

        /// <summary>
        /// OC1 -> b/s
        /// 1 OC1 to vv: 51840000 bit/second [b/s]
        /// </summary>
        public static double OC1_2_BitPerSecond(double inVal)                           => inVal * 51840000;
        /// <summary>
        /// b/s -> OC1
        /// vv: 51840000 bit/second [b/s] to 1 OC1
        /// </summary>
        public static double BitPerSecond_2_OC1(double inVal)                           => inVal / 51840000;

        /// <summary>
        /// OC3 -> b/s
        /// 1 OC3 to vv: 155520000 bit/second [b/s]
        /// </summary>
        public static double OC3_2_BitPerSecond(double inVal)                           => inVal * 155520000;
        /// <summary>
        /// b/s -> OC3
        /// vv: 155520000 bit/second [b/s] to 1 OC3
        /// </summary>
        public static double BitPerSecond_2_OC3(double inVal)                           => inVal / 155520000;

        /// <summary>
        /// OC12 -> b/s
        /// 1 OC12 to vv: 622080000 bit/second [b/s]
        /// </summary>
        public static double OC12_2_BitPerSecond(double inVal)                          => inVal * 622080000;
        /// <summary>
        /// b/s -> OC12
        /// vv: 622080000 bit/second [b/s] to 1 OC12
        /// </summary>
        public static double BitPerSecond_2_OC12(double inVal)                          => inVal / 622080000;

        /// <summary>
        /// OC24 -> b/s
        /// 1 OC24 to vv: 1244160000 bit/second [b/s]
        /// </summary>
        public static double OC24_2_BitPerSecond(double inVal)                          => inVal * 1244160000;
        /// <summary>
        /// b/s -> OC24
        /// vv: 1244160000 bit/second [b/s] to 1 OC24
        /// </summary>
        public static double BitPerSecond_2_OC24(double inVal)                          => inVal / 1244160000;

        /// <summary>
        /// OC48 -> b/s
        /// 1 OC48 to vv: 2488320000 bit/second [b/s]
        /// </summary>
        public static double OC48_2_BitPerSecond(double inVal)                          => inVal * 2488320000;
        /// <summary>
        /// b/s -> OC48
        /// vv: 2488320000 bit/second [b/s] to 1 OC48
        /// </summary>
        public static double BitPerSecond_2_OC48(double inVal)                          => inVal / 2488320000;

        /// <summary>
        /// OC192 -> b/s
        /// 1 OC192 to vv: 9953280000 bit/second [b/s]
        /// </summary>
        public static double OC192_2_BitPerSecond(double inVal)                         => inVal * 9953280000;
        /// <summary>
        /// b/s -> OC192
        /// vv: 9953280000 bit/second [b/s] to 1 OC192
        /// </summary>
        public static double BitPerSecond_2_OC192(double inVal)                         => inVal / 9953280000;

        /// <summary>
        /// OC768 -> b/s
        /// 1 OC768 to vv: 39813120000 bit/second [b/s]
        /// </summary>
        public static double OC768_2_BitPerSecond(double inVal)                         => inVal * 39813120000;
        /// <summary>
        /// b/s -> OC768
        /// vv: 39813120000 bit/second [b/s] to 1 OC768
        /// </summary>
        public static double BitPerSecond_2_OC768(double inVal)                         => inVal / 39813120000;

        /// <summary>
        /// ISDNSingleChannel -> b/s
        /// 1 ISDN (single channel) to vv: 64000 bit/second [b/s]
        /// </summary>
        public static double ISDNSingleChannel_2_BitPerSecond(double inVal)             => inVal * 64000;
        /// <summary>
        /// b/s -> ISDNSingleChannel
        /// vv: 64000 bit/second [b/s] to 1 ISDN (single channel)
        /// </summary>
        public static double BitPerSecond_2_ISDNSingleChannel(double inVal)             => inVal / 64000;

        /// <summary>
        /// ISDNDualChannel -> b/s
        /// 1 ISDN (dual channel) to vv: 128000 bit/second [b/s]
        /// </summary>
        public static double ISDNDualChannel_2_BitPerSecond(double inVal)               => inVal * 128000;
        /// <summary>
        /// b/s -> ISDNDualChannel
        /// vv: 128000 bit/second [b/s] to 1 ISDN (dual channel)
        /// </summary>
        public static double BitPerSecond_2_ISDNDualChannel(double inVal)               => inVal / 128000;

        /// <summary>
        /// Modem110 -> b/s
        /// 1 modem (110) to vv: 110 bit/second [b/s]
        /// </summary>
        public static double Modem110_2_BitPerSecond(double inVal)                      => inVal * 110;
        /// <summary>
        /// b/s -> Modem110
        /// vv: 110 bit/second [b/s] to 1 modem (110)
        /// </summary>
        public static double BitPerSecond_2_Modem110(double inVal)                      => inVal / 110;

        /// <summary>
        /// Modem300 -> b/s
        /// 1 modem (300) to vv: 300 bit/second [b/s]
        /// </summary>
        public static double Modem300_2_BitPerSecond(double inVal)                      => inVal * 300;
        /// <summary>
        /// b/s -> Modem300
        /// vv: 300 bit/second [b/s] to 1 modem (300)
        /// </summary>
        public static double BitPerSecond_2_Modem300(double inVal)                      => inVal / 300;

        /// <summary>
        /// Modem1200 -> b/s
        /// 1 modem (1200) to vv: 1200 bit/second [b/s]
        /// </summary>
        public static double Modem1200_2_BitPerSecond(double inVal)                     => inVal * 1200;
        /// <summary>
        /// b/s -> Modem1200
        /// vv: 1200 bit/second [b/s] to 1 modem (1200)
        /// </summary>
        public static double BitPerSecond_2_Modem1200(double inVal)                     => inVal / 1200;

        /// <summary>
        /// Modem2400 -> b/s
        /// 1 modem (2400) to vv: 2400 bit/second [b/s]
        /// </summary>
        public static double Modem2400_2_BitPerSecond(double inVal)                     => inVal * 2400;
        /// <summary>
        /// b/s -> Modem2400
        /// vv: 2400 bit/second [b/s] to 1 modem (2400)
        /// </summary>
        public static double BitPerSecond_2_Modem2400(double inVal)                     => inVal / 2400;

        /// <summary>
        /// Modem9600 -> b/s
        /// 1 modem (9600) to vv: 9600 bit/second [b/s]
        /// </summary>
        public static double Modem9600_2_BitPerSecond(double inVal)                     => inVal * 9600;
        /// <summary>
        /// b/s -> Modem9600
        /// vv: 9600 bit/second [b/s] to 1 modem (9600)
        /// </summary>
        public static double BitPerSecond_2_Modem9600(double inVal)                     => inVal / 9600;

        /// <summary>
        /// Modem14.4k -> b/s
        /// 1 modem (14.4k) to vv: 14400 bit/second [b/s]
        /// </summary>
        public static double Modem14k_2_BitPerSecond(double inVal)                      => inVal * 14400;
        /// <summary>
        /// b/s -> Modem14.4k
        /// vv: 14400 bit/second [b/s] to 1 modem (14.4k)
        /// </summary>
        public static double BitPerSecond_2_Modem144k(double inVal)                     => inVal / 14400;

        /// <summary>
        /// Modem28.8k -> b/s
        /// 1 modem (28.8k) to vv: 28800 bit/second [b/s]
        /// </summary>
        public static double Modem28k_2_BitPerSecond(double inVal)                      => inVal * 28800;
        /// <summary>
        /// b/s -> Modem28.8k
        /// vv: 28800 bit/second [b/s] to 1 modem (28.8k)
        /// </summary>
        public static double BitPerSecond_2_Modem28k(double inVal)                      => inVal / 28800;

        /// <summary>
        /// Modem33.6k -> b/s
        /// 1 modem (33.6k) to vv: 33600 bit/second [b/s]
        /// </summary>
        public static double Modem33k_2_BitPerSecond(double inVal)                      => inVal * 33600;
        /// <summary>
        /// b/s -> Modem33.6k
        /// vv: 33600 bit/second [b/s] to 1 modem (33.6k)
        /// </summary>
        public static double BitPerSecond_2_Modem33k(double inVal)                      => inVal / 33600;

        /// <summary>
        /// Modem56k -> b/s
        /// 1 modem (56k) to vv: 56000 bit/second [b/s]
        /// </summary>
        public static double Modem56k_2_BitPerSecond(double inVal)                      => inVal * 56000;
        /// <summary>
        /// b/s -> Modem56k
        /// vv: 56000 bit/second [b/s] to 1 modem (56k)
        /// </summary>
        public static double BitPerSecond_2_Modem56k(double inVal)                      => inVal / 56000;

        /// <summary>
        /// SCSIAsync -> b/s
        /// 1 SCSI (Async) to vv: 12000000 bit/second [b/s]
        /// </summary>
        public static double SCSIAsync_2_BitPerSecond(double inVal)                     => inVal * 12000000;
        /// <summary>
        /// b/s -> SCSIAsync
        /// vv: 12000000 bit/second [b/s] to 1 SCSI (Async)
        /// </summary>
        public static double BitPerSecond_2_SCSIAsync(double inVal)                     => inVal / 12000000;

        /// <summary>
        /// SCSISync -> b/s
        /// 1 SCSI (Sync) to vv: 40000000 bit/second [b/s]
        /// </summary>
        public static double SCSISync_2_BitPerSecond(double inVal)                      => inVal * 40000000;
        /// <summary>
        /// b/s -> SCSISync
        /// vv: 40000000 bit/second [b/s] to 1 SCSI (Sync)
        /// </summary>
        public static double BitPerSecond_2_SCSISync(double inVal)                      => inVal / 40000000;

        /// <summary>
        /// SCSIFast -> b/s
        /// 1 SCSI (Fast) to vv: 80000000 bit/second [b/s]
        /// </summary>
        public static double SCSIFast_2_BitPerSecond(double inVal)                      => inVal * 80000000;
        /// <summary>
        /// b/s -> SCSIFast
        /// vv: 80000000 bit/second [b/s] to 1 SCSI (Fast)
        /// </summary>
        public static double BitPerSecond_2_SCSIFast(double inVal)                      => inVal / 80000000;

        /// <summary>
        /// SCSIFastUltra -> b/s
        /// 1 SCSI (Fast Ultra) to vv: 160000000 bit/second [b/s]
        /// </summary>
        public static double SCSIFastUltra_2_BitPerSecond(double inVal)                 => inVal * 160000000;
        /// <summary>
        /// b/s -> SCSIFastUltra
        /// vv: 160000000 bit/second [b/s] to 1 SCSI (Fast Ultra)
        /// </summary>
        public static double BitPerSecond_2_SCSIFastUltra(double inVal)                 => inVal / 160000000;

        /// <summary>
        /// SCSIFastWide -> b/s
        /// 1 SCSI (Fast Wide) to vv: 160000000 bit/second [b/s]
        /// </summary>
        public static double SCSIFastWide_2_BitPerSecond(double inVal)                  => inVal * 160000000;
        /// <summary>
        /// b/s -> SCSIFastWide
        /// vv: 160000000 bit/second [b/s] to 1 SCSI (Fast Wide)
        /// </summary>
        public static double BitPerSecond_2_SCSIFastWide(double inVal)                  => inVal / 160000000;

        /// <summary>
        /// SCSIFastUltraWide -> b/s
        /// 1 SCSI (Fast Ultra Wide) to vv: 320000000 bit/second [b/s]
        /// </summary>
        public static double SCSIFastUltraWide_2_BitPerSecond(double inVal)             => inVal * 320000000;
        /// <summary>
        /// b/s -> SCSIFastUltraWide
        /// vv: 320000000 bit/second [b/s] to 1 SCSI (Fast Ultra Wide)
        /// </summary>
        public static double BitPerSecond_2_SCSIFastUltraWide(double inVal)             => inVal / 320000000;

        /// <summary>
        /// SCSIUltra2 -> b/s
        /// 1 SCSI (Ultra-2) to vv: 640000000 bit/second [b/s]
        /// </summary>
        public static double SCSIUltra2_2_BitPerSecond(double inVal)                    => inVal * 640000000;
        /// <summary>
        /// b/s -> SCSIUltra2
        /// vv: 640000000 bit/second [b/s] to 1 SCSI (Ultra-2)
        /// </summary>
        public static double BitPerSecond_2_SCSIUltra2(double inVal)                    => inVal / 640000000;

        /// <summary>
        /// SCSIUltra3 -> b/s
        /// 1 SCSI (Ultra-3) to vv: 1280000000 bit/second [b/s]
        /// </summary>
        public static double SCSIUltra3_2_BitPerSecond(double inVal)                    => inVal * 1280000000;
        /// <summary>
        /// b/s -> SCSIUltra3
        /// vv: 1280000000 bit/second [b/s] to 1 SCSI (Ultra-3)
        /// </summary>
        public static double BitPerSecond_2_SCSIUltra3(double inVal)                    => inVal / 1280000000;

        /// <summary>
        /// SCSILVDUltra80 -> b/s
        /// 1 SCSI (LVD Ultra80) to vv: 640000000 bit/second [b/s]
        /// </summary>
        public static double SCSILVDUltra80_2_BitPerSecond(double inVal)                => inVal * 640000000;
        /// <summary>
        /// b/s -> SCSILVDUltra80
        /// vv: 640000000 bit/second [b/s] to 1 SCSI (LVD Ultra80)
        /// </summary>
        public static double BitPerSecond_2_SCSILVDUltra80(double inVal)                => inVal / 640000000;

        /// <summary>
        /// SCSILVDUltra160 -> b/s
        /// 1 SCSI (LVD Ultra160) to vv: 1280000000 bit/second [b/s]
        /// </summary>
        public static double SCSILVDUltra160_2_BitPerSecond(double inVal)               => inVal * 1280000000;
        /// <summary>
        /// b/s -> SCSILVDUltra160
        /// vv: 1280000000 bit/second [b/s] to 1 SCSI (LVD Ultra160)
        /// </summary>
        public static double BitPerSecond_2_SCSILVDUltra160(double inVal)               => inVal / 1280000000;

        /// <summary>
        /// IDEPIOMode0 -> b/s
        /// 1 IDE (PIO mode 0) to vv: 26400000 bit/second [b/s]
        /// </summary>
        public static double IDEPIOMode0_2_BitPerSecond(double inVal)                   => inVal * 26400000;
        /// <summary>
        /// b/s -> IDEPIOMode0
        /// vv: 26400000 bit/second [b/s] to 1 IDE (PIO mode 0)
        /// </summary>
        public static double BitPerSecond_2_IDEPIOMode0(double inVal)                   => inVal / 26400000;

        /// <summary>
        /// IDEPIOMode1 -> b/s
        /// 1 IDE (PIO mode 1) to vv: 41600000 bit/second [b/s]
        /// </summary>
        public static double IDEPIOMode1_2_BitPerSecond(double inVal)                   => inVal * 41600000;
        /// <summary>
        /// b/s -> IDEPIOMode1
        /// vv: 41600000 bit/second [b/s] to 1 IDE (PIO mode 1)
        /// </summary>
        public static double BitPerSecond_2_IDEPIOMode1(double inVal)                   => inVal / 41600000;

        /// <summary>
        /// IDEPIOMode2 -> b/s
        /// 1 IDE (PIO mode 2) to vv: 66400000 bit/second [b/s]
        /// </summary>
        public static double IDEPIOMode2_2_BitPerSecond(double inVal)                   => inVal * 66400000;
        /// <summary>
        /// b/s -> IDEPIOMode2
        /// vv: 66400000 bit/second [b/s] to 1 IDE (PIO mode 2)
        /// </summary>
        public static double BitPerSecond_2_IDEPIOMode2(double inVal)                   => inVal / 66400000;

        /// <summary>
        /// IDEPIOMode3 -> b/s
        /// 1 IDE (PIO mode 3) to vv: 88800000 bit/second [b/s]
        /// </summary>
        public static double IDEPIOMode3_2_BitPerSecond(double inVal)                   => inVal * 88800000;
        /// <summary>
        /// b/s -> IDEPIOMode3
        /// vv: 88800000 bit/second [b/s] to 1 IDE (PIO mode 3)
        /// </summary>
        public static double BitPerSecond_2_IDEPIOMode3(double inVal)                   => inVal / 88800000;

        /// <summary>
        /// IDEPIOMode4 -> b/s
        /// 1 IDE (PIO mode 4) to vv: 132800000 bit/second [b/s]
        /// </summary>
        public static double IDEPIOMode4_2_BitPerSecond(double inVal)                   => inVal * 132800000;
        /// <summary>
        /// b/s -> IDEPIOMode4
        /// vv: 132800000 bit/second [b/s] to 1 IDE (PIO mode 4)
        /// </summary>
        public static double BitPerSecond_2_IDEPIOMode4(double inVal)                   => inVal / 132800000;

        /// <summary>
        /// IDEDMAMode0 -> b/s
        /// 1 IDE (DMA mode 0) to vv: 33600000 bit/second [b/s]
        /// </summary>
        public static double IDEDMAMode0_2_BitPerSecond(double inVal)                   => inVal * 33600000;
        /// <summary>
        /// b/s -> IDEDMAMode0
        /// vv: 33600000 bit/second [b/s] to 1 IDE (DMA mode 0)
        /// </summary>
        public static double BitPerSecond_2_IDEDMAMode0(double inVal)                   => inVal / 33600000;

        /// <summary>
        /// IDEDMAMode1 -> b/s
        /// 1 IDE (DMA mode 1) to vv: 106400000 bit/second [b/s]
        /// </summary>
        public static double IDEDMAMode1_2_BitPerSecond(double inVal)                   => inVal * 106400000;
        /// <summary>
        /// b/s -> IDEDMAMode1
        /// vv: 106400000 bit/second [b/s] to 1 IDE (DMA mode 1)
        /// </summary>
        public static double BitPerSecond_2_IDEDMAMode1(double inVal)                   => inVal / 106400000;

        /// <summary>
        /// IDEDMAMode2 -> b/s
        /// 1 IDE (DMA mode 2) to vv: 132800000 bit/second [b/s]
        /// </summary>
        public static double IDEDMAMode2_2_BitPerSecond(double inVal)                   => inVal * 132800000;
        /// <summary>
        /// b/s -> IDEDMAMode2
        /// vv: 132800000 bit/second [b/s] to 1 IDE (DMA mode 2)
        /// </summary>
        public static double BitPerSecond_2_IDEDMAMode2(double inVal)                   => inVal / 132800000;

        /// <summary>
        /// IDEUDMAMode0 -> b/s
        /// 1 IDE (UDMA mode 0) to vv: 132800000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMAMode0_2_BitPerSecond(double inVal)                  => inVal * 132800000;
        /// <summary>
        /// b/s -> IDEUDMAMode0
        /// vv: 132800000 bit/second [b/s] to 1 IDE (UDMA mode 0)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMAMode0(double inVal)                  => inVal / 132800000;

        /// <summary>
        /// IDEUDMAMode1 -> b/s
        /// 1 IDE (UDMA mode 1) to vv: 200000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMAMode1_2_BitPerSecond(double inVal)                  => inVal * 200000000;
        /// <summary>
        /// b/s -> IDEUDMAMode1
        /// vv: 200000000 bit/second [b/s] to 1 IDE (UDMA mode 1)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMAMode1(double inVal)                  => inVal / 200000000;

        /// <summary>
        /// IDEUDMAMode2 -> b/s
        /// 1 IDE (UDMA mode 2) to vv: 264000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMAMode2_2_BitPerSecond(double inVal)                  => inVal * 264000000;
        /// <summary>
        /// b/s -> IDEUDMAMode2
        /// vv: 264000000 bit/second [b/s] to 1 IDE (UDMA mode 2)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMAMode2(double inVal)                  => inVal / 264000000;

        /// <summary>
        /// IDEUDMAMode3 -> b/s
        /// 1 IDE (UDMA mode 3) to vv: 400000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMAMode3_2_BitPerSecond(double inVal)                  => inVal * 400000000;
        /// <summary>
        /// b/s -> IDEUDMAMode3
        /// vv: 400000000 bit/second [b/s] to 1 IDE (UDMA mode 3)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMAMode3(double inVal)                  => inVal / 400000000;

        /// <summary>
        /// IDEUDMAMode4 -> b/s
        /// 1 IDE (UDMA mode 4) to vv: 528000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMAMode4_2_BitPerSecond(double inVal)                  => inVal * 528000000;
        /// <summary>
        /// b/s -> IDEUDMAMode4
        /// vv: 528000000 bit/second [b/s] to 1 IDE (UDMA mode 4)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMAMode4(double inVal)                  => inVal / 528000000;

        /// <summary>
        /// IDEUDMA33 -> b/s
        /// 1 IDE (UDMA-33) to vv: 264000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMA33_2_BitPerSecond(double inVal)                     => inVal * 264000000;
        /// <summary>
        /// b/s -> IDEUDMA33
        /// vv: 264000000 bit/second [b/s] to 1 IDE (UDMA-33)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMA33(double inVal)                     => inVal / 264000000;

        /// <summary>
        /// IDEUDMA66 -> b/s
        /// 1 IDE (UDMA-66) to vv: 528000000 bit/second [b/s]
        /// </summary>
        public static double IDEUDMA66_2_BitPerSecond(double inVal)                     => inVal * 528000000;
        /// <summary>
        /// b/s -> IDEUDMA66
        /// vv: 528000000 bit/second [b/s] to 1 IDE (UDMA-66)
        /// </summary>
        public static double BitPerSecond_2_IDEUDMA66(double inVal)                     => inVal / 528000000;

        /// <summary>
        /// USB -> b/s
        /// 1 USB to vv: 12000000 bit/second [b/s]
        /// </summary>
        public static double USB_2_BitPerSecond(double inVal)                           => inVal * 12000000;
        /// <summary>
        /// b/s -> USB
        /// vv: 12000000 bit/second [b/s] to 1 USB
        /// </summary>
        public static double BitPerSecond_2_USB(double inVal)                           => inVal / 12000000;

        /// <summary>
        /// FirewireIEEE1394 -> b/s
        /// 1 firewire (IEEE-1394) to vv: 400000000 bit/second [b/s]
        /// </summary>
        public static double FirewireIEEE1394_2_BitPerSecond(double inVal)              => inVal * 400000000;
        /// <summary>
        /// b/s -> FirewireIEEE1394
        /// vv: 400000000 bit/second [b/s] to 1 firewire (IEEE-1394)
        /// </summary>
        public static double BitPerSecond_2_FirewireIEEE1394(double inVal)              => inVal / 400000000;

        /// <summary>
        /// T0Payload -> b/s
        /// 1 T0 (payload) to vv: 56000 bit/second [b/s]
        /// </summary>
        public static double T0Payload_2_BitPerSecond(double inVal)                     => inVal * 56000;
        /// <summary>
        /// b/s -> T0Payload
        /// vv: 56000 bit/second [b/s] to 1 T0 (payload)
        /// </summary>
        public static double BitPerSecond_2_T0Payload(double inVal)                     => inVal / 56000;

        /// <summary>
        /// T0B8ZSPayload -> b/s
        /// 1 T0 (B8ZS payload) to vv: 64000 bit/second [b/s]
        /// </summary>
        public static double T0B8ZSPayload_2_BitPerSecond(double inVal)                 => inVal * 64000;
        /// <summary>
        /// b/s -> T0B8ZSPayload
        /// vv: 64000 bit/second [b/s] to 1 T0 (B8ZS payload)
        /// </summary>
        public static double BitPerSecond_2_T0B8ZSPayload(double inVal)                 => inVal / 64000;

        /// <summary>
        /// T1Signal -> b/s
        /// 1 T1 (signal) to vv: 1544000 bit/second [b/s]
        /// </summary>
        public static double T1Signal_2_BitPerSecond(double inVal)                      => inVal * 1544000;
        /// <summary>
        /// b/s -> T1Signal
        /// vv: 1544000 bit/second [b/s] to 1 T1 (signal)
        /// </summary>
        public static double BitPerSecond_2_T1Signal(double inVal)                      => inVal / 1544000;

        /// <summary>
        /// T1Payload -> b/s
        /// 1 T1 (payload) to vv: 1344000 bit/second [b/s]
        /// </summary>
        public static double T1Payload_2_BitPerSecond(double inVal)                     => inVal * 1344000;
        /// <summary>
        /// b/s -> T1Payload
        /// vv: 1344000 bit/second [b/s] to 1 T1 (payload)
        /// </summary>
        public static double BitPerSecond_2_T1Payload(double inVal)                     => inVal / 1344000;

        /// <summary>
        /// T1ZPayload -> b/s
        /// 1 T1Z (payload) to vv: 1544000 bit/second [b/s]
        /// </summary>
        public static double T1ZPayload_2_BitPerSecond(double inVal)                    => inVal * 1544000;
        /// <summary>
        /// b/s -> T1ZPayload
        /// vv: 1544000 bit/second [b/s] to 1 T1Z (payload)
        /// </summary>
        public static double BitPerSecond_2_T1ZPayload(double inVal)                    => inVal / 1544000;

        /// <summary>
        /// T1CSignal -> b/s
        /// 1 T1C (signal) to vv: 3152000 bit/second [b/s]
        /// </summary>
        public static double T1CSignal_2_BitPerSecond(double inVal)                     => inVal * 3152000;
        /// <summary>
        /// b/s -> T1CSignal
        /// vv: 3152000 bit/second [b/s] to 1 T1C (signal)
        /// </summary>
        public static double BitPerSecond_2_T1CSignal(double inVal)                     => inVal / 3152000;

        /// <summary>
        /// T1CPayload -> b/s
        /// 1 T1C (payload) to vv: 2688000 bit/second [b/s]
        /// </summary>
        public static double T1CPayload_2_BitPerSecond(double inVal)                    => inVal * 2688000;
        /// <summary>
        /// b/s -> T1CPayload
        /// vv: 2688000 bit/second [b/s] to 1 T1C (payload)
        /// </summary>
        public static double BitPerSecond_2_T1CPayload(double inVal)                    => inVal / 2688000;

        /// <summary>
        /// T2Signal -> b/s
        /// 1 T2 (signal) to vv: 6312000 bit/second [b/s]
        /// </summary>
        public static double T2Signal_2_BitPerSecond(double inVal)                      => inVal * 6312000;
        /// <summary>
        /// b/s -> T2Signal
        /// vv: 6312000 bit/second [b/s] to 1 T2 (signal)
        /// </summary>
        public static double BitPerSecond_2_T2Signal(double inVal)                      => inVal / 6312000;

        /// <summary>
        /// T3Signal -> b/s
        /// 1 T3 (signal) to vv: 44736000 bit/second [b/s]
        /// </summary>
        public static double T3Signal_2_BitPerSecond(double inVal)                      => inVal * 44736000;
        /// <summary>
        /// b/s -> T3Signal
        /// vv: 44736000 bit/second [b/s] to 1 T3 (signal)
        /// </summary>
        public static double BitPerSecond_2_T3Signal(double inVal)                      => inVal / 44736000;

        /// <summary>
        /// T3Payload -> b/s
        /// 1 T3 (payload) to vv: 37632000 bit/second [b/s]
        /// </summary>
        public static double T3Payload_2_BitPerSecond(double inVal)                     => inVal * 37632000;
        /// <summary>
        /// b/s -> T3Payload
        /// vv: 37632000 bit/second [b/s] to 1 T3 (payload)
        /// </summary>
        public static double BitPerSecond_2_T3Payload(double inVal)                     => inVal / 37632000;

        /// <summary>
        /// T3ZPayload -> b/s
        /// 1 T3Z (payload) to vv: 43008000 bit/second [b/s]
        /// </summary>
        public static double T3ZPayload_2_BitPerSecond(double inVal)                    => inVal * 43008000;
        /// <summary>
        /// b/s -> T3ZPayload
        /// vv: 43008000 bit/second [b/s] to 1 T3Z (payload)
        /// </summary>
        public static double BitPerSecond_2_T3ZPayload(double inVal)                    => inVal / 43008000;

        /// <summary>
        /// T4Signal -> b/s
        /// 1 T4 (signal) to vv: 274176000 bit/second [b/s]
        /// </summary>
        public static double T4Signal_2_BitPerSecond(double inVal)                      => inVal * 274176000;
        /// <summary>
        /// b/s -> T4Signal
        /// vv: 274176000 bit/second [b/s] to 1 T4 (signal)
        /// </summary>
        public static double BitPerSecond_2_T4Signal(double inVal)                      => inVal / 274176000;

        /// <summary>
        /// EPTA1Signal -> b/s
        /// 1 EPTA 1 (signal) to vv: 2048000 bit/second [b/s]
        /// </summary>
        public static double EPTA1Signal_2_BitPerSecond(double inVal)               => inVal * 2048000;
        /// <summary>
        /// b/s -> EPTA1Signal
        /// vv: 2048000 bit/second [b/s] to 1 EPTA 1 (signal)
        /// </summary>
        public static double BitPerSecond_2_EPTA1Signal(double inVal)               => inVal / 2048000;

        /// <summary>
        /// EPTA1Payload -> b/s
        /// 1 EPTA 1 (payload) to vv: 1920000 bit/second [b/s]
        /// </summary>
        public static double EPTA1Payload_2_BitPerSecond(double inVal)              => inVal * 1920000;
        /// <summary>
        /// b/s -> EPTA1Payload
        /// vv: 1920000 bit/second [b/s] to 1 EPTA 1 (payload)
        /// </summary>
        public static double BitPerSecond_2_EPTA1Payload(double inVal)              => inVal / 1920000;

        /// <summary>
        /// EPTA2Signal -> b/s
        /// 1 EPTA 2 (signal) to vv: 8448000 bit/second [b/s]
        /// </summary>
        public static double EPTA2Signal_2_BitPerSecond(double inVal)               => inVal * 8448000;
        /// <summary>
        /// b/s -> EPTA2Signal
        /// vv: 8448000 bit/second [b/s] to 1 EPTA 2 (signal)
        /// </summary>
        public static double BitPerSecond_2_EPTA2Signal(double inVal)               => inVal / 8448000;

        /// <summary>
        /// EPTA2Payload -> b/s
        /// 1 EPTA 2 (payload) to vv: 7680000 bit/second [b/s]
        /// </summary>
        public static double EPTA2Payload_2_BitPerSecond(double inVal)              => inVal * 7680000;
        /// <summary>
        /// b/s -> EPTA2Payload
        /// vv: 7680000 bit/second [b/s] to 1 EPTA 2 (payload)
        /// </summary>
        public static double BitPerSecond_2_EPTA2Payload(double inVal)              => inVal / 7680000;

        /// <summary>
        /// EPTA3Signal -> b/s
        /// 1 EPTA 3 (signal) to vv: 34368000 bit/second [b/s]
        /// </summary>
        public static double EPTA3Signal_2_BitPerSecond(double inVal)               => inVal * 34368000;
        /// <summary>
        /// b/s -> EPTA3Signal
        /// vv: 34368000 bit/second [b/s] to 1 EPTA 3 (signal)
        /// </summary>
        public static double BitPerSecond_2_EPTA3Signal(double inVal)               => inVal / 34368000;

        /// <summary>
        /// EPTA3Payload -> b/s
        /// 1 EPTA 3 (payload) to vv: 30720000 bit/second [b/s]
        /// </summary>
        public static double EPTA3Payload_2_BitPerSecond(double inVal)              => inVal * 30720000;
        /// <summary>
        /// b/s -> EPTA3Payload
        /// vv: 30720000 bit/second [b/s] to 1 EPTA 3 (payload)
        /// </summary>
        public static double BitPerSecond_2_EPTA3Payload(double inVal)              => inVal / 30720000;

        /// <summary>
        /// H0 -> b/s
        /// 1 H0 to vv: 384000 bit/second [b/s]
        /// </summary>
        public static double H0_2_BitPerSecond(double inVal)                            => inVal * 384000;
        /// <summary>
        /// b/s -> H0
        /// vv: 384000 bit/second [b/s] to 1 H0
        /// </summary>
        public static double BitPerSecond_2_H0(double inVal)                            => inVal / 384000;

        /// <summary>
        /// H11 -> b/s
        /// 1 H11 to vv: 1536000 bit/second [b/s]
        /// </summary>
        public static double H11_2_BitPerSecond(double inVal)                           => inVal * 1536000;
        /// <summary>
        /// b/s -> H11
        /// vv: 1536000 bit/second [b/s] to 1 H11
        /// </summary>
        public static double BitPerSecond_2_H11(double inVal)                           => inVal / 1536000;

        /// <summary>
        /// H12 -> b/s
        /// 1 H12 to vv: 1920000 bit/second [b/s]
        /// </summary>
        public static double H12_2_BitPerSecond(double inVal)                           => inVal * 1920000;
        /// <summary>
        /// b/s -> H12
        /// vv: 1920000 bit/second [b/s] to 1 H12
        /// </summary>
        public static double BitPerSecond_2_H12(double inVal)                           => inVal / 1920000;

        /// <summary>
        /// VirtualTributary1Signal -> b/s
        /// 1 Virtual Tributary 1 (signal) to vv: 1728000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary1Signal_2_BitPerSecond(double inVal)       => inVal * 1728000;
        /// <summary>
        /// b/s -> VirtualTributary1Signal
        /// vv: 1728000 bit/second [b/s] to 1 Virtual Tributary 1 (signal)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary1Signal(double inVal)       => inVal / 1728000;

        /// <summary>
        /// VirtualTributary1Payload -> b/s
        /// 1 Virtual Tributary 1 (payload) to vv: 1544000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary1Payload_2_BitPerSecond(double inVal)      => inVal * 1544000;
        /// <summary>
        /// b/s -> VirtualTributary1Payload
        /// vv: 1544000 bit/second [b/s] to 1 Virtual Tributary 1 (payload)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary1Payload(double inVal)      => inVal / 1544000;

        /// <summary>
        /// VirtualTributary2Signal -> b/s
        /// 1 Virtual Tributary 2 (signal) to vv: 2304000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary2Signal_2_BitPerSecond(double inVal)       => inVal * 2304000;
        /// <summary>
        /// b/s -> VirtualTributary2Signal
        /// vv: 2304000 bit/second [b/s] to 1 Virtual Tributary 2 (signal)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary2Signal(double inVal)       => inVal / 2304000;

        /// <summary>
        /// VirtualTributary2Payload -> b/s
        /// 1 Virtual Tributary 2 (payload) to vv: 2048000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary2Payload_2_BitPerSecond(double inVal)      => inVal * 2048000;
        /// <summary>
        /// b/s -> VirtualTributary2Payload
        /// vv: 2048000 bit/second [b/s] to 1 Virtual Tributary 2 (payload)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary2Payload(double inVal)      => inVal / 2048000;

        /// <summary>
        /// VirtualTributary6Signal -> b/s
        /// 1 Virtual Tributary 6 (signal) to vv: 6312000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary6Signal_2_BitPerSecond(double inVal)       => inVal * 6312000;
        /// <summary>
        /// b/s -> VirtualTributary6Signal
        /// vv: 6312000 bit/second [b/s] to 1 Virtual Tributary 6 (signal)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary6Signal(double inVal)       => inVal / 6312000;

        /// <summary>
        /// VirtualTributary6Payload -> b/s
        /// 1 Virtual Tributary 6 (payload) to vv: 6000000 bit/second [b/s]
        /// </summary>
        public static double VirtualTributary6Payload_2_BitPerSecond(double inVal)      => inVal * 6000000;
        /// <summary>
        /// b/s -> VirtualTributary6Payload
        /// vv: 6000000 bit/second [b/s] to 1 Virtual Tributary 6 (payload)
        /// </summary>
        public static double BitPerSecond_2_VirtualTributary6Payload(double inVal)      => inVal / 6000000;

        /// <summary>
        /// STS1Signal -> b/s
        /// 1 STS1 (signal) to vv: 51840000 bit/second [b/s]
        /// </summary>
        public static double STS1Signal_2_BitPerSecond(double inVal)                    => inVal * 51840000;
        /// <summary>
        /// b/s -> STS1Signal
        /// vv: 51840000 bit/second [b/s] to 1 STS1 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS1Signal(double inVal)                    => inVal / 51840000;

        /// <summary>
        /// STS1Payload -> b/s
        /// 1 STS1 (payload) to vv: 49500000 bit/second [b/s]
        /// </summary>
        public static double STS1Payload_2_BitPerSecond(double inVal)                   => inVal * 49500000;
        /// <summary>
        /// b/s -> STS1Payload
        /// vv: 49500000 bit/second [b/s] to 1 STS1 (payload)
        /// </summary>
        public static double BitPerSecond_2_STS1Payload(double inVal)                   => inVal / 49500000;

        /// <summary>
        /// STS3Signal -> b/s
        /// 1 STS3 (signal) to vv: 155520000 bit/second [b/s]
        /// </summary>
        public static double STS3Signal_2_BitPerSecond(double inVal)                    => inVal * 155520000;
        /// <summary>
        /// b/s -> STS3Signal
        /// vv: 155520000 bit/second [b/s] to 1 STS3 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS3Signal(double inVal)                    => inVal / 155520000;

        /// <summary>
        /// STS3Payload -> b/s
        /// 1 STS3 (payload) to vv: 150336000 bit/second [b/s]
        /// </summary>
        public static double STS3Payload_2_BitPerSecond(double inVal)                   => inVal * 150336000;
        /// <summary>
        /// b/s -> STS3Payload
        /// vv: 150336000 bit/second [b/s] to 1 STS3 (payload)
        /// </summary>
        public static double BitPerSecond_2_STS3Payload(double inVal)                   => inVal / 150336000;

        /// <summary>
        /// STS3cSignal -> b/s
        /// 1 STS3c (signal) to vv: 155520000 bit/second [b/s]
        /// </summary>
        public static double STS3cSignal_2_BitPerSecond(double inVal)                   => inVal * 155520000;
        /// <summary>
        /// b/s -> STS3cSignal
        /// vv: 155520000 bit/second [b/s] to 1 STS3c (signal)
        /// </summary>
        public static double BitPerSecond_2_STS3cSignal(double inVal)                   => inVal / 155520000;

        /// <summary>
        /// STS3cPayload -> b/s
        /// 1 STS3c (payload) to vv: 150336000 bit/second [b/s]
        /// </summary>
        public static double STS3cPayload_2_BitPerSecond(double inVal)                  => inVal * 150336000;
        /// <summary>
        /// b/s -> STS3cPayload
        /// vv: 150336000 bit/second [b/s] to 1 STS3c (payload)
        /// </summary>
        public static double BitPerSecond_2_STS3cPayload(double inVal)                  => inVal / 150336000;

        /// <summary>
        /// STS12Signal -> b/s
        /// 1 STS12 (signal) to vv: 622080000 bit/second [b/s]
        /// </summary>
        public static double STS12Signal_2_BitPerSecond(double inVal)                   => inVal * 622080000;
        /// <summary>
        /// b/s -> STS12Signal
        /// vv: 622080000 bit/second [b/s] to 1 STS12 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS12Signal(double inVal)                   => inVal / 622080000;

        /// <summary>
        /// STS24Signal -> b/s
        /// 1 STS24 (signal) to vv: 1244160000 bit/second [b/s]
        /// </summary>
        public static double STS24Signal_2_BitPerSecond(double inVal)                   => inVal * 1244160000;
        /// <summary>
        /// b/s -> STS24Signal
        /// vv: 1244160000 bit/second [b/s] to 1 STS24 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS24Signal(double inVal)                   => inVal / 1244160000;

        /// <summary>
        /// STS48Signal -> b/s
        /// 1 STS48 (signal) to vv: 2488320000 bit/second [b/s]
        /// </summary>
        public static double STS48Signal_2_BitPerSecond(double inVal)                   => inVal * 2488320000;
        /// <summary>
        /// b/s -> STS48Signal
        /// vv: 2488320000 bit/second [b/s] to 1 STS48 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS48Signal(double inVal)                   => inVal / 2488320000;

        /// <summary>
        /// STS192Signal -> b/s
        /// 1 STS192 (signal) to vv: 9953280000 bit/second [b/s]
        /// </summary>
        public static double STS192Signal_2_BitPerSecond(double inVal)                  => inVal * 9953280000;
        /// <summary>
        /// b/s -> STS192Signal
        /// vv: 9953280000 bit/second [b/s] to 1 STS192 (signal)
        /// </summary>
        public static double BitPerSecond_2_STS192Signal(double inVal)                  => inVal / 9953280000;

        /// <summary>
        /// STM1Signal -> b/s
        /// 1 STM-1 (signal) to vv: 155520000 bit/second [b/s]
        /// </summary>
        public static double STM1Signal_2_BitPerSecond(double inVal)                    => inVal * 155520000;
        /// <summary>
        /// b/s -> STM1Signal
        /// vv: 155520000 bit/second [b/s] to 1 STM-1 (signal)
        /// </summary>
        public static double BitPerSecond_2_STM1Signal(double inVal)                    => inVal / 155520000;

        /// <summary>
        /// STM4Signal -> b/s
        /// 1 STM-4 (signal) to vv: 622080000 bit/second [b/s]
        /// </summary>
        public static double STM4Signal_2_BitPerSecond(double inVal)                    => inVal * 622080000;
        /// <summary>
        /// b/s -> STM4Signal
        /// vv: 622080000 bit/second [b/s] to 1 STM-4 (signal)
        /// </summary>
        public static double BitPerSecond_2_STM4Signal(double inVal)                    => inVal / 622080000;

        /// <summary>
        /// STM16Signal -> b/s
        /// 1 STM-16 (signal) to vv: 2488320000 bit/second [b/s]
        /// </summary>
        public static double STM16Signal_2_BitPerSecond(double inVal)                   => inVal * 2488320000;
        /// <summary>
        /// b/s -> STM16Signal
        /// vv: 2488320000 bit/second [b/s] to 1 STM-16 (signal)
        /// </summary>
        public static double BitPerSecond_2_STM16Signal(double inVal)                   => inVal / 2488320000;

        /// <summary>
        /// STM64Signal -> b/s
        /// 1 STM-64 (signal) to vv: 9953280000 bit/second [b/s]
        /// </summary>
        public static double STM64Signal_2_BitPerSecond(double inVal)                   => inVal * 9953280000;
        /// <summary>
        /// b/s -> STM64Signal
        /// vv: 9953280000 bit/second [b/s] to 1 STM-64 (signal)
        /// </summary>
        public static double BitPerSecond_2_STM64Signal(double inVal)                   => inVal / 9953280000;

        #endregion
    }
}
