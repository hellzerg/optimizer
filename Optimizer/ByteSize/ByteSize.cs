using System;
using System.Globalization;

namespace Optimizer
{
    /// <summary>
    /// Represents a byte size value with support for decimal (KiloByte) and
    /// binary values (KibiByte).
    /// </summary>
    public partial struct ByteSize : IComparable<ByteSize>, IEquatable<ByteSize>
    {
        public static readonly ByteSize MinValue = ByteSize.FromBits(long.MinValue);
        public static readonly ByteSize MaxValue = ByteSize.FromBits(long.MaxValue);
        public const long BitsInByte = 8;
        public const string BitSymbol = "b";
        public const string ByteSymbol = "B";
        public long Bits { get; private set; }
        public double Bytes { get; private set; }

        public string LargestWholeNumberBinarySymbol
        {
            get
            {
                // Absolute value is used to deal with negative values
                if (Math.Abs(this.PebiBytes) >= 1)
                    return PebiByteSymbol;

                if (Math.Abs(this.TebiBytes) >= 1)
                    return TebiByteSymbol;

                if (Math.Abs(this.GibiBytes) >= 1)
                    return GibiByteSymbol;

                if (Math.Abs(this.MebiBytes) >= 1)
                    return MebiByteSymbol;

                if (Math.Abs(this.KibiBytes) >= 1)
                    return KibiByteSymbol;

                if (Math.Abs(this.Bytes) >= 1)
                    return ByteSymbol;

                return BitSymbol;
            }
        }

        public string LargestWholeNumberDecimalSymbol
        {
            get
            {
                // Absolute value is used to deal with negative values
                if (Math.Abs(this.PetaBytes) >= 1)
                    return PetaByteSymbol;

                if (Math.Abs(this.TeraBytes) >= 1)
                    return TeraByteSymbol;

                if (Math.Abs(this.GigaBytes) >= 1)
                    return GigaByteSymbol;

                if (Math.Abs(this.MegaBytes) >= 1)
                    return MegaByteSymbol;

                if (Math.Abs(this.KiloBytes) >= 1)
                    return KiloByteSymbol;

                if (Math.Abs(this.Bytes) >= 1)
                    return ByteSymbol;

                return BitSymbol;
            }
        }

        public double LargestWholeNumberBinaryValue
        {
            get
            {
                // Absolute value is used to deal with negative values
                if (Math.Abs(this.PebiBytes) >= 1)
                    return this.PebiBytes;

                if (Math.Abs(this.TebiBytes) >= 1)
                    return this.TebiBytes;

                if (Math.Abs(this.GibiBytes) >= 1)
                    return this.GibiBytes;

                if (Math.Abs(this.MebiBytes) >= 1)
                    return this.MebiBytes;

                if (Math.Abs(this.KibiBytes) >= 1)
                    return this.KibiBytes;

                if (Math.Abs(this.Bytes) >= 1)
                    return this.Bytes;

                return this.Bits;
            }
        }

        public double LargestWholeNumberDecimalValue
        {
            get
            {
                // Absolute value is used to deal with negative values
                if (Math.Abs(this.PetaBytes) >= 1)
                    return this.PetaBytes;

                if (Math.Abs(this.TeraBytes) >= 1)
                    return this.TeraBytes;

                if (Math.Abs(this.GigaBytes) >= 1)
                    return this.GigaBytes;

                if (Math.Abs(this.MegaBytes) >= 1)
                    return this.MegaBytes;

                if (Math.Abs(this.KiloBytes) >= 1)
                    return this.KiloBytes;

                if (Math.Abs(this.Bytes) >= 1)
                    return this.Bytes;

                return this.Bits;
            }
        }

        public ByteSize(long bits)
            : this()
        {
            Bits = bits;

            Bytes = bits / BitsInByte;
        }

        public ByteSize(double bytes)
            : this()
        {
            // Get ceiling because bits are whole units
            Bits = (long)Math.Ceiling(bytes * BitsInByte);

            Bytes = bytes;
        }

        public static ByteSize FromBits(long value)
        {
            return new ByteSize(value);
        }

