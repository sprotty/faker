//using System.CodeDom.Compiler;

//namespace FakerNet
//{
//    partial class DataGenerator
//    {
//        partial class ColorGenerator
//        {
//            /// <summary>
//            /// Produces a hex color code.
//            ///                             <p>Clients are able to specify the hue, saturation, or lightness of the required color. Alternatively a client can simply specify that they need a light or dark color.</p>
//            /// </summary>
//            /// <param name="red">
//            /// The red component (0-255)
//            /// (default value "nil")
//            /// </param>
//            /// <param name="green">
//            /// The green component (0-255)
//            /// (default value "nil")
//            /// </param>
//            /// <param name="blue">
//            /// The blue component (0-255)
//            /// (default value "nil")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Color.hex_color #=> "#31a785"</code>
//            /// </example>
//            [FakerMethod("hex_color_from_RGB")]
//            public string HexColorFromRGB(long? red = null, long? green = null, long? blue = null)
//            {
//                red = (red ?? Random.NextInt32(0, 255)) & 0xFF;
//                green = (green ?? Random.NextInt32(0, 255)) & 0xFF;
//                blue = (blue ?? Random.NextInt32(0, 255)) & 0xFF;
//                return $"#{red:X2}{green:X2}{blue:X2}";
//            }


//            /// <summary>
//            /// Produces a hex color code from hue, saturation, or luminance values
//            /// </summary>
//            /// <param name="hue">
//            /// The hue component (0-1)
//            /// (default value "nil")
//            /// </param>
//            /// <param name="saturation">
//            /// The saturation component (0-1)
//            /// (default value "nil")
//            /// </param>
//            /// <param name="luminance">
//            /// The luminance component (0-1)
//            /// (default value "nil")
//            /// </param>
//            /// <example>
//            /// <code>Faker::Color.hex_color_from_HSL #=> "#31a785"</code>
//            /// </example>
//            [FakerMethod("hex_color_from_HSL")]
//            public string HexColorFromHSL(double? hue = null, double? saturation = null, double? luminance = null)
//            {
//                hue = (hue ?? Random.NextDouble(0, 1)) % 1;
//                saturation = (saturation ?? Random.NextDouble(0, 1)) % 1;
//                luminance = (luminance ?? Random.NextDouble(0, 1)) % 1;

//                byte r, g, b;
//                if (saturation == 0)
//                {
//                    r = (byte)Math.Round(luminance.Value * 255d);
//                    g = (byte)Math.Round(luminance.Value * 255d);
//                    b = (byte)Math.Round(luminance.Value * 255d);
//                }
//                else
//                {
//                    double t1, t2;
//                    double th = hue.Value / 6.0d;

//                    if (luminance < 0.5d)
//                    {
//                        t2 = luminance.Value * (1d + saturation.Value);
//                    }
//                    else
//                    {
//                        t2 = (luminance.Value + saturation.Value) - (luminance.Value * saturation.Value);
//                    }
//                    t1 = 2d * luminance.Value - t2;

//                    double tr, tg, tb;
//                    tr = th + (1.0d / 3.0d);
//                    tg = th;
//                    tb = th - (1.0d / 3.0d);

//                    tr = ColorCalc(tr, t1, t2);
//                    tg = ColorCalc(tg, t1, t2);
//                    tb = ColorCalc(tb, t1, t2);
//                    r = (byte)Math.Round(tr * 255d);
//                    g = (byte)Math.Round(tg * 255d);
//                    b = (byte)Math.Round(tb * 255d);
//                }
//                return HexColorFromRGB(r, g, b);

//                double ColorCalc(double c, double t1, double t2)
//                {

//                    if (c < 0) c += 1d;
//                    if (c > 1) c -= 1d;
//                    if (6.0d * c < 1.0d) return t1 + (t2 - t1) * 6.0d * c;
//                    if (2.0d * c < 1.0d) return t2;
//                    if (3.0d * c < 2.0d) return t1 + (t2 - t1) * (2.0d / 3.0d - c) * 6.0d;
//                    return t1;
//                }
//            }

//        }

//    }
//}
