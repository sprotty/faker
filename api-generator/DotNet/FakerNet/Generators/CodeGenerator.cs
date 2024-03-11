//using System.CodeDom.Compiler;
//using System.Text;

//namespace FakerNet
//{
//    partial class CommerceGenerator
//    {
//        partial class CodeGenerator
//        {
//            #region Ean
//            /// <summary>
//            /// Produces a random EAN (European Article Number) code.
//            /// </summary>
//            /// <param name="digits">
//            /// the length of the code to generate (either 8 or 13)
//            /// (default value "13")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Code.ean(digits: 8) #=> "36941070"</code>
//            /// </example>
//            [FakerMethod("ean")]
//            public string Ean(long digits = 13)
//            {
//                char[] values;
//                int sum = 0;

//                if (digits == 13)
//                {
//                    values = Regexify("\\d{12}").ToCharArray();
//                    for (int i = 0; i < values.Length; i++)
//                    {
//                        sum += int.Parse(values[i].ToString()) * GTIN_13_CHECK_DIGITS[i];
//                    }
//                }
//                else if (digits == 8)
//                {
//                    values = Regexify("\\d{7}").ToCharArray();
//                    for (int i = 0; i < values.Length; i++)
//                    {
//                        sum += int.Parse(values[i].ToString()) * GTIN_8_CHECK_DIGITS[i];
//                    }
//                }
//                else
//                    throw new ArgumentOutOfRangeException(nameof(digits), "Valid values are 10 and 13.");

//                int checkDigit = 10 - sum % 10;
//                if (checkDigit == 10)
//                    return new string(values) + "0";
//                else
//                    return new string(values) + checkDigit.ToString();
//            }

//            private static readonly int[] GTIN_8_CHECK_DIGITS = { 3, 1, 3, 1, 3, 1, 3 };
//            private static readonly int[] GTIN_13_CHECK_DIGITS = { 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };
//            #endregion

//            #region Imei
//            /// <summary>
//            /// Produces a random IMEI (International Mobile Equipment Number) code.
//            /// </summary>
//            /// <example>
//            /// <code>Faker::Code.imei #=> "492033129092256"</code>
//            /// </example>
//            [FakerMethod("imei")]
//            public string Imei()
//            {
//                // Fill in the first two values of the string based with the specified prefix.
//                string str = Random.NextItem(REPORTING_BODY_IDENTIFIERS);

//                // Fill all the remaining numbers except for the last one with random values.
//                str += Faker.Data.String.RandomDigits(12);

//                // Calculate the Luhn checksum of the values thus far
//                int lenOffset = str.Length % 2;
//                int t = 0;
//                int sum = 0;
//                for (int i = 0; i < str.Length; i++)
//                {
//                    if ((i + lenOffset) % 2 != 0)
//                    {
//                        t = int.Parse(str[i].ToString()) * 2;
//                        if (t > 9)
//                        {
//                            t -= 9;
//                        }

//                        sum += t;
//                    }
//                    else
//                    {
//                        sum += int.Parse(str[i].ToString());
//                    }
//                }

//                // Choose the last digit so that it causes the entire string to pass the checksum.
//                str += ((10 - (sum % 10)) % 10).ToString();

//                return str;
//            }
//            private static readonly String[] REPORTING_BODY_IDENTIFIERS = { "01", "10", "30", "33", "35", "44", "45", "49", "50", "51", "52", "53", "54", "86", "91", "98", "99" };
//            #endregion

