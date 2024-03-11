using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    partial class DataGenerator
    {
        partial class StringGenerator
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

            /// <summary>
            /// returns part of the string
            /// </summary>
            /// <param name="text">
            /// The string to get a part of
            /// </param>
            /// <param name="start">
            /// The index to start the sub string at
            /// </param>
            /// <param name="length">
            /// the number of bytes to get (by default it will return the rest of the string)
            /// (default value "nil")
            /// </param>
            [FakerMethod("sub_string")]
            public string SubString(string text, long start, long? length = null)
            {
                return text.Substring((int)start, (int)(length ?? (text.Length - start)));
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
            public string RandomString(long minLength = 50, long maxLength = 50, string alphabet = AlpahNumeric)
            {
                char[] validChars = alphabet.ToCharArray();
                int length = Random.NextInt32((int)minLength, (int)maxLength);
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
            public string RandomDigits(long length = 1) => RandomString(length, length, Digits);

            /// <summary>
            /// Adds the 'char' to the start of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
            /// </param>
            [FakerMethod("pad_left")]
            public string PadLeft(string text, long length, string @char)
            {
                if (@char.Length == 0) throw new ArgumentException("Must be 1 char long", "char");
                return text.PadLeft((int)length, @char[0]);
            }

            /// <summary>
            /// Adds the 'char' to the end of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
            /// </param>
            [FakerMethod("pad_right")]
            public string PadRight(string text, long length, string @char)
            {
                if (@char.Length== 0) throw new ArgumentException("Must be 1 char long", "char");
                return text.PadRight((int)length, @char[0]);
            }
        }
    }
}