using System.CodeDom.Compiler;
using System.Text;

namespace FakerNet
{
    partial class DataGenerator
    {
        partial class NumberGenerator
        {
            private static readonly int[] NonZeroValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /// <summary>
            /// Produces a binary number 1s and 0s.
            /// </summary>
            /// <param name="digits">
            /// Number of digits to generate the binary as string
            /// (default value "4")
            /// </param>
            /// <example>
            /// <code>Faker::Number.binary(digits: 4) #=> "1001"</code>
            /// </example>
            [FakerMethod("binary")]
            public string Binary(long digits = 4)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < digits; i++)
                {
                    stringBuilder.Append(Random.NextBoolean() ? '0' : '1');
                }
                return stringBuilder.ToString();
            }

            /// <summary>
            /// Produces a decimal value
            /// </summary>
            /// <param name="wholeNumberDigits">
            /// Number of digits that the generated decimal should have to the left of the decimal point.
            /// (default value "5")
            /// </param>
            /// <param name="factionalDigits">
            /// Number of digits that the generated decimal should have to the right of the decimal point.
            /// (default value "2")
            /// </param>
            /// <example>
            /// <code>Faker::Number.decimal(l_digits: 2) #=> 11.88
            /// Faker::Number.decimal(l_digits: 3, r_digits: 3) #=> 181.843</code>
            /// </example>
            [FakerMethod("decimal")]
            public string Decimal(long wholeNumberDigits = 5, long factionalDigits = 2)
            {
                if (wholeNumberDigits <= 0) throw new ArgumentException("Must be greater than 0", "wholeNumberDigits");
                if (factionalDigits < 0) throw new ArgumentException("Must be greater than or equal to 0", "factionalDigits");
                var result = NonZeroDigit().ToString("D1") + Faker.Data.String.RandomDigits(wholeNumberDigits - 1);
                if (factionalDigits > 0)
                    result += "." + Faker.Data.String.RandomDigits(factionalDigits);
                return result;
            }

            /// <summary>
            /// Creates a random integer number
            /// </summary>
            /// <param name="min">
            /// A value greater than or equal to this will be generated
            /// (default value "0")
            /// </param>
            /// <param name="max">
            /// A value less than or equal to this will be generated
            /// (default value "1000000")
            /// </param>
            [FakerMethod("Integer")]
            public long Integer(long min = 0, long max = 1000000)
            {
                if (min < 0) throw new ArgumentException("Must be greater than or equal to 0", "min");
                if (min > max) throw new ArgumentException("min must be less than max", "min");
                return Random.NextInt64(min, max);
            }

            /// <summary>
            /// Produces a negative float.
            /// </summary>
            /// <param name="from">
            /// The lower boundary.
            /// (default value "-1000000")
            /// </param>
            /// <param name="to">
            /// The higher boundary.
            /// (default value "0")
            /// </param>
            /// <example>
            /// <code>Faker::Number.negative #=> -4480.042585669558</code>
            /// </example>
            [FakerMethod("negative")]
            public double Negative(long min = -1000000, long max = 0)
            {
                if (min < 0) throw new ArgumentException("Must be greater than or equal to 0", "min");
                if (min > max) throw new ArgumentException("min must be less than max", "min");
                return Random.NextDouble(min, max);
            }

            /// <summary>
            /// Produces a non-zero single-digit integer.
            /// </summary>
            /// <example>
            /// <code>Faker::Number.non_zero_digit #=> 8</code>
            /// </example>
            [FakerMethod("non_zero_digit")]
            public long NonZeroDigit()
            {
                return Random.NextItem(NonZeroValues);
            }

            /// <summary>
            /// Produces a float given a mean and standard deviation.
            /// </summary>
            /// <param name="mean">
            /// </param>
            /// <param name="standardDeviation">
            /// (default value "1")
            /// </param>
            /// <example>
            /// <code>Faker::Number.normal(mean: 50, standard_deviation: 3.5) #=> 47.14669604069156</code>
            /// </example>
            [FakerMethod("normal")]
            public double Normal(long mean, double? standardDeviation = null)
            {
                // Ported from Ruby Faker - doesn't look right though
                standardDeviation ??= 3.5;
                double rand = Random.NextDouble();
                double theta = 2 * Math.PI * rand;
                double rho = Math.Sqrt(-2 * Math.Log(1 - rand));
                double scale = standardDeviation.Value * rho;
                double result = mean + scale * Math.Cos(theta);
                return result;
            }

            /// <summary>
            /// Produces a positive float.
            /// </summary>
            /// <param name="from">
            /// The lower boundary.
            /// (default value "0")
            /// </param>
            /// <param name="to">
            /// The higher boundary.
            /// (default value "1000000")
            /// </param>
            /// <example>
            /// <code>Faker::Number.positive #=> 235.59238499107653</code>
            /// </example>
            [FakerMethod("positive")]
            public double Positive(long min = 0, long max = 1000000)
            {
                if (min < 0) throw new ArgumentException("Must be greater than or equal to 0", "min");
                if (min > max) throw new ArgumentException("min must be less than max", "min");
                return Random.NextDouble(min, max);
            }
            /// <summary>
            /// Produces a number within two provided values.
            ///                             <p>Boundaries are inclusive or exclusive depending on the range passed.</p>
            /// </summary>
            /// <param name="min">
            /// The number generated will be greater than or equal to this value
            /// (default value "-10000")
            /// </param>
            /// <param name="max">
            /// The number generated will be greater than or equal to this value.
            /// (default value "10000")
            /// </param>
            /// <example>
            /// <code>Faker::Number.within(range: 1..10) #=> 7
            /// Faker::Number.within(range: 0.0..1.0) #=> 0.7844640543957383</code>
            /// </example>
            [FakerMethod("within")]
            public double Within(double min = -10000, double max = 10000)
            {
                if (min < 0) throw new ArgumentException("Must be greater than or equal to 0", "min");
                if (min > max) throw new ArgumentException("min must be less than max", "min");
                return Random.NextDouble(min, max);
            }
        }

    }
}
