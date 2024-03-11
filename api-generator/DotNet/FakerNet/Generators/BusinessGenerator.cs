//using System.CodeDom.Compiler;

//namespace FakerNet
//{
//    partial class CommerceGenerator
//    {
//        partial class BusinessGenerator
//        {
//            /// <summary>
//            /// Produces a credit card expiration date in the form MMYY.
//            /// </summary>
//            /// <param name="expiredRatio">
//            /// The number of expired dates to produce
//            /// 0 - all numbers are valid
//            /// 0.5 - even split of expired/valid dates
//            /// 1 - all numbers are expired
//            /// (default value "0")
//            /// </param>
//            /// <param name="separator">
//            /// The separator to place between the MM and YY
//            /// (default value "/")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Business.credit_card_expiry_date #=> <Date: 2015-11-11 ((2457338j,0s,0n),+0s,2299161j)></code>
//            /// </example>
//            [FakerMethod("credit_card_expiry_date")]
//            public string CreditCardExpiryDate(double expiredRatio = 0, string separator = "/")
//            {
//                DateTime dt;
//                if (Random.NextBoolean(expiredRatio))
//                    dt = Random.NextDateTime(DateTime.Now.AddYears(-5), DateTime.Now);
//                else
//                    dt = Random.NextDateTime(DateTime.Now, DateTime.Now.AddYears(5));

//                return dt.Month.ToString("D2") + separator + dt.Month.ToString("D4").Substring(2, 2);
//            }
//        }
//    }
//}