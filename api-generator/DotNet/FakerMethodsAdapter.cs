#pragma warning disable CS1030 // #warning directive
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
    public partial class FakerAdapterCommerce
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceAppliance
    {
        [NativeFunction("Brand", "Produces the name of an appliance brand.", "Product.Appliance", "function-commerce-appliance-Brand.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Brand(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Appliance.Brand();
        }
        [NativeFunction("Name", "Produces the name of a type of appliance equipment.", "Product.Appliance", "function-commerce-appliance-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Appliance.Equipment();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceBank
    {
        [NativeFunction("AccountNumber", "Produces a bank account number.", "Commerce.Bank", "function-commerce-bank-AccountNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AccountNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "Number of digits that the generated account number should have.", IsOptional = true, OptionalDesc = "\"10\"", Default = "10")] long digits)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.AccountNumber(digits);
        }
        [NativeFunction("BsbNumber", "Produces an Australian BSB (Bank-State-Branch) number.", "Commerce.Bank", "function-commerce-bank-BsbNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BsbNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.BsbNumber();
        }
        [NativeFunction("Iban", "Produces a bank iban number.", "Commerce.Bank", "function-commerce-bank-Iban.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Iban(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("countryCode", "Specifies what country prefix is used to generate the iban code.", IsOptional = true, OptionalDesc = "Random Country")] string? countryCode)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.Iban(countryCode);
        }
        [NativeFunction("IbanCountryCode", "Produces the ISO 3166 code of a country that uses the IBAN system.", "Commerce.Bank", "function-commerce-bank-IbanCountryCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IbanCountryCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.IbanCountryCode();
        }
        [NativeFunction("Name", "Produces a bank name.", "Commerce.Bank", "function-commerce-bank-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.Name();
        }
        [NativeFunction("RoutingNumber", "Produces a routing number.", "Commerce.Bank", "function-commerce-bank-RoutingNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RoutingNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.RoutingNumber();
        }
        [NativeFunction("RoutingNumberWithFormat", "Produces a valid routing number.", "Commerce.Bank", "function-commerce-bank-RoutingNumberWithFormat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RoutingNumberWithFormat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.RoutingNumberWithFormat();
        }
        [NativeFunction("SwiftBic", "Produces a swift / bic number.", "Commerce.Bank", "function-commerce-bank-SwiftBic.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SwiftBic(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Bank.SwiftBic();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceBarcode
    {
        [NativeFunction("CompositeSymbology", "composite symbology string with check digit", "Commerce.Barcode", "function-commerce-barcode-CompositeSymbology.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CompositeSymbology(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Barcode.CompositeSymbology();
        }
        #warning Failed processing method ean_with_composite_symbology : method has no name or return type.
        [NativeFunction("Ean13", "Returns a EAN 13 digit format barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Ean13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Barcode.Ean13();
        }
        [NativeFunction("Ean8", "Returns a EAN 8 digit format barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Ean8.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean8(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Barcode.Ean8();
        }
        [NativeFunction("GenerateBarcode", "Adds the check digit to the barcode", "Commerce.Barcode", "function-commerce-barcode-GenerateBarcode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "A complete numeric barcode including the check digit.")]
        public static string GenerateBarcode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("barcodeDigits", "The barcode digits to create a bar code from")] string barcodeDigits)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Barcode.GenerateBarcode(barcodeDigits);
        }
        [NativeFunction("Isbn10", "Returns a 10 digit ISBN code as a barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Isbn10.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn10(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Barcode.Isbn10();
        }
        [NativeFunction("Isbn13", "Returns a 13 digit ISBN code as a barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Isbn13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Barcode.Isbn13();
        }
        [NativeFunction("Ismn", "Returns a ISMN format barcode number with check digit  @return [String].\n\n@example\nFaker::Barcode.ismn      =&gt; &quot;9790527672897&quot;\n", "Commerce.Barcode", "function-commerce-barcode-Ismn.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ismn(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Barcode.Ismn();
        }
        [NativeFunction("Issn", "Returns a ISSN format barcode number with check digit \n@example\nFaker::Barcode.issn      =&gt; &quot;9775541703338&quot;", "Commerce.Barcode", "function-commerce-barcode-Issn.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Issn(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Barcode.Issn();
        }
        [NativeFunction("UpcA", "Returns a UPC_A format barcode number with check digit\n@example\nFaker::Barcode.upc_a      =&gt; &quot;766807541831&quot;", "Commerce.Barcode", "function-commerce-barcode-UpcA.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UpcA(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Barcode.UpcA();
        }
        #warning Failed processing method upc_a_with_composite_symbology : method has no name or return type.
        [NativeFunction("UpcE", "Returns a UPC_E format barcode number with check digit  @return [String]\n@example\n03746820", "Commerce.Barcode", "function-commerce-barcode-UpcE.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UpcE(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Barcode.UpcE();
        }
        #warning Failed processing method upc_e_with_composite_symbology : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceBusiness
    {
        [NativeFunction("ExpiryDate", "Produces a credit card expiration date in the form MMYY.", "Person.CreditCard|Commerce.CreditCard", "function-commerce-business-ExpiryDate.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ExpiryDate(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("expiredRatio", "The number of expired dates to produce\n0 - all numbers are valid\n0.5 - even split of expired/valid dates\n1 - all numbers are expired", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] double expiredRatio
            , [ArgumentProperty("separator", "The separator to place between the MM and YY", IsOptional = true, OptionalDesc = "\"'/'\"", Default = "/")] string separator)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Business.CreditCardExpiryDate(expiredRatio, separator);
        }
        [NativeFunction("CardType", "Produces a type of credit card.", "Person.CreditCard|Commerce.CreditCard", "function-commerce-business-CardType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CardType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Business.CreditCardType();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceCode
    {
        [NativeFunction("Asin", "Retrieves a real Amazon ASIN code from https://archive.org/details/asin_listing.\n<p>Retrieves a real Amazon ASIN code from <a href=\"https://archive.org/details/asin_listing\">archive.org/details/asin_listing</a></p>", "Commerce.Code", "function-commerce-code-Asin.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Asin(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Asin();
        }
        [NativeFunction("Ean", "Produces a random EAN (European Article Number) code.", "Commerce.Code", "function-commerce-code-Ean.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "the length of the code to generate (either 8 or 13)", IsOptional = true, OptionalDesc = "\"13\"", Default = "13")] long digits
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Ean(digits);
        }
        [NativeFunction("Ean13", "Produces a random EAN (European Article Number) 13 digit code.", "Commerce.Code", "function-commerce-code-Ean13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Ean13();
        }
        [NativeFunction("Ean8", "Produces a random EAN (European Article Number) 8 digit code.", "Commerce.Code", "function-commerce-code-Ean8.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean8(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Ean8();
        }
        [NativeFunction("Imei", "Produces a random IMEI (International Mobile Equipment Number) code.", "Commerce.Code", "function-commerce-code-Imei.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Imei(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Imei();
        }
        [NativeFunction("Isbn", "Produces a random ISBN (International Standard Book Number) code.", "Commerce.Code", "function-commerce-code-Isbn.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "the length of the code to generate (either 10 or 13)", IsOptional = true, OptionalDesc = "\"10\"", Default = "10")] long digits
            , [ArgumentProperty("separator", "true if you want separators returned, false otherwise", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool separator
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Isbn(digits, separator);
        }
        [NativeFunction("Isbn10", "Produces a random ISBN (International Standard Book Number) 10 digit code.", "Commerce.Code", "function-commerce-code-Isbn10.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn10(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("separator", "true if you want separators returned, false otherwise", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool separator)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Code.Isbn10(separator);
        }
        [NativeFunction("Isbn13", "Produces a random ISBN (International Standard Book Number) 13 digit code.", "Commerce.Code", "function-commerce-code-Isbn13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("separator", "true if you want separators returned, false otherwise", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool separator)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Code.Isbn13(separator);
        }
        [NativeFunction("Npi", "Produces a random NPI (National Provider Identifier) code.", "Commerce.Code", "function-commerce-code-Npi.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Npi(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Npi();
        }
        [NativeFunction("Nric", "Produces a random NRIC (National Registry Identity Card) code.\n<p>By default generates a Singaporean NRIC ID for someone who is born between the age of 18 and 65.</p>", "Commerce.Code", "function-commerce-code-Nric.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Nric(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minAge", "the min age of the person in years", IsOptional = true, OptionalDesc = "\"18\"", Default = "18")] long minAge
            , [ArgumentProperty("maxAge", "the max age of the person in years", IsOptional = true, OptionalDesc = "\"65\"", Default = "65")] long maxAge
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Nric(minAge, maxAge);
        }
        [NativeFunction("Rut", "Produces a random RUT (Rol Unico Nacional) code.", "Commerce.Code", "function-commerce-code-Rut.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Rut(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Rut();
        }
        [NativeFunction("Sin", "Produces a random SIN (Social Insurance Number for Canada) code.", "Commerce.Code", "function-commerce-code-Sin.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sin(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Sin();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceCommerceRENAME
    {
        [NativeFunction("TopBrands", "Produces a randomized string of a brand name.", "Commerce.Company", "function-commerce-commercerename-TopBrands.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TopBrands(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.Brand();
        }
        [NativeFunction("Superlative", "Produces a random product name.", "Commerce.Company.Product|Commerce.Marketing", "function-commerce-commercerename-Superlative.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Superlative(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.ProductName();
        }
        [NativeFunction("PromotionalCode", "Produces a random promotion code.", "Commerce.Company", "function-commerce-commercerename-PromotionalCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PromotionalCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "Updates the number of numerical digits used to generate the promotion code.", IsOptional = true, OptionalDesc = "\"6\"", Default = "6")] long digits
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.PromotionCode(digits);
        }
        [NativeFunction("Vendor", "Produces a randomized string of a vendor name.", "Commerce.Company", "function-commerce-commercerename-Vendor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vendor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.Vendor();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceCompany
    {
        #warning Failed processing method abn_checksum : method has no name or return type.
        #warning No implementation defined for method australian_business_number
        #warning No implementation defined for method brazilian_company_number
        #warning No implementation defined for method bs
        #warning No implementation defined for method buzzword
        #warning Failed processing method calculate_gst_checksum : method has no name or return type.
        #warning No implementation defined for method catch_phrase
        #warning Failed processing method collect_regon_sum : method has no name or return type.
        #warning No implementation defined for method czech_organisation_number
        [NativeFunction("Department", "Produces a company department.", "Commerce.Company", "function-commerce-company-Department.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Department(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Department();
        }
        #warning No implementation defined for method duns_number
        #warning No implementation defined for method ein
        #warning No implementation defined for method french_siren_number
        #warning No implementation defined for method french_siret_number
        #warning No implementation defined for method indian_gst_number
        [NativeFunction("Industry", "Produces a company industry.", "Commerce.Company", "function-commerce-company-Industry.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Industry(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Industry();
        }
        #warning Failed processing method inn_checksum : method has no name or return type.
        #warning No implementation defined for method inn_number
        [NativeFunction("Logo", "Produces a company logo.\n                            <p>Get a random company logo url in PNG format.</p>", "Commerce.Company", "function-commerce-company-Logo.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Logo(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Company.Logo();
        }
        #warning Failed processing method luhn_algorithm : method has no name or return type.
        #warning Failed processing method mod11 : method has no name or return type.
        [NativeFunction("Name", "Produces a company name.", "Commerce.Company", "function-commerce-company-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Name();
        }
        #warning No implementation defined for method norwegian_organisation_number
        #warning No implementation defined for method polish_register_of_national_economy
        #warning No implementation defined for method polish_taxpayer_identification_number
        [NativeFunction("Profession", "Produces a company profession.", "Commerce.Company", "function-commerce-company-Profession.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Profession(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Profession();
        }
        #warning No implementation defined for method russian_tax_number
        [NativeFunction("SicCode", "Produces a company sic code.", "Commerce.Company", "function-commerce-company-SicCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SicCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.SicCode();
        }
        #warning No implementation defined for method south_african_close_corporation_registration_number
        #warning No implementation defined for method south_african_listed_company_registration_number
        #warning No implementation defined for method south_african_pty_ltd_registration_number
        #warning No implementation defined for method south_african_trust_registration_number
        #warning Failed processing method spanish_b_algorithm : method has no name or return type.
        #warning Failed processing method spanish_cif_control_digit : method has no name or return type.
        #warning No implementation defined for method spanish_organisation_number
        [NativeFunction("Suffix", "Produces a company suffix.", "Commerce.Company", "function-commerce-company-Suffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Suffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Suffix();
        }
        #warning No implementation defined for method swedish_organisation_number
        [NativeFunction("Type", "Produces a company type.", "Commerce.Company", "function-commerce-company-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Company.Type();
        }
        #warning Failed processing method weight_sum : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceConstruction
    {
        [NativeFunction("HeavyEquipment", "Produces a random heavy equipment.", "Commerce.Construction", "function-commerce-construction-HeavyEquipment.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HeavyEquipment(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.HeavyEquipment();
        }
        [NativeFunction("Material", "Produces a random material.", "Commerce.Construction", "function-commerce-construction-Material.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Material(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.Material();
        }
        [NativeFunction("Role", "Produces a random role.", "Commerce.Construction", "function-commerce-construction-Role.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Role(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.Role();
        }
        [NativeFunction("StandardCostCode", "Produces a random standard cost code.", "Commerce.Construction", "function-commerce-construction-StandardCostCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StandardCostCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.StandardCostCode();
        }
        [NativeFunction("SubcontractCategory", "Produces a random subcontract category.", "Commerce.Construction", "function-commerce-construction-SubcontractCategory.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SubcontractCategory(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.SubcontractCategory();
        }
        [NativeFunction("Trade", "Produces a random trade.", "Commerce.Construction", "function-commerce-construction-Trade.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Trade(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Construction.Trade();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceCurrency
    {
        [NativeFunction("Code", "Produces a currency code.", "Commerce.Currency", "function-commerce-currency-Code.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Code(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Currency.Code();
        }
        [NativeFunction("Name", "Produces the name of a currency.", "Commerce.Currency", "function-commerce-currency-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Currency.Name();
        }
        [NativeFunction("Symbol", "Produces a currency symbol.", "Commerce.Currency", "function-commerce-currency-Symbol.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Symbol(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Currency.Symbol();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceFinance
    {
        [NativeFunction("CardNumber", "Produces a random credit card number.", "Person.CreditCard|Commerce.CreditCard", "function-commerce-finance-CardNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CardNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("cardType", "Specific credit card type (see CreditCard.CardTypes).", IsOptional = true, OptionalDesc = "Random card type")] string? cardType
            , [ArgumentProperty("includeFormatting", "includes formatting chars i.e. 3787-866288-08162", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool includeFormatting)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Finance.CreditCard(cardType, includeFormatting);
        }
        [NativeFunction("Market", "Returns a randomly-selected stock market.", "Commerce.StockMarket", "function-commerce-finance-Market.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Market(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Finance.StockMarket();
        }
        [NativeFunction("Ticker", "Returns a randomly-selected stock ticker from a specified market.", "Commerce.StockMarket", "function-commerce-finance-Ticker.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ticker(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("market", "The name of the market to choose the ticker from (e.g. NYSE, NASDAQ) \nSee Commerce.StockMarket.Market", IsOptional = true, OptionalDesc = "Random Market")] string? market)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Finance.Ticker(market);
        }
        [NativeFunction("VatNumber", "Produces a random vat number.", "Commerce.Company", "function-commerce-finance-VatNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string VatNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("countryCode", "Two capital letter country code to use for the vat number.", IsOptional = true, OptionalDesc = "Random Country")] string? countryCode)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Commerce.Finance.VatNumber(countryCode);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceIndustrySegments
    {
        [NativeFunction("Industry", "Produces the name of an industry.", "Commerce.IndustrySegments", "function-commerce-industrysegments-Industry.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Industry(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.IndustrySegments.Industry();
        }
        [NativeFunction("Sector", "Produces the name of a sector of an industry.", "Commerce.IndustrySegments", "function-commerce-industrysegments-Sector.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sector(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.IndustrySegments.Sector();
        }
        [NativeFunction("SubSector", "Produces the name of a subsector of an industry.", "Commerce.IndustrySegments", "function-commerce-industrysegments-SubSector.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SubSector(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.IndustrySegments.SubSector();
        }
        [NativeFunction("SuperSector", "Produces the name of a super-sector of an industry.", "Commerce.IndustrySegments", "function-commerce-industrysegments-SuperSector.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SuperSector(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.IndustrySegments.SuperSector();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceInvoice
    {
        #warning Failed processing method iban_checksum : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceJob
    {
        [NativeFunction("Field", "Produces a random job field.", "Commerce.Job", "function-commerce-job-Field.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Field(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Job.Field();
        }
        [NativeFunction("KeySkill", "Produces a random job skill.", "Commerce.Job", "function-commerce-job-KeySkill.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string KeySkill(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Job.KeySkill();
        }
        [NativeFunction("Position", "Produces a random job position.", "Commerce.Job", "function-commerce-job-Position.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Position(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Job.Position();
        }
        [NativeFunction("Title", "Produces a random job title.", "Commerce.Job", "function-commerce-job-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Job.Title();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceMarketing
    {
        [NativeFunction("Buzzwords", "Produces a few marketing buzzwords.", "Commerce.Marketing", "function-commerce-marketing-Buzzwords.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Buzzwords(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Marketing.Buzzwords();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceRestaurant
    {
        [NativeFunction("Description", "Produces a description of a restaurant.", "Commerce.Restaurant", "function-commerce-restaurant-Description.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Description(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Restaurant.Description();
        }
        [NativeFunction("Name", "Produces the name of a restaurant.", "Commerce.Restaurant", "function-commerce-restaurant-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Restaurant.Name();
        }
        [NativeFunction("Review", "Produces a review for a restaurant.", "Commerce.Restaurant", "function-commerce-restaurant-Review.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Review(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Restaurant.Review();
        }
        [NativeFunction("Type", "Produces a type of restaurant.", "Commerce.Restaurant", "function-commerce-restaurant-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Restaurant.Type();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceStripe
    {
        [NativeFunction("CCV", "Produces a random ccv number.", "Person.CreditCard|Commerce.CreditCard", "function-commerce-stripe-CCV.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CCV(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("cardType", "Specific valid card type.", IsOptional = true, OptionalDesc = "Random card type")] string? cardType
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Stripe.Ccv(cardType);
        }
        [NativeFunction("CardNumberInvalid", "Produces a random invalid card number.", "Person.CreditCard|Commerce.CreditCard", "function-commerce-stripe-CardNumberInvalid.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CardNumberInvalid(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Stripe.InvalidCard();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceSubscription
    {
        [NativeFunction("PaymentMethod", "Produces the name of a payment method.", "Commerce.Subscription", "function-commerce-subscription-PaymentMethod.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PaymentMethod(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Subscription.PaymentMethod();
        }
        [NativeFunction("PaymentTerm", "Produces the name of a payment term.", "Commerce.Subscription", "function-commerce-subscription-PaymentTerm.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PaymentTerm(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Subscription.PaymentTerm();
        }
        [NativeFunction("Plan", "Produces the name of a subscription plan.", "Commerce.Subscription", "function-commerce-subscription-Plan.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Plan(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Subscription.Plan();
        }
        [NativeFunction("Status", "Produces a subscription status.", "Commerce.Subscription", "function-commerce-subscription-Status.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Status(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Subscription.Status();
        }
        [NativeFunction("SubscriptionTerm", "Produces the name of a subscription term.", "Commerce.Subscription", "function-commerce-subscription-SubscriptionTerm.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SubscriptionTerm(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Subscription.SubscriptionTerm();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterData
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataAlphanumeric
    {
        [NativeFunction("AlphaString", "Produces a random string of alphabetic characters (no digits).", "Data.Text", "function-data-alphanumeric-AlphaString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AlphaString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "The length of the string to generate", IsOptional = true, OptionalDesc = "\"32\"", Default = "32")] long length)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Alphanumeric.Alpha(length);
        }
        [NativeFunction("AlphaNumericString", "Produces a random string of alphanumeric characters.", "Data.Text", "function-data-alphanumeric-AlphaNumericString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AlphaNumericString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "The number of characters to generate", IsOptional = true, OptionalDesc = "\"32\"", Default = "32")] long length)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Alphanumeric.AlphaNumeric(length);
        }
        [NativeFunction("HexString", "", "Data.Text", "function-data-alphanumeric-HexString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HexString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "The length of the string to create", IsOptional = true, OptionalDesc = "\"10\"", Default = "10")] long length
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Alphanumeric.Hex(length);
        }
        [NativeFunction("NumericString", "Create a string of number with the given length (may contain leading 0s)", "Data.Text", "function-data-alphanumeric-NumericString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NumericString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "The length of the string to create", IsOptional = true, OptionalDesc = "\"10\"", Default = "10")] long length
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Alphanumeric.Numeric(length);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataBinary
    {
        [NativeFunction("Base64Decode", "Decodes base64 data, producing binary data", "Data.Binary", "function-data-binary-Base64Decode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Base64Decode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("base64Data", "The base 64 data to decode")] string base64Data)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Base64Decode(base64Data));
        }
        [NativeFunction("Base64Encode", "Encodes binary data as base64", "Data.Binary.Base64Encode,Data.Text", "function-data-binary-Base64Encode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Base64Encode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "The data to encode")] Binary binaryData)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Base64Encode(binaryData.Data);
        }
        [NativeFunction("Binary", "Gets some random binary data", "Data.Binary", "function-data-binary-Binary.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Binary(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLen", "The minimum number of bytes to return", IsOptional = true, OptionalDesc = "\"4\"", Default = "4")] long minLen
            , [ArgumentProperty("maxLen", "The maximum number of bytes to return", IsOptional = true, OptionalDesc = "\"32\"", Default = "32")] long maxLen)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Binary(minLen, maxLen));
        }
        [NativeFunction("HexDecode", "Decodes hex data, producing binary data", "Data.Binary", "function-data-binary-HexDecode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary HexDecode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("hexData", "The hex data to decode")] string hexData)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.HexDecode(hexData));
        }
        [NativeFunction("HexEncode", "Encodes binary data as hex", "Data.Binary.HexEncode,Data.Text", "function-data-binary-HexEncode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HexEncode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "The data to encode")] Binary binaryData)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.HexEncode(binaryData?.Data);
        }
        [NativeFunction("Md5", "Produces an MD5 hash.", "Data.Binary", "function-data-binary-Md5.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Md5(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "Binary data", IsOptional = true, OptionalDesc = "Random data")] Binary? binaryData)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Md5(binaryData?.Data));
        }
        [NativeFunction("Md5String", "Produces an MD5 hash of a string.", "Data.Binary", "function-data-binary-Md5String.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Md5String(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "Binary data", IsOptional = true, OptionalDesc = "Random data")] string? data
            , [ArgumentProperty("encoding", "The encoding to use to convert the string into binary data in order to hash it.", IsOptional = true, OptionalDesc = "UTF-8")] Encoding? encoding)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Md5String(data, encoding));
        }
        [NativeFunction("Sha1", "Produces a SHA1 hash.", "Data.Binary", "function-data-binary-Sha1.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha1(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "The binary data tohash", IsOptional = true, OptionalDesc = "Random data")] Binary? binaryData)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha1(binaryData?.Data));
        }
        [NativeFunction("Sha1String", "Produces a SHA1 hash of a string.", "Data.Binary", "function-data-binary-Sha1String.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha1String(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "The binary data tohash", IsOptional = true, OptionalDesc = "Random data")] string? data
            , [ArgumentProperty("encoding", "The encoding to use to convert the string into binary data in order to hash it.", IsOptional = true, OptionalDesc = "UTF-8")] Encoding? encoding)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha1String(data, encoding));
        }
        [NativeFunction("Sha256", "Produces a SHA256 hash.", "Data.Binary", "function-data-binary-Sha256.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha256(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "The binary data to hash", IsOptional = true, OptionalDesc = "Random data")] Binary? binaryData)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha256(binaryData?.Data));
        }
        [NativeFunction("Sha256String", "Produces a SHA256 hash of a string.", "Data.Binary", "function-data-binary-Sha256String.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha256String(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "The binary data to hash", IsOptional = true, OptionalDesc = "Random data")] string? data
            , [ArgumentProperty("encoding", "The encoding to use to convert the string into binary data in order to hash it.", IsOptional = true, OptionalDesc = "UTF-8")] Encoding? encoding)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha256String(data, encoding));
        }
        [NativeFunction("Sha512", "Produces a SHA512 hash.", "Data.Binary", "function-data-binary-Sha512.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha512(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("binaryData", "The binary data to hash", IsOptional = true, OptionalDesc = "Random Data")] Binary? binaryData)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha512(binaryData?.Data));
        }
        [NativeFunction("Sha512String", "Produces a SHA512 hash of a string.", "Data.Binary", "function-data-binary-Sha512String.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static Binary Sha512String(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("data", "The binary data to hash", IsOptional = true, OptionalDesc = "Random Data")] string? data
            , [ArgumentProperty("encoding", "The encoding to use to convert the string into binary data in order to hash it.", IsOptional = true, OptionalDesc = "UTF-8")] Encoding? encoding)
        {
            return new Binary(context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Binary.Sha512String(data, encoding));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataBoolean
    {
        [NativeFunction("Boolean", "Produces a boolean.", "Data.Boolean", "function-data-boolean-Boolean.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static bool Boolean(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("trueRatio", "The likelihood (as a float, out of 1.0) for the method to return ‘true`.", IsOptional = true, OptionalDesc = "\"0.5\"", Default = "0.5")] double trueRatio)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Boolean.GetBoolean(trueRatio);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataDate
    {
        [NativeFunction("PastDateTime", "Produce a random date in the past (up to N days).", "Data.Date", "function-data-date-PastDateTime.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateTime PastDateTime(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("days", "The maximum number of days to go into the past.", IsOptional = true, OptionalDesc = "\"365\"", Default = "365")] long days)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.Backward(days);
        }
        [NativeFunction("PastDate", "Produce a random date in the past (up to N days).", "Data.Date", "function-data-date-PastDate.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateOnly PastDate(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("days", "The maximum number of days to go into the past.", IsOptional = true, OptionalDesc = "\"365\"", Default = "365")] long days)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.BackwardDate(days);
        }
        [NativeFunction("Date", "Produce a random date between two dates.", "Data.Date", "function-data-date-Date.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateOnly Date(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("from", "The start of the usable date range.", IsOptional = true, OptionalDesc = "\"1970-01-01\"")] DateOnly? from
            , [ArgumentProperty("to", "The end of the usable date range.", IsOptional = true, OptionalDesc = "\"2050-01-01\"")] DateOnly? to)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.Between(from ?? System.DateOnly.Parse("1970-01-01"), to ?? System.DateOnly.Parse("2050-01-01"));
        }
        [NativeFunction("DateOfBirth", "Produce a random date which would create a date of birth within the age range specified", "Person", "function-data-date-DateOfBirth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateOnly DateOfBirth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minAge", "The minimum age that the birthday would imply.", IsOptional = true, OptionalDesc = "\"18\"", Default = "18")] long minAge
            , [ArgumentProperty("maxAge", "The maximum age that the birthday would imply.", IsOptional = true, OptionalDesc = "\"65\"", Default = "65")] long maxAge)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.Birthday(minAge, maxAge);
        }
        [NativeFunction("DateTime", "A random date/time within the range.", "Data.Date", "function-data-date-DateTime.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateTime DateTime(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("from", "The time generated will be equal to or after this value", IsOptional = true, OptionalDesc = "\"1970-01-01\"")] DateTime? from
            , [ArgumentProperty("to", "The time generated will be equal to or before this value", IsOptional = true, OptionalDesc = "\"2050-01-01\"")] DateTime? to)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.DateTime(from ?? System.DateTime.Parse("1970-01-01"), to ?? System.DateTime.Parse("2050-01-01"));
        }
        [NativeFunction("Day", "A random day of the week translated into the selected locale", "Data.Date", "function-data-date-Day.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Day(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Date.Day();
        }
        [NativeFunction("FutureDateTime", "Produce a random date in the future (up to N days).", "Data.Date", "function-data-date-FutureDateTime.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateTime FutureDateTime(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("days", "The maximum number of days to go into the future.", IsOptional = true, OptionalDesc = "\"365\"", Default = "365")] long days)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.Forward(days);
        }
        [NativeFunction("FutureDate", "Produce a random date in the future (up to N days).", "Data.Date", "function-data-date-FutureDate.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static DateOnly FutureDate(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("days", "The maximum number of days to go into the future.", IsOptional = true, OptionalDesc = "\"365\"", Default = "365")] long days)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.ForwardDate(days);
        }
        [NativeFunction("Time", "A random time within the range (if 'from' is greater than 'to' then 'to' is considered to be the following day).", "Data.Date", "function-data-date-Time.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static TimeOnly Time(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("from", "The time generated will be equal to or after this value", IsOptional = true, OptionalDesc = "\"00:00:00\"")] TimeOnly? from
            , [ArgumentProperty("to", "The time generated will be equal to or before this value", IsOptional = true, OptionalDesc = "\"23:59:59\"")] TimeOnly? to)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Date.Time(from ?? System.TimeOnly.Parse("00:00:00"), to ?? System.TimeOnly.Parse("23:59:59"));
        }
        [NativeFunction("WeekDay", "A random week day (Monday-Friday ) translated into the selected locale", "Data.Date", "function-data-date-WeekDay.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string WeekDay(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Date.WeekDay();
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
        [NativeFunction("BinaryString", "Produces a binary number 1s and 0s.", "Data.Text", "function-data-number-BinaryString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BinaryString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "Number of digits to generate the binary as string", IsOptional = true, OptionalDesc = "\"4\"", Default = "4")] long digits)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Binary(digits);
        }
        [NativeFunction("DecimalString", "Produces a decimal value", "Data.Text", "function-data-number-DecimalString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DecimalString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wholeNumberDigits", "Number of digits that the generated decimal should have to the left of the decimal point.", IsOptional = true, OptionalDesc = "\"5\"", Default = "5")] long wholeNumberDigits
            , [ArgumentProperty("factionalDigits", "Number of digits that the generated decimal should have to the right of the decimal point.", IsOptional = true, OptionalDesc = "\"2\"", Default = "2")] long factionalDigits)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Decimal(wholeNumberDigits, factionalDigits);
        }
        [NativeFunction("Float", "Creates a random floating point number", "Data.Number", "function-data-number-Float.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double Float(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("min", "A value greater than or equal to this will be generated", IsOptional = true, OptionalDesc = "\"-100000\"", Default = "-100000")] double min
            , [ArgumentProperty("max", "A value less than or equal to this will be generated", IsOptional = true, OptionalDesc = "\"1000000\"", Default = "1000000")] double max)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Float(min, max);
        }
        [NativeFunction("Integer", "Creates a random integer number", "Data.Number", "function-data-number-Integer.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static long Integer(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("min", "A value greater than or equal to this will be generated", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long min
            , [ArgumentProperty("max", "A value less than or equal to this will be generated", IsOptional = true, OptionalDesc = "\"1000000\"", Default = "1000000")] long max)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Integer(min, max);
        }
        [NativeFunction("NegativeFloat", "Produces a negative float.", "Data.Number", "function-data-number-NegativeFloat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double NegativeFloat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("min", "The lower boundary.", IsOptional = true, OptionalDesc = "\"-1000000\"", Default = "-1000000")] long min
            , [ArgumentProperty("max", "The higher boundary.", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long max)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Negative(min, max);
        }
        [NativeFunction("NonZeroDigit", "Produces a non-zero single-digit integer.", "Data.Number", "function-data-number-NonZeroDigit.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static long NonZeroDigit(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.NonZeroDigit();
        }
        [NativeFunction("StandardDeviation", "Produces a float given a mean and standard deviation.", "Data.Number", "function-data-number-StandardDeviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double StandardDeviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("mean", "")] long mean
            , [ArgumentProperty("standardDeviation", "", IsOptional = true, OptionalDesc = "\"3.5\"", Default = "3.5")] double standardDeviation)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Normal(mean, standardDeviation);
        }
        [NativeFunction("PositiveFloat", "Produces a positive float.", "Data.Number", "function-data-number-PositiveFloat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double PositiveFloat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("min", "The lower boundary.", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long min
            , [ArgumentProperty("max", "The higher boundary.", IsOptional = true, OptionalDesc = "\"1000000\"", Default = "1000000")] long max)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Positive(min, max);
        }
        [NativeFunction("Real", "Produces a number within two provided values.\nBoundaries are inclusive or exclusive depending on the range passed.", "Data.Number", "function-data-number-Real.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double Real(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("min", "The number generated will be greater than or equal to this value", IsOptional = true, OptionalDesc = "\"-10000\"", Default = "-10000")] double min
            , [ArgumentProperty("max", "The number generated will be greater than or equal to this value.", IsOptional = true, OptionalDesc = "\"10000\"", Default = "10000")] double max)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Number.Within(min, max);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataString
    {
        [NativeFunction("PadLeft", "Adds the 'char' to the start of the 'text' until it is 'length' long", "Data.String", "function-data-string-PadLeft.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PadLeft(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "The text to add pad")] string text
            , [ArgumentProperty("length", "The length the 'text' will be padded to")] long length
            , [ArgumentProperty("@char", "The character used to pad the string (must be 1 character )")] string @char)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.String.PadLeft(text, length, @char);
        }
        [NativeFunction("PadRight", "Adds the 'char' to the end of the 'text' until it is 'length' long", "Data.String", "function-data-string-PadRight.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PadRight(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "The text to add pad")] string text
            , [ArgumentProperty("length", "The length the 'text' will be padded to")] long length
            , [ArgumentProperty("@char", "The character used to pad the string (must be 1 character )")] string @char)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.String.PadRight(text, length, @char);
        }
        [NativeFunction("String", "", "Data.String", "function-data-string-String.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string String(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLength", "The minimum length of the string that will be generated", IsOptional = true, OptionalDesc = "\"50\"", Default = "50")] long minLength
            , [ArgumentProperty("maxLength", "The maximum length of the string that will be generated", IsOptional = true, OptionalDesc = "\"50\"", Default = "50")] long maxLength
            , [ArgumentProperty("alphabet", "The characters that will be used to create the random string", IsOptional = true, OptionalDesc = "\"'0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'\"", Default = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")] string alphabet)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.String.RandomString(minLength, maxLength, alphabet);
        }
        [NativeFunction("SubString", "returns part of the string", "Data.String", "function-data-string-SubString.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SubString(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "The string to get a part of")] string text
            , [ArgumentProperty("start", "The index to start the sub string at")] long start
            , [ArgumentProperty("length", "the number of bytes to get (by default it will return the rest of the string)", IsOptional = true, OptionalDesc = "null")] long? length)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.String.SubString(text, start, length);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataText
    {
        [NativeFunction("Paragraph", "Generates three sentence paragraph.", "Data.Text", "function-data-text-Paragraph.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Paragraph(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("sentenceCount", "Number of sentences in the paragraph", IsOptional = true, OptionalDesc = "\"3\"", Default = "3")] long sentenceCount
            , [ArgumentProperty("supplemental", "Whether to include supplemental lorem words", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool supplemental
            , [ArgumentProperty("randomSentencesToAdd", "A random number of sentences, less than or equal to this, are added to the paragraph.", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long randomSentencesToAdd
            , [ArgumentProperty("excludeWords", "A list of comma separated words that should not be used", IsOptional = true, OptionalDesc = "no excluded words")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.Paragraph(sentenceCount, supplemental, randomSentencesToAdd, excludeWords);
        }
        [NativeFunction("ParagraphByChars", "Generates paragraph with a given number of characters.", "Data.Text", "function-data-text-ParagraphByChars.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ParagraphByChars(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("charCount", "The number of characters in the paragraph", IsOptional = true, OptionalDesc = "\"256 \"", Default = "256 ")] long charCount
            , [ArgumentProperty("supplemental", "Whether to include supplemental lorem words", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool supplemental
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.ParagraphByChars(charCount, supplemental);
        }
        [NativeFunction("Question", "Returns the question with 4 words.", "Data.Text", "function-data-text-Question.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Question(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "How many words should be there in a sentence", IsOptional = true, OptionalDesc = "\"5\"", Default = "5")] long wordCount
            , [ArgumentProperty("supplemental", "Whether to include supplemental lorem words", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool supplemental
            , [ArgumentProperty("randomWordsToAdd", "A random number of words, less than or equal to this, are added to the word count.", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long randomWordsToAdd
            , [ArgumentProperty("excludeWords", "A list of comma separated words that should not be used", IsOptional = true, OptionalDesc = "no excluded words")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.Question(wordCount, supplemental, randomWordsToAdd, excludeWords);
        }
        [NativeFunction("Sentence", "Generates sentence.", "Data.Text", "function-data-text-Sentence.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sentence(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "How many words should be there in a sentence", IsOptional = true, OptionalDesc = "\"4\"", Default = "4")] long wordCount
            , [ArgumentProperty("supplemental", "Whether to include supplemental lorem words", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool supplemental
            , [ArgumentProperty("randomWordsToAdd", "A random number of words, less than or equal to this, are added to the word count.", IsOptional = true, OptionalDesc = "\"0\"", Default = "0")] long randomWordsToAdd
            , [ArgumentProperty("excludeWords", "A list of comma separated words that should not be used", IsOptional = true, OptionalDesc = "no excluded words")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.Sentence(wordCount, supplemental, randomWordsToAdd, excludeWords);
        }
        [NativeFunction("Word", "Returs the random word.", "Data.Text", "function-data-text-Word.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Word(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("excludeWords", "A list of comma separated words that should not be used", IsOptional = true, OptionalDesc = "no excluded words", Default = "")] string excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.Word(excludeWords);
        }
        [NativeFunction("Words", "Generates 3 random lorem words.", "Data.Text", "function-data-text-Words.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Words(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("wordCount", "Number of words to be generated", IsOptional = true, OptionalDesc = "\"3\"", Default = "3")] long wordCount
            , [ArgumentProperty("supplemental", "Whether to include supplemental lorem words", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool supplemental
            , [ArgumentProperty("excludeWords", "A list of comma separated words that should not be used", IsOptional = true, OptionalDesc = "no excluded words")] string? excludeWords
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Text.Words(wordCount, supplemental, excludeWords);
        }
        [NativeFunction("ZeroPadLeft", "Adds 0s to the start of the 'text' until it is 'length' long", "Data.Text", "function-data-text-ZeroPadLeft.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ZeroPadLeft(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "The text to add pad")] string text
            , [ArgumentProperty("length", "The length the 'text' will be padded to")] long length)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Text.ZeroPadLeft(text, length);
        }
        [NativeFunction("ZeroPadRight", "Adds 0s to the end of the 'text' until it is 'length' long", "Data.Text", "function-data-text-ZeroPadRight.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ZeroPadRight(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("text", "The text to add pad")] string text
            , [ArgumentProperty("length", "The length the 'text' will be padded to")] long length)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Data.Text.ZeroPadRight(text, length);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternet
    {
        [NativeFunction("MockBase64", "Produces a random string of alphabetic characters, (no digits).", "Data.Binary", "function-internet-MockBase64.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MockBase64(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "The length of the string to generate", IsOptional = true, OptionalDesc = "\"16\"", Default = "16")] long length
            , [ArgumentProperty("padding", "Toggles if a final equal ‘=’ will be added.", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool padding
            , [ArgumentProperty("urlsafe", "Toggles charset to ‘-’ and ‘_’ instead of ‘+’ and ‘/’.", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool urlsafe)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.Base64(length, padding, urlsafe);
        }
        [NativeFunction("BotUserAgent", "Generate Web Crawler's user agents.", "Internet", "function-internet-BotUserAgent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BotUserAgent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("vendor", "Name of vendor, supported vendors are googlebot, bingbot, duckduckbot, baiduspider, yandexbot", IsOptional = true, OptionalDesc = "null")] string? vendor
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.BotUserAgent(vendor);
        }
        #warning Failed processing method device_token : method has no name or return type.
        [NativeFunction("DomainName", "Returns the domain name.", "Internet", "function-internet-DomainName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DomainName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("subdomain", "If true passed adds a subdomain in response", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool subdomain
            , [ArgumentProperty("domain", "", IsOptional = true, OptionalDesc = "null")] string? domain
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.DomainName(subdomain, domain);
        }
        [NativeFunction("DomainSuffix", "Returns the domain suffix e.g.\ncom, org, co, biz, info etc.", "Internet", "function-internet-DomainSuffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DomainSuffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("safe", "Returns a 'safe' domain - one that wont get annoyed if you aim random traffic at it.", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool safe
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.DomainSuffix(safe);
        }
        [NativeFunction("DomainWord", "Returns the domain word for internet.", "Internet", "function-internet-DomainWord.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DomainWord(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.DomainWord();
        }
        [NativeFunction("Email", "Returns the email address.", "Internet|Person", "function-internet-Email.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Email(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("name", "The user name part of the address", IsOptional = true, OptionalDesc = "Random")] string? name
            , [ArgumentProperty("separators", "A string containing allowable separators within the email address (i.e. '-_')", IsOptional = true, OptionalDesc = "\"'-_'\"", Default = "-_")] string separators
            , [ArgumentProperty("domain", "The email domain to use", IsOptional = true, OptionalDesc = "Random")] string? domain
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Email(name, separators, domain);
        }
        [NativeFunction("IpV4Address", "Returns the IPv4 address.", "Internet", "function-internet-IpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.IpV4Address();
        }
        [NativeFunction("IpV4Cidr", "Returns Ipv4 address with CIDR, range from 1 to 31.", "Internet", "function-internet-IpV4Cidr.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV4Cidr(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.IpV4Cidr();
        }
        [NativeFunction("IpV6Address", "Returns Ipv6 address.", "Internet", "function-internet-IpV6Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV6Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.IpV6Address();
        }
        [NativeFunction("IpV6Cidr", "Returns Ipv6 address with CIDR, range between 1 to 127", "Internet", "function-internet-IpV6Cidr.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV6Cidr(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.IpV6Cidr();
        }
        [NativeFunction("MacAddress", "Returns the MAC address.", "Internet", "function-internet-MacAddress.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MacAddress(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.MacAddress();
        }
        [NativeFunction("Password", "Produces a randomized string of characters suitable for passwords.", "Internet|Person", "function-internet-Password.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Password(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLength", "The minimum length of the password", IsOptional = true, OptionalDesc = "\"8\"", Default = "8")] long minLength
            , [ArgumentProperty("maxLength", "The maximum length of the password", IsOptional = true, OptionalDesc = "\"16\"", Default = "16")] long maxLength
            , [ArgumentProperty("mixCase", "Toggles if uppercased letters are allowed. If true, at least one will be added.", IsOptional = true, OptionalDesc = "\"true\"", Default = "true")] bool mixCase
            , [ArgumentProperty("specialCharacters", "Toggles if special characters are allowed. If true, at least one will be added.", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool specialCharacters)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.Password(minLength, maxLength, mixCase, specialCharacters);
        }
        [NativeFunction("PrivateIpV4Address", "Returns the private IPv4 address.", "Internet", "function-internet-PrivateIpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PrivateIpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.PrivateIpV4Address();
        }
        [NativeFunction("PublicIpV4Address", "Returns the public IPv4 address.", "Internet", "function-internet-PublicIpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PublicIpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.PublicIpV4Address();
        }
        [NativeFunction("Slug", "Returns unique string in URL.", "Internet", "function-internet-Slug.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Slug(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("words", "Comma or period separated words list", IsOptional = true, OptionalDesc = "null")] string? words
            , [ArgumentProperty("glue", "Separator to add between words passed, default used are ‘-’ or ‘_’", IsOptional = true, OptionalDesc = "null")] string? glue
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Slug(words, glue);
        }
        [NativeFunction("Url", "Returns URL.", "Internet", "function-internet-Url.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Url(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("host", "", IsOptional = true, OptionalDesc = "null")] string? host
            , [ArgumentProperty("path", "", IsOptional = true, OptionalDesc = "null")] string? path
            , [ArgumentProperty("scheme", "", IsOptional = true, OptionalDesc = "\"'https'\"", Default = "https")] string scheme
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Url(host, path, scheme);
        }
        [NativeFunction("UserAgent", "Generates the random browser identifier.", "Internet", "function-internet-UserAgent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UserAgent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("vendor", "Name of vendor, supported vendors are aol, chrome, firefox, internet_explorer, netscape, opera, safari", IsOptional = true, OptionalDesc = "null")] string? vendor
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.UserAgent(vendor);
        }
        [NativeFunction("Username", "Returns the username.", "Internet|Person", "function-internet-Username.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Username(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLen", "The minimum length for the generated username", IsOptional = true, OptionalDesc = "\"4\"", Default = "4")] long minLen
            , [ArgumentProperty("maxLen", "The maximum length for the generated username", IsOptional = true, OptionalDesc = "\"12\"", Default = "12")] long maxLen
            , [ArgumentProperty("separators", "A string containig all characters that can be used to separate parts of the name.", IsOptional = true, OptionalDesc = "\"'._'\"", Default = "._")] string separators)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.Username(minLen, maxLen, separators);
        }
        [NativeFunction("Uuid", "Generated universally unique identifier.", "Internet", "function-internet-Uuid.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Uuid(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Internet.Uuid();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternetHTML
    {
        #warning Failed processing method available_methods : method has no name or return type.
        [NativeFunction("Code", "Produces a random code block formatted in HTML.", "Internet.HTML", "function-internet-html-Code.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Code(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.HTML.Code();
        }
        #warning No implementation defined for method element
        [NativeFunction("Emphasis", "Produces a random emphasis formatting on a random word in two HTML paragraphs.", "Internet.HTML", "function-internet-html-Emphasis.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Emphasis(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.HTML.Emphasis();
        }
        #warning Failed processing method generate_table_row : method has no name or return type.
        #warning No implementation defined for method heading
        #warning No implementation defined for method link
        #warning No implementation defined for method ordered_list
        #warning No implementation defined for method paragraph
        #warning No implementation defined for method sandwich
        [NativeFunction("Script", "Generates a random <script> tag with the `src` attribute set to a random URL.", "Internet.HTML", "function-internet-html-Script.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Script(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.HTML.Script();
        }
        #warning No implementation defined for method table
        #warning No implementation defined for method unordered_list
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternetJson
    {
        #warning No implementation defined for method add_depth_to_json
        #warning Failed processing method add_hash : method has no name or return type.
        #warning Failed processing method add_hash_to_bottom : method has no name or return type.
        #warning Failed processing method build_keys_from_array : method has no name or return type.
        #warning Failed processing method build_shallow_hash : method has no name or return type.
        #warning No implementation defined for method shallow_json
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternetMarkdown
    {
        #warning Failed processing method available_methods : method has no name or return type.
        [NativeFunction("BlockCode", "Produces a random code block formatted in Ruby.", "Internet.Markdown", "function-internet-markdown-BlockCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BlockCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Markdown.BlockCode();
        }
        [NativeFunction("Emphasis", "Produces a random emphasis formatting on a random word in two sentences.", "Internet.Markdown", "function-internet-markdown-Emphasis.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Emphasis(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Markdown.Emphasis();
        }
        [NativeFunction("Headers", "Produces a random header format.", "Internet.Markdown", "function-internet-markdown-Headers.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Headers(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Markdown.Headers();
        }
        [NativeFunction("InlineCode", "Produces a random inline code snippet between two sentences.", "Internet.Markdown", "function-internet-markdown-InlineCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string InlineCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Markdown.InlineCode();
        }
        #warning No implementation defined for method ordered_list
        #warning No implementation defined for method sandwich
        #warning No implementation defined for method table
        #warning No implementation defined for method unordered_list
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPerson
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonAddress
    {
        [NativeFunction("USStateAbbreviation", "Produces a state abbreviation.", "Person.Address", "function-person-address-USStateAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string USStateAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Person.Address.StateAbbr();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonAvatar
    {
        [NativeFunction("AvatarImageUrl", "Produces a URL for an avatar from robohash.org.", "Person", "function-person-avatar-AvatarImageUrl.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AvatarImageUrl(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("name", "The name of the image, also used as a key to generate the image, so changing this changes the image. \nDefault value will select some Lorem text", IsOptional = true, OptionalDesc = "null")] string? name
            , [ArgumentProperty("size", "image size in pixels, in the format of ‘AxB’", IsOptional = true, OptionalDesc = "\"'48x48'\"", Default = "48x48")] string size
            , [ArgumentProperty("format", "The image file format ('png', 'jpg' or 'bmp')", IsOptional = true, OptionalDesc = "\"'jpg'\"", Default = "jpg")] string format
            , [ArgumentProperty("type", "The avatar set to use (Robot, Monster, RobotHead, Cat, Person)", IsOptional = true, OptionalDesc = "\"Person\"", Default = "Person")] AvatarType type
            , [ArgumentProperty("background", "Include a background", IsOptional = true, OptionalDesc = "\"false\"", Default = "false")] bool background)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Person.Avatar.Image(name, size, format, type, background);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonBlood
    {
        [NativeFunction("Group", "Produces a random blood group name.", "Person.Blood", "function-person-blood-Group.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Group(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Person.Blood.Group();
        }
        [NativeFunction("RhFactor", "Produces a random blood RH-Factor.", "Person.Blood", "function-person-blood-RhFactor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RhFactor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Person.Blood.RhFactor();
        }
        [NativeFunction("Type", "Produces a random blood type.", "Person.Blood", "function-person-blood-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.Person.Blood.Type();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonDemographic
    {
        [NativeFunction("Demonym", "Produces a denonym.", "Person.Demographic", "function-person-demographic-Demonym.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Demonym(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Demographic.Demonym();
        }
        [NativeFunction("EducationalAttainment", "Produces a level of educational attainment.", "Person.Demographic", "function-person-demographic-EducationalAttainment.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string EducationalAttainment(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Demographic.EducationalAttainment();
        }
        #warning No implementation defined for method height
        [NativeFunction("MaritalStatus", "Produces a marital status.", "Person.Demographic", "function-person-demographic-MaritalStatus.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaritalStatus(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Demographic.MaritalStatus();
        }
        [NativeFunction("Race", "Produces the name of a race.", "Person.Demographic", "function-person-demographic-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Demographic.Race();
        }
        [NativeFunction("Sex", "Produces a sex for demographic purposes.", "Person.Demographic", "function-person-demographic-Sex.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sex(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Demographic.Sex();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonDrivingLicence
    {
        #warning No implementation defined for method british_driving_licence
        #warning Failed processing method gb_licence_checksum : method has no name or return type.
        #warning Failed processing method gb_licence_padding : method has no name or return type.
        #warning Failed processing method gb_licence_year : method has no name or return type.
        #warning No implementation defined for method initialize
        #warning No implementation defined for method northern_irish_driving_licence
        #warning Failed processing method random_gender : method has no name or return type.
        #warning Failed processing method uk_driving_licence : method has no name or return type.
        [NativeFunction("UsaDrivingLicence", "Produces a random USA driving licence number by state code passed.", "Person.DrivingLicence", "function-person-drivinglicence-UsaDrivingLicence.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UsaDrivingLicence(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("state", "The name of the state to create a driving license number for", IsOptional = true, OptionalDesc = "\"'California'\"", Default = "California")] string state
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.DrivingLicence.UsaDrivingLicence(state);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonGender
    {
        [NativeFunction("BinaryType", "Produces either 'Male' or 'Female'.", "Person.Gender", "function-person-gender-BinaryType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BinaryType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Gender.BinaryType();
        }
        [NativeFunction("ShortBinaryType", "Produces either 'f' or 'm'.", "Person.Gender", "function-person-gender-ShortBinaryType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ShortBinaryType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Gender.ShortBinaryType();
        }
        [NativeFunction("Type", "Produces the name of a gender identity.", "Person.Gender", "function-person-gender-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Gender.Type();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonIDNumber
    {
#warning Failed processing method _translate : method has no name or return type.
#warning No implementation defined for method brazilian_citizen_number
#warning Failed processing method brazilian_citizen_number_checksum_digit : method has no name or return type.
#warning Failed processing method brazilian_citizen_number_digit : method has no name or return type.
#warning Failed processing method brazilian_document_checksum : method has no name or return type.

#warning Failed processing method brazilian_document_digit : method has no name or return type.
#warning No implementation defined for method brazilian_id
#warning Failed processing method brazilian_id_checksum_digit : method has no name or return type.
#warning Failed processing method brazilian_id_digit : method has no name or return type.
#warning No implementation defined for method chilean_id
#warning Failed processing method chilean_verification_code : method has no name or return type.
#warning No implementation defined for method croatian_id
#warning Failed processing method croatian_id_checksum_digit : method has no name or return type.
#warning Failed processing method danish_control_digits : method has no name or return type.
#warning No implementation defined for method danish_id_number
#warning No implementation defined for method french_insee_number
#warning No implementation defined for method invalid
#warning No implementation defined for method invalid_south_african_id_number
#warning Failed processing method south_african_id_checksum_digit : method has no name or return type.
#warning No implementation defined for method spanish_citizen_number
#warning No implementation defined for method spanish_foreign_citizen_number
#warning Failed processing method ssn_valid : method has no name or return type.
#warning No implementation defined for method valid
#warning No implementation defined for method valid_south_african_id_number
    }

    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonName
    {
        [NativeFunction("FemaleFirstName", "Produces a random female first name.", "Person.Name", "function-person-name-FemaleFirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FemaleFirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.FemaleFirstName();
        }
        [NativeFunction("FirstName", "Produces a random first name.", "Person.Name", "function-person-name-FirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.FirstName();
        }
        #warning No implementation defined for method initials
        [NativeFunction("LastName", "Produces a random last name.", "Person.Name", "function-person-name-LastName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LastName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.LastName();
        }
        [NativeFunction("MaleFirstName", "Produces a random male first name.", "Person.Name", "function-person-name-MaleFirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaleFirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.MaleFirstName();
        }
        [NativeFunction("Name", "Produces a random name.", "Person.Name", "function-person-name-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.Name();
        }
        [NativeFunction("NameWithMiddle", "Produces a random name with middle name.", "Person.Name", "function-person-name-NameWithMiddle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NameWithMiddle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.NameWithMiddle();
        }
        [NativeFunction("NeutralFirstName", "Produces a random gender neutral first name.", "Person.Name", "function-person-name-NeutralFirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NeutralFirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.NeutralFirstName();
        }
        [NativeFunction("Prefix", "Produces a random name prefix.", "Person.Name", "function-person-name-Prefix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Prefix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.Prefix();
        }
        [NativeFunction("Suffix", "Produces a random name suffix.", "Person.Name", "function-person-name-Suffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Suffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Name.Suffix();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonPhoneNumber
    {
        [NativeFunction("UsAreaCode", "Produces a random area code.", "Person.PhoneNumber", "function-person-phonenumber-UsAreaCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UsAreaCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.AreaCode();
        }
        [NativeFunction("CellPhone", "Produces a random cell phone number in a random format without the country code and it can have different dividers.", "Person.PhoneNumber", "function-person-phonenumber-CellPhone.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CellPhone(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.CellPhone();
        }
        #warning No implementation defined for method cell_phone_in_e164
        [NativeFunction("CellPhoneWithCountryCode", "Produces a random cell phone number with country code.", "Person.PhoneNumber", "function-person-phonenumber-CellPhoneWithCountryCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CellPhoneWithCountryCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.CellPhoneWithCountryCode();
        }
        [NativeFunction("CountryCode", "Produces a random country code.", "Person.PhoneNumber", "function-person-phonenumber-CountryCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CountryCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.CountryCode();
        }
        [NativeFunction("UsExchangeCode", "Produces a random exchange code.", "Person.PhoneNumber", "function-person-phonenumber-UsExchangeCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UsExchangeCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.ExchangeCode();
        }
        [NativeFunction("PhoneNumber", "Produces a phone number in a random format without the country code and it can have different dividers.", "Person.PhoneNumber", "function-person-phonenumber-PhoneNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PhoneNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.PhoneNumber();
        }
        [NativeFunction("PhoneNumberWithCountryCode", "Produces a random phone number with country code.", "Person.PhoneNumber", "function-person-phonenumber-PhoneNumberWithCountryCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PhoneNumberWithCountryCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.PhoneNumber.PhoneNumberWithCountryCode();
        }
        #warning No implementation defined for method subscriber_number
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonRelationship
    {
        #warning No implementation defined for method familial
        [NativeFunction("InLaw", "Produces a random in-law relationship.", "Person.Relationship", "function-person-relationship-InLaw.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string InLaw(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Relationship.InLaw();
        }
        [NativeFunction("Parent", "Produces a random parent relationship.", "Person.Relationship", "function-person-relationship-Parent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Parent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Relationship.Parent();
        }
        [NativeFunction("Sibling", "Produces a random sibling relationship.", "Person.Relationship", "function-person-relationship-Sibling.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sibling(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Relationship.Sibling();
        }
        [NativeFunction("Spouse", "Produces a random spouse relationship.", "Person.Relationship", "function-person-relationship-Spouse.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Spouse(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Relationship.Spouse();
        }
    }
    
}
#pragma warning restore CS1030 // #warning directive
