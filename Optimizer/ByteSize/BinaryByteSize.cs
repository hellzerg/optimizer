using System;
using System.Globalization;

namespace Optimizer
{
    public partial struct ByteSize
    {
        public const long BytesInKibiByte = 1_024;
        public const long BytesInMebiByte = 1_048_576;
        public const long BytesInGibiByte = 1_073_741_824;
        public const long BytesInTebiByte = 1_099_511_627_776;
        public const long BytesInPebiByte = 1_125_899_906_842_624;

        public const string KibiByteSymbol = "KiB";
        public const string MebiByteSymbol = "MiB";
        public const string GibiByteSymbol = "GiB";
        public const string TebiByteSymbol = "TiB";
        public const string PebiByteSymbol = "PiB";

        public double KibiBytes => Bytes / BytesInKibiByte;
        public double MebiBytes => Bytes / BytesInMebiByte;
        public double GibiBytes => Bytes / BytesInGibiByte;
        public double TebiBytes => Bytes / BytesInTebiByte;
        public double PebiBytes => Bytes / BytesInPebiByte;

        public static ByteSize FromKibiBytes(double value)
        {
            return new ByteSize(value * BytesInKibiByte);
        }

        public static ByteSize FromMebiBytes(double value)
        {
            return new ByteSize(value * BytesInMebiByte);
        }

        public static ByteSize FromGibiBytes(double value)
        {
            return new ByteSize(value * BytesInGibiByte);
        }

        public static ByteSize FromTebiBytes(double value)
        {
            return new ByteSize(value * BytesInTebiByte);
        }

        public static ByteSize FromPebiBytes(double value)
        {
            return new ByteSize(value * BytesInPebiByte);
        }

        public ByteSize AddKibiBytes(double value)
        {
            return this + ByteSize.FromKibiBytes(value);
        }

        public ByteSize AddMebiBytes(double value)
        {
            return this + ByteSize.FromMebiBytes(value);
        }

        public ByteSize AddGibiBytes(double value)
        {
            return this + ByteSize.FromGibiBytes(value);
        }

        public ByteSize AddTebiBytes(double value)
        {
            return this + ByteSize.FromTebiBytes(value);
        }

        public ByteSize AddPebiBytes(double value)
        {
            return this + ByteSize.FromPebiBytes(value);
        }

        public string ToBinaryString()
        {
            return this.ToString("0.##", CultureInfo.CurrentCulture, useBinaryByte: true);
        }

        public string ToBinaryString(IFormatProvider formatProvider)
        {
            return this.ToString("0.##", formatProvider, useBinaryByte: true);
        }
    }
}