using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    public static class BinaryHelper
    {
        public static readonly char[] Base58Alphabet = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz".ToCharArray();

        #region Base58Encode
        internal static string Base58Encode(byte[] input)
        {

            if (0 == input.Length)
            {
                return String.Empty;
            }
            input = CopyOfRange(input, 0, input.Length);
            // Count leading zeroes.
            int zeroCount = 0;
            while (zeroCount < input.Length && input[zeroCount] == 0)
            {
                zeroCount++;
            }
            // The actual encoding.
            byte[] temp = new byte[input.Length * 2];
            int j = temp.Length;

            int startAt = zeroCount;
            while (startAt < input.Length)
            {
                byte mod = DivMod58(input, startAt);
                if (input[startAt] == 0)
                {
                    startAt++;
                }
                temp[--j] = (byte)Base58Alphabet[mod];
            }

            // Strip extra '1' if there are some after decoding.
            while (j < temp.Length && temp[j] == Base58Alphabet[0])
            {
                ++j;
            }
            // Add as many leading '1' as there were leading zeros.
            while (--zeroCount >= 0)
            {
                temp[--j] = (byte)Base58Alphabet[0];
            }

            byte[] output = CopyOfRange(temp, j, temp.Length);
            try
            {
                return Encoding.ASCII.GetString(output);
            }
            catch (DecoderFallbackException e)
            {
                Console.WriteLine(e.ToString());
                return String.Empty;
            }


            byte DivMod58(byte[] number, int startAt)
            {
                int remainder = 0;
                for (int i = startAt; i < number.Length; i++)
                {
                    int digit256 = (int)number[i] & 0xFF;
                    int temp = remainder * 256 + digit256;

                    number[i] = (byte)(temp / 58);

                    remainder = temp % 58;
                }

                return (byte)remainder;
            }
            byte DivMod256(byte[] number58, int startAt)
            {
                int remainder = 0;
                for (int i = startAt; i < number58.Length; i++)
                {
                    int digit58 = (int)number58[i] & 0xFF;
                    int temp = remainder * 58 + digit58;

                    number58[i] = (byte)(temp / 256);

                    remainder = temp % 256;
                }

                return (byte)remainder;
            }
            byte[] CopyOfRange(byte[] source, int from, int to)
            {
                byte[] range = new byte[to - from];
                for (int i = 0; i < to - from; i++)
                {
                    range[i] = source[from + i];
                }
                return range;
            }
        }

        #endregion

        #region CreateSHA256Digest
        internal static byte[] CreateSHA256Digest(byte[] data)
        {
            using (var sha256Hash = SHA256.Create())
            {
                return sha256Hash.ComputeHash(data);
            }
        }
        #endregion

        //#region HexDecode
        //public static byte[] HexDecode(string hex)
        //{
        //    int NumberChars = hex.Length;
        //    byte[] bytes = new byte[NumberChars / 2];
        //    for (int i = 0; i < NumberChars; i += 2)
        //        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        //    return bytes;
        //} 
        //#endregion

        #region IsEqual
        /// <summary>
        /// Determines if the contents of 2 arrays are the same
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool IsEqual(byte[] a, byte[] b)
        {
            if (a == b)
                return true;
            if (a == null || a == null)
                return false;
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
        #endregion
    }
}
