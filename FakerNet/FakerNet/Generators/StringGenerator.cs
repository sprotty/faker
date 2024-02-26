using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    partial class StringGenerator : GeneratorBase
    {
        public const string AlphabetLower = "abcdefghijklmnopqrstuvwxyz";
        public const string AlphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string AlpahNumeric = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Digits = "0123456789";

        /// <param name="text">
        /// The string to get the length of
        /// </param>
        [FakerMethod("length")]
        public long Length(string text)
        {
            return text.Length;
        }

        /// <param name="text">
        /// The string as lower case
        /// </param>
        [FakerMethod("lower")]
        public string Lower(string text)
        {
            return text.ToLower();
        }

        /// <param name="text">
        /// The string as lower case
        /// </param>
        [FakerMethod("replace")]
        public string Replace(string text, string find, string replace)
        {
            return text.Replace(find, replace);
        }

        /// <param name="text">
        /// The string as lower case
        /// </param>
        [FakerMethod("random_string")]
        public string RandomString(int minLength = 50, int maxLength = 50, string alphabet = AlpahNumeric)
        {
            char[] validChars = alphabet.ToCharArray();
            int length = Random.NextInt32(minLength, maxLength);
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
                letters[i] = Random.NextItem(validChars);
            return new string(letters);
        }

        ///<summary>Creates a sequence of random digits</summary>
        /// <param name="length">
        /// The number of digits to create (default 1)
        /// </param>
        /// <example>#{random_digits 5} => "26845" </example>
        [FakerMethod("random_digits")]
        public string RandomDigits(int length = 1) => RandomString(length, length, Digits);

#warning No implementation defined for method select_a();
#warning No implementation defined for method utf8string();
#warning No implementation defined for method space_or_utf8_char();
#warning No implementation defined for method char_space_ratio();
#warning No implementation defined for method utf8character();
    }
}
