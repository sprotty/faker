using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
        /// <example>(fr-FR) -> [ fr-FR, fr, en ]</example>
        /// <param name="locale"></param>
        /// <returns>a list of <see cref="CultureInfo"/>} instance</returns>
        internal static CultureInfo[] GetLocaleChain(this CultureInfo locale)
        {
            List<CultureInfo> chain = new List<CultureInfo>(3);
            if (EnglishCulture.Equals(locale) == false)
            {
                chain.Add(locale);
                if (string.IsNullOrWhiteSpace(locale.GetCountry()) == false)
                {
                    chain.Add(new CultureInfo(locale.GetLanguage()));
                }
            }
            chain.Add(EnglishCulture); // default
            return chain.ToArray();
        }

        public static string GetLanguage(this CultureInfo culture)
        {
            return culture.TwoLetterISOLanguageName;
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

        #region FirstLetterToLower
        public static string FirstLetterToLower(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return str.Substring(0, 1).ToLower() + str.Substring(1);
        }
        #endregion

        #region FirstLetterToUpper
        public static string FirstLetterToUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
        #endregion

        #region RemoveTrailing
        public static string RemoveTrailing(this string str, params char[] charsToRemove)
        {
            int i = str.Length - 1;
            while (i >= 0 && charsToRemove.Contains(str[i]))
                i--;
            return str.Substring(0, i + 1);
        }
        #endregion

        public static string GetEnumDisplayName(Enum value)
        {
            DisplayAttribute? displayAttr;

            var fieldInfo = value.GetType().GetField(value.ToString());

            if ((displayAttr = fieldInfo?.GetCustomAttribute<DisplayAttribute>()) != null && displayAttr.Name != null)
                return displayAttr.Name;

            return value.ToString();
        }

        public static string GetEnumDesc(Enum value)
        {
            DisplayAttribute? displayAttr;

            var fieldInfo = value.GetType().GetField(value.ToString());

            if ((displayAttr = fieldInfo?.GetCustomAttribute<DisplayAttribute>()) != null && displayAttr.Description != null)
                return displayAttr.Description;

            return value.ToString();
        }

        public static string GetEnumValue(Enum value)
        {
            DisplayAttribute? displayAttr;

            var fieldInfo = value.GetType().GetField(value.ToString());

            if ((displayAttr = fieldInfo?.GetCustomAttribute<DisplayAttribute>()) != null && displayAttr.ShortName != null)
                return displayAttr.ShortName;

            return value.ToString();
        }

    }

    //public class UNKNWON_Hash { }
    //public class UNKNWON_Number { }
    //public class UNKNWON_Symbol { }
    internal class IntegerRange
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

        public static implicit operator IntegerRange(string d) => Parse(d);
    }
    //public class FloatRange
    //{
    //    public FloatRange(double min, double max)
    //    {
    //        Min = min;
    //        Max = max;
    //    }

    //    public double Min { get; }
    //    public double Max { get; }

    //    public static FloatRange Parse(string numericRange)
    //    {
    //        int indexOfSep = numericRange.IndexOf("..");
    //        if (indexOfSep <= 0 || indexOfSep >= numericRange.Length - 1)
    //            throw new ArgumentException("Expected form is '0..1'");

    //        double min = double.Parse(numericRange.Substring(0, indexOfSep));
    //        double max = double.Parse(numericRange.Substring(indexOfSep + 2));
    //        return new FloatRange(min, max);
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Min}..{Max}";
    //    }

    //    public static implicit operator FloatRange(string d) => Parse(d);
    //}
}
