using System.CodeDom.Compiler;

namespace FakerNet
{
    partial class CommerceGenerator
    {
        partial class StripeGenerator
        {
            /// <summary>
            /// Produces a random ccv number.
            /// </summary>
            /// <param name="cardType">
            /// Specific valid card type.
            /// (default value null)
            /// </param>
            /// <example>
            /// <code>Faker::Stripe.ccv #=> "123"
            /// Faker::Stripe.ccv(card_type: "amex") #=> "1234"</code>
            /// </example>
            [FakerMethod("ccv")]
            public string Ccv(string? cardType = null)
            {
                throw new TodoException();
            }

            /// <summary>
            /// Produces a random invalid card number.
            /// </summary>
            /// <example>
            /// <code>Faker::Stripe.invalid_card #=> "4000000000000002"
            /// Faker::Stripe.invalid_card(card_error: "addressZipFail") #=> "4000000000000010"</code>
            /// </example>
            [FakerMethod("invalid_card")]
            public string InvalidCard()
            {
                throw new TodoException();
            }
        }

    }
}
