using System.CodeDom.Compiler;

namespace FakerNet
{
    partial class PersonGenerator
    {


        partial class PhoneNumberGenerator
        {
            /// <summary>
            /// Produces a random cell phone number with country code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.cell_phone_with_country_code #=> "+852 (190) 987-9034"
            /// Faker::PhoneNumber.cell_phone_with_country_code #=> "+64 (820) 583-6474"
            /// Faker::PhoneNumber.cell_phone_with_country_code #=> "+1 591.871.7985"</code>
            /// </example>
            [FakerMethod("cell_phone_with_country_code")]
            public string CellPhoneWithCountryCode()
            {
                return GetNumberWithCountryCode(this.CellPhone());
            }

            /// <summary>
            /// Produces a random phone number with country code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.phone_number_with_country_code #=> "+55 466-746-6882"
            /// Faker::PhoneNumber.phone_number_with_country_code #=> "+81 3718219558"
            /// Faker::PhoneNumber.phone_number_with_country_code #=> "+49 140 957 9846"</code>
            /// </example>
            [FakerMethod("phone_number_with_country_code")]
            public string PhoneNumberWithCountryCode()
            {
                return GetNumberWithCountryCode(this.PhoneNumber());
            }

            private string GetNumberWithCountryCode(string phoneNumberWithDialingCode)
            {
                if (phoneNumberWithDialingCode.FirstOrDefault(c => char.IsDigit(c)) == '0')
                    phoneNumberWithDialingCode = phoneNumberWithDialingCode.ReplaceFirst("0", "");
                return $"+{CountryCode()} {phoneNumberWithDialingCode}";
            }
        }
    }
}
