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
    [FakerGenerator("Blockchain")]
    public partial class BlockchainGenerator : GeneratorBase
    {
        [FakerProperty]
        public AeternityGenerator Aeternity { get; }
        [FakerProperty]
        public BitcoinGenerator Bitcoin { get; }
        [FakerProperty]
        public EthereumGenerator Ethereum { get; }
        [FakerProperty]
        public TezosGenerator Tezos { get; }
        internal BlockchainGenerator(Faker faker)
                 : base(faker)
        {
            Aeternity = new AeternityGenerator(this.Faker);
            Bitcoin = new BitcoinGenerator(this.Faker);
            Ethereum = new EthereumGenerator(this.Faker);
            Tezos = new TezosGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Blockchain.Aeternity")]
        public partial class AeternityGenerator : GeneratorBase
        {
            internal AeternityGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random Aeternity wallet address.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.address
            /// #=> "ak_zvU8YQLagjcfng7Tg8yCdiZ1rpiWNp1PBn3vtUs44utSvbJVR"</code>
            /// </example>
            [FakerMethod("address")]
            public string Address()
            {
                return this.EvaluateExpression("ak_#{String.random_string}");
            }
            /// <summary>
            /// Produces a random Aeternity contract.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.contract
            /// #=> "ct_Hk2JsNeWGEYQEHHQCfcBeGrwbhtYSwFTPdDhW2SvjFYVojyhW"</code>
            /// </example>
            [FakerMethod("contract")]
            public string Contract()
            {
                return this.EvaluateExpression("ct_#{String.random_string}");
            }
            /// <summary>
            /// Produces a random Aeternity oracle.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.oracle
            /// #=> "ok_28QDg7fkF5qiKueSdUvUBtCYPJdmMEoS73CztzXCRAwMGKHKZh"</code>
            /// </example>
            [FakerMethod("oracle")]
            public string Oracle()
            {
                return this.EvaluateExpression("ok_#{String.random_string '51','51'}");
            }
            /// <summary>
            /// Produces a random Aeternity transaction.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Aeternity.transaction
            /// #=> "th_147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"</code>
            /// </example>
            [FakerMethod("transaction")]
            public string Transaction()
            {
                return this.EvaluateExpression("th_#{String.random_string '51','51'}");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Blockchain.Bitcoin")]
        public partial class BitcoinGenerator : GeneratorBase
        {
            internal BitcoinGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a Bitcoin wallet address.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Bitcoin.address
            /// #=> "147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"</code>
            /// </example>
            [FakerMethod("address")]
            public string Address()
            {
                return this.EvaluateExpression("#{address_for '0'}");
            }
            /// <summary>
            /// Generates a random Bitcoin address for the given network.
            /// </summary>
            /// <param name="networkByte">
            /// The name of network protocol to generate an address for,  mainnet (0x00), testnet (0x6f).
            /// (default value "0")
            /// </param>
            [FakerMethod("address_for")]
            public string AddressFor(long networkByte = 0)
            {
                byte[] packed = new byte[25];
                packed[0] = (byte)(networkByte & 0x0FF);
                CreateRandomBytes(20, 20).CopyTo(packed, 1);
                byte[] hash = BinaryHelper.CreateSHA256Digest(BinaryHelper.CreateSHA256Digest(packed));
                packed[21] = hash[0];
                packed[22] = hash[1];
                packed[23] = hash[2];
                packed[24] = hash[3];
                return BinaryHelper.Base58Encode(packed);
            }
            /// <summary>
            /// Produces a Bitcoin testnet address.
            /// </summary>
            /// <example>
            /// <code>Faker::Blockchain::Bitcoin.testnet_address
            /// #=> "n4YjRyYD6V6zREpk6opqESDqD3KYnMdVEB"</code>
            /// </example>
            [FakerMethod("testnet_address")]
            public string TestnetAddress()
            {
                return this.EvaluateExpression("#{address_for '111'}");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Blockchain.Ethereum")]
        public partial class EthereumGenerator : GeneratorBase
        {
            internal EthereumGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method address();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Blockchain.Tezos")]
        public partial class TezosGenerator : GeneratorBase
        {
            internal TezosGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method account();
            #warning No implementation defined for method block();
            #warning No implementation defined for method contract();
            #warning No implementation defined for method operation();
            #warning No implementation defined for method public_key();
            #warning No implementation defined for method secret_key();
            #warning No implementation defined for method signature();
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Books")]
    public partial class BooksGenerator : GeneratorBase
    {
        [FakerProperty]
        public BibleGenerator Bible { get; }
        [FakerProperty]
        public CosmereGenerator Cosmere { get; }
        [FakerProperty]
        public CultureSeriesGenerator CultureSeries { get; }
        [FakerProperty]
        public DcComicsGenerator DcComics { get; }
        [FakerProperty]
        public DuneGenerator Dune { get; }
        [FakerProperty]
        public LovecraftGenerator Lovecraft { get; }
        [FakerProperty]
        public TheKingkillerChronicleGenerator TheKingkillerChronicle { get; }
        [FakerProperty]
        public TolkienGenerator Tolkien { get; }
        internal BooksGenerator(Faker faker)
                 : base(faker)
        {
            Bible = new BibleGenerator(this.Faker);
            Cosmere = new CosmereGenerator(this.Faker);
            CultureSeries = new CultureSeriesGenerator(this.Faker);
            DcComics = new DcComicsGenerator(this.Faker);
            Dune = new DuneGenerator(this.Faker);
            Lovecraft = new LovecraftGenerator(this.Faker);
            TheKingkillerChronicle = new TheKingkillerChronicleGenerator(this.Faker);
            Tolkien = new TolkienGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Bible")]
        public partial class BibleGenerator : GeneratorBase
        {
            internal BibleGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bible.character"))));
            }
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bible.location"))));
            }
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bible.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Cosmere")]
        public partial class CosmereGenerator : GeneratorBase
        {
            internal CosmereGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random allomancer.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.allomancer #=> "Coinshot"</code>
            /// </example>
            [FakerMethod("allomancer")]
            public string Allomancer()
            {
                return this.ResolveYamlValue("cosmere.allomancers");
            }
            /// <summary>
            /// Produces a random aon.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.aon #=> "Rao"</code>
            /// </example>
            [FakerMethod("aon")]
            public string Aon()
            {
                return this.ResolveYamlValue("cosmere.aons");
            }
            /// <summary>
            /// Produces a random feruchemist.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.feruchemist #=> "Archivist"</code>
            /// </example>
            [FakerMethod("feruchemist")]
            public string Feruchemist()
            {
                return this.ResolveYamlValue("cosmere.feruchemists");
            }
            /// <summary>
            /// Produces a random herald.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.herald #=> "Ishar"</code>
            /// </example>
            [FakerMethod("herald")]
            public string Herald()
            {
                return this.ResolveYamlValue("cosmere.heralds");
            }
            /// <summary>
            /// Produces a random knight radiant.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.knight_radiant #=> "Truthwatcher"</code>
            /// </example>
            [FakerMethod("knight_radiant")]
            public string KnightRadiant()
            {
                return this.ResolveYamlValue("cosmere.knights_radiant");
            }
            /// <summary>
            /// Produces a random metal.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.metal #=> "Brass"</code>
            /// </example>
            [FakerMethod("metal")]
            public string Metal()
            {
                return this.ResolveYamlValue("cosmere.metals");
            }
            /// <summary>
            /// Produces a random shard.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.shard #=> "Ambition"</code>
            /// </example>
            [FakerMethod("shard")]
            public string Shard()
            {
                return this.ResolveYamlValue("cosmere.shards");
            }
            /// <summary>
            /// Produces a random shard world.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.shard_world #=> "Yolen"</code>
            /// </example>
            [FakerMethod("shard_world")]
            public string ShardWorld()
            {
                return this.ResolveYamlValue("cosmere.shard_worlds");
            }
            /// <summary>
            /// Produces a random spren.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.spren #=> "Flamespren"</code>
            /// </example>
            [FakerMethod("spren")]
            public string Spren()
            {
                return this.ResolveYamlValue("cosmere.sprens");
            }
            /// <summary>
            /// Produces a random surge.
            /// </summary>
            /// <example>
            /// <code>Faker::Cosmere.surge #=> "Progression"</code>
            /// </example>
            [FakerMethod("surge")]
            public string Surge()
            {
                return this.ResolveYamlValue("cosmere.surges");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Books.CultureSeries")]
        public partial class CultureSeriesGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.books"))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.civ
            /// #=> "Culture"</code>
            /// </example>
            [FakerMethod("civ")]
            public string Civ()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.civs"))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship
            /// #=> "Fate Amenable To Change"</code>
            /// </example>
            [FakerMethod("culture_ship")]
            public string CultureShip()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.culture_ships"))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship_class
            /// #=> "General Systems Vehicle"</code>
            /// </example>
            [FakerMethod("culture_ship_class")]
            public string CultureShipClass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.culture_ship_classes"))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.culture_ship_class_abv
            /// #=> "The Odd Sister"</code>
            /// </example>
            [FakerMethod("culture_ship_class_abv")]
            public string CultureShipClassAbv()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.culture_ship_class_abvs"))));
            }
            /// <example>
            /// <code>Faker::Books::CultureSeries.planet
            /// #=> "Xinth"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("culture_series.planets"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("DcComics")]
        public partial class DcComicsGenerator : GeneratorBase
        {
            internal DcComicsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a hero name from DC Comics.
            /// </summary>
            /// <example>
            /// <code>Faker::DcComics.hero #=> "Batman"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dc_comics.hero"))));
            }
            /// <summary>
            /// Produces a heroine name from DC Comics.
            /// </summary>
            /// <example>
            /// <code>Faker::DcComics.heroine #=> "Supergirl"</code>
            /// </example>
            [FakerMethod("heroine")]
            public string Heroine()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dc_comics.heroine"))));
            }
            /// <summary>
            /// Produces a character name from DC Comics.
            /// </summary>
            /// <example>
            /// <code>Faker::DcComics.name #=> "Clark Kent"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dc_comics.name"))));
            }
            /// <summary>
            /// Produces a comic book title from DC Comics.
            /// </summary>
            /// <example>
            /// <code>Faker::DcComics.title #=> "Batman: The Long Halloween"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dc_comics.title"))));
            }
            /// <summary>
            /// Produces a villain name from DC Comics.
            /// </summary>
            /// <example>
            /// <code>Faker::DcComics.villain #=> "The Joker"</code>
            /// </example>
            [FakerMethod("villain")]
            public string Villain()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dc_comics.villain"))));
            }
        }
        
        /// <summary>
        /// 
        /// 				A Faker module beyond your dreams, test data beyond your imagination.
        /// 				<p>A Faker module beyond your dreams, test data beyond your imagination.</p>
        /// 			
        /// </summary>
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Books.Dune")]
        public partial class DuneGenerator : GeneratorBase
        {
            internal DuneGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Dune.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.character #=> "Leto Atreides"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dune.characters"))));
            }
            /// <summary>
            /// Produces the name of a city from Dune.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.city #=> "Arrakeen"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dune.cities"))));
            }
            /// <summary>
            /// Produces the name of a planet from Dune.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Dune.planet #=> "Caladan"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dune.planets"))));
            }
            #warning No implementation defined for method quote(string? character = null);
            #warning No implementation defined for method saying(string? source = null);
            /// <example>
            /// <code>Faker::Books::Dune.title #=> "Duke"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dune.titles"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Books.Lovecraft")]
        public partial class LovecraftGenerator : GeneratorBase
        {
            internal LovecraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a deity.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.deity #=> "Shub-Niggurath"</code>
            /// </example>
            [FakerMethod("deity")]
            public string Deity()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lovecraft.deity"))));
            }
            /// <param name="number">
            /// The number of times to repeat the chant
            /// (default value "1")
            /// </param>
            /// <example>
            /// <code>Faker::Books::Lovecraft.fhtagn
            /// #=> "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Books::Lovecraft.fhtagn(number: 3)
            /// #=> "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fht...</code>
            /// </example>
            [FakerMethod("fhtagn")]
            public string Fhtagn(long number = 1)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lovecraft.fhtagn"))));
            }
            /// <summary>
            /// Produces the name of a location.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.location #=> "Kingsport"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lovecraft.location"))));
            }
            #warning No implementation defined for method paragraph(long sentenceCount, long randomSentencesToAdd = 3);
            #warning No implementation defined for method paragraph_by_chars(long characters = 256);
            #warning No implementation defined for method paragraphs(long number = 3);
            #warning No implementation defined for method sentence(long wordCount, long randomWordsToAdd, bool openCompoundsAllowed = true);
            #warning No implementation defined for method sentences(long number = 3);
            /// <summary>
            /// Produces the name of a tome.
            /// </summary>
            /// <example>
            /// <code>Faker::Books::Lovecraft.tome #=> "Book of Eibon"</code>
            /// </example>
            [FakerMethod("tome")]
            public string Tome()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lovecraft.tome"))));
            }
            #warning No implementation defined for method word();
            #warning No implementation defined for method words(long number, bool spacesAllowed = false);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Books.TheKingkillerChronicle")]
        public partial class TheKingkillerChronicleGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("books.the_kingkiller_chronicle.books"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("books.the_kingkiller_chronicle.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("books.the_kingkiller_chronicle.creatures"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("books.the_kingkiller_chronicle.locations"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Fantasy.Tolkien")]
        public partial class TolkienGenerator : GeneratorBase
        {
            internal TolkienGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Tolkien's legendarium.
            ///                                 <p>Produces a character from Tolkien’s legendarium</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.character
            /// #=> "Goldberry"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.characters"))));
            }
            /// <summary>
            /// Produces a location from Tolkien's legendarium.
            ///                                 <p>Produces a location from Tolkien’s legendarium</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.location
            /// #=> "Helm's Deep"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.locations"))));
            }
            /// <summary>
            /// Produces the name of a poem from Tolkien's legendarium.
            ///                                 <p>Produces the name of a poem from Tolkien’s legendarium</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.poem
            /// #=> "Chip the glasses and crack the plates"</code>
            /// </example>
            [FakerMethod("poem")]
            public string Poem()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.poems"))));
            }
            /// <summary>
            /// Produces a race from Tolkien's legendarium.
            ///                                 <p>Produces a race from Tolkien’s legendarium</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Fantasy::Tolkien.race
            /// #=> "Uruk-hai"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.races"))));
            }
        }
        
        /// <summary>
        /// Produces a random book author.
        /// </summary>
        /// <example>
        /// <code>Faker::Books.author #=> "Alysha Olsen"</code>
        /// </example>
        [FakerMethod("author")]
        public string Author()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("book.author"))));
        }
        /// <summary>
        /// Produces a random genre.
        /// </summary>
        /// <example>
        /// <code>Faker::Books.genre #=> "Mystery"</code>
        /// </example>
        [FakerMethod("genre")]
        public string Genre()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("book.genre"))));
        }
        /// <summary>
        /// Produces a random book publisher.
        /// </summary>
        /// <example>
        /// <code>Faker::Books.publisher #=> "Opus Reader"</code>
        /// </example>
        [FakerMethod("publisher")]
        public string Publisher()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("book.publisher"))));
        }
        /// <summary>
        /// Produces a random book title.
        /// </summary>
        /// <example>
        /// <code>Faker::Books.title #=> "The Odd Sister"</code>
        /// </example>
        [FakerMethod("title")]
        public string Title()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("book.title"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("ChileRut")]
    public partial class ChileRutGenerator : GeneratorBase
    {
        internal ChileRutGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method check_digit();
        #warning No implementation defined for method dv();
        #warning Failed processing method format_rut : method has no name or return type.
        #warning No implementation defined for method full_rut(long minRut, long maxRut, bool @fixed);
        #warning Failed processing method last_rut : method has no name or return type.
        #warning No implementation defined for method rut(long minRut, long maxRut, bool isFixed = false);
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Coin")]
    public partial class CoinGenerator : GeneratorBase
    {
        internal CoinGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Retrieves a face to a flipped coin.
        /// </summary>
        /// <example>
        /// <code>Faker::Coin.flip #=> "Heads"</code>
        /// </example>
        [FakerMethod("flip")]
        public string Flip()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coin.flip"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("currency.name"))));
        }
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
        public CryptoCoinGenerator CryptoCoin { get; }
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
            CryptoCoin = new CryptoCoinGenerator(this.Faker);
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
                return this.EvaluateExpression("#{RandomString " + digits + "," + digits + ",'0123456789'}");
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
            /// Specifies what country prefix is used to generate the iban code. Providing ‘nil` will use a random country.
            /// (default value "'GB'")
            /// </param>
            /// <example>
            /// <code>Faker::Bank.iban #=> "GB76DZJM33188515981979"
            /// Faker::Bank.iban(country_code: "be") #=> "BE6375388567752043"
            /// Faker::Bank.iban(country_code: nil) #=> "DE45186738071857270067"</code>
            /// </example>
            [FakerMethod("iban")]
            public string Iban(string countryCode = "GB")
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
            /// </param>
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
            /// Produces a credit card number.
            /// </summary>
            /// <example>
            /// <code>Faker::Business.credit_card_number #=> "1228-1221-1221-1431"</code>
            /// </example>
            [FakerMethod("credit_card_number")]
            public string CreditCardNumber()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("business.credit_card_numbers"))));
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
            #warning No implementation defined for method logo();
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
        [FakerGenerator("CryptoCoin")]
        public partial class CryptoCoinGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("crypto_coin.coin")))).Split(',').Select(item => item).ToList();
            }
            #warning No implementation defined for method coin_hash();
            #warning No implementation defined for method coin_name();
            #warning No implementation defined for method url_logo();
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
            /// <summary>
            /// Produces a random credit card number.
            /// </summary>
            /// <param name="types">
            /// Specific credit card type.
            /// </param>
            /// <example>
            /// <code>Faker::Finance.credit_card #=> "3018-348979-1853"
            /// Faker::Finance.credit_card(:mastercard) #=> "6771-8921-2291-6236"
            /// Faker::Finance.credit_card(:mastercard, :visa) #=> "4448-8934-1277-7195"</code>
            /// </example>
            [FakerMethod("credit_card")]
            public string CreditCard(string types)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.credit_card.#{type}"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.stock_market"))));
            }
            /// <summary>
            /// Returns a randomly-selected stock ticker from a specified market.
            /// </summary>
            /// <param name="markets">
            /// The name of the market to choose the ticker from (e.g. NYSE, NASDAQ)
            /// </param>
            /// <example>
            /// <code>Faker::Finance.ticker #=> 'AMZN'
            /// Faker::Finance.vat_number('NASDAQ') #=> 'GOOG'</code>
            /// </example>
            [FakerMethod("ticker")]
            public string Ticker(string markets)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.ticker.#{market}"))));
            }
            /// <summary>
            /// Produces a random vat number.
            /// </summary>
            /// <param name="country">
            /// Two capital letter country code to use for the vat number.
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("finance.vat_number." + country + ""))));
            }
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
            
            #warning No implementation defined for method ccv(string? cardType = null);
            #warning No implementation defined for method invalid_card();
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
    [FakerGenerator("Creature")]
    public partial class CreatureGenerator : GeneratorBase
    {
        [FakerProperty]
        public AnimalGenerator Animal { get; }
        [FakerProperty]
        public BirdGenerator Bird { get; }
        [FakerProperty]
        public CatGenerator Cat { get; }
        [FakerProperty]
        public DogGenerator Dog { get; }
        [FakerProperty]
        public HorseGenerator Horse { get; }
        internal CreatureGenerator(Faker faker)
                 : base(faker)
        {
            Animal = new AnimalGenerator(this.Faker);
            Bird = new BirdGenerator(this.Faker);
            Cat = new CatGenerator(this.Faker);
            Dog = new DogGenerator(this.Faker);
            Horse = new HorseGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Creature.Animal")]
        public partial class AnimalGenerator : GeneratorBase
        {
            internal AnimalGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random animal name.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Animal.name #=> "fly"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.animal.name"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Creature.Bird")]
        public partial class BirdGenerator : GeneratorBase
        {
            internal BirdGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random adjective used to described birds.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.adjective #=> 'common'</code>
            /// </example>
            [FakerMethod("adjective")]
            public string Adjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.adjectives"))));
            }
            /// <summary>
            /// Produces a random bird anatomy word.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.anatomy #=> "rump"</code>
            /// </example>
            [FakerMethod("anatomy")]
            public string Anatomy()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.anatomy"))));
            }
            /// <summary>
            /// Produces a random, past tensed bird anatomy word.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.anatomy #=> "breasted"</code>
            /// </example>
            [FakerMethod("anatomy_past_tense")]
            public string AnatomyPastTense()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.anatomy_past_tense"))));
            }
            /// <summary>
            /// Produces a random color word used in describing birds.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.color #=> "ferruginous"</code>
            /// </example>
            [FakerMethod("color")]
            public string Color()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.colors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.common_family_name"))));
            }
            /// <summary>
            /// Produces a random common name for a bird.
            /// </summary>
            /// <param name="taxOrder">
            /// taxonomic order
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Creature::Bird.common_name #=> 'wren'</code>
            /// </example>
            [FakerMethod("common_name")]
            public string CommonName(string? taxOrder = null)
            {
                var taxOrderMap = this.Faker.FetchYamlMap("creature.bird.order_common_map");
                var allTaxOrders = taxOrderMap.Keys.OfType<string>().ToList();
                
                if (taxOrder == null)
                {
                taxOrder = this.Random.NextItem(allTaxOrders);
                }
                else
                {
                if (allTaxOrders.Contains(taxOrder) == false)
                    throw new ArgumentException($"Invalid taxonomic order. Valid values are {string.Join(", ", allTaxOrders)}.");
                }
                
                var commonName = this.Translate(this.Faker.FetchYamlValue($"creature.bird.order_common_map.{taxOrder}"));
                return commonName;
            }
            /// <summary>
            /// Produces a random emotional adjective NOT used to described birds ...but could be.
            ///                                 <p>Produces a random emotional adjective NOT used to described birds …but could be</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.emotional_adjective #=> 'cantankerous'</code>
            /// </example>
            [FakerMethod("emotional_adjective")]
            public string EmotionalAdjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.emotional_adjectives"))));
            }
            /// <summary>
            /// Produces a random geographical word used in describing birds.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.geo #=> "Eurasian"</code>
            /// </example>
            [FakerMethod("geo")]
            public string Geo()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.geo"))));
            }
            /// <summary>
            /// Produces a random and IMplausible common name for a bird.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.implausible_common_name #=> 'Hellinger's Cantankerous Chickadee'</code>
            /// </example>
            [FakerMethod("implausible_common_name")]
            public string ImplausibleCommonName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.implausible_common_names"))));
            }
            #warning No implementation defined for method order();
            #warning No implementation defined for method order_with_common_name();
            /// <summary>
            /// Produces a random and plausible common name for a bird.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.plausible_common_name #=> 'Hellinger's Wren'</code>
            /// </example>
            [FakerMethod("plausible_common_name")]
            public string PlausibleCommonName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.plausible_common_names"))));
            }
            /// <summary>
            /// Produces a random adjective NOT used to described birds ...but probably shouldn't.
            ///                                 <p>Produces a random adjective NOT used to described birds …but probably shouldn’t</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Bird.silly_adjective #=> 'drunk'</code>
            /// </example>
            [FakerMethod("silly_adjective")]
            public string SillyAdjective()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.bird.silly_adjectives"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Creature.Cat")]
        public partial class CatGenerator : GeneratorBase
        {
            internal CatGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random cat breed.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.breed #=> "Scottish Fold"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.cat.breed"))));
            }
            /// <summary>
            /// Produces a random name for a cat.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.name #=> "Felix"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.cat.name"))));
            }
            /// <summary>
            /// Produces a random cat breed registry.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Cat.registry #=> "Fancy Southern Africa Cat Council"</code>
            /// </example>
            [FakerMethod("registry")]
            public string Registry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.cat.registry"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Creature.Dog")]
        public partial class DogGenerator : GeneratorBase
        {
            internal DogGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random dog age.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.age #=> "puppy"</code>
            /// </example>
            [FakerMethod("age")]
            public string Age()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.age"))));
            }
            /// <summary>
            /// Produces a random dog breed.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.breed #=> "Yorkshire Terrier"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.breed"))));
            }
            /// <summary>
            /// Produces a random coat length.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.coat_length #=> "short"</code>
            /// </example>
            [FakerMethod("coat_length")]
            public string CoatLength()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.coat_length"))));
            }
            #warning No implementation defined for method gender();
            /// <summary>
            /// Produces a random dog meme phrase.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.meme_phrase #=> "smol pupperino"</code>
            /// </example>
            [FakerMethod("meme_phrase")]
            public string MemePhrase()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.meme_phrase"))));
            }
            /// <summary>
            /// Produces a random name for a dog.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.name #=> "Spike"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.name"))));
            }
            /// <summary>
            /// Produces a random size of a dog.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.size #=> "small"</code>
            /// </example>
            [FakerMethod("size")]
            public string Size()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.size"))));
            }
            /// <summary>
            /// Produces a random sound made by a dog.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Dog.sound #=> "woof woof"</code>
            /// </example>
            [FakerMethod("sound")]
            public string Sound()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.dog.sound"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Creature.Horse")]
        public partial class HorseGenerator : GeneratorBase
        {
            internal HorseGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random horse breed.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Horse.breed #=> "Spanish Barb see Barb Horse"</code>
            /// </example>
            [FakerMethod("breed")]
            public string Breed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.horse.breed"))));
            }
            /// <summary>
            /// Produces a random name for a horse.
            /// </summary>
            /// <example>
            /// <code>Faker::Creature::Horse.name #=> "Noir"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("creature.horse.name"))));
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
        public BooleanGenerator Boolean { get; }
        [FakerProperty]
        public ColorGenerator Color { get; }
        [FakerProperty]
        public CryptoGenerator Crypto { get; }
        [FakerProperty]
        public DateGenerator Date { get; }
        [FakerProperty]
        public LoremGenerator Lorem { get; }
        [FakerProperty]
        public MeasurementGenerator Measurement { get; }
        [FakerProperty]
        public NumberGenerator Number { get; }
        [FakerProperty]
        public StringGenerator String { get; }
        [FakerProperty]
        public TimeGenerator Time { get; }
        internal DataGenerator(Faker faker)
                 : base(faker)
        {
            Alphanumeric = new AlphanumericGenerator(this.Faker);
            Boolean = new BooleanGenerator(this.Faker);
            Color = new ColorGenerator(this.Faker);
            Crypto = new CryptoGenerator(this.Faker);
            Date = new DateGenerator(this.Faker);
            Lorem = new LoremGenerator(this.Faker);
            Measurement = new MeasurementGenerator(this.Faker);
            Number = new NumberGenerator(this.Faker);
            String = new StringGenerator(this.Faker);
            Time = new TimeGenerator(this.Faker);
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
            /// <param name="number">
            /// The length of the string to generate
            /// (default value "32")
            /// </param>
            /// <example>
            /// <code>Faker::Alphanumeric.alpha(number: 10) #=> "zlvubkrwga"</code>
            /// </example>
            [FakerMethod("alpha")]
            public string Alpha(long number = 32)
            {
                return this.EvaluateExpression("#{RandomString " + number + "," + number + ",'abcdefghijklmnopqrstuvwxyz'}");
            }
            /// <summary>
            /// Produces a random string of alphanumeric characters.
            /// </summary>
            /// <param name="number">
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
            public string AlphaNumeric(long number = 32)
            {
                return this.EvaluateExpression("#{RandomString " + number + "," + number + ",'0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'}");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Boolean")]
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
        [FakerGenerator("Color")]
        public partial class ColorGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("color.name"))));
            }
            #warning No implementation defined for method hex_color(UNKNOWN_Hash? args = null);
            #warning No implementation defined for method hsl_color(UNKNOWN_FLoat hue, double saturation, double? lightness = null);
            #warning No implementation defined for method hsl_to_hex(UNKNOWN_Array(Float, Float, Float) aHslColor);
            #warning No implementation defined for method hsla_color();
            #warning No implementation defined for method rgb_color();
            #warning Failed processing method single_rgb_color : method has no name or return type.
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Crypto")]
        public partial class CryptoGenerator : GeneratorBase
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
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Date")]
        public partial class DateGenerator : GeneratorBase
        {
            internal DateGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method backward(long days = 365);
            #warning No implementation defined for method between(DateOnly from, DateOnly to);
            #warning No implementation defined for method between_except(DateOnly from, DateOnly to, DateOnly excepted);
            #warning No implementation defined for method birthday(long minAge, long maxAge = 65);
            #warning Failed processing method birthday_date : method has no name or return type.
            #warning No implementation defined for method forward(long from, long days = 365);
            #warning Failed processing method get_date_object : method has no name or return type.
            #warning No implementation defined for method in_date_period(long month, long year = ::Date.today.year);
            #warning No implementation defined for method on_day_of_week_between(UNKNOWN_Symbol day, DateOnly from, DateOnly to);
        }
        
        /// <summary>
        /// Based on Perl's Text::Lorem.
        /// <p>Based on Perl’s Text::Lorem</p>
        /// 
        /// </summary>
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Lorem")]
        public partial class LoremGenerator : GeneratorBase
        {
            internal LoremGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Gets a '.' character in the current locale.
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_period")]
            public string LocalePeriod()
            {
                return this.ResolveYamlValue("lorem.punctuation.period");
            }
            /// <summary>
            /// Gets a '?' character in the current locale
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_question_mark")]
            public string LocaleQuestionMark()
            {
                return this.ResolveYamlValue("lorem.punctuation.question_mark");
            }
            /// <summary>
            /// Gets a 'space' character in the current locale.
            /// private needed for Japanese
            /// </summary>
            [FakerMethod("locale_space")]
            public string LocaleSpace()
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
            
            #warning No implementation defined for method between(UNKNOWN_Numeric from, UNKNOWN_Numeric? to = null);
            #warning No implementation defined for method binary(long digits = 4);
            #warning No implementation defined for method decimal(long lDigits, long rDigits = 2);
            #warning No implementation defined for method decimal_part(long digits = 10);
            #warning No implementation defined for method digit();
            #warning Failed processing method generate : method has no name or return type.
            #warning Failed processing method greater_than_zero : method has no name or return type.
            #warning No implementation defined for method hexadecimal(long digits = 6);
            #warning No implementation defined for method leading_zero_number(long digits = 10);
            #warning Failed processing method less_than_zero : method has no name or return type.
            #warning No implementation defined for method negative(long from, long to);
            #warning No implementation defined for method non_zero_digit();
            #warning No implementation defined for method normal(long mean, UNKNOWN_Numeric? standardDeviation = null);
            #warning No implementation defined for method number(long digits = 10);
            #warning No implementation defined for method positive(long from, long to = 5000.00);
            #warning Failed processing method should_be : method has no name or return type.
            #warning No implementation defined for method within(UNKNOWN_Range? range = null);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("String")]
        public partial class StringGenerator : GeneratorBase
        {
            internal StringGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method char_space_ratio();
            // Expecting native implementation
            /*
            /// <param name="text">
            /// The string to get the length of
            /// </param>
            [FakerMethod("length")]
            public long Length(string text)
            */
            // Expecting native implementation
            /*
            /// <param name="text">
            /// The string as lower case
            /// </param>
            [FakerMethod("lower")]
            public string Lower(string text)
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
            #warning No implementation defined for method select_a();
            #warning No implementation defined for method space_or_utf8_char();
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
            public string SubString(string text, long start, long? length = null)
            {
                return text.Substring((int)start, (int)(length ??(text.Length-start)));
            }
            #warning No implementation defined for method utf8character();
            #warning No implementation defined for method utf8string();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Time")]
        public partial class TimeGenerator : GeneratorBase
        {
            internal TimeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method backward(long days, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
            #warning No implementation defined for method between(UNKNOWN_Time from, UNKNOWN_Time to, UNKNOWN_Symbol? format = null);
            #warning No implementation defined for method between_dates(DateOnly from, DateOnly to, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
            #warning Failed processing method date_with_random_time : method has no name or return type.
            #warning No implementation defined for method forward(long days, UNKNOWN_Symbol period, UNKNOWN_Symbol? format = null);
            #warning Failed processing method get_time_object : method has no name or return type.
            #warning Failed processing method hours : method has no name or return type.
            #warning Failed processing method minutes : method has no name or return type.
            #warning Failed processing method seconds : method has no name or return type.
            #warning Failed processing method time_with_format : method has no name or return type.
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Defence")]
    public partial class DefenceGenerator : GeneratorBase
    {
        [FakerProperty]
        public MilitaryGenerator Military { get; }
        [FakerProperty]
        public NatoPhoneticAlphabetGenerator NatoPhoneticAlphabet { get; }
        internal DefenceGenerator(Faker faker)
                 : base(faker)
        {
            Military = new MilitaryGenerator(this.Faker);
            NatoPhoneticAlphabet = new NatoPhoneticAlphabetGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Military")]
        public partial class MilitaryGenerator : GeneratorBase
        {
            internal MilitaryGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Air Force.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.air_force_rank #=> "Captain"</code>
            /// </example>
            [FakerMethod("air_force_rank")]
            public string AirForceRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.air_force_rank"))));
            }
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Army.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.army_rank #=> "Staff Sergeant"</code>
            /// </example>
            [FakerMethod("army_rank")]
            public string ArmyRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.army_rank"))));
            }
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Coast Guard</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.coast_guard_rank #=> "Master Chief Petty Officer of the Coast Guard"</code>
            /// </example>
            [FakerMethod("coast_guard_rank")]
            public string CoastGuardRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.coast_guard_rank"))));
            }
            /// <summary>
            /// Produces a U.S.
            ///                             <p>Department of Defense Paygrade.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.dod_paygrade #=> "E-6"</code>
            /// </example>
            [FakerMethod("dod_paygrade")]
            public string DodPaygrade()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.dod_paygrade"))));
            }
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Marines.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.marines_rank #=> "Gunnery Sergeant"</code>
            /// </example>
            [FakerMethod("marines_rank")]
            public string MarinesRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.marines_rank"))));
            }
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Navy.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.navy_rank #=> "Seaman"</code>
            /// </example>
            [FakerMethod("navy_rank")]
            public string NavyRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.navy_rank"))));
            }
            /// <summary>
            /// Produces a rank in the U.S.
            ///                             <p>Space Force.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Military.space_force_rank #=> "Senior Enlisted Advisor of the Space Force"</code>
            /// </example>
            [FakerMethod("space_force_rank")]
            public string SpaceForceRank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("military.space_force_rank"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("NatoPhoneticAlphabet")]
        public partial class NatoPhoneticAlphabetGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("nato_phonetic_alphabet.code_word"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Education")]
    public partial class EducationGenerator : GeneratorBase
    {
        internal EducationGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        /// <summary>
        /// Produces a campus name.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.campus #=> "Vertapple Campus"</code>
        /// </example>
        [FakerMethod("campus")]
        public string Campus()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.campus"))));
        }
        /// <summary>
        /// Produces a course name.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.course_name #=> "Criminology 101"</code>
        /// </example>
        [FakerMethod("course_name")]
        public string CourseName()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.course_name"))));
        }
        /// <summary>
        /// Produces a university degree.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.degree #=> "Associate Degree in Criminology"</code>
        /// </example>
        [FakerMethod("degree")]
        public string Degree()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.degree"))));
        }
        /// <summary>
        /// Produces a primary school.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.primary_school #=> "Brighthurst Elementary School"</code>
        /// </example>
        [FakerMethod("primary_school")]
        public string PrimarySchool()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.primary_school"))));
        }
        /// <summary>
        /// Produces a secondary school.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.secondary_school #=> "Iceborough Secondary College"</code>
        /// </example>
        [FakerMethod("secondary_school")]
        public string SecondarySchool()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.secondary_school"))));
        }
        /// <summary>
        /// Produces a university subject.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.subject #=> "Criminology"</code>
        /// </example>
        [FakerMethod("subject")]
        public string Subject()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.subject"))));
        }
        /// <summary>
        /// Produces a university name.
        /// </summary>
        /// <example>
        /// <code>Faker::Education.university #=> "Mallowtown Technical College"</code>
        /// </example>
        [FakerMethod("university")]
        public string University()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("educator.university"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("FoodAndDrink")]
    public partial class FoodAndDrinkGenerator : GeneratorBase
    {
        [FakerProperty]
        public BeerGenerator Beer { get; }
        [FakerProperty]
        public CoffeeGenerator Coffee { get; }
        [FakerProperty]
        public FoodGenerator Food { get; }
        [FakerProperty]
        public TeaGenerator Tea { get; }
        internal FoodAndDrinkGenerator(Faker faker)
                 : base(faker)
        {
            Beer = new BeerGenerator(this.Faker);
            Coffee = new CoffeeGenerator(this.Faker);
            Food = new FoodGenerator(this.Faker);
            Tea = new TeaGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Beer")]
        public partial class BeerGenerator : GeneratorBase
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
                return this.EvaluateExpression("#{rand(2.0..10.0).round(1)}%");
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
                return this.EvaluateExpression("#{rand(5.0..20.0).round(1)}°Blg");
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("beer.hop"))));
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
                return this.EvaluateExpression("#{rand(10..100)} IBU");
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("beer.malt"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("beer.name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("beer.style"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("beer.yeast"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Coffee")]
        public partial class CoffeeGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coffee.blend_name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coffee.intensifier"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coffee.notes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coffee.country"))));
            }
            #warning Failed processing method search_format : method has no name or return type.
            /// <summary>
            /// Produces a random coffee variety.
            /// </summary>
            /// <example>
            /// <code>Faker::Coffee.variety #=> "Red Bourbon"</code>
            /// </example>
            [FakerMethod("variety")]
            public string Variety()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("coffee.variety"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Food")]
        public partial class FoodGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.allergens"))));
            }
            /// <summary>
            /// Retrieves a description about some dish.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.description #=> "Breaded fried chicken with waffles. Served with maple syrup."</code>
            /// </example>
            [FakerMethod("description")]
            public string Description()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.descriptions"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.dish"))));
            }
            /// <summary>
            /// Retrieves ethnic category.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.ethnic_category #=> "Indian cuisine"</code>
            /// </example>
            [FakerMethod("ethnic_category")]
            public string EthnicCategory()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.ethnic_category"))));
            }
            /// <summary>
            /// Retrieves a fruit.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.fruits #=> "Papaya"</code>
            /// </example>
            [FakerMethod("fruits")]
            public string Fruits()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.fruits"))));
            }
            /// <summary>
            /// Retrieves an ingredient.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.ingredient #=> "Olives"</code>
            /// </example>
            [FakerMethod("ingredient")]
            public string Ingredient()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.ingredients"))));
            }
            /// <summary>
            /// Retrieves cooking measures.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.measurement #=> "1/3"</code>
            /// </example>
            [FakerMethod("measurement")]
            public string Measurement()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.measurement_sizes"))));
            }
            /// <summary>
            /// Retrieves metric measurements.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.metric_measurement #=> "centiliter"</code>
            /// </example>
            [FakerMethod("metric_measurement")]
            public string MetricMeasurement()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.metric_measurements"))));
            }
            /// <summary>
            /// Retrieves some random spice.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.spice #=> "Garlic Chips"</code>
            /// </example>
            [FakerMethod("spice")]
            public string Spice()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.spices"))));
            }
            /// <summary>
            /// Retrieves a vegetable.
            /// </summary>
            /// <example>
            /// <code>Faker::Food.vegetables #=> "Broccolini"</code>
            /// </example>
            [FakerMethod("vegetables")]
            public string Vegetables()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("food.vegetables"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Tea")]
        public partial class TeaGenerator : GeneratorBase
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
            /// the type of tea to query for (valid types: ‘Black’, ‘Green’, ‘Oolong’, ‘White’, and ‘Herbal’)
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Tea.variety
            /// #=> "Earl Grey"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Tea.variety(type: 'Green')
            /// #=> "Jasmine"</code>
            /// </example>
            [FakerMethod("variety")]
            public string Variety(string? type = null)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tea.type"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Game")]
    public partial class GameGenerator : GeneratorBase
    {
        [FakerProperty]
        public ClashOfClansGenerator ClashOfClans { get; }
        [FakerProperty]
        public ControlGenerator Control { get; }
        [FakerProperty]
        public DnDGenerator DnD { get; }
        [FakerProperty]
        public DotaGenerator Dota { get; }
        [FakerProperty]
        public ElderScrollsGenerator ElderScrolls { get; }
        [FakerProperty]
        public FalloutGenerator Fallout { get; }
        [FakerProperty]
        public FinalFantasyXIVGenerator FinalFantasyXIV { get; }
        [FakerProperty]
        public HalfLifeGenerator HalfLife { get; }
        [FakerProperty]
        public HeroesGenerator Heroes { get; }
        [FakerProperty]
        public HeroesOfTheStormGenerator HeroesOfTheStorm { get; }
        [FakerProperty]
        public LeagueOfLegendsGenerator LeagueOfLegends { get; }
        [FakerProperty]
        public MinecraftGenerator Minecraft { get; }
        [FakerProperty]
        public MystGenerator Myst { get; }
        [FakerProperty]
        public OverwatchGenerator Overwatch { get; }
        [FakerProperty]
        public PokemonGenerator Pokemon { get; }
        [FakerProperty]
        public SonicTheHedgehogGenerator SonicTheHedgehog { get; }
        [FakerProperty]
        public StreetFighterGenerator StreetFighter { get; }
        [FakerProperty]
        public SuperMarioGenerator SuperMario { get; }
        [FakerProperty]
        public SuperSmashBrosGenerator SuperSmashBros { get; }
        [FakerProperty]
        public TarkovGenerator Tarkov { get; }
        [FakerProperty]
        public TouhouGenerator Touhou { get; }
        [FakerProperty]
        public WarhammerFantasyGenerator WarhammerFantasy { get; }
        [FakerProperty]
        public WitcherGenerator Witcher { get; }
        [FakerProperty]
        public WorldOfWarcraftGenerator WorldOfWarcraft { get; }
        [FakerProperty]
        public ZeldaGenerator Zelda { get; }
        internal GameGenerator(Faker faker)
                 : base(faker)
        {
            ClashOfClans = new ClashOfClansGenerator(this.Faker);
            Control = new ControlGenerator(this.Faker);
            DnD = new DnDGenerator(this.Faker);
            Dota = new DotaGenerator(this.Faker);
            ElderScrolls = new ElderScrollsGenerator(this.Faker);
            Fallout = new FalloutGenerator(this.Faker);
            FinalFantasyXIV = new FinalFantasyXIVGenerator(this.Faker);
            HalfLife = new HalfLifeGenerator(this.Faker);
            Heroes = new HeroesGenerator(this.Faker);
            HeroesOfTheStorm = new HeroesOfTheStormGenerator(this.Faker);
            LeagueOfLegends = new LeagueOfLegendsGenerator(this.Faker);
            Minecraft = new MinecraftGenerator(this.Faker);
            Myst = new MystGenerator(this.Faker);
            Overwatch = new OverwatchGenerator(this.Faker);
            Pokemon = new PokemonGenerator(this.Faker);
            SonicTheHedgehog = new SonicTheHedgehogGenerator(this.Faker);
            StreetFighter = new StreetFighterGenerator(this.Faker);
            SuperMario = new SuperMarioGenerator(this.Faker);
            SuperSmashBros = new SuperSmashBrosGenerator(this.Faker);
            Tarkov = new TarkovGenerator(this.Faker);
            Touhou = new TouhouGenerator(this.Faker);
            WarhammerFantasy = new WarhammerFantasyGenerator(this.Faker);
            Witcher = new WitcherGenerator(this.Faker);
            WorldOfWarcraft = new WorldOfWarcraftGenerator(this.Faker);
            Zelda = new ZeldaGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.ClashOfClans")]
        public partial class ClashOfClansGenerator : GeneratorBase
        {
            internal ClashOfClansGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a defensive building from Clash Of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ClashOfClans.defensive_building #=> "Cannon"</code>
            /// </example>
            [FakerMethod("defensive_building")]
            public string DefensiveBuilding()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.clash_of_clans.defensive_buildings"))));
            }
            /// <summary>
            /// Produces the name of a rank from Clash Of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ClashOfClans.rank #=> "Legend"</code>
            /// </example>
            [FakerMethod("rank")]
            public string Rank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.clash_of_clans.ranks"))));
            }
            /// <summary>
            /// Produces the name of a troop from Clash of Clans.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ClashOfClans.troop #=> "Barbarian"</code>
            /// </example>
            [FakerMethod("troop")]
            public string Troop()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.clash_of_clans.troops"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Control")]
        public partial class ControlGenerator : GeneratorBase
        {
            internal ControlGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an Altered Item.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.altered_item #=> "Rubber Duck"</code>
            /// </example>
            [FakerMethod("altered_item")]
            public string AlteredItem()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.altered_item"))));
            }
            /// <summary>
            /// Produces the location of an Altered World Event (AWE).
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.altered_world_event #=> "Ordinary, Wisconsin"</code>
            /// </example>
            [FakerMethod("altered_world_event")]
            public string AlteredWorldEvent()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.altered_world_event"))));
            }
            /// <summary>
            /// Produces the name of a character from Control.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.character #=> "Jesse Faden"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.character"))));
            }
            /// <summary>
            /// Produces a line from the Hiss incantation.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.hiss #=> "Push the fingers through the surface into the wet."</code>
            /// </example>
            [FakerMethod("hiss")]
            public string Hiss()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.hiss"))));
            }
            /// <summary>
            /// Produces the name of a location from Control.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.location #=> "Dimensional Research"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.location"))));
            }
            /// <summary>
            /// Produces the name of an Object of Power (OoP).
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.object_of_power #=> "Hotline"</code>
            /// </example>
            [FakerMethod("object_of_power")]
            public string ObjectOfPower()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.object_of_power"))));
            }
            /// <summary>
            /// Produces a quote from Control.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.quote #=> "He never liked fridge duty"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.quote"))));
            }
            /// <summary>
            /// < Produces a line/quote/message from The Board >.
            ///                                 <p>&lt; Produces a line/quote/message from The Board &gt;</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Control.the_board #=> "< You/We wield the Gun/You. The Board appoints you. Congratulations, Director. >"</code>
            /// </example>
            [FakerMethod("the_board")]
            public string TheBoard()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.control.the_board"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.DnD")]
        public partial class DnDGenerator : GeneratorBase
        {
            internal DnDGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an alignment from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.alignment #=> "Lawful Neutral"</code>
            /// </example>
            [FakerMethod("alignment")]
            public string Alignment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.alignments"))));
            }
            /// <summary>
            /// Produces the name of a background from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.background #=> "Urchin"</code>
            /// </example>
            [FakerMethod("background")]
            public string Background()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.backgrounds"))));
            }
            /// <summary>
            /// Produces the name of a city from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.city #=> "Earthfast"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.cities"))));
            }
            /// <summary>
            /// Produces the first name of a character or monster from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.name #=> "Eilonwy"</code>
            /// </example>
            [FakerMethod("first_name")]
            public string FirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.name.first_name"))));
            }
            /// <summary>
            /// Produces the name of a class from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.klass #=> "Warlock"</code>
            /// </example>
            [FakerMethod("klass")]
            public string Klass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.klasses"))));
            }
            /// <summary>
            /// Produces the name of a language from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.language #=> "Gnomish"</code>
            /// </example>
            [FakerMethod("language")]
            public string Language()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.languages"))));
            }
            /// <summary>
            /// Produces a last name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.last_name #=> "Leafwhisper"</code>
            /// </example>
            [FakerMethod("last_name")]
            public string LastName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.name.last_name"))));
            }
            /// <summary>
            /// Produces the name of a melee weapon from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.melee_weapon #=> "Handaxe"</code>
            /// </example>
            [FakerMethod("melee_weapon")]
            public string MeleeWeapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.melee_weapons"))));
            }
            /// <summary>
            /// Produces the name of a monster from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.monster #=> "Manticore"</code>
            /// </example>
            [FakerMethod("monster")]
            public string Monster()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.monsters"))));
            }
            /// <summary>
            /// Produces a full name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.name #=> "Drakon Blackthorn"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.name.first_name"))));
            }
            /// <summary>
            /// Produces the name of a race from Dungeons and Dragons (PHB).
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.races #=> "Dwarf"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.races"))));
            }
            /// <summary>
            /// Produces the name of a ranged weapon from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.ranged_weapon #=> "Shortbow"</code>
            /// </example>
            [FakerMethod("ranged_weapon")]
            public string RangedWeapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.ranged_weapons"))));
            }
            /// <summary>
            /// Produces a last name from Dungeons and Dragons.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DnD.title_name #=> "Corvus the Cunning"</code>
            /// </example>
            [FakerMethod("title_name")]
            public string TitleName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dnd.name.first_name"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Dota")]
        public partial class DotaGenerator : GeneratorBase
        {
            internal DotaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a building from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Dota.building #=> "Tower"</code>
            /// </example>
            [FakerMethod("building")]
            public string Building()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota.building"))));
            }
            /// <summary>
            /// Produces the name of a hero from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Dota.hero #=> "Abaddon"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota.hero"))));
            }
            /// <summary>
            /// Produces the name of an item from Dota.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Dota.item #=> "Armlet of Mordiggian"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota.item"))));
            }
            /// <summary>
            /// Produces the name of a professional Dota player.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Dota.player #=> "Dendi"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota.player"))));
            }
            /// <summary>
            /// Produces the name of a hero from Dota.
            /// </summary>
            /// <param name="hero">
            /// The name of a Dota hero.
            /// (default value "'abaddon'")
            /// </param>
            /// <example>
            /// <code>Faker::Game::Dota.quote #=> "You have called death upon yourself."
            /// Faker::Game::Dota.quote(hero: 'alchemist') #=> "Better living through alchemy!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote(string hero = "abaddon")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota." + hero + ".quote"))));
            }
            /// <summary>
            /// Produces the name of a professional Dota team.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Dota.team #=> "Evil Geniuses"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.dota.team"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.ElderScrolls")]
        public partial class ElderScrollsGenerator : GeneratorBase
        {
            internal ElderScrollsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a city from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.city #=> "Whiterun"</code>
            /// </example>
            [FakerMethod("city")]
            public string City()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.city"))));
            }
            /// <summary>
            /// Produces the name of a creature from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.creature #=> "Frost Troll"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.creature"))));
            }
            /// <summary>
            /// Produces the name of a dragon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.dragon #=> "Blood Dragon"</code>
            /// </example>
            [FakerMethod("dragon")]
            public string Dragon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.dragon"))));
            }
            /// <summary>
            /// Produces a first name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.first_name #=> "Balgruuf"</code>
            /// </example>
            [FakerMethod("first_name")]
            public string FirstName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.first_name"))));
            }
            /// <summary>
            /// Produces a weapon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.jewelry #=> "Silver Ruby Ring"</code>
            /// </example>
            [FakerMethod("jewelry")]
            public string Jewelry()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.jewelry"))));
            }
            /// <summary>
            /// Produces a last name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.last_name #=> "The Old"</code>
            /// </example>
            [FakerMethod("last_name")]
            public string LastName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.last_name"))));
            }
            /// <summary>
            /// Produces a randomly generated name from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.name #=> "Balgruuf The Old"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.first_name"))));
            }
            /// <summary>
            /// Produces the name of a race from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.race #=> "Argonian"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.race"))));
            }
            /// <summary>
            /// Produces the name of a region from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.region #=> "Cyrodiil"</code>
            /// </example>
            [FakerMethod("region")]
            public string Region()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.region"))));
            }
            /// <summary>
            /// Produces a weapon from the Elder Scrolls universe.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::ElderScrolls.weapon #=> "Elven Bow"</code>
            /// </example>
            [FakerMethod("weapon")]
            public string Weapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.elder_scrolls.weapon"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Fallout")]
        public partial class FalloutGenerator : GeneratorBase
        {
            internal FalloutGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Fallout.character #=> "Liberty Prime"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.fallout.characters"))));
            }
            /// <summary>
            /// Produces the name of a faction from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Fallout.faction #=> "Brotherhood of Steel"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.fallout.factions"))));
            }
            /// <summary>
            /// Produces the name of a location from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Fallout.location #=> "New Vegas"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.fallout.locations"))));
            }
            /// <summary>
            /// Produces a quote from the Fallout games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Fallout.quote
            /// #=> "Democracy is non-negotiable"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.fallout.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.FinalFantasyXIV")]
        public partial class FinalFantasyXIVGenerator : GeneratorBase
        {
            internal FinalFantasyXIVGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from FFXIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::FinalFantasyXIV.character #=> "Y'shtola Rhul"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.final_fantasy_xiv.characters"))));
            }
            /// <summary>
            /// Produces a data center from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::FinalFantasyXIV.data_center #=> "Aether"</code>
            /// </example>
            [FakerMethod("data_center")]
            public string DataCenter()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.final_fantasy_xiv.data_centers"))));
            }
            /// <summary>
            /// Produces a job name from Final Fantasy XIV.
            ///                                 <p>Either a battle or non-battle playable job.</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Game::FinalFantasyXIV.job #=> "Paladin"</code>
            /// </example>
            [FakerMethod("job")]
            public string Job()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.final_fantasy_xiv.jobs"))));
            }
            /// <summary>
            /// Produces the name of a playable race from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::FinalFantasyXIV.race #=> "Miqo'te"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.final_fantasy_xiv.races"))));
            }
            /// <summary>
            /// Produces a geographical zone from Final Fantasy XIV.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::FinalFantasyXIV.zone #=> "Eastern La Noscea"</code>
            /// </example>
            [FakerMethod("zone")]
            public string Zone()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.final_fantasy_xiv.zones"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.HalfLife")]
        public partial class HalfLifeGenerator : GeneratorBase
        {
            internal HalfLifeGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HalfLife.character #=> "Gordon Freeman"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.half_life.character"))));
            }
            /// <summary>
            /// Produces the name of an enemy from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HalfLife.enemy #=> "Headcrab"</code>
            /// </example>
            [FakerMethod("enemy")]
            public string Enemy()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.half_life.enemy"))));
            }
            /// <summary>
            /// Produces the name of a location from the Half-Life games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HalfLife.location #=> "Black Mesa Research Facility"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.half_life.location"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Heroes")]
        public partial class HeroesGenerator : GeneratorBase
        {
            internal HeroesGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an artifact from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Heroes.artifact #=> "Armageddon's Blade"</code>
            /// </example>
            [FakerMethod("artifact")]
            public string Artifact()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes.artifacts"))));
            }
            /// <summary>
            /// Produces the name of a class from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Heroes.klass #=> "Knight"</code>
            /// </example>
            [FakerMethod("klass")]
            public string Klass()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes.klasses"))));
            }
            /// <summary>
            /// Produces the name of a hero from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Heroes.name #=> "Christian"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes.names"))));
            }
            /// <summary>
            /// Produces the name of a specialty from Heroes 3.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Heroes.specialty #=> "Ballista"</code>
            /// </example>
            [FakerMethod("specialty")]
            public string Specialty()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes.specialties"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.HeroesOfTheStorm")]
        public partial class HeroesOfTheStormGenerator : GeneratorBase
        {
            internal HeroesOfTheStormGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a battleground from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HeroesOfTheStorm.battleground #=> "Towers of Doom"</code>
            /// </example>
            [FakerMethod("battleground")]
            public string Battleground()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes_of_the_storm.battlegrounds"))));
            }
            #warning No implementation defined for method class();
            /// <summary>
            /// Produces a class name from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HeroesOfTheStorm.class_name #=> "Support"</code>
            /// </example>
            [FakerMethod("class_name")]
            public string ClassName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes_of_the_storm.class_names"))));
            }
            /// <summary>
            /// Produces a hero from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HeroesOfTheStorm.hero #=> "Illidan"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes_of_the_storm.heroes"))));
            }
            /// <summary>
            /// Produces a quote from Heroes of the Storm.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::HeroesOfTheStorm.quote #=> "MEAT!!!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("heroes_of_the_storm.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.LeagueOfLegends")]
        public partial class LeagueOfLegendsGenerator : GeneratorBase
        {
            internal LeagueOfLegendsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a champion from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.champion #=> "Jarvan IV"</code>
            /// </example>
            [FakerMethod("champion")]
            public string Champion()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.champion"))));
            }
            /// <summary>
            /// Produces a location from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.location #=> "Demacia"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.location"))));
            }
            /// <summary>
            /// Produces a mastery from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.masteries #=> "Double Edged Sword"</code>
            /// </example>
            [FakerMethod("masteries")]
            public string Masteries()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.masteries"))));
            }
            /// <summary>
            /// Produces a quote from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.quote #=> "Purge the unjust."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.quote"))));
            }
            /// <summary>
            /// Produces a rank from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.rank #=> "Bronze V"</code>
            /// </example>
            [FakerMethod("rank")]
            public string Rank()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.rank"))));
            }
            /// <summary>
            /// Produces a summoner spell from League of Legends.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::LeagueOfLegends.summoner_spell #=> "Flash"</code>
            /// </example>
            [FakerMethod("summoner_spell")]
            public string SummonerSpell()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.league_of_legends.summoner_spell"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Minecraft")]
        public partial class MinecraftGenerator : GeneratorBase
        {
            internal MinecraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an achievement from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.achievement #=> "Time to Mine!"</code>
            /// </example>
            [FakerMethod("achievement")]
            public string Achievement()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.achievement"))));
            }
            /// <summary>
            /// Produces the name of a biome from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.biome #=> "Jungle"</code>
            /// </example>
            [FakerMethod("biome")]
            public string Biome()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.biome"))));
            }
            /// <summary>
            /// Produces the name of a block from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.block #=> "Stone"</code>
            /// </example>
            [FakerMethod("block")]
            public string Block()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.blocks"))));
            }
            /// <summary>
            /// Produces the name of a enchantment from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.enchantment #=> "Fire Protection"</code>
            /// </example>
            [FakerMethod("enchantment")]
            public string Enchantment()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.enchantment"))));
            }
            /// <summary>
            /// Produces the name of a game mode from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.game_mode #=> "Survival"</code>
            /// </example>
            [FakerMethod("game_mode")]
            public string GameMode()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.game_mode"))));
            }
            /// <summary>
            /// Produces the name of an item from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.item #=> "Iron Shovel"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.items"))));
            }
            /// <summary>
            /// Produces the name of a mob from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.mob #=> "Sheep"</code>
            /// </example>
            [FakerMethod("mob")]
            public string Mob()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.mobs"))));
            }
            /// <summary>
            /// Produces the name of a status effect from Minecraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Minecraft.status_effect #=> "Weakness"</code>
            /// </example>
            [FakerMethod("status_effect")]
            public string StatusEffect()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.minecraft.status_effect"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Myst")]
        public partial class MystGenerator : GeneratorBase
        {
            internal MystGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an age from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Myst.age #=> "Relto"</code>
            /// </example>
            [FakerMethod("age")]
            public string Age()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.myst.ages"))));
            }
            /// <summary>
            /// Produces the name of a character from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Myst.character #=> "Gehn"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.myst.characters"))));
            }
            /// <summary>
            /// Produces the name of a creature from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Myst.creature #=> "squee"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.myst.creatures"))));
            }
            /// <summary>
            /// Produces the name of a game from the Myst series.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Myst.game #=> "Myst III: Exile"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.myst.games"))));
            }
            /// <summary>
            /// Produces a quote from Myst.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Myst.quote #=> "I realized, the moment I fell into the fissure, that the Book would not be destroyed as I had planned."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.myst.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Overwatch")]
        public partial class OverwatchGenerator : GeneratorBase
        {
            internal OverwatchGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a hero from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Overwatch.hero #=> "Tracer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.overwatch.heroes"))));
            }
            /// <summary>
            /// Produces the name of a location from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Overwatch.location #=> "Numbani"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.overwatch.locations"))));
            }
            /// <summary>
            /// Produces a quote from Overwatch.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Overwatch.quote #=> "It's high noon"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.overwatch.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Pokemon")]
        public partial class PokemonGenerator : GeneratorBase
        {
            internal PokemonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a location from Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Pokemon.location #=> "Pallet Town"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.pokemon.locations"))));
            }
            /// <summary>
            /// Produces a move from Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Pokemon.move #=> "Thunder Shock"</code>
            /// </example>
            [FakerMethod("move")]
            public string Move()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.pokemon.moves"))));
            }
            /// <summary>
            /// Produces the name of a Pokemon.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Pokemon.name #=> "Pikachu"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.pokemon.names"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.SonicTheHedgehog")]
        public partial class SonicTheHedgehogGenerator : GeneratorBase
        {
            internal SonicTheHedgehogGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Sonic the Hedgehog.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SonicTheHedgehog.character #=> "Sonic the Hedgehog"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.sonic_the_hedgehog.character"))));
            }
            /// <summary>
            /// Produces the name of a game from the Sonic the Hedgehog series.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SonicTheHedgehog.game #=> "Waku Waku Sonic Patrol Car"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.sonic_the_hedgehog.game"))));
            }
            /// <summary>
            /// Produces the name of a zone from Sonic the Hedgehog.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SonicTheHedgehog.zone #=> "Green Hill Zone"</code>
            /// </example>
            [FakerMethod("zone")]
            public string Zone()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.sonic_the_hedgehog.zone"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.StreetFighter")]
        public partial class StreetFighterGenerator : GeneratorBase
        {
            internal StreetFighterGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a playable character from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::StreetFighter.character #=> "Ryu"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.street_fighter.characters"))));
            }
            /// <summary>
            /// Produces the name of a move from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::StreetFighter.move #=> "Shoryuken"</code>
            /// </example>
            [FakerMethod("move")]
            public string Move()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.street_fighter.moves"))));
            }
            /// <summary>
            /// Produces a quote from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::StreetFighter.quote #=> "Go home and be a family man."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.street_fighter.quotes"))));
            }
            /// <summary>
            /// Produces the name of a stage from Street Fighter.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::StreetFighter.stage #=> "Volcanic Rim"</code>
            /// </example>
            [FakerMethod("stage")]
            public string Stage()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.street_fighter.stages"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.SuperMario")]
        public partial class SuperMarioGenerator : GeneratorBase
        {
            internal SuperMarioGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Super Mario character.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SuperMario.character #=> "Luigi"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.super_mario.characters"))));
            }
            /// <summary>
            /// Produces the name of a Super Mario game.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SuperMario.game #=> "Super Mario Odyssey"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.super_mario.games"))));
            }
            /// <summary>
            /// Produces the name of a Super Mario location.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SuperMario.location #=> "Kong City"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.super_mario.locations"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.SuperSmashBros")]
        public partial class SuperSmashBrosGenerator : GeneratorBase
        {
            internal SuperSmashBrosGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a fighter from the Smash Bros games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SuperSmashBros.fighter #=> "Mario"</code>
            /// </example>
            [FakerMethod("fighter")]
            public string Fighter()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.super_smash_bros.fighter"))));
            }
            /// <summary>
            /// Produces the name of a stage from the Smash Bros games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::SuperSmashBros.stage #=> "Final Destination"</code>
            /// </example>
            [FakerMethod("stage")]
            public string Stage()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.super_smash_bros.stage"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Tarkov")]
        public partial class TarkovGenerator : GeneratorBase
        {
            internal TarkovGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random boss from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.boss #=> "Tagilla"</code>
            /// </example>
            [FakerMethod("boss")]
            public string Boss()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.bosses"))));
            }
            /// <summary>
            /// Produces a random faction from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.faction #=> "USEC"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.factions"))));
            }
            /// <summary>
            /// Produces a random quest from Fence from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.fence_quest #=> "Compensation for Damage - Wager"</code>
            /// </example>
            [FakerMethod("fence_quest")]
            public string FenceQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.fence"))));
            }
            /// <summary>
            /// Produces a random item from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.item #=> "Diary"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.items"))));
            }
            /// <summary>
            /// Produces a random quest from Jaeger from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.jaeger_quest #=> "The Tarkov Shooter - Part 1"</code>
            /// </example>
            [FakerMethod("jaeger_quest")]
            public string JaegerQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.jaeger"))));
            }
            /// <summary>
            /// Produces a random location from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.location #=> "Customs"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.locations"))));
            }
            /// <summary>
            /// Produces a random quest from Mechanic from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.mechanic_quest #=> "Signal - Part 4"</code>
            /// </example>
            [FakerMethod("mechanic_quest")]
            public string MechanicQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.mechanic"))));
            }
            /// <summary>
            /// Produces a random quest from Peacekeeper from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.peacekeeper_quest #=> "Overpopulation"</code>
            /// </example>
            [FakerMethod("peacekeeper_quest")]
            public string PeacekeeperQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.peacekeeper"))));
            }
            /// <summary>
            /// Produces a random quest from Prapor from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.prapor_quest #=> "Easy Job - Part 2</code>
            /// </example>
            [FakerMethod("prapor_quest")]
            public string PraporQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.prapor"))));
            }
            /// <summary>
            /// Produces a random quest from a random trader from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.quest #=> "The Key to Success"</code>
            /// </example>
            [FakerMethod("quest")]
            public string Quest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.#{@traders.sample}"))));
            }
            /// <summary>
            /// Produces a random quest from Ragman from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.ragman_quest #=> "Hot Delivery"</code>
            /// </example>
            [FakerMethod("ragman_quest")]
            public string RagmanQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.ragman"))));
            }
            /// <summary>
            /// Produces a random quest from Skier from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.skier_quest #=> "Safe Corridor"</code>
            /// </example>
            [FakerMethod("skier_quest")]
            public string SkierQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.skier"))));
            }
            /// <summary>
            /// Produces a random quest from Therapist from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.therapist_quest #=> "Supply Plans"</code>
            /// </example>
            [FakerMethod("therapist_quest")]
            public string TherapistQuest()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.quests.therapist"))));
            }
            /// <summary>
            /// Produces a random trader from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.trader #=> "Prapor"</code>
            /// </example>
            [FakerMethod("trader")]
            public string Trader()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.traders"))));
            }
            /// <summary>
            /// Produces a random weapon from Escape from Tarkov.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Tarkov.weapon #=> "AK-74N"</code>
            /// </example>
            [FakerMethod("weapon")]
            public string Weapon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tarkov.weapons"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Touhou")]
        public partial class TouhouGenerator : GeneratorBase
        {
            internal TouhouGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Touhou.character #=> "Sanae Kochiya"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.touhou.characters"))));
            }
            /// <summary>
            /// Produces the name of a Touhou game.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Touhou.game #=> "Mountain of Faith"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.touhou.games"))));
            }
            /// <summary>
            /// Produces the name of a location from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Touhou.location #=> "Moriya Shrine"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.touhou.locations"))));
            }
            /// <summary>
            /// Produces the name of a song from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Touhou.song #=> "Faith Is for the Transient People"</code>
            /// </example>
            [FakerMethod("song")]
            public string Song()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.touhou.songs"))));
            }
            /// <summary>
            /// Produces the name of a spell card from the Touhou games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Touhou.spell_card #=> 'Esoterica "Gray Thaumaturgy"'</code>
            /// </example>
            [FakerMethod("spell_card")]
            public string SpellCard()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.touhou.spell_cards"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.WarhammerFantasy")]
        public partial class WarhammerFantasyGenerator : GeneratorBase
        {
            internal WarhammerFantasyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a creature from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WarhammerFantasy.creature #=> "Hydra"</code>
            /// </example>
            [FakerMethod("creature")]
            public string Creature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.warhammer_fantasy.creatures"))));
            }
            /// <summary>
            /// Produces a faction from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WarhammerFantasy.faction #=> "Bretonnia"</code>
            /// </example>
            [FakerMethod("faction")]
            public string Faction()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.warhammer_fantasy.factions"))));
            }
            /// <summary>
            /// Produces the name of a hero from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WarhammerFantasy.hero #=> "Sigmar Heldenhammer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.warhammer_fantasy.heros"))));
            }
            /// <summary>
            /// Produces a location from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WarhammerFantasy.location #=> "Lustria"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.warhammer_fantasy.locations"))));
            }
            /// <summary>
            /// Produces a quote from the Warhammer Fantasy setting.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WarhammerFantasy.quote #=> "The softest part of a castle is the belly of the man inside."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.warhammer_fantasy.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Witcher")]
        public partial class WitcherGenerator : GeneratorBase
        {
            internal WitcherGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a book from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.book #=> "Sword of Destiny"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.books"))));
            }
            /// <summary>
            /// Produces the name of a character from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.character #=> "Triss Merigold"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.characters"))));
            }
            /// <summary>
            /// Produces the name of a location from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.location #=> "Novigrad"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.locations"))));
            }
            /// <summary>
            /// Produces the name of a monster from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.monster #=> "Katakan"</code>
            /// </example>
            [FakerMethod("monster")]
            public string Monster()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.monsters"))));
            }
            /// <summary>
            /// Produces the name of a potion from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.potion #=> "Gadwall"</code>
            /// </example>
            [FakerMethod("potion")]
            public string Potion()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.potions"))));
            }
            /// <summary>
            /// Produces a quote from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.quote #=> "No Lollygagin'!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.quotes"))));
            }
            /// <summary>
            /// Produces the name of a school from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.school #=> "Wolf"</code>
            /// </example>
            [FakerMethod("school")]
            public string School()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.schools"))));
            }
            /// <summary>
            /// Produces the name of a sign from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.sign #=> "Igni"</code>
            /// </example>
            [FakerMethod("sign")]
            public string Sign()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.signs"))));
            }
            /// <summary>
            /// Produces the name of a witcher from The Witcher.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Witcher.witcher #=> "Geralt of Rivia"</code>
            /// </example>
            [FakerMethod("witcher")]
            public string Witcher()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.witcher.witchers"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.WorldOfWarcraft")]
        public partial class WorldOfWarcraftGenerator : GeneratorBase
        {
            internal WorldOfWarcraftGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a class name from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WorldOfWarcraft.class_name #=> "Druid"</code>
            /// </example>
            [FakerMethod("class_name")]
            public string ClassName()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.world_of_warcraft.class_names"))));
            }
            /// <summary>
            /// Produces the name of a hero from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WorldOfWarcraft.hero #=> "Uther the Lightbringer"</code>
            /// </example>
            [FakerMethod("hero")]
            public string Hero()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.world_of_warcraft.heros"))));
            }
            /// <summary>
            /// Produces a quote from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WorldOfWarcraft.quote #=> "These are dark times indeed."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.world_of_warcraft.quotes"))));
            }
            /// <summary>
            /// Produces the name of a race from World of Warcraft.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::WorldOfWarcraft.race #=> "Druid"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.world_of_warcraft.races"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Games.Zelda")]
        public partial class ZeldaGenerator : GeneratorBase
        {
            internal ZeldaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Zelda.character #=> "Link"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.zelda.characters"))));
            }
            /// <summary>
            /// Produces the name of a Legend of Zelda game.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Zelda.game #=> "Breath of the Wild"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.zelda.games"))));
            }
            /// <summary>
            /// Produces the name of an item from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Zelda.item #=> "Boomerang"</code>
            /// </example>
            [FakerMethod("item")]
            public string Item()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.zelda.items"))));
            }
            /// <summary>
            /// Produces the name of a character from the Legend of Zelda games.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::Zelda.location #=> "Hyrule Castle"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("games.zelda.locations"))));
            }
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game.genre"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game.platform"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game.title"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Internet")]
    public partial class InternetGenerator : GeneratorBase
    {
        [FakerProperty]
        public HTMLGenerator HTML { get; }
        [FakerProperty]
        public HTTPGenerator HTTP { get; }
        [FakerProperty]
        public JsonGenerator Json { get; }
        [FakerProperty]
        public MarkdownGenerator Markdown { get; }
        [FakerProperty]
        public TwitterGenerator Twitter { get; }
        internal InternetGenerator(Faker faker)
                 : base(faker)
        {
            HTML = new HTMLGenerator(this.Faker);
            HTTP = new HTTPGenerator(this.Faker);
            Json = new JsonGenerator(this.Faker);
            Markdown = new MarkdownGenerator(this.Faker);
            Twitter = new TwitterGenerator(this.Faker);
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
                return this.EvaluateExpression("<code>#{Lorem.sentence(word_count: 1)}</code>");
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
                return this.Translate(this.Numerify(this.Letterify(this.EvaluateExpression("<em>#{Faker::Lorem.paragraph(sentence_count: 1)}</em>"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.EvaluateExpression("<script src=\"#{Faker::Internet.url}.js\"></script>"))));
            }
            #warning No implementation defined for method table();
            #warning No implementation defined for method unordered_list();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Internet.HTTP")]
        public partial class HTTPGenerator : GeneratorBase
        {
            internal HTTPGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method status_code();
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
                return this.EvaluateExpression("```ruby\n#{Lorem.sentence(word_count: 1)}\n```");
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("markdown.emphasis"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.EvaluateExpression("`#{Faker::Lorem.sentence(word_count: 1)}`"))));
            }
            #warning No implementation defined for method ordered_list();
            #warning Failed processing method random : method has no name or return type.
            #warning No implementation defined for method sandwich(long sentences, long repeat = 1);
            #warning No implementation defined for method table();
            #warning No implementation defined for method unordered_list();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Twitter")]
        public partial class TwitterGenerator : GeneratorBase
        {
            internal TwitterGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning Failed processing method created_at : method has no name or return type.
            #warning Failed processing method id : method has no name or return type.
            #warning Failed processing method photo_entity : method has no name or return type.
            #warning No implementation defined for method screen_name();
            #warning No implementation defined for method status(bool includeUser, bool includePhoto = false);
            #warning Failed processing method status_entities : method has no name or return type.
            #warning No implementation defined for method user(bool includeStatus, bool includeEmail = false);
            #warning Failed processing method user_entities : method has no name or return type.
            #warning Failed processing method utc_offset : method has no name or return type.
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
        /// (default value "nil")
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
        /// (default value "nil")
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
        /// (default value "nil")
        /// </param>
        /// <param name="separators">
        /// A string containing allowable separators within the email address (i.e. '-_')
        /// (default value "'-_'")
        /// </param>
        /// <param name="domain">
        /// (default value "nil")
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
            return this.EvaluateExpression("#{random_integer '0..255'}.#{random_integer '0..255'}.#{random_integer '0..255'}.#{random_integer '0..255'}");
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
            return this.EvaluateExpression("#{ip_v4_address}/#{random_integer '1..31'}");
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
            return this.EvaluateExpression("#{ip_v6_address}/#{random_integer '1..127'}");
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
        /// (default value "nil")
        /// </param>
        /// <param name="glue">
        /// Separator to add between words passed, default used are ‘-’ or ‘_’
        /// (default value "nil")
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
        /// (default value "nil")
        /// </param>
        /// <param name="path">
        /// (default value "nil")
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
        #warning No implementation defined for method user();
        // Expecting native implementation
        /*
        /// <summary>
        /// Generates the random browser identifier.
        /// </summary>
        /// <param name="vendor">
        /// Name of vendor, supported vendors are aol, chrome, firefox, internet_explorer, netscape, opera, safari
        /// (default value "nil")
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
        /// <param name="lengthRange">
        /// When int value passed it returns the username longer than specifier. Max value can be 10^6
        /// (default value "5..10")
        /// </param>
        /// <param name="separators">
        /// (default value "'._'")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.username(specifier: 10)                     #=> "lulu.goodwin"
        /// Faker::Internet.username(specifier: 5..10)                  #=> "morris"
        /// Faker::Internet.username(specifier: 5..10)                  #=> "berryberry"
        /// Faker::Internet.username(specifier: 20, separators: ['_'])  #=> "nikki_sawaynnikki_saway"</code>
        /// </example>
        [FakerMethod("username")]
        public string Username(IntegerRange? lengthRange = null, string separators = "._")
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
    [FakerGenerator("IT")]
    public partial class ITGenerator : GeneratorBase
    {
        [FakerProperty]
        public AppGenerator App { get; }
        [FakerProperty]
        public ComputerGenerator Computer { get; }
        [FakerProperty]
        public DeviceGenerator Device { get; }
        [FakerProperty]
        public ElectricalComponentsGenerator ElectricalComponents { get; }
        [FakerProperty]
        public FileGenerator File { get; }
        [FakerProperty]
        public ProgrammingLanguageGenerator ProgrammingLanguage { get; }
        [FakerProperty]
        public SlackEmojiGenerator SlackEmoji { get; }
        [FakerProperty]
        public SourceGenerator Source { get; }
        [FakerProperty]
        public VulnerabilityIdentifierGenerator VulnerabilityIdentifier { get; }
        internal ITGenerator(Faker faker)
                 : base(faker)
        {
            App = new AppGenerator(this.Faker);
            Computer = new ComputerGenerator(this.Faker);
            Device = new DeviceGenerator(this.Faker);
            ElectricalComponents = new ElectricalComponentsGenerator(this.Faker);
            File = new FileGenerator(this.Faker);
            ProgrammingLanguage = new ProgrammingLanguageGenerator(this.Faker);
            SlackEmoji = new SlackEmojiGenerator(this.Faker);
            Source = new SourceGenerator(this.Faker);
            VulnerabilityIdentifier = new VulnerabilityIdentifierGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("App")]
        public partial class AppGenerator : GeneratorBase
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
                return this.Numerify(this.Letterify(this.ResolveYamlValue("app.author")));
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
                return this.Numerify(this.Letterify(this.ResolveYamlValue("app.name")));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("app.version"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Computer")]
        public partial class ComputerGenerator : GeneratorBase
        {
            internal ComputerGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a computer os.
            /// </summary>
            /// <param name="platform">
            /// optionally specify the platform ‘linux`, `macos`, or `windows`.
            /// (default value "'linux'")
            /// </param>
            /// <example>
            /// <code>Faker::Computer.os #=> "RHEL 6.10"</code>
            /// </example>
            [FakerMethod("os")]
            public string Os(string platform = "linux")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("computer.os.#{String.lower '" + platform + "'}"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("computer.platform"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("computer.os.#{String.lower '#{platform}'}"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("computer.type"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Device")]
        public partial class DeviceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("device.manufacturer"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("device.model_name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("device.platform"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("device.serial"))));
            }
            #warning No implementation defined for method version();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("ElectricalComponents")]
        public partial class ElectricalComponentsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("electrical_components.active"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("electrical_components.electromechanical"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("electrical_components.passive"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("File")]
        public partial class FileGenerator : GeneratorBase
        {
            internal FileGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a random directory name.
            /// </summary>
            /// <param name="segmentCount">
            /// Specifies the number of nested folders in the generated string.
            /// (default value "3")
            /// </param>
            /// <param name="root">
            /// Specifies the root of the generated string.
            /// (default value "nil")
            /// </param>
            /// <param name="directorySeparator">
            /// Specifies the separator between the segments.
            /// (default value "'/'")
            /// </param>
            /// <example>
            /// <code>Faker::File.dir #=> "et_error/sint_voluptas/quas_veritatis"
            /// Faker::File.dir(segment_count: 2) #=> "ea-suscipit/ut-deleniti"
            /// Faker::File.dir(segment_count: 3, root: nil, directory_separator: '/') #=> "est_porro/fugit_eveniet/incidunt-autem"
            /// Faker::File.dir(segment_count: 3, root: nil, directory_separator: '\\') #=> "aut-ullam\\quia_quisquam\\ut-eos"</code>
            /// </example>
            [FakerMethod("dir")]
            public string Dir(long segmentCount = 3, string? root = null, string directorySeparator = "/")
            {
                var parts = Enumerable.Range(0, (int)segmentCount).Select(i => this.Faker.Internet.Slug());
                if (string.IsNullOrWhiteSpace(root) == false)
                    parts.Prepend(root);
                return string.Join(directorySeparator, parts);
            }
            /// <summary>
            /// Produces a random file extension.
            /// </summary>
            /// <example>
            /// <code>Faker::File.extension #=> "mp3"</code>
            /// </example>
            [FakerMethod("extension")]
            public string Extension()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("file.extension"))));
            }
            #warning No implementation defined for method file_name(string? dir = null, string? name = null, string? ext = null, string directorySeparator = "/");
            /// <summary>
            /// Produces a random mime type.
            /// </summary>
            /// <param name="mediaType">
            /// The media type to get a mime type for. The default will return mime type from all the media types.
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::File.mime_type #=> "application/pdf"</code>
            /// </example>
            [FakerMethod("mime_type")]
            public string MimeType(MimeTypeMedia? mediaType = null)
            {
                if (mediaType.HasValue)
                    return this.Faker.FetchYamlValue($"file.mime_type.{UtilityMethods.GetEnumValue(mediaType)}");
                else
                    return Random.NextItem(((List<object>)Random.NextItem(this.Faker.FetchYamlMap("file.mime_type"))).OfType<string>().ToList());
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("ProgrammingLanguage")]
        public partial class ProgrammingLanguageGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("programming_language.creator"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("programming_language.name"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("SlackEmoji")]
        public partial class SlackEmojiGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.activity"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.celebration"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.custom"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.emoji"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.food_and_drink"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.nature"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.objects_and_symbols"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.people"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("slack_emoji.travel_and_places"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Source")]
        public partial class SourceGenerator : GeneratorBase
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
            /// <example>
            /// <code>Faker::Source.hello_world(lang: :javascript)
            /// #=> "alert('Hello World!');"</code>
            /// </example>
            [FakerMethod("hello_world")]
            public string HelloWorld(string lang = "ruby")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("source.hello_world." + lang + ""))));
            }
            /// <summary>
            /// Produces source code for printing a string in a given language.
            /// </summary>
            /// <param name="str">
            /// The string to print
            /// </param>
            /// <param name="lang">
            /// The programming language to use
            /// (default value "'ruby'")
            /// </param>
            /// <example>
            /// <code>Faker::Source.print #=> "puts 'faker_string_to_print'"</code>
            /// </example>
            /// <example>
            /// <code>Faker::Source.print(str: 'foo bar', lang: :javascript)
            /// #=> "console.log('foo bar');"</code>
            /// </example>
            [FakerMethod("print")]
            public string Print(string str, string lang = "ruby")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("source.print." + lang + ""))));
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
            /// <example>
            /// <code>Faker::Source.print_1_to_10(lang: :javascript)
            /// # => "for (let i=0; i<10; i++) {
            /// #       console.log(i);
            /// #    }"</code>
            /// </example>
            [FakerMethod("print_1_to_10")]
            public string Print1To10(string lang = "ruby")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("source.print_1_to_10." + lang + ""))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("VulnerabilityIdentifier")]
        public partial class VulnerabilityIdentifierGenerator : GeneratorBase
        {
            internal VulnerabilityIdentifierGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method cve(long year = ::Date.today.year);
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("JapaneseMedia")]
    public partial class JapaneseMediaGenerator : GeneratorBase
    {
        [FakerProperty]
        public ConanGenerator Conan { get; }
        [FakerProperty]
        public CowboyBebopGenerator CowboyBebop { get; }
        [FakerProperty]
        public DoraemonGenerator Doraemon { get; }
        [FakerProperty]
        public DragonBallGenerator DragonBall { get; }
        [FakerProperty]
        public FmaBrotherhoodGenerator FmaBrotherhood { get; }
        [FakerProperty]
        public KamenRiderGenerator KamenRider { get; }
        [FakerProperty]
        public NarutoGenerator Naruto { get; }
        [FakerProperty]
        public OnePieceGenerator OnePiece { get; }
        [FakerProperty]
        public StudioGhibliGenerator StudioGhibli { get; }
        [FakerProperty]
        public SwordArtOnlineGenerator SwordArtOnline { get; }
        internal JapaneseMediaGenerator(Faker faker)
                 : base(faker)
        {
            Conan = new ConanGenerator(this.Faker);
            CowboyBebop = new CowboyBebopGenerator(this.Faker);
            Doraemon = new DoraemonGenerator(this.Faker);
            DragonBall = new DragonBallGenerator(this.Faker);
            FmaBrotherhood = new FmaBrotherhoodGenerator(this.Faker);
            KamenRider = new KamenRiderGenerator(this.Faker);
            Naruto = new NarutoGenerator(this.Faker);
            OnePiece = new OnePieceGenerator(this.Faker);
            StudioGhibli = new StudioGhibliGenerator(this.Faker);
            SwordArtOnline = new SwordArtOnlineGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.Conan")]
        public partial class ConanGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("conan.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("conan.gadgets"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("conan.vehicles"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.CowboyBebop")]
        public partial class CowboyBebopGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cowboy_bebop.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cowboy_bebop.episode"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cowboy_bebop.quote"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cowboy_bebop.song"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.Doraemon")]
        public partial class DoraemonGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("doraemon.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("doraemon.gadgets"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("doraemon.locations"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.DragonBall")]
        public partial class DragonBallGenerator : GeneratorBase
        {
            internal DragonBallGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DragonBall.character #=> "Goku"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dragon_ball.characters"))));
            }
            /// <summary>
            /// Produces the name of a planet from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DragonBall.planet #=> "Namek"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dragon_ball.planets"))));
            }
            /// <summary>
            /// Produces the name of a race from Dragon Ball.
            /// </summary>
            /// <example>
            /// <code>Faker::Game::DragonBall.race #=> "Saiyan"</code>
            /// </example>
            [FakerMethod("race")]
            public string Race()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dragon_ball.races"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.FmaBrotherhood")]
        public partial class FmaBrotherhoodGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("fma_brotherhood.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("fma_brotherhood.cities"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("fma_brotherhood.countries"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.KamenRider")]
        public partial class KamenRiderGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kamen_rider.#{era}.#{field}"))));
            }
            #warning No implementation defined for method kamen_rider();
            #warning No implementation defined for method series();
            #warning No implementation defined for method transformation_device();
            #warning No implementation defined for method user();
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.Naruto")]
        public partial class NarutoGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("naruto.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("naruto.demons"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("naruto.eyes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("naruto.villages"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.OnePiece")]
        public partial class OnePieceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.akuma_no_mi"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.islands"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("one_piece.seas"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.StudioGhibli")]
        public partial class StudioGhibliGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("studio_ghibli.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("studio_ghibli.movies"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("studio_ghibli.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("JapaneseMedia.SwordArtOnline")]
        public partial class SwordArtOnlineGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sword_art_online.game_name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sword_art_online.item"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sword_art_online.location"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sword_art_online.real_name"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Location")]
    public partial class LocationGenerator : GeneratorBase
    {
        [FakerProperty]
        public CompassGenerator Compass { get; }
        internal LocationGenerator(Faker faker)
                 : base(faker)
        {
            Compass = new CompassGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Compass")]
        public partial class CompassGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.abbreviation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.azimuth"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.cardinal.word"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.cardinal.abbreviation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.cardinal.azimuth"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.direction"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.half-wind.word"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.half-wind.abbreviation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.half-wind.azimuth"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.ordinal.word"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.ordinal.abbreviation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.ordinal.azimuth"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.quarter-wind.word"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.quarter-wind.abbreviation"))));
            }
            /// <summary>
            /// Produces a random quarter wind azimuth.
            /// </summary>
            /// <example>
            /// <code>Faker::Compass.quarter_wind_azimuth #=> "56.25"</code>
            /// </example>
            [FakerMethod("quarter_wind_azimuth")]
            public string QuarterWindAzimuth()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("compass.quarter-wind.azimuth"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("LoremFlickr")]
    public partial class LoremFlickrGenerator : GeneratorBase
    {
        internal LoremFlickrGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method build_url : method has no name or return type.
        #warning No implementation defined for method colorized_image(string size, string color, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method grayscale_image(string size, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method image(string size, List<string> searchTerms, bool matchAll = false);
        #warning No implementation defined for method pixelated_image(string size, List<string> searchTerms, bool matchAll = false);
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Medicine")]
    public partial class MedicineGenerator : GeneratorBase
    {
        [FakerProperty]
        public CannabisGenerator Cannabis { get; }
        [FakerProperty]
        public NationalHealthServiceGenerator NationalHealthService { get; }
        internal MedicineGenerator(Faker faker)
                 : base(faker)
        {
            Cannabis = new CannabisGenerator(this.Faker);
            NationalHealthService = new NationalHealthServiceGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Cannabis")]
        public partial class CannabisGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.brands"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.buzzwords"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.cannabinoids"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.cannabinoid_abbreviations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.categories"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.health_benefits"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.medical_uses"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.strains"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.terpenes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("cannabis.types"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("NationalHealthService")]
        public partial class NationalHealthServiceGenerator : GeneratorBase
        {
            internal NationalHealthServiceGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method british_number();
            #warning No implementation defined for method check_digit(long number = 0);
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Movie")]
    public partial class MovieGenerator : GeneratorBase
    {
        [FakerProperty]
        public AvatarGenerator Avatar { get; }
        [FakerProperty]
        public BackToTheFutureGenerator BackToTheFuture { get; }
        [FakerProperty]
        public BossaNovaGenerator BossaNova { get; }
        [FakerProperty]
        public DepartedGenerator Departed { get; }
        [FakerProperty]
        public GhostbustersGenerator Ghostbusters { get; }
        [FakerProperty]
        public HackersGenerator Hackers { get; }
        [FakerProperty]
        public HarryPotterGenerator HarryPotter { get; }
        [FakerProperty]
        public HitchhikersGuideToTheGalaxyGenerator HitchhikersGuideToTheGalaxy { get; }
        [FakerProperty]
        public HobbitGenerator Hobbit { get; }
        [FakerProperty]
        public HowToTrainYourDragonGenerator HowToTrainYourDragon { get; }
        [FakerProperty]
        public LebowskiGenerator Lebowski { get; }
        [FakerProperty]
        public LordOfTheRingsGenerator LordOfTheRings { get; }
        [FakerProperty]
        public PrincessBrideGenerator PrincessBride { get; }
        [FakerProperty]
        public ShowGenerator Show { get; }
        [FakerProperty]
        public StarWarsGenerator StarWars { get; }
        [FakerProperty]
        public TheRoomGenerator TheRoom { get; }
        [FakerProperty]
        public TronGenerator Tron { get; }
        [FakerProperty]
        public VForVendettaGenerator VForVendetta { get; }
        internal MovieGenerator(Faker faker)
                 : base(faker)
        {
            Avatar = new AvatarGenerator(this.Faker);
            BackToTheFuture = new BackToTheFutureGenerator(this.Faker);
            BossaNova = new BossaNovaGenerator(this.Faker);
            Departed = new DepartedGenerator(this.Faker);
            Ghostbusters = new GhostbustersGenerator(this.Faker);
            Hackers = new HackersGenerator(this.Faker);
            HarryPotter = new HarryPotterGenerator(this.Faker);
            HitchhikersGuideToTheGalaxy = new HitchhikersGuideToTheGalaxyGenerator(this.Faker);
            Hobbit = new HobbitGenerator(this.Faker);
            HowToTrainYourDragon = new HowToTrainYourDragonGenerator(this.Faker);
            Lebowski = new LebowskiGenerator(this.Faker);
            LordOfTheRings = new LordOfTheRingsGenerator(this.Faker);
            PrincessBride = new PrincessBrideGenerator(this.Faker);
            Show = new ShowGenerator(this.Faker);
            StarWars = new StarWarsGenerator(this.Faker);
            TheRoom = new TheRoomGenerator(this.Faker);
            Tron = new TronGenerator(this.Faker);
            VForVendetta = new VForVendettaGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Avatar")]
        public partial class AvatarGenerator : GeneratorBase
        {
            internal AvatarGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Avatar.character #=> "Jake Sully"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("avatar.characters"))));
            }
            /// <summary>
            /// Produces a date from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Avatar.date #=> "December 15, 2022"</code>
            /// </example>
            [FakerMethod("date")]
            public string Date()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("avatar.dates"))));
            }
            /// <summary>
            /// Produces a quote from Avatar.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Avatar.quote
            /// #=> "If it ain't raining, we ain't training."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("avatar.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.BackToTheFuture")]
        public partial class BackToTheFutureGenerator : GeneratorBase
        {
            internal BackToTheFutureGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::BackToTheFuture.character #=> "Marty McFly"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("back_to_the_future.characters"))));
            }
            /// <summary>
            /// Produces a date from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::BackToTheFuture.date #=> "November 5, 1955"</code>
            /// </example>
            [FakerMethod("date")]
            public string Date()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("back_to_the_future.dates"))));
            }
            /// <summary>
            /// Produces a quote from Back to the Future.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::BackToTheFuture.quote
            /// #=> "Roads? Where we're going, we don't need roads."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("back_to_the_future.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("BossaNova")]
        public partial class BossaNovaGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bossa_nova.artists"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bossa_nova.songs"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Departed")]
        public partial class DepartedGenerator : GeneratorBase
        {
            internal DepartedGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Departed.actor #=> "Matt Damon"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("departed.actors"))));
            }
            /// <summary>
            /// Produces a character from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Departed.character #=> "Frank Costello"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("departed.characters"))));
            }
            /// <summary>
            /// Produces a quote from The Departed.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Departed.quote
            /// #=> "I'm the guy who does his job. You must be the other guy"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("departed.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Ghostbusters")]
        public partial class GhostbustersGenerator : GeneratorBase
        {
            internal GhostbustersGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Ghostbusters.actor #=> "Bill Murray"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ghostbusters.actors"))));
            }
            /// <summary>
            /// Produces a character from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Ghostbusters.character #=> "Dr. Egon Spengler"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ghostbusters.characters"))));
            }
            /// <summary>
            /// Produces a quote from Ghostbusters.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Ghostbusters.quote
            /// #=> "I tried to think of the most harmless thing. Something I loved from my childhood. Something that could never ever possibly destroy us. Mr. Stay Puft!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ghostbusters.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Hackers")]
        public partial class HackersGenerator : GeneratorBase
        {
            internal HackersGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a real character name from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hackers.character #=> "Dade Murphy"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hackers.characters"))));
            }
            /// <summary>
            /// Produces a character hacker "handle" from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hackers.handle #=> "Zero Cool"</code>
            /// </example>
            [FakerMethod("handle")]
            public string Handle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hackers.handles"))));
            }
            /// <summary>
            /// Produces a quote from Hackers.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hackers.quote #=> "Hack the Planet!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hackers.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.HarryPotter")]
        public partial class HarryPotterGenerator : GeneratorBase
        {
            internal HarryPotterGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a book from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.book #=> "Harry Potter and the Chamber of Secrets"</code>
            /// </example>
            [FakerMethod("book")]
            public string Book()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.books"))));
            }
            /// <summary>
            /// Produces a character from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.character #=> "Harry Potter"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.characters"))));
            }
            /// <summary>
            /// Produces a house from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.house #=> "Gryffindor"</code>
            /// </example>
            [FakerMethod("house")]
            public string House()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.houses"))));
            }
            /// <summary>
            /// Produces a location from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.location #=> "Hogwarts"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.locations"))));
            }
            /// <summary>
            /// Produces a quote from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.quote #=> "I solemnly swear that I am up to good."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.quotes"))));
            }
            /// <summary>
            /// Produces a spell from Harry Potter.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HarryPotter.spell #=> "Reparo"</code>
            /// </example>
            [FakerMethod("spell")]
            public string Spell()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("harry_potter.spells"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.HitchhikersGuideToTheGalaxy")]
        public partial class HitchhikersGuideToTheGalaxyGenerator : GeneratorBase
        {
            internal HitchhikersGuideToTheGalaxyGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.character #=> "Marvin"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.characters"))));
            }
            /// <summary>
            /// Produces a location from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.location
            /// #=> "Arthur Dent's house"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.locations"))));
            }
            /// <summary>
            /// Produces a Marvin quote from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.marvin_quote
            /// #=> "Life? Don't talk to me about life."</code>
            /// </example>
            [FakerMethod("marvin_quote")]
            public string MarvinQuote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.marvin_quote"))));
            }
            /// <summary>
            /// Produces a planet from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.planet
            /// #=> "Magrathea"</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.planets"))));
            }
            /// <summary>
            /// Produces a quote from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.quote
            /// #=> "In the beginning, the Universe was created. This has made a lot of people very angry and been widely regarded as a bad move."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.quotes"))));
            }
            /// <summary>
            /// Produces a species from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.specie
            /// #=> "Perfectly Normal Beast"</code>
            /// </example>
            [FakerMethod("specie")]
            public string Specie()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.species"))));
            }
            /// <summary>
            /// Produces a starship from The Hitchhiker's Guide to the Galaxy.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HitchhikersGuideToTheGalaxy.starship
            /// #=> "Vogon Constructor Fleet"</code>
            /// </example>
            [FakerMethod("starship")]
            public string Starship()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hitchhikers_guide_to_the_galaxy.starships"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Hobbit")]
        public partial class HobbitGenerator : GeneratorBase
        {
            internal HobbitGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a character from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hobbit.character #=> "Gandalf the Grey"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.hobbit.character"))));
            }
            /// <summary>
            /// Produces the name of a location from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hobbit.location #=> "The Shire"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.hobbit.location"))));
            }
            /// <summary>
            /// Produces a quote from The Hobbit.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hobbit.quote
            /// #=> "Never laugh at live dragons, Bilbo you fool!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.hobbit.quote"))));
            }
            /// <summary>
            /// Produces the name of one of the 13 dwarves from the Company, or Gandalf or Bilbo.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Hobbit.thorins_company #=> "Thorin Oakenshield"</code>
            /// </example>
            [FakerMethod("thorins_company")]
            public string ThorinsCompany()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.hobbit.thorins_company"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.HowToTrainYourDragon")]
        public partial class HowToTrainYourDragonGenerator : GeneratorBase
        {
            internal HowToTrainYourDragonGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HowToTrainYourDragon.character #=> "Hiccup"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_to_train_your_dragon.characters"))));
            }
            /// <summary>
            /// Produces a dragon from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HowToTrainYourDragon.dragons #=> "Toothless"</code>
            /// </example>
            [FakerMethod("dragon")]
            public string Dragon()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_to_train_your_dragon.dragons"))));
            }
            /// <summary>
            /// Produces a location from How To Train Your Dragon.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::HowToTrainYourDragon.location #=> "Berk"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_to_train_your_dragon.locations"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Lebowski")]
        public partial class LebowskiGenerator : GeneratorBase
        {
            internal LebowskiGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Lebowski.actor #=> "John Goodman"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lebowski.actors"))));
            }
            /// <summary>
            /// Produces a character from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Lebowski.character #=> "Jackie Treehorn"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lebowski.characters"))));
            }
            /// <summary>
            /// Produces a quote from The Big Lebowski.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Lebowski.quote #=> "Forget it, Donny, you're out of your element!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("lebowski.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.LordOfTheRings")]
        public partial class LordOfTheRingsGenerator : GeneratorBase
        {
            internal LordOfTheRingsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::LordOfTheRings.character #=> "Legolas"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.lord_of_the_rings.characters"))));
            }
            /// <summary>
            /// Produces a location from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::LordOfTheRings.location #=> "Helm's Deep"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.lord_of_the_rings.locations"))));
            }
            /// <summary>
            /// Produces a quote from Lord of the Rings.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::LordOfTheRings.quote
            /// #=> "I wish the Ring had never come to me. I wish none of this had happened."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("tolkien.lord_of_the_rings.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.PrincessBride")]
        public partial class PrincessBrideGenerator : GeneratorBase
        {
            internal PrincessBrideGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from The Princess Bride.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::PrincessBride.character #=> "Dread Pirate Roberts"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("princess_bride.characters"))));
            }
            /// <summary>
            /// Produces a quote from The Princess Bride.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::PrincessBride.quote
            /// #=> "Hello. My name is Inigo Montoya. You killed my father. Prepare to die!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("princess_bride.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Show")]
        public partial class ShowGenerator : GeneratorBase
        {
            internal ShowGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a musical for an older audience.
            /// </summary>
            /// <example>
            /// <code>Faker::Alphanumeric.alpha
            /// #=> "West Side Story"</code>
            /// </example>
            [FakerMethod("adult_musical")]
            public string AdultMusical()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("show.adult_musical"))));
            }
            /// <summary>
            /// Produces the name of a musical for a younger audience.
            /// </summary>
            /// <example>
            /// <code>Faker::Alphanumeric.alpha
            /// #=> "Into the Woods JR."</code>
            /// </example>
            [FakerMethod("kids_musical")]
            public string KidsMusical()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("show.kids_musical"))));
            }
            /// <summary>
            /// Produces the name of a play.
            /// </summary>
            /// <example>
            /// <code>Faker::Alphanumeric.alpha
            /// #=> "Death of a Salesman"</code>
            /// </example>
            [FakerMethod("play")]
            public string Play()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("show.play"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.StarWars")]
        public partial class StarWarsGenerator : GeneratorBase
        {
            internal StarWarsGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a call number from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.call_numbers  #=> ["Leader", "#"]</code>
            /// </example>
            [FakerMethod("call_number")]
            public string CallNumber()
            {
                return this.ResolveYamlValue("star_wars.call_numbers");
            }
            /// <summary>
            /// Produces a call sign from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.call_sign #=> "Grey 5"</code>
            /// </example>
            [FakerMethod("call_sign")]
            public string CallSign()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("star_wars.call_sign"))));
            }
            /// <summary>
            /// Produces a call squadron from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.call_squadrons  #=> ["Rogue", "Red", "Gray", "Green", "Blue", "Gold", "Black", "Yellow", "Phoenix"]</code>
            /// </example>
            [FakerMethod("call_squadron")]
            public string CallSquadron()
            {
                return this.ResolveYamlValue("star_wars.call_squadrons");
            }
            /// <summary>
            /// Produces a character from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.characters</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.ResolveYamlValue("star_wars.characters");
            }
            /// <summary>
            /// Produces a droid from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.droids</code>
            /// </example>
            [FakerMethod("droid")]
            public string Droid()
            {
                return this.ResolveYamlValue("star_wars.droids");
            }
            /// <summary>
            /// Produces a planet from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.planets</code>
            /// </example>
            [FakerMethod("planet")]
            public string Planet()
            {
                return this.ResolveYamlValue("star_wars.planets");
            }
            #warning No implementation defined for method quote(string? character = null);
            /// <summary>
            /// Produces a species from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.species</code>
            /// </example>
            [FakerMethod("specie")]
            public string Specie()
            {
                return this.ResolveYamlValue("star_wars.species");
            }
            /// <summary>
            /// Produces a vehicle from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.vehicles</code>
            /// </example>
            [FakerMethod("vehicle")]
            public string Vehicle()
            {
                return this.ResolveYamlValue("star_wars.vehicles");
            }
            /// <summary>
            /// Produces a wookiee sentence from Star Wars.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.wookiee_sentence #=> "Yrroonn ru ooma roo ahuma ur roooarrgh hnn-rowr."</code>
            /// </example>
            [FakerMethod("wookiee_sentence")]
            public string WookieeSentence()
            {
                return String.Join(" ", Enumerable.Range(0, Random.NextInt32(0, 10)).Select(i => WookieeWord())) + Random.NextItem(['.', '?', '!']);
            }
            /// <summary>
            /// Gets a random wookiee word
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::StarWars.wookiee_words</code>
            /// </example>
            [FakerMethod("wookiee_word")]
            public string WookieeWord()
            {
                return this.ResolveYamlValue("star_wars.wookiee_words");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.TheRoom")]
        public partial class TheRoomGenerator : GeneratorBase
        {
            internal TheRoomGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an actor from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Room.actor #=> "Tommy Wiseau"</code>
            /// </example>
            [FakerMethod("actor")]
            public string Actor()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_room.actors"))));
            }
            /// <summary>
            /// Produces a character from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Room.character #=> "Johnny"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_room.characters"))));
            }
            /// <summary>
            /// Produces a location from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Room.location #=> "Johnny's Apartment"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_room.locations"))));
            }
            /// <summary>
            /// Produces a quote from The Room (2003).
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Room.quote
            /// #=> "You're lying, I never hit you. You are tearing me apart, Lisa!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_room.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.Tron")]
        public partial class TronGenerator : GeneratorBase
        {
            internal TronGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.character #=> "Bit"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.ResolveYamlValue("tron.characters");
            }
            /// <summary>
            /// Produces a game from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.game #=> "Space Paranoids"</code>
            /// </example>
            [FakerMethod("game")]
            public string Game()
            {
                return this.ResolveYamlValue("tron.games");
            }
            /// <summary>
            /// Produces a location from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.location #=> "Flynn's Arcade"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.ResolveYamlValue("tron.locations");
            }
            /// <summary>
            /// Produces a program from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.program #=> "Clu"</code>
            /// </example>
            [FakerMethod("program")]
            public string Program()
            {
                return this.ResolveYamlValue("tron.characters.programs");
            }
            #warning No implementation defined for method quote(string? character = null);
            /// <summary>
            /// Produces a tagline from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.tagline #=> "The Electronic Gladiator"</code>
            /// </example>
            [FakerMethod("tagline")]
            public string Tagline()
            {
                return this.ResolveYamlValue("tron.taglines");
            }
            /// <summary>
            /// Produces a user from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.user #=> "Light Cycle"</code>
            /// </example>
            [FakerMethod("user")]
            public string User()
            {
                return this.ResolveYamlValue("tron.characters.users");
            }
            /// <summary>
            /// Produces a vehicle from Tron.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::Tron.vehicle #=> "Light Cycle"</code>
            /// </example>
            [FakerMethod("vehicle")]
            public string Vehicle()
            {
                return this.ResolveYamlValue("tron.vehicles");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Movies.VForVendetta")]
        public partial class VForVendettaGenerator : GeneratorBase
        {
            internal VForVendettaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::VForVendetta.character #=> "V"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("v_for_vendetta.characters"))));
            }
            /// <summary>
            /// Produces a quote from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::VForVendetta.quote
            /// #=> "People should not be afraid of their governments. Governments should be afraid of their people."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("v_for_vendetta.quotes"))));
            }
            /// <summary>
            /// Produces a speech from V For Vendetta.
            /// </summary>
            /// <example>
            /// <code>Faker::Movie::VForVendetta.speech
            /// #=> "Remember, remember, the Fifth of November, the Gunpowder Treason and Plot. I know of no reason why the Gunpowder Treason should ever be forgot..."</code>
            /// </example>
            [FakerMethod("speech")]
            public string Speech()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("v_for_vendetta.speeches"))));
            }
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("movie.quote"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("movie.title"))));
        }
    }
    
    /// <summary>
    /// A generator of titles of operas by various composers.
    /// <p>A generator of titles of operas by various composers</p>
    /// 
    /// </summary>
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Music")]
    public partial class MusicGenerator : GeneratorBase
    {
        [FakerProperty]
        public GratefulDeadGenerator GratefulDead { get; }
        [FakerProperty]
        public HiphopGenerator Hiphop { get; }
        [FakerProperty]
        public KpopGenerator Kpop { get; }
        [FakerProperty]
        public OperaGenerator Opera { get; }
        [FakerProperty]
        public PearlJamGenerator PearlJam { get; }
        [FakerProperty]
        public PhishGenerator Phish { get; }
        [FakerProperty]
        public PrinceGenerator Prince { get; }
        [FakerProperty]
        public RockBandGenerator RockBand { get; }
        [FakerProperty]
        public RushGenerator Rush { get; }
        [FakerProperty]
        public SmashingPumpkinsGenerator SmashingPumpkins { get; }
        [FakerProperty]
        public UmphreysMcgeeGenerator UmphreysMcgee { get; }
        internal MusicGenerator(Faker faker)
                 : base(faker)
        {
            GratefulDead = new GratefulDeadGenerator(this.Faker);
            Hiphop = new HiphopGenerator(this.Faker);
            Kpop = new KpopGenerator(this.Faker);
            Opera = new OperaGenerator(this.Faker);
            PearlJam = new PearlJamGenerator(this.Faker);
            Phish = new PhishGenerator(this.Faker);
            Prince = new PrinceGenerator(this.Faker);
            RockBand = new RockBandGenerator(this.Faker);
            Rush = new RushGenerator(this.Faker);
            SmashingPumpkins = new SmashingPumpkinsGenerator(this.Faker);
            UmphreysMcgee = new UmphreysMcgeeGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.GratefulDead")]
        public partial class GratefulDeadGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("grateful_dead.players"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("grateful_dead.songs"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.Hiphop")]
        public partial class HiphopGenerator : GeneratorBase
        {
            internal HiphopGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Hip Hop Artist.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.artist #=> "Lil Wayne"</code>
            /// </example>
            [FakerMethod("artist")]
            public string Artist()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.hiphop.artist"))));
            }
            /// <summary>
            /// Produces the name of a Hip Hop Group.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.groups #=> "OVO"</code>
            /// </example>
            [FakerMethod("groups")]
            public string Groups()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.hiphop.groups"))));
            }
            /// <summary>
            /// Produces the name of a Hip Hop Subgenre.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Hiphop.subgeneres #=> "Alternative"</code>
            /// </example>
            [FakerMethod("subgenres")]
            public string Subgenres()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.hiphop.subgenres"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Kpop")]
        public partial class KpopGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.boy_bands"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.girl_groups"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.i_groups"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.ii_groups"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.iii_groups"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("kpop.solo"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.Opera")]
        public partial class OperaGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_ludwig_van_beethoven"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_vincenzo_bellini"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_alban_berg"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_hector_berlioz"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_georges_bizet"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_gaetano_donizetti"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_christoph_willibald_gluck"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_christoph_willibald_gluck"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_christoph_willibald_gluck"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_charles_gounod"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_wolfgang_amadeus_mozart"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_wolfgang_amadeus_mozart"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_wolfgang_amadeus_mozart"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_maurice_ravel"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_gioacchino_rossini"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.french.by_camille_saint_saens"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_franz_schubert"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_robert_schumann"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_richard_strauss"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.italian.by_giuseppe_verdi"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_richard_wagner"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("opera.german.by_carl_maria_von_weber"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.PearlJam")]
        public partial class PearlJamGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("pearl_jam.albums"))));
            }
            /// <summary>
            /// Produces the name of a member of Pearl Jam (current and former).
            /// </summary>
            /// <example>
            /// <code>Faker::Music::PearlJam.musician #=> "Eddie Vedder"</code>
            /// </example>
            [FakerMethod("musician")]
            public string Musician()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("pearl_jam.musicians"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("pearl_jam.songs"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.Phish")]
        public partial class PhishGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phish.albums"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phish.musicians"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("phish.songs"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.Prince")]
        public partial class PrinceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("prince.album"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("prince.band"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("prince.lyric"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("prince.song"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.RockBand")]
        public partial class RockBandGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rock_band.name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rock_band.song"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.Rush")]
        public partial class RushGenerator : GeneratorBase
        {
            internal RushGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of an album by Rush.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Rush.album #=> "Hold Your Fire"</code>
            /// </example>
            [FakerMethod("album")]
            public string Album()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rush.albums"))));
            }
            /// <summary>
            /// Produces the name of a member of Rush.
            /// </summary>
            /// <example>
            /// <code>Faker::Music::Rush.player #=> "Geddy Lee"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rush.players"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.SmashingPumpkins")]
        public partial class SmashingPumpkinsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("smashing_pumpkins.albums"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("smashing_pumpkins.lyric"))));
            }
            /// <summary>
            /// Produces the name of a member of the Smashing Pumpkins (current and former).
            /// </summary>
            /// <example>
            /// <code>Faker::Music::SmashingPumpkins.musician #=> "Billy Corgan"</code>
            /// </example>
            [FakerMethod("musician")]
            public string Musician()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("smashing_pumpkins.musicians"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("smashing_pumpkins.songs"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Music.UmphreysMcgee")]
        public partial class UmphreysMcgeeGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("umphreys_mcgee.song"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.albums"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.bands"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.genres"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.instruments"))));
        }
        #warning No implementation defined for method key();
        #warning No implementation defined for method key_types();
        #warning No implementation defined for method key_variants();
        #warning No implementation defined for method keys();
        /// <summary>
        /// Produces a name from Lou Bega's Mambo #5.
        ///                             <p>Produces a name from Lou Bega’s Mambo #5</p>
        /// </summary>
        /// <example>
        /// <code>Faker::Music.mambo #=> "Monica"</code>
        /// </example>
        [FakerMethod("mambo_no_5")]
        public string MamboNo5()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("music.mambo_no_5"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Omniauth")]
    public partial class OmniauthGenerator : GeneratorBase
    {
        internal OmniauthGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning No implementation defined for method apple(string name, string email, string? uid = null);
        #warning No implementation defined for method auth0(string name, string email, string? uid = null);
        #warning Failed processing method city_state : method has no name or return type.
        #warning Failed processing method email : method has no name or return type.
        #warning No implementation defined for method facebook(string name, string email, string username, string uid);
        #warning Failed processing method first_name : method has no name or return type.
        #warning Failed processing method gender : method has no name or return type.
        #warning No implementation defined for method github(string name, string email, string uid);
        #warning No implementation defined for method google(string name, string email, string uid);
        #warning Failed processing method image : method has no name or return type.
        #warning No implementation defined for method initialize();
        #warning Failed processing method last_name : method has no name or return type.
        #warning No implementation defined for method linkedin(string name, string email, string uid);
        #warning Failed processing method name : method has no name or return type.
        #warning Failed processing method random_boolean : method has no name or return type.
        #warning Failed processing method random_number_from_range : method has no name or return type.
        #warning Failed processing method timezone : method has no name or return type.
        #warning No implementation defined for method twitter(string name, string nickname, string uid);
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("People")]
    public partial class PeopleGenerator : GeneratorBase
    {
        [FakerProperty]
        public AncientGenerator Ancient { get; }
        [FakerProperty]
        public ArtistGenerator Artist { get; }
        [FakerProperty]
        public FunnyNameGenerator FunnyName { get; }
        [FakerProperty]
        public GreekPhilosophersGenerator GreekPhilosophers { get; }
        [FakerProperty]
        public SuperheroGenerator Superhero { get; }
        internal PeopleGenerator(Faker faker)
                 : base(faker)
        {
            Ancient = new AncientGenerator(this.Faker);
            Artist = new ArtistGenerator(this.Faker);
            FunnyName = new FunnyNameGenerator(this.Faker);
            GreekPhilosophers = new GreekPhilosophersGenerator(this.Faker);
            Superhero = new SuperheroGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Ancient")]
        public partial class AncientGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ancient.god"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ancient.hero"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ancient.primordial"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("ancient.titan"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Artist")]
        public partial class ArtistGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("artist.names"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("FunnyName")]
        public partial class FunnyNameGenerator : GeneratorBase
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
                return this.ResolveYamlValue("funny_name.name");
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("funny_name.name"))));
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
                return this.ResolveYamlValue("funny_name.name");
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
                return this.ResolveYamlValue("funny_name.name");
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
                return this.ResolveYamlValue("funny_name.name");
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("GreekPhilosophers")]
        public partial class GreekPhilosophersGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("greek_philosophers.names"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("greek_philosophers.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Superhero")]
        public partial class SuperheroGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("superhero.descriptor"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("superhero.name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("superhero.power"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("superhero.prefix"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("superhero.suffix"))));
            }
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
                return double.Parse(this.EvaluateExpression("#{random_float '-180..180'}"));
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
                return double.Parse(this.EvaluateExpression("#{random_float '-180..180'}"));
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
                return this.ResolveYamlValue("address.secondary_address");
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
                return this.ResolveYamlValue("address.state");
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
            /// (default value "nil")
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
            /// (default value "AvatarType.Person")
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
            public string Image(string? name = null, string size = "48x48", string format = "jpg", AvatarType type = AvatarType.Person, bool background = false)
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("driving_licence.usa.#{state.to_s.strip.downcase.gsub(' ', '_')}"))));
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
                return this.EvaluateExpression("#{country_code} #{cell_phone}");
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
                return this.EvaluateExpression("#{country_code} #{phone_number}");
            }
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
    [FakerGenerator("Place")]
    public partial class PlaceGenerator : GeneratorBase
    {
        [FakerProperty]
        public AustraliaGenerator Australia { get; }
        [FakerProperty]
        public DessertGenerator Dessert { get; }
        [FakerProperty]
        public MountainGenerator Mountain { get; }
        [FakerProperty]
        public NationGenerator Nation { get; }
        [FakerProperty]
        public SouthAfricaGenerator SouthAfrica { get; }
        [FakerProperty]
        public SpaceGenerator Space { get; }
        [FakerProperty]
        public UniversityGenerator University { get; }
        internal PlaceGenerator(Faker faker)
                 : base(faker)
        {
            Australia = new AustraliaGenerator(this.Faker);
            Dessert = new DessertGenerator(this.Faker);
            Mountain = new MountainGenerator(this.Faker);
            Nation = new NationGenerator(this.Faker);
            SouthAfrica = new SouthAfricaGenerator(this.Faker);
            Space = new SpaceGenerator(this.Faker);
            University = new UniversityGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Australia")]
        public partial class AustraliaGenerator : GeneratorBase
        {
            internal AustraliaGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an Australian animal.
            /// </summary>
            /// <example>
            /// <code>Faker::Australia.animal
            /// #=> "Dingo"</code>
            /// </example>
            [FakerMethod("animal")]
            public string Animal()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("australia.animals"))));
            }
            /// <summary>
            /// Produces a location in Australia.
            /// </summary>
            /// <example>
            /// <code>Faker::Australia.location
            /// #=> "Sydney"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("australia.locations"))));
            }
            /// <summary>
            /// Produces an Australian State or Territory.
            /// </summary>
            /// <example>
            /// <code>Faker::Australia.state
            /// #=> "New South Wales"</code>
            /// </example>
            [FakerMethod("state")]
            public string State()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("australia.states"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Dessert")]
        public partial class DessertGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dessert.flavor"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dessert.topping"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dessert.variety"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Mountain")]
        public partial class MountainGenerator : GeneratorBase
        {
            internal MountainGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a name of a mountain.
            ///                             
            /// 
            ///                             <pre><code>@faker.version next
            ///                             </code></pre>
            /// </summary>
            /// <example>
            /// <code>Faker::Mountain.name #=> "Mount Everest"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("mountain.name"))));
            }
            /// <summary>
            /// Produces a name of a range.
            /// </summary>
            /// <example>
            /// <code>Faker::Mountain.range #=> "Dhaulagiri Himalaya"</code>
            /// </example>
            [FakerMethod("range")]
            public string Range()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("mountain.range"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Nation")]
        public partial class NationGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("nation.capital_city"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("nation.language"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("team.sport"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("nation.nationality"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("SouthAfrica")]
        public partial class SouthAfricaGenerator : GeneratorBase
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
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Space")]
        public partial class SpaceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.agency"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.agency_abv"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.company"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.constellation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.distance_measurement"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.galaxy"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.launch_vehicle"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.meteorite"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.moon"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.nasa_space_craft"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.nebula"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.planet"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.star"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("space.star_cluster"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("University")]
        public partial class UniversityGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("university.name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("university.prefix"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("university.suffix"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Placeholdit")]
    public partial class PlaceholditGenerator : GeneratorBase
    {
        internal PlaceholditGenerator(Faker faker)
                 : base(faker)
        {
        }
        
        #warning Failed processing method generate_color : method has no name or return type.
        #warning No implementation defined for method image(string size, string format, string backgroundColor, string textColor, string? text = null);
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Quote")]
    public partial class QuoteGenerator : GeneratorBase
    {
        [FakerProperty]
        public ChiquitoGenerator Chiquito { get; }
        [FakerProperty]
        public ChuckNorrisGenerator ChuckNorris { get; }
        [FakerProperty]
        public RajnikanthGenerator Rajnikanth { get; }
        [FakerProperty]
        public ShakespeareGenerator Shakespeare { get; }
        internal QuoteGenerator(Faker faker)
                 : base(faker)
        {
            Chiquito = new ChiquitoGenerator(this.Faker);
            ChuckNorris = new ChuckNorrisGenerator(this.Faker);
            Rajnikanth = new RajnikanthGenerator(this.Faker);
            Shakespeare = new ShakespeareGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Quotes.Chiquito")]
        public partial class ChiquitoGenerator : GeneratorBase
        {
            internal ChiquitoGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces an Expression from Chiquito.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Chiquito.expression # => "Ereh un torpedo!"</code>
            /// </example>
            [FakerMethod("expression")]
            public string Expression()
            {
                return this.ResolveYamlValue("chiquito.expressions");
            }
            /// <summary>
            /// Produces a joke from Chiquito.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Chiquito.joke # => "- Papar papar llevame al circo!
            /// - Noorl! El que quiera verte que venga a la casa"</code>
            /// </example>
            [FakerMethod("joke")]
            public string Joke()
            {
                return this.ResolveYamlValue("chiquito.jokes");
            }
            [FakerMethod("jokes")]
            public string Jokes()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chiquito.jokes"))));
            }
            /// <summary>
            /// Produces a sentence from Chiquito.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Chiquito.sentence # => "Te llamo trigo por no llamarte Rodrigo"</code>
            /// </example>
            [FakerMethod("sentence")]
            public string Sentence()
            {
                return this.ResolveYamlValue("chiquito.sentences");
            }
            [FakerMethod("sentences")]
            public string Sentences()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chiquito.sentences"))));
            }
            /// <summary>
            /// Produces a concept from Chiquito.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Chiquito.term # => "Fistro"</code>
            /// </example>
            [FakerMethod("term")]
            public string Term()
            {
                return this.ResolveYamlValue("chiquito.terms");
            }
            [FakerMethod("terms")]
            public string Terms()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chiquito.terms"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("ChuckNorris")]
        public partial class ChuckNorrisGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chuck_norris.fact"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Quotes.Rajnikanth")]
        public partial class RajnikanthGenerator : GeneratorBase
        {
            internal RajnikanthGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a Rajnikanth.
            ///                                 <p>Original list of jokes: <a href="http://www.rajinikanthjokes.com">www.rajinikanthjokes.com</a>/</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Rajnikanth.joke
            /// #=> "Rajinikanth is so fast that he always comes yesterday."</code>
            /// </example>
            [FakerMethod("joke")]
            public string Joke()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rajnikanth.joke"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Quotes.Shakespeare")]
        public partial class ShakespeareGenerator : GeneratorBase
        {
            internal ShakespeareGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Generates quote from 'As you like it!'.
            ///                                 <p>Generates quote from ‘As you like it!’</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.as_you_like_it   #=> "How bitter a thing it is to look into happiness through another man's eyes!"</code>
            /// </example>
            [FakerMethod("as_you_like_it")]
            public string AsYouLikeIt()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("shakespeare.as_you_like_it"))));
            }
            /// <summary>
            /// Produces a Shakespeare quote from As You Like It.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.as_you_like_it_quote # => "Can one desire too much of a good thing?."</code>
            /// </example>
            [FakerMethod("as_you_like_it_quote")]
            public string AsYouLikeItQuote()
            {
                return this.ResolveYamlValue("shakespeare.as_you_like_it");
            }
            /// <summary>
            /// Generates quote from Hamlet.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.hamlet   #=> "A little more than kin, and less than kind."</code>
            /// </example>
            [FakerMethod("hamlet")]
            public string Hamlet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("shakespeare.hamlet"))));
            }
            /// <summary>
            /// Produces a Shakespeare quote from Hamlet.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.hamlet_quote # => "To be, or not to be: that is the question."</code>
            /// </example>
            [FakerMethod("hamlet_quote")]
            public string HamletQuote()
            {
                return this.ResolveYamlValue("shakespeare.hamlet");
            }
            /// <summary>
            /// Returns quote from 'King Rechard III'.
            ///                                 <p>Returns quote from ‘King Rechard III’</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare  #=> "The king's name is a tower of strength."</code>
            /// </example>
            [FakerMethod("king_richard_iii")]
            public string KingRichardIii()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("shakespeare.king_richard_iii"))));
            }
            /// <summary>
            /// Produces a Shakespeare quote from King Richard III.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.king_richard_iii_quote # => "Now is the winter of our discontent."</code>
            /// </example>
            [FakerMethod("king_richard_iii_quote")]
            public string KingRichardIiiQuote()
            {
                return this.ResolveYamlValue("shakespeare.king_richard_iii");
            }
            /// <summary>
            /// Quote from 'Romeo and Juliet'.
            ///                                 <p>Quote from ‘Romeo and Juliet’</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.romeo_and_juliet  #=> "Wisely and slow; they stumble that run fast."</code>
            /// </example>
            [FakerMethod("romeo_and_juliet")]
            public string RomeoAndJuliet()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("shakespeare.romeo_and_juliet"))));
            }
            /// <summary>
            /// Produces a Shakespeare quote from Romeo And Juliet.
            /// </summary>
            /// <example>
            /// <code>Faker::Quote::Shakespeare.romeo_and_juliet_quote # => "O Romeo, Romeo! wherefore art thou Romeo?."</code>
            /// </example>
            [FakerMethod("romeo_and_juliet_quote")]
            public string RomeoAndJulietQuote()
            {
                return this.ResolveYamlValue("shakespeare.romeo_and_juliet");
            }
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.famous_last_words"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.fortune_cookie"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.jack_handey"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.matz"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.mitch_hedberg"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.most_interesting_man_in_the_world"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.robin"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.singular_siegler"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("quote.yoda"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Science")]
    public partial class ScienceGenerator : GeneratorBase
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.element"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.element_state"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.element_subcategory"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.element_symbol"))));
        }
        /// <summary>
        /// Produces a scientifically sounding word.
        /// </summary>
        /// <example>
        /// <code>Faker::Science.modifier #=> "Quantum"
        /// Faker::Science.modifier #=> "Superconductive"</code>
        /// </example>
        [FakerMethod("modifier")]
        public string Modifier()
        {
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.modifier"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.scientist"))));
        }
        /// <summary>
        /// Produces the name of a scientific tool.
        ///                             <p>By default it uses a science word modifier to generate more diverse data, which can be disabled.</p>
        /// </summary>
        /// <param name="simple">
        /// Whether to generate simple realistic tool names, (no Q-word).
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("science.tool"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Sport")]
    public partial class SportGenerator : GeneratorBase
    {
        [FakerProperty]
        public BasketballGenerator Basketball { get; }
        [FakerProperty]
        public ChessGenerator Chess { get; }
        [FakerProperty]
        public EsportGenerator Esport { get; }
        [FakerProperty]
        public FootballGenerator Football { get; }
        [FakerProperty]
        public MountaineeringGenerator Mountaineering { get; }
        [FakerProperty]
        public TeamGenerator Team { get; }
        [FakerProperty]
        public VolleyballGenerator Volleyball { get; }
        [FakerProperty]
        public WorldCupGenerator WorldCup { get; }
        internal SportGenerator(Faker faker)
                 : base(faker)
        {
            Basketball = new BasketballGenerator(this.Faker);
            Chess = new ChessGenerator(this.Faker);
            Esport = new EsportGenerator(this.Faker);
            Football = new FootballGenerator(this.Faker);
            Mountaineering = new MountaineeringGenerator(this.Faker);
            Team = new TeamGenerator(this.Faker);
            Volleyball = new VolleyballGenerator(this.Faker);
            WorldCup = new WorldCupGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Sports.Basketball")]
        public partial class BasketballGenerator : GeneratorBase
        {
            internal BasketballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a basketball coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Basketball.coach #=> "Gregg Popovich"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("basketball.coaches"))));
            }
            /// <summary>
            /// Produces the name of a basketball player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Basketball.player #=> "LeBron James"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("basketball.players"))));
            }
            /// <summary>
            /// Produces a position in basketball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Basketball.position #=> "Point Guard"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("basketball.positions"))));
            }
            /// <summary>
            /// Produces the name of a basketball team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Basketball.team #=> "Golden State Warriors"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("basketball.teams"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Sports.Chess")]
        public partial class ChessGenerator : GeneratorBase
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
            /// <code>Faker::Sport::Chess.opening #=> "Giuoco Piano"</code>
            /// </example>
            [FakerMethod("opening")]
            public string Opening()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chess.openings"))));
            }
            /// <summary>
            /// Produces the name of a chess player name.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Chess.player #=> "Golden State Warriors"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chess.players"))));
            }
            #warning No implementation defined for method rating();
            /// <summary>
            /// Produces a chess title.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Chess.title #=> "GM"</code>
            /// </example>
            [FakerMethod("title")]
            public string Title()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chess.titles"))));
            }
            [FakerMethod("tournament")]
            public string Tournament()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("chess.tournaments"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Esport")]
        public partial class EsportGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("esport.events"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("esport.games"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("esport.leagues"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("esport.players"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("esport.teams"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Sports.Football")]
        public partial class FootballGenerator : GeneratorBase
        {
            internal FootballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a football coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Football.coach #=> "Jose Mourinho"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("football.coaches"))));
            }
            /// <summary>
            /// Produces a football competition.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Football.competition #=> "FIFA World Cup"</code>
            /// </example>
            [FakerMethod("competition")]
            public string Competition()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("football.competitions"))));
            }
            /// <summary>
            /// Produces the name of a football player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Football.player #=> "Lionel Messi"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("football.players"))));
            }
            /// <summary>
            /// Produces a position in football.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Football.position #=> "Defensive Midfielder"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("football.positions"))));
            }
            /// <summary>
            /// Produces the name of a football team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Football.team #=> "Manchester United"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("football.teams"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Sports.Mountaineering")]
        public partial class MountaineeringGenerator : GeneratorBase
        {
            internal MountaineeringGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a Mountaineer.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Mountaineering.mountaineer #=> "Junko Tabei"</code>
            /// </example>
            [FakerMethod("mountaineer")]
            public string Mountaineer()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("mountaineering.mountaineer"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Team")]
        public partial class TeamGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("team.creature"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("team.mascot"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("team.name"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("team.sport"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("address.state"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Sports.Volleyball")]
        public partial class VolleyballGenerator : GeneratorBase
        {
            internal VolleyballGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces the name of a volleyball coach.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Volleyball.coach #=> "Russ Rose"</code>
            /// </example>
            [FakerMethod("coach")]
            public string Coach()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("volleyball.coach"))));
            }
            /// <summary>
            /// Produces a formation in volleyball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Volleyball.formation #=> "4-2"</code>
            /// </example>
            [FakerMethod("formation")]
            public string Formation()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("volleyball.formation"))));
            }
            /// <summary>
            /// Produces the name of a volleyball player.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Volleyball.player #=> "Saeid Marouf"</code>
            /// </example>
            [FakerMethod("player")]
            public string Player()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("volleyball.player"))));
            }
            /// <summary>
            /// Produces a position in volleyball.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Volleyball.position #=> "Middle blocker"</code>
            /// </example>
            [FakerMethod("position")]
            public string Position()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("volleyball.position"))));
            }
            /// <summary>
            /// Produces the name of a volleyball team.
            /// </summary>
            /// <example>
            /// <code>Faker::Sport::Volleyball.team #=> "Leo Shoes Modena"</code>
            /// </example>
            [FakerMethod("team")]
            public string Team()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("volleyball.team"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("WorldCup")]
        public partial class WorldCupGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("world_cup.cities"))));
            }
            /// <summary>
            /// Produces a random national team name from a group.
            /// </summary>
            /// <param name="group">
            /// Valid Values : Group_A to Group_H
            /// (default value "'group_A'")
            /// </param>
            /// <example>
            /// <code>Faker::WorldCup.group(group: 'group_B') #=> "Spain"</code>
            /// </example>
            /// <example>
            /// <code>Faker::WorldCup.group #=> "Russia"</code>
            /// </example>
            [FakerMethod("group")]
            public string Group(string group = "group_A")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("world_cup.groups." + group + ""))));
            }
            /// <summary>
            /// Produces a random name from national team roster.
            /// </summary>
            /// <param name="country">
            /// (default value "'Egypt'")
            /// </param>
            /// <param name="type">
            /// Valid values : coach, goalkeepers, defenders, midfielders, forwards
            /// (default value "'coach'")
            /// </param>
            /// <example>
            /// <code>Faker::WorldCup.roster #=> "Hector Cuper"</code>
            /// </example>
            /// <example>
            /// <code>Faker::WorldCup.roster(country: 'Spain', type: 'forwards') #=> "Diego Costa"</code>
            /// </example>
            [FakerMethod("roster")]
            public string Roster(string country = "Egypt", string type = "coach")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("world_cup.rosters." + country + "." + type + ""))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("world_cup.stadiums"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("world_cup.teams"))));
            }
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.ancient_olympics"))));
        }
        /// <summary>
        /// Produces a sport from the modern olympics or paralympics, summer or winter.
        /// </summary>
        /// <param name="includeAncient">
        /// If true, may produce a sport from the ancient olympics
        /// </param>
        /// <param name="includeUnusual">
        /// If true, may produce an unusual (definitely not olympic) sport
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Sport.sport #=> "Football"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Sport.sport(include_ancient: true) #=> "Chariot racing"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Sport.sport(include_unsual: true) #=> "Flugtag/Birdman"</code>
        /// </example>
        /// <example>
        /// <code>Faker::Sport.sport(include_ancient:true, include_unusual: true) #=> "Water polo"</code>
        /// </example>
        [FakerMethod("sport")]
        public string Sport(bool includeAncient, bool includeUnusual = false)
        {
            return this.ResolveYamlValue("sport.summer_olympics");
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.summer_olympics"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.summer_paralympics"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.unusual"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.winter_olympics"))));
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
            return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("sport.winter_paralympics"))));
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Things")]
    public partial class ThingsGenerator : GeneratorBase
    {
        [FakerProperty]
        public CameraGenerator Camera { get; }
        [FakerProperty]
        public DroneGenerator Drone { get; }
        [FakerProperty]
        public HobbyGenerator Hobby { get; }
        [FakerProperty]
        public HouseGenerator House { get; }
        [FakerProperty]
        public VehicleGenerator Vehicle { get; }
        internal ThingsGenerator(Faker faker)
                 : base(faker)
        {
            Camera = new CameraGenerator(this.Faker);
            Drone = new DroneGenerator(this.Faker);
            Hobby = new HobbyGenerator(this.Faker);
            House = new HouseGenerator(this.Faker);
            Vehicle = new VehicleGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Camera")]
        public partial class CameraGenerator : GeneratorBase
        {
            internal CameraGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a brand of a camera.
            /// </summary>
            /// <example>
            /// <code>Faker::Camera.brand #=> "Canon"</code>
            /// </example>
            [FakerMethod("brand")]
            public string Brand()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("camera.brand"))));
            }
            /// <summary>
            /// Produces a brand with model.
            /// </summary>
            /// <example>
            /// <code>Faker::Camera.brand_with_model #=> "Canon 450D"</code>
            /// </example>
            [FakerMethod("brand_with_model")]
            public string BrandWithModel()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("camera.brand_with_model"))));
            }
            /// <summary>
            /// Produces a model of camera.
            /// </summary>
            /// <example>
            /// <code>Faker::Camera.model #=> "450D"</code>
            /// </example>
            [FakerMethod("model")]
            public string Model()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("camera.model"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Drone")]
        public partial class DroneGenerator : GeneratorBase
        {
            internal DroneGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Returns the drone battery capacity.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.battery_capacity #=> "3500 mAh"</code>
            /// </example>
            [FakerMethod("battery_capacity")]
            public string BatteryCapacity()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.battery_capacity"))));
            }
            /// <summary>
            /// Returns the battery type.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.battery_type #=> "LiPo 4S"</code>
            /// </example>
            [FakerMethod("battery_type")]
            public string BatteryType()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.battery_type"))));
            }
            /// <summary>
            /// Returns battery voltage.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.battery_voltage #=> "13.2V"</code>
            /// </example>
            [FakerMethod("battery_voltage")]
            public string BatteryVoltage()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.battery_voltage"))));
            }
            /// <summary>
            /// Returns total battery weight in grams.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.battery_weight #=> "198 g"</code>
            /// </example>
            [FakerMethod("battery_weight")]
            public string BatteryWeight()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.battery_weight"))));
            }
            /// <summary>
            /// Returns charging temperature for battery in Fahrenheit.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.charging_temperature #=> "41-104F"</code>
            /// </example>
            [FakerMethod("charging_temperature")]
            public string ChargingTemperature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.charging_temperature"))));
            }
            /// <summary>
            /// Returns max flight time for drone in optimal conditions.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.flight_time #=> "34 min"</code>
            /// </example>
            [FakerMethod("flight_time")]
            public string FlightTime()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.flight_time"))));
            }
            /// <summary>
            /// Returns camera ISO range for drone.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.iso #=> "100-3200"</code>
            /// </example>
            [FakerMethod("iso")]
            public string Iso()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.iso"))));
            }
            /// <summary>
            /// Returns max altitude drone can go above sea level in meters.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_altitude #=> "5000 m"</code>
            /// </example>
            [FakerMethod("max_altitude")]
            public string MaxAltitude()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_altitude"))));
            }
            /// <summary>
            /// Returns max angular velocity of drone in degrees/s.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_angular_velocity #=> "250 degree/s"</code>
            /// </example>
            [FakerMethod("max_angular_velocity")]
            public string MaxAngularVelocity()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_angular_velocity"))));
            }
            /// <summary>
            /// Returns maximum ascent speed for drone in m/s.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_ascent_speed #=> "4 m/s"</code>
            /// </example>
            [FakerMethod("max_ascent_speed")]
            public string MaxAscentSpeed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_ascent_speed"))));
            }
            /// <summary>
            /// Returns max chargin power required for battery.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_charging_power #=> "38W"</code>
            /// </example>
            [FakerMethod("max_charging_power")]
            public string MaxChargingPower()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_charging_power"))));
            }
            /// <summary>
            /// Returns maximum descent speed for drone in m/s.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_descent_speed #=> "4 m/s"</code>
            /// </example>
            [FakerMethod("max_descent_speed")]
            public string MaxDescentSpeed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_descent_speed"))));
            }
            /// <summary>
            /// Returns how far drone can go in optimal condition when full charged in meters.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_flight_distance #=> "18500 m"</code>
            /// </example>
            [FakerMethod("max_flight_distance")]
            public string MaxFlightDistance()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_flight_distance"))));
            }
            /// <summary>
            /// Returns max camera resolution in MP".
            ///                             <p>Returns max camera resolution in MP“</p>
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_resolution #=> "48MP"</code>
            /// </example>
            [FakerMethod("max_resolution")]
            public string MaxResolution()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_resolution"))));
            }
            /// <summary>
            /// Returns max shutter speed for camera.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_shutter_speed #=> "60s"</code>
            /// </example>
            [FakerMethod("max_shutter_speed")]
            public string MaxShutterSpeed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_shutter_speed"))));
            }
            /// <summary>
            /// Returns max horizontal speed by drone in m/s.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_speed #=> "19 m/s"</code>
            /// </example>
            [FakerMethod("max_speed")]
            public string MaxSpeed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_speed"))));
            }
            /// <summary>
            /// Returns max tilt angle drone can go in degrees.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_tilt_angle #=> "35 degrees"</code>
            /// </example>
            [FakerMethod("max_tilt_angle")]
            public string MaxTiltAngle()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_tilt_angle"))));
            }
            /// <summary>
            /// Returns max wind resistance by drone in m/s.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.max_wind_resistance #=> "10.5 m/s"</code>
            /// </example>
            [FakerMethod("max_wind_resistance")]
            public string MaxWindResistance()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_wind_resistance"))));
            }
            /// <summary>
            /// Returns min shutter speed for camera.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.min_shutter_speed #=> "1/8000s"</code>
            /// </example>
            [FakerMethod("min_shutter_speed")]
            public string MinShutterSpeed()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.min_shutter_speed"))));
            }
            /// <summary>
            /// Returns random drone name with company.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.name #=> "DJI Mavic Air 2"</code>
            /// </example>
            [FakerMethod("name")]
            public string Name()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.name"))));
            }
            /// <summary>
            /// Returns operating temperature for drone in Fahrenheit.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.operating_temperature #=> "14-104F"</code>
            /// </example>
            [FakerMethod("operating_temperature")]
            public string OperatingTemperature()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.operating_temperature"))));
            }
            /// <summary>
            /// Returns photo format for drone.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.photo_format #=> "JPEG"</code>
            /// </example>
            [FakerMethod("photo_format")]
            public string PhotoFormat()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.photo_format"))));
            }
            /// <summary>
            /// Returns max and min shutter speed for camera.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.shutter_speed_range #=> "8-1/8000s"</code>
            /// </example>
            [FakerMethod("shutter_speed_range")]
            public string ShutterSpeedRange()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.max_shutter_speed"))));
            }
            /// <summary>
            /// Returns video format.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.video_format #=> "MP4"</code>
            /// </example>
            [FakerMethod("video_format")]
            public string VideoFormat()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.video_format"))));
            }
            /// <summary>
            /// Returns total drone weight in grams.
            /// </summary>
            /// <example>
            /// <code>Faker::Drone.weight #=> "570 g"</code>
            /// </example>
            [FakerMethod("weight")]
            public string Weight()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("drone.weight"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Hobby")]
        public partial class HobbyGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hobby.activity"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("House")]
        public partial class HouseGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("house.furniture"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("house.rooms"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Vehicle")]
        public partial class VehicleGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.car_options")))).Split(',').Select(item => item).ToList();
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.car_types"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.colors"))));
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
                return long.Parse(this.ResolveYamlValue("vehicle.doors"));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.drive_types"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.cylinder_engine"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.fuel_types"))));
            }
            /// <summary>
            /// Produces a random license plate number.
            /// </summary>
            /// <param name="stateAbbreviation">
            /// Two letter state abbreviation for license plate generation.
            /// (default value "''")
            /// </param>
            /// <example>
            /// <code>Faker::Vehicle.license_plate #=> "DEP-2483"
            /// Faker::Vehicle.license_plate(state_abbreviation: 'FL') #=> "977 UNU"</code>
            /// </example>
            [FakerMethod("license_plate")]
            public string LicensePlate(string stateAbbreviation = "")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.license_plate"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.makes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.manufacture"))));
            }
            #warning No implementation defined for method mileage(long min, long max = MILEAGE_MAX);
            /// <summary>
            /// Produces a random vehicle model.
            /// </summary>
            /// <param name="makeOfModel">
            /// Specific valid vehicle make.
            /// (default value "''")
            /// </param>
            /// <example>
            /// <code>Faker::Vehicle.model #=> "A8"
            /// Faker::Vehicle.model(make_of_model: 'Toyota') #=> "Prius"</code>
            /// </example>
            [FakerMethod("model")]
            public string Model(string makeOfModel = "")
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.models_by_make.#{make}"))));
            }
            #warning Failed processing method singapore_checksum : method has no name or return type.
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.standard_specs")))).Split(',').Select(item => item).ToList();
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.styles"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.transmissions"))));
            }
            /// <summary>
            /// Produces a car version.
            /// </summary>
            /// <example>
            /// <code>Faker::Vehicle.version #=> "40 TFSI Premium"</code>
            /// </example>
            [FakerMethod("version")]
            public string Version()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("vehicle.version"))));
            }
            #warning No implementation defined for method vin();
            #warning No implementation defined for method year();
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Travel")]
    public partial class TravelGenerator : GeneratorBase
    {
        [FakerProperty]
        public AirportGenerator Airport { get; }
        [FakerProperty]
        public TrainStationGenerator TrainStation { get; }
        internal TravelGenerator(Faker faker)
                 : base(faker)
        {
            Airport = new AirportGenerator(this.Faker);
            TrainStation = new TrainStationGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Travel.Airport")]
        public partial class AirportGenerator : GeneratorBase
        {
            internal AirportGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces random Airport by IATA code and takes arguments for size and region.
            ///                                 
            /// 
            ///                                 <p>Faker::Travel::Airport.iata(size: ‘large’, region: ‘united_states’) =&gt; “LAX”</p>
            /// </summary>
            /// <param name="size">
            /// airport size, united_states has large, or medium, or small, european_union has large, or medium
            /// </param>
            /// <param name="region">
            /// airport region, currently available -&gt; united_states or european_union
            /// </param>
            [FakerMethod("iata")]
            public string Iata(string size, string region)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("airport." + region + ".iata_code." + size + ""))));
            }
            /// <summary>
            /// Produces random Airport by name and takes arguments for size and region.
            ///                                 
            /// 
            ///                                 <p>Faker::Travel::Airport.name(size: ‘large’, region: ‘united_states’) =&gt; “Los Angeles International Airport”</p>
            /// </summary>
            /// <param name="size">
            /// airport size, united_states has large, or medium, or small, european_union has large, or medium
            /// </param>
            /// <param name="region">
            /// airport region, currently available -&gt; united_states or european_union
            /// </param>
            [FakerMethod("name")]
            public string Name(string size, string region)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("airport." + region + "." + size + ""))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Travel.TrainStation")]
        public partial class TrainStationGenerator : GeneratorBase
        {
            internal TrainStationGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            #warning No implementation defined for method fill_missing_inputs_with_samples();
            /// <summary>
            /// Produces random Train Station by name and takes optional arguments for region and type.
            ///                                 
            /// 
            ///                                 <p>Faker::Travel::TrainStation.name(region: ‘united_kingdom’, type: ‘metro’) =&gt; “Brockley” Faker::Travel::TrainStation.name(type: ‘railway’) =&gt; “Düsseldorf Hauptbahnhof” Faker::Travel::TrainStation.name(region: ‘spain’) =&gt; “Santa Eulàlia”</p>
            /// </summary>
            /// <param name="region">
            /// Train station region: germany, spain, united_kingdom, united_states
            /// </param>
            /// <param name="type">
            /// Train station type: metro, railway
            /// (default value "nil")
            /// </param>
            [FakerMethod("name")]
            public string Name(string region, string? type = null)
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("train_station." + region + "." + type + ""))));
            }
            #warning No implementation defined for method validate_arguments();
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("TvShows")]
    public partial class TvShowsGenerator : GeneratorBase
    {
        [FakerProperty]
        public AquaTeenHungerForceGenerator AquaTeenHungerForce { get; }
        [FakerProperty]
        public ArcherGenerator Archer { get; }
        [FakerProperty]
        public BigBangTheoryGenerator BigBangTheory { get; }
        [FakerProperty]
        public BojackHorsemanGenerator BojackHorseman { get; }
        [FakerProperty]
        public BreakingBadGenerator BreakingBad { get; }
        [FakerProperty]
        public BrooklynNineNineGenerator BrooklynNineNine { get; }
        [FakerProperty]
        public BuffyGenerator Buffy { get; }
        [FakerProperty]
        public CommunityGenerator Community { get; }
        [FakerProperty]
        public DrWhoGenerator DrWho { get; }
        [FakerProperty]
        public DumbAndDumberGenerator DumbAndDumber { get; }
        [FakerProperty]
        public FamilyGuyGenerator FamilyGuy { get; }
        [FakerProperty]
        public FinalSpaceGenerator FinalSpace { get; }
        [FakerProperty]
        public FriendsGenerator Friends { get; }
        [FakerProperty]
        public FuturamaGenerator Futurama { get; }
        [FakerProperty]
        public GameOfThronesGenerator GameOfThrones { get; }
        [FakerProperty]
        public HeyArnoldGenerator HeyArnold { get; }
        [FakerProperty]
        public HowIMetYourMotherGenerator HowIMetYourMother { get; }
        [FakerProperty]
        public MichaelScottGenerator MichaelScott { get; }
        [FakerProperty]
        public NewGirlGenerator NewGirl { get; }
        [FakerProperty]
        public ParksAndRecGenerator ParksAndRec { get; }
        [FakerProperty]
        public RickAndMortyGenerator RickAndMorty { get; }
        [FakerProperty]
        public RuPaulGenerator RuPaul { get; }
        [FakerProperty]
        public SeinfeldGenerator Seinfeld { get; }
        [FakerProperty]
        public SiliconValleyGenerator SiliconValley { get; }
        [FakerProperty]
        public SimpsonsGenerator Simpsons { get; }
        [FakerProperty]
        public SouthParkGenerator SouthPark { get; }
        [FakerProperty]
        public SpongebobGenerator Spongebob { get; }
        [FakerProperty]
        public StargateGenerator Stargate { get; }
        [FakerProperty]
        public StarTrekGenerator StarTrek { get; }
        [FakerProperty]
        public StrangerThingsGenerator StrangerThings { get; }
        [FakerProperty]
        public SuitsGenerator Suits { get; }
        [FakerProperty]
        public SupernaturalGenerator Supernatural { get; }
        [FakerProperty]
        public TheExpanseGenerator TheExpanse { get; }
        [FakerProperty]
        public TheFreshPrinceOfBelAirGenerator TheFreshPrinceOfBelAir { get; }
        [FakerProperty]
        public TheITCrowdGenerator TheITCrowd { get; }
        [FakerProperty]
        public TheOfficeGenerator TheOffice { get; }
        [FakerProperty]
        public TheThickOfItGenerator TheThickOfIt { get; }
        [FakerProperty]
        public TwinPeaksGenerator TwinPeaks { get; }
        [FakerProperty]
        public VentureBrosGenerator VentureBros { get; }
        internal TvShowsGenerator(Faker faker)
                 : base(faker)
        {
            AquaTeenHungerForce = new AquaTeenHungerForceGenerator(this.Faker);
            Archer = new ArcherGenerator(this.Faker);
            BigBangTheory = new BigBangTheoryGenerator(this.Faker);
            BojackHorseman = new BojackHorsemanGenerator(this.Faker);
            BreakingBad = new BreakingBadGenerator(this.Faker);
            BrooklynNineNine = new BrooklynNineNineGenerator(this.Faker);
            Buffy = new BuffyGenerator(this.Faker);
            Community = new CommunityGenerator(this.Faker);
            DrWho = new DrWhoGenerator(this.Faker);
            DumbAndDumber = new DumbAndDumberGenerator(this.Faker);
            FamilyGuy = new FamilyGuyGenerator(this.Faker);
            FinalSpace = new FinalSpaceGenerator(this.Faker);
            Friends = new FriendsGenerator(this.Faker);
            Futurama = new FuturamaGenerator(this.Faker);
            GameOfThrones = new GameOfThronesGenerator(this.Faker);
            HeyArnold = new HeyArnoldGenerator(this.Faker);
            HowIMetYourMother = new HowIMetYourMotherGenerator(this.Faker);
            MichaelScott = new MichaelScottGenerator(this.Faker);
            NewGirl = new NewGirlGenerator(this.Faker);
            ParksAndRec = new ParksAndRecGenerator(this.Faker);
            RickAndMorty = new RickAndMortyGenerator(this.Faker);
            RuPaul = new RuPaulGenerator(this.Faker);
            Seinfeld = new SeinfeldGenerator(this.Faker);
            SiliconValley = new SiliconValleyGenerator(this.Faker);
            Simpsons = new SimpsonsGenerator(this.Faker);
            SouthPark = new SouthParkGenerator(this.Faker);
            Spongebob = new SpongebobGenerator(this.Faker);
            Stargate = new StargateGenerator(this.Faker);
            StarTrek = new StarTrekGenerator(this.Faker);
            StrangerThings = new StrangerThingsGenerator(this.Faker);
            Suits = new SuitsGenerator(this.Faker);
            Supernatural = new SupernaturalGenerator(this.Faker);
            TheExpanse = new TheExpanseGenerator(this.Faker);
            TheFreshPrinceOfBelAir = new TheFreshPrinceOfBelAirGenerator(this.Faker);
            TheITCrowd = new TheITCrowdGenerator(this.Faker);
            TheOffice = new TheOfficeGenerator(this.Faker);
            TheThickOfIt = new TheThickOfItGenerator(this.Faker);
            TwinPeaks = new TwinPeaksGenerator(this.Faker);
            VentureBros = new VentureBrosGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.AquaTeenHungerForce")]
        public partial class AquaTeenHungerForceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("aqua_teen_hunger_force.character"))));
            }
            /// <summary>
            /// Produces a perl of great ATHF wisdom.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::AquaTeenHungerForce.quote #=> "Friendship ain't about trust. Friendship's about nunchucks."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("aqua_teen_hunger_force.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Archer")]
        public partial class ArcherGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("archer.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("archer.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("archer.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.BigBangTheory")]
        public partial class BigBangTheoryGenerator : GeneratorBase
        {
            internal BigBangTheoryGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Big Bang Theory.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BigBangTheory.character #=> "Sheldon Cooper"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("big_bang_theory.characters"))));
            }
            /// <summary>
            /// Produces a quote from Bing Bang Theory.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::BigBangTheory.quote #=> "I'm not crazy. My mother had me tested."</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("big_bang_theory.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.BojackHorseman")]
        public partial class BojackHorsemanGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bojack_horseman.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bojack_horseman.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("bojack_horseman.tongue_twisters"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.BreakingBad")]
        public partial class BreakingBadGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("breaking_bad.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("breaking_bad.episode"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.BrooklynNineNine")]
        public partial class BrooklynNineNineGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("brooklyn_nine_nine.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("brooklyn_nine_nine.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Buffy")]
        public partial class BuffyGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("buffy.actors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("buffy.big_bads"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("buffy.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("buffy.episodes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("buffy.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Community")]
        public partial class CommunityGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("community.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("community.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.DrWho")]
        public partial class DrWhoGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.actors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.catch_phrases"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.species"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.the_doctors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dr_who.villains"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.DumbAndDumber")]
        public partial class DumbAndDumberGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dumb_and_dumber.actors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dumb_and_dumber.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("dumb_and_dumber.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.FamilyGuy")]
        public partial class FamilyGuyGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("family_guy.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("family_guy.location"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("family_guy.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.FinalSpace")]
        public partial class FinalSpaceGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("final_space.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("final_space.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("final_space.vehicles"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Friends")]
        public partial class FriendsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("friends.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("friends.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("friends.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Futurama")]
        public partial class FuturamaGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("futurama.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("futurama.hermes_catchphrases"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("futurama.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("futurama.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.GameOfThrones")]
        public partial class GameOfThronesGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game_of_thrones.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game_of_thrones.cities"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game_of_thrones.dragons"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game_of_thrones.houses"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("game_of_thrones.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.HeyArnold")]
        public partial class HeyArnoldGenerator : GeneratorBase
        {
            internal HeyArnoldGenerator(Faker faker)
                     : base(faker)
            {
            }
            
            /// <summary>
            /// Produces a character from Hey Arnold!.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.character #=> "Arnold"</code>
            /// </example>
            [FakerMethod("character")]
            public string Character()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hey_arnold.characters"))));
            }
            /// <summary>
            /// Produces a location from Hey Arnold!.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.location #=> "Big Bob's Beeper Emporium"</code>
            /// </example>
            [FakerMethod("location")]
            public string Location()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hey_arnold.locations"))));
            }
            /// <summary>
            /// Produces a quote from Hey Arnold!.
            /// </summary>
            /// <example>
            /// <code>Faker::TvShows::HeyArnold.quote #=> "Stoop Kid's afraid to leave his stoop!"</code>
            /// </example>
            [FakerMethod("quote")]
            public string Quote()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hey_arnold.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.HowIMetYourMother")]
        public partial class HowIMetYourMotherGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_i_met_your_mother.catch_phrase"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_i_met_your_mother.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_i_met_your_mother.high_five"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("how_i_met_your_mother.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.MichaelScott")]
        public partial class MichaelScottGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("michael_scott.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.NewGirl")]
        public partial class NewGirlGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("new_girl.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("new_girl.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.ParksAndRec")]
        public partial class ParksAndRecGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("parks_and_rec.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("parks_and_rec.cities"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.RickAndMorty")]
        public partial class RickAndMortyGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rick_and_morty.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rick_and_morty.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rick_and_morty.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.RuPaul")]
        public partial class RuPaulGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rupaul.queens"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("rupaul.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Seinfeld")]
        public partial class SeinfeldGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("seinfeld.business"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("seinfeld.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("seinfeld.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.SiliconValley")]
        public partial class SiliconValleyGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.apps"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.companies"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.email"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.inventions"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.mottos"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("silicon_valley.urls"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Simpsons")]
        public partial class SimpsonsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("simpsons.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("simpsons.episode_titles"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("simpsons.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("simpsons.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.SouthPark")]
        public partial class SouthParkGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("south_park.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("south_park.episodes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("south_park.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Spongebob")]
        public partial class SpongebobGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("spongebob.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("spongebob.episodes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("spongebob.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Stargate")]
        public partial class StargateGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("stargate.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("stargate.planets"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("stargate.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.StarTrek")]
        public partial class StarTrekGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("star_trek.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("star_trek.location"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("star_trek.specie"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("star_trek.villain"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.StrangerThings")]
        public partial class StrangerThingsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("stranger_things.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("stranger_things.quote"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Suits")]
        public partial class SuitsGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("suits.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("suits.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.Supernatural")]
        public partial class SupernaturalGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("supernatural.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("supernatural.creature"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("supernatural.weapon"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TheExpanse")]
        public partial class TheExpanseGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_expanse.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_expanse.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_expanse.quotes"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_expanse.ships"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TheFreshPrinceOfBelAir")]
        public partial class TheFreshPrinceOfBelAirGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_fresh_prince_of_bel_air.actors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_fresh_prince_of_bel_air.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_fresh_prince_of_bel_air.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TheITCrowd")]
        public partial class TheITCrowdGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_it_crowd.actors"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_it_crowd.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_it_crowd.emails"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_it_crowd.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TheOffice")]
        public partial class TheOfficeGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_office.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_office.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TheThickOfIt")]
        public partial class TheThickOfItGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_thick_of_it.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_thick_of_it.departments"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("the_thick_of_it.positions"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.TwinPeaks")]
        public partial class TwinPeaksGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("twin_peaks.characters"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("twin_peaks.locations"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("twin_peaks.quotes"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("TvShows.VentureBros")]
        public partial class VentureBrosGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("venture_bros.character"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("venture_bros.organization"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("venture_bros.quote"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("venture_bros.vehicle"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Types")]
    public partial class TypesGenerator : GeneratorBase
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
        #warning Failed processing method titleize : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [FakerGenerator("Words")]
    public partial class WordsGenerator : GeneratorBase
    {
        [FakerProperty]
        public AdjectiveGenerator Adjective { get; }
        [FakerProperty]
        public EmotionGenerator Emotion { get; }
        [FakerProperty]
        public HackerGenerator Hacker { get; }
        [FakerProperty]
        public HipsterGenerator Hipster { get; }
        [FakerProperty]
        public VerbGenerator Verb { get; }
        internal WordsGenerator(Faker faker)
                 : base(faker)
        {
            Adjective = new AdjectiveGenerator(this.Faker);
            Emotion = new EmotionGenerator(this.Faker);
            Hacker = new HackerGenerator(this.Faker);
            Hipster = new HipsterGenerator(this.Faker);
            Verb = new VerbGenerator(this.Faker);
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Adjective")]
        public partial class AdjectiveGenerator : GeneratorBase
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
                return this.Translate(this.ResolveYamlValue("adjective.negative"));
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
                return this.Translate(this.ResolveYamlValue("adjective.positive"));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Emotion")]
        public partial class EmotionGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("emotion.adjective"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("emotion.noun"))));
            }
        }
        
        /// <summary>
        /// Port of http://shinytoylabs.com/jargon/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.
        /// <p>Port of <a href="http://shinytoylabs.com/jargon">shinytoylabs.com/jargon</a>/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.</p>
        /// 
        /// </summary>
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Hacker")]
        public partial class HackerGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hacker.abbreviation"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hacker.adjective"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hacker.ingverb"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hacker.noun"))));
            }
            /// <summary>
            /// Produces something smart.
            /// </summary>
            /// <example>
            /// <code>Faker::Hacker.say_something_smart
            /// #=> "Try to compress the SQL interface, maybe it will program the back-end hard drive!"</code>
            /// </example>
            [FakerMethod("say_something_smart")]
            public string SaySomethingSmart()
            {
                return this.ResolveYamlValue("hacker.phrases");
            }
            /// <summary>
            /// Actions that hackers take.
            /// </summary>
            /// <example>
            /// <code>Faker::Hacker.verb #=> "bypass"</code>
            /// </example>
            [FakerMethod("verb")]
            public string Verb()
            {
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("hacker.verb"))));
            }
        }
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Hipster")]
        public partial class HipsterGenerator : GeneratorBase
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
        
        [GeneratedCode("Faker Code Generator", "1.0.0.0")]
        [FakerGenerator("Verb")]
        public partial class VerbGenerator : GeneratorBase
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("verbs.base"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("verbs.ing_form"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("verbs.past"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("verbs.past_participle"))));
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
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("verbs.simple_present"))));
            }
        }
        
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    partial class Faker
    {
        [FakerProperty]
        public BlockchainGenerator Blockchain { get; }
        [FakerProperty]
        public BooksGenerator Books { get; }
        [FakerProperty]
        public ChileRutGenerator ChileRut { get; }
        [FakerProperty]
        public CoinGenerator Coin { get; }
        [FakerProperty]
        public CommerceGenerator Commerce { get; }
        [FakerProperty]
        public CreatureGenerator Creature { get; }
        [FakerProperty]
        public DataGenerator Data { get; }
        [FakerProperty]
        public DefenceGenerator Defence { get; }
        [FakerProperty]
        public EducationGenerator Education { get; }
        [FakerProperty]
        public FoodAndDrinkGenerator FoodAndDrink { get; }
        [FakerProperty]
        public GameGenerator Game { get; }
        [FakerProperty]
        public InternetGenerator Internet { get; }
        [FakerProperty]
        public ITGenerator IT { get; }
        [FakerProperty]
        public JapaneseMediaGenerator JapaneseMedia { get; }
        [FakerProperty]
        public LocationGenerator Location { get; }
        [FakerProperty]
        public LoremFlickrGenerator LoremFlickr { get; }
        [FakerProperty]
        public MedicineGenerator Medicine { get; }
        [FakerProperty]
        public MovieGenerator Movie { get; }
        [FakerProperty]
        public MusicGenerator Music { get; }
        [FakerProperty]
        public OmniauthGenerator Omniauth { get; }
        [FakerProperty]
        public PeopleGenerator People { get; }
        [FakerProperty]
        public PersonGenerator Person { get; }
        [FakerProperty]
        public PlaceGenerator Place { get; }
        [FakerProperty]
        public PlaceholditGenerator Placeholdit { get; }
        [FakerProperty]
        public QuoteGenerator Quote { get; }
        [FakerProperty]
        public ScienceGenerator Science { get; }
        [FakerProperty]
        public SportGenerator Sport { get; }
        [FakerProperty]
        public ThingsGenerator Things { get; }
        [FakerProperty]
        public TravelGenerator Travel { get; }
        [FakerProperty]
        public TvShowsGenerator TvShows { get; }
        [FakerProperty]
        public TypesGenerator Types { get; }
        [FakerProperty]
        public WordsGenerator Words { get; }
        
        public Faker(CultureInfo locale, Random random)
        {
            this.Random = random;
            
            // Create the Faker Generators
            Blockchain = new BlockchainGenerator(this);
            Books = new BooksGenerator(this);
            ChileRut = new ChileRutGenerator(this);
            Coin = new CoinGenerator(this);
            Commerce = new CommerceGenerator(this);
            Creature = new CreatureGenerator(this);
            Data = new DataGenerator(this);
            Defence = new DefenceGenerator(this);
            Education = new EducationGenerator(this);
            FoodAndDrink = new FoodAndDrinkGenerator(this);
            Game = new GameGenerator(this);
            Internet = new InternetGenerator(this);
            IT = new ITGenerator(this);
            JapaneseMedia = new JapaneseMediaGenerator(this);
            Location = new LocationGenerator(this);
            LoremFlickr = new LoremFlickrGenerator(this);
            Medicine = new MedicineGenerator(this);
            Movie = new MovieGenerator(this);
            Music = new MusicGenerator(this);
            Omniauth = new OmniauthGenerator(this);
            People = new PeopleGenerator(this);
            Person = new PersonGenerator(this);
            Place = new PlaceGenerator(this);
            Placeholdit = new PlaceholditGenerator(this);
            Quote = new QuoteGenerator(this);
            Science = new ScienceGenerator(this);
            Sport = new SportGenerator(this);
            Things = new ThingsGenerator(this);
            Travel = new TravelGenerator(this);
            TvShows = new TvShowsGenerator(this);
            Types = new TypesGenerator(this);
            Words = new WordsGenerator(this);
            
            Init(locale);
        }
    }
}
