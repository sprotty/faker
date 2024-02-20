using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace FakerNet
{
    [FakerGenerator("Address")]
    public class AddressGenerator : GeneratorBase
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
        [FakerMethod("building_number")]
        public string BuildingNumber()
        {
            return this.Resolve("address.building_number", this);
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
            return this.Resolve("address.city", this);
        }
        /// <summary>
        /// Produces the name of a city with the state.
        /// </summary>
        /// <example>
        /// <code>Faker::Address.city_with_state #=> "Northfort, California"</code>
        /// </example>
        [FakerMethod("city_with_state")]
        public string CityWithState()
        {
            return this.Resolve("address.city", this);
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
            return this.Resolve("address.city_prefix", this);
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
            return this.Resolve("address.city_suffix", this);
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
            return this.Resolve("address.community", this);
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
            return this.Translate(this.Resolve("address.country", this));
        }
        /// <summary>
        /// Produces a country by ISO country code.
        /// <p>See the [List of ISO 3166 country codes](<a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">en.wikipedia.org/wiki/List_of_ISO_3166_country_codes</a>) on Wikipedia for a full list.</p>
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
            return this.Resolve("address.country_by_code." + code + "", this);
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
            return this.Resolve("address.country_code", this);
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
            return this.Resolve("address.country_code_long", this);
        }
        /// <summary>
        /// Produces an ISO 3166 country code when given a country name.
        /// </summary>
        /// <param name="name">
        /// <p>Country name in snake_case format.</p>
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
            return this.Resolve("address.country_by_name.#{String.lower '" + name + "'}", this);
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
            return double.Parse(this.Expression("#{random_float '-180..180'}", this));
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
            return double.Parse(this.Expression("#{random_float '-180..180'}", this));
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
            return this.Numerify(this.Letterify(this.Resolve("address.mail_box", this)));
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
            return this.Resolve("address.secondary_address", this);
        }
        /// <summary>
        /// Produces the name of a state.
        /// </summary>
        /// <example>
        /// <code>Faker::Address.state #=> "California"</code>
        /// </example>
        [FakerMethod("state")]
        public string State()
        {
            return this.Resolve("address.state", this);
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
            return this.Resolve("address.state_abbr", this);
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("address.street_address", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("address.street_name", this))));
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
            return this.Resolve("address.street_suffix", this);
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
            return this.Resolve("address.time_zone", this);
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
            return this.Numerify(this.Letterify(this.Resolve("address.postcode", this)));
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
            return this.Numerify(this.Letterify(this.Resolve("address.postcode", this)));
        }
    }
    
    [FakerGenerator("Adjective")]
    public class AdjectiveGenerator : GeneratorBase
    {
        internal AdjectiveGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a negative adjective.
        /// </summary>
        /// <example>
        /// <code>Faker::Adjective.negative #=> "Creepy"</code>
        /// </example>
        [FakerMethod("negative")]
        public string Negative()
        {
            return this.Translate(this.Resolve("adjective.negative", this));
        }
        /// <summary>
        /// Produces a positive adjective.
        /// </summary>
        /// <example>
        /// <code>Faker::Adjective.positive #=> "Kind"</code>
        /// </example>
        [FakerMethod("positive")]
        public string Positive()
        {
            return this.Translate(this.Resolve("adjective.positive", this));
        }
    }
    
    [FakerGenerator("Alphanumeric")]
    public class AlphanumericGenerator : GeneratorBase
    {
        internal AlphanumericGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method alpha(long number = 32);
        #warning No implementation defined for method alpha_numeric(long number, long minAlpha, long minNumeric = 0);
    }
    
    [FakerGenerator("Ancient")]
    public class AncientGenerator : GeneratorBase
    {
        internal AncientGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a god from ancient mythology.
        /// </summary>
        /// <example>
        /// <code>Faker::Ancient.god #=> "Zeus"</code>
        /// </example>
        [FakerMethod("god")]
        public string God()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("ancient.god", this))));
        }
        /// <summary>
        /// Produces a hero from ancient mythology.
        /// </summary>
        /// <example>
        /// <code>Faker::Ancient.hero #=> "Achilles"</code>
        /// </example>
        [FakerMethod("hero")]
        public string Hero()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("ancient.hero", this))));
        }
        /// <summary>
        /// Produces a primordial from ancient mythology.
        /// </summary>
        /// <example>
        /// <code>Faker::Ancient.primordial #=> "Gaia"</code>
        /// </example>
        [FakerMethod("primordial")]
        public string Primordial()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("ancient.primordial", this))));
        }
        /// <summary>
        /// Produces a titan from ancient mythology.
        /// </summary>
        /// <example>
        /// <code>Faker::Ancient.titan #=> "Atlas"</code>
        /// </example>
        [FakerMethod("titan")]
        public string Titan()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("ancient.titan", this))));
        }
    }
    
    [FakerGenerator("App")]
    public class AppGenerator : GeneratorBase
    {
        internal AppGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of an app's author.
        /// </summary>
        /// <example>
        /// <code>Faker::App.author #=> "Daphne Swift"</code>
        /// </example>
        [FakerMethod("author")]
        public string Author()
        {
            return this.Numerify(this.Letterify(this.Resolve("app.author", this)));
        }
        /// <summary>
        /// Produces an app name.
        /// </summary>
        /// <example>
        /// <code>Faker::App.name #=> "Treeflex"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Numerify(this.Letterify(this.Resolve("app.name", this)));
        }
        #warning No implementation defined for method semantic_version(IntegerRange? major = null, IntegerRange? minor = null, IntegerRange? patch = null);
        /// <summary>
        /// Produces a version string.
        /// </summary>
        /// <example>
        /// <code>Faker::App.version #=> "1.85"</code>
        /// </example>
        [FakerMethod("version")]
        public string Version()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("app.version", this))));
        }
    }
    
    [FakerGenerator("Appliance")]
    public class ApplianceGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("appliance.brand", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("appliance.equipment", this))));
        }
    }
    
    [FakerGenerator("Artist")]
    public class ArtistGenerator : GeneratorBase
    {
        internal ArtistGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of an artist.
        /// </summary>
        /// <example>
        /// <code>Faker::Artist.name #=> "Michelangelo"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("artist.names", this))));
        }
    }
    
    [FakerGenerator("Australia")]
    public class AustraliaGenerator : GeneratorBase
    {
        internal AustraliaGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces an Australian animal.
        /// <p>Produces an Australian animal</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Australia.animal
        /// #=> "Dingo"</code>
        /// </example>
        [FakerMethod("animal")]
        public string Animal()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("australia.animals", this))));
        }
        /// <summary>
        /// Produces a location in Australia.
        /// <p>Produces a location in Australia</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Australia.location
        /// #=> "Sydney"</code>
        /// </example>
        [FakerMethod("location")]
        public string Location()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("australia.locations", this))));
        }
        /// <summary>
        /// Produces an Australian State or Territory.
        /// <p>Produces an Australian State or Territory</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Australia.state
        /// #=> "New South Wales"</code>
        /// </example>
        [FakerMethod("state")]
        public string State()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("australia.states", this))));
        }
    }
    
    [FakerGenerator("Avatar")]
    public class AvatarGenerator : GeneratorBase
    {
        internal AvatarGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method image(string slug, string size, string format, string set, string? bgset = null);
    }
    
    [FakerGenerator("Bank")]
    public class BankGenerator : GeneratorBase
    {
        internal BankGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method account_number(long digits = 10);
        #warning No implementation defined for method bsb_number();
        #warning Failed processing method checksum
        #warning Failed processing method compile_bsb_number
        #warning Failed processing method compile_fraction
        #warning Failed processing method compile_routing_number
        /// <summary>
        /// Produces a bank iban number.
        /// </summary>
        /// <param name="countryCode">
        /// <p>Specifies what country prefix is used to generate the iban code. Providing ‘nil` will use a random country.</p>
        /// (default value "'GB'")
        /// </param>
        /// <example>
        /// <code>Faker::Bank.iban #=> "GB76DZJM33188515981979"
        /// Faker::Bank.iban(country_code: "be") #=> "BE6375388567752043"
        /// Faker::Bank.iban(country_code: nil) #=> "DE45186738071857270067"</code>
        /// </example>
        [FakerMethod("iban")]
        public string Iban(string countryCode = "GB")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bank.iban_details.#{string.lower '#{country_code}}.bban_pattern", this))));
        }
        #warning Failed processing method iban_checksum
        #warning No implementation defined for method iban_country_code();
        /// <summary>
        /// Produces a bank name.
        /// </summary>
        /// <example>
        /// <code>Faker::Bank.name #=> "ABN AMRO CORPORATE FINANCE LIMITED"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bank.name", this))));
        }
        #warning Failed processing method rand_numstring
        #warning No implementation defined for method routing_number();
        #warning No implementation defined for method routing_number_with_format();
        /// <summary>
        /// Produces a swift / bic number.
        /// </summary>
        /// <example>
        /// <code>Faker::Bank.swift_bic #=> "AAFMGB21"</code>
        /// </example>
        [FakerMethod("swift_bic")]
        public string SwiftBic()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bank.swift_bic", this))));
        }
        #warning No implementation defined for method valid_checksum();
        #warning Failed processing method valid_routing_number
    }
    
    [FakerGenerator("Barcode")]
    public class BarcodeGenerator : GeneratorBase
    {
        internal BarcodeGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method ean
        #warning Failed processing method ean_with_composite_symbology
        #warning Failed processing method generate_barcode
        #warning No implementation defined for method generate_check_digit();
        #warning Failed processing method isbn
        #warning Failed processing method ismn
        #warning Failed processing method issn
        #warning No implementation defined for method sum_even_odd();
        #warning Failed processing method upc_a
        #warning Failed processing method upc_a_with_composite_symbology
        #warning Failed processing method upc_e
        #warning Failed processing method upc_e_with_composite_symbology
    }
    
    [FakerGenerator("Beer")]
    public class BeerGenerator : GeneratorBase
    {
        internal BeerGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random beer alcohol percentage.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.alcohol #=> "5.4%"</code>
        /// </example>
        [FakerMethod("alcohol")]
        public string Alcohol()
        {
            return this.Expression("#{rand(2.0..10.0).round(1)}%", this);
        }
        /// <summary>
        /// Produces a random beer blg level.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.blg #=> "5.1Blg"</code>
        /// </example>
        [FakerMethod("blg")]
        public string Blg()
        {
            return this.Expression("#{rand(5.0..20.0).round(1)}°Blg", this);
        }
        /// <summary>
        /// Produces a random beer hops.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.hop #=> "Sterling"</code>
        /// </example>
        [FakerMethod("hop")]
        public string Hop()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("beer.hop", this))));
        }
        /// <summary>
        /// Produces a random beer IBU.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.ibu #=> "87 IBU"</code>
        /// </example>
        [FakerMethod("ibu")]
        public string Ibu()
        {
            return this.Expression("#{rand(10..100)} IBU", this);
        }
        /// <summary>
        /// Produces a random beer malt.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.malts #=> "Munich"</code>
        /// </example>
        [FakerMethod("malts")]
        public string Malts()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("beer.malt", this))));
        }
        /// <summary>
        /// Produces a random beer name.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.name #=> "Pliny The Elder"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("beer.name", this))));
        }
        /// <summary>
        /// Produces a random beer style.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.style #=> "Wood-aged Beer"</code>
        /// </example>
        [FakerMethod("style")]
        public string Style()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("beer.style", this))));
        }
        /// <summary>
        /// Produces a random beer yeast.
        /// </summary>
        /// <example>
        /// <code>Faker::Beer.yeast #=> "5335 - Lactobacillus"</code>
        /// </example>
        [FakerMethod("yeast")]
        public string Yeast()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("beer.yeast", this))));
        }
    }
    
    [FakerGenerator("Blockchain")]
    public class BlockchainGenerator : GeneratorBase
    {
        [FakerMethod("Aeternity")]
        public AeternityGenerator Aeternity { get; }
        [FakerMethod("Bitcoin")]
        public BitcoinGenerator Bitcoin { get; }
        [FakerMethod("Ethereum")]
        public EthereumGenerator Ethereum { get; }
        [FakerMethod("Tezos")]
        public TezosGenerator Tezos { get; }
        internal BlockchainGenerator(Faker faker)
                 : base(faker)
        {
            Aeternity = new AeternityGenerator(_faker);
            Bitcoin = new BitcoinGenerator(_faker);
            Ethereum = new EthereumGenerator(_faker);
            Tezos = new TezosGenerator(_faker);
        }
        
        [FakerGenerator("Aeternity")]
        public class AeternityGenerator : GeneratorBase
        {
            internal AeternityGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random Aeternity wallet address.
            /// <p>Produces a random Aeternity wallet address</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.address
            /// #=> "ak_zvU8YQLagjcfng7Tg8yCdiZ1rpiWNp1PBn3vtUs44utSvbJVR"</code>
            /// </example>
            [FakerMethod("address")]
            public string Address()
            {
                return this.Expression("ak_#{rand_strings}", this);
            }
            /// <summary>
            /// Produces a random Aeternity contract.
            /// <p>Produces a random Aeternity contract</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.contract
            /// #=> "ct_Hk2JsNeWGEYQEHHQCfcBeGrwbhtYSwFTPdDhW2SvjFYVojyhW"</code>
            /// </example>
            [FakerMethod("contract")]
            public string Contract()
            {
                return this.Expression("ct_#{rand_strings}", this);
            }
            /// <summary>
            /// Produces a random Aeternity oracle.
            /// <p>Produces a random Aeternity oracle</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.oracle
            /// #=> "ok_28QDg7fkF5qiKueSdUvUBtCYPJdmMEoS73CztzXCRAwMGKHKZh"</code>
            /// </example>
            [FakerMethod("oracle")]
            public string Oracle()
            {
                return this.Expression("ok_#{rand_strings(51)}", this);
            }
            /// <summary>
            /// Produces a random Aeternity transaction.
            /// <p>Produces a random Aeternity transaction</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.transaction
            /// #=> "th_147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"</code>
            /// </example>
            [FakerMethod("transaction")]
            public string Transaction()
            {
                return this.Expression("th_#{rand_strings(51)}", this);
            }
        }
        
        [FakerGenerator("Bitcoin")]
        public class BitcoinGenerator : GeneratorBase
        {
            internal BitcoinGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method address();
            #warning No implementation defined for method address_for(UNKNOWN_Symbol network);
            #warning No implementation defined for method testnet_address();
        }
        
        [FakerGenerator("Ethereum")]
        public class EthereumGenerator : GeneratorBase
        {
            internal EthereumGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method address();
        }
        
        [FakerGenerator("Tezos")]
        public class TezosGenerator : GeneratorBase
        {
            internal TezosGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method account();
            #warning No implementation defined for method block();
            #warning No implementation defined for method contract();
            #warning No implementation defined for method encode_tz(UNKNOWN_Symbol prefix, long payloadSize);
            #warning No implementation defined for method operation();
            #warning No implementation defined for method public_key();
            #warning No implementation defined for method secret_key();
            #warning No implementation defined for method signature();
        }
        
    }
    
    [FakerGenerator("Blood")]
    public class BloodGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("blood.group", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("blood.rh_factor", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("blood.type", this))));
        }
    }
    
    [FakerGenerator("Book")]
    public class BookGenerator : GeneratorBase
    {
        internal BookGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random book author.
        /// <p>Produces a random book author</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Book.author #=> "Alysha Olsen"</code>
        /// </example>
        [FakerMethod("author")]
        public string Author()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("book.author", this))));
        }
        /// <summary>
        /// Produces a random genre.
        /// <p>Produces a random genre</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Book.genre #=> "Mystery"</code>
        /// </example>
        [FakerMethod("genre")]
        public string Genre()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("book.genre", this))));
        }
        /// <summary>
        /// Produces a random book publisher.
        /// <p>Produces a random book publisher</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Book.publisher #=> "Opus Reader"</code>
        /// </example>
        [FakerMethod("publisher")]
        public string Publisher()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("book.publisher", this))));
        }
        /// <summary>
        /// Produces a random book title.
        /// <p>Produces a random book title</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Book.title #=> "The Odd Sister"</code>
        /// </example>
        [FakerMethod("title")]
        public string Title()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("book.title", this))));
        }
    }
    
    [FakerGenerator("Books")]
    public class BooksGenerator : GeneratorBase
    {
        [FakerMethod("CultureSeries")]
        public CultureSeriesGenerator CultureSeries { get; }
        [FakerMethod("Dune")]
        public DuneGenerator Dune { get; }
        [FakerMethod("Lovecraft")]
        public LovecraftGenerator Lovecraft { get; }
        [FakerMethod("TheKingkillerChronicle")]
        public TheKingkillerChronicleGenerator TheKingkillerChronicle { get; }
        internal BooksGenerator(Faker faker)
                 : base(faker)
        {
            CultureSeries = new CultureSeriesGenerator(_faker);
            Dune = new DuneGenerator(_faker);
            Lovecraft = new LovecraftGenerator(_faker);
            TheKingkillerChronicle = new TheKingkillerChronicleGenerator(_faker);
        }
        
        [FakerGenerator("CultureSeries")]
        public class CultureSeriesGenerator : GeneratorBase
        {
            internal CultureSeriesGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <example>
            /// <code>Faker::Books::CultureSeries.book
            /// #=> "The Player of Games"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.books", this))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.civ
            /// #=> "Culture"</code>
            /// </example>
            [FakerMethod("civ")]
            public string Civ()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.civs", this))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship
            /// #=> "Fate Amenable To Change"</code>
            /// </example>
            [FakerMethod("culture_ship")]
            public string CultureShip()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.culture_ships", this))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship_class
            /// #=> "General Systems Vehicle"</code>
            /// </example>
            [FakerMethod("culture_ship_class")]
            public string CultureShipClass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.culture_ship_classes", this))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship_class_abv
            /// #=> "The Odd Sister"</code>
            /// </example>
            [FakerMethod("culture_ship_class_abv")]
            public string CultureShipClassAbv()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.culture_ship_class_abvs", this))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.planet
            /// #=> "Xinth"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("culture_series.planets", this))));
            }
        }
        
        /// <summary>
        /// 
        /// 				A Faker module beyond your dreams, test data beyond your imagination.
        /// 				<p>A Faker module beyond your dreams, test data beyond your imagination.</p>
        /// 			
        /// </summary>
        [FakerGenerator("Dune")]
        public class DuneGenerator : GeneratorBase
        {
            internal DuneGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Dune.
            /// <p>Produces the name of a character from Dune</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.character #=> "Leto Atreides"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dune.characters", this))));
            }
            /// <summary>
            /// Produces the name of a city from Dune.
            /// <p>Produces the name of a city from Dune</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.city #=> "Arrakeen"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dune.cities", this))));
            }
            /// <summary>
            /// Produces the name of a planet from Dune.
            /// <p>Produces the name of a planet from Dune</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.planet #=> "Caladan"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dune.planets", this))));
            }
            #warning No implementation defined for method quote(string? character = null);
            #warning No implementation defined for method saying(string? source = null);
            /// <example>
            /// <code>Faker::Books::Dune.title #=> "Duke"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dune.titles", this))));
            }
        }
        
        [FakerGenerator("Lovecraft")]
        public class LovecraftGenerator : GeneratorBase
        {
            internal LovecraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a deity.
            /// <p>Produces the name of a deity</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.deity #=> "Shub-Niggurath"</code>
            /// </example>
            [FakerMethod("deity")]
            public string Deity()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lovecraft.deity", this))));
            }
            /// <param name="number">
            /// <p>The number of times to repeat the chant</p>
            /// (default value "1")
            /// </param>
            /// <example>
            /// <code>Faker::Books::Lovecraft.fhtagn
            /// #=> "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"</code>
            /// </example>
            [FakerMethod("fhtagn")]
            public string Fhtagn(long number = 1)
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lovecraft.fhtagn", this))));
            }
            /// <summary>
            /// Produces the name of a location.
            /// <p>Produces the name of a location</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.location #=> "Kingsport"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lovecraft.location", this))));
            }
            #warning No implementation defined for method paragraph(long sentenceCount, long randomSentencesToAdd = 3);
            #warning No implementation defined for method paragraph_by_chars(long characters = 256);
            #warning No implementation defined for method paragraphs(long number = 3);
            #warning No implementation defined for method sentence(long wordCount, long randomWordsToAdd, bool openCompoundsAllowed = true);
            #warning No implementation defined for method sentences(long number = 3);
            /// <summary>
            /// Produces the name of a tome.
            /// <p>Produces the name of a tome</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.tome #=> "Book of Eibon"</code>
            /// </example>
            [FakerMethod("tome")]
            public string Tome()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lovecraft.tome", this))));
            }
            #warning No implementation defined for method word();
            #warning No implementation defined for method words(long number, bool spacesAllowed = false);
        }
        
        [FakerGenerator("TheKingkillerChronicle")]
        public class TheKingkillerChronicleGenerator : GeneratorBase
        {
            internal TheKingkillerChronicleGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a The Kingkiller Chronicle book.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::TheKingkillerChronicle.book #=> "The Name of the Wind"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("books.the_kingkiller_chronicle.books", this))));
            }
            /// <summary>
            /// Produces the name of a The Kingkiller Chronicle character.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::TheKingkillerChronicle.character #=> "Kvothe"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("books.the_kingkiller_chronicle.characters", this))));
            }
            /// <summary>
            /// Produces the name of a The Kingkiller Chronicle creature.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::TheKingkillerChronicle.creature #=> "Scrael"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("books.the_kingkiller_chronicle.creatures", this))));
            }
            /// <summary>
            /// Produces the name of a The Kingkiller Chronicle location.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::TheKingkillerChronicle.location #=> "Tarbean"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("books.the_kingkiller_chronicle.locations", this))));
            }
        }
        
    }
    
    [FakerGenerator("Boolean")]
    public class BooleanGenerator : GeneratorBase
    {
        internal BooleanGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method get_boolean(double trueRatio = 0.5);
    }
    
    [FakerGenerator("BossaNova")]
    public class BossaNovaGenerator : GeneratorBase
    {
        internal BossaNovaGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a bossa nova artist.
        /// </summary>
        /// <example>
        /// <code>Faker::BossaNova.artist #=> "Tom Jobin"</code>
        /// </example>
        [FakerMethod("artist")]
        public string Artist()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bossa_nova.artists", this))));
        }
        /// <summary>
        /// Produces a bossa nova song.
        /// </summary>
        /// <example>
        /// <code>Faker::BossaNova.song #=> "Chega de Saudade"</code>
        /// </example>
        [FakerMethod("song")]
        public string Song()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bossa_nova.songs", this))));
        }
    }
    
    [FakerGenerator("Business")]
    public class BusinessGenerator : GeneratorBase
    {
        internal BusinessGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method credit_card_expiry_date();
        /// <summary>
        /// Produces a credit card number.
        /// </summary>
        /// <example>
        /// <code>Faker::Business.credit_card_number #=> "1228-1221-1221-1431"</code>
        /// </example>
        [FakerMethod("credit_card_number")]
        public string CreditCardNumber()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("business.credit_card_numbers", this))));
        }
        /// <summary>
        /// Produces a type of credit card.
        /// </summary>
        /// <example>
        /// <code>Faker::Business.credit_card_type #=> "visa"</code>
        /// </example>
        [FakerMethod("credit_card_type")]
        public string CreditCardType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("business.credit_card_types", this))));
        }
    }
    
    [FakerGenerator("Camera")]
    public class CameraGenerator : GeneratorBase
    {
        internal CameraGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a brand of a camera.
        /// <p>Produces a brand of a camera</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Camera.brand #=> "Canon"</code>
        /// </example>
        [FakerMethod("brand")]
        public string Brand()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("camera.brand", this))));
        }
        /// <summary>
        /// Produces a brand with model.
        /// <p>Produces a brand with model</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Camera.brand_with_model #=> "Canon 450D"</code>
        /// </example>
        [FakerMethod("brand_with_model")]
        public string BrandWithModel()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("camera.brand_with_model", this))));
        }
        /// <summary>
        /// Produces a model of camera.
        /// <p>Produces a model of camera</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Camera.model #=> "450D"</code>
        /// </example>
        [FakerMethod("model")]
        public string Model()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("camera.model", this))));
        }
    }
    
    [FakerGenerator("Cannabis")]
    public class CannabisGenerator : GeneratorBase
    {
        internal CannabisGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random brand.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.brand #=> "Cannavore Confections"</code>
        /// </example>
        [FakerMethod("brand")]
        public string Brand()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.brands", this))));
        }
        /// <summary>
        /// Produces a random buzzword.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.buzzword #=> "high"</code>
        /// </example>
        [FakerMethod("buzzword")]
        public string Buzzword()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.buzzwords", this))));
        }
        /// <summary>
        /// Produces a random cannabinoid type.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.cannabinoid #=> "Cannabinolic Acid"</code>
        /// </example>
        [FakerMethod("cannabinoid")]
        public string Cannabinoid()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.cannabinoids", this))));
        }
        /// <summary>
        /// Produces a random abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.cannabinoid_abbreviation #=> "CBGa"</code>
        /// </example>
        [FakerMethod("cannabinoid_abbreviation")]
        public string CannabinoidAbbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.cannabinoid_abbreviations", this))));
        }
        /// <summary>
        /// Produces a random category.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.category #=> "crystalline"</code>
        /// </example>
        [FakerMethod("category")]
        public string Category()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.categories", this))));
        }
        /// <summary>
        /// Produces a random health benefit.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.health_benefit #=> "prevents infection"</code>
        /// </example>
        [FakerMethod("health_benefit")]
        public string HealthBenefit()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.health_benefits", this))));
        }
        /// <summary>
        /// Produces a random kind of medical use.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.medical_use #=> "anti-cancer"</code>
        /// </example>
        [FakerMethod("medical_use")]
        public string MedicalUse()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.medical_uses", this))));
        }
        /// <summary>
        /// Produces a random strain.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.strain #=> "Super Glue"</code>
        /// </example>
        [FakerMethod("strain")]
        public string Strain()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.strains", this))));
        }
        /// <summary>
        /// Produces a random terpene type.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.terpene #=> "Terpinene"</code>
        /// </example>
        [FakerMethod("terpene")]
        public string Terpene()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.terpenes", this))));
        }
        /// <summary>
        /// Produces a random type.
        /// </summary>
        /// <example>
        /// <code>Faker::Cannabis.type #=> "indica"</code>
        /// </example>
        [FakerMethod("type")]
        public string Type()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cannabis.types", this))));
        }
    }
    
    [FakerGenerator("ChileRut")]
    public class ChileRutGenerator : GeneratorBase
    {
        internal ChileRutGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method check_digit();
        #warning No implementation defined for method dv();
        #warning Failed processing method format_rut
        #warning No implementation defined for method full_rut(long minRut, long maxRut, bool @fixed);
        #warning Failed processing method last_rut
        #warning No implementation defined for method rut(long minRut, long maxRut, bool isFixed = false);
    }
    
    [FakerGenerator("ChuckNorris")]
    public class ChuckNorrisGenerator : GeneratorBase
    {
        internal ChuckNorrisGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a Chuck Norris Fact.
        /// <p>Original list of facts: <a href="https://github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java">github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java</a></p>
        /// </summary>
        /// <example>
        /// <code>Faker::ChuckNorris.fact
        /// #=> "Chuck Norris can solve the Towers of Hanoi in one move."</code>
        /// </example>
        [FakerMethod("fact")]
        public string Fact()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("chuck_norris.fact", this))));
        }
    }
    
    [FakerGenerator("Code")]
    public class CodeGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("code.asin", this))));
        }
        #warning No implementation defined for method ean(long digits = 13);
        #warning Failed processing method generate_base10_isbn
        #warning Failed processing method generate_base13_ean
        #warning Failed processing method generate_base13_isbn
        #warning Failed processing method generate_base8_ean
        #warning Failed processing method generate_imei
        #warning Failed processing method generate_nric_check_alphabet
        #warning Failed processing method generate_sin_check_digit
        #warning No implementation defined for method imei();
        #warning No implementation defined for method isbn(long digits = 10);
        #warning No implementation defined for method npi();
        #warning No implementation defined for method nric(long minAge, long maxAge = 65);
        #warning No implementation defined for method rut();
        #warning Failed processing method rut_verificator_digit
        #warning No implementation defined for method sin();
        #warning Failed processing method sum
    }
    
    [FakerGenerator("Coffee")]
    public class CoffeeGenerator : GeneratorBase
    {
        internal CoffeeGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random blend name.
        /// </summary>
        /// <example>
        /// <code>Faker::Coffee.blend_name #=> "Major Java"</code>
        /// </example>
        [FakerMethod("blend_name")]
        public string BlendName()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coffee.blend_name", this))));
        }
        /// <summary>
        /// Produces a random coffee taste intensity.
        /// </summary>
        /// <example>
        /// <code>Faker::Coffee.intensifier #=> "mild"</code>
        /// </example>
        [FakerMethod("intensifier")]
        public string Intensifier()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coffee.intensifier", this))));
        }
        /// <summary>
        /// Produces a string containing a random description of a coffee's taste.
        /// </summary>
        /// <example>
        /// <code>Faker::Coffee.notes #=> "dull, tea-like, cantaloupe, soy sauce, marshmallow"</code>
        /// </example>
        [FakerMethod("notes")]
        public string Notes()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coffee.notes", this))));
        }
        /// <summary>
        /// Produces a random coffee origin place.
        /// </summary>
        /// <example>
        /// <code>Faker::Coffee.origin #=> "Oaxaca, Mexico"</code>
        /// </example>
        [FakerMethod("origin")]
        public string Origin()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coffee.country", this))));
        }
        #warning Failed processing method search_format
        /// <summary>
        /// Produces a random coffee variety.
        /// </summary>
        /// <example>
        /// <code>Faker::Coffee.variety #=> "Red Bourbon"</code>
        /// </example>
        [FakerMethod("variety")]
        public string Variety()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coffee.variety", this))));
        }
    }
    
    [FakerGenerator("Coin")]
    public class CoinGenerator : GeneratorBase
    {
        internal CoinGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Retrieves a face to a flipped coin.
        /// <p>Retrieves a face to a flipped coin</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Coin.flip #=> "Heads"</code>
        /// </example>
        [FakerMethod("flip")]
        public string Flip()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("coin.flip", this))));
        }
        /// <summary>
        /// Retrieves a random coin from any country.
        /// </summary>
        /// <example>
        /// <code>Faker::Coin.name #=> "Brazilian Real"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("currency.name", this))));
        }
    }
    
    [FakerGenerator("Color")]
    public class ColorGenerator : GeneratorBase
    {
        internal ColorGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a color.
        /// </summary>
        /// <example>
        /// <code>Faker::Color.color_name #=> "yellow"</code>
        /// </example>
        [FakerMethod("color_name")]
        public string ColorName()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("color.name", this))));
        }
        #warning No implementation defined for method hex_color(UNKNOWN_Hash? args = null);
        #warning No implementation defined for method hsl_color(UNKNOWN_FLoat hue, double saturation, double? lightness = null);
        #warning No implementation defined for method hsl_to_hex(UNKNOWN_Array(Float, Float, Float) aHslColor);
        #warning No implementation defined for method hsla_color();
        #warning No implementation defined for method rgb_color();
        #warning Failed processing method single_rgb_color
    }
    
    [FakerGenerator("Commerce")]
    public class CommerceGenerator : GeneratorBase
    {
        internal CommerceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a randomized string of a brand name.
        ///                             <p>Produces a randomized string of a brand name</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Commerce.brand #=> 'Apple'</code>
        /// </example>
        [FakerMethod("brand")]
        public string Brand()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("commerce.brand", this))));
        }
        #warning Failed processing method categories
        /// <summary>
        /// Produces a random color.
        /// </summary>
        /// <example>
        /// <code>Faker::Commerce.color #=> "lavender"</code>
        /// </example>
        [FakerMethod("color")]
        public string Color()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("color.name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("commerce.product_name.material", this))));
        }
        #warning Failed processing method merge_categories
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("commerce.product_name.adjective", this))));
        }
        /// <summary>
        /// Produces a random promotion code.
        /// </summary>
        /// <param name="digits">
        /// 
        /// <p>Updates the number of numerical digits used to generate the promotion code.</p>
        /// 
        /// (default value "6")
        /// </param>
        /// <example>
        /// <code>Faker::Commerce.promotion_code #=> "AmazingDeal829102"
        /// Faker::Commerce.promotion_code(digits: 2) #=> "AmazingPrice57"</code>
        /// </example>
        [FakerMethod("promotion_code")]
        public string PromotionCode(long digits = 6)
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("commerce.promotion_code.adjective", this))));
        }
        /// <summary>
        /// Produces a randomized string of a vendor name.
        ///                             <p>Produces a randomized string of a vendor name</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Commerce.vendor #=> 'Dollar General'</code>
        /// </example>
        [FakerMethod("vendor")]
        public string Vendor()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("commerce.vendor", this))));
        }
    }
    
    [FakerGenerator("Company")]
    public class CompanyGenerator : GeneratorBase
    {
        internal CompanyGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method abn_checksum
        #warning No implementation defined for method australian_business_number();
        #warning No implementation defined for method brazilian_company_number();
        #warning No implementation defined for method bs();
        #warning No implementation defined for method buzzword();
        #warning Failed processing method calculate_gst_checksum
        #warning No implementation defined for method catch_phrase();
        #warning Failed processing method collect_regon_sum
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.department", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.industry", this))));
        }
        #warning Failed processing method inn_checksum
        #warning No implementation defined for method inn_number(UNKNOWN_Symbol type);
        #warning No implementation defined for method logo();
        #warning Failed processing method luhn_algorithm
        #warning Failed processing method mod11
        /// <summary>
        /// Produces a company name.
        /// </summary>
        /// <example>
        /// <code>Faker::Company.name #=> "Roberts Inc"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.profession", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.sic_code", this))));
        }
        #warning No implementation defined for method south_african_close_corporation_registration_number();
        #warning No implementation defined for method south_african_listed_company_registration_number();
        #warning No implementation defined for method south_african_pty_ltd_registration_number();
        #warning No implementation defined for method south_african_trust_registration_number();
        #warning Failed processing method spanish_b_algorithm
        #warning Failed processing method spanish_cif_control_digit
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.suffix", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("company.type", this))));
        }
        #warning Failed processing method weight_sum
    }
    
    [FakerGenerator("Compass")]
    public class CompassGenerator : GeneratorBase
    {
        internal CompassGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.abbreviation #=> "NEbN"</code>
        /// </example>
        [FakerMethod("abbreviation")]
        public string Abbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.abbreviation", this))));
        }
        /// <summary>
        /// Produces a random azimuth.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.azimuth #=> "168.75"</code>
        /// </example>
        [FakerMethod("azimuth")]
        public string Azimuth()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.azimuth", this))));
        }
        /// <summary>
        /// Produces a random cardinal.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.cardinal #=> "north"</code>
        /// </example>
        [FakerMethod("cardinal")]
        public string Cardinal()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.cardinal.word", this))));
        }
        /// <summary>
        /// Produces a random cardinal abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.cardinal_abbreviation #=> "N"</code>
        /// </example>
        [FakerMethod("cardinal_abbreviation")]
        public string CardinalAbbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.cardinal.abbreviation", this))));
        }
        /// <summary>
        /// Produces a random cardinal azimuth.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.cardinal_azimuth #=> "90"</code>
        /// </example>
        [FakerMethod("cardinal_azimuth")]
        public string CardinalAzimuth()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.cardinal.azimuth", this))));
        }
        /// <summary>
        /// Produces a random direction.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.direction #=> "southeast"</code>
        /// </example>
        [FakerMethod("direction")]
        public string Direction()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.direction", this))));
        }
        /// <summary>
        /// Produces a random half wind.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.half_wind #=> "north-northwest"</code>
        /// </example>
        [FakerMethod("half_wind")]
        public string HalfWind()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.half-wind.word", this))));
        }
        /// <summary>
        /// Produces a random half wind abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.half_wind_abbreviation #=> "NNE"</code>
        /// </example>
        [FakerMethod("half_wind_abbreviation")]
        public string HalfWindAbbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.half-wind.abbreviation", this))));
        }
        /// <summary>
        /// Produces a random half wind azimuth.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.half_wind_azimuth #=> "292.5"</code>
        /// </example>
        [FakerMethod("half_wind_azimuth")]
        public string HalfWindAzimuth()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.half-wind.azimuth", this))));
        }
        /// <summary>
        /// Produces a random ordinal.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.ordinal #=> "northwest"</code>
        /// </example>
        [FakerMethod("ordinal")]
        public string Ordinal()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.ordinal.word", this))));
        }
        /// <summary>
        /// Produces a random ordinal abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.ordinal_abbreviation #=> "SW"</code>
        /// </example>
        [FakerMethod("ordinal_abbreviation")]
        public string OrdinalAbbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.ordinal.abbreviation", this))));
        }
        /// <summary>
        /// Produces a random ordinal azimuth.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.ordinal_azimuth #=> "135"</code>
        /// </example>
        [FakerMethod("ordinal_azimuth")]
        public string OrdinalAzimuth()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.ordinal.azimuth", this))));
        }
        /// <summary>
        /// Produces a random quarter wind.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.quarter_wind #=> "north by west"</code>
        /// </example>
        [FakerMethod("quarter_wind")]
        public string QuarterWind()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.quarter-wind.word", this))));
        }
        /// <summary>
        /// Produces a random quarter wind abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.quarter_wind_abbreviation #=> "SWbS"</code>
        /// </example>
        [FakerMethod("quarter_wind_abbreviation")]
        public string QuarterWindAbbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.quarter-wind.abbreviation", this))));
        }
        /// <summary>
        /// Produces a random quarter wind azimuth.
        ///                             <p>Produces a random quarter wind azimuth</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Compass.quarter_wind_azimuth #=> "56.25"</code>
        /// </example>
        [FakerMethod("quarter_wind_azimuth")]
        public string QuarterWindAzimuth()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("compass.quarter-wind.azimuth", this))));
        }
    }
    
    [FakerGenerator("Computer")]
    public class ComputerGenerator : GeneratorBase
    {
        internal ComputerGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a computer os.
        /// </summary>
        /// <param name="platform">
        /// <p>optionally specify the platform ‘linux`, `macos`, or `windows`.</p>
        /// (default value "'linux'")
        /// </param>
        /// <example>
        /// <code>Faker::Computer.os #=> "RHEL 6.10"</code>
        /// </example>
        [FakerMethod("os")]
        public string Os(string platform = "linux")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("computer.os.#{String.lower '" + platform + "'}", this))));
        }
        /// <summary>
        /// Produces the name of a computer platform.
        /// </summary>
        /// <example>
        /// <code>Faker::Computer.platform #=> "Linux"</code>
        /// </example>
        [FakerMethod("platform")]
        public string Platform()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("computer.platform", this))));
        }
        /// <summary>
        /// Produces a string with computer platform and os.                        
        /// </summary>
        /// <example>
        /// <code>Faker::Computer.stack #=> "Linux, RHEL 6.10"</code>
        /// </example>
        [FakerMethod("stack")]
        public string Stack()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("computer.os.#{String.lower '#{platform}'}", this))));
        }
        /// <summary>
        /// Produces the name of a computer type.
        /// </summary>
        /// <example>
        /// <code>Faker::Computer.type #=> "server"</code>
        /// </example>
        [FakerMethod("type")]
        public string Type()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("computer.type", this))));
        }
    }
    
    [FakerGenerator("Construction")]
    public class ConstructionGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.heavy_equipment", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.materials", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.roles", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.standard_cost_codes", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.subcontract_categories", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("construction.trades", this))));
        }
    }
    
    [FakerGenerator("Cosmere")]
    public class CosmereGenerator : GeneratorBase
    {
        internal CosmereGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method allomancer();
        #warning No implementation defined for method aon();
        #warning No implementation defined for method feruchemist();
        #warning No implementation defined for method herald();
        #warning No implementation defined for method knight_radiant();
        #warning No implementation defined for method metal();
        #warning No implementation defined for method shard();
        #warning No implementation defined for method shard_world();
        #warning No implementation defined for method spren();
        #warning No implementation defined for method surge();
    }
    
    [FakerGenerator("Creature")]
    public class CreatureGenerator : GeneratorBase
    {
        [FakerMethod("Animal")]
        public AnimalGenerator Animal { get; }
        [FakerMethod("Bird")]
        public BirdGenerator Bird { get; }
        [FakerMethod("Cat")]
        public CatGenerator Cat { get; }
        [FakerMethod("Dog")]
        public DogGenerator Dog { get; }
        [FakerMethod("Horse")]
        public HorseGenerator Horse { get; }
        internal CreatureGenerator(Faker faker)
                 : base(faker)
        {
            Animal = new AnimalGenerator(_faker);
            Bird = new BirdGenerator(_faker);
            Cat = new CatGenerator(_faker);
            Dog = new DogGenerator(_faker);
            Horse = new HorseGenerator(_faker);
        }
        
        [FakerGenerator("Animal")]
        public class AnimalGenerator : GeneratorBase
        {
            internal AnimalGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random animal name.
            ///                                 <p>Produces a random animal name</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Animal.name #=> "fly"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.animal.name", this))));
            }
        }
        
        [FakerGenerator("Bird")]
        public class BirdGenerator : GeneratorBase
        {
            internal BirdGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random adjective used to described birds.
            ///                                 <p>Produces a random adjective used to described birds</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.adjective #=> 'common'</code>
            /// </example>
            [FakerMethod("adjective")]
            public string Adjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.adjectives", this))));
            }
            /// <summary>
            /// Produces a random bird anatomy word.
            ///                                 <p>Produces a random bird anatomy word</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.anatomy #=> "rump"</code>
            /// </example>
            [FakerMethod("anatomy")]
            public string Anatomy()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.anatomy", this))));
            }
            /// <summary>
            /// Produces a random, past tensed bird anatomy word.
            ///                                 <p>Produces a random, past tensed bird anatomy word</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.anatomy #=> "breasted"</code>
            /// </example>
            [FakerMethod("anatomy_past_tense")]
            public string AnatomyPastTense()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.anatomy_past_tense", this))));
            }
            /// <summary>
            /// Produces a random color word used in describing birds.
            ///                                 <p>Produces a random color word used in describing birds</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.color #=> "ferruginous"</code>
            /// </example>
            [FakerMethod("color")]
            public string Color()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.colors", this))));
            }
            /// <summary>
            /// Produces a random common family name of a bird.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.common_family_name #=> "Owls"</code>
            /// </example>
            [FakerMethod("common_family_name")]
            public string CommonFamilyName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.common_family_name", this))));
            }
            #warning No implementation defined for method common_name(UNKNOWN_String | Symbol | nil? taxOrder = null);
            /// <summary>
            /// Produces a random emotional adjective NOT used to described birds ...but could be.
            ///                                 <p>Produces a random emotional adjective NOT used to described birds …but could be</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.emotional_adjective #=> 'cantankerous'</code>
            /// </example>
            [FakerMethod("emotional_adjective")]
            public string EmotionalAdjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.emotional_adjectives", this))));
            }
            /// <summary>
            /// Produces a random geographical word used in describing birds.
            ///                                 <p>Produces a random geographical word used in describing birds</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.geo #=> "Eurasian"</code>
            /// </example>
            [FakerMethod("geo")]
            public string Geo()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.geo", this))));
            }
            /// <summary>
            /// Produces a random and IMplausible common name for a bird.
            ///                                 <p>Produces a random and IMplausible common name for a bird</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.implausible_common_name #=> 'Hellinger's Cantankerous Chickadee'</code>
            /// </example>
            [FakerMethod("implausible_common_name")]
            public string ImplausibleCommonName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.implausible_common_names", this))));
            }
            #warning No implementation defined for method order();
            #warning No implementation defined for method order_with_common_name();
            /// <summary>
            /// Produces a random and plausible common name for a bird.
            ///                                 <p>Produces a random and plausible common name for a bird</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.plausible_common_name #=> 'Hellinger's Wren'</code>
            /// </example>
            [FakerMethod("plausible_common_name")]
            public string PlausibleCommonName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.plausible_common_names", this))));
            }
            /// <summary>
            /// Produces a random adjective NOT used to described birds ...but probably shouldn't.
            ///                                 <p>Produces a random adjective NOT used to described birds …but probably shouldn’t</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.silly_adjective #=> 'drunk'</code>
            /// </example>
            [FakerMethod("silly_adjective")]
            public string SillyAdjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.bird.silly_adjectives", this))));
            }
        }
        
        [FakerGenerator("Cat")]
        public class CatGenerator : GeneratorBase
        {
            internal CatGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random cat breed.
            ///                                 <p>Produces a random cat breed</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.breed #=> "Scottish Fold"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.cat.breed", this))));
            }
            /// <summary>
            /// Produces a random name for a cat.
            ///                                 <p>Produces a random name for a cat</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.name #=> "Felix"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.cat.name", this))));
            }
            /// <summary>
            /// Produces a random cat breed registry.
            ///                                 <p>Produces a random cat breed registry</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.registry #=> "Fancy Southern Africa Cat Council"</code>
            /// </example>
            [FakerMethod("registry")]
            public string Registry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.cat.registry", this))));
            }
        }
        
        [FakerGenerator("Dog")]
        public class DogGenerator : GeneratorBase
        {
            internal DogGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random dog age.
            ///                                 <p>Produces a random dog age</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.age #=> "puppy"</code>
            /// </example>
            [FakerMethod("age")]
            public string Age()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.age", this))));
            }
            /// <summary>
            /// Produces a random dog breed.
            ///                                 <p>Produces a random dog breed</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.breed #=> "Yorkshire Terrier"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.breed", this))));
            }
            /// <summary>
            /// Produces a random coat length.
            ///                                 <p>Produces a random coat length</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.coat_length #=> "short"</code>
            /// </example>
            [FakerMethod("coat_length")]
            public string CoatLength()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.coat_length", this))));
            }
            #warning No implementation defined for method gender();
            /// <summary>
            /// Produces a random dog meme phrase.
            ///                                 <p>Produces a random dog meme phrase</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.meme_phrase #=> "smol pupperino"</code>
            /// </example>
            [FakerMethod("meme_phrase")]
            public string MemePhrase()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.meme_phrase", this))));
            }
            /// <summary>
            /// Produces a random name for a dog.
            ///                                 <p>Produces a random name for a dog</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.name #=> "Spike"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.name", this))));
            }
            /// <summary>
            /// Produces a random size of a dog.
            ///                                 <p>Produces a random size of a dog</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.size #=> "small"</code>
            /// </example>
            [FakerMethod("size")]
            public string Size()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.size", this))));
            }
            /// <summary>
            /// Produces a random sound made by a dog.
            ///                                 <p>Produces a random sound made by a dog</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.sound #=> "woof woof"</code>
            /// </example>
            [FakerMethod("sound")]
            public string Sound()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.dog.sound", this))));
            }
        }
        
        [FakerGenerator("Horse")]
        public class HorseGenerator : GeneratorBase
        {
            internal HorseGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random horse breed.
            ///                                 <p>Produces a random horse breed</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Horse.breed #=> "Spanish Barb see Barb Horse"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.horse.breed", this))));
            }
            /// <summary>
            /// Produces a random name for a horse.
            ///                                 <p>Produces a random name for a horse</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Horse.name #=> "Noir"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("creature.horse.name", this))));
            }
        }
        
    }
    
    [FakerGenerator("Crypto")]
    public class CryptoGenerator : GeneratorBase
    {
        internal CryptoGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method md5();
        #warning No implementation defined for method sha1();
        #warning No implementation defined for method sha256();
        #warning No implementation defined for method sha512();
    }
    
    [FakerGenerator("CryptoCoin")]
    public class CryptoCoinGenerator : GeneratorBase
    {
        internal CryptoCoinGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method acronym();
        /// <summary>
        /// Produces a random crypto coin's name, acronym and logo in an array.
        /// </summary>
        /// <example>
        /// <code>Faker::CryptoCoin.coin_array #=> ["Dash", "DASH", "https://i.imgur.com/2uX91cb.png"]</code>
        /// </example>
        [FakerMethod("coin_array")]
        public List<string> CoinArray()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("crypto_coin.coin", this)))).Split(',').Select(item => item).ToList();
        }
        #warning No implementation defined for method coin_hash();
        #warning No implementation defined for method coin_name();
        #warning No implementation defined for method url_logo();
    }
    
    [FakerGenerator("Currency")]
    public class CurrencyGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("currency.code", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("currency.name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("currency.symbol", this))));
        }
    }
    
    [FakerGenerator("Date")]
    public class DateGenerator : GeneratorBase
    {
        internal DateGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method backward(long days = 365);
        #warning No implementation defined for method between(DateOnly from, DateOnly to);
        #warning No implementation defined for method between_except(DateOnly from, DateOnly to, DateOnly excepted);
        #warning No implementation defined for method birthday(long minAge, long maxAge = 65);
        #warning Failed processing method birthday_date
        #warning No implementation defined for method forward(long from, long days = 365);
        #warning Failed processing method get_date_object
        #warning No implementation defined for method in_date_period(long month, long year = ::Date.today.year);
        #warning No implementation defined for method on_day_of_week_between(UNKNOWN_Symbol day, DateOnly from, DateOnly to);
    }
    
    [FakerGenerator("DcComics")]
    public class DcComicsGenerator : GeneratorBase
    {
        internal DcComicsGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a hero name from DC Comics.
        ///                             <p>Produces a hero name from DC Comics</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::DcComics.hero #=> "Batman"</code>
        /// </example>
        [FakerMethod("hero")]
        public string Hero()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dc_comics.hero", this))));
        }
        /// <summary>
        /// Produces a heroine name from DC Comics.
        ///                             <p>Produces a heroine name from DC Comics</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::DcComics.heroine #=> "Supergirl"</code>
        /// </example>
        [FakerMethod("heroine")]
        public string Heroine()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dc_comics.heroine", this))));
        }
        /// <summary>
        /// Produces a character name from DC Comics.
        ///                             <p>Produces a character name from DC Comics</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::DcComics.name #=> "Clark Kent"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dc_comics.name", this))));
        }
        /// <summary>
        /// Produces a comic book title from DC Comics.
        ///                             <p>Produces a comic book title from DC Comics</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::DcComics.title #=> "Batman: The Long Halloween"</code>
        /// </example>
        [FakerMethod("title")]
        public string Title()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dc_comics.title", this))));
        }
        /// <summary>
        /// Produces a villain name from DC Comics.
        ///                             <p>Produces a villain name from DC Comics</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::DcComics.villain #=> "The Joker"</code>
        /// </example>
        [FakerMethod("villain")]
        public string Villain()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dc_comics.villain", this))));
        }
    }
    
    [FakerGenerator("Demographic")]
    public class DemographicGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("demographic.demonym", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("demographic.educational_attainment", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("demographic.marital_status", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("demographic.race", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("demographic.sex", this))));
        }
    }
    
    [FakerGenerator("Dessert")]
    public class DessertGenerator : GeneratorBase
    {
        internal DessertGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a dessert flavor.
        /// </summary>
        /// <example>
        /// <code>Faker::Dessert.flavor #=> "Salted Caramel"</code>
        /// </example>
        [FakerMethod("flavor")]
        public string Flavor()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dessert.flavor", this))));
        }
        /// <summary>
        /// Produces the name of a dessert topping.
        /// </summary>
        /// <example>
        /// <code>Faker::Dessert.topping #=> "Gummy Bears"</code>
        /// </example>
        [FakerMethod("topping")]
        public string Topping()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dessert.topping", this))));
        }
        /// <summary>
        /// Produces the name of a dessert variety.
        /// </summary>
        /// <example>
        /// <code>Faker::Dessert.variety #=> "Cake"</code>
        /// </example>
        [FakerMethod("variety")]
        public string Variety()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("dessert.variety", this))));
        }
    }
    
    [FakerGenerator("Device")]
    public class DeviceGenerator : GeneratorBase
    {
        internal DeviceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method build_number();
        /// <summary>
        /// Produces the name of a manufacturer for a device.
        /// </summary>
        /// <example>
        /// <code>Faker::Device.manufacturer #=> "Apple"</code>
        /// </example>
        [FakerMethod("manufacturer")]
        public string Manufacturer()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("device.manufacturer", this))));
        }
        /// <summary>
        /// Produces a model name for a device.
        /// </summary>
        /// <example>
        /// <code>Faker::Device.model_name #=> "iPhone 4"</code>
        /// </example>
        [FakerMethod("model_name")]
        public string ModelName()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("device.model_name", this))));
        }
        /// <summary>
        /// Produces the name of a platform for a device.
        /// </summary>
        /// <example>
        /// <code>Faker::Device.platform #=> "webOS"</code>
        /// </example>
        [FakerMethod("platform")]
        public string Platform()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("device.platform", this))));
        }
        /// <summary>
        /// Produces a serial code for a device.
        /// </summary>
        /// <example>
        /// <code>Faker::Device.serial #=> "ejfjnRNInxh0363JC2WM"</code>
        /// </example>
        [FakerMethod("serial")]
        public string Serial()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("device.serial", this))));
        }
        #warning No implementation defined for method version();
    }
    
    [FakerGenerator("DrivingLicence")]
    public class DrivingLicenceGenerator : GeneratorBase
    {
        internal DrivingLicenceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method british_driving_licence(string lastName, string initials, string gender, string dateOfBirth);
        #warning Failed processing method gb_licence_checksum
        #warning Failed processing method gb_licence_padding
        #warning Failed processing method gb_licence_year
        #warning No implementation defined for method northern_irish_driving_licence();
        #warning Failed processing method random_gender
        #warning Failed processing method uk_driving_licence
        /// <summary>
        /// Produces a random USA driving licence number by state code passed.
        /// </summary>
        /// <example>
        /// <code>Faker::DrivingLicence.usa_driving_licence                 #=> "V5598249"
        /// Faker::DrivingLicence.usa_driving_licence('new mexico')   #=> "270692028"
        /// Faker::DrivingLicence.usa_driving_licence('New Mexico')   #=> "68178637"</code>
        /// </example>
        [FakerMethod("usa_driving_licence")]
        public string UsaDrivingLicence()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("driving_licence.usa.#{state.to_s.strip.downcase.gsub(' ', '_')}", this))));
        }
        #warning No implementation defined for method initialize();
    }
    
    [FakerGenerator("Drone")]
    public class DroneGenerator : GeneratorBase
    {
        internal DroneGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Returns the drone battery capacity.
        ///                             <p>Returns the drone battery capacity</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.battery_capacity #=> "3500 mAh"</code>
        /// </example>
        [FakerMethod("battery_capacity")]
        public string BatteryCapacity()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.battery_capacity", this))));
        }
        /// <summary>
        /// Returns the battery type.
        ///                             <p>Returns the battery type</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.battery_type #=> "LiPo 4S"</code>
        /// </example>
        [FakerMethod("battery_type")]
        public string BatteryType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.battery_type", this))));
        }
        /// <summary>
        /// Returns battery voltage.
        ///                             <p>Returns battery voltage</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.battery_voltage #=> "13.2V"</code>
        /// </example>
        [FakerMethod("battery_voltage")]
        public string BatteryVoltage()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.battery_voltage", this))));
        }
        /// <summary>
        /// Returns total battery weight in grams.
        ///                             <p>Returns total battery weight in grams</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.battery_weight #=> "198 g"</code>
        /// </example>
        [FakerMethod("battery_weight")]
        public string BatteryWeight()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.battery_weight", this))));
        }
        /// <summary>
        /// Returns charging temperature for battery in Fahrenheit.
        ///                             <p>Returns charging temperature for battery in Fahrenheit</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.charging_temperature #=> "41-104F"</code>
        /// </example>
        [FakerMethod("charging_temperature")]
        public string ChargingTemperature()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.charging_temperature", this))));
        }
        /// <summary>
        /// Returns max flight time for drone in optimal conditions.
        ///                             <p>Returns max flight time for drone in optimal conditions</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.flight_time #=> "34 min"</code>
        /// </example>
        [FakerMethod("flight_time")]
        public string FlightTime()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.flight_time", this))));
        }
        /// <summary>
        /// Returns camera ISO range for drone.
        ///                             <p>Returns camera ISO range for drone</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.iso #=> "100-3200"</code>
        /// </example>
        [FakerMethod("iso")]
        public string Iso()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.iso", this))));
        }
        /// <summary>
        /// Returns max altitude drone can go above sea level in meters.
        ///                             <p>Returns max altitude drone can go above sea level in meters</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_altitude #=> "5000 m"</code>
        /// </example>
        [FakerMethod("max_altitude")]
        public string MaxAltitude()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_altitude", this))));
        }
        /// <summary>
        /// Returns max angular velocity of drone in degrees/s.
        ///                             <p>Returns max angular velocity of drone in degrees/s</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_angular_velocity #=> "250 degree/s"</code>
        /// </example>
        [FakerMethod("max_angular_velocity")]
        public string MaxAngularVelocity()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_angular_velocity", this))));
        }
        /// <summary>
        /// Returns maximum ascent speed for drone in m/s.
        ///                             <p>Returns maximum ascent speed for drone in m/s</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_ascent_speed #=> "4 m/s"</code>
        /// </example>
        [FakerMethod("max_ascent_speed")]
        public string MaxAscentSpeed()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_ascent_speed", this))));
        }
        /// <summary>
        /// Returns max chargin power required for battery.
        ///                             <p>Returns max chargin power required for battery</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_charging_power #=> "38W"</code>
        /// </example>
        [FakerMethod("max_charging_power")]
        public string MaxChargingPower()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_charging_power", this))));
        }
        /// <summary>
        /// Returns maximum descent speed for drone in m/s.
        ///                             <p>Returns maximum descent speed for drone in m/s</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_descent_speed #=> "4 m/s"</code>
        /// </example>
        [FakerMethod("max_descent_speed")]
        public string MaxDescentSpeed()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_descent_speed", this))));
        }
        /// <summary>
        /// Returns how far drone can go in optimal condition when full charged in meters.
        ///                             <p>Returns how far drone can go in optimal condition when full charged in meters</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_flight_distance #=> "18500 m"</code>
        /// </example>
        [FakerMethod("max_flight_distance")]
        public string MaxFlightDistance()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_flight_distance", this))));
        }
        /// <summary>
        /// Returns max camera resolution in MP".
        ///                             <p>Returns max camera resolution in MP“</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_resolution #=> "48MP"</code>
        /// </example>
        [FakerMethod("max_resolution")]
        public string MaxResolution()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_resolution", this))));
        }
        /// <summary>
        /// Returns max shutter speed for camera.
        ///                             <p>Returns max shutter speed for camera</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_shutter_speed #=> "60s"</code>
        /// </example>
        [FakerMethod("max_shutter_speed")]
        public string MaxShutterSpeed()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_shutter_speed", this))));
        }
        /// <summary>
        /// Returns max horizontal speed by drone in m/s.
        ///                             <p>Returns max horizontal speed by drone in m/s</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_speed #=> "19 m/s"</code>
        /// </example>
        [FakerMethod("max_speed")]
        public string MaxSpeed()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_speed", this))));
        }
        /// <summary>
        /// Returns max tilt angle drone can go in degrees.
        ///                             <p>Returns max tilt angle drone can go in degrees</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_tilt_angle #=> "35 degrees"</code>
        /// </example>
        [FakerMethod("max_tilt_angle")]
        public string MaxTiltAngle()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_tilt_angle", this))));
        }
        /// <summary>
        /// Returns max wind resistance by drone in m/s.
        ///                             <p>Returns max wind resistance by drone in m/s</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.max_wind_resistance #=> "10.5 m/s"</code>
        /// </example>
        [FakerMethod("max_wind_resistance")]
        public string MaxWindResistance()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_wind_resistance", this))));
        }
        /// <summary>
        /// Returns min shutter speed for camera.
        ///                             <p>Returns min shutter speed for camera</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.min_shutter_speed #=> "1/8000s"</code>
        /// </example>
        [FakerMethod("min_shutter_speed")]
        public string MinShutterSpeed()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.min_shutter_speed", this))));
        }
        /// <summary>
        /// Returns random drone name with company.
        ///                             <p>Returns random drone name with company</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.name #=> "DJI Mavic Air 2"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.name", this))));
        }
        /// <summary>
        /// Returns operating temperature for drone in Fahrenheit.
        ///                             <p>Returns operating temperature for drone in Fahrenheit</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.operating_temperature #=> "14-104F"</code>
        /// </example>
        [FakerMethod("operating_temperature")]
        public string OperatingTemperature()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.operating_temperature", this))));
        }
        /// <summary>
        /// Returns photo format for drone.
        ///                             <p>Returns photo format for drone</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.photo_format #=> "JPEG"</code>
        /// </example>
        [FakerMethod("photo_format")]
        public string PhotoFormat()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.photo_format", this))));
        }
        /// <summary>
        /// Returns max and min shutter speed for camera.
        ///                             <p>Returns max and min shutter speed for camera</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.shutter_speed_range #=> "8-1/8000s"</code>
        /// </example>
        [FakerMethod("shutter_speed_range")]
        public string ShutterSpeedRange()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.max_shutter_speed", this))));
        }
        /// <summary>
        /// Returns video format.
        ///                             <p>Returns video format</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.video_format #=> "MP4"</code>
        /// </example>
        [FakerMethod("video_format")]
        public string VideoFormat()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.video_format", this))));
        }
        /// <summary>
        /// Returns total drone weight in grams.
        ///                             <p>Returns total drone weight in grams</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Drone.weight #=> "570 g"</code>
        /// </example>
        [FakerMethod("weight")]
        public string Weight()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("drone.weight", this))));
        }
    }
    
    [FakerGenerator("Educator")]
    public class EducatorGenerator : GeneratorBase
    {
        internal EducatorGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a campus name.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.campus #=> "Vertapple Campus"</code>
        /// </example>
        [FakerMethod("campus")]
        public string Campus()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.campus", this))));
        }
        /// <summary>
        /// Produces a course name.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.course_name #=> "Criminology 101"</code>
        /// </example>
        [FakerMethod("course_name")]
        public string CourseName()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.course_name", this))));
        }
        /// <summary>
        /// Produces a university degree.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.degree #=> "Associate Degree in Criminology"</code>
        /// </example>
        [FakerMethod("degree")]
        public string Degree()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.degree", this))));
        }
        /// <summary>
        /// Produces a primary school.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.primary_school #=> "Brighthurst Elementary School"</code>
        /// </example>
        [FakerMethod("primary_school")]
        public string PrimarySchool()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.primary_school", this))));
        }
        /// <summary>
        /// Produces a secondary school.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.secondary_school #=> "Iceborough Secondary College"</code>
        /// </example>
        [FakerMethod("secondary_school")]
        public string SecondarySchool()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.secondary_school", this))));
        }
        /// <summary>
        /// Produces a university subject.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.subject #=> "Criminology"</code>
        /// </example>
        [FakerMethod("subject")]
        public string Subject()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.subject", this))));
        }
        /// <summary>
        /// Produces a university name.
        /// </summary>
        /// <example>
        /// <code>Faker::Educator.university #=> "Mallowtown Technical College"</code>
        /// </example>
        [FakerMethod("university")]
        public string University()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("educator.university", this))));
        }
    }
    
    [FakerGenerator("ElectricalComponents")]
    public class ElectricalComponentsGenerator : GeneratorBase
    {
        internal ElectricalComponentsGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces an active electrical component.
        /// </summary>
        /// <example>
        /// <code>Faker::ElectricalComponents.active #=> "Transistor"</code>
        /// </example>
        [FakerMethod("active")]
        public string Active()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("electrical_components.active", this))));
        }
        /// <summary>
        /// Produces an electromechanical electrical component.
        /// </summary>
        /// <example>
        /// <code>Faker::ElectricalComponents.electromechanical #=> "Toggle Switch"</code>
        /// </example>
        [FakerMethod("electromechanical")]
        public string Electromechanical()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("electrical_components.electromechanical", this))));
        }
        /// <summary>
        /// Produces a passive electrical component.
        /// </summary>
        /// <example>
        /// <code>Faker::ElectricalComponents.passive #=> "Resistor"</code>
        /// </example>
        [FakerMethod("passive")]
        public string Passive()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("electrical_components.passive", this))));
        }
    }
    
    [FakerGenerator("Emotion")]
    public class EmotionGenerator : GeneratorBase
    {
        internal EmotionGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces an emotion adjective.
        /// </summary>
        /// <example>
        /// <code>Faker::Emotion.adjective # => "nonplussed"</code>
        /// </example>
        [FakerMethod("adjective")]
        public string Adjective()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("emotion.adjective", this))));
        }
        /// <summary>
        /// Produces an emotion noun.
        /// </summary>
        /// <example>
        /// <code>Faker::Emotion.noun #=> "amazement"</code>
        /// </example>
        [FakerMethod("noun")]
        public string Noun()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("emotion.noun", this))));
        }
    }
    
    [FakerGenerator("Esport")]
    public class EsportGenerator : GeneratorBase
    {
        internal EsportGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of an eSports event.
        /// </summary>
        /// <example>
        /// <code>Faker::Esport.event #=> "ESL Cologne"</code>
        /// </example>
        [FakerMethod("event")]
        public string Event()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("esport.events", this))));
        }
        /// <summary>
        /// Produces the name of a game played as an eSport.
        /// </summary>
        /// <example>
        /// <code>Faker::Esport.game #=> "Dota 2"</code>
        /// </example>
        [FakerMethod("game")]
        public string Game()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("esport.games", this))));
        }
        /// <summary>
        /// Produces the name of an eSports league.
        /// </summary>
        /// <example>
        /// <code>Faker::Esport.league #=> "IEM"</code>
        /// </example>
        [FakerMethod("league")]
        public string League()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("esport.leagues", this))));
        }
        /// <summary>
        /// Produces the name of a professional eSports player.
        /// </summary>
        /// <example>
        /// <code>Faker::Esport.player #=> "Crimsix"</code>
        /// </example>
        [FakerMethod("player")]
        public string Player()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("esport.players", this))));
        }
        /// <summary>
        /// Produces the name of an eSports team.
        /// </summary>
        /// <example>
        /// <code>Faker::Esport.team #=> "CLG"</code>
        /// </example>
        [FakerMethod("team")]
        public string Team()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("esport.teams", this))));
        }
    }
    
    [FakerGenerator("Fantasy")]
    public class FantasyGenerator : GeneratorBase
    {
        [FakerMethod("Tolkien")]
        public TolkienGenerator Tolkien { get; }
        internal FantasyGenerator(Faker faker)
                 : base(faker)
        {
            Tolkien = new TolkienGenerator(_faker);
        }
        
        [FakerGenerator("Tolkien")]
        public class TolkienGenerator : GeneratorBase
        {
            internal TolkienGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Tolkien's legendarium.
            ///                                 <p>Produces a character from Tolkien’s legendarium</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.character
            /// #=> "Goldberry"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.characters", this))));
            }
            /// <summary>
            /// Produces a location from Tolkien's legendarium.
            ///                                 <p>Produces a location from Tolkien’s legendarium</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.location
            /// #=> "Helm's Deep"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.locations", this))));
            }
            /// <summary>
            /// Produces the name of a poem from Tolkien's legendarium.
            ///                                 <p>Produces the name of a poem from Tolkien’s legendarium</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.poem
            /// #=> "Chip the glasses and crack the plates"</code>
            /// </example>
            [FakerMethod("poem")]
            public string Poem()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.poems", this))));
            }
            /// <summary>
            /// Produces a race from Tolkien's legendarium.
            ///                                 <p>Produces a race from Tolkien’s legendarium</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.race
            /// #=> "Uruk-hai"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.races", this))));
            }
        }
        
    }
    
    [FakerGenerator("File")]
    public class FileGenerator : GeneratorBase
    {
        internal FileGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method dir(long segmentCount, string root, string directorySeparator = ::File::Separator);
        /// <summary>
        /// Produces a random file extension.
        /// </summary>
        /// <example>
        /// <code>Faker::File.extension #=> "mp3"</code>
        /// </example>
        [FakerMethod("extension")]
        public string Extension()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("file.extension", this))));
        }
        #warning No implementation defined for method file_name(string dir, string name, string ext, string directorySeparator = ::File::Separator);
        /// <summary>
        /// Produces a random mime type.
        /// </summary>
        /// <example>
        /// <code>Faker::File.mime_type #=> "application/pdf"</code>
        /// </example>
        [FakerMethod("mime_type")]
        public string MimeType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("file.mime_type.#{media_type}", this))));
        }
    }
    
    [FakerGenerator("Finance")]
    public class FinanceGenerator : GeneratorBase
    {
        internal FinanceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Returns a random condominium fiscal code.
        /// </summary>
        /// <param name="country">
        /// 
        /// <p>Two capital letter country code to use for the vat number.</p>
        /// 
        /// (default value "'IT'")
        /// </param>
        /// <example>
        /// <code>Faker::Finance.condominium_fiscal_code #=> "012345678"</code>
        /// </example>
        [FakerMethod("condominium_fiscal_code")]
        public string CondominiumFiscalCode(string country = "IT")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("finance.condominium_fiscal_code." + country + "", this))));
        }
        /// <summary>
        /// Produces a random credit card number.
        /// </summary>
        /// <param name="types">
        /// 
        /// <p>Specific credit card type.</p>
        /// 
        /// </param>
        /// <example>
        /// <code>Faker::Finance.credit_card #=> "3018-348979-1853"
        /// Faker::Finance.credit_card(:mastercard) #=> "6771-8921-2291-6236"
        /// Faker::Finance.credit_card(:mastercard, :visa) #=> "4448-8934-1277-7195"</code>
        /// </example>
        [FakerMethod("credit_card")]
        public string CreditCard(string types)
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("finance.credit_card.#{type}", this))));
        }
        /// <summary>
        /// Returns a randomly-selected stock market.
        /// </summary>
        /// <example>
        /// <code>Faker::Finance.stock_market #=> 'NASDAQ'</code>
        /// </example>
        [FakerMethod("stock_market")]
        public string StockMarket()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("finance.stock_market", this))));
        }
        /// <summary>
        /// Returns a randomly-selected stock ticker from a specified market.
        /// </summary>
        /// <param name="markets">
        /// 
        /// <p>The name of the market to choose the ticker from (e.g. NYSE, NASDAQ)</p>
        /// 
        /// </param>
        /// <example>
        /// <code>Faker::Finance.ticker #=> 'AMZN'
        /// Faker::Finance.vat_number('NASDAQ') #=> 'GOOG'</code>
        /// </example>
        [FakerMethod("ticker")]
        public string Ticker(string markets)
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("finance.ticker.#{market}", this))));
        }
        /// <summary>
        /// Produces a random vat number.
        /// </summary>
        /// <param name="country">
        /// 
        /// <p>Two capital letter country code to use for the vat number.</p>
        /// 
        /// (default value "'BR'")
        /// </param>
        /// <example>
        /// <code>Faker::Finance.vat_number #=> "BR38.395.329/2471-83"
        /// Faker::Finance.vat_number('DE') #=> "DE593306671"
        /// Faker::Finance.vat_number('ZA') #=> "ZA79494416181"</code>
        /// </example>
        [FakerMethod("vat_number")]
        public string VatNumber(string country = "BR")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("finance.vat_number." + country + "", this))));
        }
        #warning Failed processing method vat_number_keys
    }
    
    [FakerGenerator("Food")]
    public class FoodGenerator : GeneratorBase
    {
        internal FoodGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Retrieves an allergen.
        /// </summary>
        /// <example>
        /// <code>Faker::Food.allergen #=> "Peanuts"</code>
        /// </example>
        [FakerMethod("allergen")]
        public string Allergen()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.allergens", this))));
        }
        /// <summary>
        /// Retrieves a description about some dish.
        ///                             <p>Retrieves a description about some dish</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.description #=> "Breaded fried chicken with waffles. Served with maple syrup."</code>
        /// </example>
        [FakerMethod("description")]
        public string Description()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.descriptions", this))));
        }
        /// <summary>
        /// Retrieves a typical dish from each country.
        /// </summary>
        /// <example>
        /// <code>Faker::Food.dish #=> "Feijoada"</code>
        /// </example>
        [FakerMethod("dish")]
        public string Dish()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.dish", this))));
        }
        /// <summary>
        /// Retrieves ethnic category.
        ///                             <p>Retrieves ethnic category</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.ethnic_category #=> "Indian cuisine"</code>
        /// </example>
        [FakerMethod("ethnic_category")]
        public string EthnicCategory()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.ethnic_category", this))));
        }
        /// <summary>
        /// Retrieves a fruit.
        ///                             <p>Retrieves a fruit</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.fruits #=> "Papaya"</code>
        /// </example>
        [FakerMethod("fruits")]
        public string Fruits()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.fruits", this))));
        }
        /// <summary>
        /// Retrieves an ingredient.
        ///                             <p>Retrieves an ingredient</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.ingredient #=> "Olives"</code>
        /// </example>
        [FakerMethod("ingredient")]
        public string Ingredient()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.ingredients", this))));
        }
        /// <summary>
        /// Retrieves cooking measures.
        ///                             <p>Retrieves cooking measures</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.measurement #=> "1/3"</code>
        /// </example>
        [FakerMethod("measurement")]
        public string Measurement()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.measurement_sizes", this))));
        }
        /// <summary>
        /// Retrieves metric measurements.
        ///                             <p>Retrieves metric measurements</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.metric_measurement #=> "centiliter"</code>
        /// </example>
        [FakerMethod("metric_measurement")]
        public string MetricMeasurement()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.metric_measurements", this))));
        }
        /// <summary>
        /// Retrieves some random spice.
        ///                             <p>Retrieves some random spice</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.spice #=> "Garlic Chips"</code>
        /// </example>
        [FakerMethod("spice")]
        public string Spice()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.spices", this))));
        }
        /// <summary>
        /// Retrieves a vegetable.
        ///                             <p>Retrieves a vegetable</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Food.vegetables #=> "Broccolini"</code>
        /// </example>
        [FakerMethod("vegetables")]
        public string Vegetables()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("food.vegetables", this))));
        }
    }
    
    [FakerGenerator("FunnyName")]
    public class FunnyNameGenerator : GeneratorBase
    {
        internal FunnyNameGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Retrieves a funny four word name.
        /// </summary>
        /// <example>
        /// <code>Faker::FunnyName.four_word_name #=> "Maude L. T. Ford"</code>
        /// </example>
        [FakerMethod("four_word_name")]
        public string FourWordName()
        {
            return this.Resolve("funny_name.name", this);
        }
        /// <summary>
        /// Retrieves a funny name.
        /// </summary>
        /// <example>
        /// <code>Faker::FunnyName.name #=> "Sam Pull"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("funny_name.name", this))));
        }
        /// <summary>
        /// Retrieves a funny name with an initial.
        /// </summary>
        /// <example>
        /// <code>Faker::FunnyName.name_with_initial #=> "Heather N. Yonn"</code>
        /// </example>
        [FakerMethod("name_with_initial")]
        public string NameWithInitial()
        {
            return this.Resolve("funny_name.name", this);
        }
        /// <summary>
        /// Retrieves a funny three word name.
        /// </summary>
        /// <example>
        /// <code>Faker::FunnyName.three_word_name #=> "Carson O. Gin"</code>
        /// </example>
        [FakerMethod("three_word_name")]
        public string ThreeWordName()
        {
            return this.Resolve("funny_name.name", this);
        }
        /// <summary>
        /// Retrieves a funny two word name.
        /// </summary>
        /// <example>
        /// <code>Faker::FunnyName.two_word_name #=> "Shirley Knot"</code>
        /// </example>
        [FakerMethod("two_word_name")]
        public string TwoWordName()
        {
            return this.Resolve("funny_name.name", this);
        }
    }
    
    [FakerGenerator("Game")]
    public class GameGenerator : GeneratorBase
    {
        internal GameGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a video game genre.
        /// </summary>
        /// <example>
        /// <code>Faker::Game.genre #=> "Real-time strategy"</code>
        /// </example>
        [FakerMethod("genre")]
        public string Genre()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("game.genre", this))));
        }
        /// <summary>
        /// Produces the name of a video game console or platform.
        /// </summary>
        /// <example>
        /// <code>Faker::Game.platform #=> "Nintendo Switch"</code>
        /// </example>
        [FakerMethod("platform")]
        public string Platform()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("game.platform", this))));
        }
        /// <summary>
        /// Produces the name of a video game.
        /// </summary>
        /// <example>
        /// <code>Faker::Game.title #=> "Half-Life 2"</code>
        /// </example>
        [FakerMethod("title")]
        public string Title()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("game.title", this))));
        }
    }
    
    [FakerGenerator("Games")]
    public class GamesGenerator : GeneratorBase
    {
        [FakerMethod("ClashOfClans")]
        public ClashOfClansGenerator ClashOfClans { get; }
        [FakerMethod("Control")]
        public ControlGenerator Control { get; }
        [FakerMethod("DnD")]
        public DnDGenerator DnD { get; }
        [FakerMethod("Dota")]
        public DotaGenerator Dota { get; }
        [FakerMethod("ElderScrolls")]
        public ElderScrollsGenerator ElderScrolls { get; }
        [FakerMethod("Fallout")]
        public FalloutGenerator Fallout { get; }
        [FakerMethod("FinalFantasyXIV")]
        public FinalFantasyXIVGenerator FinalFantasyXIV { get; }
        [FakerMethod("HalfLife")]
        public HalfLifeGenerator HalfLife { get; }
        [FakerMethod("Heroes")]
        public HeroesGenerator Heroes { get; }
        [FakerMethod("HeroesOfTheStorm")]
        public HeroesOfTheStormGenerator HeroesOfTheStorm { get; }
        [FakerMethod("LeagueOfLegends")]
        public LeagueOfLegendsGenerator LeagueOfLegends { get; }
        [FakerMethod("Minecraft")]
        public MinecraftGenerator Minecraft { get; }
        [FakerMethod("Myst")]
        public MystGenerator Myst { get; }
        [FakerMethod("Overwatch")]
        public OverwatchGenerator Overwatch { get; }
        [FakerMethod("Pokemon")]
        public PokemonGenerator Pokemon { get; }
        [FakerMethod("SonicTheHedgehog")]
        public SonicTheHedgehogGenerator SonicTheHedgehog { get; }
        [FakerMethod("StreetFighter")]
        public StreetFighterGenerator StreetFighter { get; }
        [FakerMethod("SuperMario")]
        public SuperMarioGenerator SuperMario { get; }
        [FakerMethod("SuperSmashBros")]
        public SuperSmashBrosGenerator SuperSmashBros { get; }
        [FakerMethod("Tarkov")]
        public TarkovGenerator Tarkov { get; }
        [FakerMethod("Touhou")]
        public TouhouGenerator Touhou { get; }
        [FakerMethod("WarhammerFantasy")]
        public WarhammerFantasyGenerator WarhammerFantasy { get; }
        [FakerMethod("Witcher")]
        public WitcherGenerator Witcher { get; }
        [FakerMethod("WorldOfWarcraft")]
        public WorldOfWarcraftGenerator WorldOfWarcraft { get; }
        [FakerMethod("Zelda")]
        public ZeldaGenerator Zelda { get; }
        internal GamesGenerator(Faker faker)
                 : base(faker)
        {
            ClashOfClans = new ClashOfClansGenerator(_faker);
            Control = new ControlGenerator(_faker);
            DnD = new DnDGenerator(_faker);
            Dota = new DotaGenerator(_faker);
            ElderScrolls = new ElderScrollsGenerator(_faker);
            Fallout = new FalloutGenerator(_faker);
            FinalFantasyXIV = new FinalFantasyXIVGenerator(_faker);
            HalfLife = new HalfLifeGenerator(_faker);
            Heroes = new HeroesGenerator(_faker);
            HeroesOfTheStorm = new HeroesOfTheStormGenerator(_faker);
            LeagueOfLegends = new LeagueOfLegendsGenerator(_faker);
            Minecraft = new MinecraftGenerator(_faker);
            Myst = new MystGenerator(_faker);
            Overwatch = new OverwatchGenerator(_faker);
            Pokemon = new PokemonGenerator(_faker);
            SonicTheHedgehog = new SonicTheHedgehogGenerator(_faker);
            StreetFighter = new StreetFighterGenerator(_faker);
            SuperMario = new SuperMarioGenerator(_faker);
            SuperSmashBros = new SuperSmashBrosGenerator(_faker);
            Tarkov = new TarkovGenerator(_faker);
            Touhou = new TouhouGenerator(_faker);
            WarhammerFantasy = new WarhammerFantasyGenerator(_faker);
            Witcher = new WitcherGenerator(_faker);
            WorldOfWarcraft = new WorldOfWarcraftGenerator(_faker);
            Zelda = new ZeldaGenerator(_faker);
        }
        
        [FakerGenerator("ClashOfClans")]
        public class ClashOfClansGenerator : GeneratorBase
        {
            internal ClashOfClansGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a defensive building from Clash Of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ClashOfClans.defensive_building #=> "Cannon"</code>
            /// </example>
            [FakerMethod("defensive_building")]
            public string DefensiveBuilding()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.clash_of_clans.defensive_buildings", this))));
            }
            /// <summary>
            /// Produces the name of a rank from Clash Of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ClashOfClans.rank #=> "Legend"</code>
            /// </example>
            [FakerMethod("rank")]
            public string Rank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.clash_of_clans.ranks", this))));
            }
            /// <summary>
            /// Produces the name of a troop from Clash of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ClashOfClans.troop #=> "Barbarian"</code>
            /// </example>
            [FakerMethod("troop")]
            public string Troop()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.clash_of_clans.troops", this))));
            }
        }
        
        [FakerGenerator("Control")]
        public class ControlGenerator : GeneratorBase
        {
            internal ControlGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an Altered Item.
            ///                                 <p>Produces the name of an Altered Item</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.altered_item #=> "Rubber Duck"</code>
            /// </example>
            [FakerMethod("altered_item")]
            public string AlteredItem()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.altered_item", this))));
            }
            /// <summary>
            /// Produces the location of an Altered World Event (AWE).
            ///                                 <p>Produces the location of an Altered World Event (AWE)</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.altered_world_event #=> "Ordinary, Wisconsin"</code>
            /// </example>
            [FakerMethod("altered_world_event")]
            public string AlteredWorldEvent()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.altered_world_event", this))));
            }
            /// <summary>
            /// Produces the name of a character from Control.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.character #=> "Jesse Faden"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.character", this))));
            }
            /// <summary>
            /// Produces a line from the Hiss incantation.
            ///                                 <p>Produces a line from the Hiss incantation</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.hiss #=> "Push the fingers through the surface into the wet."</code>
            /// </example>
            [FakerMethod("hiss")]
            public string Hiss()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.hiss", this))));
            }
            /// <summary>
            /// Produces the name of a location from Control.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.location #=> "Dimensional Research"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.location", this))));
            }
            /// <summary>
            /// Produces the name of an Object of Power (OoP).
            ///                                 <p>Produces the name of an Object of Power (OoP)</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.object_of_power #=> "Hotline"</code>
            /// </example>
            [FakerMethod("object_of_power")]
            public string ObjectOfPower()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.object_of_power", this))));
            }
            /// <summary>
            /// Produces a quote from Control.
            ///                                 <p>Produces a quote from Control</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.quote #=> "He never liked fridge duty"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.quote", this))));
            }
            /// <summary>
            /// < Produces a line/quote/message from The Board >.
            ///                                 <p>&lt; Produces a line/quote/message from The Board &gt;</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Control.the_board #=> "< You/We wield the Gun/You. The Board appoints you. Congratulations, Director. >"</code>
            /// </example>
            [FakerMethod("the_board")]
            public string TheBoard()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.control.the_board", this))));
            }
        }
        
        [FakerGenerator("DnD")]
        public class DnDGenerator : GeneratorBase
        {
            internal DnDGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an alignment from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.alignment #=> "Lawful Neutral"</code>
            /// </example>
            [FakerMethod("alignment")]
            public string Alignment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.alignments", this))));
            }
            /// <summary>
            /// Produces the name of a background from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.background #=> "Urchin"</code>
            /// </example>
            [FakerMethod("background")]
            public string Background()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.backgrounds", this))));
            }
            /// <summary>
            /// Produces the name of a city from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.city #=> "Earthfast"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.cities", this))));
            }
            /// <summary>
            /// Produces the first name of a character or monster from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.name #=> "Eilonwy"</code>
            /// </example>
            [FakerMethod("first_name")]
            public string FirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.name.first_name", this))));
            }
            /// <summary>
            /// Produces the name of a class from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.klass #=> "Warlock"</code>
            /// </example>
            [FakerMethod("klass")]
            public string Klass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.klasses", this))));
            }
            /// <summary>
            /// Produces the name of a language from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.language #=> "Gnomish"</code>
            /// </example>
            [FakerMethod("language")]
            public string Language()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.languages", this))));
            }
            /// <summary>
            /// Produces a last name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.last_name #=> "Leafwhisper"</code>
            /// </example>
            [FakerMethod("last_name")]
            public string LastName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.name.last_name", this))));
            }
            /// <summary>
            /// Produces the name of a melee weapon from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.melee_weapon #=> "Handaxe"</code>
            /// </example>
            [FakerMethod("melee_weapon")]
            public string MeleeWeapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.melee_weapons", this))));
            }
            /// <summary>
            /// Produces the name of a monster from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.monster #=> "Manticore"</code>
            /// </example>
            [FakerMethod("monster")]
            public string Monster()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.monsters", this))));
            }
            /// <summary>
            /// Produces a full name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.name #=> "Drakon Blackthorn"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.name.first_name", this))));
            }
            /// <summary>
            /// Produces the name of a race from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.races #=> "Dwarf"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.races", this))));
            }
            /// <summary>
            /// Produces the name of a ranged weapon from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.ranged_weapon #=> "Shortbow"</code>
            /// </example>
            [FakerMethod("ranged_weapon")]
            public string RangedWeapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.ranged_weapons", this))));
            }
            /// <summary>
            /// Produces a last name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DnD.title_name #=> "Corvus the Cunning"</code>
            /// </example>
            [FakerMethod("title_name")]
            public string TitleName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dnd.name.first_name", this))));
            }
        }
        
        [FakerGenerator("Dota")]
        public class DotaGenerator : GeneratorBase
        {
            internal DotaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a building from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Dota.building #=> "Tower"</code>
            /// </example>
            [FakerMethod("building")]
            public string Building()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota.building", this))));
            }
            /// <summary>
            /// Produces the name of a hero from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Dota.hero #=> "Abaddon"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota.hero", this))));
            }
            /// <summary>
            /// Produces the name of an item from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Dota.item #=> "Armlet of Mordiggian"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota.item", this))));
            }
            /// <summary>
            /// Produces the name of a professional Dota player.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Dota.player #=> "Dendi"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota.player", this))));
            }
            /// <summary>
            /// Produces the name of a hero from Dota.
            /// </summary>
            /// <param name="hero">
            /// 
            /// <p>The name of a Dota hero.</p>
            /// 
            /// (default value "'abaddon'")
            /// </param>
            /// <example>
            /// <code>Faker::Games::Dota.quote #=> "You have called death upon yourself."
            /// Faker::Games::Dota.quote(hero: 'alchemist') #=> "Better living through alchemy!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote(string hero = "abaddon")
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota." + hero + ".quote", this))));
            }
            /// <summary>
            /// Produces the name of a professional Dota team.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Dota.team #=> "Evil Geniuses"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.dota.team", this))));
            }
        }
        
        [FakerGenerator("ElderScrolls")]
        public class ElderScrollsGenerator : GeneratorBase
        {
            internal ElderScrollsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a city from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.city #=> "Whiterun"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.city", this))));
            }
            /// <summary>
            /// Produces the name of a creature from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.creature #=> "Frost Troll"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.creature", this))));
            }
            /// <summary>
            /// Produces the name of a dragon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.dragon #=> "Blood Dragon"</code>
            /// </example>
            [FakerMethod("dragon")]
            public string Dragon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.dragon", this))));
            }
            /// <summary>
            /// Produces a first name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.first_name #=> "Balgruuf"</code>
            /// </example>
            [FakerMethod("first_name")]
            public string FirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.first_name", this))));
            }
            /// <summary>
            /// Produces a weapon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.jewelry #=> "Silver Ruby Ring"</code>
            /// </example>
            [FakerMethod("jewelry")]
            public string Jewelry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.jewelry", this))));
            }
            /// <summary>
            /// Produces a last name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.last_name #=> "The Old"</code>
            /// </example>
            [FakerMethod("last_name")]
            public string LastName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.last_name", this))));
            }
            /// <summary>
            /// Produces a randomly generated name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.name #=> "Balgruuf The Old"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.first_name", this))));
            }
            /// <summary>
            /// Produces the name of a race from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.race #=> "Argonian"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.race", this))));
            }
            /// <summary>
            /// Produces the name of a region from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.region #=> "Cyrodiil"</code>
            /// </example>
            [FakerMethod("region")]
            public string Region()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.region", this))));
            }
            /// <summary>
            /// Produces a weapon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::ElderScrolls.weapon #=> "Elven Bow"</code>
            /// </example>
            [FakerMethod("weapon")]
            public string Weapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.elder_scrolls.weapon", this))));
            }
        }
        
        [FakerGenerator("Fallout")]
        public class FalloutGenerator : GeneratorBase
        {
            internal FalloutGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Fallout.character #=> "Liberty Prime"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.fallout.characters", this))));
            }
            /// <summary>
            /// Produces the name of a faction from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Fallout.faction #=> "Brotherhood of Steel"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.fallout.factions", this))));
            }
            /// <summary>
            /// Produces the name of a location from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Fallout.location #=> "New Vegas"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.fallout.locations", this))));
            }
            /// <summary>
            /// Produces a quote from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Fallout.quote
            /// #=> "Democracy is non-negotiable"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.fallout.quotes", this))));
            }
        }
        
        [FakerGenerator("FinalFantasyXIV")]
        public class FinalFantasyXIVGenerator : GeneratorBase
        {
            internal FinalFantasyXIVGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from FFXIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::FinalFantasyXIV.character #=> "Y'shtola Rhul"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.final_fantasy_xiv.characters", this))));
            }
            /// <summary>
            /// Produces a data center from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::FinalFantasyXIV.data_center #=> "Aether"</code>
            /// </example>
            [FakerMethod("data_center")]
            public string DataCenter()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.final_fantasy_xiv.data_centers", this))));
            }
            /// <summary>
            /// Produces a job name from Final Fantasy XIV.
            ///                                 <p>Either a battle or non-battle playable job.</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Games::FinalFantasyXIV.job #=> "Paladin"</code>
            /// </example>
            [FakerMethod("job")]
            public string Job()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.final_fantasy_xiv.jobs", this))));
            }
            /// <summary>
            /// Produces the name of a playable race from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::FinalFantasyXIV.race #=> "Miqo'te"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.final_fantasy_xiv.races", this))));
            }
            /// <summary>
            /// Produces a geographical zone from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::FinalFantasyXIV.zone #=> "Eastern La Noscea"</code>
            /// </example>
            [FakerMethod("zone")]
            public string Zone()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.final_fantasy_xiv.zones", this))));
            }
        }
        
        [FakerGenerator("HalfLife")]
        public class HalfLifeGenerator : GeneratorBase
        {
            internal HalfLifeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HalfLife.character #=> "Gordon Freeman"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.half_life.character", this))));
            }
            /// <summary>
            /// Produces the name of an enemy from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HalfLife.enemy #=> "Headcrab"</code>
            /// </example>
            [FakerMethod("enemy")]
            public string Enemy()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.half_life.enemy", this))));
            }
            /// <summary>
            /// Produces the name of a location from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HalfLife.location #=> "Black Mesa Research Facility"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.half_life.location", this))));
            }
        }
        
        [FakerGenerator("Heroes")]
        public class HeroesGenerator : GeneratorBase
        {
            internal HeroesGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an artifact from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Heroes.artifact #=> "Armageddon's Blade"</code>
            /// </example>
            [FakerMethod("artifact")]
            public string Artifact()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes.artifacts", this))));
            }
            /// <summary>
            /// Produces the name of a class from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Heroes.klass #=> "Knight"</code>
            /// </example>
            [FakerMethod("klass")]
            public string Klass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes.klasses", this))));
            }
            /// <summary>
            /// Produces the name of a hero from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Heroes.name #=> "Christian"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes.names", this))));
            }
            /// <summary>
            /// Produces the name of a specialty from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Heroes.specialty #=> "Ballista"</code>
            /// </example>
            [FakerMethod("specialty")]
            public string Specialty()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes.specialties", this))));
            }
        }
        
        [FakerGenerator("HeroesOfTheStorm")]
        public class HeroesOfTheStormGenerator : GeneratorBase
        {
            internal HeroesOfTheStormGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a battleground from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HeroesOfTheStorm.battleground #=> "Towers of Doom"</code>
            /// </example>
            [FakerMethod("battleground")]
            public string Battleground()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes_of_the_storm.battlegrounds", this))));
            }
            #warning No implementation defined for method class();
            /// <summary>
            /// Produces a class name from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HeroesOfTheStorm.class_name #=> "Support"</code>
            /// </example>
            [FakerMethod("class_name")]
            public string ClassName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes_of_the_storm.class_names", this))));
            }
            /// <summary>
            /// Produces a hero from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HeroesOfTheStorm.hero #=> "Illidan"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes_of_the_storm.heroes", this))));
            }
            /// <summary>
            /// Produces a quote from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::HeroesOfTheStorm.quote #=> "MEAT!!!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("heroes_of_the_storm.quotes", this))));
            }
        }
        
        [FakerGenerator("LeagueOfLegends")]
        public class LeagueOfLegendsGenerator : GeneratorBase
        {
            internal LeagueOfLegendsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a champion from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.champion #=> "Jarvan IV"</code>
            /// </example>
            [FakerMethod("champion")]
            public string Champion()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.champion", this))));
            }
            /// <summary>
            /// Produces a location from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.location #=> "Demacia"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.location", this))));
            }
            /// <summary>
            /// Produces a mastery from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.masteries #=> "Double Edged Sword"</code>
            /// </example>
            [FakerMethod("masteries")]
            public string Masteries()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.masteries", this))));
            }
            /// <summary>
            /// Produces a quote from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.quote #=> "Purge the unjust."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.quote", this))));
            }
            /// <summary>
            /// Produces a rank from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.rank #=> "Bronze V"</code>
            /// </example>
            [FakerMethod("rank")]
            public string Rank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.rank", this))));
            }
            /// <summary>
            /// Produces a summoner spell from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::LeagueOfLegends.summoner_spell #=> "Flash"</code>
            /// </example>
            [FakerMethod("summoner_spell")]
            public string SummonerSpell()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.league_of_legends.summoner_spell", this))));
            }
        }
        
        [FakerGenerator("Minecraft")]
        public class MinecraftGenerator : GeneratorBase
        {
            internal MinecraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an achievement from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.achievement #=> "Time to Mine!"</code>
            /// </example>
            [FakerMethod("achievement")]
            public string Achievement()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.achievement", this))));
            }
            /// <summary>
            /// Produces the name of a biome from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.biome #=> "Jungle"</code>
            /// </example>
            [FakerMethod("biome")]
            public string Biome()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.biome", this))));
            }
            /// <summary>
            /// Produces the name of a block from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.block #=> "Stone"</code>
            /// </example>
            [FakerMethod("block")]
            public string Block()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.blocks", this))));
            }
            /// <summary>
            /// Produces the name of a enchantment from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.enchantment #=> "Fire Protection"</code>
            /// </example>
            [FakerMethod("enchantment")]
            public string Enchantment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.enchantment", this))));
            }
            /// <summary>
            /// Produces the name of a game mode from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.game_mode #=> "Survival"</code>
            /// </example>
            [FakerMethod("game_mode")]
            public string GameMode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.game_mode", this))));
            }
            /// <summary>
            /// Produces the name of an item from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.item #=> "Iron Shovel"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.items", this))));
            }
            /// <summary>
            /// Produces the name of a mob from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.mob #=> "Sheep"</code>
            /// </example>
            [FakerMethod("mob")]
            public string Mob()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.mobs", this))));
            }
            /// <summary>
            /// Produces the name of a status effect from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Minecraft.status_effect #=> "Weakness"</code>
            /// </example>
            [FakerMethod("status_effect")]
            public string StatusEffect()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.minecraft.status_effect", this))));
            }
        }
        
        [FakerGenerator("Myst")]
        public class MystGenerator : GeneratorBase
        {
            internal MystGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an age from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Myst.age #=> "Relto"</code>
            /// </example>
            [FakerMethod("age")]
            public string Age()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.myst.ages", this))));
            }
            /// <summary>
            /// Produces the name of a character from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Myst.character #=> "Gehn"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.myst.characters", this))));
            }
            /// <summary>
            /// Produces the name of a creature from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Myst.creature #=> "squee"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.myst.creatures", this))));
            }
            /// <summary>
            /// Produces the name of a game from the Myst series.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Myst.game #=> "Myst III: Exile"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.myst.games", this))));
            }
            /// <summary>
            /// Produces a quote from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Myst.quote #=> "I realized, the moment I fell into the fissure, that the Book would not be destroyed as I had planned."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.myst.quotes", this))));
            }
        }
        
        [FakerGenerator("Overwatch")]
        public class OverwatchGenerator : GeneratorBase
        {
            internal OverwatchGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a hero from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Overwatch.hero #=> "Tracer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.overwatch.heroes", this))));
            }
            /// <summary>
            /// Produces the name of a location from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Overwatch.location #=> "Numbani"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.overwatch.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Overwatch.quote #=> "It's high noon"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.overwatch.quotes", this))));
            }
        }
        
        [FakerGenerator("Pokemon")]
        public class PokemonGenerator : GeneratorBase
        {
            internal PokemonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a location from Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Pokemon.location #=> "Pallet Town"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.pokemon.locations", this))));
            }
            /// <summary>
            /// Produces a move from Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Pokemon.move #=> "Thunder Shock"</code>
            /// </example>
            [FakerMethod("move")]
            public string Move()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.pokemon.moves", this))));
            }
            /// <summary>
            /// Produces the name of a Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Pokemon.name #=> "Pikachu"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.pokemon.names", this))));
            }
        }
        
        [FakerGenerator("SonicTheHedgehog")]
        public class SonicTheHedgehogGenerator : GeneratorBase
        {
            internal SonicTheHedgehogGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Sonic the Hedgehog.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SonicTheHedgehog.character #=> "Sonic the Hedgehog"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.sonic_the_hedgehog.character", this))));
            }
            /// <summary>
            /// Produces the name of a game from the Sonic the Hedgehog series.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SonicTheHedgehog.game #=> "Waku Waku Sonic Patrol Car"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.sonic_the_hedgehog.game", this))));
            }
            /// <summary>
            /// Produces the name of a zone from Sonic the Hedgehog.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SonicTheHedgehog.zone #=> "Green Hill Zone"</code>
            /// </example>
            [FakerMethod("zone")]
            public string Zone()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.sonic_the_hedgehog.zone", this))));
            }
        }
        
        [FakerGenerator("StreetFighter")]
        public class StreetFighterGenerator : GeneratorBase
        {
            internal StreetFighterGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a playable character from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::StreetFighter.character #=> "Ryu"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.street_fighter.characters", this))));
            }
            /// <summary>
            /// Produces the name of a move from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::StreetFighter.move #=> "Shoryuken"</code>
            /// </example>
            [FakerMethod("move")]
            public string Move()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.street_fighter.moves", this))));
            }
            /// <summary>
            /// Produces a quote from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::StreetFighter.quote #=> "Go home and be a family man."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.street_fighter.quotes", this))));
            }
            /// <summary>
            /// Produces the name of a stage from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::StreetFighter.stage #=> "Volcanic Rim"</code>
            /// </example>
            [FakerMethod("stage")]
            public string Stage()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.street_fighter.stages", this))));
            }
        }
        
        [FakerGenerator("SuperMario")]
        public class SuperMarioGenerator : GeneratorBase
        {
            internal SuperMarioGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Super Mario character.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SuperMario.character #=> "Luigi"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.super_mario.characters", this))));
            }
            /// <summary>
            /// Produces the name of a Super Mario game.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SuperMario.game #=> "Super Mario Odyssey"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.super_mario.games", this))));
            }
            /// <summary>
            /// Produces the name of a Super Mario location.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SuperMario.location #=> "Kong City"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.super_mario.locations", this))));
            }
        }
        
        [FakerGenerator("SuperSmashBros")]
        public class SuperSmashBrosGenerator : GeneratorBase
        {
            internal SuperSmashBrosGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a fighter from the Smash Bros games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SuperSmashBros.fighter #=> "Mario"</code>
            /// </example>
            [FakerMethod("fighter")]
            public string Fighter()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.super_smash_bros.fighter", this))));
            }
            /// <summary>
            /// Produces the name of a stage from the Smash Bros games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::SuperSmashBros.stage #=> "Final Destination"</code>
            /// </example>
            [FakerMethod("stage")]
            public string Stage()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.super_smash_bros.stage", this))));
            }
        }
        
        [FakerGenerator("Tarkov")]
        public class TarkovGenerator : GeneratorBase
        {
            internal TarkovGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random boss from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.boss #=> "Tagilla"</code>
            /// </example>
            [FakerMethod("boss")]
            public string Boss()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.bosses", this))));
            }
            /// <summary>
            /// Produces a random faction from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.faction #=> "USEC"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.factions", this))));
            }
            /// <summary>
            /// Produces a random quest from Fence from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.fence_quest #=> "Compensation for Damage - Wager"</code>
            /// </example>
            [FakerMethod("fence_quest")]
            public string FenceQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.fence", this))));
            }
            /// <summary>
            /// Produces a random item from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.item #=> "Diary"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.items", this))));
            }
            /// <summary>
            /// Produces a random quest from Jaeger from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.jaeger_quest #=> "The Tarkov Shooter - Part 1"</code>
            /// </example>
            [FakerMethod("jaeger_quest")]
            public string JaegerQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.jaeger", this))));
            }
            /// <summary>
            /// Produces a random location from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.location #=> "Customs"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.locations", this))));
            }
            /// <summary>
            /// Produces a random quest from Mechanic from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.mechanic_quest #=> "Signal - Part 4"</code>
            /// </example>
            [FakerMethod("mechanic_quest")]
            public string MechanicQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.mechanic", this))));
            }
            /// <summary>
            /// Produces a random quest from Peacekeeper from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.peacekeeper_quest #=> "Overpopulation"</code>
            /// </example>
            [FakerMethod("peacekeeper_quest")]
            public string PeacekeeperQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.peacekeeper", this))));
            }
            /// <summary>
            /// Produces a random quest from Prapor from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.prapor_quest #=> "Easy Job - Part 2</code>
            /// </example>
            [FakerMethod("prapor_quest")]
            public string PraporQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.prapor", this))));
            }
            /// <summary>
            /// Produces a random quest from a random trader from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.quest #=> "The Key to Success"</code>
            /// </example>
            [FakerMethod("quest")]
            public string Quest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.#{@traders.sample}", this))));
            }
            /// <summary>
            /// Produces a random quest from Ragman from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.ragman_quest #=> "Hot Delivery"</code>
            /// </example>
            [FakerMethod("ragman_quest")]
            public string RagmanQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.ragman", this))));
            }
            /// <summary>
            /// Produces a random quest from Skier from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.skier_quest #=> "Safe Corridor"</code>
            /// </example>
            [FakerMethod("skier_quest")]
            public string SkierQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.skier", this))));
            }
            /// <summary>
            /// Produces a random quest from Therapist from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.therapist_quest #=> "Supply Plans"</code>
            /// </example>
            [FakerMethod("therapist_quest")]
            public string TherapistQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.quests.therapist", this))));
            }
            /// <summary>
            /// Produces a random trader from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.trader #=> "Prapor"</code>
            /// </example>
            [FakerMethod("trader")]
            public string Trader()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.traders", this))));
            }
            /// <summary>
            /// Produces a random weapon from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Tarkov.weapon #=> "AK-74N"</code>
            /// </example>
            [FakerMethod("weapon")]
            public string Weapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tarkov.weapons", this))));
            }
        }
        
        [FakerGenerator("Touhou")]
        public class TouhouGenerator : GeneratorBase
        {
            internal TouhouGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Touhou.character #=> "Sanae Kochiya"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.touhou.characters", this))));
            }
            /// <summary>
            /// Produces the name of a Touhou game.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Touhou.game #=> "Mountain of Faith"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.touhou.games", this))));
            }
            /// <summary>
            /// Produces the name of a location from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Touhou.location #=> "Moriya Shrine"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.touhou.locations", this))));
            }
            /// <summary>
            /// Produces the name of a song from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Touhou.song #=> "Faith Is for the Transient People"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.touhou.songs", this))));
            }
            /// <summary>
            /// Produces the name of a spell card from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Touhou.spell_card #=> 'Esoterica "Gray Thaumaturgy"'</code>
            /// </example>
            [FakerMethod("spell_card")]
            public string SpellCard()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.touhou.spell_cards", this))));
            }
        }
        
        [FakerGenerator("WarhammerFantasy")]
        public class WarhammerFantasyGenerator : GeneratorBase
        {
            internal WarhammerFantasyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a creature from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WarhammerFantasy.creature #=> "Hydra"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.warhammer_fantasy.creatures", this))));
            }
            /// <summary>
            /// Produces a faction from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WarhammerFantasy.faction #=> "Bretonnia"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.warhammer_fantasy.factions", this))));
            }
            /// <summary>
            /// Produces the name of a hero from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WarhammerFantasy.hero #=> "Sigmar Heldenhammer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.warhammer_fantasy.heros", this))));
            }
            /// <summary>
            /// Produces a location from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WarhammerFantasy.location #=> "Lustria"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.warhammer_fantasy.locations", this))));
            }
            /// <summary>
            /// Produces a quote from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WarhammerFantasy.quote #=> "The softest part of a castle is the belly of the man inside."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.warhammer_fantasy.quotes", this))));
            }
        }
        
        [FakerGenerator("Witcher")]
        public class WitcherGenerator : GeneratorBase
        {
            internal WitcherGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a book from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.book #=> "Sword of Destiny"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.books", this))));
            }
            /// <summary>
            /// Produces the name of a character from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.character #=> "Triss Merigold"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.characters", this))));
            }
            /// <summary>
            /// Produces the name of a location from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.location #=> "Novigrad"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.locations", this))));
            }
            /// <summary>
            /// Produces the name of a monster from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.monster #=> "Katakan"</code>
            /// </example>
            [FakerMethod("monster")]
            public string Monster()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.monsters", this))));
            }
            /// <summary>
            /// Produces the name of a potion from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.potion #=> "Gadwall"</code>
            /// </example>
            [FakerMethod("potion")]
            public string Potion()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.potions", this))));
            }
            /// <summary>
            /// Produces a quote from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.quote #=> "No Lollygagin'!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.quotes", this))));
            }
            /// <summary>
            /// Produces the name of a school from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.school #=> "Wolf"</code>
            /// </example>
            [FakerMethod("school")]
            public string School()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.schools", this))));
            }
            /// <summary>
            /// Produces the name of a sign from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.sign #=> "Igni"</code>
            /// </example>
            [FakerMethod("sign")]
            public string Sign()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.signs", this))));
            }
            /// <summary>
            /// Produces the name of a witcher from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Witcher.witcher #=> "Geralt of Rivia"</code>
            /// </example>
            [FakerMethod("witcher")]
            public string Witcher()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.witcher.witchers", this))));
            }
        }
        
        [FakerGenerator("WorldOfWarcraft")]
        public class WorldOfWarcraftGenerator : GeneratorBase
        {
            internal WorldOfWarcraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a class name from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WorldOfWarcraft.class_name #=> "Druid"</code>
            /// </example>
            [FakerMethod("class_name")]
            public string ClassName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.world_of_warcraft.class_names", this))));
            }
            /// <summary>
            /// Produces the name of a hero from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WorldOfWarcraft.hero #=> "Uther the Lightbringer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.world_of_warcraft.heros", this))));
            }
            /// <summary>
            /// Produces a quote from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WorldOfWarcraft.quote #=> "These are dark times indeed."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.world_of_warcraft.quotes", this))));
            }
            /// <summary>
            /// Produces the name of a race from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::WorldOfWarcraft.race #=> "Druid"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.world_of_warcraft.races", this))));
            }
        }
        
        [FakerGenerator("Zelda")]
        public class ZeldaGenerator : GeneratorBase
        {
            internal ZeldaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Zelda.character #=> "Link"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.zelda.characters", this))));
            }
            /// <summary>
            /// Produces the name of a Legend of Zelda game.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Zelda.game #=> "Breath of the Wild"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.zelda.games", this))));
            }
            /// <summary>
            /// Produces the name of an item from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Zelda.item #=> "Boomerang"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.zelda.items", this))));
            }
            /// <summary>
            /// Produces the name of a character from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::Zelda.location #=> "Hyrule Castle"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("games.zelda.locations", this))));
            }
        }
        
    }
    
    [FakerGenerator("Gender")]
    public class GenderGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("gender.binary_types", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("gender.short_binary_types", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("gender.types", this))));
        }
    }
    
    [FakerGenerator("GreekPhilosophers")]
    public class GreekPhilosophersGenerator : GeneratorBase
    {
        internal GreekPhilosophersGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a Greek philosopher.
        /// </summary>
        /// <example>
        /// <code>Faker::GreekPhilosophers.name #=> "Socrates"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("greek_philosophers.names", this))));
        }
        /// <summary>
        /// Produces a quote from a Greek philosopher.
        /// </summary>
        /// <example>
        /// <code>Faker::GreekPhilosophers.quote #=> "Only the educated are free."</code>
        /// </example>
        [FakerMethod("quote")]
        public string Quote()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("greek_philosophers.quotes", this))));
        }
    }
    
    [FakerGenerator("HTML")]
    public class HTMLGenerator : GeneratorBase
    {
        internal HTMLGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method available_methods
        /// <summary>
        /// Produces a random code block formatted in HTML.
        /// </summary>
        /// <example>
        /// <code>Faker::HTML.code #=> "<code>Eos quasi qui.</code>"</code>
        /// </example>
        [FakerMethod("code")]
        public string Code()
        {
            return this.Expression("<code>#{Lorem.sentence(word_count: 1)}</code>", this);
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
            return this.Translate(this.Numerify(this.Letterify(this.Expression("<em>#{Faker::Lorem.paragraph(sentence_count: 1)}</em>", this))));
        }
        #warning Failed processing method generate_table_row
        #warning No implementation defined for method heading();
        #warning No implementation defined for method link(string rel = "stylesheet");
        #warning No implementation defined for method ordered_list();
        #warning No implementation defined for method paragraph(long sentenceCount, bool supplemental, long randomSentencesToAdd, List<string>? excludeWords = null);
        #warning Failed processing method random
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
            return this.Translate(this.Numerify(this.Letterify(this.Expression("<script src=\"#{Faker::Internet.url}.js\"></script>", this))));
        }
        #warning No implementation defined for method table();
        #warning No implementation defined for method unordered_list();
    }
    
    /// <summary>
    /// Port of http://shinytoylabs.com/jargon/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.
    /// <p>Port of <a href="http://shinytoylabs.com/jargon">shinytoylabs.com/jargon</a>/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.</p>
    /// 
    /// </summary>
    [FakerGenerator("Hacker")]
    public class HackerGenerator : GeneratorBase
    {
        internal HackerGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Short technical abbreviations.
        /// </summary>
        /// <example>
        /// <code>Faker::Hacker.abbreviation #=> "RAM"</code>
        /// </example>
        [FakerMethod("abbreviation")]
        public string Abbreviation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hacker.abbreviation", this))));
        }
        /// <summary>
        /// Hacker-centric adjectives.
        /// </summary>
        /// <example>
        /// <code>Faker::Hacker.adjective #=> "open-source"</code>
        /// </example>
        [FakerMethod("adjective")]
        public string Adjective()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hacker.adjective", this))));
        }
        /// <summary>
        /// Produces a verb that ends with '-ing'.
        /// </summary>
        /// <example>
        /// <code>Faker::Hacker.ingverb #=> "synthesizing"</code>
        /// </example>
        [FakerMethod("ingverb")]
        public string Ingverb()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hacker.ingverb", this))));
        }
        /// <summary>
        /// Only the best hacker-related nouns.
        /// </summary>
        /// <example>
        /// <code>Faker::Hacker.noun #=> "bandwidth"</code>
        /// </example>
        [FakerMethod("noun")]
        public string Noun()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hacker.noun", this))));
        }
        #warning Failed processing method phrases
        #warning No implementation defined for method say_something_smart();
        /// <summary>
        /// Actions that hackers take.
        /// </summary>
        /// <example>
        /// <code>Faker::Hacker.verb #=> "bypass"</code>
        /// </example>
        [FakerMethod("verb")]
        public string Verb()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hacker.verb", this))));
        }
    }
    
    [FakerGenerator("Hipster")]
    public class HipsterGenerator : GeneratorBase
    {
        internal HipsterGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method paragraph(long sentenceCount, bool supplemental, bool randomSentencesToAdd = 3);
        #warning No implementation defined for method paragraph_by_chars(long characters, bool supplemental = false);
        #warning No implementation defined for method paragraphs(long number, bool supplemental = false);
        #warning No implementation defined for method sentence(long wordCount, bool supplemental, long randomWordsToAdd, bool openCompoundsAllowed = true);
        #warning No implementation defined for method sentences(long number, bool supplemental = false);
        #warning No implementation defined for method word();
        #warning No implementation defined for method words(long number, bool supplemental, bool spacesAllowed = false);
    }
    
    [FakerGenerator("Hobby")]
    public class HobbyGenerator : GeneratorBase
    {
        internal HobbyGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Retrieves a typical hobby activity.
        /// </summary>
        /// <example>
        /// <code>Faker::Hobby.activity #=> "Cooking"</code>
        /// </example>
        [FakerMethod("activity")]
        public string Activity()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("hobby.activity", this))));
        }
    }
    
    [FakerGenerator("House")]
    public class HouseGenerator : GeneratorBase
    {
        internal HouseGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a piece of furniture.
        /// </summary>
        /// <example>
        /// <code>Faker::House.furniture #=> "chair"</code>
        /// </example>
        [FakerMethod("furniture")]
        public string Furniture()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("house.furniture", this))));
        }
        /// <summary>
        /// Produces the name of a room in a house.
        /// </summary>
        /// <example>
        /// <code>Faker::House.room #=> "kitchen"</code>
        /// </example>
        [FakerMethod("room")]
        public string Room()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("house.rooms", this))));
        }
    }
    
    [FakerGenerator("IDNumber")]
    public class IDNumberGenerator : GeneratorBase
    {
        internal IDNumberGenerator(Faker faker)
                 : base(faker)
        {
        }
        
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
        #warning No implementation defined for method danish_id_number(bool formatted, DateOnly birthday, UNKNOWN_Symbol? gender = null);
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
    
    [FakerGenerator("IndustrySegments")]
    public class IndustrySegmentsGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("industry_segments.industry", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("industry_segments.sector", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("industry_segments.sub_sector", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("industry_segments.super_sector", this))));
        }
    }
    
    [FakerGenerator("Internet")]
    public class InternetGenerator : GeneratorBase
    {
        [FakerMethod("HTTP")]
        public HTTPGenerator HTTP { get; }
        internal InternetGenerator(Faker faker)
                 : base(faker)
        {
            HTTP = new HTTPGenerator(_faker);
        }
        
        [FakerGenerator("HTTP")]
        public class HTTPGenerator : GeneratorBase
        {
            internal HTTPGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method status_code();
        }
        
        #warning No implementation defined for method base64(long length, bool padding, bool urlsafe = true);
        #warning No implementation defined for method bot_user_agent(string? vendor = null);
        #warning Failed processing method construct_email
        #warning Failed processing method device_token
        #warning No implementation defined for method domain_name(UNKNOWN_Bool subdomain, string? domain = null);
        /// <summary>
        /// Returns the domain suffix e.g.
        ///                             <p>com, org, co, biz, info etc.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.domain_suffix              #=> "com"
        /// Faker::Internet.domain_suffix              #=> "biz"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "example"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "test"</code>
        /// </example>
        [FakerMethod("domain_suffix")]
        public string DomainSuffix()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("internet.safe_domain_suffix", this))));
        }
        #warning No implementation defined for method domain_word();
        #warning No implementation defined for method email(string name, List<string> separators, string? domain = null);
        #warning No implementation defined for method fix_umlauts(string @string = "");
        #warning No implementation defined for method ip_v4_address();
        /// <summary>
        /// Returns Ipv4 address with CIDR, range from 1 to 31.
        ///                             <p>Returns Ipv4 address with CIDR, range from 1 to 31</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/16"
        /// Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/24"</code>
        /// </example>
        [FakerMethod("ip_v4_cidr")]
        public string IpV4Cidr()
        {
            return this.Expression("#{ip_v4_address}/#{rand(1..31)}", this);
        }
        #warning No implementation defined for method ip_v6_address();
        /// <summary>
        /// Returns Ipv6 address with CIDR, range between 1 to 127.
        ///                             <p>Returns Ipv6 address with CIDR, range between 1 to 127</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.ip_v6_cidr  #=> "beca:9b99:4bb6:9712:af2f:516f:8507:96e1/99"</code>
        /// </example>
        [FakerMethod("ip_v6_cidr")]
        public string IpV6Cidr()
        {
            return this.Expression("#{ip_v6_address}/#{rand(1..127)}", this);
        }
        #warning No implementation defined for method mac_address();
        #warning No implementation defined for method password(long minLength, long maxLength, bool mixCase, bool specialCharacters = false);
        #warning No implementation defined for method private_ip_v4_address();
        #warning No implementation defined for method private_net_checker();
        #warning No implementation defined for method private_nets_regex();
        #warning No implementation defined for method public_ip_v4_address();
        #warning No implementation defined for method reserved_net_checker();
        #warning No implementation defined for method reserved_nets_regex();
        #warning Failed processing method sanitize_email_local_part
        #warning No implementation defined for method slug(string words, string? glue = null);
        #warning No implementation defined for method url(string host, string path, string scheme = "http");
        #warning No implementation defined for method user();
        #warning No implementation defined for method user_agent(string? vendor = null);
        #warning No implementation defined for method username(long specifier, List<string> separators);
        #warning No implementation defined for method uuid();
    }
    
    [FakerGenerator("Invoice")]
    public class InvoiceGenerator : GeneratorBase
    {
        internal InvoiceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method amount_between(long from, long to = 0);
        #warning Failed processing method calculate_weighted_sum
        #warning No implementation defined for method creditor_reference(string @ref = "");
        #warning Failed processing method iban_checksum
        #warning Failed processing method kidmod10
        #warning Failed processing method method_731
        #warning Failed processing method mod10_remainder
        #warning No implementation defined for method reference(string @ref = "");
    }
    
    [FakerGenerator("JapaneseMedia")]
    public class JapaneseMediaGenerator : GeneratorBase
    {
        [FakerMethod("Conan")]
        public ConanGenerator Conan { get; }
        [FakerMethod("CowboyBebop")]
        public CowboyBebopGenerator CowboyBebop { get; }
        [FakerMethod("Doraemon")]
        public DoraemonGenerator Doraemon { get; }
        [FakerMethod("DragonBall")]
        public DragonBallGenerator DragonBall { get; }
        [FakerMethod("FmaBrotherhood")]
        public FmaBrotherhoodGenerator FmaBrotherhood { get; }
        [FakerMethod("KamenRider")]
        public KamenRiderGenerator KamenRider { get; }
        [FakerMethod("Naruto")]
        public NarutoGenerator Naruto { get; }
        [FakerMethod("OnePiece")]
        public OnePieceGenerator OnePiece { get; }
        [FakerMethod("StudioGhibli")]
        public StudioGhibliGenerator StudioGhibli { get; }
        [FakerMethod("SwordArtOnline")]
        public SwordArtOnlineGenerator SwordArtOnline { get; }
        internal JapaneseMediaGenerator(Faker faker)
                 : base(faker)
        {
            Conan = new ConanGenerator(_faker);
            CowboyBebop = new CowboyBebopGenerator(_faker);
            Doraemon = new DoraemonGenerator(_faker);
            DragonBall = new DragonBallGenerator(_faker);
            FmaBrotherhood = new FmaBrotherhoodGenerator(_faker);
            KamenRider = new KamenRiderGenerator(_faker);
            Naruto = new NarutoGenerator(_faker);
            OnePiece = new OnePieceGenerator(_faker);
            StudioGhibli = new StudioGhibliGenerator(_faker);
            SwordArtOnline = new SwordArtOnlineGenerator(_faker);
        }
        
        [FakerGenerator("Conan")]
        public class ConanGenerator : GeneratorBase
        {
            internal ConanGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Conan.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Conan.character #=> "Conan Edogawa"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("conan.characters", this))));
            }
            /// <summary>
            /// Produces a gadget from Conan.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Conan.gadget #=> "Voice-Changing Bowtie"</code>
            /// </example>
            [FakerMethod("gadget")]
            public string Gadget()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("conan.gadgets", this))));
            }
            /// <summary>
            /// Produces a vehicle from Conan.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Conan.vehicle #=> "Agasa's Volkswagen Beetle"</code>
            /// </example>
            [FakerMethod("vehicle")]
            public string Vehicle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("conan.vehicles", this))));
            }
        }
        
        [FakerGenerator("CowboyBebop")]
        public class CowboyBebopGenerator : GeneratorBase
        {
            internal CowboyBebopGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Cowboy Bebop.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::CowboyBebop.character #=> "Spike Spiegel"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("cowboy_bebop.character", this))));
            }
            /// <summary>
            /// Produces an episode from Cowboy Bebop.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::CowboyBebop.episode #=> "Honky Tonk Women"</code>
            /// </example>
            [FakerMethod("episode")]
            public string Episode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("cowboy_bebop.episode", this))));
            }
            /// <summary>
            /// Produces a quote from Cowboy Bebop.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::CowboyBebop.quote #=> "Bang!!!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("cowboy_bebop.quote", this))));
            }
            /// <summary>
            /// Produces a song title from Cowboy Bebop.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::CowboyBebop.songs #=> "Live in Baghdad"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("cowboy_bebop.song", this))));
            }
        }
        
        [FakerGenerator("Doraemon")]
        public class DoraemonGenerator : GeneratorBase
        {
            internal DoraemonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Doraemon.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Doraemon.character #=> "Nobita"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("doraemon.characters", this))));
            }
            /// <summary>
            /// Produces a gadget from Doraemon.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Doraemon.gadget #=> "Anywhere Door"</code>
            /// </example>
            [FakerMethod("gadget")]
            public string Gadget()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("doraemon.gadgets", this))));
            }
            /// <summary>
            /// Produces a location from Doraemon.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Doraemon.location #=> "Tokyo"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("doraemon.locations", this))));
            }
        }
        
        [FakerGenerator("DragonBall")]
        public class DragonBallGenerator : GeneratorBase
        {
            internal DragonBallGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DragonBall.character #=> "Goku"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dragon_ball.characters", this))));
            }
            /// <summary>
            /// Produces the name of a planet from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DragonBall.planet #=> "Namek"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dragon_ball.planets", this))));
            }
            /// <summary>
            /// Produces the name of a race from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Games::DragonBall.race #=> "Saiyan"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dragon_ball.races", this))));
            }
        }
        
        [FakerGenerator("FmaBrotherhood")]
        public class FmaBrotherhoodGenerator : GeneratorBase
        {
            internal FmaBrotherhoodGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from FmaBrotherhood.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::FmaBrotherhood.character #=> "Edward Elric"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("fma_brotherhood.characters", this))));
            }
            /// <summary>
            /// Produces a cities from FmaBrotherhood.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::FmaBrotherhood.city #=> "Central City"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("fma_brotherhood.cities", this))));
            }
            /// <summary>
            /// Produces a country from FmaBrotherhood.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::FmaBrotherhood.country #=> "Xing"</code>
            /// </example>
            [FakerMethod("country")]
            public string Country()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("fma_brotherhood.countries", this))));
            }
        }
        
        [FakerGenerator("KamenRider")]
        public class KamenRiderGenerator : GeneratorBase
        {
            internal KamenRiderGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method collectible_device();
            #warning No implementation defined for method eras();
            #warning No implementation defined for method eras=();
            [FakerMethod("from_eras")]
            public string FromEras()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("kamen_rider.#{era}.#{field}", this))));
            }
            #warning No implementation defined for method kamen_rider();
            #warning No implementation defined for method series();
            #warning No implementation defined for method transformation_device();
            #warning No implementation defined for method user();
        }
        
        [FakerGenerator("Naruto")]
        public class NarutoGenerator : GeneratorBase
        {
            internal NarutoGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Naruto.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Naruto.character #=> "Naruto Uzumaki"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("naruto.characters", this))));
            }
            /// <summary>
            /// Produces a demon from Naruto.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Naruto.demon #=> "Nine-Tails (Kurama)"</code>
            /// </example>
            [FakerMethod("demon")]
            public string Demon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("naruto.demons", this))));
            }
            /// <summary>
            /// Produces a eye from Naruto.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Naruto.eye #=> "Konohagakure (Byakugan)"</code>
            /// </example>
            [FakerMethod("eye")]
            public string Eye()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("naruto.eyes", this))));
            }
            /// <summary>
            /// Produces a village from Naruto.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::Naruto.village #=> "Konohagakure (Leaf Village)"</code>
            /// </example>
            [FakerMethod("village")]
            public string Village()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("naruto.villages", this))));
            }
        }
        
        [FakerGenerator("OnePiece")]
        public class OnePieceGenerator : GeneratorBase
        {
            internal OnePieceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an akuma no mi from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.akuma_no_mi #=> "Gomu Gomu no Mi"</code>
            /// </example>
            [FakerMethod("akuma_no_mi")]
            public string AkumaNoMi()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.akuma_no_mi", this))));
            }
            /// <summary>
            /// Produces a character from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.character #=> "Monkey D. Luffy"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.characters", this))));
            }
            /// <summary>
            /// Produces an island from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.island #=> "Laftel"</code>
            /// </example>
            [FakerMethod("island")]
            public string Island()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.islands", this))));
            }
            /// <summary>
            /// Produces a location from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.location #=> "Foosha Village"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.locations", this))));
            }
            /// <summary>
            /// Produces a quote from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.quote #=> "ONE PIECE IS REAL!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.quotes", this))));
            }
            /// <summary>
            /// Produces a sea from One Piece.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::OnePiece.sea #=> "East Blue"</code>
            /// </example>
            [FakerMethod("sea")]
            public string Sea()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("one_piece.seas", this))));
            }
        }
        
        [FakerGenerator("StudioGhibli")]
        public class StudioGhibliGenerator : GeneratorBase
        {
            internal StudioGhibliGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from the Studio Ghibli.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::StudioGhibli.character #=> "Chihiro"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("studio_ghibli.characters", this))));
            }
            /// <summary>
            /// Produces a movie from Studio Ghibli.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::StudioGhibli.movie #=> "Kiki's Delivery Service"</code>
            /// </example>
            [FakerMethod("movie")]
            public string Movie()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("studio_ghibli.movies", this))));
            }
            /// <summary>
            /// Produces a quote from Studio Ghibli's movies.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::StudioGhibli.quote #=> "One thing you can always count on is that hearts change."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("studio_ghibli.quotes", this))));
            }
        }
        
        [FakerGenerator("SwordArtOnline")]
        public class SwordArtOnlineGenerator : GeneratorBase
        {
            internal SwordArtOnlineGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the in-game name of a character from Sword Art Online.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::SwordArtOnline.game_name #=> "Silica"</code>
            /// </example>
            [FakerMethod("game_name")]
            public string GameName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("sword_art_online.game_name", this))));
            }
            /// <summary>
            /// Produces the name of an item from Sword Art Online.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::SwordArtOnline.item #=> "Blackwyrm Coat"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("sword_art_online.item", this))));
            }
            /// <summary>
            /// Produces the name of a location from Sword Art Online.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::SwordArtOnline.location #=> "Ruby Palace"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("sword_art_online.location", this))));
            }
            /// <summary>
            /// Produces the real name of a character from Sword Art Online.
            /// </summary>
            /// <example>
            /// <code>Faker::JapaneseMedia::SwordArtOnline.real_name #=> "Kirigaya Kazuto"</code>
            /// </example>
            [FakerMethod("real_name")]
            public string RealName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("sword_art_online.real_name", this))));
            }
        }
        
    }
    
    [FakerGenerator("Job")]
    public class JobGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("job.field", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("job.key_skills", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("job.position", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("job.title", this))));
        }
    }
    
    [FakerGenerator("Json")]
    public class JsonGenerator : GeneratorBase
    {
        internal JsonGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method add_depth_to_json(UNKNOWN_Hash{String => String} json, long width, UNKNOWN_Hash options);
        #warning Failed processing method add_hash
        #warning Failed processing method add_hash_to_bottom
        #warning Failed processing method build_keys_from_array
        #warning Failed processing method build_shallow_hash
        #warning No implementation defined for method shallow_json(long width, UNKNOWN_Hash options);
    }
    
    [FakerGenerator("Kpop")]
    public class KpopGenerator : GeneratorBase
    {
        internal KpopGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a K-Pop boy band.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.boy_bands #=> "Exo"</code>
        /// </example>
        [FakerMethod("boy_bands")]
        public string BoyBands()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.boy_bands", this))));
        }
        /// <summary>
        /// Produces the name of a K-Pop girl group.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.girl_groups #=> "2NE1"</code>
        /// </example>
        [FakerMethod("girl_groups")]
        public string GirlGroups()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.girl_groups", this))));
        }
        /// <summary>
        /// Produces the name of a 1990's 'OG' K-Pop group.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.i_groups #=> "Seo Taiji and Boys"</code>
        /// </example>
        [FakerMethod("i_groups")]
        public string IGroups()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.i_groups", this))));
        }
        /// <summary>
        /// Produces the name of a 2000's K-Pop group.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.ii_groups #=> "Girls' Generation"</code>
        /// </example>
        [FakerMethod("ii_groups")]
        public string IiGroups()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.ii_groups", this))));
        }
        /// <summary>
        /// Produces the name of a 2010's K-Pop group.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.iii_groups #=> "Trouble Maker"</code>
        /// </example>
        [FakerMethod("iii_groups")]
        public string IiiGroups()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.iii_groups", this))));
        }
        /// <summary>
        /// Produces the name of a solo K-Pop artist.
        /// </summary>
        /// <example>
        /// <code>Faker::Kpop.solo #=> "T.O.P"</code>
        /// </example>
        [FakerMethod("solo")]
        public string Solo()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("kpop.solo", this))));
        }
    }
    
    /// <summary>
    /// Based on Perl's Text::Lorem.
    /// <p>Based on Perl’s Text::Lorem</p>
    /// 
    /// </summary>
    [FakerGenerator("Lorem")]
    public class LoremGenerator : GeneratorBase
    {
        internal LoremGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method character();
        #warning No implementation defined for method characters(long number, long minAlpha, long minNumeric = 0);
        #warning Failed processing method locale_period
        #warning Failed processing method locale_question_mark
        #warning Failed processing method locale_space
        #warning No implementation defined for method multibyte();
        #warning No implementation defined for method paragraph(long sentenceCount, bool supplemental, long randomSentencesToAdd);
        #warning No implementation defined for method paragraph_by_chars(long number, bool supplemental = false);
        #warning No implementation defined for method paragraphs(long number, bool supplemental);
        #warning No implementation defined for method question(long wordCount, bool supplemental, long randomWordsToAdd);
        #warning No implementation defined for method questions(long number, bool supplemental);
        #warning No implementation defined for method sentence(long wordCount, bool supplemental, long randomWordsToAdd);
        #warning No implementation defined for method sentences(long number, bool supplemental);
        #warning No implementation defined for method word();
        #warning No implementation defined for method words(long number, bool supplemental);
    }
    
    [FakerGenerator("LoremFlickr")]
    public class LoremFlickrGenerator : GeneratorBase
    {
        internal LoremFlickrGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method build_url
        #warning No implementation defined for method colorized_image(string size, string color, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method grayscale_image(string size, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method image(string size, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method pixelated_image(string size, List<string> searchTerms, bool matchAll = false);
    }
    
    [FakerGenerator("Markdown")]
    public class MarkdownGenerator : GeneratorBase
    {
        internal MarkdownGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method available_methods
        /// <summary>
        /// Produces a random code block formatted in Ruby.
        /// </summary>
        /// <example>
        /// <code>Faker::Markdown.block_code #=> "```ruby\nEos quasi qui.\n```"</code>
        /// </example>
        [FakerMethod("block_code")]
        public string BlockCode()
        {
            return this.Expression("```ruby\n#{Lorem.sentence(word_count: 1)}\n```", this);
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("markdown.emphasis", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("markdown.headers", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Expression("`#{Faker::Lorem.sentence(word_count: 1)}`", this))));
        }
        #warning No implementation defined for method ordered_list();
        #warning Failed processing method random
        #warning No implementation defined for method sandwich(long sentences, long repeat = 1);
        #warning No implementation defined for method table();
        #warning No implementation defined for method unordered_list();
    }
    
    [FakerGenerator("Marketing")]
    public class MarketingGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("marketing.buzzwords", this))));
        }
    }
    
    [FakerGenerator("Measurement")]
    public class MeasurementGenerator : GeneratorBase
    {
        internal MeasurementGenerator(Faker faker)
                 : base(faker)
        {
        }
        
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
    
    [FakerGenerator("Military")]
    public class MilitaryGenerator : GeneratorBase
    {
        internal MilitaryGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Air Force.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.air_force_rank #=> "Captain"</code>
        /// </example>
        [FakerMethod("air_force_rank")]
        public string AirForceRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.air_force_rank", this))));
        }
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Army.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.army_rank #=> "Staff Sergeant"</code>
        /// </example>
        [FakerMethod("army_rank")]
        public string ArmyRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.army_rank", this))));
        }
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Coast Guard</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.coast_guard_rank #=> "Master Chief Petty Officer of the Coast Guard"</code>
        /// </example>
        [FakerMethod("coast_guard_rank")]
        public string CoastGuardRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.coast_guard_rank", this))));
        }
        /// <summary>
        /// Produces a U.S.
        ///                             <p>Department of Defense Paygrade.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.dod_paygrade #=> "E-6"</code>
        /// </example>
        [FakerMethod("dod_paygrade")]
        public string DodPaygrade()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.dod_paygrade", this))));
        }
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Marines.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.marines_rank #=> "Gunnery Sergeant"</code>
        /// </example>
        [FakerMethod("marines_rank")]
        public string MarinesRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.marines_rank", this))));
        }
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Navy.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.navy_rank #=> "Seaman"</code>
        /// </example>
        [FakerMethod("navy_rank")]
        public string NavyRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.navy_rank", this))));
        }
        /// <summary>
        /// Produces a rank in the U.S.
        ///                             <p>Space Force.</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Military.space_force_rank #=> "Senior Enlisted Advisor of the Space Force"</code>
        /// </example>
        [FakerMethod("space_force_rank")]
        public string SpaceForceRank()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("military.space_force_rank", this))));
        }
    }
    
    [FakerGenerator("Mountain")]
    public class MountainGenerator : GeneratorBase
    {
        internal MountainGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a name of a mountain.
        ///                             <p>Produces a name of a mountain</p>
        /// 
        ///                             <pre><code>@faker.version next
        ///                             </code></pre>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Mountain.name #=> "Mount Everest"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("mountain.name", this))));
        }
        /// <summary>
        /// Produces a name of a range.
        ///                             <p>Produces a name of a range</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Mountain.range #=> "Dhaulagiri Himalaya"</code>
        /// </example>
        [FakerMethod("range")]
        public string Range()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("mountain.range", this))));
        }
    }
    
    [FakerGenerator("Movie")]
    public class MovieGenerator : GeneratorBase
    {
        internal MovieGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a quote from a movie.
        /// </summary>
        /// <example>
        /// <code>Faker::Movie.quote #=> "Bumble bee tuna"</code>
        /// </example>
        [FakerMethod("quote")]
        public string Quote()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("movie.quote", this))));
        }
        /// <summary>
        /// Produces a title from a movie.
        /// </summary>
        /// <example>
        /// <code>Faker::Movie.title #=> "The Lord of the Rings: The Two Towers"</code>
        /// </example>
        [FakerMethod("title")]
        public string Title()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("movie.title", this))));
        }
    }
    
    [FakerGenerator("Movies")]
    public class MoviesGenerator : GeneratorBase
    {
        [FakerMethod("Avatar")]
        public AvatarGenerator Avatar { get; }
        [FakerMethod("BackToTheFuture")]
        public BackToTheFutureGenerator BackToTheFuture { get; }
        [FakerMethod("Departed")]
        public DepartedGenerator Departed { get; }
        [FakerMethod("Ghostbusters")]
        public GhostbustersGenerator Ghostbusters { get; }
        [FakerMethod("Hackers")]
        public HackersGenerator Hackers { get; }
        [FakerMethod("HarryPotter")]
        public HarryPotterGenerator HarryPotter { get; }
        [FakerMethod("HitchhikersGuideToTheGalaxy")]
        public HitchhikersGuideToTheGalaxyGenerator HitchhikersGuideToTheGalaxy { get; }
        [FakerMethod("Hobbit")]
        public HobbitGenerator Hobbit { get; }
        [FakerMethod("HowToTrainYourDragon")]
        public HowToTrainYourDragonGenerator HowToTrainYourDragon { get; }
        [FakerMethod("Lebowski")]
        public LebowskiGenerator Lebowski { get; }
        [FakerMethod("LordOfTheRings")]
        public LordOfTheRingsGenerator LordOfTheRings { get; }
        [FakerMethod("PrincessBride")]
        public PrincessBrideGenerator PrincessBride { get; }
        [FakerMethod("StarWars")]
        public StarWarsGenerator StarWars { get; }
        [FakerMethod("TheRoom")]
        public TheRoomGenerator TheRoom { get; }
        [FakerMethod("Tron")]
        public TronGenerator Tron { get; }
        [FakerMethod("VForVendetta")]
        public VForVendettaGenerator VForVendetta { get; }
        internal MoviesGenerator(Faker faker)
                 : base(faker)
        {
            Avatar = new AvatarGenerator(_faker);
            BackToTheFuture = new BackToTheFutureGenerator(_faker);
            Departed = new DepartedGenerator(_faker);
            Ghostbusters = new GhostbustersGenerator(_faker);
            Hackers = new HackersGenerator(_faker);
            HarryPotter = new HarryPotterGenerator(_faker);
            HitchhikersGuideToTheGalaxy = new HitchhikersGuideToTheGalaxyGenerator(_faker);
            Hobbit = new HobbitGenerator(_faker);
            HowToTrainYourDragon = new HowToTrainYourDragonGenerator(_faker);
            Lebowski = new LebowskiGenerator(_faker);
            LordOfTheRings = new LordOfTheRingsGenerator(_faker);
            PrincessBride = new PrincessBrideGenerator(_faker);
            StarWars = new StarWarsGenerator(_faker);
            TheRoom = new TheRoomGenerator(_faker);
            Tron = new TronGenerator(_faker);
            VForVendetta = new VForVendettaGenerator(_faker);
        }
        
        [FakerGenerator("Avatar")]
        public class AvatarGenerator : GeneratorBase
        {
            internal AvatarGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Avatar.character #=> "Jake Sully"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("avatar.characters", this))));
            }
            /// <summary>
            /// Produces a date from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Avatar.date #=> "December 15, 2022"</code>
            /// </example>
            [FakerMethod("date")]
            public string Date()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("avatar.dates", this))));
            }
            /// <summary>
            /// Produces a quote from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Avatar.quote
            /// #=> "If it ain't raining, we ain't training."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("avatar.quotes", this))));
            }
        }
        
        [FakerGenerator("BackToTheFuture")]
        public class BackToTheFutureGenerator : GeneratorBase
        {
            internal BackToTheFutureGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::BackToTheFuture.character #=> "Marty McFly"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("back_to_the_future.characters", this))));
            }
            /// <summary>
            /// Produces a date from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::BackToTheFuture.date #=> "November 5, 1955"</code>
            /// </example>
            [FakerMethod("date")]
            public string Date()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("back_to_the_future.dates", this))));
            }
            /// <summary>
            /// Produces a quote from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::BackToTheFuture.quote
            /// #=> "Roads? Where we're going, we don't need roads."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("back_to_the_future.quotes", this))));
            }
        }
        
        [FakerGenerator("Departed")]
        public class DepartedGenerator : GeneratorBase
        {
            internal DepartedGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Departed.actor #=> "Matt Damon"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("departed.actors", this))));
            }
            /// <summary>
            /// Produces a character from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Departed.character #=> "Frank Costello"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("departed.characters", this))));
            }
            /// <summary>
            /// Produces a quote from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Departed.quote
            /// #=> "I'm the guy who does his job. You must be the other guy"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("departed.quotes", this))));
            }
        }
        
        [FakerGenerator("Ghostbusters")]
        public class GhostbustersGenerator : GeneratorBase
        {
            internal GhostbustersGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Ghostbusters.actor #=> "Bill Murray"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("ghostbusters.actors", this))));
            }
            /// <summary>
            /// Produces a character from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Ghostbusters.character #=> "Dr. Egon Spengler"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("ghostbusters.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Ghostbusters.quote
            /// #=> "I tried to think of the most harmless thing. Something I loved from my childhood. Something that could never ever possibly destroy us. Mr. Stay Puft!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("ghostbusters.quotes", this))));
            }
        }
        
        [FakerGenerator("Hackers")]
        public class HackersGenerator : GeneratorBase
        {
            internal HackersGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a real character name from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hackers.character #=> "Dade Murphy"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hackers.characters", this))));
            }
            /// <summary>
            /// Produces a character hacker "handle" from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hackers.handle #=> "Zero Cool"</code>
            /// </example>
            [FakerMethod("handle")]
            public string Handle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hackers.handles", this))));
            }
            /// <summary>
            /// Produces a quote from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hackers.quote #=> "Hack the Planet!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hackers.quotes", this))));
            }
        }
        
        [FakerGenerator("HarryPotter")]
        public class HarryPotterGenerator : GeneratorBase
        {
            internal HarryPotterGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a book from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.book #=> "Harry Potter and the Chamber of Secrets"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.books", this))));
            }
            /// <summary>
            /// Produces a character from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.character #=> "Harry Potter"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.characters", this))));
            }
            /// <summary>
            /// Produces a house from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.house #=> "Gryffindor"</code>
            /// </example>
            [FakerMethod("house")]
            public string House()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.houses", this))));
            }
            /// <summary>
            /// Produces a location from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.location #=> "Hogwarts"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.quote #=> "I solemnly swear that I am up to good."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.quotes", this))));
            }
            /// <summary>
            /// Produces a spell from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HarryPotter.spell #=> "Reparo"</code>
            /// </example>
            [FakerMethod("spell")]
            public string Spell()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("harry_potter.spells", this))));
            }
        }
        
        [FakerGenerator("HitchhikersGuideToTheGalaxy")]
        public class HitchhikersGuideToTheGalaxyGenerator : GeneratorBase
        {
            internal HitchhikersGuideToTheGalaxyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.character #=> "Marvin"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.characters", this))));
            }
            /// <summary>
            /// Produces a location from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.location
            /// #=> "Arthur Dent's house"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.locations", this))));
            }
            /// <summary>
            /// Produces a Marvin quote from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.marvin_quote
            /// #=> "Life? Don't talk to me about life."</code>
            /// </example>
            [FakerMethod("marvin_quote")]
            public string MarvinQuote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.marvin_quote", this))));
            }
            /// <summary>
            /// Produces a planet from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.planet
            /// #=> "Magrathea"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.planets", this))));
            }
            /// <summary>
            /// Produces a quote from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.quote
            /// #=> "In the beginning, the Universe was created. This has made a lot of people very angry and been widely regarded as a bad move."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.quotes", this))));
            }
            /// <summary>
            /// Produces a species from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.specie
            /// #=> "Perfectly Normal Beast"</code>
            /// </example>
            [FakerMethod("specie")]
            public string Specie()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.species", this))));
            }
            /// <summary>
            /// Produces a starship from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HitchhikersGuideToTheGalaxy.starship
            /// #=> "Vogon Constructor Fleet"</code>
            /// </example>
            [FakerMethod("starship")]
            public string Starship()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hitchhikers_guide_to_the_galaxy.starships", this))));
            }
        }
        
        [FakerGenerator("Hobbit")]
        public class HobbitGenerator : GeneratorBase
        {
            internal HobbitGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hobbit.character #=> "Gandalf the Grey"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.hobbit.character", this))));
            }
            /// <summary>
            /// Produces the name of a location from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hobbit.location #=> "The Shire"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.hobbit.location", this))));
            }
            /// <summary>
            /// Produces a quote from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hobbit.quote
            /// #=> "Never laugh at live dragons, Bilbo you fool!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.hobbit.quote", this))));
            }
            /// <summary>
            /// Produces the name of one of the 13 dwarves from the Company, or Gandalf or Bilbo.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Hobbit.thorins_company #=> "Thorin Oakenshield"</code>
            /// </example>
            [FakerMethod("thorins_company")]
            public string ThorinsCompany()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.hobbit.thorins_company", this))));
            }
        }
        
        [FakerGenerator("HowToTrainYourDragon")]
        public class HowToTrainYourDragonGenerator : GeneratorBase
        {
            internal HowToTrainYourDragonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HowToTrainYourDragon.character #=> "Hiccup"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_to_train_your_dragon.characters", this))));
            }
            /// <summary>
            /// Produces a dragon from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HowToTrainYourDragon.dragons #=> "Toothless"</code>
            /// </example>
            [FakerMethod("dragon")]
            public string Dragon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_to_train_your_dragon.dragons", this))));
            }
            /// <summary>
            /// Produces a location from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::HowToTrainYourDragon.location #=> "Berk"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_to_train_your_dragon.locations", this))));
            }
        }
        
        [FakerGenerator("Lebowski")]
        public class LebowskiGenerator : GeneratorBase
        {
            internal LebowskiGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Lebowski.actor #=> "John Goodman"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lebowski.actors", this))));
            }
            /// <summary>
            /// Produces a character from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Lebowski.character #=> "Jackie Treehorn"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lebowski.characters", this))));
            }
            /// <summary>
            /// Produces a quote from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Lebowski.quote #=> "Forget it, Donny, you're out of your element!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("lebowski.quotes", this))));
            }
        }
        
        [FakerGenerator("LordOfTheRings")]
        public class LordOfTheRingsGenerator : GeneratorBase
        {
            internal LordOfTheRingsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::LordOfTheRings.character #=> "Legolas"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.lord_of_the_rings.characters", this))));
            }
            /// <summary>
            /// Produces a location from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::LordOfTheRings.location #=> "Helm's Deep"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.lord_of_the_rings.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::LordOfTheRings.quote
            /// #=> "I wish the Ring had never come to me. I wish none of this had happened."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("tolkien.lord_of_the_rings.quotes", this))));
            }
        }
        
        [FakerGenerator("PrincessBride")]
        public class PrincessBrideGenerator : GeneratorBase
        {
            internal PrincessBrideGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Princess Bride.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::PrincessBride.character #=> "Dread Pirate Roberts"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("princess_bride.characters", this))));
            }
            /// <summary>
            /// Produces a quote from The Princess Bride.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::PrincessBride.quote
            /// #=> "Hello. My name is Inigo Montoya. You killed my father. Prepare to die!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("princess_bride.quotes", this))));
            }
        }
        
        [FakerGenerator("StarWars")]
        public class StarWarsGenerator : GeneratorBase
        {
            internal StarWarsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method call_number();
            /// <summary>
            /// Generates numbers array.
            ///                                 <p>Generates numbers array</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.call_numbers  #=> ["Leader", "#"]</code>
            /// </example>
            [FakerMethod("call_numbers")]
            public List<string> CallNumbers()
            {
                return this.Resolve("star_wars.call_numbers", this).Split(',').Select(item => item).ToList();
            }
            /// <summary>
            /// Produces a call sign from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.call_sign #=> "Grey 5"</code>
            /// </example>
            [FakerMethod("call_sign")]
            public string CallSign()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("star_wars.call_sign", this))));
            }
            #warning No implementation defined for method call_squadron();
            /// <summary>
            /// Returns squadrons array.
            ///                                 <p>Returns squadrons array</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.call_squadrons  #=> ["Rogue", "Red", "Gray", "Green", "Blue", "Gold", "Black", "Yellow", "Phoenix"]</code>
            /// </example>
            [FakerMethod("call_squadrons")]
            public List<string> CallSquadrons()
            {
                return this.Resolve("star_wars.call_squadrons", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method character();
            /// <summary>
            /// Returns all character names in movie.
            ///                                 <p>Returns all character names in movie</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.characters</code>
            /// </example>
            [FakerMethod("characters")]
            public List<string> Characters()
            {
                return this.Resolve("star_wars.characters", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method droid();
            /// <summary>
            /// Returns droid list.
            ///                                 <p>Returns droid list</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.droids</code>
            /// </example>
            [FakerMethod("droids")]
            public List<string> Droids()
            {
                return this.Resolve("star_wars.droids", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method planet();
            /// <summary>
            /// Lists out all planet names.
            ///                                 <p>Lists out all planet names</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.planets</code>
            /// </example>
            [FakerMethod("planets")]
            public List<string> Planets()
            {
                return this.Resolve("star_wars.planets", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method quote(string? character = null);
            #warning No implementation defined for method specie();
            /// <summary>
            /// Returns name of all species.
            ///                                 <p>Returns name of all species</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.species</code>
            /// </example>
            [FakerMethod("species")]
            public List<string> Species()
            {
                return this.Resolve("star_wars.species", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method vehicle();
            /// <summary>
            /// Lists out all vehicles.
            ///                                 <p>Lists out all vehicles</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.vehicles</code>
            /// </example>
            [FakerMethod("vehicles")]
            public List<string> Vehicles()
            {
                return this.Resolve("star_wars.vehicles", this).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method wookiee_sentence();
            /// <summary>
            /// All wookiee words.
            ///                                 <p>All wookiee words</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::StarWars.wookiee_words</code>
            /// </example>
            [FakerMethod("wookiee_words")]
            public List<string> WookieeWords()
            {
                return this.Resolve("star_wars.wookiee_words", this).Split(',').Select(item => item).ToList();
            }
        }
        
        [FakerGenerator("TheRoom")]
        public class TheRoomGenerator : GeneratorBase
        {
            internal TheRoomGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Room.actor #=> "Tommy Wiseau"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_room.actors", this))));
            }
            /// <summary>
            /// Produces a character from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Room.character #=> "Johnny"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_room.characters", this))));
            }
            /// <summary>
            /// Produces a location from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Room.location #=> "Johnny's Apartment"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_room.locations", this))));
            }
            /// <summary>
            /// Produces a quote from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::Room.quote
            /// #=> "You're lying, I never hit you. You are tearing me apart, Lisa!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_room.quotes", this))));
            }
        }
        
        [FakerGenerator("Tron")]
        public class TronGenerator : GeneratorBase
        {
            internal TronGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method character();
            #warning No implementation defined for method game();
            #warning No implementation defined for method location();
            #warning No implementation defined for method program();
            #warning No implementation defined for method quote(string? character = null);
            #warning No implementation defined for method tagline();
            #warning No implementation defined for method user();
            #warning No implementation defined for method vehicle();
        }
        
        [FakerGenerator("VForVendetta")]
        public class VForVendettaGenerator : GeneratorBase
        {
            internal VForVendettaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::VForVendetta.character #=> "V"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("v_for_vendetta.characters", this))));
            }
            /// <summary>
            /// Produces a quote from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::VForVendetta.quote
            /// #=> "People should not be afraid of their governments. Governments should be afraid of their people."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("v_for_vendetta.quotes", this))));
            }
            /// <summary>
            /// Produces a speech from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movies::VForVendetta.speech
            /// #=> "Remember, remember, the Fifth of November, the Gunpowder Treason and Plot. I know of no reason why the Gunpowder Treason should ever be forgot..."</code>
            /// </example>
            [FakerMethod("speech")]
            public string Speech()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("v_for_vendetta.speeches", this))));
            }
        }
        
    }
    
    /// <summary>
    /// A generator of titles of operas by various composers.
    /// <p>A generator of titles of operas by various composers</p>
    /// 
    /// </summary>
    [FakerGenerator("Music")]
    public class MusicGenerator : GeneratorBase
    {
        [FakerMethod("GratefulDead")]
        public GratefulDeadGenerator GratefulDead { get; }
        [FakerMethod("Hiphop")]
        public HiphopGenerator Hiphop { get; }
        [FakerMethod("Opera")]
        public OperaGenerator Opera { get; }
        [FakerMethod("PearlJam")]
        public PearlJamGenerator PearlJam { get; }
        [FakerMethod("Phish")]
        public PhishGenerator Phish { get; }
        [FakerMethod("Prince")]
        public PrinceGenerator Prince { get; }
        [FakerMethod("RockBand")]
        public RockBandGenerator RockBand { get; }
        [FakerMethod("Rush")]
        public RushGenerator Rush { get; }
        [FakerMethod("SmashingPumpkins")]
        public SmashingPumpkinsGenerator SmashingPumpkins { get; }
        [FakerMethod("UmphreysMcgee")]
        public UmphreysMcgeeGenerator UmphreysMcgee { get; }
        internal MusicGenerator(Faker faker)
                 : base(faker)
        {
            GratefulDead = new GratefulDeadGenerator(_faker);
            Hiphop = new HiphopGenerator(_faker);
            Opera = new OperaGenerator(_faker);
            PearlJam = new PearlJamGenerator(_faker);
            Phish = new PhishGenerator(_faker);
            Prince = new PrinceGenerator(_faker);
            RockBand = new RockBandGenerator(_faker);
            Rush = new RushGenerator(_faker);
            SmashingPumpkins = new SmashingPumpkinsGenerator(_faker);
            UmphreysMcgee = new UmphreysMcgeeGenerator(_faker);
        }
        
        [FakerGenerator("GratefulDead")]
        public class GratefulDeadGenerator : GeneratorBase
        {
            internal GratefulDeadGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a member of The Grateful Dead.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::GratefulDead.player #=> "Jerry Garcia"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("grateful_dead.players", this))));
            }
            /// <summary>
            /// Produces the name of a song by The Grateful Dead.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::GratefulDead.song #=> "Cassidy"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("grateful_dead.songs", this))));
            }
        }
        
        [FakerGenerator("Hiphop")]
        public class HiphopGenerator : GeneratorBase
        {
            internal HiphopGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Hip Hop Artist.
            ///                                 <p>Produces the name of a Hip Hop Artist</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.artist #=> "Lil Wayne"</code>
            /// </example>
            [FakerMethod("artist")]
            public string Artist()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.hiphop.artist", this))));
            }
            /// <summary>
            /// Produces the name of a Hip Hop Group.
            ///                                 <p>Produces the name of a Hip Hop Group</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.groups #=> "OVO"</code>
            /// </example>
            [FakerMethod("groups")]
            public string Groups()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.hiphop.groups", this))));
            }
            /// <summary>
            /// Produces the name of a Hip Hop Subgenre.
            ///                                 <p>Produces the name of a Hip Hop Subgenre</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.subgeneres #=> "Alternative"</code>
            /// </example>
            [FakerMethod("subgenres")]
            public string Subgenres()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.hiphop.subgenres", this))));
            }
        }
        
        [FakerGenerator("Opera")]
        public class OperaGenerator : GeneratorBase
        {
            internal OperaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the title of an opera by Ludwig van Beethoven.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.beethoven #=> "Fidelio"</code>
            /// </example>
            [FakerMethod("beethoven")]
            public string Beethoven()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_ludwig_van_beethoven", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Vincenzo Bellini.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.bellini #=> "Norma"</code>
            /// </example>
            [FakerMethod("bellini")]
            public string Bellini()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_vincenzo_bellini", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Alban Berg.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.berg #=> "Wozzeck"</code>
            /// </example>
            [FakerMethod("berg")]
            public string Berg()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_alban_berg", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Hector Berlioz.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.berlioz #=> "Les Troyens"</code>
            /// </example>
            [FakerMethod("berlioz")]
            public string Berlioz()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_hector_berlioz", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Georges Bizet.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.bizet #=> "Carmen"</code>
            /// </example>
            [FakerMethod("bizet")]
            public string Bizet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_georges_bizet", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Gaetano Donizetti.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.donizetti #=> "Lucia di Lammermoor"</code>
            /// </example>
            [FakerMethod("donizetti")]
            public string Donizetti()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_gaetano_donizetti", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Christoph Willibald Gluck.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.gluck #=> "Orfeo ed Euridice"</code>
            /// </example>
            [FakerMethod("gluck")]
            public string Gluck()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_christoph_willibald_gluck", this))));
            }
            /// <summary>
            /// Produces the title of a French opera by Christoph Willibald Gluck.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.gluck_fr #=> "Orphee et Euridice"</code>
            /// </example>
            [FakerMethod("gluck_french")]
            public string GluckFrench()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_christoph_willibald_gluck", this))));
            }
            /// <summary>
            /// Produces the title of an Italian opera by Christoph Willibald Gluck.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.gluck_it #=> "Orfeo ed Euridice"</code>
            /// </example>
            [FakerMethod("gluck_italian")]
            public string GluckItalian()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_christoph_willibald_gluck", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Charles Gounod.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.gounod #=> "Faust"</code>
            /// </example>
            [FakerMethod("gounod")]
            public string Gounod()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_charles_gounod", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Wolfgang Amadeus Mozart.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.mozart #=> "Die Zauberfloete"</code>
            /// </example>
            [FakerMethod("mozart")]
            public string Mozart()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_wolfgang_amadeus_mozart", this))));
            }
            /// <summary>
            /// Produces the title of a German opera by Wolfgang Amadeus Mozart.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.mozart_ger #=> "Die Zauberfloete"</code>
            /// </example>
            [FakerMethod("mozart_german")]
            public string MozartGerman()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_wolfgang_amadeus_mozart", this))));
            }
            /// <summary>
            /// Produces the title of an Italian opera by Wolfgang Amadeus Mozart.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.mozart_it #=> "Cosi fan tutte"</code>
            /// </example>
            [FakerMethod("mozart_italian")]
            public string MozartItalian()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_wolfgang_amadeus_mozart", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Maurice Ravel.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.ravel #=> "L'enfant et les sortileges"</code>
            /// </example>
            [FakerMethod("ravel")]
            public string Ravel()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_maurice_ravel", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Gioacchino Rossini.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.rossini #=> "Il Barbiere di Siviglia"</code>
            /// </example>
            [FakerMethod("rossini")]
            public string Rossini()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_gioacchino_rossini", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Camille Saint-Saens.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.saint_saens #=> "Samson and Delilah"</code>
            /// </example>
            [FakerMethod("saint_saens")]
            public string SaintSaens()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.french.by_camille_saint_saens", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Franz Schubert.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.schubert #=> "Alfonso und Estrella"</code>
            /// </example>
            [FakerMethod("schubert")]
            public string Schubert()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_franz_schubert", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Robert Schumann.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.schumann #=> "Genoveva"</code>
            /// </example>
            [FakerMethod("schumann")]
            public string Schumann()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_robert_schumann", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Richard Strauss.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.strauss #=> "Elektra"</code>
            /// </example>
            [FakerMethod("strauss")]
            public string Strauss()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_richard_strauss", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Giuseppe Verdi.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.verdi #=> "Il Trovatore"</code>
            /// </example>
            [FakerMethod("verdi")]
            public string Verdi()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.italian.by_giuseppe_verdi", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Richard Wagner.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.wagner #=> "Tristan und Isolde"</code>
            /// </example>
            [FakerMethod("wagner")]
            public string Wagner()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_richard_wagner", this))));
            }
            /// <summary>
            /// Produces the title of an opera by Carl Maria von Weber.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Opera.weber #=> "Der Freischuetz"</code>
            /// </example>
            [FakerMethod("weber")]
            public string Weber()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("opera.german.by_carl_maria_von_weber", this))));
            }
        }
        
        [FakerGenerator("PearlJam")]
        public class PearlJamGenerator : GeneratorBase
        {
            internal PearlJamGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an album by Pearl Jam.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::PearlJam.album #=> "Ten"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("pearl_jam.albums", this))));
            }
            /// <summary>
            /// Produces the name of a member of Pearl Jam (current and former).
            ///                                 <p>Produces the name of a member of Pearl Jam (current and former)</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::PearlJam.musician #=> "Eddie Vedder"</code>
            /// </example>
            [FakerMethod("musician")]
            public string Musician()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("pearl_jam.musicians", this))));
            }
            /// <summary>
            /// Produces the name of a song by Pearl Jam.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::PearlJam.song #=> "Even Flow"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("pearl_jam.songs", this))));
            }
        }
        
        [FakerGenerator("Phish")]
        public class PhishGenerator : GeneratorBase
        {
            internal PhishGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a album by Phish.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Phish.album #=> "Fuego"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("phish.albums", this))));
            }
            /// <summary>
            /// Produces the name of a musician in Phish.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Phish.musician #=> "Trey Anastasio"</code>
            /// </example>
            [FakerMethod("musician")]
            public string Musician()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("phish.musicians", this))));
            }
            /// <summary>
            /// Produces the name of a song by Phish.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Phish.song #=> "Tweezer"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("phish.songs", this))));
            }
        }
        
        [FakerGenerator("Prince")]
        public class PrinceGenerator : GeneratorBase
        {
            internal PrinceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random Prince album.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Prince.album #=> "The Gold Experience"
            /// Faker::Music::Prince.album #=> "Purple Rain"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("prince.album", this))));
            }
            /// <summary>
            /// Produces a random Prince-associated band.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Prince.band #=> "The New Power Generation"</code>
            /// </example>
            [FakerMethod("band")]
            public string Band()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("prince.band", this))));
            }
            /// <summary>
            /// Produces a random Prince song lyric.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Prince.lyric #=> "Dearly beloved, we are gathered here today to get through this thing called life."
            /// Faker::Music::Prince.lyric #=> "You were so hard to find, the beautiful ones, they hurt you every time."</code>
            /// </example>
            [FakerMethod("lyric")]
            public string Lyric()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("prince.lyric", this))));
            }
            /// <summary>
            /// Produces a random Prince song.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Prince.song #=> "Raspberry Beret"
            /// Faker::Music::Prince.song #=> "Starfish And Coffee"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("prince.song", this))));
            }
        }
        
        [FakerGenerator("RockBand")]
        public class RockBandGenerator : GeneratorBase
        {
            internal RockBandGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a rock band.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::RockBand.name #=> "Led Zeppelin"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rock_band.name", this))));
            }
            /// <summary>
            /// Produces a rock song.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::RockBand.song #=> "Dani California"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rock_band.song", this))));
            }
        }
        
        [FakerGenerator("Rush")]
        public class RushGenerator : GeneratorBase
        {
            internal RushGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an album by Rush.
            ///                                 <p>Produces the name of an album by Rush</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Rush.album #=> "Hold Your Fire"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rush.albums", this))));
            }
            /// <summary>
            /// Produces the name of a member of Rush.
            ///                                 <p>Produces the name of a member of Rush</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Rush.player #=> "Geddy Lee"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rush.players", this))));
            }
        }
        
        [FakerGenerator("SmashingPumpkins")]
        public class SmashingPumpkinsGenerator : GeneratorBase
        {
            internal SmashingPumpkinsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an album by the Smashing Pumpkins.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::SmashingPumpkins.album #=> "Siamese Dream"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("smashing_pumpkins.albums", this))));
            }
            /// <summary>
            /// Produces a random Smashing Pumpkins song lyric.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::SmashingPumpkins.lyric #=> "Despite all my rage, I am still just a rat in a cage"
            /// Faker::Music::SmashingPumpkins.lyric #=> "Breathin' underwater, and livin' under glass"</code>
            /// </example>
            [FakerMethod("lyric")]
            public string Lyric()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("smashing_pumpkins.lyric", this))));
            }
            /// <summary>
            /// Produces the name of a member of the Smashing Pumpkins (current and former).
            ///                                 <p>Produces the name of a member of the Smashing Pumpkins (current and former)</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Music::SmashingPumpkins.musician #=> "Billy Corgan"</code>
            /// </example>
            [FakerMethod("musician")]
            public string Musician()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("smashing_pumpkins.musicians", this))));
            }
            /// <summary>
            /// Produces the name of a song by the Smashing Pumpkins.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::SmashingPumpkins.song #=> "Stand Inside My Love"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("smashing_pumpkins.songs", this))));
            }
        }
        
        [FakerGenerator("UmphreysMcgee")]
        public class UmphreysMcgeeGenerator : GeneratorBase
        {
            internal UmphreysMcgeeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a song by Umphrey's McGee.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::UmphreysMcgee.song #=> "Dump City"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("umphreys_mcgee.song", this))));
            }
        }
        
        /// <summary>
        /// Produces the name of an album.
        /// </summary>
        /// <example>
        /// <code>Faker::Music.album #=> "Sgt. Pepper's Lonely Hearts Club"</code>
        /// </example>
        [FakerMethod("album")]
        public string Album()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.albums", this))));
        }
        /// <summary>
        /// Produces the name of a band.
        /// </summary>
        /// <example>
        /// <code>Faker::Music.band #=> "The Beatles"</code>
        /// </example>
        [FakerMethod("band")]
        public string Band()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.bands", this))));
        }
        #warning No implementation defined for method chord();
        #warning No implementation defined for method chord_types();
        /// <summary>
        /// Produces the name of a musical genre.
        /// </summary>
        /// <example>
        /// <code>Faker::Music.genre #=> "Rock"</code>
        /// </example>
        [FakerMethod("genre")]
        public string Genre()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.genres", this))));
        }
        /// <summary>
        /// Produces the name of an instrument.
        /// </summary>
        /// <example>
        /// <code>Faker::Music.instrument #=> "Acoustic Guitar"</code>
        /// </example>
        [FakerMethod("instrument")]
        public string Instrument()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.instruments", this))));
        }
        #warning No implementation defined for method key();
        #warning No implementation defined for method key_types();
        #warning No implementation defined for method key_variants();
        #warning No implementation defined for method keys();
        /// <summary>
        /// Produces a name from Lou Bega's Mambo #5.
        ///                             <p>Produces a name from Lou Bega’s Mambo #5</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Music.mambo #=> "Monica"</code>
        /// </example>
        [FakerMethod("mambo_no_5")]
        public string MamboNo5()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("music.mambo_no_5", this))));
        }
    }
    
    [FakerGenerator("Name")]
    public class NameGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.female_first_name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.first_name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.last_name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.male_first_name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.name_with_middle", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.neutral_first_name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.prefix", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("name.suffix", this))));
        }
    }
    
    [FakerGenerator("Nation")]
    public class NationGenerator : GeneratorBase
    {
        internal NationGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random capital city.
        /// </summary>
        /// <example>
        /// <code>Faker::Nation.capital_city #=> "Kathmandu"</code>
        /// </example>
        [FakerMethod("capital_city")]
        public string CapitalCity()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("nation.capital_city", this))));
        }
        #warning No implementation defined for method flag();
        /// <summary>
        /// Produces a random national language.
        /// </summary>
        /// <example>
        /// <code>Faker::Nation.language #=> "Nepali"</code>
        /// </example>
        [FakerMethod("language")]
        public string Language()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("nation.language", this))));
        }
        /// <summary>
        /// Produces a random national sport.
        /// </summary>
        /// <example>
        /// <code>Faker::Nation.national_sport #=> "dandi biyo"</code>
        /// </example>
        [FakerMethod("national_sport")]
        public string NationalSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("team.sport", this))));
        }
        /// <summary>
        /// Produces a random nationality.
        /// </summary>
        /// <example>
        /// <code>Faker::Nation.nationality #=> "Nepalese"</code>
        /// </example>
        [FakerMethod("nationality")]
        public string Nationality()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("nation.nationality", this))));
        }
    }
    
    [FakerGenerator("NationalHealthService")]
    public class NationalHealthServiceGenerator : GeneratorBase
    {
        internal NationalHealthServiceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method british_number();
        #warning No implementation defined for method check_digit(long number = 0);
    }
    
    [FakerGenerator("NatoPhoneticAlphabet")]
    public class NatoPhoneticAlphabetGenerator : GeneratorBase
    {
        internal NatoPhoneticAlphabetGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a code word from the NATO phonetic alphabet.
        /// </summary>
        /// <example>
        /// <code>Faker::NatoPhoneticAlphabet.code_word #=> "Hotel"</code>
        /// </example>
        [FakerMethod("code_word")]
        public string CodeWord()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("nato_phonetic_alphabet.code_word", this))));
        }
    }
    
    [FakerGenerator("Number")]
    public class NumberGenerator : GeneratorBase
    {
        internal NumberGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method between(UNKNOWN_Numeric from, UNKNOWN_Numeric? to = null);
        #warning No implementation defined for method binary(long digits = 4);
        #warning No implementation defined for method decimal(long lDigits, long rDigits = 2);
        #warning No implementation defined for method decimal_part(long digits = 10);
        #warning No implementation defined for method digit();
        #warning Failed processing method generate
        #warning Failed processing method greater_than_zero
        #warning No implementation defined for method hexadecimal(long digits = 6);
        #warning No implementation defined for method leading_zero_number(long digits = 10);
        #warning Failed processing method less_than_zero
        #warning No implementation defined for method negative(long from, long to);
        #warning No implementation defined for method non_zero_digit();
        #warning No implementation defined for method normal(long mean, UNKNOWN_Numeric? standardDeviation = null);
        #warning No implementation defined for method number(long digits = 10);
        #warning No implementation defined for method positive(long from, long to = 5000.00);
        #warning Failed processing method should_be
        #warning No implementation defined for method within(UNKNOWN_Range? range = null);
    }
    
    [FakerGenerator("Omniauth")]
    public class OmniauthGenerator : GeneratorBase
    {
        internal OmniauthGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method apple(string name, string email, string? uid = null);
        #warning No implementation defined for method auth0(string name, string email, string? uid = null);
        #warning Failed processing method city_state
        #warning No implementation defined for method facebook(string name, string email, string username, string uid);
        #warning Failed processing method gender
        #warning No implementation defined for method github(string name, string email, string uid);
        #warning No implementation defined for method google(string name, string email, string uid);
        #warning Failed processing method image
        #warning No implementation defined for method linkedin(string name, string email, string uid);
        #warning Failed processing method random_boolean
        #warning Failed processing method random_number_from_range
        #warning Failed processing method timezone
        #warning No implementation defined for method twitter(string name, string nickname, string uid);
        #warning Failed processing method email
        #warning Failed processing method first_name
        #warning No implementation defined for method initialize();
        #warning Failed processing method last_name
        #warning Failed processing method name
    }
    
    [FakerGenerator("PhoneNumber")]
    public class PhoneNumberGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("phone_number.area_code", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("cell_phone.formats", this))));
        }
        #warning No implementation defined for method cell_phone_in_e164();
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
        {
            return this.Expression("#{country_code} #{cell_phone}", this);
        }
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("phone_number.country_code", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("phone_number.exchange_code", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("phone_number.formats", this))));
        }
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
        {
            return this.Expression("#{country_code} #{phone_number}", this);
        }
        #warning No implementation defined for method subscriber_number(long length = 4);
    }
    
    [FakerGenerator("Placeholdit")]
    public class PlaceholditGenerator : GeneratorBase
    {
        internal PlaceholditGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method generate_color
        #warning No implementation defined for method image(string size, string format, string backgroundColor, string textColor, string? text = null);
    }
    
    [FakerGenerator("ProgrammingLanguage")]
    public class ProgrammingLanguageGenerator : GeneratorBase
    {
        internal ProgrammingLanguageGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a programming language's creator.
        /// </summary>
        /// <example>
        /// <code>Faker::ProgrammingLanguage.creator #=> "Yukihiro Matsumoto"</code>
        /// </example>
        [FakerMethod("creator")]
        public string Creator()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("programming_language.creator", this))));
        }
        /// <summary>
        /// Produces the name of a programming language.
        /// </summary>
        /// <example>
        /// <code>Faker::ProgrammingLanguage.name #=> "Ruby"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("programming_language.name", this))));
        }
    }
    
    [FakerGenerator("Quote")]
    public class QuoteGenerator : GeneratorBase
    {
        internal QuoteGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a famous last words quote.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.famous_last_words #=> "My vocabulary did this to me. Your love will let you go on..."</code>
        /// </example>
        [FakerMethod("famous_last_words")]
        public string FamousLastWords()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.famous_last_words", this))));
        }
        /// <summary>
        /// Produces a quote from a fortune cookie.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.fortune_cookie #=> "This cookie senses that you are superstitious; it is an inclination that is bad for your mental health."</code>
        /// </example>
        [FakerMethod("fortune_cookie")]
        public string FortuneCookie()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.fortune_cookie", this))));
        }
        /// <summary>
        /// Produces a quote from Deep Thoughts by Jack Handey.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.jack_handey # => "I hope life isn't a big joke, because I don't get it."</code>
        /// </example>
        [FakerMethod("jack_handey")]
        public string JackHandey()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.jack_handey", this))));
        }
        /// <summary>
        /// Produces a quote from Matz.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.matz #=> "You want to enjoy life, don't you? If you get your job done quickly and your job is fun, that's good isn't it? That's the purpose of life, partly. Your life is better."</code>
        /// </example>
        [FakerMethod("matz")]
        public string Matz()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.matz", this))));
        }
        /// <summary>
        /// Produces a quote from comedian Mitch Hedberg.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.mitch_hedberg # => "I like Kit-Kats, unless I'm with four or more people."</code>
        /// </example>
        [FakerMethod("mitch_hedberg")]
        public string MitchHedberg()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.mitch_hedberg", this))));
        }
        /// <summary>
        /// Produces a quote about the most interesting man in the world.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.most_interesting_man_in_the_world #=> "He can speak Russian... in French"</code>
        /// </example>
        [FakerMethod("most_interesting_man_in_the_world")]
        public string MostInterestingManInTheWorld()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.most_interesting_man_in_the_world", this))));
        }
        /// <summary>
        /// Produces a Robin quote.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.robin #=> "Holy Razors Edge"</code>
        /// </example>
        [FakerMethod("robin")]
        public string Robin()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.robin", this))));
        }
        /// <summary>
        /// Produces a singular siegler quote.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.singular_siegler #=> "Texas!"</code>
        /// </example>
        [FakerMethod("singular_siegler")]
        public string SingularSiegler()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.singular_siegler", this))));
        }
        /// <summary>
        /// Produces a quote from Yoda.
        /// </summary>
        /// <example>
        /// <code>Faker::Quote.yoda #=> "Use your feelings, Obi-Wan, and find him you will."</code>
        /// </example>
        [FakerMethod("yoda")]
        public string Yoda()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("quote.yoda", this))));
        }
    }
    
    [FakerGenerator("Quotes")]
    public class QuotesGenerator : GeneratorBase
    {
        [FakerMethod("Chiquito")]
        public ChiquitoGenerator Chiquito { get; }
        [FakerMethod("Rajnikanth")]
        public RajnikanthGenerator Rajnikanth { get; }
        [FakerMethod("Shakespeare")]
        public ShakespeareGenerator Shakespeare { get; }
        internal QuotesGenerator(Faker faker)
                 : base(faker)
        {
            Chiquito = new ChiquitoGenerator(_faker);
            Rajnikanth = new RajnikanthGenerator(_faker);
            Shakespeare = new ShakespeareGenerator(_faker);
        }
        
        [FakerGenerator("Chiquito")]
        public class ChiquitoGenerator : GeneratorBase
        {
            internal ChiquitoGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method expression();
            [FakerMethod("expressions")]
            public string Expressions()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chiquito.expressions", this))));
            }
            #warning No implementation defined for method joke();
            [FakerMethod("jokes")]
            public string Jokes()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chiquito.jokes", this))));
            }
            #warning No implementation defined for method sentence();
            [FakerMethod("sentences")]
            public string Sentences()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chiquito.sentences", this))));
            }
            #warning No implementation defined for method term();
            [FakerMethod("terms")]
            public string Terms()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chiquito.terms", this))));
            }
        }
        
        [FakerGenerator("Rajnikanth")]
        public class RajnikanthGenerator : GeneratorBase
        {
            internal RajnikanthGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a Rajnikanth.
            ///                                 <p>Original list of jokes: <a href="http://www.rajinikanthjokes.com">www.rajinikanthjokes.com</a>/</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Rajnikanth.joke
            /// #=> "Rajinikanth is so fast that he always comes yesterday."</code>
            /// </example>
            [FakerMethod("joke")]
            public string Joke()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rajnikanth.joke", this))));
            }
        }
        
        [FakerGenerator("Shakespeare")]
        public class ShakespeareGenerator : GeneratorBase
        {
            internal ShakespeareGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Generates quote from 'As you like it!'.
            ///                                 <p>Generates quote from ‘As you like it!’</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Quotes::Shakespeare.as_you_like_it   #=> "How bitter a thing it is to look into happiness through another man's eyes!"</code>
            /// </example>
            [FakerMethod("as_you_like_it")]
            public string AsYouLikeIt()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("shakespeare.as_you_like_it", this))));
            }
            #warning No implementation defined for method as_you_like_it_quote();
            /// <summary>
            /// Generates quote from Hamlet.
            ///                                 <p>Generates quote from Hamlet</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Quotes::Shakespeare.hamlet   #=> "A little more than kin, and less than kind."</code>
            /// </example>
            [FakerMethod("hamlet")]
            public string Hamlet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("shakespeare.hamlet", this))));
            }
            #warning No implementation defined for method hamlet_quote();
            /// <summary>
            /// Returns quote from 'King Rechard III'.
            ///                                 <p>Returns quote from ‘King Rechard III’</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Quotes::Shakespeare  #=> "The king's name is a tower of strength."</code>
            /// </example>
            [FakerMethod("king_richard_iii")]
            public string KingRichardIii()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("shakespeare.king_richard_iii", this))));
            }
            #warning No implementation defined for method king_richard_iii_quote();
            /// <summary>
            /// Quote from 'Romeo and Juliet'.
            ///                                 <p>Quote from ‘Romeo and Juliet’</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::Quotes::Shakespeare.romeo_and_juliet  #=> "Wisely and slow; they stumble that run fast."</code>
            /// </example>
            [FakerMethod("romeo_and_juliet")]
            public string RomeoAndJuliet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("shakespeare.romeo_and_juliet", this))));
            }
            #warning No implementation defined for method romeo_and_juliet_quote();
        }
        
    }
    
    [FakerGenerator("Relationship")]
    public class RelationshipGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("relationship.in_law", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("relationship.parent", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("relationship.sibling", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("relationship.spouse", this))));
        }
    }
    
    [FakerGenerator("Restaurant")]
    public class RestaurantGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("restaurant.description", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("restaurant.name", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("restaurant.review", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("restaurant.type", this))));
        }
    }
    
    [FakerGenerator("Science")]
    public class ScienceGenerator : GeneratorBase
    {
        internal ScienceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a element.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.element #=> "Carbon"</code>
        /// </example>
        [FakerMethod("element")]
        public string Element()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.element", this))));
        }
        /// <summary>
        /// Produces the state of an element.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.element_state #=> "Liquid"</code>
        /// </example>
        [FakerMethod("element_state")]
        public string ElementState()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.element_state", this))));
        }
        /// <summary>
        /// Produces the subcategory of an element.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.element_subcategory #=> "Reactive nonmetal"</code>
        /// </example>
        [FakerMethod("element_subcategory")]
        public string ElementSubcategory()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.element_subcategory", this))));
        }
        /// <summary>
        /// Produces the symbol of an element.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.element_symbol #=> "Pb"</code>
        /// </example>
        [FakerMethod("element_symbol")]
        public string ElementSymbol()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.element_symbol", this))));
        }
        /// <summary>
        /// Produces a scientifically sounding word.
        ///                             <p>Produces a scientifically sounding word</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Science.modifier #=> "Quantum"
        /// Faker::Science.modifier #=> "Superconductive"</code>
        /// </example>
        [FakerMethod("modifier")]
        public string Modifier()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.modifier", this))));
        }
        #warning No implementation defined for method science(List<UNKNOWN_Symbol> branches);
        /// <summary>
        /// Produces the name of a scientist.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.scientist #=> "Isaac Newton"</code>
        /// </example>
        [FakerMethod("scientist")]
        public string Scientist()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.scientist", this))));
        }
        /// <summary>
        /// Produces the name of a scientific tool.
        ///                             <p>By default it uses a science word modifier to generate more diverse data, which can be disabled.</p>
        ///                         
        /// </summary>
        /// <param name="simple">
        /// 
        /// <p>Whether to generate simple realistic tool names, (no Q-word).</p>
        /// 
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Science.tool #=> "Superconductive Microcentrifuge"
        /// Faker::Science.tool #=> "Portable Cryostat"
        /// Faker::Science.tool #=> "Quantum Spectrophotometer"
        /// Faker::Science.tool(simple: true) #=> "Microcentrifuge"</code>
        /// </example>
        [FakerMethod("tool")]
        public string Tool(bool simple = false)
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("science.tool", this))));
        }
    }
    
    [FakerGenerator("Show")]
    public class ShowGenerator : GeneratorBase
    {
        internal ShowGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a musical for an older audience.
        ///                             <p>Produces the name of a musical for an older audience</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Alphanumeric.alpha
        /// #=> "West Side Story"</code>
        /// </example>
        [FakerMethod("adult_musical")]
        public string AdultMusical()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("show.adult_musical", this))));
        }
        /// <summary>
        /// Produces the name of a musical for a younger audience.
        ///                             <p>Produces the name of a musical for a younger audience</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Alphanumeric.alpha
        /// #=> "Into the Woods JR."</code>
        /// </example>
        [FakerMethod("kids_musical")]
        public string KidsMusical()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("show.kids_musical", this))));
        }
        /// <summary>
        /// Produces the name of a play.
        ///                             <p>Produces the name of a play</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Alphanumeric.alpha
        /// #=> "Death of a Salesman"</code>
        /// </example>
        [FakerMethod("play")]
        public string Play()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("show.play", this))));
        }
    }
    
    [FakerGenerator("SlackEmoji")]
    public class SlackEmojiGenerator : GeneratorBase
    {
        internal SlackEmojiGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random slack emoji from activity category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.activity #=> ":soccer:"</code>
        /// </example>
        [FakerMethod("activity")]
        public string Activity()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.activity", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from celebration category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.celebration #=> ":tada:"</code>
        /// </example>
        [FakerMethod("celebration")]
        public string Celebration()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.celebration", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from custom category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.custom #=> ":slack:"</code>
        /// </example>
        [FakerMethod("custom")]
        public string Custom()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.custom", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from any category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.emoji #=> ":pizza:"</code>
        /// </example>
        [FakerMethod("emoji")]
        public string Emoji()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.emoji", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from food and drink category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.food_and_drink #=> ":beers:"</code>
        /// </example>
        [FakerMethod("food_and_drink")]
        public string FoodAndDrink()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.food_and_drink", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from nature category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.nature #=> ":mount_fuji:"</code>
        /// </example>
        [FakerMethod("nature")]
        public string Nature()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.nature", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from objects and symbols category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.objects_and_symbols #=> ":id:"</code>
        /// </example>
        [FakerMethod("objects_and_symbols")]
        public string ObjectsAndSymbols()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.objects_and_symbols", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from people category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.people #=> ":sleepy:"</code>
        /// </example>
        [FakerMethod("people")]
        public string People()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.people", this))));
        }
        /// <summary>
        /// Produces a random slack emoji from travel and places category.
        /// </summary>
        /// <example>
        /// <code>Faker::SlackEmoji.travel_and_places #=> ":metro:"</code>
        /// </example>
        [FakerMethod("travel_and_places")]
        public string TravelAndPlaces()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("slack_emoji.travel_and_places", this))));
        }
    }
    
    [FakerGenerator("Source")]
    public class SourceGenerator : GeneratorBase
    {
        internal SourceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces source code for Hello World in a given language.
        /// </summary>
        /// <param name="lang">
        /// The programming language to use
        /// (default value "'ruby'")
        /// </param>
        /// <example>
        /// <code>Faker::Source.hello_world #=> "puts 'Hello World!'"</code>
        /// </example>
        [FakerMethod("hello_world")]
        public string HelloWorld(string lang = "ruby")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("source.hello_world." + lang + "", this))));
        }
        /// <summary>
        /// Produces source code for printing a string in a given language.
        /// </summary>
        /// <param name="str">
        /// 
        /// <p>The string to print</p>
        /// 
        /// </param>
        /// <param name="lang">
        /// The programming language to use
        /// (default value "'ruby'")
        /// </param>
        /// <example>
        /// <code>Faker::Source.print #=> "puts 'faker_string_to_print'"</code>
        /// </example>
        [FakerMethod("print")]
        public string Print(string str, string lang = "ruby")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("source.print." + lang + "", this))));
        }
        /// <summary>
        /// Produces source code for printing 1 through 10 in a given language.
        /// </summary>
        /// <param name="lang">
        /// The programming language to use
        /// (default value "'ruby'")
        /// </param>
        /// <example>
        /// <code>Faker::Source.print_1_to_10 #=> "(1..10).each { |i| puts i }"</code>
        /// </example>
        [FakerMethod("print_1_to_10")]
        public string Print1To10(string lang = "ruby")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("source.print_1_to_10." + lang + "", this))));
        }
    }
    
    [FakerGenerator("SouthAfrica")]
    public class SouthAfricaGenerator : GeneratorBase
    {
        internal SouthAfricaGenerator(Faker faker)
                 : base(faker)
        {
        }
        
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
    
    [FakerGenerator("Space")]
    public class SpaceGenerator : GeneratorBase
    {
        internal SpaceGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the name of a space agency.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.agency #=> "Japan Aerospace Exploration Agency"</code>
        /// </example>
        [FakerMethod("agency")]
        public string Agency()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.agency", this))));
        }
        /// <summary>
        /// Produces a space agency abbreviation.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.agency_abv #=> "NASA"</code>
        /// </example>
        [FakerMethod("agency_abv")]
        public string AgencyAbv()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.agency_abv", this))));
        }
        /// <summary>
        /// Produces the name of a space company.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.company #=> "SpaceX"</code>
        /// </example>
        [FakerMethod("company")]
        public string Company()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.company", this))));
        }
        /// <summary>
        /// Produces the name of a constellation.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.constellation #=> "Orion"</code>
        /// </example>
        [FakerMethod("constellation")]
        public string Constellation()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.constellation", this))));
        }
        /// <summary>
        /// Produces a distance measurement.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.distance_measurement #=> "15 parsecs"</code>
        /// </example>
        [FakerMethod("distance_measurement")]
        public string DistanceMeasurement()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.distance_measurement", this))));
        }
        /// <summary>
        /// Produces the name of a galaxy.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.galaxy #=> "Andromeda"</code>
        /// </example>
        [FakerMethod("galaxy")]
        public string Galaxy()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.galaxy", this))));
        }
        /// <summary>
        /// Produces the name of a launch vehicle.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.launch_vehicle #=> "Saturn IV"</code>
        /// </example>
        [FakerMethod("launch_vehicle")]
        public string LaunchVehicle()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.launch_vehicle", this))));
        }
        /// <summary>
        /// Produces the name of a meteorite.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.meteorite #=> "Ensisheim"</code>
        /// </example>
        [FakerMethod("meteorite")]
        public string Meteorite()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.meteorite", this))));
        }
        /// <summary>
        /// Produces the name of a moon.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.moon #=> "Europa"</code>
        /// </example>
        [FakerMethod("moon")]
        public string Moon()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.moon", this))));
        }
        /// <summary>
        /// Produces the name of a NASA spacecraft.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.nasa_space_craft #=> "Endeavour"</code>
        /// </example>
        [FakerMethod("nasa_space_craft")]
        public string NasaSpaceCraft()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.nasa_space_craft", this))));
        }
        /// <summary>
        /// Produces the name of a nebula.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.nebula #=> "Triffid Nebula"</code>
        /// </example>
        [FakerMethod("nebula")]
        public string Nebula()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.nebula", this))));
        }
        /// <summary>
        /// Produces the name of a planet.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.planet #=> "Venus"</code>
        /// </example>
        [FakerMethod("planet")]
        public string Planet()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.planet", this))));
        }
        /// <summary>
        /// Produces the name of a star.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.star #=> "Proxima Centauri"</code>
        /// </example>
        [FakerMethod("star")]
        public string Star()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.star", this))));
        }
        /// <summary>
        /// Produces the name of a star cluster.
        /// </summary>
        /// <example>
        /// <code>Faker::Space.star_cluster #=> "Messier 70"</code>
        /// </example>
        [FakerMethod("star_cluster")]
        public string StarCluster()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("space.star_cluster", this))));
        }
    }
    
    [FakerGenerator("Sport")]
    public class SportGenerator : GeneratorBase
    {
        internal SportGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a sport from the ancient olympics.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.ancient_olympics_sport #=> "Pankration"</code>
        /// </example>
        [FakerMethod("ancient_olympics_sport")]
        public string AncientOlympicsSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.ancient_olympics", this))));
        }
        /// <summary>
        /// Produces a sport from the modern olympics or paralympics, summer or winter.
        /// </summary>
        /// <param name="includeAncient">
        /// 
        /// <p>If true, may produce a sport from the ancient olympics</p>
        /// 
        /// </param>
        /// <param name="includeUnusual">
        /// 
        /// <p>If true, may produce an unusual (definitely not olympic) sport</p>
        /// 
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Sport.sport #=> "Football"</code>
        /// </example>
        [FakerMethod("sport")]
        public string Sport(bool includeAncient, bool includeUnusual = false)
        {
            return this.Resolve("sport.summer_olympics", this);
        }
        /// <summary>
        /// Produces a sport from the summer olympics.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.summer_olympics_sport #=> "Archery"</code>
        /// </example>
        [FakerMethod("summer_olympics_sport")]
        public string SummerOlympicsSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.summer_olympics", this))));
        }
        /// <summary>
        /// Produces a sport from the summer paralympics.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.summer_paralympics_sport #=> "Wheelchair Basketball"</code>
        /// </example>
        [FakerMethod("summer_paralympics_sport")]
        public string SummerParalympicsSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.summer_paralympics", this))));
        }
        /// <summary>
        /// Produces an unusual sport.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.unusual_sport #=> "Camel Jumping"</code>
        /// </example>
        [FakerMethod("unusual_sport")]
        public string UnusualSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.unusual", this))));
        }
        /// <summary>
        /// Produces a sport from the winter olympics.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.winter_olympics_sport #=> "Bobsleigh"</code>
        /// </example>
        [FakerMethod("winter_olympics_sport")]
        public string WinterOlympicsSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.winter_olympics", this))));
        }
        /// <summary>
        /// Produces a sport from the winter paralympics.
        /// </summary>
        /// <example>
        /// <code>Faker::Sport.winter_paralympics_sport #=> "Para Ice Hockey"</code>
        /// </example>
        [FakerMethod("winter_paralympics_sport")]
        public string WinterParalympicsSport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("sport.winter_paralympics", this))));
        }
    }
    
    [FakerGenerator("Sports")]
    public class SportsGenerator : GeneratorBase
    {
        [FakerMethod("Basketball")]
        public BasketballGenerator Basketball { get; }
        [FakerMethod("Chess")]
        public ChessGenerator Chess { get; }
        [FakerMethod("Football")]
        public FootballGenerator Football { get; }
        [FakerMethod("Mountaineering")]
        public MountaineeringGenerator Mountaineering { get; }
        [FakerMethod("Volleyball")]
        public VolleyballGenerator Volleyball { get; }
        internal SportsGenerator(Faker faker)
                 : base(faker)
        {
            Basketball = new BasketballGenerator(_faker);
            Chess = new ChessGenerator(_faker);
            Football = new FootballGenerator(_faker);
            Mountaineering = new MountaineeringGenerator(_faker);
            Volleyball = new VolleyballGenerator(_faker);
        }
        
        [FakerGenerator("Basketball")]
        public class BasketballGenerator : GeneratorBase
        {
            internal BasketballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a basketball coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Basketball.coach #=> "Gregg Popovich"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("basketball.coaches", this))));
            }
            /// <summary>
            /// Produces the name of a basketball player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Basketball.player #=> "LeBron James"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("basketball.players", this))));
            }
            /// <summary>
            /// Produces a position in basketball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Basketball.position #=> "Point Guard"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("basketball.positions", this))));
            }
            /// <summary>
            /// Produces the name of a basketball team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Basketball.team #=> "Golden State Warriors"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("basketball.teams", this))));
            }
        }
        
        [FakerGenerator("Chess")]
        public class ChessGenerator : GeneratorBase
        {
            internal ChessGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method federation();
            /// <summary>
            /// Produces the name of a chess opening.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Chess.opening #=> "Giuoco Piano"</code>
            /// </example>
            [FakerMethod("opening")]
            public string Opening()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chess.openings", this))));
            }
            /// <summary>
            /// Produces the name of a chess player name.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Chess.player #=> "Golden State Warriors"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chess.players", this))));
            }
            #warning No implementation defined for method rating();
            /// <summary>
            /// Produces a chess title.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Chess.title #=> "GM"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chess.titles", this))));
            }
            [FakerMethod("tournament")]
            public string Tournament()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("chess.tournaments", this))));
            }
        }
        
        [FakerGenerator("Football")]
        public class FootballGenerator : GeneratorBase
        {
            internal FootballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a football coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Football.coach #=> "Jose Mourinho"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("football.coaches", this))));
            }
            /// <summary>
            /// Produces a football competition.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Football.competition #=> "FIFA World Cup"</code>
            /// </example>
            [FakerMethod("competition")]
            public string Competition()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("football.competitions", this))));
            }
            /// <summary>
            /// Produces the name of a football player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Football.player #=> "Lionel Messi"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("football.players", this))));
            }
            /// <summary>
            /// Produces a position in football.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Football.position #=> "Defensive Midfielder"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("football.positions", this))));
            }
            /// <summary>
            /// Produces the name of a football team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Football.team #=> "Manchester United"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("football.teams", this))));
            }
        }
        
        [FakerGenerator("Mountaineering")]
        public class MountaineeringGenerator : GeneratorBase
        {
            internal MountaineeringGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Mountaineer.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Mountaineering.mountaineer #=> "Junko Tabei"</code>
            /// </example>
            [FakerMethod("mountaineer")]
            public string Mountaineer()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("mountaineering.mountaineer", this))));
            }
        }
        
        [FakerGenerator("Volleyball")]
        public class VolleyballGenerator : GeneratorBase
        {
            internal VolleyballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a volleyball coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Volleyball.coach #=> "Russ Rose"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("volleyball.coach", this))));
            }
            /// <summary>
            /// Produces a formation in volleyball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Volleyball.formation #=> "4-2"</code>
            /// </example>
            [FakerMethod("formation")]
            public string Formation()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("volleyball.formation", this))));
            }
            /// <summary>
            /// Produces the name of a volleyball player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Volleyball.player #=> "Saeid Marouf"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("volleyball.player", this))));
            }
            /// <summary>
            /// Produces a position in volleyball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Volleyball.position #=> "Middle blocker"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("volleyball.position", this))));
            }
            /// <summary>
            /// Produces the name of a volleyball team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sports::Volleyball.team #=> "Leo Shoes Modena"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("volleyball.team", this))));
            }
        }
        
    }
    
    [FakerGenerator("Stripe")]
    public class StripeGenerator : GeneratorBase
    {
        internal StripeGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method ccv(string? cardType = null);
        #warning No implementation defined for method invalid_card();
        #warning No implementation defined for method month();
        #warning No implementation defined for method valid_card(string? cardType = null);
        #warning No implementation defined for method valid_token(string? cardType = null);
        #warning No implementation defined for method year();
    }
    
    [FakerGenerator("Subscription")]
    public class SubscriptionGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("subscription.payment_methods", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("subscription.payment_terms", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("subscription.plans", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("subscription.statuses", this))));
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
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("subscription.subscription_terms", this))));
        }
    }
    
    [FakerGenerator("Superhero")]
    public class SuperheroGenerator : GeneratorBase
    {
        internal SuperheroGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a superhero descriptor.
        /// </summary>
        /// <example>
        /// <code>Faker::Superhero.descriptor #=> "Bizarro"</code>
        /// </example>
        [FakerMethod("descriptor")]
        public string Descriptor()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("superhero.descriptor", this))));
        }
        /// <summary>
        /// Produces a random superhero name.
        /// </summary>
        /// <example>
        /// <code>Faker::Superhero.name #=> "Magnificent Shatterstar"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("superhero.name", this))));
        }
        /// <summary>
        /// Produces a superpower.
        /// </summary>
        /// <example>
        /// <code>Faker::Superhero.power #=> "Photokinesis"</code>
        /// </example>
        [FakerMethod("power")]
        public string Power()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("superhero.power", this))));
        }
        /// <summary>
        /// Produces a superhero name prefix.
        /// </summary>
        /// <example>
        /// <code>Faker::Superhero.prefix #=> "the Fated"</code>
        /// </example>
        [FakerMethod("prefix")]
        public string Prefix()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("superhero.prefix", this))));
        }
        /// <summary>
        /// Produces a superhero name suffix.
        /// </summary>
        /// <example>
        /// <code>Faker::Superhero.suffix #=> "Captain"</code>
        /// </example>
        [FakerMethod("suffix")]
        public string Suffix()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("superhero.suffix", this))));
        }
    }
    
    [FakerGenerator("Tea")]
    public class TeaGenerator : GeneratorBase
    {
        internal TeaGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method type();
        /// <summary>
        /// Produces a random variety or blend of tea.
        /// </summary>
        /// <param name="type">
        /// 
        /// <p>the type of tea to query for (valid types: ‘Black’, ‘Green’, ‘Oolong’, ‘White’, and ‘Herbal’)</p>
        /// 
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Tea.variety
        /// #=> "Earl Grey"</code>
        /// </example>
        [FakerMethod("variety")]
        public string Variety(string? type = null)
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("tea.type", this))));
        }
    }
    
    [FakerGenerator("Team")]
    public class TeamGenerator : GeneratorBase
    {
        internal TeamGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a team creature.
        /// </summary>
        /// <example>
        /// <code>Faker::Team.creature #=> "geese"</code>
        /// </example>
        [FakerMethod("creature")]
        public string Creature()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("team.creature", this))));
        }
        /// <summary>
        /// Produces the name of a team mascot.
        /// </summary>
        /// <example>
        /// <code>Faker::Team.mascot #=> "Hugo"</code>
        /// </example>
        [FakerMethod("mascot")]
        public string Mascot()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("team.mascot", this))));
        }
        /// <summary>
        /// Produces a team name from a state and a creature.
        /// </summary>
        /// <example>
        /// <code>Faker::Team.name #=> "Oregon vixens"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("team.name", this))));
        }
        /// <summary>
        /// Produces a team sport.
        /// </summary>
        /// <example>
        /// <code>Faker::Team.sport #=> "Lacrosse"</code>
        /// </example>
        [FakerMethod("sport")]
        public string Sport()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("team.sport", this))));
        }
        /// <summary>
        /// Produces a team state.
        /// </summary>
        /// <example>
        /// <code>Faker::Team.state #=> "Oregon"</code>
        /// </example>
        [FakerMethod("state")]
        public string State()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("address.state", this))));
        }
    }
    
    [FakerGenerator("Time")]
    public class TimeGenerator : GeneratorBase
    {
        internal TimeGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method backward(long days, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
        #warning No implementation defined for method between(UNKNOWN_Time from, UNKNOWN_Time to, UNKNOWN_Symbol? format = null);
        #warning No implementation defined for method between_dates(DateOnly from, DateOnly to, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
        #warning Failed processing method date_with_random_time
        #warning No implementation defined for method forward(long days, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
        #warning Failed processing method get_time_object
        #warning Failed processing method hours
        #warning Failed processing method minutes
        #warning Failed processing method seconds
        #warning Failed processing method time_with_format
    }
    
    [FakerGenerator("Travel")]
    public class TravelGenerator : GeneratorBase
    {
        [FakerMethod("Airport")]
        public AirportGenerator Airport { get; }
        [FakerMethod("TrainStation")]
        public TrainStationGenerator TrainStation { get; }
        internal TravelGenerator(Faker faker)
                 : base(faker)
        {
            Airport = new AirportGenerator(_faker);
            TrainStation = new TrainStationGenerator(_faker);
        }
        
        [FakerGenerator("Airport")]
        public class AirportGenerator : GeneratorBase
        {
            internal AirportGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces random Airport by IATA code and takes arguments for size and region.
            ///                                 <p>Produces random Airport by IATA code and takes arguments for size and region</p>
            /// 
            ///                                 <p>Faker::Travel::Airport.iata(size: ‘large’, region: ‘united_states’) =&gt; “LAX”</p>
            ///                             
            /// </summary>
            /// <param name="size">
            /// 
            /// <p>airport size, united_states has large, or medium, or small, european_union has large, or medium</p>
            /// 
            /// </param>
            /// <param name="region">
            /// 
            /// <p>airport region, currently available -&gt; united_states or european_union</p>
            /// 
            /// </param>
            [FakerMethod("iata")]
            public string Iata(string size, string region)
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("airport." + region + ".iata_code." + size + "", this))));
            }
            /// <summary>
            /// Produces random Airport by name and takes arguments for size and region.
            ///                                 <p>Produces random Airport by name and takes arguments for size and region</p>
            /// 
            ///                                 <p>Faker::Travel::Airport.name(size: ‘large’, region: ‘united_states’) =&gt; “Los Angeles International Airport”</p>
            ///                             
            /// </summary>
            /// <param name="size">
            /// 
            /// <p>airport size, united_states has large, or medium, or small, european_union has large, or medium</p>
            /// 
            /// </param>
            /// <param name="region">
            /// 
            /// <p>airport region, currently available -&gt; united_states or european_union</p>
            /// 
            /// </param>
            [FakerMethod("name")]
            public string Name(string size, string region)
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("airport." + region + "." + size + "", this))));
            }
        }
        
        [FakerGenerator("TrainStation")]
        public class TrainStationGenerator : GeneratorBase
        {
            internal TrainStationGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method fill_missing_inputs_with_samples();
            /// <summary>
            /// Produces random Train Station by name and takes optional arguments for region and type.
            ///                                 <p>Produces random Train Station by name and takes optional arguments for region and type</p>
            /// 
            ///                                 <p>Faker::Travel::TrainStation.name(region: ‘united_kingdom’, type: ‘metro’) =&gt; “Brockley” Faker::Travel::TrainStation.name(type: ‘railway’) =&gt; “Düsseldorf Hauptbahnhof” Faker::Travel::TrainStation.name(region: ‘spain’) =&gt; “Santa Eulàlia”</p>
            ///                             
            /// </summary>
            /// <param name="region">
            /// 
            /// <p>Train station region: germany, spain, united_kingdom, united_states</p>
            /// 
            /// </param>
            /// <param name="type">
            /// 
            /// <p>Train station type: metro, railway</p>
            /// 
            /// (default value "nil")
            /// </param>
            [FakerMethod("name")]
            public string Name(string region, string? type = null)
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("train_station." + region + "." + type + "", this))));
            }
            #warning No implementation defined for method validate_arguments();
        }
        
    }
    
    [FakerGenerator("TvShows")]
    public class TvShowsGenerator : GeneratorBase
    {
        [FakerMethod("AquaTeenHungerForce")]
        public AquaTeenHungerForceGenerator AquaTeenHungerForce { get; }
        [FakerMethod("Archer")]
        public ArcherGenerator Archer { get; }
        [FakerMethod("BigBangTheory")]
        public BigBangTheoryGenerator BigBangTheory { get; }
        [FakerMethod("BojackHorseman")]
        public BojackHorsemanGenerator BojackHorseman { get; }
        [FakerMethod("BreakingBad")]
        public BreakingBadGenerator BreakingBad { get; }
        [FakerMethod("BrooklynNineNine")]
        public BrooklynNineNineGenerator BrooklynNineNine { get; }
        [FakerMethod("Buffy")]
        public BuffyGenerator Buffy { get; }
        [FakerMethod("Community")]
        public CommunityGenerator Community { get; }
        [FakerMethod("DrWho")]
        public DrWhoGenerator DrWho { get; }
        [FakerMethod("DumbAndDumber")]
        public DumbAndDumberGenerator DumbAndDumber { get; }
        [FakerMethod("FamilyGuy")]
        public FamilyGuyGenerator FamilyGuy { get; }
        [FakerMethod("FinalSpace")]
        public FinalSpaceGenerator FinalSpace { get; }
        [FakerMethod("Friends")]
        public FriendsGenerator Friends { get; }
        [FakerMethod("Futurama")]
        public FuturamaGenerator Futurama { get; }
        [FakerMethod("GameOfThrones")]
        public GameOfThronesGenerator GameOfThrones { get; }
        [FakerMethod("HeyArnold")]
        public HeyArnoldGenerator HeyArnold { get; }
        [FakerMethod("HowIMetYourMother")]
        public HowIMetYourMotherGenerator HowIMetYourMother { get; }
        [FakerMethod("MichaelScott")]
        public MichaelScottGenerator MichaelScott { get; }
        [FakerMethod("NewGirl")]
        public NewGirlGenerator NewGirl { get; }
        [FakerMethod("ParksAndRec")]
        public ParksAndRecGenerator ParksAndRec { get; }
        [FakerMethod("RickAndMorty")]
        public RickAndMortyGenerator RickAndMorty { get; }
        [FakerMethod("RuPaul")]
        public RuPaulGenerator RuPaul { get; }
        [FakerMethod("Seinfeld")]
        public SeinfeldGenerator Seinfeld { get; }
        [FakerMethod("SiliconValley")]
        public SiliconValleyGenerator SiliconValley { get; }
        [FakerMethod("Simpsons")]
        public SimpsonsGenerator Simpsons { get; }
        [FakerMethod("SouthPark")]
        public SouthParkGenerator SouthPark { get; }
        [FakerMethod("Spongebob")]
        public SpongebobGenerator Spongebob { get; }
        [FakerMethod("StarTrek")]
        public StarTrekGenerator StarTrek { get; }
        [FakerMethod("Stargate")]
        public StargateGenerator Stargate { get; }
        [FakerMethod("StrangerThings")]
        public StrangerThingsGenerator StrangerThings { get; }
        [FakerMethod("Suits")]
        public SuitsGenerator Suits { get; }
        [FakerMethod("Supernatural")]
        public SupernaturalGenerator Supernatural { get; }
        [FakerMethod("TheExpanse")]
        public TheExpanseGenerator TheExpanse { get; }
        [FakerMethod("TheFreshPrinceOfBelAir")]
        public TheFreshPrinceOfBelAirGenerator TheFreshPrinceOfBelAir { get; }
        [FakerMethod("TheITCrowd")]
        public TheITCrowdGenerator TheITCrowd { get; }
        [FakerMethod("TheOffice")]
        public TheOfficeGenerator TheOffice { get; }
        [FakerMethod("TheThickOfIt")]
        public TheThickOfItGenerator TheThickOfIt { get; }
        [FakerMethod("TwinPeaks")]
        public TwinPeaksGenerator TwinPeaks { get; }
        [FakerMethod("VentureBros")]
        public VentureBrosGenerator VentureBros { get; }
        internal TvShowsGenerator(Faker faker)
                 : base(faker)
        {
            AquaTeenHungerForce = new AquaTeenHungerForceGenerator(_faker);
            Archer = new ArcherGenerator(_faker);
            BigBangTheory = new BigBangTheoryGenerator(_faker);
            BojackHorseman = new BojackHorsemanGenerator(_faker);
            BreakingBad = new BreakingBadGenerator(_faker);
            BrooklynNineNine = new BrooklynNineNineGenerator(_faker);
            Buffy = new BuffyGenerator(_faker);
            Community = new CommunityGenerator(_faker);
            DrWho = new DrWhoGenerator(_faker);
            DumbAndDumber = new DumbAndDumberGenerator(_faker);
            FamilyGuy = new FamilyGuyGenerator(_faker);
            FinalSpace = new FinalSpaceGenerator(_faker);
            Friends = new FriendsGenerator(_faker);
            Futurama = new FuturamaGenerator(_faker);
            GameOfThrones = new GameOfThronesGenerator(_faker);
            HeyArnold = new HeyArnoldGenerator(_faker);
            HowIMetYourMother = new HowIMetYourMotherGenerator(_faker);
            MichaelScott = new MichaelScottGenerator(_faker);
            NewGirl = new NewGirlGenerator(_faker);
            ParksAndRec = new ParksAndRecGenerator(_faker);
            RickAndMorty = new RickAndMortyGenerator(_faker);
            RuPaul = new RuPaulGenerator(_faker);
            Seinfeld = new SeinfeldGenerator(_faker);
            SiliconValley = new SiliconValleyGenerator(_faker);
            Simpsons = new SimpsonsGenerator(_faker);
            SouthPark = new SouthParkGenerator(_faker);
            Spongebob = new SpongebobGenerator(_faker);
            StarTrek = new StarTrekGenerator(_faker);
            Stargate = new StargateGenerator(_faker);
            StrangerThings = new StrangerThingsGenerator(_faker);
            Suits = new SuitsGenerator(_faker);
            Supernatural = new SupernaturalGenerator(_faker);
            TheExpanse = new TheExpanseGenerator(_faker);
            TheFreshPrinceOfBelAir = new TheFreshPrinceOfBelAirGenerator(_faker);
            TheITCrowd = new TheITCrowdGenerator(_faker);
            TheOffice = new TheOfficeGenerator(_faker);
            TheThickOfIt = new TheThickOfItGenerator(_faker);
            TwinPeaks = new TwinPeaksGenerator(_faker);
            VentureBros = new VentureBrosGenerator(_faker);
        }
        
        [FakerGenerator("AquaTeenHungerForce")]
        public class AquaTeenHungerForceGenerator : GeneratorBase
        {
            internal AquaTeenHungerForceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Aqua Teen Hunger Force.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::AquaTeenHungerForce.character #=> "Master Shake"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("aqua_teen_hunger_force.character", this))));
            }
            /// <summary>
            /// Produces a perl of great ATHF wisdom.
            ///                                 <p>Produces a perl of great ATHF wisdom</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::AquaTeenHungerForce.quote #=> "Friendship ain't about trust. Friendship's about nunchucks."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("aqua_teen_hunger_force.quote", this))));
            }
        }
        
        [FakerGenerator("Archer")]
        public class ArcherGenerator : GeneratorBase
        {
            internal ArcherGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Archer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Archer.character #=> "Sterling Archer"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("archer.characters", this))));
            }
            /// <summary>
            /// Produces a location from Archer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Archer.location #=> "The Tuntmore Towers"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("archer.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Archer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Archer.quote
            /// #=> "You're not my supervisor!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("archer.quotes", this))));
            }
        }
        
        [FakerGenerator("BigBangTheory")]
        public class BigBangTheoryGenerator : GeneratorBase
        {
            internal BigBangTheoryGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Big Bang Theory.
            ///                                 <p>Produces a character from Big Bang Theory</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BigBangTheory.character #=> "Sheldon Cooper"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("big_bang_theory.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Bing Bang Theory.
            ///                                 <p>Produces a quote from Bing Bang Theory</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BigBangTheory.quote #=> "I'm not crazy. My mother had me tested."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("big_bang_theory.quotes", this))));
            }
        }
        
        [FakerGenerator("BojackHorseman")]
        public class BojackHorsemanGenerator : GeneratorBase
        {
            internal BojackHorsemanGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from BoJack Horseman.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BojackHorseman.character #=> "BoJack Horseman"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("bojack_horseman.characters", this))));
            }
            /// <summary>
            /// Produces a quote from BoJack Horseman.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BojackHorseman.quote
            /// #=> "Not understanding that you're a horrible person doesn't make you less of a horrible person."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("bojack_horseman.quotes", this))));
            }
            /// <summary>
            /// Produces a tongue twister from BoJack Horseman.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BojackHorseman.tongue_twister #=> "Did you steal a meal from Neal McBeal the Navy Seal?"</code>
            /// </example>
            [FakerMethod("tongue_twister")]
            public string TongueTwister()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("bojack_horseman.tongue_twisters", this))));
            }
        }
        
        [FakerGenerator("BreakingBad")]
        public class BreakingBadGenerator : GeneratorBase
        {
            internal BreakingBadGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Breaking Bad.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BreakingBad.character #=> "Walter White"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("breaking_bad.character", this))));
            }
            /// <summary>
            /// Produces the name of an episode from Breaking Bad.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BreakingBad.episode #=> "Fly"</code>
            /// </example>
            [FakerMethod("episode")]
            public string Episode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("breaking_bad.episode", this))));
            }
        }
        
        [FakerGenerator("BrooklynNineNine")]
        public class BrooklynNineNineGenerator : GeneratorBase
        {
            internal BrooklynNineNineGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Brooklyn Nine Nine.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BrooklynNineNine.character #=> "Jake Peralta"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("brooklyn_nine_nine.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Brooklyn Nine Nine.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BrooklynNineNine.quote
            /// #=> "Cool, cool, cool, cool, cool. No doubt, no doubt, no doubt."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("brooklyn_nine_nine.quotes", this))));
            }
        }
        
        [FakerGenerator("Buffy")]
        public class BuffyGenerator : GeneratorBase
        {
            internal BuffyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a actor from Buffy the Vampire Slayer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Buffy.actor #=> "John Ritter"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("buffy.actors", this))));
            }
            /// <summary>
            /// Produces a big bad from Buffy the Vampire Slayer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Buffy.big_bad #=> "Glory"</code>
            /// </example>
            [FakerMethod("big_bad")]
            public string BigBad()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("buffy.big_bads", this))));
            }
            /// <summary>
            /// Produces a character from Buffy the Vampire Slayer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Buffy.character #=> "Buffy Summers"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("buffy.characters", this))));
            }
            /// <summary>
            /// Produces an episode from Buffy the Vampire Slayer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Buffy.episode #=> "Once More, with Feeling"</code>
            /// </example>
            [FakerMethod("episode")]
            public string Episode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("buffy.episodes", this))));
            }
            /// <summary>
            /// Produces a quote from Buffy the Vampire Slayer.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Buffy.quote #=> "If the apocalypse comes, beep me."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("buffy.quotes", this))));
            }
        }
        
        [FakerGenerator("Community")]
        public class CommunityGenerator : GeneratorBase
        {
            internal CommunityGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Community.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Community.characters #=> "Jeff Winger"</code>
            /// </example>
            [FakerMethod("characters")]
            public string Characters()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("community.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Community.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Community.quotes
            /// #=> "I fear a political career could shine a negative light on my drug dealing."</code>
            /// </example>
            [FakerMethod("quotes")]
            public string Quotes()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("community.quotes", this))));
            }
        }
        
        [FakerGenerator("DrWho")]
        public class DrWhoGenerator : GeneratorBase
        {
            internal DrWhoGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.actor #=> "Matt Smith"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.actors", this))));
            }
            /// <summary>
            /// Produces a catch phrase from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.catch_phrase #=> "Fantastic!"</code>
            /// </example>
            [FakerMethod("catch_phrase")]
            public string CatchPhrase()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.catch_phrases", this))));
            }
            /// <summary>
            /// Produces a character from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.character #=> "Captain Jack Harkness"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.character", this))));
            }
            /// <summary>
            /// Produces a quote from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.quote #=> "Lots of planets have a north!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.quotes", this))));
            }
            /// <summary>
            /// Produces a species from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.specie #=> "Dalek"</code>
            /// </example>
            [FakerMethod("specie")]
            public string Specie()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.species", this))));
            }
            /// <summary>
            /// Produces an iteration of The Doctor from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.the_doctor #=> "Ninth Doctor"</code>
            /// </example>
            [FakerMethod("the_doctor")]
            public string TheDoctor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.the_doctors", this))));
            }
            /// <summary>
            /// Produces a villain from Doctor Who.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DrWho.villain #=> "The Master"</code>
            /// </example>
            [FakerMethod("villain")]
            public string Villain()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dr_who.villains", this))));
            }
        }
        
        [FakerGenerator("DumbAndDumber")]
        public class DumbAndDumberGenerator : GeneratorBase
        {
            internal DumbAndDumberGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from Dumb and Dumber.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DumbAndDumber.actor #=> "Jim Carrey"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dumb_and_dumber.actors", this))));
            }
            /// <summary>
            /// Produces a character from Dumb and Dumber.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DumbAndDumber.character #=> "Harry Dunne"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dumb_and_dumber.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Dumb and Dumber.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::DumbAndDumber.quote
            /// #=> "Why you going to the airport? Flying somewhere?"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("dumb_and_dumber.quotes", this))));
            }
        }
        
        [FakerGenerator("FamilyGuy")]
        public class FamilyGuyGenerator : GeneratorBase
        {
            internal FamilyGuyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Family Guy.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FamilyGuy.character #=> "Peter Griffin"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("family_guy.character", this))));
            }
            /// <summary>
            /// Produces a location from Family Guy.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FamilyGuy.location #=> "James Woods High"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("family_guy.location", this))));
            }
            /// <summary>
            /// Produces a quote from Family Guy.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FamilyGuy.quote
            /// #=> "It's Peanut Butter Jelly Time."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("family_guy.quote", this))));
            }
        }
        
        [FakerGenerator("FinalSpace")]
        public class FinalSpaceGenerator : GeneratorBase
        {
            internal FinalSpaceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Final Space.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FinalSpace.character #=> "Gary Goodspeed"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("final_space.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Final Space.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FinalSpace.quote
            /// #=> "It's an alien on my face! It's an alien on my...It's a space alien!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("final_space.quotes", this))));
            }
            /// <summary>
            /// Produces a vehicle from Final Space.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::FinalSpace.vehicle #=> "Imperium Cruiser"</code>
            /// </example>
            [FakerMethod("vehicle")]
            public string Vehicle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("final_space.vehicles", this))));
            }
        }
        
        [FakerGenerator("Friends")]
        public class FriendsGenerator : GeneratorBase
        {
            internal FriendsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Friends.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Friends.character #=> "Rachel Green"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("friends.characters", this))));
            }
            /// <summary>
            /// Produces a location from Friends.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Friends.location #=> "Central Perk"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("friends.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Friends.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Friends.quote #=> "We were on a break!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("friends.quotes", this))));
            }
        }
        
        [FakerGenerator("Futurama")]
        public class FuturamaGenerator : GeneratorBase
        {
            internal FuturamaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Futurama.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Futurama.character #=> "Amy Wong"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("futurama.characters", this))));
            }
            /// <summary>
            /// Produces a catchphrase from Hermes Conrad.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Futurama.hermes_catchphrase
            /// #=> "Great foo of bar!"</code>
            /// </example>
            [FakerMethod("hermes_catchphrase")]
            public string HermesCatchphrase()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("futurama.hermes_catchphrases", this))));
            }
            /// <summary>
            /// Produces a location from Futurama.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Futurama.location #=> "Wormulon"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("futurama.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Futurama.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Futurama.quote
            /// #=> "Ugh, it's like a party in my mouth & everyone's throwing up."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("futurama.quotes", this))));
            }
        }
        
        [FakerGenerator("GameOfThrones")]
        public class GameOfThronesGenerator : GeneratorBase
        {
            internal GameOfThronesGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Game of Thrones.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::GameOfThrones.character #=> "Tyrion Lannister"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("game_of_thrones.characters", this))));
            }
            /// <summary>
            /// Produces a city from Game of Thrones.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::GameOfThrones.city #=> "Lannisport"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("game_of_thrones.cities", this))));
            }
            /// <summary>
            /// Produces a dragon from Game of Thrones.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::GameOfThrones.dragon #=> "Drogon"</code>
            /// </example>
            [FakerMethod("dragon")]
            public string Dragon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("game_of_thrones.dragons", this))));
            }
            /// <summary>
            /// Produces a house from Game of Thrones.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::GameOfThrones.house #=> "Stark"</code>
            /// </example>
            [FakerMethod("house")]
            public string House()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("game_of_thrones.houses", this))));
            }
            /// <summary>
            /// Produces a quote from Game of Thrones.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::GameOfThrones.quote
            /// #=> "Never forget who you are. The rest of the world won't. Wear it like an armor and it can never be used against you."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("game_of_thrones.quotes", this))));
            }
        }
        
        [FakerGenerator("HeyArnold")]
        public class HeyArnoldGenerator : GeneratorBase
        {
            internal HeyArnoldGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Hey Arnold!.
            ///                                 <p>Produces a character from Hey Arnold!</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.character #=> "Arnold"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hey_arnold.characters", this))));
            }
            /// <summary>
            /// Produces a location from Hey Arnold!.
            ///                                 <p>Produces a location from Hey Arnold!</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.location #=> "Big Bob's Beeper Emporium"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hey_arnold.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Hey Arnold!.
            ///                                 <p>Produces a quote from Hey Arnold!</p>
            ///                             
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.quote #=> "Stoop Kid's afraid to leave his stoop!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("hey_arnold.quotes", this))));
            }
        }
        
        [FakerGenerator("HowIMetYourMother")]
        public class HowIMetYourMotherGenerator : GeneratorBase
        {
            internal HowIMetYourMotherGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a catch phrase from How I Met Your Mother.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HowIMetYourMother.catch_phrase #=> "Legendary"</code>
            /// </example>
            [FakerMethod("catch_phrase")]
            public string CatchPhrase()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_i_met_your_mother.catch_phrase", this))));
            }
            /// <summary>
            /// Produces a character from How I Met Your Mother.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HowIMetYourMother.character #=> "Barney Stinson"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_i_met_your_mother.character", this))));
            }
            /// <summary>
            /// Produces a high five from How I Met Your Mother.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HowIMetYourMother.high_five #=> "Relapse Five"</code>
            /// </example>
            [FakerMethod("high_five")]
            public string HighFive()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_i_met_your_mother.high_five", this))));
            }
            /// <summary>
            /// Produces a quote from How I Met Your Mother.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HowIMetYourMother.quote
            /// #=> "Whenever I'm sad, I stop being sad and be awesome instead."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("how_i_met_your_mother.quote", this))));
            }
        }
        
        [FakerGenerator("MichaelScott")]
        public class MichaelScottGenerator : GeneratorBase
        {
            internal MichaelScottGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a quote from Michael Scott.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::MichaelScott.quote
            /// #=> "I am Beyoncé, always."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("michael_scott.quotes", this))));
            }
        }
        
        [FakerGenerator("NewGirl")]
        public class NewGirlGenerator : GeneratorBase
        {
            internal NewGirlGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from New Girl.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::NewGirl.character #=> "Jessica Day"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("new_girl.characters", this))));
            }
            /// <summary>
            /// Produces a quote from New Girl.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::NewGirl.quote
            /// #=> "Are you cooking a frittata in a sauce pan? What is this - prison?"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("new_girl.quotes", this))));
            }
        }
        
        [FakerGenerator("ParksAndRec")]
        public class ParksAndRecGenerator : GeneratorBase
        {
            internal ParksAndRecGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Parks and Recreation.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::ParksAndRec.character #=> "Leslie Knope"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("parks_and_rec.characters", this))));
            }
            /// <summary>
            /// Produces a city from Parks and Recreation.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::ParksAndRec.city #=> "Pawnee"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("parks_and_rec.cities", this))));
            }
        }
        
        [FakerGenerator("RickAndMorty")]
        public class RickAndMortyGenerator : GeneratorBase
        {
            internal RickAndMortyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Rick and Morty.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::RickAndMorty.character #=> "Rick Sanchez"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rick_and_morty.characters", this))));
            }
            /// <summary>
            /// Produces a location from Rick and Morty.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::RickAndMorty.location #=> "Dimension C-132"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rick_and_morty.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Rick and Morty.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::RickAndMorty.quote
            /// #=> "Ohh yea, you gotta get schwifty."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rick_and_morty.quotes", this))));
            }
        }
        
        [FakerGenerator("RuPaul")]
        public class RuPaulGenerator : GeneratorBase
        {
            internal RuPaulGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a queen from RuPaul's Drag Race.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::RuPaul.queen #=> "Latrice Royale"</code>
            /// </example>
            [FakerMethod("queen")]
            public string Queen()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rupaul.queens", this))));
            }
            /// <summary>
            /// Produces a quote from RuPaul's Drag Race.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::RuPaul.quote #=> "That's Funny, Tell Another One."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("rupaul.quotes", this))));
            }
        }
        
        [FakerGenerator("Seinfeld")]
        public class SeinfeldGenerator : GeneratorBase
        {
            internal SeinfeldGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a business from Seinfeld.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Seinfeld.business #=> "Kruger Industrial Smoothing"</code>
            /// </example>
            [FakerMethod("business")]
            public string Business()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("seinfeld.business", this))));
            }
            /// <summary>
            /// Produces a character from Seinfeld.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Seinfeld.character #=> "George Costanza"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("seinfeld.character", this))));
            }
            /// <summary>
            /// Produces a quote from Seinfeld.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Seinfeld.quote
            /// #=> "I'm not a lesbian. I hate men, but I'm not a lesbian."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("seinfeld.quote", this))));
            }
        }
        
        [FakerGenerator("SiliconValley")]
        public class SiliconValleyGenerator : GeneratorBase
        {
            internal SiliconValleyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an app from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.app #=> "Nip Alert"</code>
            /// </example>
            [FakerMethod("app")]
            public string App()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.apps", this))));
            }
            /// <summary>
            /// Produces a character from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.character #=> "Jian Yang"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.characters", this))));
            }
            /// <summary>
            /// Produces a company from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.company #=> "Bachmanity"</code>
            /// </example>
            [FakerMethod("company")]
            public string Company()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.companies", this))));
            }
            /// <summary>
            /// Produces an email address from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.email #=> "richard@piedpiper.test"</code>
            /// </example>
            [FakerMethod("email")]
            public string Email()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.email", this))));
            }
            /// <summary>
            /// Produces an invention from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.invention
            /// #=> "Tres Comas Tequila"</code>
            /// </example>
            [FakerMethod("invention")]
            public string Invention()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.inventions", this))));
            }
            /// <summary>
            /// Produces a motto from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.motto
            /// #=> "Our products are products, producing unrivaled results"</code>
            /// </example>
            [FakerMethod("motto")]
            public string Motto()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.mottos", this))));
            }
            /// <summary>
            /// Produces a quote from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.quote
            /// #=> "I don't want to live in a world where someone else is making the world a better place better than we are."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.quotes", this))));
            }
            /// <summary>
            /// Produces a URL from Silicon Valley.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SiliconValley.url #=> "http://www.piedpiper.com"</code>
            /// </example>
            [FakerMethod("url")]
            public string Url()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("silicon_valley.urls", this))));
            }
        }
        
        [FakerGenerator("Simpsons")]
        public class SimpsonsGenerator : GeneratorBase
        {
            internal SimpsonsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Simpsons.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Simpsons.character #=> "Charles Montgomery Burns"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("simpsons.characters", this))));
            }
            /// <summary>
            /// Produces an episode title from The Simpsons.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Simpsons.episode_title
            /// #=> "Two Cars in Every Garage and Three Eyes on Every Fish"</code>
            /// </example>
            [FakerMethod("episode_title")]
            public string EpisodeTitle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("simpsons.episode_titles", this))));
            }
            /// <summary>
            /// Produces a location from The Simpsons.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Simpsons.location #=> "Moe's Tavern"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("simpsons.locations", this))));
            }
            /// <summary>
            /// Produces a quote from The Simpsons.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Simpsons.quote
            /// #=> "It takes two to lie: one to lie and one to listen."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("simpsons.quotes", this))));
            }
        }
        
        [FakerGenerator("SouthPark")]
        public class SouthParkGenerator : GeneratorBase
        {
            internal SouthParkGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from South Park.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SouthPark.character #=> "Mr. Garrison"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("south_park.characters", this))));
            }
            /// <summary>
            /// Produces an episode name from South Park.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SouthPark.episode_name
            /// #=> "Make Love, Not Warcraft"</code>
            /// </example>
            [FakerMethod("episode_name")]
            public string EpisodeName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("south_park.episodes", this))));
            }
            /// <summary>
            /// Produces a quote from South Park.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::SouthPark.quote
            /// #=> "I'm just getting a little cancer Stan."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("south_park.quotes", this))));
            }
        }
        
        [FakerGenerator("Spongebob")]
        public class SpongebobGenerator : GeneratorBase
        {
            internal SpongebobGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Spongebob.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Spongebob.character #=> "Patrick"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("spongebob.characters", this))));
            }
            /// <summary>
            /// Produces an episode from Spongebob.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Spongebob.episode #=> "Reef Blower"</code>
            /// </example>
            [FakerMethod("episode")]
            public string Episode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("spongebob.episodes", this))));
            }
            /// <summary>
            /// Produces a quote from Spongebob.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Spongebob.quote #=> "I'm ready! I'm ready!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("spongebob.quotes", this))));
            }
        }
        
        [FakerGenerator("StarTrek")]
        public class StarTrekGenerator : GeneratorBase
        {
            internal StarTrekGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Star Trek.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StarTrek.character #=> "Spock"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("star_trek.character", this))));
            }
            /// <summary>
            /// Produces a location from Star Trek.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StarTrek.location #=> "Cardassia"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("star_trek.location", this))));
            }
            /// <summary>
            /// Produces a species from Star Trek.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StarTrek.specie #=> "Ferengi"</code>
            /// </example>
            [FakerMethod("specie")]
            public string Specie()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("star_trek.specie", this))));
            }
            /// <summary>
            /// Produces a villain from Star Trek.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StarTrek.villain #=> "Khan Noonien Singh"</code>
            /// </example>
            [FakerMethod("villain")]
            public string Villain()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("star_trek.villain", this))));
            }
        }
        
        [FakerGenerator("Stargate")]
        public class StargateGenerator : GeneratorBase
        {
            internal StargateGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Stargate.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Stargate.character #=> "Jack O'Neill"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("stargate.characters", this))));
            }
            /// <summary>
            /// Produces a planet from Stargate.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Stargate.planet #=> "Abydos"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("stargate.planets", this))));
            }
            /// <summary>
            /// Produces a quote from Stargate.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Stargate.quote
            /// #=> "General, request permission to beat the crap out of this man."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("stargate.quotes", this))));
            }
        }
        
        [FakerGenerator("StrangerThings")]
        public class StrangerThingsGenerator : GeneratorBase
        {
            internal StrangerThingsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a quote from Stranger Things.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StrangerThings.quote
            /// #=> "Friends don't lie."</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("stranger_things.character", this))));
            }
            /// <summary>
            /// Produces a character from Stranger Things.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::StrangerThings.character #=> "six"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("stranger_things.quote", this))));
            }
        }
        
        [FakerGenerator("Suits")]
        public class SuitsGenerator : GeneratorBase
        {
            internal SuitsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Suits.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Suits.character #=> "Harvey Specter"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("suits.characters", this))));
            }
            /// <summary>
            /// Produces a quote from Suits.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Suits.quote #=> "Don't play the odds, play the man."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("suits.quotes", this))));
            }
        }
        
        [FakerGenerator("Supernatural")]
        public class SupernaturalGenerator : GeneratorBase
        {
            internal SupernaturalGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Supernatural.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Supernatural.character #=> "Dean Winchester"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("supernatural.character", this))));
            }
            /// <summary>
            /// Produces the name of a hunted creature.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Supernatural.creature #=> "Demon"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("supernatural.creature", this))));
            }
            /// <summary>
            /// Produces the name of a weapon used by the hunters.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::Supernatural.weapon #=> "Colt"</code>
            /// </example>
            [FakerMethod("weapon")]
            public string Weapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("supernatural.weapon", this))));
            }
        }
        
        [FakerGenerator("TheExpanse")]
        public class TheExpanseGenerator : GeneratorBase
        {
            internal TheExpanseGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Expanse.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheExpanse.character #=> "Jim Holden"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_expanse.characters", this))));
            }
            /// <summary>
            /// Produces a location from The Expanse.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheExpanse.location #=> "Ganymede"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_expanse.locations", this))));
            }
            /// <summary>
            /// Produces a quote from The Expanse.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheExpanse.quote #=> "I am that guy."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_expanse.quotes", this))));
            }
            /// <summary>
            /// Produces a ship from The Expanse.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheExpanse.ship #=> "Nauvoo"</code>
            /// </example>
            [FakerMethod("ship")]
            public string Ship()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_expanse.ships", this))));
            }
        }
        
        [FakerGenerator("TheFreshPrinceOfBelAir")]
        public class TheFreshPrinceOfBelAirGenerator : GeneratorBase
        {
            internal TheFreshPrinceOfBelAirGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a actor from The Fresh Prince of Bel-Air.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheFreshPrinceOfBelAir.actor #=> "Quincy Jones"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_fresh_prince_of_bel_air.actors", this))));
            }
            /// <summary>
            /// Produces a character from The Fresh Prince of Bel-Air.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheFreshPrinceOfBelAir.character #=> "Will Smith"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_fresh_prince_of_bel_air.characters", this))));
            }
            /// <summary>
            /// Produces a quote from The Fresh Prince of Bel-Air.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheFreshPrinceOfBelAir.quote
            /// #=> "Girl, you look so good, I would marry your brother just to get in your family."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_fresh_prince_of_bel_air.quotes", this))));
            }
        }
        
        [FakerGenerator("TheITCrowd")]
        public class TheITCrowdGenerator : GeneratorBase
        {
            internal TheITCrowdGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The IT Crowd.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheITCrowd.actor #=> "Chris O'Dowd"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_it_crowd.actors", this))));
            }
            /// <summary>
            /// Produces a character from The IT Crowd.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheITCrowd.character #=> "Roy Trenneman"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_it_crowd.characters", this))));
            }
            /// <summary>
            /// Produces an email from The IT Crowd.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheITCrowd.email #=> "roy.trenneman@reynholm.test"</code>
            /// </example>
            [FakerMethod("email")]
            public string Email()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_it_crowd.emails", this))));
            }
            /// <summary>
            /// Produces a quote from The IT Crowd.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheITCrowd.quote
            /// #=> "Hello, IT. Have you tried turning it off and on again?"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_it_crowd.quotes", this))));
            }
        }
        
        [FakerGenerator("TheOffice")]
        public class TheOfficeGenerator : GeneratorBase
        {
            internal TheOfficeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Office.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheOffice.character #=> "Michael Scott"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_office.characters", this))));
            }
            /// <summary>
            /// Produces a quote from The Office.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheOffice.quote #=> "Identity theft is not a joke, Jim! Millions of families suffer every year."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_office.quotes", this))));
            }
        }
        
        [FakerGenerator("TheThickOfIt")]
        public class TheThickOfItGenerator : GeneratorBase
        {
            internal TheThickOfItGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Thick of It.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheThickOfIt.character #=> "Nicola Murray"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_thick_of_it.characters", this))));
            }
            /// <summary>
            /// Produces a department from The Thick of It.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheThickOfIt.department #=> "Shadow Cabinet"</code>
            /// </example>
            [FakerMethod("department")]
            public string Department()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_thick_of_it.departments", this))));
            }
            /// <summary>
            /// Produces a position from The Thick of It.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TheThickOfIt.position
            /// #=> "Director of Communications"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("the_thick_of_it.positions", this))));
            }
        }
        
        [FakerGenerator("TwinPeaks")]
        public class TwinPeaksGenerator : GeneratorBase
        {
            internal TwinPeaksGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Twin Peaks.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TwinPeaks.character #=> "Dale Cooper"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("twin_peaks.characters", this))));
            }
            /// <summary>
            /// Produces a location from Twin Peaks.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TwinPeaks.location #=> "Black Lodge"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("twin_peaks.locations", this))));
            }
            /// <summary>
            /// Produces a quote from Twin Peaks.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::TwinPeaks.quote
            /// #=> "The owls are not what they seem."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("twin_peaks.quotes", this))));
            }
        }
        
        [FakerGenerator("VentureBros")]
        public class VentureBrosGenerator : GeneratorBase
        {
            internal VentureBrosGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Venture Bros.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::VentureBros.character #=> "Scaramantula"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("venture_bros.character", this))));
            }
            /// <summary>
            /// Produces an organization from The Venture Bros.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::VentureBros.organization
            /// #=> "Guild of Calamitous Intent"</code>
            /// </example>
            [FakerMethod("organization")]
            public string Organization()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("venture_bros.organization", this))));
            }
            /// <summary>
            /// Produces a quote from The Venture Bros.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::VentureBros.quote
            /// #=> "Revenge, like gazpacho soup, is best served cold, precise, and merciless."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("venture_bros.quote", this))));
            }
            /// <summary>
            /// Produces a vehicle from The Venture Bros.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::VentureBros.vehicle #=> "Monarchmobile"</code>
            /// </example>
            [FakerMethod("vehicle")]
            public string Vehicle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.Resolve("venture_bros.vehicle", this))));
            }
        }
        
    }
    
    [FakerGenerator("Twitter")]
    public class TwitterGenerator : GeneratorBase
    {
        internal TwitterGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method created_at
        #warning Failed processing method id
        #warning Failed processing method photo_entity
        #warning No implementation defined for method screen_name();
        #warning No implementation defined for method status(bool includeUser, bool includePhoto = false);
        #warning Failed processing method status_entities
        #warning No implementation defined for method user(bool includeStatus, bool includeEmail = false);
        #warning Failed processing method user_entities
        #warning Failed processing method utc_offset
    }
    
    [FakerGenerator("Types")]
    public class TypesGenerator : GeneratorBase
    {
        internal TypesGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method character();
        #warning No implementation defined for method complex_rb_hash(long number = 1);
        #warning No implementation defined for method random_complex_type();
        #warning No implementation defined for method random_type();
        #warning No implementation defined for method rb_array(long len);
        #warning No implementation defined for method rb_hash(long number);
        #warning No implementation defined for method rb_integer();
        #warning No implementation defined for method rb_string();
        #warning Failed processing method titleize
    }
    
    [FakerGenerator("University")]
    public class UniversityGenerator : GeneratorBase
    {
        internal UniversityGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method greek_alphabet();
        #warning No implementation defined for method greek_organization();
        /// <summary>
        /// Produces a random university name.
        /// </summary>
        /// <example>
        /// <code>Faker::University.name #=> "Eastern Mississippi Academy"</code>
        /// </example>
        [FakerMethod("name")]
        public string Name()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("university.name", this))));
        }
        /// <summary>
        /// Produces a random university prefix.
        /// </summary>
        /// <example>
        /// <code>Faker::University.prefix #=> "Western"</code>
        /// </example>
        [FakerMethod("prefix")]
        public string Prefix()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("university.prefix", this))));
        }
        /// <summary>
        /// Produces a random university suffix.
        /// </summary>
        /// <example>
        /// <code>Faker::University.suffix #=> "Academy"</code>
        /// </example>
        [FakerMethod("suffix")]
        public string Suffix()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("university.suffix", this))));
        }
    }
    
    [FakerGenerator("Vehicle")]
    public class VehicleGenerator : GeneratorBase
    {
        internal VehicleGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a random list of car options.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.car_options #=> ["DVD System", "MP3 (Single Disc)", "Tow Package", "CD (Multi Disc)", "Cassette Player", "Bucket Seats", "Cassette Player", "Leather Interior", "AM/FM Stereo", "Third Row Seats"]</code>
        /// </example>
        [FakerMethod("car_options")]
        public List<string> CarOptions()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.car_options", this)))).Split(',').Select(item => item).ToList();
        }
        /// <summary>
        /// Produces a random car type.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.car_type #=> "Sedan"</code>
        /// </example>
        [FakerMethod("car_type")]
        public string CarType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.car_types", this))));
        }
        /// <summary>
        /// Produces a random vehicle color.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.color #=> "Red"</code>
        /// </example>
        [FakerMethod("color")]
        public string Color()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.colors", this))));
        }
        /// <summary>
        /// Produces a random vehicle door count.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.doors #=> 1
        /// Faker::Vehicle.door_count #=> 3</code>
        /// </example>
        [FakerMethod("doors")]
        public long Doors()
        {
            return long.Parse(this.Resolve("vehicle.doors", this));
        }
        /// <summary>
        /// Produces a random vehicle drive type.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.drive_type #=> "4x2/2-wheel drive"</code>
        /// </example>
        [FakerMethod("drive_type")]
        public string DriveType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.drive_types", this))));
        }
        /// <summary>
        /// Produces a random engine cylinder count.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.engine_size #=> 6
        /// Faker::Vehicle.engine #=> 4</code>
        /// </example>
        [FakerMethod("engine")]
        public string Engine()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.cylinder_engine", this))));
        }
        /// <summary>
        /// Produces a random vehicle fuel type.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.fuel_type #=> "Diesel"</code>
        /// </example>
        [FakerMethod("fuel_type")]
        public string FuelType()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.fuel_types", this))));
        }
        /// <summary>
        /// Produces a random license plate number.
        /// </summary>
        /// <param name="stateAbbreviation">
        /// 
        /// <p>Two letter state abbreviation for license plate generation.</p>
        /// 
        /// (default value "''")
        /// </param>
        /// <example>
        /// <code>Faker::Vehicle.license_plate #=> "DEP-2483"
        /// Faker::Vehicle.license_plate(state_abbreviation: 'FL') #=> "977 UNU"</code>
        /// </example>
        [FakerMethod("license_plate")]
        public string LicensePlate(string stateAbbreviation = "")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.license_plate", this))));
        }
        /// <summary>
        /// Produces a random vehicle make.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.make #=> "Honda"</code>
        /// </example>
        [FakerMethod("make")]
        public string Make()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.makes", this))));
        }
        #warning No implementation defined for method make_and_model();
        /// <summary>
        /// Produces a random vehicle manufacturer.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.manufacture #=> "Lamborghini"</code>
        /// </example>
        [FakerMethod("manufacture")]
        public string Manufacture()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.manufacture", this))));
        }
        #warning No implementation defined for method mileage(long min, long max = MILEAGE_MAX);
        /// <summary>
        /// Produces a random vehicle model.
        /// </summary>
        /// <param name="makeOfModel">
        /// 
        /// <p>Specific valid vehicle make.</p>
        /// 
        /// (default value "''")
        /// </param>
        /// <example>
        /// <code>Faker::Vehicle.model #=> "A8"
        /// Faker::Vehicle.model(make_of_model: 'Toyota') #=> "Prius"</code>
        /// </example>
        [FakerMethod("model")]
        public string Model(string makeOfModel = "")
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.models_by_make.#{make}", this))));
        }
        #warning Failed processing method singapore_checksum
        #warning No implementation defined for method singapore_license_plate();
        /// <summary>
        /// Produces a random list of standard specs.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.standard_specs #=> ["Full-size spare tire w/aluminum alloy wheel", "Back-up camera", "Carpeted cargo area", "Silver accent IP trim finisher -inc: silver shifter finisher", "Back-up camera", "Water-repellent windshield & front door glass", "Floor carpeting"]</code>
        /// </example>
        [FakerMethod("standard_specs")]
        public List<string> StandardSpecs()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.standard_specs", this)))).Split(',').Select(item => item).ToList();
        }
        /// <summary>
        /// Produces a random vehicle style.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.style #=> "ESi"</code>
        /// </example>
        [FakerMethod("style")]
        public string Style()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.styles", this))));
        }
        /// <summary>
        /// Produces a random vehicle transmission.
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.transmission #=> "Automanual"</code>
        /// </example>
        [FakerMethod("transmission")]
        public string Transmission()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.transmissions", this))));
        }
        /// <summary>
        /// Produces a car version.
        ///                             <p>Produces a car version</p>
        ///                         
        /// </summary>
        /// <example>
        /// <code>Faker::Vehicle.version #=> "40 TFSI Premium"</code>
        /// </example>
        [FakerMethod("version")]
        public string Version()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("vehicle.version", this))));
        }
        #warning No implementation defined for method vin();
        #warning No implementation defined for method year();
    }
    
    [FakerGenerator("Verb")]
    public class VerbGenerator : GeneratorBase
    {
        internal VerbGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces the base form of a random verb.
        /// </summary>
        /// <example>
        /// <code>Faker::Verb.base #=> "hurt"</code>
        /// </example>
        [FakerMethod("base")]
        public string Base()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("verbs.base", this))));
        }
        /// <summary>
        /// Produces a random verb in the .ing form.
        /// </summary>
        /// <example>
        /// <code>Faker::Verb.ing_form #=> "causing"</code>
        /// </example>
        [FakerMethod("ing_form")]
        public string IngForm()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("verbs.ing_form", this))));
        }
        /// <summary>
        /// Produces a random verb in past tense.
        /// </summary>
        /// <example>
        /// <code>Faker::Verb.past #=> "completed"</code>
        /// </example>
        [FakerMethod("past")]
        public string Past()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("verbs.past", this))));
        }
        /// <summary>
        /// Produces a random verb in past participle.
        /// </summary>
        /// <example>
        /// <code>Faker::Verb.past_participle #=> "digested"</code>
        /// </example>
        [FakerMethod("past_participle")]
        public string PastParticiple()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("verbs.past_participle", this))));
        }
        /// <summary>
        /// Produces a random verb in simple present.
        /// </summary>
        /// <example>
        /// <code>Faker::Verb.simple_present #=> "climbs"</code>
        /// </example>
        [FakerMethod("simple_present")]
        public string SimplePresent()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("verbs.simple_present", this))));
        }
    }
    
    [FakerGenerator("VulnerabilityIdentifier")]
    public class VulnerabilityIdentifierGenerator : GeneratorBase
    {
        internal VulnerabilityIdentifierGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method cve(long year = ::Date.today.year);
    }
    
    [FakerGenerator("WorldCup")]
    public class WorldCupGenerator : GeneratorBase
    {
        internal WorldCupGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a city name hosting the World Cup match.
        /// </summary>
        /// <example>
        /// <code>Faker::WorldCup.city #=> "Moscow"</code>
        /// </example>
        [FakerMethod("city")]
        public string City()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("world_cup.cities", this))));
        }
        /// <summary>
        /// Produces a random national team name from a group.
        /// </summary>
        /// <example>
        /// <code>Faker::WorldCup.group(group: 'group_B') #=> "Spain"</code>
        /// </example>
        [FakerMethod("group")]
        public string Group()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("world_cup.groups.#{group}", this))));
        }
        /// <summary>
        /// Produces a random name from national team roster.
        /// </summary>
        /// <example>
        /// <code>Faker::WorldCup.roster #=> "Hector Cuper"</code>
        /// </example>
        [FakerMethod("roster")]
        public string Roster()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("world_cup.rosters.#{country}.#{type}", this))));
        }
        /// <summary>
        /// Produces the name of a stadium that has hosted a World Cup match.
        /// </summary>
        /// <example>
        /// <code>Faker::WorldCup.stadium #=> "Rostov Arena"</code>
        /// </example>
        [FakerMethod("stadium")]
        public string Stadium()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("world_cup.stadiums", this))));
        }
        /// <summary>
        /// Produces a national team name.
        /// </summary>
        /// <example>
        /// <code>Faker::WorldCup.team #=> "Iran"</code>
        /// </example>
        [FakerMethod("team")]
        public string Team()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("world_cup.teams", this))));
        }
    }
    
    [FakerGenerator("String")]
    public class StringGenerator : GeneratorBase
    {
        internal StringGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <param name="text">
        /// The string to get the length of
        /// </param>
        [FakerMethod("length")]
        public long Length(string text)
        {
            return text.Length;
        }
        /// <param name="text">
        /// The string as lower case
        /// </param>
        [FakerMethod("lower")]
        public string Lower(string text)
        {
            return text.ToLower();
        }
        #warning No implementation defined for method random();
        #warning No implementation defined for method select_a();
        #warning No implementation defined for method utf8string();
        #warning No implementation defined for method space_or_utf8_char();
        #warning No implementation defined for method char_space_ratio();
        #warning No implementation defined for method utf8character();
    }
    
    [FakerGenerator("Bible")]
    public class BibleGenerator : GeneratorBase
    {
        internal BibleGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        [FakerMethod("character")]
        public string Character()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bible.character", this))));
        }
        [FakerMethod("location")]
        public string Location()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bible.location", this))));
        }
        [FakerMethod("quote")]
        public string Quote()
        {
            return this.Translate(this.Numerify(this.Letterify(this.Resolve("bible.quote", this))));
        }
    }
    
    partial class Faker
    {
        [FakerMethod("Address")]
        public AddressGenerator Address { get; }
        [FakerMethod("Adjective")]
        public AdjectiveGenerator Adjective { get; }
        [FakerMethod("Alphanumeric")]
        public AlphanumericGenerator Alphanumeric { get; }
        [FakerMethod("Ancient")]
        public AncientGenerator Ancient { get; }
        [FakerMethod("App")]
        public AppGenerator App { get; }
        [FakerMethod("Appliance")]
        public ApplianceGenerator Appliance { get; }
        [FakerMethod("Artist")]
        public ArtistGenerator Artist { get; }
        [FakerMethod("Australia")]
        public AustraliaGenerator Australia { get; }
        [FakerMethod("Avatar")]
        public AvatarGenerator Avatar { get; }
        [FakerMethod("Bank")]
        public BankGenerator Bank { get; }
        [FakerMethod("Barcode")]
        public BarcodeGenerator Barcode { get; }
        [FakerMethod("Beer")]
        public BeerGenerator Beer { get; }
        [FakerMethod("Blockchain")]
        public BlockchainGenerator Blockchain { get; }
        [FakerMethod("Blood")]
        public BloodGenerator Blood { get; }
        [FakerMethod("Book")]
        public BookGenerator Book { get; }
        [FakerMethod("Books")]
        public BooksGenerator Books { get; }
        [FakerMethod("Boolean")]
        public BooleanGenerator Boolean { get; }
        [FakerMethod("BossaNova")]
        public BossaNovaGenerator BossaNova { get; }
        [FakerMethod("Business")]
        public BusinessGenerator Business { get; }
        [FakerMethod("Camera")]
        public CameraGenerator Camera { get; }
        [FakerMethod("Cannabis")]
        public CannabisGenerator Cannabis { get; }
        [FakerMethod("ChileRut")]
        public ChileRutGenerator ChileRut { get; }
        [FakerMethod("ChuckNorris")]
        public ChuckNorrisGenerator ChuckNorris { get; }
        [FakerMethod("Code")]
        public CodeGenerator Code { get; }
        [FakerMethod("Coffee")]
        public CoffeeGenerator Coffee { get; }
        [FakerMethod("Coin")]
        public CoinGenerator Coin { get; }
        [FakerMethod("Color")]
        public ColorGenerator Color { get; }
        [FakerMethod("Commerce")]
        public CommerceGenerator Commerce { get; }
        [FakerMethod("Company")]
        public CompanyGenerator Company { get; }
        [FakerMethod("Compass")]
        public CompassGenerator Compass { get; }
        [FakerMethod("Computer")]
        public ComputerGenerator Computer { get; }
        [FakerMethod("Construction")]
        public ConstructionGenerator Construction { get; }
        [FakerMethod("Cosmere")]
        public CosmereGenerator Cosmere { get; }
        [FakerMethod("Creature")]
        public CreatureGenerator Creature { get; }
        [FakerMethod("Crypto")]
        public CryptoGenerator Crypto { get; }
        [FakerMethod("CryptoCoin")]
        public CryptoCoinGenerator CryptoCoin { get; }
        [FakerMethod("Currency")]
        public CurrencyGenerator Currency { get; }
        [FakerMethod("Date")]
        public DateGenerator Date { get; }
        [FakerMethod("DcComics")]
        public DcComicsGenerator DcComics { get; }
        [FakerMethod("Demographic")]
        public DemographicGenerator Demographic { get; }
        [FakerMethod("Dessert")]
        public DessertGenerator Dessert { get; }
        [FakerMethod("Device")]
        public DeviceGenerator Device { get; }
        [FakerMethod("DrivingLicence")]
        public DrivingLicenceGenerator DrivingLicence { get; }
        [FakerMethod("Drone")]
        public DroneGenerator Drone { get; }
        [FakerMethod("Educator")]
        public EducatorGenerator Educator { get; }
        [FakerMethod("ElectricalComponents")]
        public ElectricalComponentsGenerator ElectricalComponents { get; }
        [FakerMethod("Emotion")]
        public EmotionGenerator Emotion { get; }
        [FakerMethod("Esport")]
        public EsportGenerator Esport { get; }
        [FakerMethod("Fantasy")]
        public FantasyGenerator Fantasy { get; }
        [FakerMethod("File")]
        public FileGenerator File { get; }
        [FakerMethod("Finance")]
        public FinanceGenerator Finance { get; }
        [FakerMethod("Food")]
        public FoodGenerator Food { get; }
        [FakerMethod("FunnyName")]
        public FunnyNameGenerator FunnyName { get; }
        [FakerMethod("Game")]
        public GameGenerator Game { get; }
        [FakerMethod("Games")]
        public GamesGenerator Games { get; }
        [FakerMethod("Gender")]
        public GenderGenerator Gender { get; }
        [FakerMethod("GreekPhilosophers")]
        public GreekPhilosophersGenerator GreekPhilosophers { get; }
        [FakerMethod("HTML")]
        public HTMLGenerator HTML { get; }
        [FakerMethod("Hacker")]
        public HackerGenerator Hacker { get; }
        [FakerMethod("Hipster")]
        public HipsterGenerator Hipster { get; }
        [FakerMethod("Hobby")]
        public HobbyGenerator Hobby { get; }
        [FakerMethod("House")]
        public HouseGenerator House { get; }
        [FakerMethod("IDNumber")]
        public IDNumberGenerator IDNumber { get; }
        [FakerMethod("IndustrySegments")]
        public IndustrySegmentsGenerator IndustrySegments { get; }
        [FakerMethod("Internet")]
        public InternetGenerator Internet { get; }
        [FakerMethod("Invoice")]
        public InvoiceGenerator Invoice { get; }
        [FakerMethod("JapaneseMedia")]
        public JapaneseMediaGenerator JapaneseMedia { get; }
        [FakerMethod("Job")]
        public JobGenerator Job { get; }
        [FakerMethod("Json")]
        public JsonGenerator Json { get; }
        [FakerMethod("Kpop")]
        public KpopGenerator Kpop { get; }
        [FakerMethod("Lorem")]
        public LoremGenerator Lorem { get; }
        [FakerMethod("LoremFlickr")]
        public LoremFlickrGenerator LoremFlickr { get; }
        [FakerMethod("Markdown")]
        public MarkdownGenerator Markdown { get; }
        [FakerMethod("Marketing")]
        public MarketingGenerator Marketing { get; }
        [FakerMethod("Measurement")]
        public MeasurementGenerator Measurement { get; }
        [FakerMethod("Military")]
        public MilitaryGenerator Military { get; }
        [FakerMethod("Mountain")]
        public MountainGenerator Mountain { get; }
        [FakerMethod("Movie")]
        public MovieGenerator Movie { get; }
        [FakerMethod("Movies")]
        public MoviesGenerator Movies { get; }
        [FakerMethod("Music")]
        public MusicGenerator Music { get; }
        [FakerMethod("Name")]
        public NameGenerator Name { get; }
        [FakerMethod("Nation")]
        public NationGenerator Nation { get; }
        [FakerMethod("NationalHealthService")]
        public NationalHealthServiceGenerator NationalHealthService { get; }
        [FakerMethod("NatoPhoneticAlphabet")]
        public NatoPhoneticAlphabetGenerator NatoPhoneticAlphabet { get; }
        [FakerMethod("Number")]
        public NumberGenerator Number { get; }
        [FakerMethod("Omniauth")]
        public OmniauthGenerator Omniauth { get; }
        [FakerMethod("PhoneNumber")]
        public PhoneNumberGenerator PhoneNumber { get; }
        [FakerMethod("Placeholdit")]
        public PlaceholditGenerator Placeholdit { get; }
        [FakerMethod("ProgrammingLanguage")]
        public ProgrammingLanguageGenerator ProgrammingLanguage { get; }
        [FakerMethod("Quote")]
        public QuoteGenerator Quote { get; }
        [FakerMethod("Quotes")]
        public QuotesGenerator Quotes { get; }
        [FakerMethod("Relationship")]
        public RelationshipGenerator Relationship { get; }
        [FakerMethod("Restaurant")]
        public RestaurantGenerator Restaurant { get; }
        [FakerMethod("Science")]
        public ScienceGenerator Science { get; }
        [FakerMethod("Show")]
        public ShowGenerator Show { get; }
        [FakerMethod("SlackEmoji")]
        public SlackEmojiGenerator SlackEmoji { get; }
        [FakerMethod("Source")]
        public SourceGenerator Source { get; }
        [FakerMethod("SouthAfrica")]
        public SouthAfricaGenerator SouthAfrica { get; }
        [FakerMethod("Space")]
        public SpaceGenerator Space { get; }
        [FakerMethod("Sport")]
        public SportGenerator Sport { get; }
        [FakerMethod("Sports")]
        public SportsGenerator Sports { get; }
        [FakerMethod("Stripe")]
        public StripeGenerator Stripe { get; }
        [FakerMethod("Subscription")]
        public SubscriptionGenerator Subscription { get; }
        [FakerMethod("Superhero")]
        public SuperheroGenerator Superhero { get; }
        [FakerMethod("Tea")]
        public TeaGenerator Tea { get; }
        [FakerMethod("Team")]
        public TeamGenerator Team { get; }
        [FakerMethod("Time")]
        public TimeGenerator Time { get; }
        [FakerMethod("Travel")]
        public TravelGenerator Travel { get; }
        [FakerMethod("TvShows")]
        public TvShowsGenerator TvShows { get; }
        [FakerMethod("Twitter")]
        public TwitterGenerator Twitter { get; }
        [FakerMethod("Types")]
        public TypesGenerator Types { get; }
        [FakerMethod("University")]
        public UniversityGenerator University { get; }
        [FakerMethod("Vehicle")]
        public VehicleGenerator Vehicle { get; }
        [FakerMethod("Verb")]
        public VerbGenerator Verb { get; }
        [FakerMethod("VulnerabilityIdentifier")]
        public VulnerabilityIdentifierGenerator VulnerabilityIdentifier { get; }
        [FakerMethod("WorldCup")]
        public WorldCupGenerator WorldCup { get; }
        [FakerMethod("String")]
        public StringGenerator String { get; }
        [FakerMethod("Bible")]
        public BibleGenerator Bible { get; }
        
        public Faker(CultureInfo locale, Random random)
        {
            this.Random = random;
            
            // Create the Faker Generators
            Address = new AddressGenerator(this);
            Adjective = new AdjectiveGenerator(this);
            Alphanumeric = new AlphanumericGenerator(this);
            Ancient = new AncientGenerator(this);
            App = new AppGenerator(this);
            Appliance = new ApplianceGenerator(this);
            Artist = new ArtistGenerator(this);
            Australia = new AustraliaGenerator(this);
            Avatar = new AvatarGenerator(this);
            Bank = new BankGenerator(this);
            Barcode = new BarcodeGenerator(this);
            Beer = new BeerGenerator(this);
            Blockchain = new BlockchainGenerator(this);
            Blood = new BloodGenerator(this);
            Book = new BookGenerator(this);
            Books = new BooksGenerator(this);
            Boolean = new BooleanGenerator(this);
            BossaNova = new BossaNovaGenerator(this);
            Business = new BusinessGenerator(this);
            Camera = new CameraGenerator(this);
            Cannabis = new CannabisGenerator(this);
            ChileRut = new ChileRutGenerator(this);
            ChuckNorris = new ChuckNorrisGenerator(this);
            Code = new CodeGenerator(this);
            Coffee = new CoffeeGenerator(this);
            Coin = new CoinGenerator(this);
            Color = new ColorGenerator(this);
            Commerce = new CommerceGenerator(this);
            Company = new CompanyGenerator(this);
            Compass = new CompassGenerator(this);
            Computer = new ComputerGenerator(this);
            Construction = new ConstructionGenerator(this);
            Cosmere = new CosmereGenerator(this);
            Creature = new CreatureGenerator(this);
            Crypto = new CryptoGenerator(this);
            CryptoCoin = new CryptoCoinGenerator(this);
            Currency = new CurrencyGenerator(this);
            Date = new DateGenerator(this);
            DcComics = new DcComicsGenerator(this);
            Demographic = new DemographicGenerator(this);
            Dessert = new DessertGenerator(this);
            Device = new DeviceGenerator(this);
            DrivingLicence = new DrivingLicenceGenerator(this);
            Drone = new DroneGenerator(this);
            Educator = new EducatorGenerator(this);
            ElectricalComponents = new ElectricalComponentsGenerator(this);
            Emotion = new EmotionGenerator(this);
            Esport = new EsportGenerator(this);
            Fantasy = new FantasyGenerator(this);
            File = new FileGenerator(this);
            Finance = new FinanceGenerator(this);
            Food = new FoodGenerator(this);
            FunnyName = new FunnyNameGenerator(this);
            Game = new GameGenerator(this);
            Games = new GamesGenerator(this);
            Gender = new GenderGenerator(this);
            GreekPhilosophers = new GreekPhilosophersGenerator(this);
            HTML = new HTMLGenerator(this);
            Hacker = new HackerGenerator(this);
            Hipster = new HipsterGenerator(this);
            Hobby = new HobbyGenerator(this);
            House = new HouseGenerator(this);
            IDNumber = new IDNumberGenerator(this);
            IndustrySegments = new IndustrySegmentsGenerator(this);
            Internet = new InternetGenerator(this);
            Invoice = new InvoiceGenerator(this);
            JapaneseMedia = new JapaneseMediaGenerator(this);
            Job = new JobGenerator(this);
            Json = new JsonGenerator(this);
            Kpop = new KpopGenerator(this);
            Lorem = new LoremGenerator(this);
            LoremFlickr = new LoremFlickrGenerator(this);
            Markdown = new MarkdownGenerator(this);
            Marketing = new MarketingGenerator(this);
            Measurement = new MeasurementGenerator(this);
            Military = new MilitaryGenerator(this);
            Mountain = new MountainGenerator(this);
            Movie = new MovieGenerator(this);
            Movies = new MoviesGenerator(this);
            Music = new MusicGenerator(this);
            Name = new NameGenerator(this);
            Nation = new NationGenerator(this);
            NationalHealthService = new NationalHealthServiceGenerator(this);
            NatoPhoneticAlphabet = new NatoPhoneticAlphabetGenerator(this);
            Number = new NumberGenerator(this);
            Omniauth = new OmniauthGenerator(this);
            PhoneNumber = new PhoneNumberGenerator(this);
            Placeholdit = new PlaceholditGenerator(this);
            ProgrammingLanguage = new ProgrammingLanguageGenerator(this);
            Quote = new QuoteGenerator(this);
            Quotes = new QuotesGenerator(this);
            Relationship = new RelationshipGenerator(this);
            Restaurant = new RestaurantGenerator(this);
            Science = new ScienceGenerator(this);
            Show = new ShowGenerator(this);
            SlackEmoji = new SlackEmojiGenerator(this);
            Source = new SourceGenerator(this);
            SouthAfrica = new SouthAfricaGenerator(this);
            Space = new SpaceGenerator(this);
            Sport = new SportGenerator(this);
            Sports = new SportsGenerator(this);
            Stripe = new StripeGenerator(this);
            Subscription = new SubscriptionGenerator(this);
            Superhero = new SuperheroGenerator(this);
            Tea = new TeaGenerator(this);
            Team = new TeamGenerator(this);
            Time = new TimeGenerator(this);
            Travel = new TravelGenerator(this);
            TvShows = new TvShowsGenerator(this);
            Twitter = new TwitterGenerator(this);
            Types = new TypesGenerator(this);
            University = new UniversityGenerator(this);
            Vehicle = new VehicleGenerator(this);
            Verb = new VerbGenerator(this);
            VulnerabilityIdentifier = new VulnerabilityIdentifierGenerator(this);
            WorldCup = new WorldCupGenerator(this);
            String = new StringGenerator(this);
            Bible = new BibleGenerator(this);
            
            Init(locale);
        }
    }
}
