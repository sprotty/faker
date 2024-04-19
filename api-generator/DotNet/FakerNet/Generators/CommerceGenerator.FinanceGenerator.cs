using System.CodeDom.Compiler;

namespace FakerNet
{
    partial class CommerceGenerator
    {
        partial class FinanceGenerator
        {
            /// <summary>
            /// Produces a random credit card number.
            /// </summary>
            /// <param name="cardType">
            /// Specific credit card type (see CreditCard.CardTypes).
            /// (default value null [Random card type])
            /// </param>
            /// <param name="includeFormatting">
            /// includes formatting chars i.e. 3787-866288-08162
            /// (default value "true")
            /// </param>
            /// <example>
            /// <code>Faker::Finance.credit_card #=> "3018-348979-1853"
            /// Faker::Finance.credit_card(:mastercard) #=> "6771-8921-2291-6236"
            /// Faker::Finance.credit_card(:mastercard, :visa) #=> "4448-8934-1277-7195"</code>
            /// </example>
            [FakerMethod("credit_card")]
            public string CreditCard(string? cardType = null, bool includeFormatting = true)
            {
                // Each country has its own format for bank accounts
                // Many of them use letters in certain parts of the account
                // Using regex patterns we can create virtually any type of bank account
                cardType ??= Faker.Commerce.Business.CreditCardType();


                object? yamlContext = null;
                string numerfiedRegExExpr;
                object? numerfiedRegExExprObj = Faker.FetchYamlObject($"finance.credit_card.{cardType.ToLower()}", ref yamlContext);
                if (numerfiedRegExExprObj is string str)
                    numerfiedRegExExpr = str;
                else if (numerfiedRegExExprObj is List<object> lst && lst.Count > 0 && Random.NextItem(lst) is string lstItemStr)
                    numerfiedRegExExpr = lstItemStr;
                else
                    throw new InvalidOperationException($"Could not find card type {cardType}");

                var regExExpr = Numerify(numerfiedRegExExpr);
                var formattedCardNoLun = (Faker.IsSlashDelimitedRegex(regExExpr)) ? Faker.TrimRegexSlashesAndEscape(Regexify(regExExpr)) : regExExpr;
                var cardNoLun = string.Concat(formattedCardNoLun.Where(c => char.IsDigit(c)));
                var lunDigit = GetLuhnCheckSum(cardNoLun).ToString("D1");
                return includeFormatting ? formattedCardNoLun.Replace("L", lunDigit) : cardNoLun.Replace("L", lunDigit);
            }


            /// <summary>
            /// Produces a random vat number.
            /// </summary>
            /// <param name="countryCode">
            /// Two capital letter country code to use for the vat number.
            /// (default value null [Random Country])
            /// </param>
            /// <example>
            /// <code>Faker::Finance.vat_number #=> "BR38.395.329/2471-83"
            /// Faker::Finance.vat_number('DE') #=> "DE593306671"
            /// Faker::Finance.vat_number('ZA') #=> "ZA79494416181"</code>
            /// </example>
            [FakerMethod("vat_number")]
            public string VatNumber(string? countryCode = null)
            {
                var vatEntries = Faker.FetchYamlMap("finance.vat_number");
                countryCode ??= Random.NextItem(vatEntries.Keys) as string;
                return this.Numerify(this.Letterify(this.ResolveYamlValue($"finance.vat_number.{countryCode.ToUpper()}")));
            }

            /// <summary>
            /// Returns a randomly-selected stock ticker from a specified market.
            /// </summary>
            /// <param name="market">
            /// The name of the market to choose the ticker from (e.g. NYSE, NASDAQ) 
            /// See Commerce.StockMarket.Market
            /// (default value null [Random Market])
            /// </param>
            /// <example>
            /// <code>Faker::Finance.ticker #=> 'AMZN'
            /// Faker::Finance.vat_number('NASDAQ') #=> 'GOOG'</code>
            /// </example>
            [FakerMethod("ticker")]
            public string Ticker(string? market = null)
            {
                var vatEntries = Faker.FetchYamlMap("finance.ticker");
                market ??= Random.NextItem(vatEntries.Keys) as string;
                return this.Numerify(this.Letterify(this.ResolveYamlValue($"finance.ticker.{market.ToLower()}")));
            }


            private static readonly Dictionary<char, int> CharacterMap =
                "0123456789"
                    .Select((x, i) => (x, i))
                    .ToDictionary(x => x.x, x => x.i);

            private static int GetLuhnCheckSum(string value)
            {
                if (!value.All(CharacterMap.ContainsKey))
                    throw new ArgumentException("Value contains invalid characters", nameof(value));

                int @base = CharacterMap.Count;
                var parity = true;
                var sum = 0;

                // process the number from right to left
                foreach (var c in value.Reverse())
                {
                    var digit = CharacterMap[c];

                    // From the rightmost digit, which is the check digit, and moving left, double the value of every second digit.
                    if (parity)
                    {
                        digit *= 2;

                        // If the result of this doubling operation is greater than 9, then add the digits of the product.
                        if (digit >= @base)
                            digit = digit % @base + 1;
                    }

                    parity = !parity;
                    sum += digit;
                }

                // The check digit (x) is obtained by computing the sum of the other digits then subtracting the units digit from 10
                return (@base - (sum % @base)) % @base;
            }
        }

    }
}