//            #region Isbn
//            /// <summary>
//            /// Produces a random ISBN (International Standard Book Number) code.
//            /// </summary>
//            /// <param name="digits">
//            /// the length of the code to generate (either 10 or 13)
//            /// (default value "10")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Code.isbn(digits: 13) #=> "896579606969-8"</code>
//            /// </example>
//            [FakerMethod("isbn")]
//            public string Isbn(long digits = 10, bool separator = false)
//            {
//                if (digits == 13)
//                {
//                    string isbn13RandomCheckDigit = "978-" + this.Numerify(ResolveYamlValue("code.isbn_10_patterns"));
//                    string isbn13NoCheckDigit = isbn13RandomCheckDigit.Substring(0, isbn13RandomCheckDigit.Length - 1);
//                    int checkDigit = Isbn13CheckDigit(isbn13NoCheckDigit);
//                    string isbn13 = isbn13NoCheckDigit + (checkDigit != 10 ? checkDigit.ToString() : "X");
//                    return separator ? isbn13.ToString() : StripIsbnSeparator(isbn13.ToString());
//                }
//                else if (digits == 10)
//                {
//                    string isbn10RandomCheckDigit = this.Numerify(ResolveYamlValue("code.isbn_10_patterns"));
//                    string isbn10NoCheckDigit = isbn10RandomCheckDigit.Substring(0, isbn10RandomCheckDigit.Length - 1);
//                    int checkDigit = Isbn10CheckDigit(isbn10NoCheckDigit);
//                    string isbn10 = isbn10NoCheckDigit + (checkDigit != 10 ? checkDigit.ToString() : "X");
//                    return separator ? isbn10.ToString() : StripIsbnSeparator(isbn10.ToString());
//                }
//                else
//                    throw new ArgumentOutOfRangeException(nameof(digits), "Valid values are 10 and 13.");
//            }

//            private int Isbn10CheckDigit(string t)
//            {
//                String value = StripIsbnSeparator(t);
//                int sum = 0;
//                for (int i = 0; i < value.Length; i++)
//                {
//                    sum += ((i + 1) * int.Parse(value[i].ToString()));
//                }
//                return sum % 11;
//            }

//            private int Isbn13CheckDigit(string t)
//            {
//                String value = StripIsbnSeparator(t);
//                int sum = 0;
//                int multiplier = 0;
//                for (int i = 0; i < value.Length; i++)
//                {
//                    multiplier = i % 2 == 0 ? 1 : 3;
//                    sum += multiplier * int.Parse(value[i].ToString());
//                }

//                return (10 - sum % 10) % 10;
//            }

//            private String StripIsbnSeparator(string t)
//            {
//                return t.Replace("-", "");
//            }
//            #endregion


//            /// <summary>
//            /// Produces a random NPI (National Provider Identifier) code.
//            /// </summary>
//            /// <example>
//            /// <code>Faker::Code.npi #=> "9804062802"</code>
//            /// </example>
//            [FakerMethod("npi")]
//            public string Npi()
//            {
//                throw new TodoException();
//            }
//            /// <summary>
//            /// Produces a random NRIC (National Registry Identity Card) code.
//            /// <p>By default generates a Singaporean NRIC ID for someone who is born between the age of 18 and 65.</p>
//            /// </summary>
//            /// <param name="minAge">
//            /// the min age of the person in years
//            /// (default value "18")
//            /// </param>
//            /// <param name="maxAge">
//            /// the max age of the person in years
//            /// (default value "65")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Code.nric(min_age: 25, max_age: 50) #=> "S9347283G"</code>
//            /// </example>
//            [FakerMethod("nric")]
//            public string Nric(long minAge = 18, long maxAge = 65)
//            {
//                throw new TodoException();
//            }
//            /// <summary>
//            /// Produces a random RUT (Rol Unico Nacional) code.
//            /// </summary>
//            /// <example>
//            /// <code>Faker::Code.rut #=> "91611842-2"</code>
//            /// </example>
//            [FakerMethod("rut")]
//            public string Rut()
//            {
//                throw new TodoException();
//            }
//            /// <summary>
//            /// Produces a random SIN (Social Insurance Number for Canada) code.
//            /// </summary>
//            /// <example>
//            /// <code>Faker::Code.sin #=> "996586962"</code>
//            /// </example>
//            [FakerMethod("sin")]
//            public string Sin()
//            {
//                throw new TodoException();
//            }
//        }
//    }
//}