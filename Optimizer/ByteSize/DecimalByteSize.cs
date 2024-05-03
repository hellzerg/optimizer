namespace Optimizer
{
    public partial struct ByteSize
    {
        public const long BytesInKiloByte = 1_000;
        public const long BytesInMegaByte = 1_000_000;
        public const long BytesInGigaByte = 1_000_000_000;
        public const long BytesInTeraByte = 1_000_000_000_000;
        public const long BytesInPetaByte = 1_000_000_000_000_000;

        public const string KiloByteSymbol = "KB";
        public const string MegaByteSymbol = "MB";
        public const string GigaByteSymbol = "GB";
        public const string TeraByteSymbol = "TB";
        public const string PetaByteSymbol = "PB";

        public double KiloBytes => Bytes / BytesInKiloByte;
        public double MegaBytes => Bytes / BytesInMegaByte;
        public double GigaBytes => Bytes / BytesInGigaByte;
        public double TeraBytes => Bytes / BytesInTeraByte;
        public double PetaBytes => Bytes / BytesInPetaByte;

        public static ByteSize FromKiloBytes(double value)
        {
            return new ByteSize(value * BytesInKiloByte);
        }

        public static ByteSize FromMegaBytes(double value)
        {
            return new ByteSize(value * BytesInMegaByte);
        }

        public static ByteSize FromGigaBytes(double value)
        {
            return new ByteSize(value * BytesInGigaByte);
        }

        public static ByteSize FromTeraBytes(double value)
        {
            return new ByteSize(value * BytesInTeraByte);
        }

        public static ByteSize FromPetaBytes(double value)
        {
            return new ByteSize(value * BytesInPetaByte);
        }

        public ByteSize AddKiloBytes(double value)
        {
            return this + ByteSize.FromKiloBytes(value);
        }

        public ByteSize AddMegaBytes(double value)
        {
            return this + ByteSize.FromMegaBytes(value);
        }

        public ByteSize AddGigaBytes(double value)
        {
            return this + ByteSize.FromGigaBytes(value);
        }

        public ByteSize AddTeraBytes(double value)
        {
            return this + ByteSize.FromTeraBytes(value);
        }

        public ByteSize AddPetaBytes(double value)
        {
            return this + ByteSize.FromPetaBytes(value);
        }
    }
}