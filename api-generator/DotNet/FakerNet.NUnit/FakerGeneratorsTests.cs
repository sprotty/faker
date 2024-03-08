using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace FakerNet.NUnit
{
    [TestClass]
    public class Test_Blockchain : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Blockchain_Aeternity : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Aeternity.Address());
        }
        [TestMethod()]
        public void Test_Contract_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Aeternity.Contract());
        }
        [TestMethod()]
        public void Test_Oracle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Aeternity.Oracle());
        }
        [TestMethod()]
        public void Test_Transaction_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Aeternity.Transaction());
        }
    }
    
    [TestClass]
    public class Test_Blockchain_Bitcoin : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Address_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Bitcoin.Address());
        }
        [TestMethod()]
        public void Test_AddressFor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Bitcoin.AddressFor());
        }
        [TestMethod()]
        public void Test_TestnetAddress_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Blockchain.Bitcoin.TestnetAddress());
        }
    }
    
    [TestClass]
    public class Test_Blockchain_Ethereum : FakerNUnitBase
    {
        #warning No implementation defined for method address();
    }
    
    [TestClass]
    public class Test_Blockchain_Tezos : FakerNUnitBase
    {
        #warning No implementation defined for method account();
        #warning No implementation defined for method block();
        #warning No implementation defined for method contract();
        #warning No implementation defined for method operation();
        #warning No implementation defined for method public_key();
        #warning No implementation defined for method secret_key();
        #warning No implementation defined for method signature();
    }
    
    [TestClass]
    public class Test_Books : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Author_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Author());
        }
        [TestMethod()]
        public void Test_Genre_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Genre());
        }
        [TestMethod()]
        public void Test_Publisher_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Publisher());
        }
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Title());
        }
    }
    
    [TestClass]
    public class Test_Books_Bible : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Bible.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Bible.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Bible.Quote());
        }
    }
    
    [TestClass]
    public class Test_Books_Cosmere : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Allomancer_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Allomancer());
        }
        [TestMethod()]
        public void Test_Aon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Aon());
        }
        [TestMethod()]
        public void Test_Feruchemist_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Feruchemist());
        }
        [TestMethod()]
        public void Test_Herald_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Herald());
        }
        [TestMethod()]
        public void Test_KnightRadiant_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.KnightRadiant());
        }
        [TestMethod()]
        public void Test_Metal_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Metal());
        }
        [TestMethod()]
        public void Test_Shard_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Shard());
        }
        [TestMethod()]
        public void Test_ShardWorld_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.ShardWorld());
        }
        [TestMethod()]
        public void Test_Spren_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Spren());
        }
        [TestMethod()]
        public void Test_Surge_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Cosmere.Surge());
        }
    }
    
    [TestClass]
    public class Test_Books_CultureSeries : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Book_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.Book());
        }
        [TestMethod()]
        public void Test_Civ_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.Civ());
        }
        [TestMethod()]
        public void Test_CultureShip_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.CultureShip());
        }
        [TestMethod()]
        public void Test_CultureShipClass_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.CultureShipClass());
        }
        [TestMethod()]
        public void Test_CultureShipClassAbv_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.CultureShipClassAbv());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.CultureSeries.Planet());
        }
    }
    
    [TestClass]
    public class Test_Books_DcComics : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.DcComics.Hero());
        }
        [TestMethod()]
        public void Test_Heroine_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.DcComics.Heroine());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.DcComics.Name());
        }
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.DcComics.Title());
        }
        [TestMethod()]
        public void Test_Villain_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.DcComics.Villain());
        }
    }
    
    [TestClass]
    public class Test_Books_Dune : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Dune.Character());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Dune.City());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Dune.Planet());
        }
        #warning No implementation defined for method quote(string? character = null);
        #warning No implementation defined for method saying(string? source = null);
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Dune.Title());
        }
    }
    
    [TestClass]
    public class Test_Books_Lovecraft : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Deity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Lovecraft.Deity());
        }
        [TestMethod()]
        public void Test_Fhtagn_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Lovecraft.Fhtagn());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Lovecraft.Location());
        }
        // Method : paragraph : Can not generated test for method with required arguments.
        #warning No implementation defined for method paragraph_by_chars(long characters = 256);
        #warning No implementation defined for method paragraphs(long number = 3);
        // Method : sentence : Can not generated test for method with required arguments.
        #warning No implementation defined for method sentences(long number = 3);
        [TestMethod()]
        public void Test_Tome_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Lovecraft.Tome());
        }
        #warning No implementation defined for method word();
        // Method : words : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Books_TheKingkillerChronicle : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Book_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.TheKingkillerChronicle.Book());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.TheKingkillerChronicle.Character());
        }
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.TheKingkillerChronicle.Creature());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.TheKingkillerChronicle.Location());
        }
    }
    
    [TestClass]
    public class Test_Books_Tolkien : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Tolkien.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Tolkien.Location());
        }
        [TestMethod()]
        public void Test_Poem_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Tolkien.Poem());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Books.Tolkien.Race());
        }
    }
    
    [TestClass]
    public class Test_ChileRut : FakerNUnitBase
    {
        #warning No implementation defined for method check_digit();
        #warning No implementation defined for method dv();
        #warning Failed processing method format_rut
        // Method : full_rut : Can not generated test for method with required arguments.
        #warning Failed processing method last_rut
        // Method : rut : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Coin : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Flip_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Coin.Flip());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Coin.Name());
        }
    }
    
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
        public void Test_CreditCardNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Business.CreditCardNumber());
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
        #warning No implementation defined for method logo();
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
    public class Test_Commerce_CryptoCoin : FakerNUnitBase
    {
        #warning No implementation defined for method acronym();
        [TestMethod()]
        public void Test_CoinArray_Execute()
        {
            FakerForEveryLocale<List<string>>(faker => faker.Commerce.CryptoCoin.CoinArray());
        }
        #warning No implementation defined for method coin_hash();
        #warning No implementation defined for method coin_name();
        #warning No implementation defined for method url_logo();
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
        // Method : credit_card : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_StockMarket_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Commerce.Finance.StockMarket());
        }
        // Method : ticker : Can not generated test for method with required arguments.
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
        #warning No implementation defined for method creditor_reference(string ref = "");
        #warning Failed processing method iban_checksum
        #warning Failed processing method kidmod10
        #warning Failed processing method method_731
        #warning Failed processing method mod10_remainder
        #warning No implementation defined for method reference(string ref = "");
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
        #warning No implementation defined for method ccv(string? cardType = null);
        #warning No implementation defined for method invalid_card();
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
    public class Test_Creature : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Creature_Animal : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Animal.Name());
        }
    }
    
    [TestClass]
    public class Test_Creature_Bird : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Adjective_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.Adjective());
        }
        [TestMethod()]
        public void Test_Anatomy_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.Anatomy());
        }
        [TestMethod()]
        public void Test_AnatomyPastTense_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.AnatomyPastTense());
        }
        [TestMethod()]
        public void Test_Color_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.Color());
        }
        [TestMethod()]
        public void Test_CommonFamilyName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.CommonFamilyName());
        }
        [TestMethod()]
        public void Test_CommonName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.CommonName());
        }
        [TestMethod()]
        public void Test_EmotionalAdjective_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.EmotionalAdjective());
        }
        [TestMethod()]
        public void Test_Geo_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.Geo());
        }
        [TestMethod()]
        public void Test_ImplausibleCommonName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.ImplausibleCommonName());
        }
        #warning No implementation defined for method order();
        #warning No implementation defined for method order_with_common_name();
        [TestMethod()]
        public void Test_PlausibleCommonName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.PlausibleCommonName());
        }
        [TestMethod()]
        public void Test_SillyAdjective_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Bird.SillyAdjective());
        }
    }
    
    [TestClass]
    public class Test_Creature_Cat : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Breed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Cat.Breed());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Cat.Name());
        }
        [TestMethod()]
        public void Test_Registry_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Cat.Registry());
        }
    }
    
    [TestClass]
    public class Test_Creature_Dog : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Age_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.Age());
        }
        [TestMethod()]
        public void Test_Breed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.Breed());
        }
        [TestMethod()]
        public void Test_CoatLength_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.CoatLength());
        }
        #warning No implementation defined for method gender();
        [TestMethod()]
        public void Test_MemePhrase_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.MemePhrase());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.Name());
        }
        [TestMethod()]
        public void Test_Size_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.Size());
        }
        [TestMethod()]
        public void Test_Sound_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Dog.Sound());
        }
    }
    
    [TestClass]
    public class Test_Creature_Horse : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Breed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Horse.Breed());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Creature.Horse.Name());
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
    public class Test_Data_Color : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_ColorName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Color.ColorName());
        }
        #warning No implementation defined for method hex_color(UNKNOWN_Hash? args = null);
        // Method : hsl_color : Can not generated test for method with required arguments.
        // Method : hsl_to_hex : Can not generated test for method with required arguments.
        #warning No implementation defined for method hsla_color();
        #warning No implementation defined for method rgb_color();
        #warning Failed processing method single_rgb_color
    }
    
    [TestClass]
    public class Test_Data_Crypto : FakerNUnitBase
    {
        #warning No implementation defined for method md5();
        #warning No implementation defined for method sha1();
        #warning No implementation defined for method sha256();
        #warning No implementation defined for method sha512();
    }
    
    [TestClass]
    public class Test_Data_Date : FakerNUnitBase
    {
        #warning No implementation defined for method backward(long days = 365);
        // Method : between : Can not generated test for method with required arguments.
        // Method : between_except : Can not generated test for method with required arguments.
        // Method : birthday : Can not generated test for method with required arguments.
        #warning Failed processing method birthday_date
        // Method : forward : Can not generated test for method with required arguments.
        #warning Failed processing method get_date_object
        // Method : in_date_period : Can not generated test for method with required arguments.
        // Method : on_day_of_week_between : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Data_Lorem : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_LocalePeriod_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.LocalePeriod());
        }
        [TestMethod()]
        public void Test_LocaleQuestionMark_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.LocaleQuestionMark());
        }
        [TestMethod()]
        public void Test_LocaleSpace_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.LocaleSpace());
        }
        [TestMethod()]
        public void Test_Paragraph_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.Paragraph());
        }
        [TestMethod()]
        public void Test_ParagraphByChars_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.ParagraphByChars());
        }
        [TestMethod()]
        public void Test_Question_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.Question());
        }
        [TestMethod()]
        public void Test_Sentence_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.Sentence());
        }
        [TestMethod()]
        public void Test_Word_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.Word());
        }
        [TestMethod()]
        public void Test_Words_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.Lorem.Words());
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
        // Method : between : Can not generated test for method with required arguments.
        #warning No implementation defined for method binary(long digits = 4);
        // Method : decimal : Can not generated test for method with required arguments.
        #warning No implementation defined for method decimal_part(long digits = 10);
        #warning No implementation defined for method digit();
        #warning Failed processing method generate
        #warning Failed processing method greater_than_zero
        #warning No implementation defined for method hexadecimal(long digits = 6);
        #warning No implementation defined for method leading_zero_number(long digits = 10);
        #warning Failed processing method less_than_zero
        // Method : negative : Can not generated test for method with required arguments.
        #warning No implementation defined for method non_zero_digit();
        // Method : normal : Can not generated test for method with required arguments.
        #warning No implementation defined for method number(long digits = 10);
        // Method : positive : Can not generated test for method with required arguments.
        #warning Failed processing method should_be
        #warning No implementation defined for method within(UNKNOWN_Range? range = null);
    }
    
    [TestClass]
    public class Test_Data_String : FakerNUnitBase
    {
        #warning No implementation defined for method char_space_ratio();
        // Method : length : Can not generated test for method with required arguments.
        // Method : lower : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_RandomString_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Data.String.RandomString());
        }
        #warning No implementation defined for method select_a();
        #warning No implementation defined for method space_or_utf8_char();
        // Method : sub_string : Can not generated test for method with required arguments.
        #warning No implementation defined for method utf8character();
        #warning No implementation defined for method utf8string();
    }
    
    [TestClass]
    public class Test_Data_Time : FakerNUnitBase
    {
        // Method : backward : Can not generated test for method with required arguments.
        // Method : between : Can not generated test for method with required arguments.
        // Method : between_dates : Can not generated test for method with required arguments.
        #warning Failed processing method date_with_random_time
        // Method : forward : Can not generated test for method with required arguments.
        #warning Failed processing method get_time_object
        #warning Failed processing method hours
        #warning Failed processing method minutes
        #warning Failed processing method seconds
        #warning Failed processing method time_with_format
    }
    
    [TestClass]
    public class Test_Defence : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Defence_Military : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AirForceRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.AirForceRank());
        }
        [TestMethod()]
        public void Test_ArmyRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.ArmyRank());
        }
        [TestMethod()]
        public void Test_CoastGuardRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.CoastGuardRank());
        }
        [TestMethod()]
        public void Test_DodPaygrade_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.DodPaygrade());
        }
        [TestMethod()]
        public void Test_MarinesRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.MarinesRank());
        }
        [TestMethod()]
        public void Test_NavyRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.NavyRank());
        }
        [TestMethod()]
        public void Test_SpaceForceRank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.Military.SpaceForceRank());
        }
    }
    
    [TestClass]
    public class Test_Defence_NatoPhoneticAlphabet : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CodeWord_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Defence.NatoPhoneticAlphabet.CodeWord());
        }
    }
    
    [TestClass]
    public class Test_Education : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Campus_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.Campus());
        }
        [TestMethod()]
        public void Test_CourseName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.CourseName());
        }
        [TestMethod()]
        public void Test_Degree_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.Degree());
        }
        [TestMethod()]
        public void Test_PrimarySchool_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.PrimarySchool());
        }
        [TestMethod()]
        public void Test_SecondarySchool_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.SecondarySchool());
        }
        [TestMethod()]
        public void Test_Subject_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.Subject());
        }
        [TestMethod()]
        public void Test_University_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Education.University());
        }
    }
    
    [TestClass]
    public class Test_FoodAndDrink : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_FoodAndDrink_Beer : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Alcohol_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Alcohol());
        }
        [TestMethod()]
        public void Test_Blg_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Blg());
        }
        [TestMethod()]
        public void Test_Hop_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Hop());
        }
        [TestMethod()]
        public void Test_Ibu_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Ibu());
        }
        [TestMethod()]
        public void Test_Malts_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Malts());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Name());
        }
        [TestMethod()]
        public void Test_Style_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Style());
        }
        [TestMethod()]
        public void Test_Yeast_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Beer.Yeast());
        }
    }
    
    [TestClass]
    public class Test_FoodAndDrink_Coffee : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_BlendName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Coffee.BlendName());
        }
        [TestMethod()]
        public void Test_Intensifier_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Coffee.Intensifier());
        }
        [TestMethod()]
        public void Test_Notes_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Coffee.Notes());
        }
        [TestMethod()]
        public void Test_Origin_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Coffee.Origin());
        }
        #warning Failed processing method search_format
        [TestMethod()]
        public void Test_Variety_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Coffee.Variety());
        }
    }
    
    [TestClass]
    public class Test_FoodAndDrink_Food : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Allergen_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Allergen());
        }
        [TestMethod()]
        public void Test_Description_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Description());
        }
        [TestMethod()]
        public void Test_Dish_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Dish());
        }
        [TestMethod()]
        public void Test_EthnicCategory_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.EthnicCategory());
        }
        [TestMethod()]
        public void Test_Fruits_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Fruits());
        }
        [TestMethod()]
        public void Test_Ingredient_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Ingredient());
        }
        [TestMethod()]
        public void Test_Measurement_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Measurement());
        }
        [TestMethod()]
        public void Test_MetricMeasurement_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.MetricMeasurement());
        }
        [TestMethod()]
        public void Test_Spice_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Spice());
        }
        [TestMethod()]
        public void Test_Vegetables_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Food.Vegetables());
        }
    }
    
    [TestClass]
    public class Test_FoodAndDrink_Tea : FakerNUnitBase
    {
        #warning No implementation defined for method type();
        [TestMethod()]
        public void Test_Variety_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.FoodAndDrink.Tea.Variety());
        }
    }
    
    [TestClass]
    public class Test_Game : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Genre_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Genre());
        }
        [TestMethod()]
        public void Test_Platform_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Platform());
        }
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Title());
        }
    }
    
    [TestClass]
    public class Test_Game_ClashOfClans : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_DefensiveBuilding_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ClashOfClans.DefensiveBuilding());
        }
        [TestMethod()]
        public void Test_Rank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ClashOfClans.Rank());
        }
        [TestMethod()]
        public void Test_Troop_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ClashOfClans.Troop());
        }
    }
    
    [TestClass]
    public class Test_Game_Control : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AlteredItem_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.AlteredItem());
        }
        [TestMethod()]
        public void Test_AlteredWorldEvent_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.AlteredWorldEvent());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.Character());
        }
        [TestMethod()]
        public void Test_Hiss_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.Hiss());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.Location());
        }
        [TestMethod()]
        public void Test_ObjectOfPower_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.ObjectOfPower());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.Quote());
        }
        [TestMethod()]
        public void Test_TheBoard_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Control.TheBoard());
        }
    }
    
    [TestClass]
    public class Test_Game_DnD : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Alignment_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Alignment());
        }
        [TestMethod()]
        public void Test_Background_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Background());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.City());
        }
        [TestMethod()]
        public void Test_FirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.FirstName());
        }
        [TestMethod()]
        public void Test_Klass_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Klass());
        }
        [TestMethod()]
        public void Test_Language_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Language());
        }
        [TestMethod()]
        public void Test_LastName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.LastName());
        }
        [TestMethod()]
        public void Test_MeleeWeapon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.MeleeWeapon());
        }
        [TestMethod()]
        public void Test_Monster_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Monster());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Name());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.Race());
        }
        [TestMethod()]
        public void Test_RangedWeapon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.RangedWeapon());
        }
        [TestMethod()]
        public void Test_TitleName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.DnD.TitleName());
        }
    }
    
    [TestClass]
    public class Test_Game_Dota : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Building_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Building());
        }
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Hero());
        }
        [TestMethod()]
        public void Test_Item_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Item());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Player());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Quote());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Dota.Team());
        }
    }
    
    [TestClass]
    public class Test_Game_ElderScrolls : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.City());
        }
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Creature());
        }
        [TestMethod()]
        public void Test_Dragon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Dragon());
        }
        [TestMethod()]
        public void Test_FirstName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.FirstName());
        }
        [TestMethod()]
        public void Test_Jewelry_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Jewelry());
        }
        [TestMethod()]
        public void Test_LastName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.LastName());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Name());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Race());
        }
        [TestMethod()]
        public void Test_Region_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Region());
        }
        [TestMethod()]
        public void Test_Weapon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.ElderScrolls.Weapon());
        }
    }
    
    [TestClass]
    public class Test_Game_Fallout : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Fallout.Character());
        }
        [TestMethod()]
        public void Test_Faction_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Fallout.Faction());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Fallout.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Fallout.Quote());
        }
    }
    
    [TestClass]
    public class Test_Game_FinalFantasyXIV : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.FinalFantasyXIV.Character());
        }
        [TestMethod()]
        public void Test_DataCenter_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.FinalFantasyXIV.DataCenter());
        }
        [TestMethod()]
        public void Test_Job_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.FinalFantasyXIV.Job());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.FinalFantasyXIV.Race());
        }
        [TestMethod()]
        public void Test_Zone_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.FinalFantasyXIV.Zone());
        }
    }
    
    [TestClass]
    public class Test_Game_HalfLife : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HalfLife.Character());
        }
        [TestMethod()]
        public void Test_Enemy_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HalfLife.Enemy());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HalfLife.Location());
        }
    }
    
    [TestClass]
    public class Test_Game_Heroes : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Artifact_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Heroes.Artifact());
        }
        [TestMethod()]
        public void Test_Klass_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Heroes.Klass());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Heroes.Name());
        }
        [TestMethod()]
        public void Test_Specialty_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Heroes.Specialty());
        }
    }
    
    [TestClass]
    public class Test_Game_HeroesOfTheStorm : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Battleground_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HeroesOfTheStorm.Battleground());
        }
        #warning No implementation defined for method class();
        [TestMethod()]
        public void Test_ClassName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HeroesOfTheStorm.ClassName());
        }
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HeroesOfTheStorm.Hero());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.HeroesOfTheStorm.Quote());
        }
    }
    
    [TestClass]
    public class Test_Game_LeagueOfLegends : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Champion_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.Champion());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.Location());
        }
        [TestMethod()]
        public void Test_Masteries_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.Masteries());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.Quote());
        }
        [TestMethod()]
        public void Test_Rank_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.Rank());
        }
        [TestMethod()]
        public void Test_SummonerSpell_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.LeagueOfLegends.SummonerSpell());
        }
    }
    
    [TestClass]
    public class Test_Game_Minecraft : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Achievement_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Achievement());
        }
        [TestMethod()]
        public void Test_Biome_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Biome());
        }
        [TestMethod()]
        public void Test_Block_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Block());
        }
        [TestMethod()]
        public void Test_Enchantment_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Enchantment());
        }
        [TestMethod()]
        public void Test_GameMode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.GameMode());
        }
        [TestMethod()]
        public void Test_Item_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Item());
        }
        [TestMethod()]
        public void Test_Mob_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.Mob());
        }
        [TestMethod()]
        public void Test_StatusEffect_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Minecraft.StatusEffect());
        }
    }
    
    [TestClass]
    public class Test_Game_Myst : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Age_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Myst.Age());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Myst.Character());
        }
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Myst.Creature());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Myst.Game());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Myst.Quote());
        }
    }
    
    [TestClass]
    public class Test_Game_Overwatch : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Overwatch.Hero());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Overwatch.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Overwatch.Quote());
        }
    }
    
    [TestClass]
    public class Test_Game_Pokemon : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Pokemon.Location());
        }
        [TestMethod()]
        public void Test_Move_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Pokemon.Move());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Pokemon.Name());
        }
    }
    
    [TestClass]
    public class Test_Game_SonicTheHedgehog : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SonicTheHedgehog.Character());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SonicTheHedgehog.Game());
        }
        [TestMethod()]
        public void Test_Zone_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SonicTheHedgehog.Zone());
        }
    }
    
    [TestClass]
    public class Test_Game_StreetFighter : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.StreetFighter.Character());
        }
        [TestMethod()]
        public void Test_Move_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.StreetFighter.Move());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.StreetFighter.Quote());
        }
        [TestMethod()]
        public void Test_Stage_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.StreetFighter.Stage());
        }
    }
    
    [TestClass]
    public class Test_Game_SuperMario : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SuperMario.Character());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SuperMario.Game());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SuperMario.Location());
        }
    }
    
    [TestClass]
    public class Test_Game_SuperSmashBros : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Fighter_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SuperSmashBros.Fighter());
        }
        [TestMethod()]
        public void Test_Stage_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.SuperSmashBros.Stage());
        }
    }
    
    [TestClass]
    public class Test_Game_Tarkov : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Boss_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Boss());
        }
        [TestMethod()]
        public void Test_Faction_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Faction());
        }
        [TestMethod()]
        public void Test_FenceQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.FenceQuest());
        }
        [TestMethod()]
        public void Test_Item_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Item());
        }
        [TestMethod()]
        public void Test_JaegerQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.JaegerQuest());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Location());
        }
        [TestMethod()]
        public void Test_MechanicQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.MechanicQuest());
        }
        [TestMethod()]
        public void Test_PeacekeeperQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.PeacekeeperQuest());
        }
        [TestMethod()]
        public void Test_PraporQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.PraporQuest());
        }
        [TestMethod()]
        public void Test_Quest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Quest());
        }
        [TestMethod()]
        public void Test_RagmanQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.RagmanQuest());
        }
        [TestMethod()]
        public void Test_SkierQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.SkierQuest());
        }
        [TestMethod()]
        public void Test_TherapistQuest_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.TherapistQuest());
        }
        [TestMethod()]
        public void Test_Trader_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Trader());
        }
        [TestMethod()]
        public void Test_Weapon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Tarkov.Weapon());
        }
    }
    
    [TestClass]
    public class Test_Game_Touhou : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Touhou.Character());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Touhou.Game());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Touhou.Location());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Touhou.Song());
        }
        [TestMethod()]
        public void Test_SpellCard_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Touhou.SpellCard());
        }
    }
    
    [TestClass]
    public class Test_Game_WarhammerFantasy : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WarhammerFantasy.Creature());
        }
        [TestMethod()]
        public void Test_Faction_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WarhammerFantasy.Faction());
        }
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WarhammerFantasy.Hero());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WarhammerFantasy.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WarhammerFantasy.Quote());
        }
    }
    
    [TestClass]
    public class Test_Game_Witcher : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Book_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Book());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Location());
        }
        [TestMethod()]
        public void Test_Monster_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Monster());
        }
        [TestMethod()]
        public void Test_Potion_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Potion());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Quote());
        }
        [TestMethod()]
        public void Test_School_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.School());
        }
        [TestMethod()]
        public void Test_Sign_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Sign());
        }
        [TestMethod()]
        public void Test_Witcher_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Witcher.Witcher());
        }
    }
    
    [TestClass]
    public class Test_Game_WorldOfWarcraft : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_ClassName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WorldOfWarcraft.ClassName());
        }
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WorldOfWarcraft.Hero());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WorldOfWarcraft.Quote());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.WorldOfWarcraft.Race());
        }
    }
    
    [TestClass]
    public class Test_Game_Zelda : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Zelda.Character());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Zelda.Game());
        }
        [TestMethod()]
        public void Test_Item_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Zelda.Item());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Game.Zelda.Location());
        }
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
        #warning No implementation defined for method user();
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
    public class Test_Internet_HTTP : FakerNUnitBase
    {
        #warning No implementation defined for method status_code();
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
    public class Test_Internet_Twitter : FakerNUnitBase
    {
        #warning Failed processing method created_at
        #warning Failed processing method id
        #warning Failed processing method photo_entity
        #warning No implementation defined for method screen_name();
        // Method : status : Can not generated test for method with required arguments.
        #warning Failed processing method status_entities
        // Method : user : Can not generated test for method with required arguments.
        #warning Failed processing method user_entities
        #warning Failed processing method utc_offset
    }
    
    [TestClass]
    public class Test_IT : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_IT_App : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Author_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.App.Author());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.App.Name());
        }
        #warning No implementation defined for method semantic_version(IntegerRange? major = null, IntegerRange? minor = null, IntegerRange? patch = null);
        [TestMethod()]
        public void Test_Version_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.App.Version());
        }
    }
    
    [TestClass]
    public class Test_IT_Computer : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Os_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Computer.Os());
        }
        [TestMethod()]
        public void Test_Platform_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Computer.Platform());
        }
        [TestMethod()]
        public void Test_Stack_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Computer.Stack());
        }
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Computer.Type());
        }
    }
    
    [TestClass]
    public class Test_IT_Device : FakerNUnitBase
    {
        #warning No implementation defined for method build_number();
        [TestMethod()]
        public void Test_Manufacturer_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Device.Manufacturer());
        }
        [TestMethod()]
        public void Test_ModelName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Device.ModelName());
        }
        [TestMethod()]
        public void Test_Platform_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Device.Platform());
        }
        [TestMethod()]
        public void Test_Serial_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Device.Serial());
        }
        #warning No implementation defined for method version();
    }
    
    [TestClass]
    public class Test_IT_ElectricalComponents : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Active_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.ElectricalComponents.Active());
        }
        [TestMethod()]
        public void Test_Electromechanical_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.ElectricalComponents.Electromechanical());
        }
        [TestMethod()]
        public void Test_Passive_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.ElectricalComponents.Passive());
        }
    }
    
    [TestClass]
    public class Test_IT_File : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Dir_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.File.Dir());
        }
        [TestMethod()]
        public void Test_Extension_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.File.Extension());
        }
        #warning No implementation defined for method file_name(string? dir = null, string? name = null, string? ext = null, string directorySeparator = "/");
        [TestMethod()]
        public void Test_MimeType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.File.MimeType());
        }
    }
    
    [TestClass]
    public class Test_IT_ProgrammingLanguage : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Creator_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.ProgrammingLanguage.Creator());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.ProgrammingLanguage.Name());
        }
    }
    
    [TestClass]
    public class Test_IT_SlackEmoji : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Activity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.Activity());
        }
        [TestMethod()]
        public void Test_Celebration_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.Celebration());
        }
        [TestMethod()]
        public void Test_Custom_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.Custom());
        }
        [TestMethod()]
        public void Test_Emoji_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.Emoji());
        }
        [TestMethod()]
        public void Test_FoodAndDrink_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.FoodAndDrink());
        }
        [TestMethod()]
        public void Test_Nature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.Nature());
        }
        [TestMethod()]
        public void Test_ObjectsAndSymbols_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.ObjectsAndSymbols());
        }
        [TestMethod()]
        public void Test_People_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.People());
        }
        [TestMethod()]
        public void Test_TravelAndPlaces_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.SlackEmoji.TravelAndPlaces());
        }
    }
    
    [TestClass]
    public class Test_IT_Source : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_HelloWorld_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Source.HelloWorld());
        }
        // Method : print : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Print1To10_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.IT.Source.Print1To10());
        }
    }
    
    [TestClass]
    public class Test_IT_VulnerabilityIdentifier : FakerNUnitBase
    {
        #warning No implementation defined for method cve(long year = ::Date.today.year);
    }
    
    [TestClass]
    public class Test_JapaneseMedia : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_JapaneseMedia_Conan : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Conan.Character());
        }
        [TestMethod()]
        public void Test_Gadget_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Conan.Gadget());
        }
        [TestMethod()]
        public void Test_Vehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Conan.Vehicle());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_CowboyBebop : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.CowboyBebop.Character());
        }
        [TestMethod()]
        public void Test_Episode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.CowboyBebop.Episode());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.CowboyBebop.Quote());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.CowboyBebop.Song());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_Doraemon : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Doraemon.Character());
        }
        [TestMethod()]
        public void Test_Gadget_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Doraemon.Gadget());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Doraemon.Location());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_DragonBall : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.DragonBall.Character());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.DragonBall.Planet());
        }
        [TestMethod()]
        public void Test_Race_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.DragonBall.Race());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_FmaBrotherhood : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.FmaBrotherhood.Character());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.FmaBrotherhood.City());
        }
        [TestMethod()]
        public void Test_Country_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.FmaBrotherhood.Country());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_KamenRider : FakerNUnitBase
    {
        #warning No implementation defined for method collectible_device();
        #warning No implementation defined for method eras();
        #warning No implementation defined for method eras=();
        [TestMethod()]
        public void Test_FromEras_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.KamenRider.FromEras());
        }
        #warning No implementation defined for method kamen_rider();
        #warning No implementation defined for method series();
        #warning No implementation defined for method transformation_device();
        #warning No implementation defined for method user();
    }
    
    [TestClass]
    public class Test_JapaneseMedia_Naruto : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Naruto.Character());
        }
        [TestMethod()]
        public void Test_Demon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Naruto.Demon());
        }
        [TestMethod()]
        public void Test_Eye_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Naruto.Eye());
        }
        [TestMethod()]
        public void Test_Village_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.Naruto.Village());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_OnePiece : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AkumaNoMi_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.AkumaNoMi());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.Character());
        }
        [TestMethod()]
        public void Test_Island_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.Island());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.Quote());
        }
        [TestMethod()]
        public void Test_Sea_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.OnePiece.Sea());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_StudioGhibli : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.StudioGhibli.Character());
        }
        [TestMethod()]
        public void Test_Movie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.StudioGhibli.Movie());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.StudioGhibli.Quote());
        }
    }
    
    [TestClass]
    public class Test_JapaneseMedia_SwordArtOnline : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_GameName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.SwordArtOnline.GameName());
        }
        [TestMethod()]
        public void Test_Item_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.SwordArtOnline.Item());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.SwordArtOnline.Location());
        }
        [TestMethod()]
        public void Test_RealName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.JapaneseMedia.SwordArtOnline.RealName());
        }
    }
    
    [TestClass]
    public class Test_Location : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Location_Compass : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Abbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.Abbreviation());
        }
        [TestMethod()]
        public void Test_Azimuth_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.Azimuth());
        }
        [TestMethod()]
        public void Test_Cardinal_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.Cardinal());
        }
        [TestMethod()]
        public void Test_CardinalAbbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.CardinalAbbreviation());
        }
        [TestMethod()]
        public void Test_CardinalAzimuth_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.CardinalAzimuth());
        }
        [TestMethod()]
        public void Test_Direction_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.Direction());
        }
        [TestMethod()]
        public void Test_HalfWind_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.HalfWind());
        }
        [TestMethod()]
        public void Test_HalfWindAbbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.HalfWindAbbreviation());
        }
        [TestMethod()]
        public void Test_HalfWindAzimuth_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.HalfWindAzimuth());
        }
        [TestMethod()]
        public void Test_Ordinal_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.Ordinal());
        }
        [TestMethod()]
        public void Test_OrdinalAbbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.OrdinalAbbreviation());
        }
        [TestMethod()]
        public void Test_OrdinalAzimuth_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.OrdinalAzimuth());
        }
        [TestMethod()]
        public void Test_QuarterWind_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.QuarterWind());
        }
        [TestMethod()]
        public void Test_QuarterWindAbbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.QuarterWindAbbreviation());
        }
        [TestMethod()]
        public void Test_QuarterWindAzimuth_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Location.Compass.QuarterWindAzimuth());
        }
    }
    
    [TestClass]
    public class Test_LoremFlickr : FakerNUnitBase
    {
        #warning Failed processing method build_url
        // Method : colorized_image : Can not generated test for method with required arguments.
        // Method : grayscale_image : Can not generated test for method with required arguments.
        // Method : image : Can not generated test for method with required arguments.
        // Method : pixelated_image : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Medicine : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Medicine_Cannabis : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Brand_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Brand());
        }
        [TestMethod()]
        public void Test_Buzzword_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Buzzword());
        }
        [TestMethod()]
        public void Test_Cannabinoid_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Cannabinoid());
        }
        [TestMethod()]
        public void Test_CannabinoidAbbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.CannabinoidAbbreviation());
        }
        [TestMethod()]
        public void Test_Category_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Category());
        }
        [TestMethod()]
        public void Test_HealthBenefit_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.HealthBenefit());
        }
        [TestMethod()]
        public void Test_MedicalUse_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.MedicalUse());
        }
        [TestMethod()]
        public void Test_Strain_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Strain());
        }
        [TestMethod()]
        public void Test_Terpene_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Terpene());
        }
        [TestMethod()]
        public void Test_Type_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Medicine.Cannabis.Type());
        }
    }
    
    [TestClass]
    public class Test_Medicine_NationalHealthService : FakerNUnitBase
    {
        #warning No implementation defined for method british_number();
        #warning No implementation defined for method check_digit(long number = 0);
    }
    
    [TestClass]
    public class Test_Movie : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Quote());
        }
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Title());
        }
    }
    
    [TestClass]
    public class Test_Movie_Avatar : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Avatar.Character());
        }
        [TestMethod()]
        public void Test_Date_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Avatar.Date());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Avatar.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_BackToTheFuture : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.BackToTheFuture.Character());
        }
        [TestMethod()]
        public void Test_Date_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.BackToTheFuture.Date());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.BackToTheFuture.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_BossaNova : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Artist_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.BossaNova.Artist());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.BossaNova.Song());
        }
    }
    
    [TestClass]
    public class Test_Movie_Departed : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Departed.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Departed.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Departed.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_Ghostbusters : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Ghostbusters.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Ghostbusters.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Ghostbusters.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_Hackers : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hackers.Character());
        }
        [TestMethod()]
        public void Test_Handle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hackers.Handle());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hackers.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_HarryPotter : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Book_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.Book());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.Character());
        }
        [TestMethod()]
        public void Test_House_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.House());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.Quote());
        }
        [TestMethod()]
        public void Test_Spell_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HarryPotter.Spell());
        }
    }
    
    [TestClass]
    public class Test_Movie_HitchhikersGuideToTheGalaxy : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Location());
        }
        [TestMethod()]
        public void Test_MarvinQuote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.MarvinQuote());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Planet());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Quote());
        }
        [TestMethod()]
        public void Test_Specie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Specie());
        }
        [TestMethod()]
        public void Test_Starship_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HitchhikersGuideToTheGalaxy.Starship());
        }
    }
    
    [TestClass]
    public class Test_Movie_Hobbit : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hobbit.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hobbit.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hobbit.Quote());
        }
        [TestMethod()]
        public void Test_ThorinsCompany_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Hobbit.ThorinsCompany());
        }
    }
    
    [TestClass]
    public class Test_Movie_HowToTrainYourDragon : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HowToTrainYourDragon.Character());
        }
        [TestMethod()]
        public void Test_Dragon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HowToTrainYourDragon.Dragon());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.HowToTrainYourDragon.Location());
        }
    }
    
    [TestClass]
    public class Test_Movie_Lebowski : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Lebowski.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Lebowski.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Lebowski.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_LordOfTheRings : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.LordOfTheRings.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.LordOfTheRings.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.LordOfTheRings.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_PrincessBride : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.PrincessBride.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.PrincessBride.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_Show : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AdultMusical_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Show.AdultMusical());
        }
        [TestMethod()]
        public void Test_KidsMusical_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Show.KidsMusical());
        }
        [TestMethod()]
        public void Test_Play_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Show.Play());
        }
    }
    
    [TestClass]
    public class Test_Movie_StarWars : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CallNumber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.CallNumber());
        }
        [TestMethod()]
        public void Test_CallSign_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.CallSign());
        }
        [TestMethod()]
        public void Test_CallSquadron_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.CallSquadron());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.Character());
        }
        [TestMethod()]
        public void Test_Droid_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.Droid());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.Planet());
        }
        #warning No implementation defined for method quote(string? character = null);
        [TestMethod()]
        public void Test_Specie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.Specie());
        }
        [TestMethod()]
        public void Test_Vehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.Vehicle());
        }
        [TestMethod()]
        public void Test_WookieeSentence_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.WookieeSentence());
        }
        [TestMethod()]
        public void Test_WookieeWord_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.StarWars.WookieeWord());
        }
    }
    
    [TestClass]
    public class Test_Movie_TheRoom : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.TheRoom.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.TheRoom.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.TheRoom.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.TheRoom.Quote());
        }
    }
    
    [TestClass]
    public class Test_Movie_Tron : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Character());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Game());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Location());
        }
        [TestMethod()]
        public void Test_Program_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Program());
        }
        #warning No implementation defined for method quote(string? character = null);
        [TestMethod()]
        public void Test_Tagline_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Tagline());
        }
        [TestMethod()]
        public void Test_User_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.User());
        }
        [TestMethod()]
        public void Test_Vehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.Tron.Vehicle());
        }
    }
    
    [TestClass]
    public class Test_Movie_VForVendetta : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.VForVendetta.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.VForVendetta.Quote());
        }
        [TestMethod()]
        public void Test_Speech_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Movie.VForVendetta.Speech());
        }
    }
    
    [TestClass]
    public class Test_Music : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Album());
        }
        [TestMethod()]
        public void Test_Band_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Band());
        }
        #warning No implementation defined for method chord();
        #warning No implementation defined for method chord_types();
        [TestMethod()]
        public void Test_Genre_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Genre());
        }
        [TestMethod()]
        public void Test_Instrument_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Instrument());
        }
        #warning No implementation defined for method key();
        #warning No implementation defined for method key_types();
        #warning No implementation defined for method key_variants();
        #warning No implementation defined for method keys();
        [TestMethod()]
        public void Test_MamboNo5_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.MamboNo5());
        }
    }
    
    [TestClass]
    public class Test_Music_GratefulDead : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.GratefulDead.Player());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.GratefulDead.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_Hiphop : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Artist_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Hiphop.Artist());
        }
        [TestMethod()]
        public void Test_Groups_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Hiphop.Groups());
        }
        [TestMethod()]
        public void Test_Subgenres_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Hiphop.Subgenres());
        }
    }
    
    [TestClass]
    public class Test_Music_Kpop : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_BoyBands_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.BoyBands());
        }
        [TestMethod()]
        public void Test_GirlGroups_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.GirlGroups());
        }
        [TestMethod()]
        public void Test_IGroups_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.IGroups());
        }
        [TestMethod()]
        public void Test_IiGroups_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.IiGroups());
        }
        [TestMethod()]
        public void Test_IiiGroups_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.IiiGroups());
        }
        [TestMethod()]
        public void Test_Solo_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Kpop.Solo());
        }
    }
    
    [TestClass]
    public class Test_Music_Opera : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Beethoven_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Beethoven());
        }
        [TestMethod()]
        public void Test_Bellini_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Bellini());
        }
        [TestMethod()]
        public void Test_Berg_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Berg());
        }
        [TestMethod()]
        public void Test_Berlioz_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Berlioz());
        }
        [TestMethod()]
        public void Test_Bizet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Bizet());
        }
        [TestMethod()]
        public void Test_Donizetti_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Donizetti());
        }
        [TestMethod()]
        public void Test_Gluck_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Gluck());
        }
        [TestMethod()]
        public void Test_GluckFrench_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.GluckFrench());
        }
        [TestMethod()]
        public void Test_GluckItalian_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.GluckItalian());
        }
        [TestMethod()]
        public void Test_Gounod_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Gounod());
        }
        [TestMethod()]
        public void Test_Mozart_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Mozart());
        }
        [TestMethod()]
        public void Test_MozartGerman_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.MozartGerman());
        }
        [TestMethod()]
        public void Test_MozartItalian_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.MozartItalian());
        }
        [TestMethod()]
        public void Test_Ravel_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Ravel());
        }
        [TestMethod()]
        public void Test_Rossini_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Rossini());
        }
        [TestMethod()]
        public void Test_SaintSaens_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.SaintSaens());
        }
        [TestMethod()]
        public void Test_Schubert_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Schubert());
        }
        [TestMethod()]
        public void Test_Schumann_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Schumann());
        }
        [TestMethod()]
        public void Test_Strauss_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Strauss());
        }
        [TestMethod()]
        public void Test_Verdi_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Verdi());
        }
        [TestMethod()]
        public void Test_Wagner_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Wagner());
        }
        [TestMethod()]
        public void Test_Weber_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Opera.Weber());
        }
    }
    
    [TestClass]
    public class Test_Music_PearlJam : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.PearlJam.Album());
        }
        [TestMethod()]
        public void Test_Musician_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.PearlJam.Musician());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.PearlJam.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_Phish : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Phish.Album());
        }
        [TestMethod()]
        public void Test_Musician_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Phish.Musician());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Phish.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_Prince : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Prince.Album());
        }
        [TestMethod()]
        public void Test_Band_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Prince.Band());
        }
        [TestMethod()]
        public void Test_Lyric_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Prince.Lyric());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Prince.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_RockBand : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.RockBand.Name());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.RockBand.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_Rush : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Rush.Album());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.Rush.Player());
        }
    }
    
    [TestClass]
    public class Test_Music_SmashingPumpkins : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Album_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.SmashingPumpkins.Album());
        }
        [TestMethod()]
        public void Test_Lyric_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.SmashingPumpkins.Lyric());
        }
        [TestMethod()]
        public void Test_Musician_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.SmashingPumpkins.Musician());
        }
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.SmashingPumpkins.Song());
        }
    }
    
    [TestClass]
    public class Test_Music_UmphreysMcgee : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Song_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Music.UmphreysMcgee.Song());
        }
    }
    
    [TestClass]
    public class Test_Omniauth : FakerNUnitBase
    {
        // Method : apple : Can not generated test for method with required arguments.
        // Method : auth0 : Can not generated test for method with required arguments.
        #warning Failed processing method city_state
        #warning Failed processing method email
        // Method : facebook : Can not generated test for method with required arguments.
        #warning Failed processing method first_name
        #warning Failed processing method gender
        // Method : github : Can not generated test for method with required arguments.
        // Method : google : Can not generated test for method with required arguments.
        #warning Failed processing method image
        #warning No implementation defined for method initialize();
        #warning Failed processing method last_name
        // Method : linkedin : Can not generated test for method with required arguments.
        #warning Failed processing method name
        #warning Failed processing method random_boolean
        #warning Failed processing method random_number_from_range
        #warning Failed processing method timezone
        // Method : twitter : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_People : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_People_Ancient : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_God_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Ancient.God());
        }
        [TestMethod()]
        public void Test_Hero_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Ancient.Hero());
        }
        [TestMethod()]
        public void Test_Primordial_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Ancient.Primordial());
        }
        [TestMethod()]
        public void Test_Titan_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Ancient.Titan());
        }
    }
    
    [TestClass]
    public class Test_People_Artist : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Artist.Name());
        }
    }
    
    [TestClass]
    public class Test_People_FunnyName : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_FourWordName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.FunnyName.FourWordName());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.FunnyName.Name());
        }
        [TestMethod()]
        public void Test_NameWithInitial_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.FunnyName.NameWithInitial());
        }
        [TestMethod()]
        public void Test_ThreeWordName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.FunnyName.ThreeWordName());
        }
        [TestMethod()]
        public void Test_TwoWordName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.FunnyName.TwoWordName());
        }
    }
    
    [TestClass]
    public class Test_People_GreekPhilosophers : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.GreekPhilosophers.Name());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.GreekPhilosophers.Quote());
        }
    }
    
    [TestClass]
    public class Test_People_Superhero : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Descriptor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Superhero.Descriptor());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Superhero.Name());
        }
        [TestMethod()]
        public void Test_Power_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Superhero.Power());
        }
        [TestMethod()]
        public void Test_Prefix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Superhero.Prefix());
        }
        [TestMethod()]
        public void Test_Suffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.People.Superhero.Suffix());
        }
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
        public void Test_State_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Person.Address.State());
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
    
    [TestClass]
    public class Test_Place : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Place_Australia : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Animal_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Australia.Animal());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Australia.Location());
        }
        [TestMethod()]
        public void Test_State_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Australia.State());
        }
    }
    
    [TestClass]
    public class Test_Place_Dessert : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Flavor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Dessert.Flavor());
        }
        [TestMethod()]
        public void Test_Topping_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Dessert.Topping());
        }
        [TestMethod()]
        public void Test_Variety_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Dessert.Variety());
        }
    }
    
    [TestClass]
    public class Test_Place_Mountain : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Mountain.Name());
        }
        [TestMethod()]
        public void Test_Range_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Mountain.Range());
        }
    }
    
    [TestClass]
    public class Test_Place_Nation : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CapitalCity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Nation.CapitalCity());
        }
        #warning No implementation defined for method flag();
        [TestMethod()]
        public void Test_Language_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Nation.Language());
        }
        [TestMethod()]
        public void Test_NationalSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Nation.NationalSport());
        }
        [TestMethod()]
        public void Test_Nationality_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Nation.Nationality());
        }
    }
    
    [TestClass]
    public class Test_Place_SouthAfrica : FakerNUnitBase
    {
        #warning No implementation defined for method cell_phone();
        #warning No implementation defined for method close_corporation_registration_number();
        #warning No implementation defined for method id_number();
        #warning No implementation defined for method invalid_id_number();
        #warning No implementation defined for method listed_company_registration_number();
        #warning No implementation defined for method phone_number();
        #warning No implementation defined for method pty_ltd_registration_number();
        #warning No implementation defined for method trust_registration_number();
        #warning No implementation defined for method valid_id_number();
        #warning No implementation defined for method vat_number();
    }
    
    [TestClass]
    public class Test_Place_Space : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Agency_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Agency());
        }
        [TestMethod()]
        public void Test_AgencyAbv_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.AgencyAbv());
        }
        [TestMethod()]
        public void Test_Company_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Company());
        }
        [TestMethod()]
        public void Test_Constellation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Constellation());
        }
        [TestMethod()]
        public void Test_DistanceMeasurement_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.DistanceMeasurement());
        }
        [TestMethod()]
        public void Test_Galaxy_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Galaxy());
        }
        [TestMethod()]
        public void Test_LaunchVehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.LaunchVehicle());
        }
        [TestMethod()]
        public void Test_Meteorite_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Meteorite());
        }
        [TestMethod()]
        public void Test_Moon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Moon());
        }
        [TestMethod()]
        public void Test_NasaSpaceCraft_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.NasaSpaceCraft());
        }
        [TestMethod()]
        public void Test_Nebula_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Nebula());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Planet());
        }
        [TestMethod()]
        public void Test_Star_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.Star());
        }
        [TestMethod()]
        public void Test_StarCluster_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.Space.StarCluster());
        }
    }
    
    [TestClass]
    public class Test_Place_University : FakerNUnitBase
    {
        #warning No implementation defined for method greek_alphabet();
        #warning No implementation defined for method greek_organization();
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.University.Name());
        }
        [TestMethod()]
        public void Test_Prefix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.University.Prefix());
        }
        [TestMethod()]
        public void Test_Suffix_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Place.University.Suffix());
        }
    }
    
    [TestClass]
    public class Test_Placeholdit : FakerNUnitBase
    {
        #warning Failed processing method generate_color
        // Method : image : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Quote : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_FamousLastWords_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.FamousLastWords());
        }
        [TestMethod()]
        public void Test_FortuneCookie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.FortuneCookie());
        }
        [TestMethod()]
        public void Test_JackHandey_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.JackHandey());
        }
        [TestMethod()]
        public void Test_Matz_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Matz());
        }
        [TestMethod()]
        public void Test_MitchHedberg_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.MitchHedberg());
        }
        [TestMethod()]
        public void Test_MostInterestingManInTheWorld_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.MostInterestingManInTheWorld());
        }
        [TestMethod()]
        public void Test_Robin_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Robin());
        }
        [TestMethod()]
        public void Test_SingularSiegler_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.SingularSiegler());
        }
        [TestMethod()]
        public void Test_Yoda_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Yoda());
        }
    }
    
    [TestClass]
    public class Test_Quote_Chiquito : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Expression_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Expression());
        }
        [TestMethod()]
        public void Test_Joke_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Joke());
        }
        [TestMethod()]
        public void Test_Jokes_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Jokes());
        }
        [TestMethod()]
        public void Test_Sentence_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Sentence());
        }
        [TestMethod()]
        public void Test_Sentences_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Sentences());
        }
        [TestMethod()]
        public void Test_Term_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Term());
        }
        [TestMethod()]
        public void Test_Terms_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Chiquito.Terms());
        }
    }
    
    [TestClass]
    public class Test_Quote_ChuckNorris : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Fact_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.ChuckNorris.Fact());
        }
    }
    
    [TestClass]
    public class Test_Quote_Rajnikanth : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Joke_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Rajnikanth.Joke());
        }
    }
    
    [TestClass]
    public class Test_Quote_Shakespeare : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AsYouLikeIt_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.AsYouLikeIt());
        }
        [TestMethod()]
        public void Test_AsYouLikeItQuote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.AsYouLikeItQuote());
        }
        [TestMethod()]
        public void Test_Hamlet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.Hamlet());
        }
        [TestMethod()]
        public void Test_HamletQuote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.HamletQuote());
        }
        [TestMethod()]
        public void Test_KingRichardIii_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.KingRichardIii());
        }
        [TestMethod()]
        public void Test_KingRichardIiiQuote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.KingRichardIiiQuote());
        }
        [TestMethod()]
        public void Test_RomeoAndJuliet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.RomeoAndJuliet());
        }
        [TestMethod()]
        public void Test_RomeoAndJulietQuote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Quote.Shakespeare.RomeoAndJulietQuote());
        }
    }
    
    [TestClass]
    public class Test_Science : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Element_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.Element());
        }
        [TestMethod()]
        public void Test_ElementState_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.ElementState());
        }
        [TestMethod()]
        public void Test_ElementSubcategory_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.ElementSubcategory());
        }
        [TestMethod()]
        public void Test_ElementSymbol_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.ElementSymbol());
        }
        [TestMethod()]
        public void Test_Modifier_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.Modifier());
        }
        // Method : science : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Scientist_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.Scientist());
        }
        [TestMethod()]
        public void Test_Tool_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Science.Tool());
        }
    }
    
    [TestClass]
    public class Test_Sport : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_AncientOlympicsSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.AncientOlympicsSport());
        }
        // Method : sport : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_SummerOlympicsSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.SummerOlympicsSport());
        }
        [TestMethod()]
        public void Test_SummerParalympicsSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.SummerParalympicsSport());
        }
        [TestMethod()]
        public void Test_UnusualSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.UnusualSport());
        }
        [TestMethod()]
        public void Test_WinterOlympicsSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WinterOlympicsSport());
        }
        [TestMethod()]
        public void Test_WinterParalympicsSport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WinterParalympicsSport());
        }
    }
    
    [TestClass]
    public class Test_Sport_Basketball : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Coach_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Basketball.Coach());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Basketball.Player());
        }
        [TestMethod()]
        public void Test_Position_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Basketball.Position());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Basketball.Team());
        }
    }
    
    [TestClass]
    public class Test_Sport_Chess : FakerNUnitBase
    {
        #warning No implementation defined for method federation();
        [TestMethod()]
        public void Test_Opening_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Chess.Opening());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Chess.Player());
        }
        #warning No implementation defined for method rating();
        [TestMethod()]
        public void Test_Title_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Chess.Title());
        }
        [TestMethod()]
        public void Test_Tournament_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Chess.Tournament());
        }
    }
    
    [TestClass]
    public class Test_Sport_Esport : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Event_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Esport.Event());
        }
        [TestMethod()]
        public void Test_Game_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Esport.Game());
        }
        [TestMethod()]
        public void Test_League_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Esport.League());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Esport.Player());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Esport.Team());
        }
    }
    
    [TestClass]
    public class Test_Sport_Football : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Coach_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Football.Coach());
        }
        [TestMethod()]
        public void Test_Competition_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Football.Competition());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Football.Player());
        }
        [TestMethod()]
        public void Test_Position_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Football.Position());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Football.Team());
        }
    }
    
    [TestClass]
    public class Test_Sport_Mountaineering : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Mountaineer_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Mountaineering.Mountaineer());
        }
    }
    
    [TestClass]
    public class Test_Sport_Team : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Team.Creature());
        }
        [TestMethod()]
        public void Test_Mascot_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Team.Mascot());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Team.Name());
        }
        [TestMethod()]
        public void Test_Sport_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Team.Sport());
        }
        [TestMethod()]
        public void Test_State_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Team.State());
        }
    }
    
    [TestClass]
    public class Test_Sport_Volleyball : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Coach_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Volleyball.Coach());
        }
        [TestMethod()]
        public void Test_Formation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Volleyball.Formation());
        }
        [TestMethod()]
        public void Test_Player_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Volleyball.Player());
        }
        [TestMethod()]
        public void Test_Position_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Volleyball.Position());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.Volleyball.Team());
        }
    }
    
    [TestClass]
    public class Test_Sport_WorldCup : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WorldCup.City());
        }
        [TestMethod()]
        public void Test_Group_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WorldCup.Group());
        }
        [TestMethod()]
        public void Test_Roster_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WorldCup.Roster());
        }
        [TestMethod()]
        public void Test_Stadium_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WorldCup.Stadium());
        }
        [TestMethod()]
        public void Test_Team_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Sport.WorldCup.Team());
        }
    }
    
    [TestClass]
    public class Test_Things : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Things_Camera : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Brand_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Camera.Brand());
        }
        [TestMethod()]
        public void Test_BrandWithModel_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Camera.BrandWithModel());
        }
        [TestMethod()]
        public void Test_Model_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Camera.Model());
        }
    }
    
    [TestClass]
    public class Test_Things_Drone : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_BatteryCapacity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.BatteryCapacity());
        }
        [TestMethod()]
        public void Test_BatteryType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.BatteryType());
        }
        [TestMethod()]
        public void Test_BatteryVoltage_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.BatteryVoltage());
        }
        [TestMethod()]
        public void Test_BatteryWeight_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.BatteryWeight());
        }
        [TestMethod()]
        public void Test_ChargingTemperature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.ChargingTemperature());
        }
        [TestMethod()]
        public void Test_FlightTime_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.FlightTime());
        }
        [TestMethod()]
        public void Test_Iso_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.Iso());
        }
        [TestMethod()]
        public void Test_MaxAltitude_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxAltitude());
        }
        [TestMethod()]
        public void Test_MaxAngularVelocity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxAngularVelocity());
        }
        [TestMethod()]
        public void Test_MaxAscentSpeed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxAscentSpeed());
        }
        [TestMethod()]
        public void Test_MaxChargingPower_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxChargingPower());
        }
        [TestMethod()]
        public void Test_MaxDescentSpeed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxDescentSpeed());
        }
        [TestMethod()]
        public void Test_MaxFlightDistance_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxFlightDistance());
        }
        [TestMethod()]
        public void Test_MaxResolution_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxResolution());
        }
        [TestMethod()]
        public void Test_MaxShutterSpeed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxShutterSpeed());
        }
        [TestMethod()]
        public void Test_MaxSpeed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxSpeed());
        }
        [TestMethod()]
        public void Test_MaxTiltAngle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxTiltAngle());
        }
        [TestMethod()]
        public void Test_MaxWindResistance_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MaxWindResistance());
        }
        [TestMethod()]
        public void Test_MinShutterSpeed_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.MinShutterSpeed());
        }
        [TestMethod()]
        public void Test_Name_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.Name());
        }
        [TestMethod()]
        public void Test_OperatingTemperature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.OperatingTemperature());
        }
        [TestMethod()]
        public void Test_PhotoFormat_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.PhotoFormat());
        }
        [TestMethod()]
        public void Test_ShutterSpeedRange_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.ShutterSpeedRange());
        }
        [TestMethod()]
        public void Test_VideoFormat_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.VideoFormat());
        }
        [TestMethod()]
        public void Test_Weight_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Drone.Weight());
        }
    }
    
    [TestClass]
    public class Test_Things_Hobby : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Activity_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Hobby.Activity());
        }
    }
    
    [TestClass]
    public class Test_Things_House : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Furniture_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.House.Furniture());
        }
        [TestMethod()]
        public void Test_Room_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.House.Room());
        }
    }
    
    [TestClass]
    public class Test_Things_Vehicle : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CarOptions_Execute()
        {
            FakerForEveryLocale<List<string>>(faker => faker.Things.Vehicle.CarOptions());
        }
        [TestMethod()]
        public void Test_CarType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.CarType());
        }
        [TestMethod()]
        public void Test_Color_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Color());
        }
        [TestMethod()]
        public void Test_Doors_Execute()
        {
            FakerForEveryLocale<long>(faker => faker.Things.Vehicle.Doors());
        }
        [TestMethod()]
        public void Test_DriveType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.DriveType());
        }
        [TestMethod()]
        public void Test_Engine_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Engine());
        }
        [TestMethod()]
        public void Test_FuelType_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.FuelType());
        }
        [TestMethod()]
        public void Test_LicensePlate_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.LicensePlate());
        }
        [TestMethod()]
        public void Test_Make_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Make());
        }
        #warning No implementation defined for method make_and_model();
        [TestMethod()]
        public void Test_Manufacture_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Manufacture());
        }
        // Method : mileage : Can not generated test for method with required arguments.
        [TestMethod()]
        public void Test_Model_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Model());
        }
        #warning Failed processing method singapore_checksum
        #warning No implementation defined for method singapore_license_plate();
        [TestMethod()]
        public void Test_StandardSpecs_Execute()
        {
            FakerForEveryLocale<List<string>>(faker => faker.Things.Vehicle.StandardSpecs());
        }
        [TestMethod()]
        public void Test_Style_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Style());
        }
        [TestMethod()]
        public void Test_Transmission_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Transmission());
        }
        [TestMethod()]
        public void Test_Version_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Things.Vehicle.Version());
        }
        #warning No implementation defined for method vin();
        #warning No implementation defined for method year();
    }
    
    [TestClass]
    public class Test_Travel : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Travel_Airport : FakerNUnitBase
    {
        // Method : iata : Can not generated test for method with required arguments.
        // Method : name : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Travel_TrainStation : FakerNUnitBase
    {
        #warning No implementation defined for method fill_missing_inputs_with_samples();
        // Method : name : Can not generated test for method with required arguments.
        #warning No implementation defined for method validate_arguments();
    }
    
    [TestClass]
    public class Test_TvShows : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_TvShows_AquaTeenHungerForce : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.AquaTeenHungerForce.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.AquaTeenHungerForce.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Archer : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Archer.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Archer.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Archer.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_BigBangTheory : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BigBangTheory.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BigBangTheory.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_BojackHorseman : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BojackHorseman.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BojackHorseman.Quote());
        }
        [TestMethod()]
        public void Test_TongueTwister_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BojackHorseman.TongueTwister());
        }
    }
    
    [TestClass]
    public class Test_TvShows_BreakingBad : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BreakingBad.Character());
        }
        [TestMethod()]
        public void Test_Episode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BreakingBad.Episode());
        }
    }
    
    [TestClass]
    public class Test_TvShows_BrooklynNineNine : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BrooklynNineNine.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.BrooklynNineNine.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Buffy : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Buffy.Actor());
        }
        [TestMethod()]
        public void Test_BigBad_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Buffy.BigBad());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Buffy.Character());
        }
        [TestMethod()]
        public void Test_Episode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Buffy.Episode());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Buffy.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Community : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Characters_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Community.Characters());
        }
        [TestMethod()]
        public void Test_Quotes_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Community.Quotes());
        }
    }
    
    [TestClass]
    public class Test_TvShows_DrWho : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.Actor());
        }
        [TestMethod()]
        public void Test_CatchPhrase_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.CatchPhrase());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.Quote());
        }
        [TestMethod()]
        public void Test_Specie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.Specie());
        }
        [TestMethod()]
        public void Test_TheDoctor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.TheDoctor());
        }
        [TestMethod()]
        public void Test_Villain_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DrWho.Villain());
        }
    }
    
    [TestClass]
    public class Test_TvShows_DumbAndDumber : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DumbAndDumber.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DumbAndDumber.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.DumbAndDumber.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_FamilyGuy : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FamilyGuy.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FamilyGuy.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FamilyGuy.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_FinalSpace : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FinalSpace.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FinalSpace.Quote());
        }
        [TestMethod()]
        public void Test_Vehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.FinalSpace.Vehicle());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Friends : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Friends.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Friends.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Friends.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Futurama : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Futurama.Character());
        }
        [TestMethod()]
        public void Test_HermesCatchphrase_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Futurama.HermesCatchphrase());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Futurama.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Futurama.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_GameOfThrones : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.GameOfThrones.Character());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.GameOfThrones.City());
        }
        [TestMethod()]
        public void Test_Dragon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.GameOfThrones.Dragon());
        }
        [TestMethod()]
        public void Test_House_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.GameOfThrones.House());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.GameOfThrones.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_HeyArnold : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HeyArnold.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HeyArnold.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HeyArnold.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_HowIMetYourMother : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_CatchPhrase_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HowIMetYourMother.CatchPhrase());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HowIMetYourMother.Character());
        }
        [TestMethod()]
        public void Test_HighFive_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HowIMetYourMother.HighFive());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.HowIMetYourMother.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_MichaelScott : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.MichaelScott.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_NewGirl : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.NewGirl.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.NewGirl.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_ParksAndRec : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.ParksAndRec.Character());
        }
        [TestMethod()]
        public void Test_City_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.ParksAndRec.City());
        }
    }
    
    [TestClass]
    public class Test_TvShows_RickAndMorty : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.RickAndMorty.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.RickAndMorty.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.RickAndMorty.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_RuPaul : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Queen_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.RuPaul.Queen());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.RuPaul.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Seinfeld : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Business_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Seinfeld.Business());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Seinfeld.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Seinfeld.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_SiliconValley : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_App_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.App());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Character());
        }
        [TestMethod()]
        public void Test_Company_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Company());
        }
        [TestMethod()]
        public void Test_Email_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Email());
        }
        [TestMethod()]
        public void Test_Invention_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Invention());
        }
        [TestMethod()]
        public void Test_Motto_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Motto());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Quote());
        }
        [TestMethod()]
        public void Test_Url_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SiliconValley.Url());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Simpsons : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Simpsons.Character());
        }
        [TestMethod()]
        public void Test_EpisodeTitle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Simpsons.EpisodeTitle());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Simpsons.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Simpsons.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_SouthPark : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SouthPark.Character());
        }
        [TestMethod()]
        public void Test_EpisodeName_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SouthPark.EpisodeName());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.SouthPark.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Spongebob : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Spongebob.Character());
        }
        [TestMethod()]
        public void Test_Episode_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Spongebob.Episode());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Spongebob.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Stargate : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Stargate.Character());
        }
        [TestMethod()]
        public void Test_Planet_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Stargate.Planet());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Stargate.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_StarTrek : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StarTrek.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StarTrek.Location());
        }
        [TestMethod()]
        public void Test_Specie_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StarTrek.Specie());
        }
        [TestMethod()]
        public void Test_Villain_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StarTrek.Villain());
        }
    }
    
    [TestClass]
    public class Test_TvShows_StrangerThings : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StrangerThings.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.StrangerThings.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Suits : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Suits.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Suits.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_Supernatural : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Supernatural.Character());
        }
        [TestMethod()]
        public void Test_Creature_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Supernatural.Creature());
        }
        [TestMethod()]
        public void Test_Weapon_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.Supernatural.Weapon());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TheExpanse : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheExpanse.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheExpanse.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheExpanse.Quote());
        }
        [TestMethod()]
        public void Test_Ship_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheExpanse.Ship());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TheFreshPrinceOfBelAir : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheFreshPrinceOfBelAir.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheFreshPrinceOfBelAir.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheFreshPrinceOfBelAir.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TheITCrowd : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Actor_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheITCrowd.Actor());
        }
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheITCrowd.Character());
        }
        [TestMethod()]
        public void Test_Email_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheITCrowd.Email());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheITCrowd.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TheOffice : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheOffice.Character());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheOffice.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TheThickOfIt : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheThickOfIt.Character());
        }
        [TestMethod()]
        public void Test_Department_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheThickOfIt.Department());
        }
        [TestMethod()]
        public void Test_Position_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TheThickOfIt.Position());
        }
    }
    
    [TestClass]
    public class Test_TvShows_TwinPeaks : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TwinPeaks.Character());
        }
        [TestMethod()]
        public void Test_Location_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TwinPeaks.Location());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.TwinPeaks.Quote());
        }
    }
    
    [TestClass]
    public class Test_TvShows_VentureBros : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Character_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.VentureBros.Character());
        }
        [TestMethod()]
        public void Test_Organization_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.VentureBros.Organization());
        }
        [TestMethod()]
        public void Test_Quote_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.VentureBros.Quote());
        }
        [TestMethod()]
        public void Test_Vehicle_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.TvShows.VentureBros.Vehicle());
        }
    }
    
    [TestClass]
    public class Test_Types : FakerNUnitBase
    {
        #warning No implementation defined for method character();
        #warning No implementation defined for method complex_rb_hash(long number = 1);
        #warning No implementation defined for method random_complex_type();
        #warning No implementation defined for method random_type();
        // Method : rb_array : Can not generated test for method with required arguments.
        // Method : rb_hash : Can not generated test for method with required arguments.
        #warning No implementation defined for method rb_integer();
        #warning No implementation defined for method rb_string();
        #warning Failed processing method titleize
    }
    
    [TestClass]
    public class Test_Words : FakerNUnitBase
    {
    }
    
    [TestClass]
    public class Test_Words_Adjective : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Negative_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Adjective.Negative());
        }
        [TestMethod()]
        public void Test_Positive_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Adjective.Positive());
        }
    }
    
    [TestClass]
    public class Test_Words_Emotion : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Adjective_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Emotion.Adjective());
        }
        [TestMethod()]
        public void Test_Noun_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Emotion.Noun());
        }
    }
    
    [TestClass]
    public class Test_Words_Hacker : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Abbreviation_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.Abbreviation());
        }
        [TestMethod()]
        public void Test_Adjective_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.Adjective());
        }
        [TestMethod()]
        public void Test_Ingverb_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.Ingverb());
        }
        [TestMethod()]
        public void Test_Noun_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.Noun());
        }
        [TestMethod()]
        public void Test_SaySomethingSmart_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.SaySomethingSmart());
        }
        [TestMethod()]
        public void Test_Verb_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Hacker.Verb());
        }
    }
    
    [TestClass]
    public class Test_Words_Hipster : FakerNUnitBase
    {
        // Method : paragraph : Can not generated test for method with required arguments.
        // Method : paragraph_by_chars : Can not generated test for method with required arguments.
        // Method : paragraphs : Can not generated test for method with required arguments.
        // Method : sentence : Can not generated test for method with required arguments.
        // Method : sentences : Can not generated test for method with required arguments.
        #warning No implementation defined for method word();
        // Method : words : Can not generated test for method with required arguments.
    }
    
    [TestClass]
    public class Test_Words_Verb : FakerNUnitBase
    {
        [TestMethod()]
        public void Test_Base_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Verb.Base());
        }
        [TestMethod()]
        public void Test_IngForm_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Verb.IngForm());
        }
        [TestMethod()]
        public void Test_Past_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Verb.Past());
        }
        [TestMethod()]
        public void Test_PastParticiple_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Verb.PastParticiple());
        }
        [TestMethod()]
        public void Test_SimplePresent_Execute()
        {
            FakerForEveryLocale<string>(faker => faker.Words.Verb.SimplePresent());
        }
    }
    
}
