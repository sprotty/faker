using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    internal static class UtilityMethods
    {
        internal readonly static CultureInfo EnglishCulture = new CultureInfo("en");

        /// <summary>
        /// Convert the specified locale into a chain of locales used for message resolution. For example:
        /// </summary>
        /// <example>(fr_FR) -> [ fr_FR, anotherTest, en ]</example>
        /// <param name="from"></param>
        /// <returns>a list of <see cref="CultureInfo"/>} instance</returns>
        internal static CultureInfo[] GetLocaleChain(this CultureInfo from)
        {
            if (UtilityMethods.EnglishCulture.Equals(from))
            {
                return new[] { UtilityMethods.EnglishCulture };
            }
            CultureInfo normalized = from;

            List<CultureInfo> chain = new List<CultureInfo>(3);
            chain.Add(normalized);
            if (normalized.GetCountry() != "" &&
                UtilityMethods.EnglishCulture.GetLanguage() != normalized.GetLanguage())
            {
                chain.Add(new CultureInfo(normalized.GetLanguage()));
            }
            chain.Add(UtilityMethods.EnglishCulture); // default
            return chain.ToArray();
        }

        public static string GetLanguage(this CultureInfo culture)
        {
            return culture.TwoLetterISOLanguageName;
            //var r = new RegionInfo(culture.LCID);
            //return r.TwoLetterISORegionName;
        }
        public static string? GetCountry(this CultureInfo culture)
        {
            if (culture.Equals(CultureInfo.InvariantCulture) || //Remove the invariant culture as a region cannot be created from it.
                culture.IsNeutralCulture) //Remove Neutral cultures as a region cannot be created from them.
                return null;

            var r = new RegionInfo(culture.LCID);
            return r.TwoLetterISORegionName;
        }

        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }

    public class UNKNWON_Hash { }
    public class UNKNWON_Number { }
    public class UNKNWON_Symbol { }
    public class IntegerRange
    {
        public IntegerRange(long min, long max)
        {
            Min = min;
            Max = max;
        }
        public IntegerRange(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public long Min { get; }
        public long Max { get; }

        public static IntegerRange Parse(string numericRange)
        {
            int indexOfSep = numericRange.IndexOf("..");
            if (indexOfSep <= 0 || indexOfSep >= numericRange.Length - 1)
                throw new ArgumentException("Expected form is '0..1'");

            long min = long.Parse(numericRange.Substring(0, indexOfSep));
            long max = long.Parse(numericRange.Substring(indexOfSep + 2));
            return new IntegerRange(min, max);
        }

        public override string ToString()
        {
            return $"{Min}..{Max}";
        }

        public static implicit operator IntegerRange(string d) => IntegerRange.Parse(d);
    }
    public class FloatRange
    {
        public FloatRange(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public double Min { get; }
        public double Max { get; }

        public static FloatRange Parse(string numericRange)
        {
            int indexOfSep = numericRange.IndexOf("..");
            if (indexOfSep <= 0 || indexOfSep >= numericRange.Length - 1)
                throw new ArgumentException("Expected form is '0..1'");

            double min = double.Parse(numericRange.Substring(0, indexOfSep));
            double max = double.Parse(numericRange.Substring(indexOfSep + 2));
            return new FloatRange(min, max);
        }

        public override string ToString()
        {
            return $"{Min}..{Max}";
        }

        public static implicit operator FloatRange(string d) => FloatRange.Parse(d);
    }
}
