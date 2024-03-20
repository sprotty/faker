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
        [Display(Name = "set1", Description = "A robot head and shoulders", ShortName = "set1")]
        Robot,
        /// <summary>
        /// A monster head and shoulders
        /// </summary>
        [Display(Name = "set2", Description = "A monster head and shoulders", ShortName = "set2")]
        Monster,
        /// <summary>
        /// A robot head
        /// </summary>
        [Display(Name = "set3", Description = "A robot head", ShortName = "set3")]
        RobotHead,
        /// <summary>
        /// A cute cat
        /// </summary>
        [Display(Name = "set4", Description = "A cute cat", ShortName = "set4")]
        Cat,
        /// <summary>
        /// A person head and shoulders
        /// </summary>
        [Display(Name = "set5", Description = "A person head and shoulders", ShortName = "set5")]
        Person,
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    /// <summary>
    /// </summary>
    public enum MimeTypeMedia
    {
        [Display(Name = "application", Description = "", ShortName = "application")]
        Application,
        [Display(Name = "audio", Description = "", ShortName = "audio")]
        Audio,
        [Display(Name = "image", Description = "", ShortName = "image")]
        Image,
        [Display(Name = "message", Description = "", ShortName = "message")]
        Message,
        [Display(Name = "model", Description = "", ShortName = "model")]
        Model,
        [Display(Name = "multipart", Description = "", ShortName = "multipart")]
        Multipart,
        [Display(Name = "text", Description = "", ShortName = "text")]
        Text,
        [Display(Name = "video", Description = "", ShortName = "video")]
        Video,
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Commerce")]
    public partial class CommerceGenerator : GeneratorBase
    {
        [FakerProperty]
        public ApplianceGenerator Appliance { get; }
        [FakerProperty]
        public BankGenerator Bank { get; }
        [FakerProperty]
        public BarcodeGenerator Barcode { get; }
        [FakerProperty]
        public BusinessGenerator Business { get; }
        [FakerProperty]
        public CodeGenerator Code { get; }
        [FakerProperty]
        public CommerceRENAMEGenerator CommerceRENAME { get; }
        [FakerProperty]
        public CompanyGenerator Company { get; }
        [FakerProperty]
        public ConstructionGenerator Construction { get; }
        [FakerProperty]
        public CurrencyGenerator Currency { get; }
        [FakerProperty]
        public FinanceGenerator Finance { get; }
        [FakerProperty]
        public IndustrySegmentsGenerator IndustrySegments { get; }
        [FakerProperty]
        public InvoiceGenerator Invoice { get; }
        [FakerProperty]
        public JobGenerator Job { get; }
        [FakerProperty]
        public MarketingGenerator Marketing { get; }
        [FakerProperty]
        public RestaurantGenerator Restaurant { get; }
        [FakerProperty]
        public StripeGenerator Stripe { get; }
        [FakerProperty]
        public SubscriptionGenerator Subscription { get; }
        internal CommerceGenerator(Faker faker)
                 : base(faker)
        {
            Appliance = new ApplianceGenerator(this.Faker);
            Bank = new BankGenerator(this.Faker);
            Barcode = new BarcodeGenerator(this.Faker);
            Business = new BusinessGenerator(this.Faker);
            Code = new CodeGenerator(this.Faker);
            CommerceRENAME = new CommerceRENAMEGenerator(this.Faker);
            Company = new CompanyGenerator(this.Faker);
            Construction = new ConstructionGenerator(this.Faker);
            Currency = new CurrencyGenerator(this.Faker);
            Finance = new FinanceGenerator(this.Faker);
            IndustrySegments = new IndustrySegmentsGenerator(this.Faker);
            Invoice = new InvoiceGenerator(this.Faker);
            Job = new JobGenerator(this.Faker);
            Marketing = new MarketingGenerator(this.Faker);
            Restaurant = new RestaurantGenerator(this.Faker);
            Stripe = new StripeGenerator(this.Faker);
            Subscription = new SubscriptionGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Appliance")]
        public partial class ApplianceGenerator : GeneratorBase
        {
            internal ApplianceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an appliance brand.
            /// </summary>
            /// <example>
            /// <code>Faker::Appliance.brand #=> "Bosch"</code>
            /// </example>
            [FakerMethod("brand")]
            public string Brand()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("appliance.brand"))));
            }
            /// <summary>
            /// Produces the name of a type of appliance equipment.
            /// </summary>
            /// <example>
            /// <code>Faker::Appliance.equipment #=> "Appliance plug"</code>
            /// </example>
            [FakerMethod("equipment")]
            public string Equipment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("appliance.equipment"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Bank")]
        public partial class BankGenerator : GeneratorBase
        {
            internal BankGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a bank account number.
            /// </summary>
            /// <param name="digits">
            /// Number of digits that the generated account number should have.
            /// (default value "10")
            /// </param>
            /// <example>
            /// <code>Faker::Bank.account_number #=> 6738582379
            /// Faker::Bank.account_number(digits: 13) #=> 673858237902</code>
            /// </example>
            [FakerMethod("account_number")]
            public string AccountNumber(long digits = 10)
            {
                return this.EvaluateExpression("#{String.random_string '" + digits + "','" + digits + "','0123456789'}");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces an Australian BSB (Bank-State-Branch) number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.bsb_number
            /// #=> "036616"</code>
            /// </example>
            [FakerMethod("bsb_number")]
            public string BsbNumber()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a bank iban number.
            /// </summary>
            /// <param name="countryCode">
            /// Specifies what country prefix is used to generate the iban code.
            /// (default value null [Random Country])
            /// </param>
            /// <example>
            /// <code>Faker::Bank.iban #=> "GB76DZJM33188515981979"
            /// Faker::Bank.iban(country_code: "be") #=> "BE6375388567752043"
            /// Faker::Bank.iban(country_code: nil) #=> "DE45186738071857270067"</code>
            /// </example>
            [FakerMethod("iban")]
            public string Iban(string? countryCode = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces the ISO 3166 code of a country that uses the IBAN system.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.iban_country_code #=> "CH"</code>
            /// </example>
            [FakerMethod("iban_country_code")]
            public string IbanCountryCode()
            */
            /// <summary>
            /// Produces a bank name.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.name #=> "ABN AMRO CORPORATE FINANCE LIMITED"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bank.name"))));
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a routing number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.routing_number #=> "729343831"</code>
            /// </example>
            [FakerMethod("routing_number")]
            public string RoutingNumber()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a valid routing number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.routing_number #=> "729343831"</code>
            /// </example>
            [FakerMethod("routing_number_with_format")]
            public string RoutingNumberWithFormat()
            */
            /// <summary>
            /// Produces a swift / bic number.
            /// </summary>
            /// <example>
            /// <code>Faker::Bank.swift_bic #=> "AAFMGB21"</code>
            /// </example>
            [FakerMethod("swift_bic")]
            public string SwiftBic()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bank.swift_bic"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Barcode")]
        public partial class BarcodeGenerator : GeneratorBase
        {
            internal BarcodeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// composite symbology string with check digit
            /// </summary>
            [FakerMethod("composite_symbology")]
            public string CompositeSymbology()
            {
                return this.Numerify(this.Letterify(this.ResolveYamlValue("barcode.composite_symbol")));
            }
            #warning Failed processing method ean_with_composite_symbology : method has no name or return type.
            /// <summary>
            /// Returns a EAN 13 digit format barcode number with check digit 
            /// </summary>
            /// <example>
            /// <code>&quot;2115190480285&quot;</code>
            /// </example>
            [FakerMethod("ean13")]
            public string Ean13()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{String.random_digits '12'}'}");
            }
            /// <summary>
            /// Returns a EAN 8 digit format barcode number with check digit 
            /// </summary>
            /// <example>
            /// <code>&quot;85657526&quot;
            /// &quot;30152700&quot;</code>
            /// </example>
            [FakerMethod("ean8")]
            public string Ean8()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{String.random_digits '7'}'}");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds the check digit to the barcode
            /// </summary>
            /// <param name="barcodeDigits">
            /// The barcode digits to create a bar code from
            /// <return>
            /// A complete numeric barcode including the check digit.
            /// </return>
            [FakerMethod("generate_barcode")]
            public string GenerateBarcode(string barcodeDigits)
            */
            /// <summary>
            /// Returns a 10 digit ISBN code as a barcode number with check digit 
            /// </summary>
            /// <example>
            /// <code>9798363807732</code>
            /// </example>
            [FakerMethod("isbn10")]
            public string Isbn10()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{String.sub_string '#{Code.isbn10 'false'}','0','9'}'}");
            }
            /// <summary>
            /// Returns a 13 digit ISBN code as a barcode number with check digit 
            /// </summary>
            /// <example>
            /// <code>9798363807732</code>
            /// </example>
            [FakerMethod("isbn13")]
            public string Isbn13()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{String.sub_string '#{Code.isbn13 'false'}','0','12'}'}");
            }
            /// <summary>
            /// Returns a ISMN format barcode number with check digit  @return [String].
            /// 
            /// @example
            /// Faker::Barcode.ismn      =&gt; &quot;9790527672897&quot;
            /// 
            /// </summary>
            [FakerMethod("ismn")]
            public string Ismn()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{numerify '#{barcode.ismn}'}'}");
            }
            /// <summary>
            /// Returns a ISSN format barcode number with check digit 
            /// @example
            /// Faker::Barcode.issn      =&gt; &quot;9775541703338&quot;
            /// </summary>
            [FakerMethod("issn")]
            public string Issn()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{numerify '#{barcode.issn}'}'}");
            }
            /// <summary>
            /// Returns a UPC_A format barcode number with check digit
            /// @example
            /// Faker::Barcode.upc_a      =&gt; &quot;766807541831&quot;
            /// </summary>
            [FakerMethod("upc_a")]
            public string UpcA()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{numerify '#{barcode.upc_a}'}'}");
            }
            #warning Failed processing method upc_a_with_composite_symbology : method has no name or return type.
            /// <summary>
            /// Returns a UPC_E format barcode number with check digit  @return [String]
            /// @example
            /// 03746820
            /// </summary>
            [FakerMethod("upc_e")]
            public string UpcE()
            {
                return this.EvaluateExpression("#{Barcode.generate_barcode '#{numerify '#{barcode.upc_e}'}'}");
            }
            #warning Failed processing method upc_e_with_composite_symbology : method has no name or return type.
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Business")]
        public partial class BusinessGenerator : GeneratorBase
        {
            internal BusinessGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a credit card expiration date in the form MMYY.
            /// </summary>
            /// <param name="expiredRatio">
            /// The number of expired dates to produce
            /// 0 - all numbers are valid
            /// 0.5 - even split of expired/valid dates
            /// 1 - all numbers are expired
            /// (default value "0")
            /// </param>
            /// <param name="separator">
            /// The separator to place between the MM and YY
            /// (default value "'/'")
            /// </param>
            /// <example>
            /// <code>Faker::Business.credit_card_expiry_date #=> <Date: 2015-11-11 ((2457338j,0s,0n),+0s,2299161j)></code>
            /// </example>
            /// <example>
            /// <code>credit_card_expiry_date() => 11/29
            /// credit_card_expiry_date(0.1) => 01/20
            /// credit_card_expiry_date(0.9, '') => 1028</code>
            /// </example>
            [FakerMethod("credit_card_expiry_date")]
            public string CreditCardExpiryDate(double expiredRatio = 0, string separator = "/")
            */
            /// <summary>
            /// Produces a type of credit card.
            /// </summary>
            /// <example>
            /// <code>Faker::Business.credit_card_type #=> "visa"</code>
            /// </example>
            [FakerMethod("credit_card_type")]
            public string CreditCardType()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("business.credit_card_types"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Code")]
        public partial class CodeGenerator : GeneratorBase
        {
            internal CodeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Retrieves a real Amazon ASIN code from https://archive.org/details/asin_listing.
            /// <p>Retrieves a real Amazon ASIN code from <a href="https://archive.org/details/asin_listing">archive.org/details/asin_listing</a></p>
            /// </summary>
            /// <example>
            /// <code>Faker::Code.asin #=> "B000MZW1GE"</code>
            /// </example>
            [FakerMethod("asin")]
            public string Asin()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("code.asin"))));
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random EAN (European Article Number) code.
            /// </summary>
            /// <param name="digits">
            /// the length of the code to generate (either 8 or 13)
            /// (default value "13")
            /// </param>
            /// <example>
            /// <code>Faker::Code.ean(digits: 8) #=> "36941070"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Code.ean #=> "9941880131907"</code>
            /// </example>
            [FakerMethod("ean")]
            public string Ean(long digits = 13)
            */
            /// <summary>
            /// Produces a random EAN (European Article Number) 13 digit code.
            /// </summary>
            [FakerMethod("ean13")]
            public string Ean13()
            {
                return this.EvaluateExpression("#{Code.ean '13'}");
            }
            /// <summary>
            /// Produces a random EAN (European Article Number) 8 digit code.
            /// </summary>
            [FakerMethod("ean8")]
            public string Ean8()
            {
                return this.EvaluateExpression("#{Code.ean '8'}");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random IMEI (International Mobile Equipment Number) code.
            /// </summary>
            /// <example>
            /// <code>Faker::Code.imei #=> "492033129092256"</code>
            /// </example>
            [FakerMethod("imei")]
            public string Imei()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random ISBN (International Standard Book Number) code.
            /// </summary>
            /// <param name="digits">
            /// the length of the code to generate (either 10 or 13)
            /// (default value "10")
            /// </param>
            /// <param name="separator">
            /// true if you want separators returned, false otherwise
            /// (default value "true")
            /// </param>
            /// <example>
            /// <code>Faker::Code.isbn(digits: 13) #=> "896579606969-8"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Code.isbn #=> "170366802-2"</code>
            /// </example>
            [FakerMethod("isbn")]
            public string Isbn(long digits = 10, bool separator = true)
            */
            /// <summary>
            /// Produces a random ISBN (International Standard Book Number) 10 digit code.
            /// </summary>
            /// <param name="separator">
            /// true if you want separators returned, false otherwise
            /// (default value "true")
            /// </param>
            [FakerMethod("isbn10")]
            public string Isbn10(bool separator = true)
            {
                return this.EvaluateExpression("#{Code.isbn '10','" + separator + "'}");
            }
            /// <summary>
            /// Produces a random ISBN (International Standard Book Number) 13 digit code.
            /// </summary>
            /// <param name="separator">
            /// true if you want separators returned, false otherwise
            /// (default value "true")
            /// </param>
            [FakerMethod("isbn13")]
            public string Isbn13(bool separator = true)
            {
                return this.EvaluateExpression("#{Code.isbn '13','" + separator + "'}");
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random NPI (National Provider Identifier) code.
            /// </summary>
            /// <example>
            /// <code>Faker::Code.npi #=> "9804062802"</code>
            /// </example>
            [FakerMethod("npi")]
            public string Npi()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random NRIC (National Registry Identity Card) code.
            /// <p>By default generates a Singaporean NRIC ID for someone who is born between the age of 18 and 65.</p>
            /// </summary>
            /// <param name="minAge">
            /// the min age of the person in years
            /// (default value "18")
            /// </param>
            /// <param name="maxAge">
            /// the max age of the person in years
            /// (default value "65")
            /// </param>
            /// <example>
            /// <code>Faker::Code.nric(min_age: 25, max_age: 50) #=> "S9347283G"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Code.nric(max_age: 55) #=> "S7876903C"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Code.nric(min_age: 25) #=> "S6281697Z"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Code.nric #=> "S6372958B"</code>
            /// </example>
            [FakerMethod("nric")]
            public string Nric(long minAge = 18, long maxAge = 65)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random RUT (Rol Unico Nacional) code.
            /// </summary>
            /// <example>
            /// <code>Faker::Code.rut #=> "91611842-2"</code>
            /// </example>
            [FakerMethod("rut")]
            public string Rut()
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random SIN (Social Insurance Number for Canada) code.
            /// </summary>
            /// <example>
            /// <code>Faker::Code.sin #=> "996586962"</code>
            /// </example>
            [FakerMethod("sin")]
            public string Sin()
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("CommerceRENAME")]
        public partial class CommerceRENAMEGenerator : GeneratorBase
        {
            internal CommerceRENAMEGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a randomized string of a brand name.
            /// </summary>
            /// <example>
            /// <code>Faker::Commerce.brand #=> 'Apple'</code>
            /// </example>
            [FakerMethod("brand")]
            public string Brand()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("commerce.brand"))));
            }
            #warning Failed processing method categories : method has no name or return type.
            /// <summary>
            /// Produces a random color.
            /// </summary>
            /// <example>
            /// <code>Faker::Commerce.color #=> "lavender"</code>
            /// </example>
            [FakerMethod("color")]
            public string Color()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("color.name"))));
            }
            #warning No implementation defined for method department(long max, bool fixedAmount = false);
            /// <summary>
            /// Produces a random material.
            /// </summary>
            /// <example>
            /// <code>Faker::Commerce.material #=> "Plastic"</code>
            /// </example>
            [FakerMethod("material")]
            public string Material()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("commerce.product_name.material"))));
            }
            #warning Failed processing method merge_categories : method has no name or return type.
            #warning No implementation defined for method price(UNKNOWN_Range range, bool asString = false);
            /// <summary>
            /// Produces a random product name.
            /// </summary>
            /// <example>
            /// <code>Faker::Commerce.product_name #=> "Practical Granite Shirt"</code>
            /// </example>
            [FakerMethod("product_name")]
            public string ProductName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("commerce.product_name.adjective"))));
            }
            /// <summary>
            /// Produces a random promotion code.
            /// </summary>
            /// <param name="digits">
            /// Updates the number of numerical digits used to generate the promotion code.
            /// (default value "6")
            /// </param>
            /// <example>
            /// <code>Faker::Commerce.promotion_code #=> "AmazingDeal829102"
            /// Faker::Commerce.promotion_code(digits: 2) #=> "AmazingPrice57"</code>
            /// </example>
            [FakerMethod("promotion_code")]
            public string PromotionCode(long digits = 6)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("commerce.promotion_code.adjective"))));
            }
            /// <summary>
            /// Produces a randomized string of a vendor name.
            /// </summary>
            /// <example>
            /// <code>Faker::Commerce.vendor #=> 'Dollar General'</code>
            /// </example>
            [FakerMethod("vendor")]
            public string Vendor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("commerce.vendor"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Company")]
        public partial class CompanyGenerator : GeneratorBase
        {
            internal CompanyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method abn_checksum : method has no name or return type.
            #warning No implementation defined for method australian_business_number();
            #warning No implementation defined for method brazilian_company_number();
            #warning No implementation defined for method bs();
            #warning No implementation defined for method buzzword();
            #warning Failed processing method calculate_gst_checksum : method has no name or return type.
            #warning No implementation defined for method catch_phrase();
            #warning Failed processing method collect_regon_sum : method has no name or return type.
            #warning No implementation defined for method czech_organisation_number();
            /// <summary>
            /// Produces a company department.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.department #=> "Information Technology"</code>
            /// </example>
            [FakerMethod("department")]
            public string Department()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.department"))));
            }
            #warning No implementation defined for method duns_number();
            #warning No implementation defined for method ein();
            #warning No implementation defined for method french_siren_number();
            #warning No implementation defined for method french_siret_number();
            #warning No implementation defined for method indian_gst_number();
            /// <summary>
            /// Produces a company industry.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.industry #=> "Food & Beverages"</code>
            /// </example>
            [FakerMethod("industry")]
            public string Industry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.industry"))));
            }
            #warning Failed processing method inn_checksum : method has no name or return type.
            #warning No implementation defined for method inn_number(UNKNOWN_Symbol type);
            /// <summary>
            /// Produces a company logo.
            ///                             <p>Get a random company logo url in PNG format.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Company.logo #=> "https://pigment.github.io/fake-logos/logos/medium/color/12.png"</code>
            /// </example>
            [FakerMethod("logo")]
            public string Logo()
            {
                return this.ResolveYamlValue("company.logo");
            }
            #warning Failed processing method luhn_algorithm : method has no name or return type.
            #warning Failed processing method mod11 : method has no name or return type.
            /// <summary>
            /// Produces a company name.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.name #=> "Roberts Inc"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.name"))));
            }
            #warning No implementation defined for method norwegian_organisation_number();
            #warning No implementation defined for method polish_register_of_national_economy();
            #warning No implementation defined for method polish_taxpayer_identification_number();
            /// <summary>
            /// Produces a company profession.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.profession #=> "factory worker"</code>
            /// </example>
            [FakerMethod("profession")]
            public string Profession()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.profession"))));
            }
            #warning No implementation defined for method russian_tax_number(string region, UNKNOWN_Symbol? type = null);
            /// <summary>
            /// Produces a company sic code.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.sic_code #=> "7383"</code>
            /// </example>
            [FakerMethod("sic_code")]
            public string SicCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.sic_code"))));
            }
            #warning No implementation defined for method south_african_close_corporation_registration_number();
            #warning No implementation defined for method south_african_listed_company_registration_number();
            #warning No implementation defined for method south_african_pty_ltd_registration_number();
            #warning No implementation defined for method south_african_trust_registration_number();
            #warning Failed processing method spanish_b_algorithm : method has no name or return type.
            #warning Failed processing method spanish_cif_control_digit : method has no name or return type.
            #warning No implementation defined for method spanish_organisation_number();
            /// <summary>
            /// Produces a company suffix.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.suffix #=> "LLC"</code>
            /// </example>
            [FakerMethod("suffix")]
            public string Suffix()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.suffix"))));
            }
            #warning No implementation defined for method swedish_organisation_number();
            /// <summary>
            /// Produces a company type.
            /// </summary>
            /// <example>
            /// <code>Faker::Company.type #=> "Partnership"</code>
            /// </example>
            [FakerMethod("type")]
            public string Type()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("company.type"))));
            }
            #warning Failed processing method weight_sum : method has no name or return type.
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Construction")]
        public partial class ConstructionGenerator : GeneratorBase
        {
            internal ConstructionGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random heavy equipment.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.heavy_equipment #=> "Excavator"</code>
            /// </example>
            [FakerMethod("heavy_equipment")]
            public string HeavyEquipment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.heavy_equipment"))));
            }
            /// <summary>
            /// Produces a random material.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.material #=> "Wood"</code>
            /// </example>
            [FakerMethod("material")]
            public string Material()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.materials"))));
            }
            /// <summary>
            /// Produces a random role.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.role #=> "Engineer"</code>
            /// </example>
            [FakerMethod("role")]
            public string Role()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.roles"))));
            }
            /// <summary>
            /// Produces a random standard cost code.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.standard_cost_code #=> "1-000 - Purpose"</code>
            /// </example>
            [FakerMethod("standard_cost_code")]
            public string StandardCostCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.standard_cost_codes"))));
            }
            /// <summary>
            /// Produces a random subcontract category.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.subcontract_category #=> "Curb & Gutter"</code>
            /// </example>
            [FakerMethod("subcontract_category")]
            public string SubcontractCategory()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.subcontract_categories"))));
            }
            /// <summary>
            /// Produces a random trade.
            /// </summary>
            /// <example>
            /// <code>Faker::Construction.trade #=> "Carpenter"</code>
            /// </example>
            [FakerMethod("trade")]
            public string Trade()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("construction.trades"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Currency")]
        public partial class CurrencyGenerator : GeneratorBase
        {
            internal CurrencyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a currency code.
            /// </summary>
            /// <example>
            /// <code>Faker::Currency.code #=> "USD"</code>
            /// </example>
            [FakerMethod("code")]
            public string Code()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("currency.code"))));
            }
            /// <summary>
            /// Produces the name of a currency.
            /// </summary>
            /// <example>
            /// <code>Faker::Currency.name #=> "Swedish Krona"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("currency.name"))));
            }
            /// <summary>
            /// Produces a currency symbol.
            /// </summary>
            /// <example>
            /// <code>Faker::Currency.symbol #=> "$"</code>
            /// </example>
            [FakerMethod("symbol")]
            public string Symbol()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("currency.symbol"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Finance")]
        public partial class FinanceGenerator : GeneratorBase
        {
            internal FinanceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Returns a random condominium fiscal code.
            /// </summary>
            /// <param name="country">
            /// Two capital letter country code to use for the vat number.
            /// (default value "'IT'")
            /// </param>
            /// <example>
            /// <code>Faker::Finance.condominium_fiscal_code #=> "012345678"</code>
            /// </example>
            [FakerMethod("condominium_fiscal_code")]
            public string CondominiumFiscalCode(string country = "IT")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.condominium_fiscal_code." + country + ""))));
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random credit card number.
            /// </summary>
            /// <param name="cardType">
            /// Specific credit card type (see CreditCard.CardTypes).
            /// (default value null [Random card type])
            /// </param>
            /// <param name="includeFormatting">
            /// includes formatting chars i.e. 3787-866288-08162
            /// (default value "true")
            /// </param>
            /// <example>
            /// <code>Faker::Finance.credit_card #=> "3018-348979-1853"
            /// Faker::Finance.credit_card(:mastercard) #=> "6771-8921-2291-6236"
            /// Faker::Finance.credit_card(:mastercard, :visa) #=> "4448-8934-1277-7195"</code>
            /// </example>
            [FakerMethod("credit_card")]
            public string CreditCard(string? cardType = null, bool includeFormatting = true)
            */
            /// <summary>
            /// Returns a randomly-selected stock market.
            /// </summary>
            /// <example>
            /// <code>Faker::Finance.stock_market #=> 'NASDAQ'</code>
            /// </example>
            [FakerMethod("stock_market")]
            public string StockMarket()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.stock_market"))));
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Returns a randomly-selected stock ticker from a specified market.
            /// </summary>
            /// <param name="market">
            /// The name of the market to choose the ticker from (e.g. NYSE, NASDAQ) 
            /// See Commerce.StockMarket.Market
            /// (default value null [Random Market])
            /// </param>
            /// <example>
            /// <code>Faker::Finance.ticker #=> 'AMZN'
            /// Faker::Finance.vat_number('NASDAQ') #=> 'GOOG'</code>
            /// </example>
            [FakerMethod("ticker")]
            public string Ticker(string? market = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random vat number.
            /// </summary>
            /// <param name="countryCode">
            /// Two capital letter country code to use for the vat number.
            /// (default value null [Random Country])
            /// </param>
            /// <example>
            /// <code>Faker::Finance.vat_number #=> "BR38.395.329/2471-83"
            /// Faker::Finance.vat_number('DE') #=> "DE593306671"
            /// Faker::Finance.vat_number('ZA') #=> "ZA79494416181"</code>
            /// </example>
            [FakerMethod("vat_number")]
            public string VatNumber(string? countryCode = null)
            */
            #warning Failed processing method vat_number_keys : method has no name or return type.
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("IndustrySegments")]
        public partial class IndustrySegmentsGenerator : GeneratorBase
        {
            internal IndustrySegmentsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an industry.
            /// </summary>
            /// <example>
            /// <code>Faker::IndustrySegments.industry #=> "Basic Materials"</code>
            /// </example>
            [FakerMethod("industry")]
            public string Industry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("industry_segments.industry"))));
            }
            /// <summary>
            /// Produces the name of a sector of an industry.
            /// </summary>
            /// <example>
            /// <code>Faker::IndustrySegments.sector #=> "Industrial Metals & Mining"</code>
            /// </example>
            [FakerMethod("sector")]
            public string Sector()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("industry_segments.sector"))));
            }
            /// <summary>
            /// Produces the name of a subsector of an industry.
            /// </summary>
            /// <example>
            /// <code>Faker::IndustrySegments.industry #=> "Basic Materials"</code>
            /// </example>
            [FakerMethod("sub_sector")]
            public string SubSector()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("industry_segments.sub_sector"))));
            }
            /// <summary>
            /// Produces the name of a super-sector of an industry.
            /// </summary>
            /// <example>
            /// <code>Faker::IndustrySegments.super_sector #=> "Basic Resources"</code>
            /// </example>
            [FakerMethod("super_sector")]
            public string SuperSector()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("industry_segments.super_sector"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Invoice")]
        public partial class InvoiceGenerator : GeneratorBase
        {
            internal InvoiceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method amount_between(long from, long to = 0);
            #warning Failed processing method calculate_weighted_sum : method has no name or return type.
            #warning No implementation defined for method creditor_reference(string @ref = "");
            #warning Failed processing method iban_checksum : method has no name or return type.
            #warning Failed processing method kidmod10 : method has no name or return type.
            #warning Failed processing method method_731 : method has no name or return type.
            #warning Failed processing method mod10_remainder : method has no name or return type.
            #warning No implementation defined for method reference(string @ref = "");
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Job")]
        public partial class JobGenerator : GeneratorBase
        {
            internal JobGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random job field.
            /// </summary>
            /// <example>
            /// <code>Faker::Job.field #=> "Banking"</code>
            /// </example>
            [FakerMethod("field")]
            public string Field()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("job.field"))));
            }
            /// <summary>
            /// Produces a random job skill.
            /// </summary>
            /// <example>
            /// <code>Faker::Job.key_skill #=> "Leadership"</code>
            /// </example>
            [FakerMethod("key_skill")]
            public string KeySkill()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("job.key_skills"))));
            }
            /// <summary>
            /// Produces a random job position.
            /// </summary>
            /// <example>
            /// <code>Faker::Job.position #=> "Strategist"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("job.position"))));
            }
            /// <summary>
            /// Produces a random job title.
            /// </summary>
            /// <example>
            /// <code>Faker::Job.title #=> "Construction Manager"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("job.title"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Marketing")]
        public partial class MarketingGenerator : GeneratorBase
        {
            internal MarketingGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a few marketing buzzwords.
            /// </summary>
            /// <example>
            /// <code>Faker::Marketing.buzzwords #=> "rubber meets the road"</code>
            /// </example>
            [FakerMethod("buzzwords")]
            public string Buzzwords()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("marketing.buzzwords"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Restaurant")]
        public partial class RestaurantGenerator : GeneratorBase
        {
            internal RestaurantGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a description of a restaurant.
            /// </summary>
            /// <example>
            /// <code>Faker::Restaurant.description
            /// #=> "We are committed to using the finest ingredients in our recipes. No food leaves our kitchen that we ourselves would not eat."</code>
            /// </example>
            [FakerMethod("description")]
            public string Description()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("restaurant.description"))));
            }
            /// <summary>
            /// Produces the name of a restaurant.
            /// </summary>
            /// <example>
            /// <code>Faker::Restaurant.name #=> "Curry King"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("restaurant.name"))));
            }
            /// <summary>
            /// Produces a review for a restaurant.
            /// </summary>
            /// <example>
            /// <code>Faker::Restaurant.review
            /// #=> "Brand new. Great design. Odd to hear pop music in a Mexican establishment. Music is a bit loud. It should be background."</code>
            /// </example>
            [FakerMethod("review")]
            public string Review()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("restaurant.review"))));
            }
            /// <summary>
            /// Produces a type of restaurant.
            /// </summary>
            /// <example>
            /// <code>Faker::Restaurant.type #=> "Comfort Food"</code>
            /// </example>
            [FakerMethod("type")]
            public string Type()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("restaurant.type"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Stripe")]
        public partial class StripeGenerator : GeneratorBase
        {
            internal StripeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random ccv number.
            /// </summary>
            /// <param name="cardType">
            /// Specific valid card type.
            /// (default value null [Random card type])
            /// </param>
            /// <example>
            /// <code>Faker::Stripe.ccv #=> "123"
            /// Faker::Stripe.ccv(card_type: "amex") #=> "1234"</code>
            /// </example>
            [FakerMethod("ccv")]
            public string Ccv(string? cardType = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random invalid card number.
            /// </summary>
            /// <example>
            /// <code>Faker::Stripe.invalid_card #=> "4000000000000002"
            /// Faker::Stripe.invalid_card(card_error: "addressZipFail") #=> "4000000000000010"</code>
            /// </example>
            [FakerMethod("invalid_card")]
            public string InvalidCard()
            */
            #warning No implementation defined for method month();
            #warning No implementation defined for method valid_card(string? cardType = null);
            #warning No implementation defined for method valid_token(string? cardType = null);
            #warning No implementation defined for method year();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Subscription")]
        public partial class SubscriptionGenerator : GeneratorBase
        {
            internal SubscriptionGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a payment method.
            /// </summary>
            /// <example>
            /// <code>Faker::Subscription.payment_method #=> "PayPal"</code>
            /// </example>
            [FakerMethod("payment_method")]
            public string PaymentMethod()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("subscription.payment_methods"))));
            }
            /// <summary>
            /// Produces the name of a payment term.
            /// </summary>
            /// <example>
            /// <code>Faker::Subscription.payment_term #=> "Monthly"</code>
            /// </example>
            [FakerMethod("payment_term")]
            public string PaymentTerm()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("subscription.payment_terms"))));
            }
            /// <summary>
            /// Produces the name of a subscription plan.
            /// </summary>
            /// <example>
            /// <code>Faker::Subscription.plan #=> "Platinum"</code>
            /// </example>
            [FakerMethod("plan")]
            public string Plan()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("subscription.plans"))));
            }
            /// <summary>
            /// Produces a subscription status.
            /// </summary>
            /// <example>
            /// <code>Faker::Subscription.status #=> "Active"</code>
            /// </example>
            [FakerMethod("status")]
            public string Status()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("subscription.statuses"))));
            }
            /// <summary>
            /// Produces the name of a subscription term.
            /// </summary>
            /// <example>
            /// <code>Faker::Subscription.subscription_term #=> "Annual"</code>
            /// </example>
            [FakerMethod("subscription_term")]
            public string SubscriptionTerm()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("subscription.subscription_terms"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Data")]
    public partial class DataGenerator : GeneratorBase
    {
        [FakerProperty]
        public AlphanumericGenerator Alphanumeric { get; }
        [FakerProperty]
        public BinaryGenerator Binary { get; }
        [FakerProperty]
        public BooleanGenerator Boolean { get; }
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
            Binary = new BinaryGenerator(this.Faker);
            Boolean = new BooleanGenerator(this.Faker);
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
                return this.EvaluateExpression("#{String.random_string '" + length + "','" + length + "','abcdefghijklmnopqrstuvwxyz'}");
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
                return this.EvaluateExpression("#{String.random_string '" + length + "','" + length + "','0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'}");
            }
            /// <param name="length">
            /// The length of the string to create
            /// (default value "10")
            /// </param>
            [FakerMethod("hex")]
            public string Hex(long length = 10)
            {
                return this.EvaluateExpression("#{String.random_string '" + length + "','" + length + "','0123456789ABCDEF'}");
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
                return this.EvaluateExpression("#{String.random_string '" + length + "','" + length + "','0123456789'}");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Crypto")]
        public partial class BinaryGenerator : GeneratorBase
        {
            internal BinaryGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Decodes base64 data, producing binary data
            /// </summary>
            /// <param name="base64Data">
            /// The base 64 data to decode
            [FakerMethod("base64_decode")]
            public byte[] Base64Decode(string base64Data)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Encodes binary data as base64
            /// </summary>
            /// <param name="binaryData">
            /// The data to encode
            [FakerMethod("base64_encode")]
            public string Base64Encode(byte[] binaryData)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Gets some random binary data
            /// </summary>
            /// <param name="minLen">
            /// The minimum number of bytes to return
            /// (default value "4")
            /// </param>
            /// <param name="maxLen">
            /// The maximum number of bytes to return
            /// (default value "32")
            /// </param>
            [FakerMethod("binary")]
            public byte[] Binary(long minLen = 4, long maxLen = 32)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Decodes hex data, producing binary data
            /// </summary>
            /// <param name="hexData">
            /// The hex data to decode
            [FakerMethod("hex_decode")]
            public byte[] HexDecode(string hexData)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Encodes binary data as hex
            /// </summary>
            /// <param name="binaryData">
            /// The data to encode
            [FakerMethod("hex_encode")]
            public string HexEncode(byte[] binaryData)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces an MD5 hash.
            /// </summary>
            /// <param name="binaryData">
            /// Binary data
            /// (default value null [Random data])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5")]
            public byte[] Md5(byte[]? binaryData = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces an MD5 hash of a string.
            /// </summary>
            /// <param name="data">
            /// Binary data
            /// (default value null [Random data])
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value null [UTF-8])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"</code>
            /// </example>
            [FakerMethod("md5_string")]
            public byte[] Md5String(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA1 hash.
            /// </summary>
            /// <param name="binaryData">
            /// The binary data tohash
            /// (default value null [Random data])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1")]
            public byte[] Sha1(byte[]? binaryData = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA1 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data tohash
            /// (default value null [Random data])
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value null [UTF-8])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
            /// </example>
            [FakerMethod("sha1_string")]
            public byte[] Sha1String(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA256 hash.
            /// </summary>
            /// <param name="binaryData">
            /// The binary data to hash
            /// (default value null [Random data])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256")]
            public byte[] Sha256(byte[]? binaryData = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA256 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value null [Random data])
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value null [UTF-8])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
            /// </example>
            [FakerMethod("sha256_string")]
            public byte[] Sha256String(string? data = null, Encoding? encoding = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA512 hash.
            /// </summary>
            /// <param name="binaryData">
            /// The binary data to hash
            /// (default value null [Random Data])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512")]
            public byte[] Sha512(byte[]? binaryData = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a SHA512 hash of a string.
            /// </summary>
            /// <param name="data">
            /// The binary data to hash
            /// (default value null [Random Data])
            /// </param>
            /// <param name="encoding">
            /// The encoding to use to convert the string into binary data in order to hash it.
            /// (default value null [UTF-8])
            /// </param>
            /// <example>
            /// <code>Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
            /// </example>
            [FakerMethod("sha512_string")]
            public byte[] Sha512String(string? data = null, Encoding? encoding = null)
            */
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
            /// Produce a random date in the past (up to N days).
            /// </summary>
            /// <param name="days">
            /// The maximum number of days to go into the past.
            /// (default value "365")
            /// </param>
            /// <example>
            /// <code>Faker::Date.backward_date(days: 14) #=> #<Date: 2019-09-12></code>
            /// </example>
            [FakerMethod("backward_date")]
            public DateOnly BackwardDate(long days = 365)
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
            /// Produce a random date which would create a date of birth within the age range specified
            /// </summary>
            /// <param name="minAge">
            /// The minimum age that the birthday would imply.
            /// (default value "18")
            /// </param>
            /// <param name="maxAge">
            /// The maximum age that the birthday would imply.
            /// (default value "65")
            /// </param>
            /// <example>
            /// <code>Faker::Date.birthday(min_age: 18, max_age: 65) #=> #<Date: 1986-03-28></code>
            /// </example>
            [FakerMethod("birthday")]
            public DateOnly Birthday(long minAge = 18, long maxAge = 65)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random date/time within the range.
            /// </summary>
            /// <param name="from">
            /// The time generated will be equal to or after this value
            /// (default value "1970-01-01")
            /// </param>
            /// <param name="to">
            /// The time generated will be equal to or before this value
            /// (default value "2050-01-01")
            /// </param>
            [FakerMethod("date_time")]
            public DateTime DateTime(DateTime? from = null, DateTime? to = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random day of the week translated into the selected locale
            /// </summary>
            [FakerMethod("day")]
            public string Day()
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
            /// <code>Faker::Date.forward_date(days: 23) #=> #<Date: 2014-10-03></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward_date(from: Date.current, days: 17) #=> #<Date: 2022-06-22></code>
            /// </example>
            /// <example>
            /// 
            /// <p>if used with or without Rails (Active Support)</p>
            /// 
            /// <code>Faker::Date.forward_date(from: '2022-06-03', days: 10) #=> #<Date: 2022-10-13></code>
            /// </example>
            [FakerMethod("forward_date")]
            public DateOnly ForwardDate(long days = 365)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random time within the range (if 'from' is greater than 'to' then 'to' is considered to be the following day).
            /// </summary>
            /// <param name="from">
            /// The time generated will be equal to or after this value
            /// (default value "00:00:00")
            /// </param>
            /// <param name="to">
            /// The time generated will be equal to or before this value
            /// (default value "23:59:59")
            /// </param>
            [FakerMethod("time")]
            public TimeOnly Time(TimeOnly? from = null, TimeOnly? to = null)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// A random week day (Monday-Friday ) translated into the selected locale
            /// </summary>
            [FakerMethod("week_day")]
            public string WeekDay()
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
            /// Creates a random floating point number
            /// </summary>
            /// <param name="min">
            /// A value greater than or equal to this will be generated
            /// (default value "-100000")
            /// </param>
            /// <param name="max">
            /// A value less than or equal to this will be generated
            /// (default value "1000000")
            /// </param>
            [FakerMethod("float")]
            public double Float(double min = -100000, double max = 1000000)
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
            [FakerMethod("integer")]
            public long Integer(long min = 0, long max = 1000000)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a negative float.
            /// </summary>
            /// <param name="min">
            /// The lower boundary.
            /// (default value "-1000000")
            /// </param>
            /// <param name="max">
            /// The higher boundary.
            /// (default value "0")
            /// </param>
            /// <example>
            /// <code>Faker::Number.negative #=> -4480.042585669558</code>
            /// </example>
            [FakerMethod("negative")]
            public double Negative(long min = -1000000, long max = 0)
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
            /// <param name="standardDeviation">
            /// (default value "3.5")
            /// </param>
            /// <example>
            /// <code>Faker::Number.normal(mean: 50, standard_deviation: 3.5) #=> 47.14669604069156</code>
            /// </example>
            [FakerMethod("normal")]
            public double Normal(long mean, double standardDeviation = 3.5)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a positive float.
            /// </summary>
            /// <param name="min">
            /// The lower boundary.
            /// (default value "0")
            /// </param>
            /// <param name="max">
            /// The higher boundary.
            /// (default value "1000000")
            /// </param>
            /// <example>
            /// <code>Faker::Number.positive #=> 235.59238499107653</code>
            /// </example>
            [FakerMethod("positive")]
            public double Positive(long min = 0, long max = 1000000)
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a number within two provided values.
            /// Boundaries are inclusive or exclusive depending on the range passed.
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
            [FakerMethod("length")]
            internal long Length(string text)
            */
            // Expecting native implementation
            /*
            /// <param name="text">
            /// The string as lower case
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
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
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
            /// <param name="length">
            /// The length the 'text' will be padded to
            /// <param name="@char">
            /// The character used to pad the string (must be 1 character )
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
            public string RandomString(long minLength = 50, long maxLength = 50, string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
            */
            // Expecting native implementation
            /*
            /// <summary>
            /// returns part of the string
            /// </summary>
            /// <param name="text">
            /// The string to get a part of
            /// <param name="start">
            /// The index to start the sub string at
            /// <param name="length">
            /// the number of bytes to get (by default it will return the rest of the string)
            /// (default value null)
            /// </param>
            [FakerMethod("sub_string")]
            public string SubString(string text, long start, long? length = null)
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
            /// (default value null [no excluded words])
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
            /// Generates paragraph with a given number of characters.
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
            /// (default value null [no excluded words])
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
            /// (default value null [no excluded words])
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
            /// (default value "''" [no excluded words])
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.word   => "soluto"
            /// Faker::Lorem.word(exclude_words: 'error') => "nisi"
            /// Faker::Lorem.word(exclude_words: 'id, error') => "et"
            /// Faker::Lorem.word(exclude_words: ['id', 'error']) => "consequatur"</code>
            /// </example>
            [FakerMethod("word")]
            public string Word(string excludeWords = "")
            {
                return this.EvaluateExpression("#{words '1','false','" + excludeWords + "'}");
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
            /// (default value null [no excluded words])
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
            // Expecting native implementation
            /*
            /// <summary>
            /// Adds 0s to the start of the 'text' until it is 'length' long
            /// </summary>
            /// <param name="text">
            /// The text to add pad
            /// <param name="length">
            /// The length the 'text' will be padded to
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
            /// <param name="length">
            /// The length the 'text' will be padded to
            [FakerMethod("zero_pad_right")]
            public string ZeroPadRight(string text, long length)
            */
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Internet")]
    public partial class InternetGenerator : GeneratorBase
    {
        [FakerProperty]
        public HTMLGenerator HTML { get; }
        [FakerProperty]
        public JsonGenerator Json { get; }
        [FakerProperty]
        public MarkdownGenerator Markdown { get; }
        internal InternetGenerator(Faker faker)
                 : base(faker)
        {
            HTML = new HTMLGenerator(this.Faker);
            Json = new JsonGenerator(this.Faker);
            Markdown = new MarkdownGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("HTML")]
        public partial class HTMLGenerator : GeneratorBase
        {
            internal HTMLGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method available_methods : method has no name or return type.
            /// <summary>
            /// Produces a random code block formatted in HTML.
            /// </summary>
            /// <example>
            /// <code>Faker::HTML.code #=> "<code>Eos quasi qui.</code>"</code>
            /// </example>
            [FakerMethod("code")]
            public string Code()
            {
                return this.EvaluateExpression("<code>#{Lorem.sentence '2','true','4'}</code>");
            }
            #warning No implementation defined for method element(string tag, string content, UNKNOWN_Hash attributes);
            /// <summary>
            /// Produces a random emphasis formatting on a random word in two HTML paragraphs.
            /// </summary>
            /// <example>
            /// <code>Faker::HTML.emphasis #=> "<em>repellat id impedit</em>"</code>
            /// </example>
            [FakerMethod("emphasis")]
            public string Emphasis()
            {
                return this.Translate(this.EvaluateExpression("<em>#{Lorem.paragraph '1'}</em>"));
            }
            #warning Failed processing method generate_table_row : method has no name or return type.
            #warning No implementation defined for method heading();
            #warning No implementation defined for method link(string rel = "stylesheet");
            #warning No implementation defined for method ordered_list();
            #warning No implementation defined for method paragraph(long sentenceCount, bool supplemental, long randomSentencesToAdd, List<string>? excludeWords = null);
            #warning Failed processing method random : method has no name or return type.
            #warning No implementation defined for method sandwich(long sentences, long repeat = 1);
            /// <summary>
            /// Generates a random <script> tag with the `src` attribute set to a random URL.
            /// </summary>
            /// <example>
            /// <code>Faker::HTML.script #=> "<script src=\"http://gulgowski.name/jordan.weimann.js\"></script>"</code>
            /// </example>
            [FakerMethod("script")]
            public string Script()
            {
                return this.Translate(this.EvaluateExpression("<script src=\"#{Internet.url}.js\"></script>"));
            }
            #warning No implementation defined for method table();
            #warning No implementation defined for method unordered_list();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Json")]
        public partial class JsonGenerator : GeneratorBase
        {
            internal JsonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method add_depth_to_json(UNKNOWN_Hash{String => String} json, long width, UNKNOWN_Hash options);
            #warning Failed processing method add_hash : method has no name or return type.
            #warning Failed processing method add_hash_to_bottom : method has no name or return type.
            #warning Failed processing method build_keys_from_array : method has no name or return type.
            #warning Failed processing method build_shallow_hash : method has no name or return type.
            #warning No implementation defined for method shallow_json(long width, UNKNOWN_Hash options);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Markdown")]
        public partial class MarkdownGenerator : GeneratorBase
        {
            internal MarkdownGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method available_methods : method has no name or return type.
            /// <summary>
            /// Produces a random code block formatted in Ruby.
            /// </summary>
            /// <example>
            /// <code>Faker::Markdown.block_code #=> "```ruby\nEos quasi qui.\n```"</code>
            /// </example>
            [FakerMethod("block_code")]
            public string BlockCode()
            {
                return this.EvaluateExpression("```ruby\n#{Lorem.sentence '2','true','4'}\n```");
            }
            /// <summary>
            /// Produces a random emphasis formatting on a random word in two sentences.
            /// </summary>
            /// <example>
            /// <code>Faker::Markdown.emphasis #=> "_Incidunt atque quis repellat id impedit.  Quas numquam quod incidunt dicta non. Blanditiis delectus laudantium atque reiciendis qui._"</code>
            /// </example>
            [FakerMethod("emphasis")]
            public string Emphasis()
            {
                return this.ResolveYamlValue("markdown.emphasis");
            }
            /// <summary>
            /// Produces a random header format.
            /// </summary>
            /// <example>
            /// <code>Faker::Markdown.headers #=> "##### Autem"</code>
            /// </example>
            [FakerMethod("headers")]
            public string Headers()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("markdown.headers"))));
            }
            /// <summary>
            /// Produces a random inline code snippet between two sentences.
            /// </summary>
            /// <example>
            /// <code>Faker::Markdown.inline_code #=> "Aut eos quis suscipit. `Dignissimos voluptatem expedita qui.` Quo doloremque veritatis tempora aut."</code>
            /// </example>
            [FakerMethod("inline_code")]
            public string InlineCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.EvaluateExpression("`#{Lorem.sentence '5'}`"))));
            }
            #warning No implementation defined for method ordered_list();
            #warning Failed processing method random : method has no name or return type.
            #warning No implementation defined for method sandwich(long sentences, long repeat = 1);
            #warning No implementation defined for method table();
            #warning No implementation defined for method unordered_list();
        }
        
        // Expecting native implementation
        /*
        /// <summary>
        /// Produces a random string of alphabetic characters, (no digits).
        /// </summary>
        /// <param name="length">
        /// The length of the string to generate
        /// (default value "16")
        /// </param>
        /// <param name="padding">
        /// Toggles if a final equal ‘=’ will be added.
        /// (default value "false")
        /// </param>
        /// <param name="urlsafe">
        /// Toggles charset to ‘-’ and ‘_’ instead of ‘+’ and ‘/’.
        /// (default value "true")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.base64
        /// #=> "r_hbZ2DSD-ZACzZT"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Internet.base64(length: 4, padding: true, urlsafe: false)
        /// #=> "x1/R="</code>
        /// </example>
        [FakerMethod("base64")]
        public string Base64(long length = 16, bool padding = false, bool urlsafe = true)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Generate Web Crawler's user agents.
        /// </summary>
        /// <param name="vendor">
        /// Name of vendor, supported vendors are googlebot, bingbot, duckduckbot, baiduspider, yandexbot
        /// (default value null)
        /// </param>
        /// <example>
        /// <code>Faker::Internet.bot_user_agent                        #=> "Mozilla/5.0 (compatible; YandexBot/3.0; +http://yandex.com/bots)"
        /// Faker::Internet.bot_user_agent(vendor: 'googlebot')   #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; Googlebot/2.1; +http://www.google.com/bot.html) Chrome/99.0.4844.84 Safari/537.36"
        /// Faker::Internet.bot_user_agent(vendor: 'bingbot')     #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm) Chrome/86.0.4240.68 Safari/537.36 Edg/86.0.622.31"</code>
        /// </example>
        [FakerMethod("bot_user_agent")]
        public string BotUserAgent(string? vendor = null)
        */
        #warning Failed processing method device_token : method has no name or return type.
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the domain name.
        /// </summary>
        /// <param name="subdomain">
        /// If true passed adds a subdomain in response
        /// (default value "false")
        /// </param>
        /// <param name="domain">
        /// (default value null)
        /// </param>
        /// <example>
        /// <code>Faker::Internet.domain_name                                                   #=> "altenwerth-gerhold.example"
        /// Faker::Internet.domain_name(subdomain: true)                                  #=> "metz.mclaughlin-brekke.test"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker')                 #=> "foo.faker.test"
        /// Faker::Internet.domain_name(domain: 'faker-ruby.org')                         #=> "faker-ruby.org"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker-ruby.org')        #=> "foo.faker-ruby.org"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker.faker-ruby.org')  #=> "faker.faker-ruby.org"</code>
        /// </example>
        [FakerMethod("domain_name")]
        public string DomainName(bool subdomain = false, string? domain = null)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the domain suffix e.g.
        /// com, org, co, biz, info etc.
        /// </summary>
        /// <param name="safe">
        /// Returns a 'safe' domain - one that wont get annoyed if you aim random traffic at it.
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.domain_suffix              #=> "com"
        /// Faker::Internet.domain_suffix              #=> "biz"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "example"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "test"</code>
        /// </example>
        [FakerMethod("domain_suffix")]
        public string DomainSuffix(bool safe = false)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the domain word for internet.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.domain_word   #=> "senger"</code>
        /// </example>
        [FakerMethod("domain_word")]
        public string DomainWord()
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the email address.
        /// </summary>
        /// <param name="name">
        /// The user name part of the address
        /// (default value null [Random])
        /// </param>
        /// <param name="separators">
        /// A string containing allowable separators within the email address (i.e. '-_')
        /// (default value "'-_'")
        /// </param>
        /// <param name="domain">
        /// The email domain to use
        /// (default value null [Random])
        /// </param>
        /// <example>
        /// <code>Faker::Internet.email                                                           #=> "renee@zieme.test"
        /// Faker::Internet.email(name: 'smith')                                            #=> "smith@bergnaum.test"
        /// Faker::Internet.email(name: 'sam smith', separators: ['-'])                     #=> "smith-sam@tromp.example"
        /// Faker::Internet.email(name: 'sam smith', separators: ['-'], domain: 'test')     #=> "sam-smith@test.example"
        /// Faker::Internet.email(domain: 'gmail.com')                                      #=> "foo@gmail.com"</code>
        /// </example>
        [FakerMethod("email")]
        public string Email(string? name = null, string separators = "-_", string? domain = null)
        */
        /// <summary>
        /// Returns the IPv4 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v4_address   #=> "97.117.128.93"</code>
        /// </example>
        [FakerMethod("ip_v4_address")]
        public string IpV4Address()
        {
            return this.EvaluateExpression("#{Data.Number.integer '0','255'}.#{Data.Number.integer '0','255'}.#{Data.Number.integer '0','255'}.#{Data.Number.integer '0','255'}");
        }
        /// <summary>
        /// Returns Ipv4 address with CIDR, range from 1 to 31.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/16"
        /// Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/24"</code>
        /// </example>
        [FakerMethod("ip_v4_cidr")]
        public string IpV4Cidr()
        {
            return this.EvaluateExpression("#{ip_v4_address}/#{Data.Number.integer '1','31'}");
        }
        /// <summary>
        /// Returns Ipv6 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v6_address   #=> "7754:76d4:c7aa:7646:ea68:1abb:4055:4343"</code>
        /// </example>
        [FakerMethod("ip_v6_address")]
        public string IpV6Address()
        {
            return this.EvaluateExpression("#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}:#{random_hex '4'}");
        }
        /// <summary>
        /// Returns Ipv6 address with CIDR, range between 1 to 127
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v6_cidr  #=> "beca:9b99:4bb6:9712:af2f:516f:8507:96e1/99"</code>
        /// </example>
        [FakerMethod("ip_v6_cidr")]
        public string IpV6Cidr()
        {
            return this.EvaluateExpression("#{ip_v6_address}/#{Data.Number.integer '1','127'}");
        }
        /// <summary>
        /// Returns the MAC address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.mac_address                   #=> "74:d0:c9:22:95:12"
        /// Faker::Internet.mac_address(prefix: 'a')      #=> "0a:91:ce:24:89:3b"
        /// Faker::Internet.mac_address(prefix: 'aa')     #=> "aa:38:a0:3e:e8:41"
        /// Faker::Internet.mac_address(prefix: 'aa:44')  #=> "aa:44:30:88:6e:95"</code>
        /// </example>
        [FakerMethod("mac_address")]
        public string MacAddress()
        {
            return this.EvaluateExpression("#{random_hex '2'}:#{random_hex '2'}:#{random_hex '2'}:#{random_hex '2'}:#{random_hex '2'}:#{random_hex '2'}");
        }
        // Expecting native implementation
        /*
        /// <summary>
        /// Produces a randomized string of characters suitable for passwords.
        /// </summary>
        /// <param name="minLength">
        /// The minimum length of the password
        /// (default value "8")
        /// </param>
        /// <param name="maxLength">
        /// The maximum length of the password
        /// (default value "16")
        /// </param>
        /// <param name="mixCase">
        /// Toggles if uppercased letters are allowed. If true, at least one will be added.
        /// (default value "true")
        /// </param>
        /// <param name="specialCharacters">
        /// Toggles if special characters are allowed. If true, at least one will be added.
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.password #=> "Vg5mSvY1UeRg7"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Internet.password(min_length: 8) #=> "YfGjIk0hGzDqS0"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Internet.password(min_length: 10, max_length: 20) #=> "EoC9ShWd1hWq4vBgFw"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Internet.password(min_length: 10, max_length: 20, mix_case: true) #=> "3k5qS15aNmG"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Internet.password(min_length: 10, max_length: 20, mix_case: true, special_characters: true) #=> "*%NkOnJsH4"</code>
        /// </example>
        [FakerMethod("password")]
        public string Password(long minLength = 8, long maxLength = 16, bool mixCase = true, bool specialCharacters = false)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the private IPv4 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.private_ip_v4_address   #=> "127.120.80.42"</code>
        /// </example>
        [FakerMethod("private_ip_v4_address")]
        public string PrivateIpV4Address()
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the public IPv4 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.public_ip_v4_address   #=> "127.120.80.42"</code>
        /// </example>
        [FakerMethod("public_ip_v4_address")]
        public string PublicIpV4Address()
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns unique string in URL.
        /// </summary>
        /// <param name="words">
        /// Comma or period separated words list
        /// (default value null)
        /// </param>
        /// <param name="glue">
        /// Separator to add between words passed, default used are ‘-’ or ‘_’
        /// (default value null)
        /// </param>
        /// <example>
        /// <code>Faker::Internet.slug                                    #=> "repudiandae-sed"
        /// Faker::Internet.slug(words: 'test, faker')              #=> "test-faker"
        /// Faker::Internet.slug(words: 'test. faker')              #=> "test-faker"
        /// Faker::Internet.slug(words: 'test. faker', glue: '$')   #=> "test$faker"</code>
        /// </example>
        [FakerMethod("slug")]
        public string Slug(string? words = null, string? glue = null)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns URL.
        /// </summary>
        /// <param name="host">
        /// (default value null)
        /// </param>
        /// <param name="path">
        /// (default value null)
        /// </param>
        /// <param name="scheme">
        /// (default value "'https'")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.url                                                           #=> "http://treutel.test/demarcus"
        /// Faker::Internet.url(host: 'faker')                                            #=> "http://faker/shad"
        /// Faker::Internet.url(host: 'faker', path: '/docs')                             #=> "http://faker/docs"
        /// Faker::Internet.url(host: 'faker', path: '/docs', scheme: 'https')            #=> "https://faker/docs"</code>
        /// </example>
        [FakerMethod("url")]
        public string Url(string? host = null, string? path = null, string scheme = "https")
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Generates the random browser identifier.
        /// </summary>
        /// <param name="vendor">
        /// Name of vendor, supported vendors are aol, chrome, firefox, internet_explorer, netscape, opera, safari
        /// (default value null)
        /// </param>
        /// <example>
        /// <code>Faker::Internet.user_agent                    #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        /// Faker::Internet.user_agent(vendor: 'chrome')  #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        /// Faker::Internet.user_agent(vendor: 'safari')  #=> "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A"
        /// Faker::Internet.user_agent(vendor: 'faker')   #=> "Mozilla/5.0 (Windows; U; Win 9x 4.90; SG; rv:1.9.2.4) Gecko/20101104 Netscape/9.1.0285"</code>
        /// </example>
        [FakerMethod("user_agent")]
        public string UserAgent(string? vendor = null)
        */
        // Expecting native implementation
        /*
        /// <summary>
        /// Returns the username.
        /// </summary>
        /// <param name="minLen">
        /// The minimum length for the generated username
        /// (default value "4")
        /// </param>
        /// <param name="maxLen">
        /// The maximum length for the generated username
        /// (default value "12")
        /// </param>
        /// <param name="separators">
        /// A string containig all characters that can be used to separate parts of the name.
        /// (default value "'._'")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.username(10)          #=> "lulu.goodwin"
        /// Faker::Internet.username(5, 10)       #=> "morris"
        /// Faker::Internet.username(5, 10)       #=> "berryberry"
        /// Faker::Internet.username(5, 20, '_')  #=> "nikki_sawaynnikki_saway"</code>
        /// </example>
        [FakerMethod("username")]
        public string Username(long minLen = 4, long maxLen = 12, string separators = "._")
        */
        /// <summary>
        /// Generated universally unique identifier.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.uuid  #=> "8a6cdd40-6d78-4fdb-912b-190e3057197f"</code>
        /// </example>
        [FakerMethod("uuid")]
        public string Uuid()
        {
            return this.EvaluateExpression("#{random_hex '8'}-#{random_hex '4'}-#{random_hex '4'}-#{random_hex '4'}-#{random_hex '4'}-#{random_hex '8'}");
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Person")]
    public partial class PersonGenerator : GeneratorBase
    {
        [FakerProperty]
        public AddressGenerator Address { get; }
        [FakerProperty]
        public AvatarGenerator Avatar { get; }
        [FakerProperty]
        public BloodGenerator Blood { get; }
        [FakerProperty]
        public DemographicGenerator Demographic { get; }
        [FakerProperty]
        public DrivingLicenceGenerator DrivingLicence { get; }
        [FakerProperty]
        public GenderGenerator Gender { get; }
        [FakerProperty]
        public IDNumberGenerator IDNumber { get; }
        [FakerProperty]
        public NameGenerator Name { get; }
        [FakerProperty]
        public PhoneNumberGenerator PhoneNumber { get; }
        [FakerProperty]
        public RelationshipGenerator Relationship { get; }
        internal PersonGenerator(Faker faker)
                 : base(faker)
        {
            Address = new AddressGenerator(this.Faker);
            Avatar = new AvatarGenerator(this.Faker);
            Blood = new BloodGenerator(this.Faker);
            Demographic = new DemographicGenerator(this.Faker);
            DrivingLicence = new DrivingLicenceGenerator(this.Faker);
            Gender = new GenderGenerator(this.Faker);
            IDNumber = new IDNumberGenerator(this.Faker);
            Name = new NameGenerator(this.Faker);
            PhoneNumber = new PhoneNumberGenerator(this.Faker);
            Relationship = new RelationshipGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Address")]
        public partial class AddressGenerator : GeneratorBase
        {
            internal AddressGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a building number.
            /// </summary>
            /// <example>
            /// <code>csFaker::Address.building_number #=> "7304"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Address.building_number #=> "7304"</code>
            /// </example>
            [FakerMethod("building_number")]
            public string BuildingNumber()
            {
                return this.Numerify(this.ResolveYamlValue("address.building_number"));
            }
            /// <summary>
            /// Produces the name of a city.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.city #=> "Imogeneborough"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.ResolveYamlValue("address.city");
            }
            /// <summary>
            /// Produces a city prefix.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.city_prefix #=> "Lake"</code>
            /// </example>
            [FakerMethod("city_prefix")]
            public string CityPrefix()
            {
                return this.ResolveYamlValue("address.city_prefix");
            }
            /// <summary>
            /// Produces a city suffix.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.city_suffix #=> "fort"</code>
            /// </example>
            [FakerMethod("city_suffix")]
            public string CitySuffix()
            {
                return this.ResolveYamlValue("address.city_suffix");
            }
            /// <summary>
            /// Produces the name of a community.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.community #=> "University Crossing"</code>
            /// </example>
            [FakerMethod("community")]
            public string Community()
            {
                return this.ResolveYamlValue("address.community");
            }
            /// <summary>
            /// Produces the name of a country.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.country #=> "French Guiana"</code>
            /// </example>
            [FakerMethod("country")]
            public string Country()
            {
                return this.Translate(this.ResolveYamlValue("address.country"));
            }
            /// <summary>
            /// Produces a country by ISO country code.
            /// See the [List of ISO 3166 country codes](<a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">en.wikipedia.org/wiki/List_of_ISO_3166_country_codes</a>) on Wikipedia for a full list.
            /// </summary>
            /// <param name="code">
            /// An ISO country code.
            /// (default value "'US'")
            /// </param>
            /// <example>
            /// <code>Faker::Address.country_by_code(code: 'NL') #=> "Netherlands"</code>
            /// </example>
            [FakerMethod("country_by_code")]
            public string CountryByCode(string code = "US")
            {
                return this.ResolveYamlValue("address.country_by_code." + code + "");
            }
            /// <summary>
            /// Produces an ISO 3166 country code.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.country_code #=> "IT"</code>
            /// </example>
            [FakerMethod("country_code")]
            public string CountryCode()
            {
                return this.ResolveYamlValue("address.country_code");
            }
            /// <summary>
            /// Produces a long (alpha-3) ISO 3166 country code.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.country_code_long #=> "ITA"</code>
            /// </example>
            [FakerMethod("country_code_long")]
            public string CountryCodeLong()
            {
                return this.ResolveYamlValue("address.country_code_long");
            }
            /// <summary>
            /// Produces an ISO 3166 country code when given a country name.
            /// </summary>
            /// <param name="name">
            /// Country name in snake_case format.
            /// (default value "'United States'")
            /// </param>
            /// <return>
            /// The ISO 3166 country code
            /// </return>
            /// <example>
            /// <code>Faker::Address.country_name_to_code(name: 'United States') #=> "US"</code>
            /// </example>
            [FakerMethod("country_name_to_code")]
            public string CountryNameToCode(string name = "United States")
            {
                return this.ResolveYamlValue("address.country_by_name.#{String.lower '" + name + "'}");
            }
            /// <summary>
            /// Produces a latitude.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.latitude #=> -58.17256227443719</code>
            /// </example>
            [FakerMethod("latitude")]
            public double Latitude()
            {
                return double.Parse(this.EvaluateExpression("#{Data.Number.float '-180','180'}"));
            }
            /// <summary>
            /// Produces a longitude.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.longitude #=> -156.65548382095133</code>
            /// </example>
            [FakerMethod("longitude")]
            public double Longitude()
            {
                return double.Parse(this.EvaluateExpression("#{Data.Number.float '-180','180'}"));
            }
            /// <summary>
            /// Produces a mail box number.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.mail_box #=> "PO Box 123"</code>
            /// </example>
            [FakerMethod("mail_box")]
            public string MailBox()
            {
                return this.Numerify(this.Letterify(this.ResolveYamlValue("address.mail_box")));
            }
            /// <summary>
            /// Produces a postcode/zipcode.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.zip_code #=> "58517"</code>
            /// </example>
            [FakerMethod("postcode")]
            public string Postcode()
            {
                return this.Numerify(this.Letterify(this.ResolveYamlValue("address.postcode")));
            }
            /// <summary>
            /// Produces a secondary address.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.secondary_address #=> "Apt. 672"</code>
            /// </example>
            [FakerMethod("secondary_address")]
            public string SecondaryAddress()
            {
                return this.Numerify(this.Letterify(this.ResolveYamlValue("address.secondary_address")));
            }
            /// <summary>
            /// Produces a state abbreviation.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.state_abbr #=> "AP"</code>
            /// </example>
            [FakerMethod("state_abbr")]
            public string StateAbbr()
            {
                return this.ResolveYamlValue("address.state_abbr");
            }
            /// <summary>
            /// Produces a street address.
            /// </summary>
            /// <param name="includeSecondary">
            /// Whether or not to include the secondary address.
            /// (default value "false")
            /// </param>
            /// <example>
            /// <code>Faker::Address.street_address #=> "282 Kevin Brook"</code>
            /// </example>
            [FakerMethod("street_address")]
            public string StreetAddress(bool includeSecondary = false)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("address.street_address"))));
            }
            /// <summary>
            /// Produces a street name.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.street_name #=> "Larkin Fork"</code>
            /// </example>
            [FakerMethod("street_name")]
            public string StreetName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("address.street_name"))));
            }
            /// <summary>
            /// Produces a street suffix.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.street_suffix #=> "Street"</code>
            /// </example>
            [FakerMethod("street_suffix")]
            public string StreetSuffix()
            {
                return this.ResolveYamlValue("address.street_suffix");
            }
            /// <summary>
            /// Produces the name of a time zone.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.time_zone #=> "Asia/Yakutsk"</code>
            /// </example>
            [FakerMethod("time_zone")]
            public string TimeZone()
            {
                return this.ResolveYamlValue("address.time_zone");
            }
            /// <summary>
            /// Produces a Zip Code/Postocde.
            /// </summary>
            /// <example>
            /// <code>Faker::Address.zip_code #=> "58517"
            /// Faker::Address.zip_code #=> "23285-4905"</code>
            /// </example>
            [FakerMethod("zip_code")]
            public string ZipCode()
            {
                return this.Numerify(this.Letterify(this.ResolveYamlValue("address.postcode")));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Avatar")]
        public partial class AvatarGenerator : GeneratorBase
        {
            internal AvatarGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a URL for an avatar from robohash.org.
            /// </summary>
            /// <param name="name">
            /// The name of the image, also used as a key to generate the image, so changing this changes the image. 
            /// Default value will select some Lorem text
            /// (default value null)
            /// </param>
            /// <param name="size">
            /// image size in pixels, in the format of ‘AxB’
            /// (default value "'48x48'")
            /// </param>
            /// <param name="format">
            /// The image file format ('png', 'jpg' or 'bmp')
            /// (default value "'jpg'")
            /// </param>
            /// <param name="type">
            /// The avatar set to use (Robot, Monster, RobotHead, Cat, Person)
            /// (default value "Person")
            /// </param>
            /// <param name="background">
            /// Include a background
            /// (default value "false")
            /// </param>
            /// <example>
            /// <code>Faker::Avatar.image => "https://robohash.org/sitsequiquia.png?size=300x300&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug")=> "https://robohash.org/my-own-slug.png?size=300x300&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50") => "https://robohash.org/my-own-slug.png?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "jpg")=> "https://robohash.org/my-own-slug.jpg?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp") => "https://robohash.org/my-own-slug.bmp?size=50x50&set=set1"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp", set: "set1", bgset: "bg1") => "https://robohash.org/my-own-slug.bmp?size=50x50&set=set1&bgset=bg1"</code>
            /// </example>
            [FakerMethod("image")]
            public string Image(string? name = null, string size = "48x48", string format = "jpg", AvatarType type = Person, bool background = false)
            */
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Blood")]
        public partial class BloodGenerator : GeneratorBase
        {
            internal BloodGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random blood group name.
            /// </summary>
            /// <example>
            /// <code>Faker::Blood.group #=> "AB-"</code>
            /// </example>
            [FakerMethod("group")]
            public string Group()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("blood.group"))));
            }
            /// <summary>
            /// Produces a random blood RH-Factor.
            /// </summary>
            /// <example>
            /// <code>Faker::Blood.rh_factor #=> "-"</code>
            /// </example>
            [FakerMethod("rh_factor")]
            public string RhFactor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("blood.rh_factor"))));
            }
            /// <summary>
            /// Produces a random blood type.
            /// </summary>
            /// <example>
            /// <code>Faker::Blood.type #=> "AB"</code>
            /// </example>
            [FakerMethod("type")]
            public string Type()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("blood.type"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Demographic")]
        public partial class DemographicGenerator : GeneratorBase
        {
            internal DemographicGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a denonym.
            /// </summary>
            /// <example>
            /// <code>Faker::Demographic.denonym #=> "Panamanian"</code>
            /// </example>
            [FakerMethod("demonym")]
            public string Demonym()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("demographic.demonym"))));
            }
            /// <summary>
            /// Produces a level of educational attainment.
            /// </summary>
            /// <example>
            /// <code>Faker::Demographic.educational_attainment #=> "GED or alternative credential"</code>
            /// </example>
            [FakerMethod("educational_attainment")]
            public string EducationalAttainment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("demographic.educational_attainment"))));
            }
            #warning No implementation defined for method height(UNKNOWN_Symbol? unit = null);
            /// <summary>
            /// Produces a marital status.
            /// </summary>
            /// <example>
            /// <code>Faker::Demographic.marital_status #=> "Widowed"</code>
            /// </example>
            [FakerMethod("marital_status")]
            public string MaritalStatus()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("demographic.marital_status"))));
            }
            /// <summary>
            /// Produces the name of a race.
            /// </summary>
            /// <example>
            /// <code>Faker::Demographic.race #=> "Native Hawaiian or Other Pacific Islander"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("demographic.race"))));
            }
            /// <summary>
            /// Produces a sex for demographic purposes.
            /// </summary>
            /// <example>
            /// <code>Faker::Demographic.sex #=> "Female"</code>
            /// </example>
            [FakerMethod("sex")]
            public string Sex()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("demographic.sex"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("DrivingLicence")]
        public partial class DrivingLicenceGenerator : GeneratorBase
        {
            internal DrivingLicenceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method british_driving_licence(string lastName, string initials, string gender, string dateOfBirth);
            #warning Failed processing method gb_licence_checksum : method has no name or return type.
            #warning Failed processing method gb_licence_padding : method has no name or return type.
            #warning Failed processing method gb_licence_year : method has no name or return type.
            #warning No implementation defined for method initialize();
            #warning No implementation defined for method northern_irish_driving_licence();
            #warning Failed processing method random_gender : method has no name or return type.
            #warning Failed processing method uk_driving_licence : method has no name or return type.
            /// <summary>
            /// Produces a random USA driving licence number by state code passed.
            /// </summary>
            /// <param name="state">
            /// The name of the state to create a driving license number for
            /// (default value "'California'")
            /// </param>
            /// <example>
            /// <code>Faker::DrivingLicence.usa_driving_licence                 #=> "V5598249"
            /// Faker::DrivingLicence.usa_driving_licence('new mexico')   #=> "270692028"
            /// Faker::DrivingLicence.usa_driving_licence('New Mexico')   #=> "68178637"</code>
            /// </example>
            [FakerMethod("usa_driving_licence")]
            public string UsaDrivingLicence(string state = "California")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("driving_licence.usa.#{String.lower '#{String.replace '" + state + "',' ','_'}'}"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Gender")]
        public partial class GenderGenerator : GeneratorBase
        {
            internal GenderGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces either 'Male' or 'Female'.
            /// </summary>
            /// <example>
            /// <code>Faker::Gender.binary_type #=> "Female"</code>
            /// </example>
            [FakerMethod("binary_type")]
            public string BinaryType()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("gender.binary_types"))));
            }
            /// <summary>
            /// Produces either 'f' or 'm'.
            /// </summary>
            /// <example>
            /// <code>Faker::Gender.short_binary_type #=> "f"</code>
            /// </example>
            [FakerMethod("short_binary_type")]
            public string ShortBinaryType()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("gender.short_binary_types"))));
            }
            /// <summary>
            /// Produces the name of a gender identity.
            /// </summary>
            /// <example>
            /// <code>Faker::Gender.type #=> "Non-binary"</code>
            /// </example>
            [FakerMethod("type")]
            public string Type()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("gender.types"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("IDNumber")]
        public partial class IDNumberGenerator : GeneratorBase
        {
            internal IDNumberGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method _translate : method has no name or return type.
            #warning No implementation defined for method brazilian_citizen_number(bool formatted = false);
            #warning Failed processing method brazilian_citizen_number_checksum_digit : method has no name or return type.
            #warning Failed processing method brazilian_citizen_number_digit : method has no name or return type.
            #warning Failed processing method brazilian_document_checksum : method has no name or return type.
            #warning Failed processing method brazilian_document_digit : method has no name or return type.
            #warning No implementation defined for method brazilian_id(bool formatted = false);
            #warning Failed processing method brazilian_id_checksum_digit : method has no name or return type.
            #warning Failed processing method brazilian_id_digit : method has no name or return type.
            #warning No implementation defined for method chilean_id();
            #warning Failed processing method chilean_verification_code : method has no name or return type.
            #warning No implementation defined for method croatian_id(bool international = false);
            #warning Failed processing method croatian_id_checksum_digit : method has no name or return type.
            #warning Failed processing method danish_control_digits : method has no name or return type.
            #warning No implementation defined for method danish_id_number(bool formatted, DateOnly birthday, UNKNOWN_Symbol? gender = null);
            #warning No implementation defined for method french_insee_number();
            #warning No implementation defined for method invalid();
            #warning No implementation defined for method invalid_south_african_id_number();
            #warning Failed processing method south_african_id_checksum_digit : method has no name or return type.
            #warning No implementation defined for method spanish_citizen_number();
            #warning No implementation defined for method spanish_foreign_citizen_number();
            #warning Failed processing method ssn_valid : method has no name or return type.
            #warning No implementation defined for method valid();
            #warning No implementation defined for method valid_south_african_id_number();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Name")]
        public partial class NameGenerator : GeneratorBase
        {
            internal NameGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random female first name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.female_first_name #=> "Natasha"</code>
            /// </example>
            [FakerMethod("female_first_name")]
            public string FemaleFirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.female_first_name"))));
            }
            /// <summary>
            /// Produces a random first name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.first_name #=> "Kaci"</code>
            /// </example>
            [FakerMethod("first_name")]
            public string FirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.first_name"))));
            }
            #warning No implementation defined for method initials(long number = 3);
            /// <summary>
            /// Produces a random last name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.last_name #=> "Ernser"</code>
            /// </example>
            [FakerMethod("last_name")]
            public string LastName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.last_name"))));
            }
            /// <summary>
            /// Produces a random male first name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.male_first_name #=> "Edward"</code>
            /// </example>
            [FakerMethod("male_first_name")]
            public string MaleFirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.male_first_name"))));
            }
            /// <summary>
            /// Produces a random name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.name #=> "Tyshawn Johns Sr."</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.name"))));
            }
            /// <summary>
            /// Produces a random name with middle name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.name_with_middle #=> "Aditya Elton Douglas"</code>
            /// </example>
            [FakerMethod("name_with_middle")]
            public string NameWithMiddle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.name_with_middle"))));
            }
            /// <summary>
            /// Produces a random gender neutral first name.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.neutral_first_name #=> "Casey"</code>
            /// </example>
            [FakerMethod("neutral_first_name")]
            public string NeutralFirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.neutral_first_name"))));
            }
            /// <summary>
            /// Produces a random name prefix.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.prefix #=> "Mr."</code>
            /// </example>
            [FakerMethod("prefix")]
            public string Prefix()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.prefix"))));
            }
            /// <summary>
            /// Produces a random name suffix.
            /// </summary>
            /// <example>
            /// <code>Faker::Name.suffix #=> "IV"</code>
            /// </example>
            [FakerMethod("suffix")]
            public string Suffix()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("name.suffix"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("PhoneNumber")]
        public partial class PhoneNumberGenerator : GeneratorBase
        {
            internal PhoneNumberGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random area code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.area_code #=> "201"
            /// Faker::PhoneNumber.area_code #=> "613"
            /// Faker::PhoneNumber.area_code #=> "321"</code>
            /// </example>
            [FakerMethod("area_code")]
            public string AreaCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phone_number.area_code"))));
            }
            /// <summary>
            /// Produces a random cell phone number in a random format without the country code and it can have different dividers.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.cell_phone #=> "(836) 115-8995"
            /// Faker::PhoneNumber.cell_phone #=> "382-597-5739"
            /// Faker::PhoneNumber.cell_phone #=> "316.828.1822"</code>
            /// </example>
            [FakerMethod("cell_phone")]
            public string CellPhone()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cell_phone.formats"))));
            }
            #warning No implementation defined for method cell_phone_in_e164();
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random cell phone number with country code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.cell_phone_with_country_code #=> "+852 (190) 987-9034"
            /// Faker::PhoneNumber.cell_phone_with_country_code #=> "+64 (820) 583-6474"
            /// Faker::PhoneNumber.cell_phone_with_country_code #=> "+1 591.871.7985"</code>
            /// </example>
            [FakerMethod("cell_phone_with_country_code")]
            public string CellPhoneWithCountryCode()
            */
            /// <summary>
            /// Produces a random country code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.country_code #=> "+20"
            /// Faker::PhoneNumber.country_code #=> "+39"
            /// Faker::PhoneNumber.country_code #=> "+852"</code>
            /// </example>
            [FakerMethod("country_code")]
            public string CountryCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phone_number.country_code"))));
            }
            /// <summary>
            /// Produces a random exchange code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.exchange_code #=> "208"
            /// Faker::PhoneNumber.exchange_code #=> "415"
            /// Faker::PhoneNumber.exchange_code #=> "652"</code>
            /// </example>
            [FakerMethod("exchange_code")]
            public string ExchangeCode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phone_number.exchange_code"))));
            }
            /// <summary>
            /// Produces a phone number in a random format without the country code and it can have different dividers.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.phone_number #=> "(504) 113-1705"
            /// Faker::PhoneNumber.phone_number #=> "662.291.7201"
            /// Faker::PhoneNumber.phone_number #=> "9415283713"</code>
            /// </example>
            [FakerMethod("phone_number")]
            public string PhoneNumber()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phone_number.formats"))));
            }
            // Expecting native implementation
            /*
            /// <summary>
            /// Produces a random phone number with country code.
            /// </summary>
            /// <example>
            /// <code>Faker::PhoneNumber.phone_number_with_country_code #=> "+55 466-746-6882"
            /// Faker::PhoneNumber.phone_number_with_country_code #=> "+81 3718219558"
            /// Faker::PhoneNumber.phone_number_with_country_code #=> "+49 140 957 9846"</code>
            /// </example>
            [FakerMethod("phone_number_with_country_code")]
            public string PhoneNumberWithCountryCode()
            */
            #warning No implementation defined for method subscriber_number(long length = 4);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Relationship")]
        public partial class RelationshipGenerator : GeneratorBase
        {
            internal RelationshipGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method familial();
            /// <summary>
            /// Produces a random in-law relationship.
            /// </summary>
            /// <example>
            /// <code>Faker::Relationship.in_law #=> "Brother-in-law"</code>
            /// </example>
            [FakerMethod("in_law")]
            public string InLaw()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("relationship.in_law"))));
            }
            /// <summary>
            /// Produces a random parent relationship.
            /// </summary>
            /// <example>
            /// <code>Faker::Relationship.parent #=> "Father"</code>
            /// </example>
            [FakerMethod("parent")]
            public string Parent()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("relationship.parent"))));
            }
            /// <summary>
            /// Produces a random sibling relationship.
            /// </summary>
            /// <example>
            /// <code>Faker::Relationship.sibling #=> "Sister"</code>
            /// </example>
            [FakerMethod("sibling")]
            public string Sibling()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("relationship.sibling"))));
            }
            /// <summary>
            /// Produces a random spouse relationship.
            /// </summary>
            /// <example>
            /// <code>Faker::Relationship.spouse #=> "Husband"</code>
            /// </example>
            [FakerMethod("spouse")]
            public string Spouse()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("relationship.spouse"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    partial class Faker
    {
        [FakerProperty]
        public CommerceGenerator Commerce { get; }
        [FakerProperty]
        public DataGenerator Data { get; }
        [FakerProperty]
        public InternetGenerator Internet { get; }
        [FakerProperty]
        public PersonGenerator Person { get; }
        
        public Faker(CultureInfo locale, Random random)
        {
            this.Random = random;
            
            // Create the Faker Generators
            Commerce = new CommerceGenerator(this);
            Data = new DataGenerator(this);
            Internet = new InternetGenerator(this);
            Person = new PersonGenerator(this);
            
            Init(locale);
        }
    }
}
