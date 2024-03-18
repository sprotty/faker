using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace FakerNet.NUnit
{
    [TestClass]
    public class Test_Commerce : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Commerce_Appliance : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Brand_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Appliance.Brand());
        }
        [TestMethod()]
        public void Test_Equipment_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Appliance.Equipment());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Bank : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AccountNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.AccountNumber());
        }
        [TestMethod()]
        public void Test_BsbNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.BsbNumber());
        }
        [TestMethod()]
        public void Test_Iban_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.Iban());
        }
        [TestMethod()]
        public void Test_IbanCountryCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.IbanCountryCode());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.Name());
        }
        [TestMethod()]
        public void Test_RoutingNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.RoutingNumber());
        }
        [TestMethod()]
        public void Test_RoutingNumberWithFormat_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.RoutingNumberWithFormat());
        }
        [TestMethod()]
        public void Test_SwiftBic_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Bank.SwiftBic());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Barcode : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CompositeSymbology_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.CompositeSymbology());
        }
        #warning Failed processing method ean_with_composite_symbology
        [TestMethod()]
        public void Test_Ean13_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Ean13());
        }
        [TestMethod()]
        public void Test_Ean8_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Ean8());
        }
        // Method : generate_barcode : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Isbn10_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Isbn10());
        }
        [TestMethod()]
        public void Test_Isbn13_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Isbn13());
        }
        [TestMethod()]
        public void Test_Ismn_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Ismn());
        }
        [TestMethod()]
        public void Test_Issn_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.Issn());
        }
        [TestMethod()]
        public void Test_UpcA_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.UpcA());
        }
        #warning Failed processing method upc_a_with_composite_symbology
        [TestMethod()]
        public void Test_UpcE_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Barcode.UpcE());
        }
        #warning Failed processing method upc_e_with_composite_symbology
    }
    
    [TestClass]
    public class Test_Commerce_Business : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CreditCardExpiryDate_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Business.CreditCardExpiryDate());
        }
        [TestMethod()]
        public void Test_CreditCardType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Business.CreditCardType());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Code : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Asin_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Asin());
        }
        [TestMethod()]
        public void Test_Ean_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Ean());
        }
        [TestMethod()]
        public void Test_Ean13_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Ean13());
        }
        [TestMethod()]
        public void Test_Ean8_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Ean8());
        }
        [TestMethod()]
        public void Test_Imei_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Imei());
        }
        [TestMethod()]
        public void Test_Isbn_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Isbn());
        }
        [TestMethod()]
        public void Test_Isbn10_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Isbn10());
        }
        [TestMethod()]
        public void Test_Isbn13_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Isbn13());
        }
        [TestMethod()]
        public void Test_Npi_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Npi());
        }
        [TestMethod()]
        public void Test_Nric_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Nric());
        }
        [TestMethod()]
        public void Test_Rut_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Rut());
        }
        [TestMethod()]
        public void Test_Sin_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Code.Sin());
        }
    }
    
    [TestClass]
    public class Test_Commerce_CommerceRENAME : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Brand_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.Brand());
        }
        #warning Failed processing method categories
        [TestMethod()]
        public void Test_Color_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.Color());
        }
        // Method : department : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Material_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.Material());
        }
        #warning Failed processing method merge_categories
        // Method : price : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_ProductName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.ProductName());
        }
        [TestMethod()]
        public void Test_PromotionCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.PromotionCode());
        }
        [TestMethod()]
        public void Test_Vendor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.CommerceRENAME.Vendor());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Company : FakerNUnitBase
    {
        #warning Failed processing method abn_checksum
        #warning No implementation defined for method australian_business_number();
        #warning No implementation defined for method brazilian_company_number();
        #warning No implementation defined for method bs();
        #warning No implementation defined for method buzzword();
        #warning Failed processing method calculate_gst_checksum
        #warning No implementation defined for method catch_phrase();
        #warning Failed processing method collect_regon_sum
        #warning No implementation defined for method czech_organisation_number();
        [TestMethod()]
        public void Test_Department_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Department());
        }
        #warning No implementation defined for method duns_number();
        #warning No implementation defined for method ein();
        #warning No implementation defined for method french_siren_number();
        #warning No implementation defined for method french_siret_number();
        #warning No implementation defined for method indian_gst_number();
        [TestMethod()]
        public void Test_Industry_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Industry());
        }
        #warning Failed processing method inn_checksum
        // Method : inn_number : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Logo_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Logo());
        }
        #warning Failed processing method luhn_algorithm
        #warning Failed processing method mod11
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Name());
        }
        #warning No implementation defined for method norwegian_organisation_number();
        #warning No implementation defined for method polish_register_of_national_economy();
        #warning No implementation defined for method polish_taxpayer_identification_number();
        [TestMethod()]
        public void Test_Profession_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Profession());
        }
        // Method : russian_tax_number : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_SicCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.SicCode());
        }
        #warning No implementation defined for method south_african_close_corporation_registration_number();
        #warning No implementation defined for method south_african_listed_company_registration_number();
        #warning No implementation defined for method south_african_pty_ltd_registration_number();
        #warning No implementation defined for method south_african_trust_registration_number();
        #warning Failed processing method spanish_b_algorithm
        #warning Failed processing method spanish_cif_control_digit
        #warning No implementation defined for method spanish_organisation_number();
        [TestMethod()]
        public void Test_Suffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Suffix());
        }
        #warning No implementation defined for method swedish_organisation_number();
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Company.Type());
        }
        #warning Failed processing method weight_sum
    }
    
    [TestClass]
    public class Test_Commerce_Construction : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_HeavyEquipment_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.HeavyEquipment());
        }
        [TestMethod()]
        public void Test_Material_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.Material());
        }
        [TestMethod()]
        public void Test_Role_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.Role());
        }
        [TestMethod()]
        public void Test_StandardCostCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.StandardCostCode());
        }
        [TestMethod()]
        public void Test_SubcontractCategory_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.SubcontractCategory());
        }
        [TestMethod()]
        public void Test_Trade_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Construction.Trade());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Currency : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Code_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Currency.Code());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Currency.Name());
        }
        [TestMethod()]
        public void Test_Symbol_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Currency.Symbol());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Finance : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CondominiumFiscalCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.CondominiumFiscalCode());
        }
        [TestMethod()]
        public void Test_CreditCard_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.CreditCard());
        }
        [TestMethod()]
        public void Test_StockMarket_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.StockMarket());
        }
        [TestMethod()]
        public void Test_Ticker_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.Ticker());
        }
        [TestMethod()]
        public void Test_VatNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.VatNumber());
        }
        #warning Failed processing method vat_number_keys
    }
    
    [TestClass]
    public class Test_Commerce_IndustrySegments : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Industry_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.IndustrySegments.Industry());
        }
        [TestMethod()]
        public void Test_Sector_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.IndustrySegments.Sector());
        }
        [TestMethod()]
        public void Test_SubSector_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.IndustrySegments.SubSector());
        }
        [TestMethod()]
        public void Test_SuperSector_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.IndustrySegments.SuperSector());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Invoice : FakerNUnitBase
    {
        // Method : amount_between : Can not generated test for method with required arguments.
        #warning Failed processing method calculate_weighted_sum
        #warning No implementation defined for method creditor_reference(string @ref = "");
        #warning Failed processing method iban_checksum
        #warning Failed processing method kidmod10
        #warning Failed processing method method_731
        #warning Failed processing method mod10_remainder
        #warning No implementation defined for method reference(string @ref = "");
    }
    
    [TestClass]
    public class Test_Commerce_Job : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Field_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Job.Field());
        }
        [TestMethod()]
        public void Test_KeySkill_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Job.KeySkill());
        }
        [TestMethod()]
        public void Test_Position_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Job.Position());
        }
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Job.Title());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Marketing : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Buzzwords_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Marketing.Buzzwords());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Restaurant : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Description_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Restaurant.Description());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Restaurant.Name());
        }
        [TestMethod()]
        public void Test_Review_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Restaurant.Review());
        }
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Restaurant.Type());
        }
    }
    
    [TestClass]
    public class Test_Commerce_Stripe : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Ccv_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Stripe.Ccv());
        }
        [TestMethod()]
        public void Test_InvalidCard_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Stripe.InvalidCard());
        }
        #warning No implementation defined for method month();
        #warning No implementation defined for method valid_card(string? cardType = null);
        #warning No implementation defined for method valid_token(string? cardType = null);
        #warning No implementation defined for method year();
    }
    
    [TestClass]
    public class Test_Commerce_Subscription : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_PaymentMethod_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Subscription.PaymentMethod());
        }
        [TestMethod()]
        public void Test_PaymentTerm_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Subscription.PaymentTerm());
        }
        [TestMethod()]
        public void Test_Plan_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Subscription.Plan());
        }
        [TestMethod()]
        public void Test_Status_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Subscription.Status());
        }
        [TestMethod()]
        public void Test_SubscriptionTerm_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Subscription.SubscriptionTerm());
        }
    }
    
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
    public class Test_Data_Binary : FakerNUnitBase
    {
        // Method : base64_decode : Can not generated test for method with required arguments.
        // Method : base64_encode : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Binary_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Binary());
        }
        // Method : hex_decode : Can not generated test for method with required arguments.
        // Method : hex_encode : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Md5_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Md5());
        }
        [TestMethod()]
        public void Test_Md5String_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Md5String());
        }
        [TestMethod()]
        public void Test_Sha1_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha1());
        }
        [TestMethod()]
        public void Test_Sha1String_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha1String());
        }
        [TestMethod()]
        public void Test_Sha256_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha256());
        }
        [TestMethod()]
        public void Test_Sha256String_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha256String());
        }
        [TestMethod()]
        public void Test_Sha512_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha512());
        }
        [TestMethod()]
        public void Test_Sha512String_Execute()
        {
            FakerForEveryLocale<byte[]>(faker => faker.Data.Binary.Sha512String());
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
    public class Test_Data_Date : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Backward_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.Backward());
        }
        [TestMethod()]
        public void Test_BackwardDate_Execute()
        {
            FakerForEveryLocale<DateOnly>(faker => faker.Data.Date.BackwardDate());
        }
        [TestMethod()]
        public void Test_Between_Execute()
        {
            FakerForEveryLocale<DateOnly>(faker => faker.Data.Date.Between());
        }
        [TestMethod()]
        public void Test_Birthday_Execute()
        {
            FakerForEveryLocale<DateOnly>(faker => faker.Data.Date.Birthday());
        }
        [TestMethod()]
        public void Test_DateTime_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.DateTime());
        }
        [TestMethod()]
        public void Test_Day_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Date.Day());
        }
        [TestMethod()]
        public void Test_Forward_Execute()
        {
            FakerForEveryLocale<DateTime>(faker => faker.Data.Date.Forward());
        }
        [TestMethod()]
        public void Test_ForwardDate_Execute()
        {
            FakerForEveryLocale<DateOnly>(faker => faker.Data.Date.ForwardDate());
        }
        [TestMethod()]
        public void Test_Time_Execute()
        {
            FakerForEveryLocale<TimeOnly>(faker => faker.Data.Date.Time());
        }
        [TestMethod()]
        public void Test_WeekDay_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Date.WeekDay());
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
        // Method : zero_pad_left : Can not generated test for method with required arguments.
        // Method : zero_pad_right : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Internet : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Base64_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Base64());
        }
        [TestMethod()]
        public void Test_BotUserAgent_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.BotUserAgent());
        }
        #warning Failed processing method device_token
        [TestMethod()]
        public void Test_DomainName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.DomainName());
        }
        [TestMethod()]
        public void Test_DomainSuffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.DomainSuffix());
        }
        [TestMethod()]
        public void Test_DomainWord_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.DomainWord());
        }
        [TestMethod()]
        public void Test_Email_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Email());
        }
        [TestMethod()]
        public void Test_IpV4Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.IpV4Address());
        }
        [TestMethod()]
        public void Test_IpV4Cidr_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.IpV4Cidr());
        }
        [TestMethod()]
        public void Test_IpV6Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.IpV6Address());
        }
        [TestMethod()]
        public void Test_IpV6Cidr_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.IpV6Cidr());
        }
        [TestMethod()]
        public void Test_MacAddress_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.MacAddress());
        }
        [TestMethod()]
        public void Test_Password_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Password());
        }
        [TestMethod()]
        public void Test_PrivateIpV4Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.PrivateIpV4Address());
        }
        [TestMethod()]
        public void Test_PublicIpV4Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.PublicIpV4Address());
        }
        [TestMethod()]
        public void Test_Slug_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Slug());
        }
        [TestMethod()]
        public void Test_Url_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Url());
        }
        [TestMethod()]
        public void Test_UserAgent_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.UserAgent());
        }
        [TestMethod()]
        public void Test_Username_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Username());
        }
        [TestMethod()]
        public void Test_Uuid_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Uuid());
        }
    }
    
    [TestClass]
    public class Test_Internet_HTML : FakerNUnitBase
    {
        #warning Failed processing method available_methods
        [TestMethod()]
        public void Test_Code_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.HTML.Code());
        }
        // Method : element : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Emphasis_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.HTML.Emphasis());
        }
        #warning Failed processing method generate_table_row
        #warning No implementation defined for method heading();
        #warning No implementation defined for method link(string rel = "stylesheet");
        #warning No implementation defined for method ordered_list();
        // Method : paragraph : Can not generated test for method with required arguments.
        // Method : random : Can not generated test for method with required arguments.
        // Method : sandwich : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Script_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.HTML.Script());
        }
        #warning No implementation defined for method table();
        #warning No implementation defined for method unordered_list();
    }
    
    [TestClass]
    public class Test_Internet_Json : FakerNUnitBase
    {
        // Method : add_depth_to_json : Can not generated test for method with required arguments.
        #warning Failed processing method add_hash
        #warning Failed processing method add_hash_to_bottom
        #warning Failed processing method build_keys_from_array
        #warning Failed processing method build_shallow_hash
        // Method : shallow_json : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Internet_Markdown : FakerNUnitBase
    {
        #warning Failed processing method available_methods
        [TestMethod()]
        public void Test_BlockCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Markdown.BlockCode());
        }
        [TestMethod()]
        public void Test_Emphasis_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Markdown.Emphasis());
        }
        [TestMethod()]
        public void Test_Headers_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Markdown.Headers());
        }
        [TestMethod()]
        public void Test_InlineCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Internet.Markdown.InlineCode());
        }
        #warning No implementation defined for method ordered_list();
        // Method : random : Can not generated test for method with required arguments.
        // Method : sandwich : Can not generated test for method with required arguments.
        #warning No implementation defined for method table();
        #warning No implementation defined for method unordered_list();
    }
    
    [TestClass]
    public class Test_Person : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Person_Address : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_BuildingNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.BuildingNumber());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.City());
        }
        [TestMethod()]
        public void Test_CityPrefix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CityPrefix());
        }
        [TestMethod()]
        public void Test_CitySuffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CitySuffix());
        }
        [TestMethod()]
        public void Test_Community_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.Community());
        }
        [TestMethod()]
        public void Test_Country_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.Country());
        }
        [TestMethod()]
        public void Test_CountryByCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CountryByCode());
        }
        [TestMethod()]
        public void Test_CountryCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CountryCode());
        }
        [TestMethod()]
        public void Test_CountryCodeLong_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CountryCodeLong());
        }
        [TestMethod()]
        public void Test_CountryNameToCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.CountryNameToCode());
        }
        [TestMethod()]
        public void Test_Latitude_Execute()
        {
            FakerForEveryLocale<double>(faker => faker.Person.Address.Latitude());
        }
        [TestMethod()]
        public void Test_Longitude_Execute()
        {
            FakerForEveryLocale<double>(faker => faker.Person.Address.Longitude());
        }
        [TestMethod()]
        public void Test_MailBox_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.MailBox());
        }
        [TestMethod()]
        public void Test_Postcode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.Postcode());
        }
        [TestMethod()]
        public void Test_SecondaryAddress_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.SecondaryAddress());
        }
        [TestMethod()]
        public void Test_StateAbbr_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.StateAbbr());
        }
        [TestMethod()]
        public void Test_StreetAddress_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.StreetAddress());
        }
        [TestMethod()]
        public void Test_StreetName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.StreetName());
        }
        [TestMethod()]
        public void Test_StreetSuffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.StreetSuffix());
        }
        [TestMethod()]
        public void Test_TimeZone_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.TimeZone());
        }
        [TestMethod()]
        public void Test_ZipCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.ZipCode());
        }
    }
    
    [TestClass]
    public class Test_Person_Avatar : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Image_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Avatar.Image());
        }
    }
    
    [TestClass]
    public class Test_Person_Blood : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Group_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Blood.Group());
        }
        [TestMethod()]
        public void Test_RhFactor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Blood.RhFactor());
        }
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Blood.Type());
        }
    }
    
    [TestClass]
    public class Test_Person_Demographic : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Demonym_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Demographic.Demonym());
        }
        [TestMethod()]
        public void Test_EducationalAttainment_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Demographic.EducationalAttainment());
        }
        #warning No implementation defined for method height(UNKNOWN_Symbol? unit = null);
        [TestMethod()]
        public void Test_MaritalStatus_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Demographic.MaritalStatus());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Demographic.Race());
        }
        [TestMethod()]
        public void Test_Sex_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Demographic.Sex());
        }
    }
    
    [TestClass]
    public class Test_Person_DrivingLicence : FakerNUnitBase
    {
        // Method : british_driving_licence : Can not generated test for method with required arguments.
        #warning Failed processing method gb_licence_checksum
        #warning Failed processing method gb_licence_padding
        #warning Failed processing method gb_licence_year
        #warning No implementation defined for method initialize();
        #warning No implementation defined for method northern_irish_driving_licence();
        #warning Failed processing method random_gender
        // Method : uk_driving_licence : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_UsaDrivingLicence_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.DrivingLicence.UsaDrivingLicence());
        }
    }
    
    [TestClass]
    public class Test_Person_Gender : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_BinaryType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Gender.BinaryType());
        }
        [TestMethod()]
        public void Test_ShortBinaryType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Gender.ShortBinaryType());
        }
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Gender.Type());
        }
    }
    
    [TestClass]
    public class Test_Person_IDNumber : FakerNUnitBase
    {
        #warning Failed processing method _translate
        #warning No implementation defined for method brazilian_citizen_number(bool formatted = false);
        #warning Failed processing method brazilian_citizen_number_checksum_digit
        #warning Failed processing method brazilian_citizen_number_digit
        #warning Failed processing method brazilian_document_checksum
        #warning Failed processing method brazilian_document_digit
        #warning No implementation defined for method brazilian_id(bool formatted = false);
        #warning Failed processing method brazilian_id_checksum_digit
        #warning Failed processing method brazilian_id_digit
        #warning No implementation defined for method chilean_id();
        #warning Failed processing method chilean_verification_code
        #warning No implementation defined for method croatian_id(bool international = false);
        #warning Failed processing method croatian_id_checksum_digit
        #warning Failed processing method danish_control_digits
        // Method : danish_id_number : Can not generated test for method with required arguments.
        #warning No implementation defined for method french_insee_number();
        #warning No implementation defined for method invalid();
        #warning No implementation defined for method invalid_south_african_id_number();
        #warning Failed processing method south_african_id_checksum_digit
        #warning No implementation defined for method spanish_citizen_number();
        #warning No implementation defined for method spanish_foreign_citizen_number();
        #warning Failed processing method ssn_valid
        #warning No implementation defined for method valid();
        #warning No implementation defined for method valid_south_african_id_number();
    }
    
    [TestClass]
    public class Test_Person_Name : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_FemaleFirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.FemaleFirstName());
        }
        [TestMethod()]
        public void Test_FirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.FirstName());
        }
        #warning No implementation defined for method initials(long number = 3);
        [TestMethod()]
        public void Test_LastName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.LastName());
        }
        [TestMethod()]
        public void Test_MaleFirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.MaleFirstName());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.Name());
        }
        [TestMethod()]
        public void Test_NameWithMiddle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.NameWithMiddle());
        }
        [TestMethod()]
        public void Test_NeutralFirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.NeutralFirstName());
        }
        [TestMethod()]
        public void Test_Prefix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.Prefix());
        }
        [TestMethod()]
        public void Test_Suffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Name.Suffix());
        }
    }
    
    [TestClass]
    public class Test_Person_PhoneNumber : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AreaCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.AreaCode());
        }
        [TestMethod()]
        public void Test_CellPhone_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.CellPhone());
        }
        #warning No implementation defined for method cell_phone_in_e164();
        [TestMethod()]
        public void Test_CellPhoneWithCountryCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.CellPhoneWithCountryCode());
        }
        [TestMethod()]
        public void Test_CountryCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.CountryCode());
        }
        [TestMethod()]
        public void Test_ExchangeCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.ExchangeCode());
        }
        [TestMethod()]
        public void Test_PhoneNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.PhoneNumber());
        }
        [TestMethod()]
        public void Test_PhoneNumberWithCountryCode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.PhoneNumber.PhoneNumberWithCountryCode());
        }
        #warning No implementation defined for method subscriber_number(long length = 4);
    }
    
    [TestClass]
    public class Test_Person_Relationship : FakerNUnitBase
    {
        #warning No implementation defined for method familial();
        [TestMethod()]
        public void Test_InLaw_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Relationship.InLaw());
        }
        [TestMethod()]
        public void Test_Parent_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Relationship.Parent());
        }
        [TestMethod()]
        public void Test_Sibling_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Relationship.Sibling());
        }
        [TestMethod()]
        public void Test_Spouse_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Relationship.Spouse());
        }
    }
    
}
