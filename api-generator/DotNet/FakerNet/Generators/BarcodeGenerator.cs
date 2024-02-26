using System.CodeDom.Compiler;
using System.Globalization;
using System.Numerics;

namespace FakerNet
{
    partial class BarcodeGenerator
    {
        /// <summary>
        /// Adds the check digit to the barcode
        /// </summary>
        /// <param name="barcodeDigits">
        /// The barcode digits to create a bar code from 
        /// </param>
        /// <return>
        /// A complete numeric barcode including the check digit.
        /// </return>
        [FakerMethod("generate_barcode")]
        public string GenerateBarcode(string barcodeDigits)
        {
            string checkDigit = GenerateCheckDigit(barcodeDigits);
            return $"{barcodeDigits}{checkDigit}";
        }

        private string GenerateCheckDigit(string barcodeDigits)
        {
            BigInteger number = BigInteger.Parse(new string(barcodeDigits.Reverse().ToArray()));
            BigInteger sum_even = 0, sum_odd = 0, index = 1;

            while (number != 0)
            {
                if (index % 2 == 0)
                    sum_even += number % 10;
                else
                    sum_odd += number % 10;
                number /= 10;
                index += 1;
            }

            return ((10 - (sum_odd + sum_even * 3) % 10) % 10).ToString(CultureInfo.InvariantCulture);
        }
    }
}
