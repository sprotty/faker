using LiquidTechnologies.MetaTypeSystem;
using FakerNet;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Diagnostics;

namespace LiquidTechnologies.SampleDataGeneratorModel
{
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterData
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataAlphanumeric
    {
        [NativeFunction("Data.String.AlphaString", "Produces a random string of alphabetic characters (no digits).", "Data.Alphanumeric", "function-data-alphanumeric-Data.String.AlphaString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Data.String.AlphaString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "32", Default = "32")] long length)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Data.Alphanumeric.Alpha(length);
        }
        [NativeFunction("Data.String.AlphaNumericString", "Produces a random string of alphanumeric characters.", "Data.Alphanumeric", "function-data-alphanumeric-Data.String.AlphaNumericString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Data.String.AlphaNumericString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "32", Default = "32")] long length)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Data.Alphanumeric.AlphaNumeric(length);
        }
        [NativeFunction("Data.String.HexString", "", "Data.Alphanumeric", "function-data-alphanumeric-Data.String.HexString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Data.String.HexString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "10", Default = "10")] long length
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Alphanumeric.Hex(length);
        }
        [NativeFunction("Data.String.NumericString", "", "Data.Alphanumeric", "function-data-alphanumeric-Data.String.NumericString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Data.String.NumericString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "10", Default = "10")] long length
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Alphanumeric.Numeric(length);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataBoolean
    {
        [NativeFunction("GetBoolean", "Produces a boolean.", "Data.Boolean", "function-data-boolean-GetBoolean.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static bool GetBoolean(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("trueRatio", "", IsOptional = true, OptionalDesc = "0.5", Default = "0.5")] double trueRatio)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Data.Boolean.GetBoolean(trueRatio);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataCrypto
    {
        [NativeFunction("Md5", "Produces an MD5 hash.", "Data.Crypto", "function-data-crypto-Md5.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Md5(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] byte[]? data
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Md5(data);
        }
        [NativeFunction("Md5FromString", "Produces an MD5 hash of a string.", "Data.Crypto", "function-data-crypto-Md5FromString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Md5FromString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] string? data
            , [ArgumentProperty("encoding", "", IsOptional = true, OptionalDesc = "nil")] Encoding? encoding
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Md5FromString(data, encoding);
        }
        [NativeFunction("Sha1", "Produces a SHA1 hash.", "Data.Crypto", "function-data-crypto-Sha1.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha1(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] byte[]? data
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha1(data);
        }
        [NativeFunction("Sha1FromString", "Produces a SHA1 hash of a string.", "Data.Crypto", "function-data-crypto-Sha1FromString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha1FromString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] string? data
            , [ArgumentProperty("encoding", "", IsOptional = true, OptionalDesc = "nil")] Encoding? encoding
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha1FromString(data, encoding);
        }
        [NativeFunction("Sha256", "Produces a SHA256 hash.", "Data.Crypto", "function-data-crypto-Sha256.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha256(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] byte[]? data
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha256(data);
        }
        [NativeFunction("Sha256FromString", "Produces a SHA256 hash of a string.", "Data.Crypto", "function-data-crypto-Sha256FromString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha256FromString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] string? data
            , [ArgumentProperty("encoding", "", IsOptional = true, OptionalDesc = "nil")] Encoding? encoding
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha256FromString(data, encoding);
        }
        [NativeFunction("Sha512", "Produces a SHA512 hash.", "Data.Crypto", "function-data-crypto-Sha512.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha512(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] byte[]? data
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha512(data);
        }
        [NativeFunction("Sha512FromString", "Produces a SHA512 hash of a string.", "Data.Crypto", "function-data-crypto-Sha512FromString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static byte[] Sha512FromString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "", IsOptional = true, OptionalDesc = "nil")] string? data
            , [ArgumentProperty("encoding", "", IsOptional = true, OptionalDesc = "nil")] Encoding? encoding
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Crypto.Sha512FromString(data, encoding);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataDate
    {
        [NativeFunction("Past", "Produce a random date in the past (up to N days).", "Data.Date", "function-data-date-Past.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static UNKNOWN_DateTime Past(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("days", "", IsOptional = true, OptionalDesc = "365", Default = "365")] long days
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Date.Backward(days);
        }
        [NativeFunction("Between", "Produce a random date between two dates.", "Data.Date", "function-data-date-Between.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static UNKNOWN_DateTime Between(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("from", "")] DateOnly from
            , [ArgumentProperty("to", "")] DateOnly to
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Date.Between(from, to);
        }
        #warning No implementation defined for method birthday
        #warning No implementation defined for method forward
        #warning No implementation defined for method day
        [NativeFunction("Time", "A random time within the range (if after is greater than before then before is considered to be the following day).", "Data.Date", "function-data-date-Time.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Time(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("after", "", IsOptional = true, OptionalDesc = "nil")] string? after
            , [ArgumentProperty("before", "", IsOptional = true, OptionalDesc = "nil")] string? before
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Date.Time(after, before);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataLorem
    {
        [NativeFunction("LocalePeriod", "Gets a '.' character in the current locale.
        private needed for Japanese", "Data.Lorem", "function-data-lorem-LocalePeriod.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LocalePeriod(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.LocalePeriod();
        }
        [NativeFunction("LocaleQuestionMark", "Gets a '?' character in the current locale
        private needed for Japanese", "Data.Lorem", "function-data-lorem-LocaleQuestionMark.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LocaleQuestionMark(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.LocaleQuestionMark();
        }
        [NativeFunction("LocaleSpace", "Gets a 'space' character in the current locale.
        private needed for Japanese", "Data.Lorem", "function-data-lorem-LocaleSpace.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LocaleSpace(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.LocaleSpace();
        }
        [NativeFunction("Paragraph", "Generates three sentence paragraph.", "Data.Lorem", "function-data-lorem-Paragraph.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Paragraph(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("sentenceCount", "", IsOptional = true, OptionalDesc = "3", Default = "3")] long sentenceCount
            , [ArgumentProperty("supplemental", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool supplemental
            , [ArgumentProperty("randomSentencesToAdd", "", IsOptional = true, OptionalDesc = "0", Default = "0")] long randomSentencesToAdd
            , [ArgumentProperty("excludeWords", "", IsOptional = true, OptionalDesc = "nil")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.Paragraph(sentenceCount, supplemental, randomSentencesToAdd, excludeWords);
        }
        [NativeFunction("ParagraphByChars", "Generates paragraph with 256 characters.", "Data.Lorem", "function-data-lorem-ParagraphByChars.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ParagraphByChars(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("charCount", "", IsOptional = true, OptionalDesc = "256 ", Default = "256 ")] long charCount
            , [ArgumentProperty("supplemental", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool supplemental
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.ParagraphByChars(charCount, supplemental);
        }
        [NativeFunction("Question", "Returns the question with 4 words.", "Data.Lorem", "function-data-lorem-Question.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Question(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "", IsOptional = true, OptionalDesc = "5", Default = "5")] long wordCount
            , [ArgumentProperty("supplemental", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool supplemental
            , [ArgumentProperty("randomWordsToAdd", "", IsOptional = true, OptionalDesc = "0", Default = "0")] long randomWordsToAdd
            , [ArgumentProperty("excludeWords", "", IsOptional = true, OptionalDesc = "nil")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.Question(wordCount, supplemental, randomWordsToAdd, excludeWords);
        }
        [NativeFunction("Sentence", "Generates sentence.", "Data.Lorem", "function-data-lorem-Sentence.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sentence(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "", IsOptional = true, OptionalDesc = "4", Default = "4")] long wordCount
            , [ArgumentProperty("supplemental", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool supplemental
            , [ArgumentProperty("randomWordsToAdd", "", IsOptional = true, OptionalDesc = "0", Default = "0")] long randomWordsToAdd
            , [ArgumentProperty("excludeWords", "", IsOptional = true, OptionalDesc = "nil")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.Sentence(wordCount, supplemental, randomWordsToAdd, excludeWords);
        }
        [NativeFunction("Word", "Returs the random word.", "Data.Lorem", "function-data-lorem-Word.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Word(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("excludeWords", "", IsOptional = true, OptionalDesc = "nil")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.Word(excludeWords);
        }
        [NativeFunction("Words", "Generates 3 random lorem words.", "Data.Lorem", "function-data-lorem-Words.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Words(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "", IsOptional = true, OptionalDesc = "3", Default = "3")] long wordCount
            , [ArgumentProperty("supplemental", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool supplemental
            , [ArgumentProperty("excludeWords", "", IsOptional = true, OptionalDesc = "nil")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.Words(wordCount, supplemental, excludeWords);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataMeasurement
    {
        #warning Failed processing method check_for_plural : method has no name or return type.
        #warning Failed processing method define_measurement_locale : method has no name or return type.
        #warning Failed processing method ensure_valid_amount : method has no name or return type.
        #warning No implementation defined for method height
        #warning No implementation defined for method length
        #warning Failed processing method make_plural : method has no name or return type.
        #warning No implementation defined for method metric_height
        #warning No implementation defined for method metric_length
        #warning No implementation defined for method metric_volume
        #warning No implementation defined for method metric_weight
        #warning No implementation defined for method volume
        #warning No implementation defined for method weight
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataNumber
    {
        #warning No implementation defined for method between
        #warning No implementation defined for method binary
        #warning No implementation defined for method decimal
        #warning No implementation defined for method decimal_part
        #warning No implementation defined for method digit
        #warning Failed processing method generate : method has no name or return type.
        #warning Failed processing method greater_than_zero : method has no name or return type.
        #warning No implementation defined for method hexadecimal
        #warning No implementation defined for method leading_zero_number
        #warning Failed processing method less_than_zero : method has no name or return type.
        #warning No implementation defined for method negative
        #warning No implementation defined for method non_zero_digit
        #warning No implementation defined for method normal
        #warning No implementation defined for method number
        #warning No implementation defined for method positive
        #warning Failed processing method should_be : method has no name or return type.
        #warning No implementation defined for method within
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataString
    {
        [NativeFunction("Length", "", "Data.String", "function-data-string-Length.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static long Length(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "")] string text
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.String.Length(text);
        }
        [NativeFunction("Lower", "", "Data.String", "function-data-string-Lower.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Lower(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "")] string text
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.String.Lower(text);
        }
        [NativeFunction("RandomString", "", "Data.String", "function-data-string-RandomString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RandomString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLength", "", IsOptional = true, OptionalDesc = "50", Default = "50")] long minLength
            , [ArgumentProperty("maxLength", "", IsOptional = true, OptionalDesc = "50", Default = "50")] long maxLength
            , [ArgumentProperty("alphabet", "", IsOptional = true, OptionalDesc = "'0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'", Default = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")] string alphabet
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.String.RandomString(minLength, maxLength, alphabet);
        }
        [NativeFunction("SubString", "returns part of the string", "Data.String", "function-data-string-SubString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SubString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "")] string text
            , [ArgumentProperty("start", "")] long start
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "nil")] long? length
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.String.SubString(text, start, length);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataTime
    {
        #warning No implementation defined for method backward
        #warning No implementation defined for method between
        #warning No implementation defined for method between_dates
        #warning Failed processing method date_with_random_time : method has no name or return type.
        #warning No implementation defined for method forward
        #warning Failed processing method get_time_object : method has no name or return type.
        #warning Failed processing method hours : method has no name or return type.
        #warning Failed processing method minutes : method has no name or return type.
        #warning Failed processing method seconds : method has no name or return type.
        #warning Failed processing method time_with_format : method has no name or return type.
    }
    
}
