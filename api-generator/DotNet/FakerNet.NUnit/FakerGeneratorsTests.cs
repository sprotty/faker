using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace FakerNet.NUnit
{
    [TestClass]
    public class Test_Data : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Data_Alphanumeric : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Alpha_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Alphanumeric.Alpha());
        }
        [TestMethod()]
        public void Test_AlphaNumeric_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Alphanumeric.AlphaNumeric());
        }
        [TestMethod()]
        public void Test_Hex_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Alphanumeric.Hex());
        }
        [TestMethod()]
        public void Test_Numeric_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Alphanumeric.Numeric());
        }
    }
    
    [TestClass]
    public class Test_Data_Boolean : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_GetBoolean_Execute()
        {
            FakerForEveryLocale<bool>(faker => faker.Data.Boolean.GetBoolean());
        }
    }
    
    [TestClass]
    public class Test_Data_Crypto : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Md5_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Md5());
        }
        [TestMethod()]
        public void Test_Md5FromString_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Md5FromString());
        }
        [TestMethod()]
        public void Test_Sha1_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha1());
        }
        [TestMethod()]
        public void Test_Sha1FromString_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha1FromString());
        }
        [TestMethod()]
        public void Test_Sha256_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha256());
        }
        [TestMethod()]
        public void Test_Sha256FromString_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha256FromString());
        }
        [TestMethod()]
        public void Test_Sha512_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha512());
        }
        [TestMethod()]
        public void Test_Sha512FromString_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Crypto.Sha512FromString());
        }
    }
    
    [TestClass]
    public class Test_Data_Date : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Backward_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.Backward());
        }
        [TestMethod()]
        public void Test_Between_Execute()
        {
            FakerForEveryLocale<DateOnly>(faker => faker.Data.Date.Between());
        }
        // Method : birthday : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_DateTime_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.DateTime());
        }
        [TestMethod()]
        public void Test_Day_Execute()
        {
            FakerForEveryLocale<DayOfWeek>(faker => faker.Data.Date.Day());
        }
        [TestMethod()]
        public void Test_Forward_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.Forward());
        }
        [TestMethod()]
        public void Test_Time_Execute()
        {
            FakerForEveryLocale<TimeOnly>(faker => faker.Data.Date.Time());
        }
    }
    
    [TestClass]
    public class Test_Data_Measurement : FakerNUnitBase
    {
        #warning Failed processing method check_for_plural
        #warning Failed processing method define_measurement_locale
        #warning Failed processing method ensure_valid_amount
        #warning No implementation defined for method height(long amount = rand(10));
        #warning No implementation defined for method length(long amount = rand(10));
        #warning Failed processing method make_plural
        #warning No implementation defined for method metric_height(long amount = rand(10));
        #warning No implementation defined for method metric_length(long amount = rand(10));
        #warning No implementation defined for method metric_volume(long amount = rand(10));
        #warning No implementation defined for method metric_weight(long amount = rand(10));
        #warning No implementation defined for method volume(long amount = rand(10));
        #warning No implementation defined for method weight(long amount = rand(10));
    }
    
    [TestClass]
    public class Test_Data_Number : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Binary_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Number.Binary());
        }
        [TestMethod()]
        public void Test_Decimal_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Number.Decimal());
        }
        [TestMethod()]
        public void Test_Integer_Execute()
        {
            FakerForEveryLocale<long>(faker => faker.Data.Number.Integer());
        }
        [TestMethod()]
        public void Test_Negative_Execute()
        {
            FakerForEveryLocale<double>(faker => faker.Data.Number.Negative());
        }
        [TestMethod()]
        public void Test_NonZeroDigit_Execute()
        {
            FakerForEveryLocale<long>(faker => faker.Data.Number.NonZeroDigit());
        }
        // Method : normal : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Positive_Execute()
        {
            FakerForEveryLocale<double>(faker => faker.Data.Number.Positive());
        }
        [TestMethod()]
        public void Test_Within_Execute()
        {
            FakerForEveryLocale<double>(faker => faker.Data.Number.Within());
        }
    }
    
    [TestClass]
    public class Test_Data_String : FakerNUnitBase
    {
        // Method : length : Can not generated test for method with required arguments.
        // Method : lower : Can not generated test for method with required arguments.
        // Method : pad_left : Can not generated test for method with required arguments.
        // Method : pad_right : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_RandomString_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.String.RandomString());
        }
        // Method : sub_string : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Data_Text : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_LocalePeriod_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.LocalePeriod());
        }
        [TestMethod()]
        public void Test_LocaleQuestionMark_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.LocaleQuestionMark());
        }
        [TestMethod()]
        public void Test_LocaleSpace_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.LocaleSpace());
        }
        // Method : zero_pad_left : Can not generated test for method with required arguments.
        // Method : zero_pad_right : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Paragraph_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.Paragraph());
        }
        [TestMethod()]
        public void Test_ParagraphByChars_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.ParagraphByChars());
        }
        [TestMethod()]
        public void Test_Question_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.Question());
        }
        [TestMethod()]
        public void Test_Sentence_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.Sentence());
        }
        [TestMethod()]
        public void Test_Word_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.Word());
        }
        [TestMethod()]
        public void Test_Words_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Text.Words());
        }
    }
    
}
