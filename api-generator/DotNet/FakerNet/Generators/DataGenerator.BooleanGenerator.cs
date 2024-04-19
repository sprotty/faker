namespace FakerNet
{
    partial class DataGenerator
    {
        partial class BooleanGenerator
        {
            /// <summary>
            /// Produces a boolean.
            /// </summary>
            /// <param name="trueRatio">
            /// The likelihood (as a float, out of 1.0) for the method to return ‘true`.
            /// (default value "0.5")
            /// </param>
            /// <example>
            /// <code>Faker::Boolean.boolean #=> true</code>
            /// </example>
            [FakerMethod("get_boolean")]
            public bool GetBoolean(double trueRatio = 0.5)
            {
                return this.Random.NextBoolean(trueRatio);
            }
        }
    }
}