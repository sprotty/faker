using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Diagnostics;

namespace FakerNet
{
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    /// <summary>
    /// </summary>
    public enum AvatarType
    {
        /// <summary>
        /// A robot head and shoulders
        /// </summary>
        [Display(Name = "Robot")]
        Robot,
        /// <summary>
        /// A monster head and shoulders
        /// </summary>
        [Display(Name = "Monster")]
        Monster,
        /// <summary>
        /// A robot head
        /// </summary>
        [Display(Name = "RobotHead")]
        RobotHead,
        /// <summary>
        /// A cute cat
        /// </summary>
        [Display(Name = "Cat")]
        Cat,
        /// <summary>
        /// A person head and shoulders
        /// </summary>
        [Display(Name = "Person")]
        Person,
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    /// <summary>
    /// </summary>
    public enum MimeTypeMedia
    {
        [Display(Name = "application")]
        Application,
        [Display(Name = "audio")]
        Audio,
        [Display(Name = "image")]
        Image,
        [Display(Name = "message")]
        Message,
        [Display(Name = "model")]
        Model,
        [Display(Name = "multipart")]
        Multipart,
        [Display(Name = "text")]
        Text,
        [Display(Name = "video")]
        Video,
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Data")]
    public partial class DataGenerator : GeneratorBase
    {
        [FakerProperty]
        public AlphanumericGenerator Alphanumeric { get; }
        [FakerProperty]
        public BooleanGenerator Boolean { get; }
        [FakerProperty]
        public CryptoGenerator Crypto { get; }
        [FakerProperty]
        public DateGenerator Date { get; }
        [FakerProperty]
        public MeasurementGenerator Measurement { get; }
        [FakerProperty]
        public NumberGenerator Number { get; }
        [FakerProperty]
        public StringGenerator String { get; }
        [FakerProperty]
        public TextGenerator Text { get; }
        internal DataGenerator(Faker faker)
                 : base(faker)
        {
            Alphanumeric = new AlphanumericGenerator(this.Faker);
            Boolean = new BooleanGenerator(this.Faker);
            Crypto = new CryptoGenerator(this.Faker);
            Date = new DateGenerator(this.Faker);
            Measurement = new MeasurementGenerator(this.Faker);
            Number = new NumberGenerator(this.Faker);
            String = new StringGenerator(this.Faker);
            Text = new TextGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Alphanumeric")]
        public partial class AlphanumericGenerator : GeneratorBase
        {
            internal AlphanumericGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random string of alphabetic characters (no digits).
            /// </summary>
            /// <param name="length">
            /// The length of the string to generate
            /// (default value "32")
            /// </param>
            /// <example>
            /// <code>Faker::Alphanumeric.alpha(number: 10) #=> "zlvubkrwga"</code>
            /// </example>
            [FakerMethod("alpha")]
            public string Alpha(long length = 32)
            {
                return this.EvaluateExpression("#{RandomString " + length + "," + length + ",'abcdefghijklmnopqrstuvwxyz'}");
            }
            /// <summary>
            /// Produces a random string of alphanumeric characters.
            /// </summary>
            /// <param name="length">
            /// The number of characters to generate
            /// (default value "32")
            /// </param>
            /// <example>
            /// <code>Faker::Alphanumeric.alphanumeric(number: 10) #=> "3yfq2phxtb"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Alphanumeric.alphanumeric(number: 10, min_alpha: 3) #=> "3yfq2phxtb"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Alphanumeric.alphanumeric(number: 10, min_alpha: 3, min_numeric: 3) #=> "3yfq2phx8b"</code>
            /// </example>
            [FakerMethod("alpha_numeric")]
            public string AlphaNumeric(long length = 32)
            {
                return this.EvaluateExpression("#{RandomString " + length + "," + length + ",'0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'}");
            }
            /// <param name="length">
            /// The length of the string to create
            /// (default value "10")
            /// </param>
            [FakerMethod("hex")]
            public string Hex(long length = 10)
            {
                return this.ResolveYamlValue("#{RandomString " + length + "," + length + ",'0123456789ABCDEF'}");
            }
            /// <summary>
            /// Create a string of number with the given length (may contain leading 0s)
            /// </summary>
            /// <param name="length">
            /// The length of the string to create
            /// (default value "10")
            /// </param>
            [FakerMethod("numeric")]
            public string Numeric(long length = 10)
            {
                return this.ResolveYamlValue("#{RandomString " + length + "," + length + ",'0123456789'}");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Data.Boolean.Value")]
        public partial class BooleanGenerator : GeneratorBase
        {
            internal BooleanGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
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
            /// <example>
            /// <code>Faker::Boolean.boolean(true_ratio: 0.2) #=> false</code>
            /// </example>
            [FakerMethod("get_boolean")]
            public bool GetBoolean(double trueRatio = 0.5)
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Crypto")]
        public partial class CryptoGenerator : GeneratorBase
        {
            internal CryptoGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces an MD5 hash.
            /// </summary>
            /// <param name="data">
            /// Binary data
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5")]
            public byte[] Md5(byte[]? data = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces an MD5 hash of a string.
            /// </summary>
            /// <param name="data">
            /// Binary data
            /// (default value "nil")
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5_from_string")]
            public byte[] Md5FromString(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA1 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data tohash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1")]
            public byte[] Sha1(byte[]? data = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA1 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data tohash
            /// (default value "nil")
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1_from_string")]
            public byte[] Sha1FromString(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA256 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256")]
            public byte[] Sha256(byte[]? data = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA256 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256_from_string")]
            public byte[] Sha256FromString(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA512 hash.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512")]
            public byte[] Sha512(byte[]? data = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA512 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value "nil")
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512_from_string")]
            public byte[] Sha512FromString(string? data = null, Encoding? encoding = null)
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Date")]
        public partial class DateGenerator : GeneratorBase
        {
            internal DateGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the past.
            /// (default value "365")
            /// </param>
            /// <example>
            /// <code>Faker::Date.backward(days: 14) #=> #<Date: 2019-09-12></code>
            /// </example>
            [FakerMethod("backward")]
            public DateTime Backward(long days = 365)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produce a random date between two dates.
            /// </summary>
            /// <param name="from">
            /// The start of the usable date range.
            /// (default value "1970-01-01")
            /// </param>
            /// <param name="to">
            /// The end of the usable date range.
            /// (default value "2050-01-01")
            /// </param>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.between(from: '2014-09-23', to: '2014-09-25') #=> #<Date: 2014-09-24></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.between(from: 2.days.ago, to: Date.today) #=> #<Date: 2014-09-24></code>
            /// </example>
            [FakerMethod("between")]
            public DateOnly Between(DateOnly? from = null, DateOnly? to = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="minAge">
            /// The minimum age that the birthday would imply.
            /// </param>
            /// <param name="maxAge">
            /// The maximum age that the birthday would imply.
            /// (default value "65")
            /// </param>
            /// <example>
            /// <code>Faker::Date.birthday(min_age: 18, max_age: 65) #=> #<Date: 1986-03-28></code>
            /// </example>
            [FakerMethod("birthday")]
            public DateOnly Birthday(long minAge, long maxAge = 65)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random date/time within the range.
            /// </summary>
            /// <param name="after">
            /// The time generated will be after this value
            /// (default value "1970-01-01")
            /// </param>
            /// <param name="before">
            /// The time generated will be before this value
            /// (default value "2050-01-01")
            /// </param>
            [FakerMethod("date_time")]
            public DateTime DateTime(DateTime? after = null, DateTime? before = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random day of the week
            /// </summary>
            [FakerMethod("day")]
            public DayOfWeek Day()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produce a random date in the future (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the future.
            /// (default value "365")
            /// </param>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(days: 23) #=> #<Date: 2014-10-03></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(from: Date.current, days: 17) #=> #<Date: 2022-06-22></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward(from: '2022-06-03', days: 10) #=> #<Date: 2022-10-13></code>
            /// </example>
            [FakerMethod("forward")]
            public DateTime Forward(long days = 365)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random time within the range (if after is greater than before then before is considered to be the following day).
            /// </summary>
            /// <param name="after">
            /// The time generated will be after this value
            /// (default value "nil")
            /// </param>
            /// <param name="before">
            /// The time generated will be before this value
            /// (default value "nil")
            /// </param>
            [FakerMethod("time")]
            public TimeOnly Time(TimeOnly? after = null, TimeOnly? before = null)
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Measurement")]
        public partial class MeasurementGenerator : GeneratorBase
        {
            internal MeasurementGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method check_for_plural : method has no name or return type.
            #warning Failed processing method define_measurement_locale : method has no name or return type.
            #warning Failed processing method ensure_valid_amount : method has no name or return type.
            #warning No implementation defined for method height(long amount = rand(10));
            #warning No implementation defined for method length(long amount = rand(10));
            #warning Failed processing method make_plural : method has no name or return type.
            #warning No implementation defined for method metric_height(long amount = rand(10));
            #warning No implementation defined for method metric_length(long amount = rand(10));
            #warning No implementation defined for method metric_volume(long amount = rand(10));
            #warning No implementation defined for method metric_weight(long amount = rand(10));
            #warning No implementation defined for method volume(long amount = rand(10));
            #warning No implementation defined for method weight(long amount = rand(10));
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Number")]
        public partial class NumberGenerator : GeneratorBase
        {
            internal NumberGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
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
            */
            // Expecting native implementation
            /*
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
            */
            // Expecting native implementation
            /*
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
            */
            // Expecting native implementation
            /*
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
            public double Negative(long from = -1000000, long to = 0)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a non-zero single-digit integer.
            /// </summary>
            /// <example>
            /// <code>Faker::Number.non_zero_digit #=> 8</code>
            /// </example>
            [FakerMethod("non_zero_digit")]
            public long NonZeroDigit()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a float given a mean and standard deviation.
            /// </summary>
            /// <param name="mean">
            /// </param>
            /// <param name="standardDeviation">
            /// (default value "3.5")
            /// </param>
            /// <example>
            /// <code>Faker::Number.normal(mean: 50, standard_deviation: 3.5) #=> 47.14669604069156</code>
            /// </example>
            [FakerMethod("normal")]
            public double Normal(long mean, UNKNOWN_Numeric? standardDeviation = null)
            */
            // Expecting native implementation
            /*
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
            public double Positive(long from = 0, long to = 1000000)
            */
            // Expecting native implementation
            /*
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
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("String")]
        public partial class StringGenerator : GeneratorBase
        {
            internal StringGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <param name="text">
            /// The string to get the length of
            /// </param>
            [FakerMethod("length")]
            internal long Length(string text)
            */
            // Expecting native implementation
            /*
            /// <param name="text">
            /// The string as lower case
            /// </param>
            [FakerMethod("lower")]
            internal string Lower(string text)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds the 'char' to the start of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
            /// </param>
            [FakerMethod("pad_left")]
            public string PadLeft(string text, long length, string @char)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds the 'char' to the end of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
            /// </param>
            [FakerMethod("pad_right")]
            public string PadRight(string text, long length, string @char)
            */
            // Expecting native implementation
            /*
            /// <param name="minLength">
            /// The minimum length of the string that will be generated
            /// (default value "50")
            /// </param>
            /// <param name="maxLength">
            /// The maximum length of the string that will be generated
            /// (default value "50")
            /// </param>
            /// <param name="alphabet">
            /// The characters that will be used to create the random string
            /// (default value "'0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'")
            /// </param>
            [FakerMethod("random_string")]
            internal string RandomString(long minLength = 50, long maxLength = 50, string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// returns part of the string
            /// </summary>
            /// <param name="text">
            /// The string to get a part of
            /// </param>
            /// <param name="start">
            /// The index to start the sub string at
            /// </param>
            /// <param name="length">
            /// the number of bytes to get (by default it will return the rest of the string)
            /// (default value "nil")
            /// </param>
            [FakerMethod("sub_string")]
            internal string SubString(string text, long start, long? length = null)
            */
        }
        
        /// <summary>
        /// Based on Perl's Text::Lorem.
        /// <p>Based on Perl’s Text::Lorem</p>
        /// 
        /// </summary>
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Lorem")]
        public partial class TextGenerator : GeneratorBase
        {
            internal TextGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Gets a '.' character in the current locale.
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_period")]
            internal string LocalePeriod()
            {
                return this.ResolveYamlValue("lorem.punctuation.period");
            }
            /// <summary>
            /// Gets a '?' character in the current locale
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_question_mark")]
            internal string LocaleQuestionMark()
            {
                return this.ResolveYamlValue("lorem.punctuation.question_mark");
            }
            /// <summary>
            /// Gets a 'space' character in the current locale.
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_space")]
            internal string LocaleSpace()
            {
                return this.ResolveYamlValue("lorem.punctuation.space");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds 0s to the start of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            [FakerMethod("zero_pad_left")]
            public string ZeroPadLeft(string text, long length)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds 0s to the end of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// </param>
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// </param>
            [FakerMethod("zero_pad_right")]
            public string ZeroPadRight(string text, long length)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Generates three sentence paragraph.
            /// </summary>
            /// <param name="sentenceCount">
            /// Number of sentences in the paragraph
            /// (default value "3")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomSentencesToAdd">
            /// A random number of sentences, less than or equal to this, are added to the paragraph.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.paragraph
            /// #=> "Impedit et est. Aliquid deleniti necessitatibus. Et aspernatur minima."
            /// Faker::Lorem.paragraph(sentence_count: 2)
            /// #=> "Rerum fugit vitae. Et atque autem."
            /// Faker::Lorem.paragraph(sentence_count: 2, supplemental: true)
            /// #=> "Terreo coerceo utor. Vester sunt cogito."
            /// Faker::Lorem.paragraph(sentence_count: 2, supplemental: true, random_sentences_to_add: 2)
            /// #=> "Texo tantillus tamisium. Tribuo amissio tamisium. Facere aut canis."</code>
            /// </example>
            [FakerMethod("paragraph")]
            public string Paragraph(long sentenceCount = 3, bool supplemental = false, long randomSentencesToAdd = 0, string? excludeWords = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Generates paragraph with 256 characters.
            /// </summary>
            /// <param name="charCount">
            /// The number of characters in the paragraph
            /// (default value "256 ")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.paragraph_by_chars
            /// Faker::Lorem.paragraph_by_chars(number: 20)                       #=> "Sit modi alias. Imp."
            /// Faker::Lorem.paragraph_by_chars(number: 20, supplemental: true)   #=> "Certus aveho admove."</code>
            /// </example>
            [FakerMethod("paragraph_by_chars")]
            public string ParagraphByChars(long charCount = 256 , bool supplemental = false)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Returns the question with 4 words.
            /// </summary>
            /// <param name="wordCount">
            /// How many words should be there in a sentence
            /// (default value "5")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomWordsToAdd">
            /// A random number of words, less than or equal to this, are added to the word count.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.question                                                               #=> "Natus deleniti sequi laudantium?"
            /// Faker::Lorem.question(word_count: 2)                                                #=> "Quo ut?"
            /// Faker::Lorem.question(word_count: 2, supplemental: true)                            #=> "Terga consequatur?"
            /// Faker::Lorem.question(word_count: 2, supplemental: true, random_words_to_add: 2)    #=> "Depulso uter ut?"</code>
            /// </example>
            [FakerMethod("question")]
            public string Question(long wordCount = 5, bool supplemental = false, long randomWordsToAdd = 0, string? excludeWords = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Generates sentence.
            /// </summary>
            /// <param name="wordCount">
            /// How many words should be there in a sentence
            /// (default value "4")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomWordsToAdd">
            /// A random number of words, less than or equal to this, are added to the word count.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.sentence                                                             #=> "Magnam qui aut quidem."
            /// Faker::Lorem.sentence(word_count: 5)                                              #=> "Voluptas rerum aut aliquam velit."
            /// Faker::Lorem.sentence(word_count: 5, supplemental: true)                          #=> "Aut viscus curtus votum iusto."
            /// Faker::Lorem.sentence(word_count: 5, supplemental: true, random_words_to_add:2)   #=> "Crinis quo cruentus velit animi vomer."</code>
            /// </example>
            [FakerMethod("sentence")]
            public string Sentence(long wordCount = 4, bool supplemental = false, long randomWordsToAdd = 0, string? excludeWords = null)
            */
            /// <summary>
            /// Returs the random word.
            /// </summary>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.word   => "soluto"
            /// Faker::Lorem.word(exclude_words: 'error') => "nisi"
            /// Faker::Lorem.word(exclude_words: 'id, error') => "et"
            /// Faker::Lorem.word(exclude_words: ['id', 'error']) => "consequatur"</code>
            /// </example>
            [FakerMethod("word")]
            public string Word(string? excludeWords = null)
            {
                return this.EvaluateExpression("#{words 1," + excludeWords + ")");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Generates 3 random lorem words.
            /// </summary>
            /// <param name="wordCount">
            /// Number of words to be generated
            /// (default value "3")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.words                                    #=> ["hic", "quia", "nihil"]
            /// Faker::Lorem.words(number: 4)                         #=> ["est", "temporibus", "et", "quaerat"]
            /// Faker::Lorem.words(number: 4, supplemental: true)    #=> ["nisi", "sit", "allatus", "consequatur"]
            /// Faker::Lorem.words(number: 4, supplemental: true, exclude_words: 'sit') #=> ["nisi", "allatus", "consequatur", "aut"]</code>
            /// </example>
            [FakerMethod("words")]
            public string Words(long wordCount = 3, bool supplemental = false, string? excludeWords = null)
            */
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    partial class Faker
    {
        [FakerProperty]
        public DataGenerator Data { get; }
        
        public Faker(CultureInfo locale, Random random)
        {
            this.Random = random;
            
            // Create the Faker Generators
            Data = new DataGenerator(this);
            
            Init(locale);
        }
    }
}