        public static ByteSize FromBytes(double value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Converts the value of the current object to a string.
        /// The prefix symbol (bit, byte, kilo, mebi, gibi, tebi) used is the
        /// largest prefix such that the corresponding value is greater than or
        /// equal to one.
        /// </summary>
        public override string ToString()
        {
            return this.ToString("0.##", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider, bool useBinaryByte = false)
        {
            if (!format.Contains("#") && !format.Contains("0"))
                format = "0.## " + format;

            if (provider == null) provider = CultureInfo.CurrentCulture;

            Func<string, bool> has = s => format.IndexOf(s, StringComparison.CurrentCultureIgnoreCase) != -1;
            Func<double, string> output = n => n.ToString(format, provider);

            // Binary
            if (has("PiB"))
                return output(this.PebiBytes);
            if (has("TiB"))
                return output(this.TebiBytes);
            if (has("GiB"))
                return output(this.GibiBytes);
            if (has("MiB"))
                return output(this.MebiBytes);
            if (has("KiB"))
                return output(this.KibiBytes);

            // Decimal
            if (has("PB"))
                return output(this.PetaBytes);
            if (has("TB"))
                return output(this.TeraBytes);
            if (has("GB"))
                return output(this.GigaBytes);
            if (has("MB"))
                return output(this.MegaBytes);
            if (has("KB"))
                return output(this.KiloBytes);

            // Byte and Bit symbol must be case-sensitive
            if (format.IndexOf(ByteSize.ByteSymbol) != -1)
                return output(this.Bytes);

            if (format.IndexOf(ByteSize.BitSymbol) != -1)
                return output(this.Bits);

            if (useBinaryByte)
            {
                return string.Format("{0} {1}", this.LargestWholeNumberBinaryValue.ToString(format, provider), this.LargestWholeNumberBinarySymbol);
            }
            else
            {
                return string.Format("{0} {1}", this.LargestWholeNumberDecimalValue.ToString(format, provider), this.LargestWholeNumberDecimalSymbol);
            }
        }

        public override bool Equals(object value)
        {
            if (value == null)
                return false;

            ByteSize other;
            if (value is ByteSize)
                other = (ByteSize)value;
            else
                return false;

            return Equals(other);
        }

        public bool Equals(ByteSize value)
        {
            return this.Bits == value.Bits;
        }

        public override int GetHashCode()
        {
            return this.Bits.GetHashCode();
        }

        public int CompareTo(ByteSize other)
        {
            return this.Bits.CompareTo(other.Bits);
        }

        public ByteSize Add(ByteSize bs)
        {
            return new ByteSize(this.Bytes + bs.Bytes);
        }

        public ByteSize AddBits(long value)
        {
            return this + FromBits(value);
        }

        public ByteSize AddBytes(double value)
        {
            return this + ByteSize.FromBytes(value);
        }

        public ByteSize Subtract(ByteSize bs)
        {
            return new ByteSize(this.Bytes - bs.Bytes);
        }

        public static ByteSize operator +(ByteSize b1, ByteSize b2)
        {
            return new ByteSize(b1.Bytes + b2.Bytes);
        }

        public static ByteSize operator ++(ByteSize b)
        {
            return new ByteSize(b.Bytes + 1);
        }

        public static ByteSize operator -(ByteSize b)
        {
            return new ByteSize(-b.Bytes);
        }

        public static ByteSize operator -(ByteSize b1, ByteSize b2)
        {
            return new ByteSize(b1.Bytes - b2.Bytes);
        }

        public static ByteSize operator --(ByteSize b)
        {
            return new ByteSize(b.Bytes - 1);
        }

        public static bool operator ==(ByteSize b1, ByteSize b2)
        {
            return b1.Bits == b2.Bits;
        }

        public static bool operator !=(ByteSize b1, ByteSize b2)
        {
            return b1.Bits != b2.Bits;
        }

        public static bool operator <(ByteSize b1, ByteSize b2)
        {
            return b1.Bits < b2.Bits;
        }

        public static bool operator <=(ByteSize b1, ByteSize b2)
        {
            return b1.Bits <= b2.Bits;
        }

        public static bool operator >(ByteSize b1, ByteSize b2)
        {
            return b1.Bits > b2.Bits;
        }

        public static bool operator >=(ByteSize b1, ByteSize b2)
        {
            return b1.Bits >= b2.Bits;
        }

        public static ByteSize Parse(string s)
        {
            return Parse(s, NumberFormatInfo.CurrentInfo);
        }
        public static ByteSize Parse(string s, IFormatProvider formatProvider)
        {
            return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, formatProvider);
        }

        public static ByteSize Parse(string s, NumberStyles numberStyles, IFormatProvider formatProvider)
        {

            // Arg checking
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentNullException("s", "String is null or whitespace");

            // Get the index of the first non-digit character
            s = s.TrimStart(); // Protect against leading spaces

            var num = 0;
            var found = false;

            var numberFormatInfo = NumberFormatInfo.GetInstance(formatProvider);
            var decimalSeparator = Convert.ToChar(numberFormatInfo.NumberDecimalSeparator);
            var groupSeparator = Convert.ToChar(numberFormatInfo.NumberGroupSeparator);

            // Pick first non-digit number
            for (num = 0; num < s.Length; num++)
                if (!(char.IsDigit(s[num]) || s[num] == decimalSeparator || s[num] == groupSeparator))
                {
                    found = true;
                    break;
                }

            if (found == false)
                throw new FormatException($"No byte indicator found in value '{s}'.");

            int lastNumber = num;

            // Cut the input string in half
            string numberPart = s.Substring(0, lastNumber).Trim();
            string sizePart = s.Substring(lastNumber, s.Length - lastNumber).Trim();

            // Get the numeric part
            double number;
            if (!double.TryParse(numberPart, numberStyles, formatProvider, out number))
                throw new FormatException($"No number found in value '{s}'.");

            // Get the magnitude part
            switch (sizePart)
            {
                case "b":
                    if (number % 1 != 0) // Can't have partial bits
                        throw new FormatException($"Can't have partial bits for value '{s}'.");

                    return FromBits((long)number);

                case "B":
                    return FromBytes(number);
            }

            switch (sizePart.ToLowerInvariant())
            {
                // Binary
                case "kib":
                    return FromKibiBytes(number);

                case "mib":
                    return FromMebiBytes(number);

                case "gib":
                    return FromGibiBytes(number);

                case "tib":
                    return FromTebiBytes(number);

                case "pib":
                    return FromPebiBytes(number);

                // Decimal
                case "kb":
                    return FromKiloBytes(number);

                case "mb":
                    return FromMegaBytes(number);

                case "gb":
                    return FromGigaBytes(number);

                case "tb":
                    return FromTeraBytes(number);

                case "pb":
                    return FromPetaBytes(number);

                default:
                    throw new FormatException($"Bytes of magnitude '{sizePart}' is not supported.");
            }
        }

        public static bool TryParse(string s, out ByteSize result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch
            {
                result = new ByteSize();
                return false;
            }
        }

        public static bool TryParse(string s, NumberStyles numberStyles, IFormatProvider formatProvider, out ByteSize result)
        {
            try
            {
                result = Parse(s, numberStyles, formatProvider);
                return true;
            }
            catch
            {
                result = new ByteSize();
                return false;
            }
        }
    }
}