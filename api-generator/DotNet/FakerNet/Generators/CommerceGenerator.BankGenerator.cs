using System.CodeDom.Compiler;
using System.Globalization;
using System.Numerics;

namespace FakerNet
{
    partial class CommerceGenerator
    {
        partial class BankGenerator
        {
            /// <summary>
            /// Produces an Australian BSB (Bank-State-Branch) number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.bsb_number
            /// #=> "036616"</code>
            /// </example>
            [FakerMethod("bsb_number")]
            public string BsbNumber()
            {
                return compile_bsb_number();
            }

            /// <summary>
            /// Produces a bank iban number.
            /// </summary>
            /// <param name="countryCode">
            /// Specifies what country prefix is used to generate the iban code. Providing ‘nil` will use a random country.
            /// (default value 
            /// null
            ///  [Random Country]
            /// )
            /// </param>
            /// <example>
            /// <code>Faker::Bank.iban #=> "GB76DZJM33188515981979"
            /// Faker::Bank.iban(country_code: "be") #=> "BE6375388567752043"
            /// Faker::Bank.iban(country_code: nil) #=> "DE45186738071857270067"</code>
            /// </example>
            [FakerMethod("iban")]
            public string Iban(string? countryCode = null)
            {
                // Each country has its own format for bank accounts
                // Many of them use letters in certain parts of the account
                // Using regex patterns we can create virtually any type of bank account
                countryCode ??= IbanCountryCode();

                object? yamlContext = null;
                if (Faker.TryFetchYamlValue($"bank.iban_details.{countryCode.ToLower()}.bban_pattern", ref yamlContext, out var pattern, out _) == false)
                    throw new InvalidOperationException($"Could not find iban details for {countryCode}");

                // Use Faker::Base.regexify for creating a sample from bank account format regex
                var account = Regexify(pattern);

                // Add country code and checksum to the generated account to form valid IBAN
                return countryCode.ToUpper() + IbanChecksum(countryCode, account) + account;
            }

            /// <summary>
            /// Produces the ISO 3166 code of a country that uses the IBAN system.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.iban_country_code #=> "CH"</code>
            /// </example>
            [FakerMethod("iban_country_code")]
            public string IbanCountryCode()
            {
                return ((string)Random.NextItem(Faker.FetchYamlMap("bank.iban_details").Keys)).ToUpper();
            }

            /// <summary>
            /// Produces a routing number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.routing_number #=> "729343831"</code>
            /// </example>
            [FakerMethod("routing_number")]
            public string RoutingNumber()
            {
                return valid_routing_number();
            }

            /// <summary>
            /// Produces a valid routing number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.routing_number #=> "729343831"</code>
            /// </example>
            [FakerMethod("routing_number_with_format")]
            public string RoutingNumberWithFormat()
            {
                return compile_fraction(valid_routing_number());
            }

            private string Checksum(string num_string)
            {
                int[] num_array = num_string.Select(c => int.Parse(c.ToString())).ToArray();
                int checksum = (
                  7 * (num_array[0] + num_array[3] + num_array[6]) +
                    3 * (num_array[1] + num_array[4] + num_array[7]) +
                    9 * (num_array[2] + num_array[5])
                ) % 10;
                return checksum.ToString(CultureInfo.InvariantCulture);
            }

            private bool valid_checksum(string routing_number, string checksum)
            {
                return routing_number[8] == checksum[0];
            }

            // Calculates the mandatory checksum in 3rd and 4th characters in IBAN format
            // source: https://en.wikipedia.org/wiki/International_Bank_Account_Number#Generating_IBAN_check_digits
            private string IbanChecksum(string country_code, string account)
            {
                // Converts letters to numbers according the iban rules, A=10..Z=35
                BigInteger ibanNumbers =
                    BigInteger.Parse(
                        string.Concat(
                            $"{account}{country_code}00"
                                .ToUpper()
                                .ToCharArray()
                                .Select(c => (c >= 'A' && c <= 'Z') ? (c - 55).ToString() : c.ToString())));

                // This is the correct answer to (iban_to_num + checksum) % 97 == 1
                var checksum = 98 - (ibanNumbers % 97);

                // Use leftpad to make the size always to 2
                string checksumStr = checksum.ToString("D2", CultureInfo.InvariantCulture);
                return checksumStr;
            }

            private string compile_bsb_number()
            {
                string digit01 = Random.NextItem(["01", "03", "06", "08", "11", "12", "73", "76", "78", "30"]);
                string state = Random.NextItem(["2", "3", "4", "5", "6", "7"]);
                return digit01 + state + Faker.Data.String.RandomDigits(3);
            }

            /// <summary>
            /// An 9 digit routing number (last digit is a checksum which may NOT be valid)
            /// </summary>
            /// <returns></returns>
            private string compile_routing_number()
            {
                var digit01AllowedValues = Enumerable.Range(0, 12).Concat(Enumerable.Range(21, 32 - 21)).Concat(Enumerable.Range(61, 72 - 61)).Append(80);
                var digit01 = Random.NextItem(digit01AllowedValues).ToString("D2", CultureInfo.InvariantCulture);
                return digit01 + Faker.Data.String.RandomDigits(7);
            }

            private string compile_fraction(string routing_num)
            {
                string prefix = Random.NextInt32(1, 50).ToString();
                string numerator = int.Parse(routing_num.Substring(5, 4)).ToString(CultureInfo.InvariantCulture);
                string denominator = int.Parse(routing_num.Substring(0, 5)).ToString(CultureInfo.InvariantCulture);
                return $"{prefix}-{numerator}/{denominator}";
            }

            /// <summary>
            /// An 9 digit routing number (last digit is a checksum which IS valid)
            /// </summary>
            private string valid_routing_number()
            {
                var routing_number = compile_routing_number();
                var checksum = Checksum(routing_number);
                if (valid_checksum(routing_number, checksum))
                    return routing_number;
                else
                    return routing_number.Substring(0, 8) + checksum;
            }
        }
    }
}