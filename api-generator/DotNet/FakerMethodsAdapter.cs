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
    public partial class FakerAdapterBlockchain
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBlockchainAeternity
    {
        [NativeFunction("Address", "Produces a random Aeternity wallet address.", "Blockchain.Aeternity", "function-blockchain-aeternity-Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Aeternity.Address();
        }
        [NativeFunction("Contract", "Produces a random Aeternity contract.", "Blockchain.Aeternity", "function-blockchain-aeternity-Contract.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Contract(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Aeternity.Contract();
        }
        [NativeFunction("Oracle", "Produces a random Aeternity oracle.", "Blockchain.Aeternity", "function-blockchain-aeternity-Oracle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Oracle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Aeternity.Oracle();
        }
        [NativeFunction("Transaction", "Produces a random Aeternity transaction.", "Blockchain.Aeternity", "function-blockchain-aeternity-Transaction.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Transaction(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Aeternity.Transaction();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBlockchainBitcoin
    {
        [NativeFunction("Address", "Produces a Bitcoin wallet address.", "Blockchain.Bitcoin", "function-blockchain-bitcoin-Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Bitcoin.Address();
        }
        [NativeFunction("AddressFor", "Generates a random Bitcoin address for the given network.", "Blockchain.Bitcoin", "function-blockchain-bitcoin-AddressFor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AddressFor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("networkByte", "", IsOptional = true, OptionalDesc = "0", Default = "0")] long networkByte)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Bitcoin.AddressFor(networkByte);
        }
        [NativeFunction("TestnetAddress", "Produces a Bitcoin testnet address.", "Blockchain.Bitcoin", "function-blockchain-bitcoin-TestnetAddress.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TestnetAddress(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Blockchain.Bitcoin.TestnetAddress();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBlockchainEthereum
    {
        #warning No implementation defined for method address
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBlockchainTezos
    {
        #warning No implementation defined for method account
        #warning No implementation defined for method block
        #warning No implementation defined for method contract
        #warning No implementation defined for method operation
        #warning No implementation defined for method public_key
        #warning No implementation defined for method secret_key
        #warning No implementation defined for method signature
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooks
    {
        [NativeFunction("Author", "Produces a random book author.", "Books", "function-books-Author.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Author(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Author();
        }
        [NativeFunction("Genre", "Produces a random genre.", "Books", "function-books-Genre.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Genre(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Genre();
        }
        [NativeFunction("Publisher", "Produces a random book publisher.", "Books", "function-books-Publisher.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Publisher(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Publisher();
        }
        [NativeFunction("Title", "Produces a random book title.", "Books", "function-books-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Title();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksBible
    {
        [NativeFunction("Character", "", "Books.Bible", "function-books-bible-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Bible.Character();
        }
        [NativeFunction("Location", "", "Books.Bible", "function-books-bible-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Bible.Location();
        }
        [NativeFunction("Quote", "", "Books.Bible", "function-books-bible-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Bible.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksCosmere
    {
        [NativeFunction("Allomancer", "Produces a random allomancer.", "Books.Cosmere", "function-books-cosmere-Allomancer.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Allomancer(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Allomancer();
        }
        [NativeFunction("Aon", "Produces a random aon.", "Books.Cosmere", "function-books-cosmere-Aon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Aon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Aon();
        }
        [NativeFunction("Feruchemist", "Produces a random feruchemist.", "Books.Cosmere", "function-books-cosmere-Feruchemist.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Feruchemist(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Feruchemist();
        }
        [NativeFunction("Herald", "Produces a random herald.", "Books.Cosmere", "function-books-cosmere-Herald.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Herald(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Herald();
        }
        [NativeFunction("KnightRadiant", "Produces a random knight radiant.", "Books.Cosmere", "function-books-cosmere-KnightRadiant.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string KnightRadiant(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.KnightRadiant();
        }
        [NativeFunction("Metal", "Produces a random metal.", "Books.Cosmere", "function-books-cosmere-Metal.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Metal(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Metal();
        }
        [NativeFunction("Shard", "Produces a random shard.", "Books.Cosmere", "function-books-cosmere-Shard.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Shard(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Shard();
        }
        [NativeFunction("ShardWorld", "Produces a random shard world.", "Books.Cosmere", "function-books-cosmere-ShardWorld.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ShardWorld(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.ShardWorld();
        }
        [NativeFunction("Spren", "Produces a random spren.", "Books.Cosmere", "function-books-cosmere-Spren.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Spren(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Spren();
        }
        [NativeFunction("Surge", "Produces a random surge.", "Books.Cosmere", "function-books-cosmere-Surge.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Surge(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Cosmere.Surge();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksCultureSeries
    {
        [NativeFunction("Book", "", "Books.CultureSeries", "function-books-cultureseries-Book.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Book(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.Book();
        }
        [NativeFunction("Civ", "", "Books.CultureSeries", "function-books-cultureseries-Civ.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Civ(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.Civ();
        }
        [NativeFunction("CultureShip", "", "Books.CultureSeries", "function-books-cultureseries-CultureShip.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CultureShip(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.CultureShip();
        }
        [NativeFunction("CultureShipClass", "", "Books.CultureSeries", "function-books-cultureseries-CultureShipClass.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CultureShipClass(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.CultureShipClass();
        }
        [NativeFunction("CultureShipClassAbv", "", "Books.CultureSeries", "function-books-cultureseries-CultureShipClassAbv.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CultureShipClassAbv(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.CultureShipClassAbv();
        }
        [NativeFunction("Planet", "", "Books.CultureSeries", "function-books-cultureseries-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.CultureSeries.Planet();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksDcComics
    {
        [NativeFunction("Hero", "Produces a hero name from DC Comics.", "Books.DcComics", "function-books-dccomics-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.DcComics.Hero();
        }
        [NativeFunction("Heroine", "Produces a heroine name from DC Comics.", "Books.DcComics", "function-books-dccomics-Heroine.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Heroine(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.DcComics.Heroine();
        }
        [NativeFunction("Name", "Produces a character name from DC Comics.", "Books.DcComics", "function-books-dccomics-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.DcComics.Name();
        }
        [NativeFunction("Title", "Produces a comic book title from DC Comics.", "Books.DcComics", "function-books-dccomics-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.DcComics.Title();
        }
        [NativeFunction("Villain", "Produces a villain name from DC Comics.", "Books.DcComics", "function-books-dccomics-Villain.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Villain(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.DcComics.Villain();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksDune
    {
        [NativeFunction("Character", "Produces the name of a character from Dune.", "Books.Dune", "function-books-dune-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Dune.Character();
        }
        [NativeFunction("City", "Produces the name of a city from Dune.", "Books.Dune", "function-books-dune-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Dune.City();
        }
        [NativeFunction("Planet", "Produces the name of a planet from Dune.", "Books.Dune", "function-books-dune-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Dune.Planet();
        }
        #warning No implementation defined for method quote
        #warning No implementation defined for method saying
        [NativeFunction("Title", "", "Books.Dune", "function-books-dune-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Dune.Title();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksLovecraft
    {
        [NativeFunction("Deity", "Produces the name of a deity.", "Books.Lovecraft", "function-books-lovecraft-Deity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Deity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Lovecraft.Deity();
        }
        [NativeFunction("Fhtagn", "", "Books.Lovecraft", "function-books-lovecraft-Fhtagn.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Fhtagn(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("number", "", IsOptional = true, OptionalDesc = "1", Default = "1")] long number
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Lovecraft.Fhtagn(number);
        }
        [NativeFunction("Location", "Produces the name of a location.", "Books.Lovecraft", "function-books-lovecraft-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Lovecraft.Location();
        }
        #warning No implementation defined for method paragraph
        #warning No implementation defined for method paragraph_by_chars
        #warning No implementation defined for method paragraphs
        #warning No implementation defined for method sentence
        #warning No implementation defined for method sentences
        [NativeFunction("Tome", "Produces the name of a tome.", "Books.Lovecraft", "function-books-lovecraft-Tome.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Tome(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Lovecraft.Tome();
        }
        #warning No implementation defined for method word
        #warning No implementation defined for method words
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksTheKingkillerChronicle
    {
        [NativeFunction("Book", "Produces the name of a The Kingkiller Chronicle book.", "Books.TheKingkillerChronicle", "function-books-thekingkillerchronicle-Book.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Book(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.TheKingkillerChronicle.Book();
        }
        [NativeFunction("Character", "Produces the name of a The Kingkiller Chronicle character.", "Books.TheKingkillerChronicle", "function-books-thekingkillerchronicle-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.TheKingkillerChronicle.Character();
        }
        [NativeFunction("Creature", "Produces the name of a The Kingkiller Chronicle creature.", "Books.TheKingkillerChronicle", "function-books-thekingkillerchronicle-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.TheKingkillerChronicle.Creature();
        }
        [NativeFunction("Location", "Produces the name of a The Kingkiller Chronicle location.", "Books.TheKingkillerChronicle", "function-books-thekingkillerchronicle-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.TheKingkillerChronicle.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterBooksTolkien
    {
        [NativeFunction("Character", "Produces a character from Tolkien's legendarium.\n                                <p>Produces a character from Tolkien’s legendarium</p>", "Books.Tolkien", "function-books-tolkien-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Tolkien.Character();
        }
        [NativeFunction("Location", "Produces a location from Tolkien's legendarium.\n                                <p>Produces a location from Tolkien’s legendarium</p>", "Books.Tolkien", "function-books-tolkien-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Tolkien.Location();
        }
        [NativeFunction("Poem", "Produces the name of a poem from Tolkien's legendarium.\n                                <p>Produces the name of a poem from Tolkien’s legendarium</p>", "Books.Tolkien", "function-books-tolkien-Poem.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Poem(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Tolkien.Poem();
        }
        [NativeFunction("Race", "Produces a race from Tolkien's legendarium.\n                                <p>Produces a race from Tolkien’s legendarium</p>", "Books.Tolkien", "function-books-tolkien-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Books.Tolkien.Race();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterChileRut
    {
        #warning No implementation defined for method check_digit
        #warning No implementation defined for method dv
        #warning Failed processing method format_rut : method has no name or return type.
        #warning No implementation defined for method full_rut
        #warning Failed processing method last_rut : method has no name or return type.
        #warning No implementation defined for method rut
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCoin
    {
        [NativeFunction("Flip", "Retrieves a face to a flipped coin.", "Coin", "function-coin-Flip.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Flip(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Coin.Flip();
        }
        [NativeFunction("Name", "Retrieves a random coin from any country.", "Coin", "function-coin-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Coin.Name();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerce
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceAppliance
    {
        [NativeFunction("Brand", "Produces the name of an appliance brand.", "Commerce.Appliance", "function-commerce-appliance-Brand.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Brand(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Appliance.Brand();
        }
        [NativeFunction("Equipment", "Produces the name of a type of appliance equipment.", "Commerce.Appliance", "function-commerce-appliance-Equipment.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Equipment(
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
            , [ArgumentProperty("digits", "", IsOptional = true, OptionalDesc = "10", Default = "10")] long digits
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.AccountNumber(digits);
        }
        [NativeFunction("BsbNumber", "Produces an Australian BSB (Bank-State-Branch) number.", "Commerce.Bank", "function-commerce-bank-BsbNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BsbNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.BsbNumber();
        }
        [NativeFunction("Iban", "Produces a bank iban number.", "Commerce.Bank", "function-commerce-bank-Iban.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Iban(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("countryCode", "", IsOptional = true, OptionalDesc = "'GB'", Default = "GB")] string countryCode
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.Iban(countryCode);
        }
        [NativeFunction("IbanCountryCode", "Produces the ISO 3166 code of a country that uses the IBAN system.", "Commerce.Bank", "function-commerce-bank-IbanCountryCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IbanCountryCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.IbanCountryCode();
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
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.RoutingNumber();
        }
        [NativeFunction("RoutingNumberWithFormat", "Produces a valid routing number.", "Commerce.Bank", "function-commerce-bank-RoutingNumberWithFormat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RoutingNumberWithFormat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.RoutingNumberWithFormat();
        }
        [NativeFunction("SwiftBic", "Produces a swift / bic number.", "Commerce.Bank", "function-commerce-bank-SwiftBic.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SwiftBic(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Bank.SwiftBic();
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
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Barcode.Ean13();
        }
        [NativeFunction("Ean8", "Returns a EAN 8 digit format barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Ean8.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ean8(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Barcode.Ean8();
        }
        [NativeFunction("GenerateBarcode", "Adds the check digit to the barcode", "Commerce.Barcode", "function-commerce-barcode-GenerateBarcode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "A complete numeric barcode including the check digit.")]
        public static string GenerateBarcode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("barcodeDigits", "")] string barcodeDigits)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Barcode.GenerateBarcode(barcodeDigits);
        }
        [NativeFunction("Isbn10", "Returns a 10 digit ISBN code as a barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Isbn10.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn10(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Barcode.Isbn10();
        }
        [NativeFunction("Isbn13", "Returns a 13 digit ISBN code as a barcode number with check digit ", "Commerce.Barcode", "function-commerce-barcode-Isbn13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Barcode.Isbn13();
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
        [NativeFunction("CreditCardExpiryDate", "Produces a credit card expiration date in the form MMYY.", "Commerce.Business", "function-commerce-business-CreditCardExpiryDate.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CreditCardExpiryDate(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("expiredRatio", "", IsOptional = true, OptionalDesc = "0", Default = "0")] double expiredRatio
            , [ArgumentProperty("separator", "", IsOptional = true, OptionalDesc = "'/'", Default = "/")] string separator)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Business.CreditCardExpiryDate(expiredRatio, separator);
        }
        [NativeFunction("CreditCardNumber", "Produces a credit card number.", "Commerce.Business", "function-commerce-business-CreditCardNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CreditCardNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Business.CreditCardNumber();
        }
        [NativeFunction("CreditCardType", "Produces a type of credit card.", "Commerce.Business", "function-commerce-business-CreditCardType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CreditCardType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Business.CreditCardType();
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
            , [ArgumentProperty("digits", "", IsOptional = true, OptionalDesc = "13", Default = "13")] long digits
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
            , [ArgumentProperty("digits", "", IsOptional = true, OptionalDesc = "10", Default = "10")] long digits
            , [ArgumentProperty("separator", "", IsOptional = true, OptionalDesc = "true", Default = "true")] bool separator
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Code.Isbn(digits, separator);
        }
        [NativeFunction("Isbn10", "Produces a random ISBN (International Standard Book Number) 10 digit code.", "Commerce.Code", "function-commerce-code-Isbn10.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn10(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("separator", "", IsOptional = true, OptionalDesc = "true", Default = "true")] bool separator)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Code.Isbn10(separator);
        }
        [NativeFunction("Isbn13", "Produces a random ISBN (International Standard Book Number) 13 digit code.", "Commerce.Code", "function-commerce-code-Isbn13.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Isbn13(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("separator", "", IsOptional = true, OptionalDesc = "true", Default = "true")] bool separator)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Commerce.Code.Isbn13(separator);
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
            , [ArgumentProperty("minAge", "", IsOptional = true, OptionalDesc = "18", Default = "18")] long minAge
            , [ArgumentProperty("maxAge", "", IsOptional = true, OptionalDesc = "65", Default = "65")] long maxAge
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
        [NativeFunction("Brand", "Produces a randomized string of a brand name.", "Commerce.CommerceRENAME", "function-commerce-commercerename-Brand.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Brand(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.Brand();
        }
        #warning Failed processing method categories : method has no name or return type.
        [NativeFunction("Color", "Produces a random color.", "Commerce.CommerceRENAME", "function-commerce-commercerename-Color.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Color(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.Color();
        }
        #warning No implementation defined for method department
        [NativeFunction("Material", "Produces a random material.", "Commerce.CommerceRENAME", "function-commerce-commercerename-Material.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Material(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.Material();
        }
        #warning Failed processing method merge_categories : method has no name or return type.
        #warning No implementation defined for method price
        [NativeFunction("ProductName", "Produces a random product name.", "Commerce.CommerceRENAME", "function-commerce-commercerename-ProductName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ProductName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.ProductName();
        }
        [NativeFunction("PromotionCode", "Produces a random promotion code.", "Commerce.CommerceRENAME", "function-commerce-commercerename-PromotionCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PromotionCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("digits", "", IsOptional = true, OptionalDesc = "6", Default = "6")] long digits
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CommerceRENAME.PromotionCode(digits);
        }
        [NativeFunction("Vendor", "Produces a randomized string of a vendor name.", "Commerce.CommerceRENAME", "function-commerce-commercerename-Vendor.png", AccessorType.Method)]
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
        #warning No implementation defined for method logo
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
    public partial class FakerAdapterCommerceCryptoCoin
    {
        #warning No implementation defined for method acronym
        [NativeFunction("CoinArray", "Produces a random crypto coin's name, acronym and logo in an array.", "Commerce.CryptoCoin", "function-commerce-cryptocoin-CoinArray.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static List<string> CoinArray(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.CryptoCoin.CoinArray();
        }
        #warning No implementation defined for method coin_hash
        #warning No implementation defined for method coin_name
        #warning No implementation defined for method url_logo
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceCurrency
    {
        [NativeFunction("Code", "Produces a currency code.", "Commerce.Currency", "function-commerce-currency-Code.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Code(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Currency.Code();
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
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Currency.Symbol();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCommerceFinance
    {
        [NativeFunction("CondominiumFiscalCode", "Returns a random condominium fiscal code.", "Commerce.Finance", "function-commerce-finance-CondominiumFiscalCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CondominiumFiscalCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("country", "", IsOptional = true, OptionalDesc = "'IT'", Default = "IT")] string country
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Finance.CondominiumFiscalCode(country);
        }
        [NativeFunction("CreditCard", "Produces a random credit card number.", "Commerce.Finance", "function-commerce-finance-CreditCard.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CreditCard(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("types", "")] string types
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Finance.CreditCard(types);
        }
        [NativeFunction("StockMarket", "Returns a randomly-selected stock market.", "Commerce.Finance", "function-commerce-finance-StockMarket.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StockMarket(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Finance.StockMarket();
        }
        [NativeFunction("Ticker", "Returns a randomly-selected stock ticker from a specified market.", "Commerce.Finance", "function-commerce-finance-Ticker.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ticker(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("markets", "")] string markets
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Finance.Ticker(markets);
        }
        [NativeFunction("VatNumber", "Produces a random vat number.", "Commerce.Finance", "function-commerce-finance-VatNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string VatNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("country", "", IsOptional = true, OptionalDesc = "'BR'", Default = "BR")] string country
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Commerce.Finance.VatNumber(country);
        }
        #warning Failed processing method vat_number_keys : method has no name or return type.
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
        #warning No implementation defined for method amount_between
        #warning Failed processing method calculate_weighted_sum : method has no name or return type.
        #warning No implementation defined for method creditor_reference
        #warning Failed processing method iban_checksum : method has no name or return type.
        #warning Failed processing method kidmod10 : method has no name or return type.
        #warning Failed processing method method_731 : method has no name or return type.
        #warning Failed processing method mod10_remainder : method has no name or return type.
        #warning No implementation defined for method reference
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
        #warning No implementation defined for method ccv
        #warning No implementation defined for method invalid_card
        #warning No implementation defined for method month
        #warning No implementation defined for method valid_card
        #warning No implementation defined for method valid_token
        #warning No implementation defined for method year
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
    public partial class FakerAdapterCreature
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCreatureAnimal
    {
        [NativeFunction("Name", "Produces a random animal name.", "Creature.Animal", "function-creature-animal-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Animal.Name();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCreatureBird
    {
        [NativeFunction("Adjective", "Produces a random adjective used to described birds.", "Creature.Bird", "function-creature-bird-Adjective.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Adjective(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.Adjective();
        }
        [NativeFunction("Anatomy", "Produces a random bird anatomy word.", "Creature.Bird", "function-creature-bird-Anatomy.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Anatomy(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.Anatomy();
        }
        [NativeFunction("AnatomyPastTense", "Produces a random, past tensed bird anatomy word.", "Creature.Bird", "function-creature-bird-AnatomyPastTense.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AnatomyPastTense(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.AnatomyPastTense();
        }
        [NativeFunction("Color", "Produces a random color word used in describing birds.", "Creature.Bird", "function-creature-bird-Color.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Color(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.Color();
        }
        [NativeFunction("CommonFamilyName", "Produces a random common family name of a bird.", "Creature.Bird", "function-creature-bird-CommonFamilyName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CommonFamilyName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.CommonFamilyName();
        }
        [NativeFunction("CommonName", "Produces a random common name for a bird.", "Creature.Bird", "function-creature-bird-CommonName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CommonName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("taxOrder", "", IsOptional = true, OptionalDesc = "nil")] string? taxOrder
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.CommonName(taxOrder);
        }
        [NativeFunction("EmotionalAdjective", "Produces a random emotional adjective NOT used to described birds ...but could be.\n                                <p>Produces a random emotional adjective NOT used to described birds …but could be</p>", "Creature.Bird", "function-creature-bird-EmotionalAdjective.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string EmotionalAdjective(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.EmotionalAdjective();
        }
        [NativeFunction("Geo", "Produces a random geographical word used in describing birds.", "Creature.Bird", "function-creature-bird-Geo.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Geo(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.Geo();
        }
        [NativeFunction("ImplausibleCommonName", "Produces a random and IMplausible common name for a bird.", "Creature.Bird", "function-creature-bird-ImplausibleCommonName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ImplausibleCommonName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.ImplausibleCommonName();
        }
        #warning No implementation defined for method order
        #warning No implementation defined for method order_with_common_name
        [NativeFunction("PlausibleCommonName", "Produces a random and plausible common name for a bird.", "Creature.Bird", "function-creature-bird-PlausibleCommonName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PlausibleCommonName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.PlausibleCommonName();
        }
        [NativeFunction("SillyAdjective", "Produces a random adjective NOT used to described birds ...but probably shouldn't.\n                                <p>Produces a random adjective NOT used to described birds …but probably shouldn’t</p>", "Creature.Bird", "function-creature-bird-SillyAdjective.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SillyAdjective(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Bird.SillyAdjective();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCreatureCat
    {
        [NativeFunction("Breed", "Produces a random cat breed.", "Creature.Cat", "function-creature-cat-Breed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Breed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Cat.Breed();
        }
        [NativeFunction("Name", "Produces a random name for a cat.", "Creature.Cat", "function-creature-cat-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Cat.Name();
        }
        [NativeFunction("Registry", "Produces a random cat breed registry.", "Creature.Cat", "function-creature-cat-Registry.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Registry(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Cat.Registry();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCreatureDog
    {
        [NativeFunction("Age", "Produces a random dog age.", "Creature.Dog", "function-creature-dog-Age.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Age(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.Age();
        }
        [NativeFunction("Breed", "Produces a random dog breed.", "Creature.Dog", "function-creature-dog-Breed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Breed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.Breed();
        }
        [NativeFunction("CoatLength", "Produces a random coat length.", "Creature.Dog", "function-creature-dog-CoatLength.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CoatLength(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.CoatLength();
        }
        #warning No implementation defined for method gender
        [NativeFunction("MemePhrase", "Produces a random dog meme phrase.", "Creature.Dog", "function-creature-dog-MemePhrase.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MemePhrase(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.MemePhrase();
        }
        [NativeFunction("Name", "Produces a random name for a dog.", "Creature.Dog", "function-creature-dog-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.Name();
        }
        [NativeFunction("Size", "Produces a random size of a dog.", "Creature.Dog", "function-creature-dog-Size.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Size(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.Size();
        }
        [NativeFunction("Sound", "Produces a random sound made by a dog.", "Creature.Dog", "function-creature-dog-Sound.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sound(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Dog.Sound();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterCreatureHorse
    {
        [NativeFunction("Breed", "Produces a random horse breed.", "Creature.Horse", "function-creature-horse-Breed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Breed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Horse.Breed();
        }
        [NativeFunction("Name", "Produces a random name for a horse.", "Creature.Horse", "function-creature-horse-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Creature.Horse.Name();
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
        [NativeFunction("Alpha", "Produces a random string of alphabetic characters (no digits).", "Data.Alphanumeric", "function-data-alphanumeric-Alpha.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Alpha(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("number", "", IsOptional = true, OptionalDesc = "32", Default = "32")] long number)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Data.Alphanumeric.Alpha(number);
        }
        [NativeFunction("AlphaNumeric", "Produces a random string of alphanumeric characters.", "Data.Alphanumeric", "function-data-alphanumeric-AlphaNumeric.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AlphaNumeric(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("number", "", IsOptional = true, OptionalDesc = "32", Default = "32")] long number)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Data.Alphanumeric.AlphaNumeric(number);
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
    public partial class FakerAdapterDataColor
    {
        [NativeFunction("ColorName", "Produces the name of a color.", "Data.Color", "function-data-color-ColorName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ColorName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Color.ColorName();
        }
        #warning No implementation defined for method hex_color
        #warning No implementation defined for method hsl_color
        #warning No implementation defined for method hsl_to_hex
        #warning No implementation defined for method hsla_color
        #warning No implementation defined for method rgb_color
        #warning Failed processing method single_rgb_color : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataCrypto
    {
        #warning No implementation defined for method md5
        #warning No implementation defined for method sha1
        #warning No implementation defined for method sha256
        #warning No implementation defined for method sha512
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataDate
    {
        #warning No implementation defined for method backward
        #warning No implementation defined for method between
        #warning No implementation defined for method between_except
        #warning No implementation defined for method birthday
        #warning Failed processing method birthday_date : method has no name or return type.
        #warning No implementation defined for method forward
        #warning Failed processing method get_date_object : method has no name or return type.
        #warning No implementation defined for method in_date_period
        #warning No implementation defined for method on_day_of_week_between
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDataLorem
    {
        [NativeFunction("LocalePeriod", "Gets a '.' character in the current locale.\nprivate needed for Japanese", "Data.Lorem", "function-data-lorem-LocalePeriod.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LocalePeriod(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.LocalePeriod();
        }
        [NativeFunction("LocaleQuestionMark", "Gets a '?' character in the current locale\nprivate needed for Japanese", "Data.Lorem", "function-data-lorem-LocaleQuestionMark.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LocaleQuestionMark(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Data.Lorem.LocaleQuestionMark();
        }
        [NativeFunction("LocaleSpace", "Gets a 'space' character in the current locale.\nprivate needed for Japanese", "Data.Lorem", "function-data-lorem-LocaleSpace.png", AccessorType.Method)]
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
        #warning No implementation defined for method char_space_ratio
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
        #warning No implementation defined for method select_a
        #warning No implementation defined for method space_or_utf8_char
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
        #warning No implementation defined for method utf8character
        #warning No implementation defined for method utf8string
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
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDefence
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDefenceMilitary
    {
        [NativeFunction("AirForceRank", "Produces a rank in the U.S.\n                            <p>Air Force.</p>", "Defence.Military", "function-defence-military-AirForceRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AirForceRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.AirForceRank();
        }
        [NativeFunction("ArmyRank", "Produces a rank in the U.S.\n                            <p>Army.</p>", "Defence.Military", "function-defence-military-ArmyRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ArmyRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.ArmyRank();
        }
        [NativeFunction("CoastGuardRank", "Produces a rank in the U.S.\n                            <p>Coast Guard</p>", "Defence.Military", "function-defence-military-CoastGuardRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CoastGuardRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.CoastGuardRank();
        }
        [NativeFunction("DodPaygrade", "Produces a U.S.\n                            <p>Department of Defense Paygrade.</p>", "Defence.Military", "function-defence-military-DodPaygrade.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DodPaygrade(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.DodPaygrade();
        }
        [NativeFunction("MarinesRank", "Produces a rank in the U.S.\n                            <p>Marines.</p>", "Defence.Military", "function-defence-military-MarinesRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MarinesRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.MarinesRank();
        }
        [NativeFunction("NavyRank", "Produces a rank in the U.S.\n                            <p>Navy.</p>", "Defence.Military", "function-defence-military-NavyRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NavyRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.NavyRank();
        }
        [NativeFunction("SpaceForceRank", "Produces a rank in the U.S.\n                            <p>Space Force.</p>", "Defence.Military", "function-defence-military-SpaceForceRank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SpaceForceRank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.Military.SpaceForceRank();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterDefenceNatoPhoneticAlphabet
    {
        [NativeFunction("CodeWord", "Produces a code word from the NATO phonetic alphabet.", "Defence.NatoPhoneticAlphabet", "function-defence-natophoneticalphabet-CodeWord.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CodeWord(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Defence.NatoPhoneticAlphabet.CodeWord();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterEducation
    {
        [NativeFunction("Campus", "Produces a campus name.", "Education", "function-education-Campus.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Campus(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.Campus();
        }
        [NativeFunction("CourseName", "Produces a course name.", "Education", "function-education-CourseName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CourseName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.CourseName();
        }
        [NativeFunction("Degree", "Produces a university degree.", "Education", "function-education-Degree.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Degree(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.Degree();
        }
        [NativeFunction("PrimarySchool", "Produces a primary school.", "Education", "function-education-PrimarySchool.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PrimarySchool(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.PrimarySchool();
        }
        [NativeFunction("SecondarySchool", "Produces a secondary school.", "Education", "function-education-SecondarySchool.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SecondarySchool(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.SecondarySchool();
        }
        [NativeFunction("Subject", "Produces a university subject.", "Education", "function-education-Subject.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Subject(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.Subject();
        }
        [NativeFunction("University", "Produces a university name.", "Education", "function-education-University.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string University(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Education.University();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterFoodAndDrink
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterFoodAndDrinkBeer
    {
        [NativeFunction("Alcohol", "Produces a random beer alcohol percentage.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Alcohol.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Alcohol(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).FoodAndDrink.Beer.Alcohol();
        }
        [NativeFunction("Blg", "Produces a random beer blg level.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Blg.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Blg(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).FoodAndDrink.Beer.Blg();
        }
        [NativeFunction("Hop", "Produces a random beer hops.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Hop.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hop(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Beer.Hop();
        }
        [NativeFunction("Ibu", "Produces a random beer IBU.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Ibu.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ibu(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).FoodAndDrink.Beer.Ibu();
        }
        [NativeFunction("Malts", "Produces a random beer malt.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Malts.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Malts(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Beer.Malts();
        }
        [NativeFunction("Name", "Produces a random beer name.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Beer.Name();
        }
        [NativeFunction("Style", "Produces a random beer style.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Style.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Style(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Beer.Style();
        }
        [NativeFunction("Yeast", "Produces a random beer yeast.", "FoodAndDrink.Beer", "function-foodanddrink-beer-Yeast.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Yeast(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Beer.Yeast();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterFoodAndDrinkCoffee
    {
        [NativeFunction("BlendName", "Produces a random blend name.", "FoodAndDrink.Coffee", "function-foodanddrink-coffee-BlendName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BlendName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Coffee.BlendName();
        }
        [NativeFunction("Intensifier", "Produces a random coffee taste intensity.", "FoodAndDrink.Coffee", "function-foodanddrink-coffee-Intensifier.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Intensifier(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Coffee.Intensifier();
        }
        [NativeFunction("Notes", "Produces a string containing a random description of a coffee's taste.", "FoodAndDrink.Coffee", "function-foodanddrink-coffee-Notes.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Notes(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Coffee.Notes();
        }
        [NativeFunction("Origin", "Produces a random coffee origin place.", "FoodAndDrink.Coffee", "function-foodanddrink-coffee-Origin.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Origin(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Coffee.Origin();
        }
        #warning Failed processing method search_format : method has no name or return type.
        [NativeFunction("Variety", "Produces a random coffee variety.", "FoodAndDrink.Coffee", "function-foodanddrink-coffee-Variety.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Variety(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Coffee.Variety();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterFoodAndDrinkFood
    {
        [NativeFunction("Allergen", "Retrieves an allergen.", "FoodAndDrink.Food", "function-foodanddrink-food-Allergen.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Allergen(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Allergen();
        }
        [NativeFunction("Description", "Retrieves a description about some dish.", "FoodAndDrink.Food", "function-foodanddrink-food-Description.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Description(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Description();
        }
        [NativeFunction("Dish", "Retrieves a typical dish from each country.", "FoodAndDrink.Food", "function-foodanddrink-food-Dish.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Dish(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Dish();
        }
        [NativeFunction("EthnicCategory", "Retrieves ethnic category.", "FoodAndDrink.Food", "function-foodanddrink-food-EthnicCategory.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string EthnicCategory(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.EthnicCategory();
        }
        [NativeFunction("Fruits", "Retrieves a fruit.", "FoodAndDrink.Food", "function-foodanddrink-food-Fruits.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Fruits(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Fruits();
        }
        [NativeFunction("Ingredient", "Retrieves an ingredient.", "FoodAndDrink.Food", "function-foodanddrink-food-Ingredient.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ingredient(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Ingredient();
        }
        [NativeFunction("Measurement", "Retrieves cooking measures.", "FoodAndDrink.Food", "function-foodanddrink-food-Measurement.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Measurement(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Measurement();
        }
        [NativeFunction("MetricMeasurement", "Retrieves metric measurements.", "FoodAndDrink.Food", "function-foodanddrink-food-MetricMeasurement.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MetricMeasurement(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.MetricMeasurement();
        }
        [NativeFunction("Spice", "Retrieves some random spice.", "FoodAndDrink.Food", "function-foodanddrink-food-Spice.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Spice(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Spice();
        }
        [NativeFunction("Vegetables", "Retrieves a vegetable.", "FoodAndDrink.Food", "function-foodanddrink-food-Vegetables.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vegetables(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Food.Vegetables();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterFoodAndDrinkTea
    {
        #warning No implementation defined for method type
        [NativeFunction("Variety", "Produces a random variety or blend of tea.", "FoodAndDrink.Tea", "function-foodanddrink-tea-Variety.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Variety(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("type", "", IsOptional = true, OptionalDesc = "nil")] string? type
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).FoodAndDrink.Tea.Variety(type);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGame
    {
        [NativeFunction("Genre", "Produces the name of a video game genre.", "Game", "function-game-Genre.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Genre(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Genre();
        }
        [NativeFunction("Platform", "Produces the name of a video game console or platform.", "Game", "function-game-Platform.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Platform(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Platform();
        }
        [NativeFunction("Title", "Produces the name of a video game.", "Game", "function-game-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Title();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameClashOfClans
    {
        [NativeFunction("DefensiveBuilding", "Produces the name of a defensive building from Clash Of Clans.", "Game.ClashOfClans", "function-game-clashofclans-DefensiveBuilding.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DefensiveBuilding(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ClashOfClans.DefensiveBuilding();
        }
        [NativeFunction("Rank", "Produces the name of a rank from Clash Of Clans.", "Game.ClashOfClans", "function-game-clashofclans-Rank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Rank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ClashOfClans.Rank();
        }
        [NativeFunction("Troop", "Produces the name of a troop from Clash of Clans.", "Game.ClashOfClans", "function-game-clashofclans-Troop.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Troop(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ClashOfClans.Troop();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameControl
    {
        [NativeFunction("AlteredItem", "Produces the name of an Altered Item.", "Game.Control", "function-game-control-AlteredItem.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AlteredItem(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.AlteredItem();
        }
        [NativeFunction("AlteredWorldEvent", "Produces the location of an Altered World Event (AWE).", "Game.Control", "function-game-control-AlteredWorldEvent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AlteredWorldEvent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.AlteredWorldEvent();
        }
        [NativeFunction("Character", "Produces the name of a character from Control.", "Game.Control", "function-game-control-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.Character();
        }
        [NativeFunction("Hiss", "Produces a line from the Hiss incantation.", "Game.Control", "function-game-control-Hiss.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hiss(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.Hiss();
        }
        [NativeFunction("Location", "Produces the name of a location from Control.", "Game.Control", "function-game-control-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.Location();
        }
        [NativeFunction("ObjectOfPower", "Produces the name of an Object of Power (OoP).", "Game.Control", "function-game-control-ObjectOfPower.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ObjectOfPower(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.ObjectOfPower();
        }
        [NativeFunction("Quote", "Produces a quote from Control.", "Game.Control", "function-game-control-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.Quote();
        }
        [NativeFunction("TheBoard", "< Produces a line/quote/message from The Board >.\n                                <p>&lt; Produces a line/quote/message from The Board &gt;</p>", "Game.Control", "function-game-control-TheBoard.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TheBoard(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Control.TheBoard();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameDnD
    {
        [NativeFunction("Alignment", "Produces the name of an alignment from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-Alignment.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Alignment(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Alignment();
        }
        [NativeFunction("Background", "Produces the name of a background from Dungeons and Dragons (PHB).", "Game.DnD", "function-game-dnd-Background.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Background(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Background();
        }
        [NativeFunction("City", "Produces the name of a city from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.City();
        }
        [NativeFunction("FirstName", "Produces the first name of a character or monster from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-FirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.FirstName();
        }
        [NativeFunction("Klass", "Produces the name of a class from Dungeons and Dragons (PHB).", "Game.DnD", "function-game-dnd-Klass.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Klass(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Klass();
        }
        [NativeFunction("Language", "Produces the name of a language from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-Language.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Language(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Language();
        }
        [NativeFunction("LastName", "Produces a last name from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-LastName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LastName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.LastName();
        }
        [NativeFunction("MeleeWeapon", "Produces the name of a melee weapon from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-MeleeWeapon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MeleeWeapon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.MeleeWeapon();
        }
        [NativeFunction("Monster", "Produces the name of a monster from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-Monster.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Monster(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Monster();
        }
        [NativeFunction("Name", "Produces a full name from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Name();
        }
        [NativeFunction("Race", "Produces the name of a race from Dungeons and Dragons (PHB).", "Game.DnD", "function-game-dnd-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.Race();
        }
        [NativeFunction("RangedWeapon", "Produces the name of a ranged weapon from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-RangedWeapon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RangedWeapon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.RangedWeapon();
        }
        [NativeFunction("TitleName", "Produces a last name from Dungeons and Dragons.", "Game.DnD", "function-game-dnd-TitleName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TitleName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.DnD.TitleName();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameDota
    {
        [NativeFunction("Building", "Produces the name of a building from Dota.", "Game.Dota", "function-game-dota-Building.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Building(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Building();
        }
        [NativeFunction("Hero", "Produces the name of a hero from Dota.", "Game.Dota", "function-game-dota-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Hero();
        }
        [NativeFunction("Item", "Produces the name of an item from Dota.", "Game.Dota", "function-game-dota-Item.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Item(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Item();
        }
        [NativeFunction("Player", "Produces the name of a professional Dota player.", "Game.Dota", "function-game-dota-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Player();
        }
        [NativeFunction("Quote", "Produces the name of a hero from Dota.", "Game.Dota", "function-game-dota-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("hero", "", IsOptional = true, OptionalDesc = "'abaddon'", Default = "abaddon")] string hero
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Quote(hero);
        }
        [NativeFunction("Team", "Produces the name of a professional Dota team.", "Game.Dota", "function-game-dota-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Dota.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameElderScrolls
    {
        [NativeFunction("City", "Produces the name of a city from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.City();
        }
        [NativeFunction("Creature", "Produces the name of a creature from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Creature();
        }
        [NativeFunction("Dragon", "Produces the name of a dragon from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Dragon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Dragon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Dragon();
        }
        [NativeFunction("FirstName", "Produces a first name from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-FirstName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FirstName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.FirstName();
        }
        [NativeFunction("Jewelry", "Produces a weapon from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Jewelry.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Jewelry(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Jewelry();
        }
        [NativeFunction("LastName", "Produces a last name from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-LastName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LastName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.LastName();
        }
        [NativeFunction("Name", "Produces a randomly generated name from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Name();
        }
        [NativeFunction("Race", "Produces the name of a race from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Race();
        }
        [NativeFunction("Region", "Produces the name of a region from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Region.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Region(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Region();
        }
        [NativeFunction("Weapon", "Produces a weapon from the Elder Scrolls universe.", "Game.ElderScrolls", "function-game-elderscrolls-Weapon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Weapon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.ElderScrolls.Weapon();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameFallout
    {
        [NativeFunction("Character", "Produces the name of a character from the Fallout games.", "Game.Fallout", "function-game-fallout-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Fallout.Character();
        }
        [NativeFunction("Faction", "Produces the name of a faction from the Fallout games.", "Game.Fallout", "function-game-fallout-Faction.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Faction(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Fallout.Faction();
        }
        [NativeFunction("Location", "Produces the name of a location from the Fallout games.", "Game.Fallout", "function-game-fallout-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Fallout.Location();
        }
        [NativeFunction("Quote", "Produces a quote from the Fallout games.", "Game.Fallout", "function-game-fallout-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Fallout.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameFinalFantasyXIV
    {
        [NativeFunction("Character", "Produces the name of a character from FFXIV.", "Game.FinalFantasyXIV", "function-game-finalfantasyxiv-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.FinalFantasyXIV.Character();
        }
        [NativeFunction("DataCenter", "Produces a data center from Final Fantasy XIV.", "Game.FinalFantasyXIV", "function-game-finalfantasyxiv-DataCenter.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DataCenter(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.FinalFantasyXIV.DataCenter();
        }
        [NativeFunction("Job", "Produces a job name from Final Fantasy XIV.\n                                <p>Either a battle or non-battle playable job.</p>", "Game.FinalFantasyXIV", "function-game-finalfantasyxiv-Job.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Job(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.FinalFantasyXIV.Job();
        }
        [NativeFunction("Race", "Produces the name of a playable race from Final Fantasy XIV.", "Game.FinalFantasyXIV", "function-game-finalfantasyxiv-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.FinalFantasyXIV.Race();
        }
        [NativeFunction("Zone", "Produces a geographical zone from Final Fantasy XIV.", "Game.FinalFantasyXIV", "function-game-finalfantasyxiv-Zone.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Zone(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.FinalFantasyXIV.Zone();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameHalfLife
    {
        [NativeFunction("Character", "Produces the name of a character from the Half-Life games.", "Game.HalfLife", "function-game-halflife-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HalfLife.Character();
        }
        [NativeFunction("Enemy", "Produces the name of an enemy from the Half-Life games.", "Game.HalfLife", "function-game-halflife-Enemy.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Enemy(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HalfLife.Enemy();
        }
        [NativeFunction("Location", "Produces the name of a location from the Half-Life games.", "Game.HalfLife", "function-game-halflife-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HalfLife.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameHeroes
    {
        [NativeFunction("Artifact", "Produces the name of an artifact from Heroes 3.", "Game.Heroes", "function-game-heroes-Artifact.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Artifact(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Heroes.Artifact();
        }
        [NativeFunction("Klass", "Produces the name of a class from Heroes 3.", "Game.Heroes", "function-game-heroes-Klass.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Klass(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Heroes.Klass();
        }
        [NativeFunction("Name", "Produces the name of a hero from Heroes 3.", "Game.Heroes", "function-game-heroes-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Heroes.Name();
        }
        [NativeFunction("Specialty", "Produces the name of a specialty from Heroes 3.", "Game.Heroes", "function-game-heroes-Specialty.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Specialty(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Heroes.Specialty();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameHeroesOfTheStorm
    {
        [NativeFunction("Battleground", "Produces a battleground from Heroes of the Storm.", "Game.HeroesOfTheStorm", "function-game-heroesofthestorm-Battleground.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Battleground(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HeroesOfTheStorm.Battleground();
        }
        #warning No implementation defined for method class
        [NativeFunction("ClassName", "Produces a class name from Heroes of the Storm.", "Game.HeroesOfTheStorm", "function-game-heroesofthestorm-ClassName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ClassName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HeroesOfTheStorm.ClassName();
        }
        [NativeFunction("Hero", "Produces a hero from Heroes of the Storm.", "Game.HeroesOfTheStorm", "function-game-heroesofthestorm-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HeroesOfTheStorm.Hero();
        }
        [NativeFunction("Quote", "Produces a quote from Heroes of the Storm.", "Game.HeroesOfTheStorm", "function-game-heroesofthestorm-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.HeroesOfTheStorm.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameLeagueOfLegends
    {
        [NativeFunction("Champion", "Produces the name of a champion from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-Champion.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Champion(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.Champion();
        }
        [NativeFunction("Location", "Produces a location from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.Location();
        }
        [NativeFunction("Masteries", "Produces a mastery from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-Masteries.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Masteries(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.Masteries();
        }
        [NativeFunction("Quote", "Produces a quote from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.Quote();
        }
        [NativeFunction("Rank", "Produces a rank from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-Rank.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Rank(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.Rank();
        }
        [NativeFunction("SummonerSpell", "Produces a summoner spell from League of Legends.", "Game.LeagueOfLegends", "function-game-leagueoflegends-SummonerSpell.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SummonerSpell(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.LeagueOfLegends.SummonerSpell();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameMinecraft
    {
        [NativeFunction("Achievement", "Produces the name of an achievement from Minecraft.", "Game.Minecraft", "function-game-minecraft-Achievement.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Achievement(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Achievement();
        }
        [NativeFunction("Biome", "Produces the name of a biome from Minecraft.", "Game.Minecraft", "function-game-minecraft-Biome.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Biome(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Biome();
        }
        [NativeFunction("Block", "Produces the name of a block from Minecraft.", "Game.Minecraft", "function-game-minecraft-Block.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Block(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Block();
        }
        [NativeFunction("Enchantment", "Produces the name of a enchantment from Minecraft.", "Game.Minecraft", "function-game-minecraft-Enchantment.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Enchantment(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Enchantment();
        }
        [NativeFunction("GameMode", "Produces the name of a game mode from Minecraft.", "Game.Minecraft", "function-game-minecraft-GameMode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string GameMode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.GameMode();
        }
        [NativeFunction("Item", "Produces the name of an item from Minecraft.", "Game.Minecraft", "function-game-minecraft-Item.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Item(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Item();
        }
        [NativeFunction("Mob", "Produces the name of a mob from Minecraft.", "Game.Minecraft", "function-game-minecraft-Mob.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Mob(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.Mob();
        }
        [NativeFunction("StatusEffect", "Produces the name of a status effect from Minecraft.", "Game.Minecraft", "function-game-minecraft-StatusEffect.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StatusEffect(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Minecraft.StatusEffect();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameMyst
    {
        [NativeFunction("Age", "Produces the name of an age from Myst.", "Game.Myst", "function-game-myst-Age.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Age(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Myst.Age();
        }
        [NativeFunction("Character", "Produces the name of a character from Myst.", "Game.Myst", "function-game-myst-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Myst.Character();
        }
        [NativeFunction("Creature", "Produces the name of a creature from Myst.", "Game.Myst", "function-game-myst-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Myst.Creature();
        }
        [NativeFunction("Game", "Produces the name of a game from the Myst series.", "Game.Myst", "function-game-myst-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Myst.Game();
        }
        [NativeFunction("Quote", "Produces a quote from Myst.", "Game.Myst", "function-game-myst-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Myst.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameOverwatch
    {
        [NativeFunction("Hero", "Produces the name of a hero from Overwatch.", "Game.Overwatch", "function-game-overwatch-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Overwatch.Hero();
        }
        [NativeFunction("Location", "Produces the name of a location from Overwatch.", "Game.Overwatch", "function-game-overwatch-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Overwatch.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Overwatch.", "Game.Overwatch", "function-game-overwatch-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Overwatch.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGamePokemon
    {
        [NativeFunction("Location", "Produces a location from Pokemon.", "Game.Pokemon", "function-game-pokemon-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Pokemon.Location();
        }
        [NativeFunction("Move", "Produces a move from Pokemon.", "Game.Pokemon", "function-game-pokemon-Move.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Move(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Pokemon.Move();
        }
        [NativeFunction("Name", "Produces the name of a Pokemon.", "Game.Pokemon", "function-game-pokemon-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Pokemon.Name();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameSonicTheHedgehog
    {
        [NativeFunction("Character", "Produces the name of a character from Sonic the Hedgehog.", "Game.SonicTheHedgehog", "function-game-sonicthehedgehog-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SonicTheHedgehog.Character();
        }
        [NativeFunction("Game", "Produces the name of a game from the Sonic the Hedgehog series.", "Game.SonicTheHedgehog", "function-game-sonicthehedgehog-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SonicTheHedgehog.Game();
        }
        [NativeFunction("Zone", "Produces the name of a zone from Sonic the Hedgehog.", "Game.SonicTheHedgehog", "function-game-sonicthehedgehog-Zone.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Zone(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SonicTheHedgehog.Zone();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameStreetFighter
    {
        [NativeFunction("Character", "Produces the name of a playable character from Street Fighter.", "Game.StreetFighter", "function-game-streetfighter-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.StreetFighter.Character();
        }
        [NativeFunction("Move", "Produces the name of a move from Street Fighter.", "Game.StreetFighter", "function-game-streetfighter-Move.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Move(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.StreetFighter.Move();
        }
        [NativeFunction("Quote", "Produces a quote from Street Fighter.", "Game.StreetFighter", "function-game-streetfighter-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.StreetFighter.Quote();
        }
        [NativeFunction("Stage", "Produces the name of a stage from Street Fighter.", "Game.StreetFighter", "function-game-streetfighter-Stage.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Stage(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.StreetFighter.Stage();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameSuperMario
    {
        [NativeFunction("Character", "Produces the name of a Super Mario character.", "Game.SuperMario", "function-game-supermario-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SuperMario.Character();
        }
        [NativeFunction("Game", "Produces the name of a Super Mario game.", "Game.SuperMario", "function-game-supermario-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SuperMario.Game();
        }
        [NativeFunction("Location", "Produces the name of a Super Mario location.", "Game.SuperMario", "function-game-supermario-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SuperMario.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameSuperSmashBros
    {
        [NativeFunction("Fighter", "Produces the name of a fighter from the Smash Bros games.", "Game.SuperSmashBros", "function-game-supersmashbros-Fighter.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Fighter(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SuperSmashBros.Fighter();
        }
        [NativeFunction("Stage", "Produces the name of a stage from the Smash Bros games.", "Game.SuperSmashBros", "function-game-supersmashbros-Stage.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Stage(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.SuperSmashBros.Stage();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameTarkov
    {
        [NativeFunction("Boss", "Produces a random boss from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Boss.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Boss(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Boss();
        }
        [NativeFunction("Faction", "Produces a random faction from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Faction.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Faction(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Faction();
        }
        [NativeFunction("FenceQuest", "Produces a random quest from Fence from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-FenceQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FenceQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.FenceQuest();
        }
        [NativeFunction("Item", "Produces a random item from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Item.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Item(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Item();
        }
        [NativeFunction("JaegerQuest", "Produces a random quest from Jaeger from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-JaegerQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string JaegerQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.JaegerQuest();
        }
        [NativeFunction("Location", "Produces a random location from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Location();
        }
        [NativeFunction("MechanicQuest", "Produces a random quest from Mechanic from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-MechanicQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MechanicQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.MechanicQuest();
        }
        [NativeFunction("PeacekeeperQuest", "Produces a random quest from Peacekeeper from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-PeacekeeperQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PeacekeeperQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.PeacekeeperQuest();
        }
        [NativeFunction("PraporQuest", "Produces a random quest from Prapor from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-PraporQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PraporQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.PraporQuest();
        }
        [NativeFunction("Quest", "Produces a random quest from a random trader from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Quest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Quest();
        }
        [NativeFunction("RagmanQuest", "Produces a random quest from Ragman from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-RagmanQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RagmanQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.RagmanQuest();
        }
        [NativeFunction("SkierQuest", "Produces a random quest from Skier from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-SkierQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SkierQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.SkierQuest();
        }
        [NativeFunction("TherapistQuest", "Produces a random quest from Therapist from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-TherapistQuest.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TherapistQuest(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.TherapistQuest();
        }
        [NativeFunction("Trader", "Produces a random trader from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Trader.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Trader(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Trader();
        }
        [NativeFunction("Weapon", "Produces a random weapon from Escape from Tarkov.", "Game.Tarkov", "function-game-tarkov-Weapon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Weapon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Tarkov.Weapon();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameTouhou
    {
        [NativeFunction("Character", "Produces the name of a character from the Touhou games.", "Game.Touhou", "function-game-touhou-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Touhou.Character();
        }
        [NativeFunction("Game", "Produces the name of a Touhou game.", "Game.Touhou", "function-game-touhou-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Touhou.Game();
        }
        [NativeFunction("Location", "Produces the name of a location from the Touhou games.", "Game.Touhou", "function-game-touhou-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Touhou.Location();
        }
        [NativeFunction("Song", "Produces the name of a song from the Touhou games.", "Game.Touhou", "function-game-touhou-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Touhou.Song();
        }
        [NativeFunction("SpellCard", "Produces the name of a spell card from the Touhou games.", "Game.Touhou", "function-game-touhou-SpellCard.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SpellCard(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Touhou.SpellCard();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameWarhammerFantasy
    {
        [NativeFunction("Creature", "Produces a creature from the Warhammer Fantasy setting.", "Game.WarhammerFantasy", "function-game-warhammerfantasy-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WarhammerFantasy.Creature();
        }
        [NativeFunction("Faction", "Produces a faction from the Warhammer Fantasy setting.", "Game.WarhammerFantasy", "function-game-warhammerfantasy-Faction.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Faction(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WarhammerFantasy.Faction();
        }
        [NativeFunction("Hero", "Produces the name of a hero from the Warhammer Fantasy setting.", "Game.WarhammerFantasy", "function-game-warhammerfantasy-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WarhammerFantasy.Hero();
        }
        [NativeFunction("Location", "Produces a location from the Warhammer Fantasy setting.", "Game.WarhammerFantasy", "function-game-warhammerfantasy-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WarhammerFantasy.Location();
        }
        [NativeFunction("Quote", "Produces a quote from the Warhammer Fantasy setting.", "Game.WarhammerFantasy", "function-game-warhammerfantasy-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WarhammerFantasy.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameWitcher
    {
        [NativeFunction("Book", "Produces the name of a book from The Witcher.", "Game.Witcher", "function-game-witcher-Book.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Book(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Book();
        }
        [NativeFunction("Character", "Produces the name of a character from The Witcher.", "Game.Witcher", "function-game-witcher-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Character();
        }
        [NativeFunction("Location", "Produces the name of a location from The Witcher.", "Game.Witcher", "function-game-witcher-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Location();
        }
        [NativeFunction("Monster", "Produces the name of a monster from The Witcher.", "Game.Witcher", "function-game-witcher-Monster.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Monster(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Monster();
        }
        [NativeFunction("Potion", "Produces the name of a potion from The Witcher.", "Game.Witcher", "function-game-witcher-Potion.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Potion(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Potion();
        }
        [NativeFunction("Quote", "Produces a quote from The Witcher.", "Game.Witcher", "function-game-witcher-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Quote();
        }
        [NativeFunction("School", "Produces the name of a school from The Witcher.", "Game.Witcher", "function-game-witcher-School.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string School(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.School();
        }
        [NativeFunction("Sign", "Produces the name of a sign from The Witcher.", "Game.Witcher", "function-game-witcher-Sign.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sign(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Sign();
        }
        [NativeFunction("Witcher", "Produces the name of a witcher from The Witcher.", "Game.Witcher", "function-game-witcher-Witcher.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Witcher(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Witcher.Witcher();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameWorldOfWarcraft
    {
        [NativeFunction("ClassName", "Produces a class name from World of Warcraft.", "Game.WorldOfWarcraft", "function-game-worldofwarcraft-ClassName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ClassName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WorldOfWarcraft.ClassName();
        }
        [NativeFunction("Hero", "Produces the name of a hero from World of Warcraft.", "Game.WorldOfWarcraft", "function-game-worldofwarcraft-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WorldOfWarcraft.Hero();
        }
        [NativeFunction("Quote", "Produces a quote from World of Warcraft.", "Game.WorldOfWarcraft", "function-game-worldofwarcraft-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WorldOfWarcraft.Quote();
        }
        [NativeFunction("Race", "Produces the name of a race from World of Warcraft.", "Game.WorldOfWarcraft", "function-game-worldofwarcraft-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.WorldOfWarcraft.Race();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterGameZelda
    {
        [NativeFunction("Character", "Produces the name of a character from the Legend of Zelda games.", "Game.Zelda", "function-game-zelda-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Zelda.Character();
        }
        [NativeFunction("Game", "Produces the name of a Legend of Zelda game.", "Game.Zelda", "function-game-zelda-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Zelda.Game();
        }
        [NativeFunction("Item", "Produces the name of an item from the Legend of Zelda games.", "Game.Zelda", "function-game-zelda-Item.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Item(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Zelda.Item();
        }
        [NativeFunction("Location", "Produces the name of a character from the Legend of Zelda games.", "Game.Zelda", "function-game-zelda-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Game.Zelda.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternet
    {
        [NativeFunction("Base64", "Produces a random string of alphabetic characters, (no digits).", "Internet", "function-internet-Base64.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Base64(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("length", "", IsOptional = true, OptionalDesc = "16", Default = "16")] long length
            , [ArgumentProperty("padding", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool padding
            , [ArgumentProperty("urlsafe", "", IsOptional = true, OptionalDesc = "true", Default = "true")] bool urlsafe)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.Base64(length, padding, urlsafe);
        }
        [NativeFunction("BotUserAgent", "Generate Web Crawler's user agents.", "Internet", "function-internet-BotUserAgent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BotUserAgent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("vendor", "", IsOptional = true, OptionalDesc = "nil")] string? vendor
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.BotUserAgent(vendor);
        }
        #warning Failed processing method device_token : method has no name or return type.
        [NativeFunction("DomainName", "Returns the domain name.", "Internet", "function-internet-DomainName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DomainName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("subdomain", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool subdomain
            , [ArgumentProperty("domain", "", IsOptional = true, OptionalDesc = "nil")] string? domain
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.DomainName(subdomain, domain);
        }
        [NativeFunction("DomainSuffix", "Returns the domain suffix e.g.\ncom, org, co, biz, info etc.", "Internet", "function-internet-DomainSuffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DomainSuffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("safe", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool safe
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
        [NativeFunction("Email", "Returns the email address.", "Internet", "function-internet-Email.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Email(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("name", "", IsOptional = true, OptionalDesc = "nil")] string? name
            , [ArgumentProperty("separators", "", IsOptional = true, OptionalDesc = "'-_'", Default = "-_")] string separators
            , [ArgumentProperty("domain", "", IsOptional = true, OptionalDesc = "nil")] string? domain
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Email(name, separators, domain);
        }
        [NativeFunction("IpV4Address", "Returns the IPv4 address.", "Internet", "function-internet-IpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.IpV4Address();
        }
        [NativeFunction("IpV4Cidr", "Returns Ipv4 address with CIDR, range from 1 to 31.", "Internet", "function-internet-IpV4Cidr.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV4Cidr(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.IpV4Cidr();
        }
        [NativeFunction("IpV6Address", "Returns Ipv6 address.", "Internet", "function-internet-IpV6Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV6Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.IpV6Address();
        }
        [NativeFunction("IpV6Cidr", "Returns Ipv6 address with CIDR, range between 1 to 127", "Internet", "function-internet-IpV6Cidr.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IpV6Cidr(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.IpV6Cidr();
        }
        [NativeFunction("MacAddress", "Returns the MAC address.", "Internet", "function-internet-MacAddress.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MacAddress(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.MacAddress();
        }
        [NativeFunction("Password", "Produces a randomized string of characters suitable for passwords.", "Internet", "function-internet-Password.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Password(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("minLength", "", IsOptional = true, OptionalDesc = "8", Default = "8")] long minLength
            , [ArgumentProperty("maxLength", "", IsOptional = true, OptionalDesc = "16", Default = "16")] long maxLength
            , [ArgumentProperty("mixCase", "", IsOptional = true, OptionalDesc = "true", Default = "true")] bool mixCase
            , [ArgumentProperty("specialCharacters", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool specialCharacters)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.Password(minLength, maxLength, mixCase, specialCharacters);
        }
        [NativeFunction("PrivateIpV4Address", "Returns the private IPv4 address.", "Internet", "function-internet-PrivateIpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PrivateIpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.PrivateIpV4Address();
        }
        [NativeFunction("PublicIpV4Address", "Returns the public IPv4 address.", "Internet", "function-internet-PublicIpV4Address.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PublicIpV4Address(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.PublicIpV4Address();
        }
        [NativeFunction("Slug", "Returns unique string in URL.", "Internet", "function-internet-Slug.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Slug(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("words", "", IsOptional = true, OptionalDesc = "nil")] string? words
            , [ArgumentProperty("glue", "", IsOptional = true, OptionalDesc = "nil")] string? glue
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Slug(words, glue);
        }
        [NativeFunction("Url", "Returns URL.", "Internet", "function-internet-Url.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Url(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("host", "", IsOptional = true, OptionalDesc = "nil")] string? host
            , [ArgumentProperty("path", "", IsOptional = true, OptionalDesc = "nil")] string? path
            , [ArgumentProperty("scheme", "", IsOptional = true, OptionalDesc = "'https'", Default = "https")] string scheme
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Url(host, path, scheme);
        }
        #warning No implementation defined for method user
        [NativeFunction("UserAgent", "Generates the random browser identifier.", "Internet", "function-internet-UserAgent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UserAgent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("vendor", "", IsOptional = true, OptionalDesc = "nil")] string? vendor
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.UserAgent(vendor);
        }
        [NativeFunction("Username", "Returns the username.", "Internet", "function-internet-Username.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Username(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("lengthRange", "", IsOptional = true, OptionalDesc = "5..10")] IntegerRange? lengthRange
            , [ArgumentProperty("separators", "", IsOptional = true, OptionalDesc = "'._'", Default = "._")] string separators
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Internet.Username(lengthRange ??= IntegerRange.Parse("5..10"), separators);
        }
        [NativeFunction("Uuid", "Generated universally unique identifier.", "Internet", "function-internet-Uuid.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Uuid(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Internet.Uuid();
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
        #warning Failed processing method random : method has no name or return type.
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
    public partial class FakerAdapterInternetHTTP
    {
        #warning No implementation defined for method status_code
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
        #warning Failed processing method random : method has no name or return type.
        #warning No implementation defined for method sandwich
        #warning No implementation defined for method table
        #warning No implementation defined for method unordered_list
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterInternetTwitter
    {
        #warning Failed processing method created_at : method has no name or return type.
        #warning Failed processing method id : method has no name or return type.
        #warning Failed processing method photo_entity : method has no name or return type.
        #warning No implementation defined for method screen_name
        #warning No implementation defined for method status
        #warning Failed processing method status_entities : method has no name or return type.
        #warning No implementation defined for method user
        #warning Failed processing method user_entities : method has no name or return type.
        #warning Failed processing method utc_offset : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterIT
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITApp
    {
        [NativeFunction("Author", "Produces the name of an app's author.", "IT.App", "function-it-app-Author.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Author(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.App.Author();
        }
        [NativeFunction("Name", "Produces an app name.", "IT.App", "function-it-app-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.App.Name();
        }
        #warning No implementation defined for method semantic_version
        [NativeFunction("Version", "Produces a version string.", "IT.App", "function-it-app-Version.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Version(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.App.Version();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITComputer
    {
        [NativeFunction("Os", "Produces the name of a computer os.", "IT.Computer", "function-it-computer-Os.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Os(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("platform", "", IsOptional = true, OptionalDesc = "'linux'", Default = "linux")] string platform
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Computer.Os(platform);
        }
        [NativeFunction("Platform", "Produces the name of a computer platform.", "IT.Computer", "function-it-computer-Platform.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Platform(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Computer.Platform();
        }
        [NativeFunction("Stack", "Produces a string with computer platform and os.", "IT.Computer", "function-it-computer-Stack.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Stack(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Computer.Stack();
        }
        [NativeFunction("Type", "Produces the name of a computer type.", "IT.Computer", "function-it-computer-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Computer.Type();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITDevice
    {
        #warning No implementation defined for method build_number
        [NativeFunction("Manufacturer", "Produces the name of a manufacturer for a device.", "IT.Device", "function-it-device-Manufacturer.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Manufacturer(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Device.Manufacturer();
        }
        [NativeFunction("ModelName", "Produces a model name for a device.", "IT.Device", "function-it-device-ModelName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ModelName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Device.ModelName();
        }
        [NativeFunction("Platform", "Produces the name of a platform for a device.", "IT.Device", "function-it-device-Platform.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Platform(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Device.Platform();
        }
        [NativeFunction("Serial", "Produces a serial code for a device.", "IT.Device", "function-it-device-Serial.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Serial(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Device.Serial();
        }
        #warning No implementation defined for method version
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITElectricalComponents
    {
        [NativeFunction("Active", "Produces an active electrical component.", "IT.ElectricalComponents", "function-it-electricalcomponents-Active.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Active(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.ElectricalComponents.Active();
        }
        [NativeFunction("Electromechanical", "Produces an electromechanical electrical component.", "IT.ElectricalComponents", "function-it-electricalcomponents-Electromechanical.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Electromechanical(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.ElectricalComponents.Electromechanical();
        }
        [NativeFunction("Passive", "Produces a passive electrical component.", "IT.ElectricalComponents", "function-it-electricalcomponents-Passive.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Passive(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.ElectricalComponents.Passive();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITFile
    {
        [NativeFunction("Dir", "Produces a random directory name.", "IT.File", "function-it-file-Dir.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Dir(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("segmentCount", "", IsOptional = true, OptionalDesc = "3", Default = "3")] long segmentCount
            , [ArgumentProperty("root", "", IsOptional = true, OptionalDesc = "nil")] string? root
            , [ArgumentProperty("directorySeparator", "", IsOptional = true, OptionalDesc = "'/'", Default = "/")] string directorySeparator
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.File.Dir(segmentCount, root, directorySeparator);
        }
        [NativeFunction("Extension", "Produces a random file extension.", "IT.File", "function-it-file-Extension.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Extension(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.File.Extension();
        }
        #warning No implementation defined for method file_name
        [NativeFunction("MimeType", "Produces a random mime type.", "IT.File", "function-it-file-MimeType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MimeType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("mediaType", "", IsOptional = true, OptionalDesc = "nil")] MimeTypeMedia? mediaType
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.File.MimeType(mediaType);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITProgrammingLanguage
    {
        [NativeFunction("Creator", "Produces the name of a programming language's creator.", "IT.ProgrammingLanguage", "function-it-programminglanguage-Creator.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creator(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.ProgrammingLanguage.Creator();
        }
        [NativeFunction("Name", "Produces the name of a programming language.", "IT.ProgrammingLanguage", "function-it-programminglanguage-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.ProgrammingLanguage.Name();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITSlackEmoji
    {
        [NativeFunction("Activity", "Produces a random slack emoji from activity category.", "IT.SlackEmoji", "function-it-slackemoji-Activity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Activity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.Activity();
        }
        [NativeFunction("Celebration", "Produces a random slack emoji from celebration category.", "IT.SlackEmoji", "function-it-slackemoji-Celebration.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Celebration(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.Celebration();
        }
        [NativeFunction("Custom", "Produces a random slack emoji from custom category.", "IT.SlackEmoji", "function-it-slackemoji-Custom.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Custom(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.Custom();
        }
        [NativeFunction("Emoji", "Produces a random slack emoji from any category.", "IT.SlackEmoji", "function-it-slackemoji-Emoji.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Emoji(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.Emoji();
        }
        [NativeFunction("FoodAndDrink", "Produces a random slack emoji from food and drink category.", "IT.SlackEmoji", "function-it-slackemoji-FoodAndDrink.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FoodAndDrink(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.FoodAndDrink();
        }
        [NativeFunction("Nature", "Produces a random slack emoji from nature category.", "IT.SlackEmoji", "function-it-slackemoji-Nature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Nature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.Nature();
        }
        [NativeFunction("ObjectsAndSymbols", "Produces a random slack emoji from objects and symbols category.", "IT.SlackEmoji", "function-it-slackemoji-ObjectsAndSymbols.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ObjectsAndSymbols(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.ObjectsAndSymbols();
        }
        [NativeFunction("People", "Produces a random slack emoji from people category.", "IT.SlackEmoji", "function-it-slackemoji-People.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string People(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.People();
        }
        [NativeFunction("TravelAndPlaces", "Produces a random slack emoji from travel and places category.", "IT.SlackEmoji", "function-it-slackemoji-TravelAndPlaces.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TravelAndPlaces(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.SlackEmoji.TravelAndPlaces();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITSource
    {
        [NativeFunction("HelloWorld", "Produces source code for Hello World in a given language.", "IT.Source", "function-it-source-HelloWorld.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HelloWorld(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("lang", "", IsOptional = true, OptionalDesc = "'ruby'", Default = "ruby")] string lang
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Source.HelloWorld(lang);
        }
        [NativeFunction("Print", "Produces source code for printing a string in a given language.", "IT.Source", "function-it-source-Print.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Print(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("str", "")] string str
            , [ArgumentProperty("lang", "", IsOptional = true, OptionalDesc = "'ruby'", Default = "ruby")] string lang
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Source.Print(str, lang);
        }
        [NativeFunction("Print1To10", "Produces source code for printing 1 through 10 in a given language.", "IT.Source", "function-it-source-Print1To10.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Print1To10(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("lang", "", IsOptional = true, OptionalDesc = "'ruby'", Default = "ruby")] string lang
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).IT.Source.Print1To10(lang);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterITVulnerabilityIdentifier
    {
        #warning No implementation defined for method cve
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMedia
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaConan
    {
        [NativeFunction("Character", "Produces a character from Conan.", "JapaneseMedia.Conan", "function-japanesemedia-conan-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Conan.Character();
        }
        [NativeFunction("Gadget", "Produces a gadget from Conan.", "JapaneseMedia.Conan", "function-japanesemedia-conan-Gadget.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Gadget(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Conan.Gadget();
        }
        [NativeFunction("Vehicle", "Produces a vehicle from Conan.", "JapaneseMedia.Conan", "function-japanesemedia-conan-Vehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Conan.Vehicle();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaCowboyBebop
    {
        [NativeFunction("Character", "Produces a character from Cowboy Bebop.", "JapaneseMedia.CowboyBebop", "function-japanesemedia-cowboybebop-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.CowboyBebop.Character();
        }
        [NativeFunction("Episode", "Produces an episode from Cowboy Bebop.", "JapaneseMedia.CowboyBebop", "function-japanesemedia-cowboybebop-Episode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Episode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.CowboyBebop.Episode();
        }
        [NativeFunction("Quote", "Produces a quote from Cowboy Bebop.", "JapaneseMedia.CowboyBebop", "function-japanesemedia-cowboybebop-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.CowboyBebop.Quote();
        }
        [NativeFunction("Song", "Produces a song title from Cowboy Bebop.", "JapaneseMedia.CowboyBebop", "function-japanesemedia-cowboybebop-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.CowboyBebop.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaDoraemon
    {
        [NativeFunction("Character", "Produces a character from Doraemon.", "JapaneseMedia.Doraemon", "function-japanesemedia-doraemon-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Doraemon.Character();
        }
        [NativeFunction("Gadget", "Produces a gadget from Doraemon.", "JapaneseMedia.Doraemon", "function-japanesemedia-doraemon-Gadget.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Gadget(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Doraemon.Gadget();
        }
        [NativeFunction("Location", "Produces a location from Doraemon.", "JapaneseMedia.Doraemon", "function-japanesemedia-doraemon-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Doraemon.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaDragonBall
    {
        [NativeFunction("Character", "Produces the name of a character from Dragon Ball.", "JapaneseMedia.DragonBall", "function-japanesemedia-dragonball-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.DragonBall.Character();
        }
        [NativeFunction("Planet", "Produces the name of a planet from Dragon Ball.", "JapaneseMedia.DragonBall", "function-japanesemedia-dragonball-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.DragonBall.Planet();
        }
        [NativeFunction("Race", "Produces the name of a race from Dragon Ball.", "JapaneseMedia.DragonBall", "function-japanesemedia-dragonball-Race.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Race(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.DragonBall.Race();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaFmaBrotherhood
    {
        [NativeFunction("Character", "Produces a character from FmaBrotherhood.", "JapaneseMedia.FmaBrotherhood", "function-japanesemedia-fmabrotherhood-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.FmaBrotherhood.Character();
        }
        [NativeFunction("City", "Produces a cities from FmaBrotherhood.", "JapaneseMedia.FmaBrotherhood", "function-japanesemedia-fmabrotherhood-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.FmaBrotherhood.City();
        }
        [NativeFunction("Country", "Produces a country from FmaBrotherhood.", "JapaneseMedia.FmaBrotherhood", "function-japanesemedia-fmabrotherhood-Country.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Country(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.FmaBrotherhood.Country();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaKamenRider
    {
        #warning No implementation defined for method collectible_device
        #warning No implementation defined for method eras
        #warning No implementation defined for method eras=
        [NativeFunction("FromEras", "", "JapaneseMedia.KamenRider", "function-japanesemedia-kamenrider-FromEras.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FromEras(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.KamenRider.FromEras();
        }
        #warning No implementation defined for method kamen_rider
        #warning No implementation defined for method series
        #warning No implementation defined for method transformation_device
        #warning No implementation defined for method user
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaNaruto
    {
        [NativeFunction("Character", "Produces a character from Naruto.", "JapaneseMedia.Naruto", "function-japanesemedia-naruto-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Naruto.Character();
        }
        [NativeFunction("Demon", "Produces a demon from Naruto.", "JapaneseMedia.Naruto", "function-japanesemedia-naruto-Demon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Demon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Naruto.Demon();
        }
        [NativeFunction("Eye", "Produces a eye from Naruto.", "JapaneseMedia.Naruto", "function-japanesemedia-naruto-Eye.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Eye(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Naruto.Eye();
        }
        [NativeFunction("Village", "Produces a village from Naruto.", "JapaneseMedia.Naruto", "function-japanesemedia-naruto-Village.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Village(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.Naruto.Village();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaOnePiece
    {
        [NativeFunction("AkumaNoMi", "Produces an akuma no mi from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-AkumaNoMi.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AkumaNoMi(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.AkumaNoMi();
        }
        [NativeFunction("Character", "Produces a character from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.Character();
        }
        [NativeFunction("Island", "Produces an island from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-Island.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Island(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.Island();
        }
        [NativeFunction("Location", "Produces a location from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.Location();
        }
        [NativeFunction("Quote", "Produces a quote from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.Quote();
        }
        [NativeFunction("Sea", "Produces a sea from One Piece.", "JapaneseMedia.OnePiece", "function-japanesemedia-onepiece-Sea.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sea(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.OnePiece.Sea();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaStudioGhibli
    {
        [NativeFunction("Character", "Produces a character from the Studio Ghibli.", "JapaneseMedia.StudioGhibli", "function-japanesemedia-studioghibli-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.StudioGhibli.Character();
        }
        [NativeFunction("Movie", "Produces a movie from Studio Ghibli.", "JapaneseMedia.StudioGhibli", "function-japanesemedia-studioghibli-Movie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Movie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.StudioGhibli.Movie();
        }
        [NativeFunction("Quote", "Produces a quote from Studio Ghibli's movies.", "JapaneseMedia.StudioGhibli", "function-japanesemedia-studioghibli-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.StudioGhibli.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterJapaneseMediaSwordArtOnline
    {
        [NativeFunction("GameName", "Produces the in-game name of a character from Sword Art Online.", "JapaneseMedia.SwordArtOnline", "function-japanesemedia-swordartonline-GameName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string GameName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.SwordArtOnline.GameName();
        }
        [NativeFunction("Item", "Produces the name of an item from Sword Art Online.", "JapaneseMedia.SwordArtOnline", "function-japanesemedia-swordartonline-Item.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Item(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.SwordArtOnline.Item();
        }
        [NativeFunction("Location", "Produces the name of a location from Sword Art Online.", "JapaneseMedia.SwordArtOnline", "function-japanesemedia-swordartonline-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.SwordArtOnline.Location();
        }
        [NativeFunction("RealName", "Produces the real name of a character from Sword Art Online.", "JapaneseMedia.SwordArtOnline", "function-japanesemedia-swordartonline-RealName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RealName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).JapaneseMedia.SwordArtOnline.RealName();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterLocation
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterLocationCompass
    {
        [NativeFunction("Abbreviation", "Produces a random abbreviation.", "Location.Compass", "function-location-compass-Abbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Abbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.Abbreviation();
        }
        [NativeFunction("Azimuth", "Produces a random azimuth.", "Location.Compass", "function-location-compass-Azimuth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Azimuth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.Azimuth();
        }
        [NativeFunction("Cardinal", "Produces a random cardinal.", "Location.Compass", "function-location-compass-Cardinal.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Cardinal(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.Cardinal();
        }
        [NativeFunction("CardinalAbbreviation", "Produces a random cardinal abbreviation.", "Location.Compass", "function-location-compass-CardinalAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CardinalAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.CardinalAbbreviation();
        }
        [NativeFunction("CardinalAzimuth", "Produces a random cardinal azimuth.", "Location.Compass", "function-location-compass-CardinalAzimuth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CardinalAzimuth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.CardinalAzimuth();
        }
        [NativeFunction("Direction", "Produces a random direction.", "Location.Compass", "function-location-compass-Direction.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Direction(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.Direction();
        }
        [NativeFunction("HalfWind", "Produces a random half wind.", "Location.Compass", "function-location-compass-HalfWind.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HalfWind(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.HalfWind();
        }
        [NativeFunction("HalfWindAbbreviation", "Produces a random half wind abbreviation.", "Location.Compass", "function-location-compass-HalfWindAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HalfWindAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.HalfWindAbbreviation();
        }
        [NativeFunction("HalfWindAzimuth", "Produces a random half wind azimuth.", "Location.Compass", "function-location-compass-HalfWindAzimuth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HalfWindAzimuth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.HalfWindAzimuth();
        }
        [NativeFunction("Ordinal", "Produces a random ordinal.", "Location.Compass", "function-location-compass-Ordinal.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ordinal(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.Ordinal();
        }
        [NativeFunction("OrdinalAbbreviation", "Produces a random ordinal abbreviation.", "Location.Compass", "function-location-compass-OrdinalAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string OrdinalAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.OrdinalAbbreviation();
        }
        [NativeFunction("OrdinalAzimuth", "Produces a random ordinal azimuth.", "Location.Compass", "function-location-compass-OrdinalAzimuth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string OrdinalAzimuth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.OrdinalAzimuth();
        }
        [NativeFunction("QuarterWind", "Produces a random quarter wind.", "Location.Compass", "function-location-compass-QuarterWind.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string QuarterWind(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.QuarterWind();
        }
        [NativeFunction("QuarterWindAbbreviation", "Produces a random quarter wind abbreviation.", "Location.Compass", "function-location-compass-QuarterWindAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string QuarterWindAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.QuarterWindAbbreviation();
        }
        [NativeFunction("QuarterWindAzimuth", "Produces a random quarter wind azimuth.", "Location.Compass", "function-location-compass-QuarterWindAzimuth.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string QuarterWindAzimuth(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Location.Compass.QuarterWindAzimuth();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterLoremFlickr
    {
        #warning Failed processing method build_url : method has no name or return type.
        #warning No implementation defined for method colorized_image
        #warning No implementation defined for method grayscale_image
        #warning No implementation defined for method image
        #warning No implementation defined for method pixelated_image
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMedicine
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMedicineCannabis
    {
        [NativeFunction("Brand", "Produces a random brand.", "Medicine.Cannabis", "function-medicine-cannabis-Brand.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Brand(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Brand();
        }
        [NativeFunction("Buzzword", "Produces a random buzzword.", "Medicine.Cannabis", "function-medicine-cannabis-Buzzword.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Buzzword(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Buzzword();
        }
        [NativeFunction("Cannabinoid", "Produces a random cannabinoid type.", "Medicine.Cannabis", "function-medicine-cannabis-Cannabinoid.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Cannabinoid(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Cannabinoid();
        }
        [NativeFunction("CannabinoidAbbreviation", "Produces a random abbreviation.", "Medicine.Cannabis", "function-medicine-cannabis-CannabinoidAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CannabinoidAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.CannabinoidAbbreviation();
        }
        [NativeFunction("Category", "Produces a random category.", "Medicine.Cannabis", "function-medicine-cannabis-Category.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Category(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Category();
        }
        [NativeFunction("HealthBenefit", "Produces a random health benefit.", "Medicine.Cannabis", "function-medicine-cannabis-HealthBenefit.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HealthBenefit(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.HealthBenefit();
        }
        [NativeFunction("MedicalUse", "Produces a random kind of medical use.", "Medicine.Cannabis", "function-medicine-cannabis-MedicalUse.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MedicalUse(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.MedicalUse();
        }
        [NativeFunction("Strain", "Produces a random strain.", "Medicine.Cannabis", "function-medicine-cannabis-Strain.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Strain(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Strain();
        }
        [NativeFunction("Terpene", "Produces a random terpene type.", "Medicine.Cannabis", "function-medicine-cannabis-Terpene.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Terpene(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Terpene();
        }
        [NativeFunction("Type", "Produces a random type.", "Medicine.Cannabis", "function-medicine-cannabis-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Medicine.Cannabis.Type();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMedicineNationalHealthService
    {
        #warning No implementation defined for method british_number
        #warning No implementation defined for method check_digit
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovie
    {
        [NativeFunction("Quote", "Produces a quote from a movie.", "Movie", "function-movie-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Quote();
        }
        [NativeFunction("Title", "Produces a title from a movie.", "Movie", "function-movie-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Title();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieAvatar
    {
        [NativeFunction("Character", "Produces a character from Avatar.", "Movie.Avatar", "function-movie-avatar-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Avatar.Character();
        }
        [NativeFunction("Date", "Produces a date from Avatar.", "Movie.Avatar", "function-movie-avatar-Date.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Date(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Avatar.Date();
        }
        [NativeFunction("Quote", "Produces a quote from Avatar.", "Movie.Avatar", "function-movie-avatar-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Avatar.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieBackToTheFuture
    {
        [NativeFunction("Character", "Produces a character from Back to the Future.", "Movie.BackToTheFuture", "function-movie-backtothefuture-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.BackToTheFuture.Character();
        }
        [NativeFunction("Date", "Produces a date from Back to the Future.", "Movie.BackToTheFuture", "function-movie-backtothefuture-Date.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Date(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.BackToTheFuture.Date();
        }
        [NativeFunction("Quote", "Produces a quote from Back to the Future.", "Movie.BackToTheFuture", "function-movie-backtothefuture-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.BackToTheFuture.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieBossaNova
    {
        [NativeFunction("Artist", "Produces the name of a bossa nova artist.", "Movie.BossaNova", "function-movie-bossanova-Artist.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Artist(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.BossaNova.Artist();
        }
        [NativeFunction("Song", "Produces a bossa nova song.", "Movie.BossaNova", "function-movie-bossanova-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.BossaNova.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieDeparted
    {
        [NativeFunction("Actor", "Produces an actor from The Departed.", "Movie.Departed", "function-movie-departed-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Departed.Actor();
        }
        [NativeFunction("Character", "Produces a character from The Departed.", "Movie.Departed", "function-movie-departed-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Departed.Character();
        }
        [NativeFunction("Quote", "Produces a quote from The Departed.", "Movie.Departed", "function-movie-departed-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Departed.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieGhostbusters
    {
        [NativeFunction("Actor", "Produces an actor from Ghostbusters.", "Movie.Ghostbusters", "function-movie-ghostbusters-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Ghostbusters.Actor();
        }
        [NativeFunction("Character", "Produces a character from Ghostbusters.", "Movie.Ghostbusters", "function-movie-ghostbusters-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Ghostbusters.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Ghostbusters.", "Movie.Ghostbusters", "function-movie-ghostbusters-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Ghostbusters.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieHackers
    {
        [NativeFunction("Character", "Produces a real character name from Hackers.", "Movie.Hackers", "function-movie-hackers-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hackers.Character();
        }
        [NativeFunction("Handle", "Produces a character hacker \"handle\" from Hackers.", "Movie.Hackers", "function-movie-hackers-Handle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Handle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hackers.Handle();
        }
        [NativeFunction("Quote", "Produces a quote from Hackers.", "Movie.Hackers", "function-movie-hackers-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hackers.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieHarryPotter
    {
        [NativeFunction("Book", "Produces a book from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-Book.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Book(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.Book();
        }
        [NativeFunction("Character", "Produces a character from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.Character();
        }
        [NativeFunction("House", "Produces a house from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-House.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string House(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.House();
        }
        [NativeFunction("Location", "Produces a location from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.Quote();
        }
        [NativeFunction("Spell", "Produces a spell from Harry Potter.", "Movie.HarryPotter", "function-movie-harrypotter-Spell.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Spell(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HarryPotter.Spell();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieHitchhikersGuideToTheGalaxy
    {
        [NativeFunction("Character", "Produces a character from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Character();
        }
        [NativeFunction("Location", "Produces a location from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Location();
        }
        [NativeFunction("MarvinQuote", "Produces a Marvin quote from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-MarvinQuote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MarvinQuote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.MarvinQuote();
        }
        [NativeFunction("Planet", "Produces a planet from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Planet();
        }
        [NativeFunction("Quote", "Produces a quote from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Quote();
        }
        [NativeFunction("Specie", "Produces a species from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Specie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Specie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Specie();
        }
        [NativeFunction("Starship", "Produces a starship from The Hitchhiker's Guide to the Galaxy.", "Movie.HitchhikersGuideToTheGalaxy", "function-movie-hitchhikersguidetothegalaxy-Starship.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Starship(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HitchhikersGuideToTheGalaxy.Starship();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieHobbit
    {
        [NativeFunction("Character", "Produces the name of a character from The Hobbit.", "Movie.Hobbit", "function-movie-hobbit-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hobbit.Character();
        }
        [NativeFunction("Location", "Produces the name of a location from The Hobbit.", "Movie.Hobbit", "function-movie-hobbit-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hobbit.Location();
        }
        [NativeFunction("Quote", "Produces a quote from The Hobbit.", "Movie.Hobbit", "function-movie-hobbit-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hobbit.Quote();
        }
        [NativeFunction("ThorinsCompany", "Produces the name of one of the 13 dwarves from the Company, or Gandalf or Bilbo.", "Movie.Hobbit", "function-movie-hobbit-ThorinsCompany.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ThorinsCompany(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Hobbit.ThorinsCompany();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieHowToTrainYourDragon
    {
        [NativeFunction("Character", "Produces a character from How To Train Your Dragon.", "Movie.HowToTrainYourDragon", "function-movie-howtotrainyourdragon-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HowToTrainYourDragon.Character();
        }
        [NativeFunction("Dragon", "Produces a dragon from How To Train Your Dragon.", "Movie.HowToTrainYourDragon", "function-movie-howtotrainyourdragon-Dragon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Dragon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HowToTrainYourDragon.Dragon();
        }
        [NativeFunction("Location", "Produces a location from How To Train Your Dragon.", "Movie.HowToTrainYourDragon", "function-movie-howtotrainyourdragon-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.HowToTrainYourDragon.Location();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieLebowski
    {
        [NativeFunction("Actor", "Produces an actor from The Big Lebowski.", "Movie.Lebowski", "function-movie-lebowski-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Lebowski.Actor();
        }
        [NativeFunction("Character", "Produces a character from The Big Lebowski.", "Movie.Lebowski", "function-movie-lebowski-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Lebowski.Character();
        }
        [NativeFunction("Quote", "Produces a quote from The Big Lebowski.", "Movie.Lebowski", "function-movie-lebowski-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Lebowski.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieLordOfTheRings
    {
        [NativeFunction("Character", "Produces a character from Lord of the Rings.", "Movie.LordOfTheRings", "function-movie-lordoftherings-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.LordOfTheRings.Character();
        }
        [NativeFunction("Location", "Produces a location from Lord of the Rings.", "Movie.LordOfTheRings", "function-movie-lordoftherings-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.LordOfTheRings.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Lord of the Rings.", "Movie.LordOfTheRings", "function-movie-lordoftherings-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.LordOfTheRings.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMoviePrincessBride
    {
        [NativeFunction("Character", "Produces a character from The Princess Bride.", "Movie.PrincessBride", "function-movie-princessbride-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.PrincessBride.Character();
        }
        [NativeFunction("Quote", "Produces a quote from The Princess Bride.", "Movie.PrincessBride", "function-movie-princessbride-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.PrincessBride.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieShow
    {
        [NativeFunction("AdultMusical", "Produces the name of a musical for an older audience.", "Movie.Show", "function-movie-show-AdultMusical.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AdultMusical(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Show.AdultMusical();
        }
        [NativeFunction("KidsMusical", "Produces the name of a musical for a younger audience.", "Movie.Show", "function-movie-show-KidsMusical.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string KidsMusical(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Show.KidsMusical();
        }
        [NativeFunction("Play", "Produces the name of a play.", "Movie.Show", "function-movie-show-Play.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Play(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Show.Play();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieStarWars
    {
        [NativeFunction("CallNumber", "Produces a call number from Star Wars.", "Movie.StarWars", "function-movie-starwars-CallNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CallNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.CallNumber();
        }
        [NativeFunction("CallSign", "Produces a call sign from Star Wars.", "Movie.StarWars", "function-movie-starwars-CallSign.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CallSign(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.CallSign();
        }
        [NativeFunction("CallSquadron", "Produces a call squadron from Star Wars.", "Movie.StarWars", "function-movie-starwars-CallSquadron.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CallSquadron(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.CallSquadron();
        }
        [NativeFunction("Character", "Produces a character from Star Wars.", "Movie.StarWars", "function-movie-starwars-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.Character();
        }
        [NativeFunction("Droid", "Produces a droid from Star Wars.", "Movie.StarWars", "function-movie-starwars-Droid.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Droid(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.Droid();
        }
        [NativeFunction("Planet", "Produces a planet from Star Wars.", "Movie.StarWars", "function-movie-starwars-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.Planet();
        }
        #warning No implementation defined for method quote
        [NativeFunction("Specie", "Produces a species from Star Wars.", "Movie.StarWars", "function-movie-starwars-Specie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Specie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.Specie();
        }
        [NativeFunction("Vehicle", "Produces a vehicle from Star Wars.", "Movie.StarWars", "function-movie-starwars-Vehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.Vehicle();
        }
        [NativeFunction("WookieeSentence", "Produces a wookiee sentence from Star Wars.", "Movie.StarWars", "function-movie-starwars-WookieeSentence.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string WookieeSentence(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.WookieeSentence();
        }
        [NativeFunction("WookieeWord", "Gets a random wookiee word", "Movie.StarWars", "function-movie-starwars-WookieeWord.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string WookieeWord(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.StarWars.WookieeWord();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieTheRoom
    {
        [NativeFunction("Actor", "Produces an actor from The Room (2003).", "Movie.TheRoom", "function-movie-theroom-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.TheRoom.Actor();
        }
        [NativeFunction("Character", "Produces a character from The Room (2003).", "Movie.TheRoom", "function-movie-theroom-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.TheRoom.Character();
        }
        [NativeFunction("Location", "Produces a location from The Room (2003).", "Movie.TheRoom", "function-movie-theroom-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.TheRoom.Location();
        }
        [NativeFunction("Quote", "Produces a quote from The Room (2003).", "Movie.TheRoom", "function-movie-theroom-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.TheRoom.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieTron
    {
        [NativeFunction("Character", "Produces a character from Tron.", "Movie.Tron", "function-movie-tron-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Character();
        }
        [NativeFunction("Game", "Produces a game from Tron.", "Movie.Tron", "function-movie-tron-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Game();
        }
        [NativeFunction("Location", "Produces a location from Tron.", "Movie.Tron", "function-movie-tron-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Location();
        }
        [NativeFunction("Program", "Produces a program from Tron.", "Movie.Tron", "function-movie-tron-Program.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Program(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Program();
        }
        #warning No implementation defined for method quote
        [NativeFunction("Tagline", "Produces a tagline from Tron.", "Movie.Tron", "function-movie-tron-Tagline.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Tagline(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Tagline();
        }
        [NativeFunction("User", "Produces a user from Tron.", "Movie.Tron", "function-movie-tron-User.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string User(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.User();
        }
        [NativeFunction("Vehicle", "Produces a vehicle from Tron.", "Movie.Tron", "function-movie-tron-Vehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.Tron.Vehicle();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMovieVForVendetta
    {
        [NativeFunction("Character", "Produces a character from V For Vendetta.", "Movie.VForVendetta", "function-movie-vforvendetta-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.VForVendetta.Character();
        }
        [NativeFunction("Quote", "Produces a quote from V For Vendetta.", "Movie.VForVendetta", "function-movie-vforvendetta-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.VForVendetta.Quote();
        }
        [NativeFunction("Speech", "Produces a speech from V For Vendetta.", "Movie.VForVendetta", "function-movie-vforvendetta-Speech.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Speech(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Movie.VForVendetta.Speech();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusic
    {
        [NativeFunction("Album", "Produces the name of an album.", "Music", "function-music-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Album();
        }
        [NativeFunction("Band", "Produces the name of a band.", "Music", "function-music-Band.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Band(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Band();
        }
        #warning No implementation defined for method chord
        #warning No implementation defined for method chord_types
        [NativeFunction("Genre", "Produces the name of a musical genre.", "Music", "function-music-Genre.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Genre(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Genre();
        }
        [NativeFunction("Instrument", "Produces the name of an instrument.", "Music", "function-music-Instrument.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Instrument(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Instrument();
        }
        #warning No implementation defined for method key
        #warning No implementation defined for method key_types
        #warning No implementation defined for method key_variants
        #warning No implementation defined for method keys
        [NativeFunction("MamboNo5", "Produces a name from Lou Bega's Mambo #5.\n                            <p>Produces a name from Lou Bega’s Mambo #5</p>", "Music", "function-music-MamboNo5.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MamboNo5(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.MamboNo5();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicGratefulDead
    {
        [NativeFunction("Player", "Produces the name of a member of The Grateful Dead.", "Music.GratefulDead", "function-music-gratefuldead-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.GratefulDead.Player();
        }
        [NativeFunction("Song", "Produces the name of a song by The Grateful Dead.", "Music.GratefulDead", "function-music-gratefuldead-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.GratefulDead.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicHiphop
    {
        [NativeFunction("Artist", "Produces the name of a Hip Hop Artist.", "Music.Hiphop", "function-music-hiphop-Artist.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Artist(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Hiphop.Artist();
        }
        [NativeFunction("Groups", "Produces the name of a Hip Hop Group.", "Music.Hiphop", "function-music-hiphop-Groups.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Groups(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Hiphop.Groups();
        }
        [NativeFunction("Subgenres", "Produces the name of a Hip Hop Subgenre.", "Music.Hiphop", "function-music-hiphop-Subgenres.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Subgenres(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Hiphop.Subgenres();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicKpop
    {
        [NativeFunction("BoyBands", "Produces the name of a K-Pop boy band.", "Music.Kpop", "function-music-kpop-BoyBands.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BoyBands(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.BoyBands();
        }
        [NativeFunction("GirlGroups", "Produces the name of a K-Pop girl group.", "Music.Kpop", "function-music-kpop-GirlGroups.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string GirlGroups(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.GirlGroups();
        }
        [NativeFunction("IGroups", "Produces the name of a 1990's 'OG' K-Pop group.", "Music.Kpop", "function-music-kpop-IGroups.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IGroups(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.IGroups();
        }
        [NativeFunction("IiGroups", "Produces the name of a 2000's K-Pop group.", "Music.Kpop", "function-music-kpop-IiGroups.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IiGroups(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.IiGroups();
        }
        [NativeFunction("IiiGroups", "Produces the name of a 2010's K-Pop group.", "Music.Kpop", "function-music-kpop-IiiGroups.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IiiGroups(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.IiiGroups();
        }
        [NativeFunction("Solo", "Produces the name of a solo K-Pop artist.", "Music.Kpop", "function-music-kpop-Solo.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Solo(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Kpop.Solo();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicOpera
    {
        [NativeFunction("Beethoven", "Produces the title of an opera by Ludwig van Beethoven.", "Music.Opera", "function-music-opera-Beethoven.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Beethoven(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Beethoven();
        }
        [NativeFunction("Bellini", "Produces the title of an opera by Vincenzo Bellini.", "Music.Opera", "function-music-opera-Bellini.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Bellini(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Bellini();
        }
        [NativeFunction("Berg", "Produces the title of an opera by Alban Berg.", "Music.Opera", "function-music-opera-Berg.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Berg(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Berg();
        }
        [NativeFunction("Berlioz", "Produces the title of an opera by Hector Berlioz.", "Music.Opera", "function-music-opera-Berlioz.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Berlioz(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Berlioz();
        }
        [NativeFunction("Bizet", "Produces the title of an opera by Georges Bizet.", "Music.Opera", "function-music-opera-Bizet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Bizet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Bizet();
        }
        [NativeFunction("Donizetti", "Produces the title of an opera by Gaetano Donizetti.", "Music.Opera", "function-music-opera-Donizetti.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Donizetti(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Donizetti();
        }
        [NativeFunction("Gluck", "Produces the title of an opera by Christoph Willibald Gluck.", "Music.Opera", "function-music-opera-Gluck.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Gluck(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Gluck();
        }
        [NativeFunction("GluckFrench", "Produces the title of a French opera by Christoph Willibald Gluck.", "Music.Opera", "function-music-opera-GluckFrench.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string GluckFrench(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.GluckFrench();
        }
        [NativeFunction("GluckItalian", "Produces the title of an Italian opera by Christoph Willibald Gluck.", "Music.Opera", "function-music-opera-GluckItalian.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string GluckItalian(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.GluckItalian();
        }
        [NativeFunction("Gounod", "Produces the title of an opera by Charles Gounod.", "Music.Opera", "function-music-opera-Gounod.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Gounod(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Gounod();
        }
        [NativeFunction("Mozart", "Produces the title of an opera by Wolfgang Amadeus Mozart.", "Music.Opera", "function-music-opera-Mozart.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Mozart(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Mozart();
        }
        [NativeFunction("MozartGerman", "Produces the title of a German opera by Wolfgang Amadeus Mozart.", "Music.Opera", "function-music-opera-MozartGerman.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MozartGerman(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.MozartGerman();
        }
        [NativeFunction("MozartItalian", "Produces the title of an Italian opera by Wolfgang Amadeus Mozart.", "Music.Opera", "function-music-opera-MozartItalian.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MozartItalian(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.MozartItalian();
        }
        [NativeFunction("Ravel", "Produces the title of an opera by Maurice Ravel.", "Music.Opera", "function-music-opera-Ravel.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ravel(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Ravel();
        }
        [NativeFunction("Rossini", "Produces the title of an opera by Gioacchino Rossini.", "Music.Opera", "function-music-opera-Rossini.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Rossini(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Rossini();
        }
        [NativeFunction("SaintSaens", "Produces the title of an opera by Camille Saint-Saens.", "Music.Opera", "function-music-opera-SaintSaens.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SaintSaens(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.SaintSaens();
        }
        [NativeFunction("Schubert", "Produces the title of an opera by Franz Schubert.", "Music.Opera", "function-music-opera-Schubert.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Schubert(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Schubert();
        }
        [NativeFunction("Schumann", "Produces the title of an opera by Robert Schumann.", "Music.Opera", "function-music-opera-Schumann.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Schumann(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Schumann();
        }
        [NativeFunction("Strauss", "Produces the title of an opera by Richard Strauss.", "Music.Opera", "function-music-opera-Strauss.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Strauss(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Strauss();
        }
        [NativeFunction("Verdi", "Produces the title of an opera by Giuseppe Verdi.", "Music.Opera", "function-music-opera-Verdi.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Verdi(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Verdi();
        }
        [NativeFunction("Wagner", "Produces the title of an opera by Richard Wagner.", "Music.Opera", "function-music-opera-Wagner.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Wagner(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Wagner();
        }
        [NativeFunction("Weber", "Produces the title of an opera by Carl Maria von Weber.", "Music.Opera", "function-music-opera-Weber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Weber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Opera.Weber();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicPearlJam
    {
        [NativeFunction("Album", "Produces the name of an album by Pearl Jam.", "Music.PearlJam", "function-music-pearljam-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.PearlJam.Album();
        }
        [NativeFunction("Musician", "Produces the name of a member of Pearl Jam (current and former).", "Music.PearlJam", "function-music-pearljam-Musician.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Musician(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.PearlJam.Musician();
        }
        [NativeFunction("Song", "Produces the name of a song by Pearl Jam.", "Music.PearlJam", "function-music-pearljam-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.PearlJam.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicPhish
    {
        [NativeFunction("Album", "Produces the name of a album by Phish.", "Music.Phish", "function-music-phish-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Phish.Album();
        }
        [NativeFunction("Musician", "Produces the name of a musician in Phish.", "Music.Phish", "function-music-phish-Musician.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Musician(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Phish.Musician();
        }
        [NativeFunction("Song", "Produces the name of a song by Phish.", "Music.Phish", "function-music-phish-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Phish.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicPrince
    {
        [NativeFunction("Album", "Produces a random Prince album.", "Music.Prince", "function-music-prince-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Prince.Album();
        }
        [NativeFunction("Band", "Produces a random Prince-associated band.", "Music.Prince", "function-music-prince-Band.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Band(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Prince.Band();
        }
        [NativeFunction("Lyric", "Produces a random Prince song lyric.", "Music.Prince", "function-music-prince-Lyric.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Lyric(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Prince.Lyric();
        }
        [NativeFunction("Song", "Produces a random Prince song.", "Music.Prince", "function-music-prince-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Prince.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicRockBand
    {
        [NativeFunction("Name", "Produces the name of a rock band.", "Music.RockBand", "function-music-rockband-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.RockBand.Name();
        }
        [NativeFunction("Song", "Produces a rock song.", "Music.RockBand", "function-music-rockband-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.RockBand.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicRush
    {
        [NativeFunction("Album", "Produces the name of an album by Rush.", "Music.Rush", "function-music-rush-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Rush.Album();
        }
        [NativeFunction("Player", "Produces the name of a member of Rush.", "Music.Rush", "function-music-rush-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.Rush.Player();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicSmashingPumpkins
    {
        [NativeFunction("Album", "Produces the name of an album by the Smashing Pumpkins.", "Music.SmashingPumpkins", "function-music-smashingpumpkins-Album.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Album(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.SmashingPumpkins.Album();
        }
        [NativeFunction("Lyric", "Produces a random Smashing Pumpkins song lyric.", "Music.SmashingPumpkins", "function-music-smashingpumpkins-Lyric.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Lyric(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.SmashingPumpkins.Lyric();
        }
        [NativeFunction("Musician", "Produces the name of a member of the Smashing Pumpkins (current and former).", "Music.SmashingPumpkins", "function-music-smashingpumpkins-Musician.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Musician(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.SmashingPumpkins.Musician();
        }
        [NativeFunction("Song", "Produces the name of a song by the Smashing Pumpkins.", "Music.SmashingPumpkins", "function-music-smashingpumpkins-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.SmashingPumpkins.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterMusicUmphreysMcgee
    {
        [NativeFunction("Song", "Produces the name of a song by Umphrey's McGee.", "Music.UmphreysMcgee", "function-music-umphreysmcgee-Song.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Song(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Music.UmphreysMcgee.Song();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterOmniauth
    {
        #warning No implementation defined for method apple
        #warning No implementation defined for method auth0
        #warning Failed processing method city_state : method has no name or return type.
        #warning Failed processing method email : method has no name or return type.
        #warning No implementation defined for method facebook
        #warning Failed processing method first_name : method has no name or return type.
        #warning Failed processing method gender : method has no name or return type.
        #warning No implementation defined for method github
        #warning No implementation defined for method google
        #warning Failed processing method image : method has no name or return type.
        #warning No implementation defined for method initialize
        #warning Failed processing method last_name : method has no name or return type.
        #warning No implementation defined for method linkedin
        #warning Failed processing method name : method has no name or return type.
        #warning Failed processing method random_boolean : method has no name or return type.
        #warning Failed processing method random_number_from_range : method has no name or return type.
        #warning Failed processing method timezone : method has no name or return type.
        #warning No implementation defined for method twitter
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeople
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeopleAncient
    {
        [NativeFunction("God", "Produces a god from ancient mythology.", "People.Ancient", "function-people-ancient-God.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string God(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Ancient.God();
        }
        [NativeFunction("Hero", "Produces a hero from ancient mythology.", "People.Ancient", "function-people-ancient-Hero.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hero(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Ancient.Hero();
        }
        [NativeFunction("Primordial", "Produces a primordial from ancient mythology.", "People.Ancient", "function-people-ancient-Primordial.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Primordial(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Ancient.Primordial();
        }
        [NativeFunction("Titan", "Produces a titan from ancient mythology.", "People.Ancient", "function-people-ancient-Titan.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Titan(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Ancient.Titan();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeopleArtist
    {
        [NativeFunction("Name", "Produces the name of an artist.", "People.Artist", "function-people-artist-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Artist.Name();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeopleFunnyName
    {
        [NativeFunction("FourWordName", "Retrieves a funny four word name.", "People.FunnyName", "function-people-funnyname-FourWordName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FourWordName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.FunnyName.FourWordName();
        }
        [NativeFunction("Name", "Retrieves a funny name.", "People.FunnyName", "function-people-funnyname-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.FunnyName.Name();
        }
        [NativeFunction("NameWithInitial", "Retrieves a funny name with an initial.", "People.FunnyName", "function-people-funnyname-NameWithInitial.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NameWithInitial(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.FunnyName.NameWithInitial();
        }
        [NativeFunction("ThreeWordName", "Retrieves a funny three word name.", "People.FunnyName", "function-people-funnyname-ThreeWordName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ThreeWordName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.FunnyName.ThreeWordName();
        }
        [NativeFunction("TwoWordName", "Retrieves a funny two word name.", "People.FunnyName", "function-people-funnyname-TwoWordName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TwoWordName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.FunnyName.TwoWordName();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeopleGreekPhilosophers
    {
        [NativeFunction("Name", "Produces the name of a Greek philosopher.", "People.GreekPhilosophers", "function-people-greekphilosophers-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.GreekPhilosophers.Name();
        }
        [NativeFunction("Quote", "Produces a quote from a Greek philosopher.", "People.GreekPhilosophers", "function-people-greekphilosophers-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.GreekPhilosophers.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPeopleSuperhero
    {
        [NativeFunction("Descriptor", "Produces a superhero descriptor.", "People.Superhero", "function-people-superhero-Descriptor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Descriptor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Superhero.Descriptor();
        }
        [NativeFunction("Name", "Produces a random superhero name.", "People.Superhero", "function-people-superhero-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Superhero.Name();
        }
        [NativeFunction("Power", "Produces a superpower.", "People.Superhero", "function-people-superhero-Power.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Power(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Superhero.Power();
        }
        [NativeFunction("Prefix", "Produces a superhero name prefix.", "People.Superhero", "function-people-superhero-Prefix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Prefix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Superhero.Prefix();
        }
        [NativeFunction("Suffix", "Produces a superhero name suffix.", "People.Superhero", "function-people-superhero-Suffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Suffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).People.Superhero.Suffix();
        }
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
        [NativeFunction("BuildingNumber", "Produces a building number.", "Person.Address", "function-person-address-BuildingNumber.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BuildingNumber(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.BuildingNumber();
        }
        [NativeFunction("City", "Produces the name of a city.", "Person.Address", "function-person-address-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.City();
        }
        [NativeFunction("CityPrefix", "Produces a city prefix.", "Person.Address", "function-person-address-CityPrefix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CityPrefix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.CityPrefix();
        }
        [NativeFunction("CitySuffix", "Produces a city suffix.", "Person.Address", "function-person-address-CitySuffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CitySuffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.CitySuffix();
        }
        [NativeFunction("Community", "Produces the name of a community.", "Person.Address", "function-person-address-Community.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Community(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.Community();
        }
        [NativeFunction("Country", "Produces the name of a country.", "Person.Address", "function-person-address-Country.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Country(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.Country();
        }
        [NativeFunction("CountryByCode", "Produces a country by ISO country code.\nSee the [List of ISO 3166 country codes](<a href=\"https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes\">en.wikipedia.org/wiki/List_of_ISO_3166_country_codes</a>) on Wikipedia for a full list.", "Person.Address", "function-person-address-CountryByCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CountryByCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("code", "", IsOptional = true, OptionalDesc = "'US'", Default = "US")] string code)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Address.CountryByCode(code);
        }
        [NativeFunction("CountryCodeAlpha2", "Produces an ISO 3166 country code.", "Person.Address", "function-person-address-CountryCodeAlpha2.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CountryCodeAlpha2(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Address.CountryCode();
        }
        [NativeFunction("CountryCodeAlpha3", "Produces a long (alpha-3) ISO 3166 country code.", "Person.Address", "function-person-address-CountryCodeAlpha3.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CountryCodeAlpha3(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.CountryCodeLong();
        }
        [NativeFunction("CountryNameToAlpha2", "Produces an ISO 3166 country code when given a country name.", "Person.Address", "function-person-address-CountryNameToAlpha2.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "The ISO 3166 country code")]
        public static string CountryNameToAlpha2(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("name", "", IsOptional = true, OptionalDesc = "'United States'", Default = "United States")] string name
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.CountryNameToCode(name);
        }
        [NativeFunction("Latitude", "Produces a latitude.", "Person.Address", "function-person-address-Latitude.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double Latitude(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Address.Latitude();
        }
        [NativeFunction("Longitude", "Produces a longitude.", "Person.Address", "function-person-address-Longitude.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static double Longitude(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Address.Longitude();
        }
        [NativeFunction("MailBox", "Produces a mail box number.", "Person.Address", "function-person-address-MailBox.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MailBox(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.MailBox();
        }
        [NativeFunction("Postcode", "Produces a postcode/zipcode.", "Person.Address", "function-person-address-Postcode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Postcode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.Postcode();
        }
        [NativeFunction("SecondaryAddress", "Produces a secondary address.", "Person.Address", "function-person-address-SecondaryAddress.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SecondaryAddress(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.SecondaryAddress();
        }
        [NativeFunction("USState", "Produces the name of a state.", "Person.Address", "function-person-address-USState.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string USState(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.State();
        }
        [NativeFunction("USStateAbbreviation", "Produces a state abbreviation.", "Person.Address", "function-person-address-USStateAbbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string USStateAbbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.StateAbbr();
        }
        [NativeFunction("StreetAddress", "Produces a street address.", "Person.Address", "function-person-address-StreetAddress.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StreetAddress(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("includeSecondary", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool includeSecondary
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.StreetAddress(includeSecondary);
        }
        [NativeFunction("StreetName", "Produces a street name.", "Person.Address", "function-person-address-StreetName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StreetName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.StreetName();
        }
        [NativeFunction("StreetSuffix", "Produces a street suffix.", "Person.Address", "function-person-address-StreetSuffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StreetSuffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.StreetSuffix();
        }
        [NativeFunction("TimeZone", "Produces the name of a time zone.", "Person.Address", "function-person-address-TimeZone.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TimeZone(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.TimeZone();
        }
        [NativeFunction("ZipCode", "Produces a Zip Code/Postocde.", "Person.Address", "function-person-address-ZipCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ZipCode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Address.ZipCode();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPersonAvatar
    {
        [NativeFunction("Image", "Produces a URL for an avatar from robohash.org.", "Person.Avatar", "function-person-avatar-Image.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Image(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("name", "", IsOptional = true, OptionalDesc = "nil")] string? name
            , [ArgumentProperty("size", "", IsOptional = true, OptionalDesc = "'48x48'", Default = "48x48")] string size
            , [ArgumentProperty("format", "", IsOptional = true, OptionalDesc = "'jpg'", Default = "jpg")] string format
            , [ArgumentProperty("type", "", IsOptional = true, OptionalDesc = "AvatarType.Person", Default = "AvatarType.Person")] AvatarType type
            , [ArgumentProperty("background", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool background
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Person.Avatar.Image(name, size, format, type, background);
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
            return context.GetFakerInstance(new CultureInfo("en")).Person.Blood.Group();
        }
        [NativeFunction("RhFactor", "Produces a random blood RH-Factor.", "Person.Blood", "function-person-blood-RhFactor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RhFactor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Blood.RhFactor();
        }
        [NativeFunction("Type", "Produces a random blood type.", "Person.Blood", "function-person-blood-Type.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Type(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Person.Blood.Type();
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
            , [ArgumentProperty("state", "", IsOptional = true, OptionalDesc = "'California'", Default = "California")] string state
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
        [NativeFunction("AreaCode", "Produces a random area code.", "Person.PhoneNumber", "function-person-phonenumber-AreaCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AreaCode(
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
        [NativeFunction("ExchangeCode", "Produces a random exchange code.", "Person.PhoneNumber", "function-person-phonenumber-ExchangeCode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ExchangeCode(
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
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlace
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceAustralia
    {
        [NativeFunction("Animal", "Produces an Australian animal.", "Place.Australia", "function-place-australia-Animal.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Animal(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Australia.Animal();
        }
        [NativeFunction("Location", "Produces a location in Australia.", "Place.Australia", "function-place-australia-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Australia.Location();
        }
        [NativeFunction("State", "Produces an Australian State or Territory.", "Place.Australia", "function-place-australia-State.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string State(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Australia.State();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceDessert
    {
        [NativeFunction("Flavor", "Produces the name of a dessert flavor.", "Place.Dessert", "function-place-dessert-Flavor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Flavor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Dessert.Flavor();
        }
        [NativeFunction("Topping", "Produces the name of a dessert topping.", "Place.Dessert", "function-place-dessert-Topping.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Topping(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Dessert.Topping();
        }
        [NativeFunction("Variety", "Produces the name of a dessert variety.", "Place.Dessert", "function-place-dessert-Variety.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Variety(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Dessert.Variety();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceMountain
    {
        [NativeFunction("Name", "Produces a name of a mountain.\n                            \n\n                            <pre><code>@faker.version next\n                            </code></pre>", "Place.Mountain", "function-place-mountain-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Mountain.Name();
        }
        [NativeFunction("Range", "Produces a name of a range.", "Place.Mountain", "function-place-mountain-Range.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Range(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Mountain.Range();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceNation
    {
        [NativeFunction("CapitalCity", "Produces a random capital city.", "Place.Nation", "function-place-nation-CapitalCity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CapitalCity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Nation.CapitalCity();
        }
        #warning No implementation defined for method flag
        [NativeFunction("Language", "Produces a random national language.", "Place.Nation", "function-place-nation-Language.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Language(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Nation.Language();
        }
        [NativeFunction("NationalSport", "Produces a random national sport.", "Place.Nation", "function-place-nation-NationalSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NationalSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Nation.NationalSport();
        }
        [NativeFunction("Nationality", "Produces a random nationality.", "Place.Nation", "function-place-nation-Nationality.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Nationality(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Nation.Nationality();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceSouthAfrica
    {
        #warning No implementation defined for method cell_phone
        #warning No implementation defined for method close_corporation_registration_number
        #warning No implementation defined for method id_number
        #warning No implementation defined for method invalid_id_number
        #warning No implementation defined for method listed_company_registration_number
        #warning No implementation defined for method phone_number
        #warning No implementation defined for method pty_ltd_registration_number
        #warning No implementation defined for method trust_registration_number
        #warning No implementation defined for method valid_id_number
        #warning No implementation defined for method vat_number
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceSpace
    {
        [NativeFunction("Agency", "Produces the name of a space agency.", "Place.Space", "function-place-space-Agency.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Agency(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Agency();
        }
        [NativeFunction("AgencyAbv", "Produces a space agency abbreviation.", "Place.Space", "function-place-space-AgencyAbv.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AgencyAbv(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.AgencyAbv();
        }
        [NativeFunction("Company", "Produces the name of a space company.", "Place.Space", "function-place-space-Company.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Company(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Company();
        }
        [NativeFunction("Constellation", "Produces the name of a constellation.", "Place.Space", "function-place-space-Constellation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Constellation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Constellation();
        }
        [NativeFunction("DistanceMeasurement", "Produces a distance measurement.", "Place.Space", "function-place-space-DistanceMeasurement.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DistanceMeasurement(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.DistanceMeasurement();
        }
        [NativeFunction("Galaxy", "Produces the name of a galaxy.", "Place.Space", "function-place-space-Galaxy.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Galaxy(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Galaxy();
        }
        [NativeFunction("LaunchVehicle", "Produces the name of a launch vehicle.", "Place.Space", "function-place-space-LaunchVehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LaunchVehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.LaunchVehicle();
        }
        [NativeFunction("Meteorite", "Produces the name of a meteorite.", "Place.Space", "function-place-space-Meteorite.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Meteorite(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Meteorite();
        }
        [NativeFunction("Moon", "Produces the name of a moon.", "Place.Space", "function-place-space-Moon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Moon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Moon();
        }
        [NativeFunction("NasaSpaceCraft", "Produces the name of a NASA spacecraft.", "Place.Space", "function-place-space-NasaSpaceCraft.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string NasaSpaceCraft(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.NasaSpaceCraft();
        }
        [NativeFunction("Nebula", "Produces the name of a nebula.", "Place.Space", "function-place-space-Nebula.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Nebula(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Nebula();
        }
        [NativeFunction("Planet", "Produces the name of a planet.", "Place.Space", "function-place-space-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Planet();
        }
        [NativeFunction("Star", "Produces the name of a star.", "Place.Space", "function-place-space-Star.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Star(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.Star();
        }
        [NativeFunction("StarCluster", "Produces the name of a star cluster.", "Place.Space", "function-place-space-StarCluster.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string StarCluster(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.Space.StarCluster();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceUniversity
    {
        #warning No implementation defined for method greek_alphabet
        #warning No implementation defined for method greek_organization
        [NativeFunction("Name", "Produces a random university name.", "Place.University", "function-place-university-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.University.Name();
        }
        [NativeFunction("Prefix", "Produces a random university prefix.", "Place.University", "function-place-university-Prefix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Prefix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.University.Prefix();
        }
        [NativeFunction("Suffix", "Produces a random university suffix.", "Place.University", "function-place-university-Suffix.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Suffix(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Place.University.Suffix();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterPlaceholdit
    {
        #warning Failed processing method generate_color : method has no name or return type.
        #warning No implementation defined for method image
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterQuote
    {
        [NativeFunction("FamousLastWords", "Produces a famous last words quote.", "Quote", "function-quote-FamousLastWords.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FamousLastWords(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.FamousLastWords();
        }
        [NativeFunction("FortuneCookie", "Produces a quote from a fortune cookie.", "Quote", "function-quote-FortuneCookie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FortuneCookie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.FortuneCookie();
        }
        [NativeFunction("JackHandey", "Produces a quote from Deep Thoughts by Jack Handey.", "Quote", "function-quote-JackHandey.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string JackHandey(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.JackHandey();
        }
        [NativeFunction("Matz", "Produces a quote from Matz.", "Quote", "function-quote-Matz.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Matz(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Matz();
        }
        [NativeFunction("MitchHedberg", "Produces a quote from comedian Mitch Hedberg.", "Quote", "function-quote-MitchHedberg.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MitchHedberg(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.MitchHedberg();
        }
        [NativeFunction("MostInterestingManInTheWorld", "Produces a quote about the most interesting man in the world.", "Quote", "function-quote-MostInterestingManInTheWorld.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MostInterestingManInTheWorld(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.MostInterestingManInTheWorld();
        }
        [NativeFunction("Robin", "Produces a Robin quote.", "Quote", "function-quote-Robin.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Robin(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Robin();
        }
        [NativeFunction("SingularSiegler", "Produces a singular siegler quote.", "Quote", "function-quote-SingularSiegler.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SingularSiegler(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.SingularSiegler();
        }
        [NativeFunction("Yoda", "Produces a quote from Yoda.", "Quote", "function-quote-Yoda.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Yoda(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Yoda();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterQuoteChiquito
    {
        [NativeFunction("Expression", "Produces an Expression from Chiquito.", "Quote.Chiquito", "function-quote-chiquito-Expression.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Expression(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Expression();
        }
        [NativeFunction("Joke", "Produces a joke from Chiquito.", "Quote.Chiquito", "function-quote-chiquito-Joke.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Joke(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Joke();
        }
        [NativeFunction("Jokes", "", "Quote.Chiquito", "function-quote-chiquito-Jokes.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Jokes(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Jokes();
        }
        [NativeFunction("Sentence", "Produces a sentence from Chiquito.", "Quote.Chiquito", "function-quote-chiquito-Sentence.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sentence(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Sentence();
        }
        [NativeFunction("Sentences", "", "Quote.Chiquito", "function-quote-chiquito-Sentences.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sentences(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Sentences();
        }
        [NativeFunction("Term", "Produces a concept from Chiquito.", "Quote.Chiquito", "function-quote-chiquito-Term.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Term(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Term();
        }
        [NativeFunction("Terms", "", "Quote.Chiquito", "function-quote-chiquito-Terms.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Terms(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Chiquito.Terms();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterQuoteChuckNorris
    {
        [NativeFunction("Fact", "Produces a Chuck Norris Fact.\n<p>Original list of facts: <a href=\"https://github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java\">github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java</a></p>", "Quote.ChuckNorris", "function-quote-chucknorris-Fact.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Fact(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.ChuckNorris.Fact();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterQuoteRajnikanth
    {
        [NativeFunction("Joke", "Produces a Rajnikanth.\n                                <p>Original list of jokes: <a href=\"http://www.rajinikanthjokes.com\">www.rajinikanthjokes.com</a>/</p>", "Quote.Rajnikanth", "function-quote-rajnikanth-Joke.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Joke(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Rajnikanth.Joke();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterQuoteShakespeare
    {
        [NativeFunction("AsYouLikeIt", "Generates quote from 'As you like it!'.\n                                <p>Generates quote from ‘As you like it!’</p>", "Quote.Shakespeare", "function-quote-shakespeare-AsYouLikeIt.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AsYouLikeIt(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.AsYouLikeIt();
        }
        [NativeFunction("AsYouLikeItQuote", "Produces a Shakespeare quote from As You Like It.", "Quote.Shakespeare", "function-quote-shakespeare-AsYouLikeItQuote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AsYouLikeItQuote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.AsYouLikeItQuote();
        }
        [NativeFunction("Hamlet", "Generates quote from Hamlet.", "Quote.Shakespeare", "function-quote-shakespeare-Hamlet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Hamlet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.Hamlet();
        }
        [NativeFunction("HamletQuote", "Produces a Shakespeare quote from Hamlet.", "Quote.Shakespeare", "function-quote-shakespeare-HamletQuote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HamletQuote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.HamletQuote();
        }
        [NativeFunction("KingRichardIii", "Returns quote from 'King Rechard III'.\n                                <p>Returns quote from ‘King Rechard III’</p>", "Quote.Shakespeare", "function-quote-shakespeare-KingRichardIii.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string KingRichardIii(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.KingRichardIii();
        }
        [NativeFunction("KingRichardIiiQuote", "Produces a Shakespeare quote from King Richard III.", "Quote.Shakespeare", "function-quote-shakespeare-KingRichardIiiQuote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string KingRichardIiiQuote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.KingRichardIiiQuote();
        }
        [NativeFunction("RomeoAndJuliet", "Quote from 'Romeo and Juliet'.\n                                <p>Quote from ‘Romeo and Juliet’</p>", "Quote.Shakespeare", "function-quote-shakespeare-RomeoAndJuliet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RomeoAndJuliet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.RomeoAndJuliet();
        }
        [NativeFunction("RomeoAndJulietQuote", "Produces a Shakespeare quote from Romeo And Juliet.", "Quote.Shakespeare", "function-quote-shakespeare-RomeoAndJulietQuote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string RomeoAndJulietQuote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Quote.Shakespeare.RomeoAndJulietQuote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterScience
    {
        [NativeFunction("Element", "Produces the name of a element.", "Science", "function-science-Element.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Element(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.Element();
        }
        [NativeFunction("ElementState", "Produces the state of an element.", "Science", "function-science-ElementState.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ElementState(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.ElementState();
        }
        [NativeFunction("ElementSubcategory", "Produces the subcategory of an element.", "Science", "function-science-ElementSubcategory.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ElementSubcategory(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.ElementSubcategory();
        }
        [NativeFunction("ElementSymbol", "Produces the symbol of an element.", "Science", "function-science-ElementSymbol.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ElementSymbol(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context)
        {
            return context.GetFakerInstance(new CultureInfo("en")).Science.ElementSymbol();
        }
        [NativeFunction("Modifier", "Produces a scientifically sounding word.", "Science", "function-science-Modifier.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Modifier(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.Modifier();
        }
        #warning No implementation defined for method science
        [NativeFunction("Scientist", "Produces the name of a scientist.", "Science", "function-science-Scientist.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Scientist(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.Scientist();
        }
        [NativeFunction("Tool", "Produces the name of a scientific tool.\n                            <p>By default it uses a science word modifier to generate more diverse data, which can be disabled.</p>", "Science", "function-science-Tool.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Tool(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("simple", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool simple
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Science.Tool(simple);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSport
    {
        [NativeFunction("AncientOlympicsSport", "Produces a sport from the ancient olympics.", "Sport", "function-sport-AncientOlympicsSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string AncientOlympicsSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.AncientOlympicsSport();
        }
        [NativeFunction("Sport", "Produces a sport from the modern olympics or paralympics, summer or winter.", "Sport", "function-sport-Sport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("includeAncient", "")] bool includeAncient
            , [ArgumentProperty("includeUnusual", "", IsOptional = true, OptionalDesc = "false", Default = "false")] bool includeUnusual
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Sport(includeAncient, includeUnusual);
        }
        [NativeFunction("SummerOlympicsSport", "Produces a sport from the summer olympics.", "Sport", "function-sport-SummerOlympicsSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SummerOlympicsSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.SummerOlympicsSport();
        }
        [NativeFunction("SummerParalympicsSport", "Produces a sport from the summer paralympics.", "Sport", "function-sport-SummerParalympicsSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SummerParalympicsSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.SummerParalympicsSport();
        }
        [NativeFunction("UnusualSport", "Produces an unusual sport.", "Sport", "function-sport-UnusualSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string UnusualSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.UnusualSport();
        }
        [NativeFunction("WinterOlympicsSport", "Produces a sport from the winter olympics.", "Sport", "function-sport-WinterOlympicsSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string WinterOlympicsSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WinterOlympicsSport();
        }
        [NativeFunction("WinterParalympicsSport", "Produces a sport from the winter paralympics.", "Sport", "function-sport-WinterParalympicsSport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string WinterParalympicsSport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WinterParalympicsSport();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportBasketball
    {
        [NativeFunction("Coach", "Produces the name of a basketball coach.", "Sport.Basketball", "function-sport-basketball-Coach.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Coach(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Basketball.Coach();
        }
        [NativeFunction("Player", "Produces the name of a basketball player.", "Sport.Basketball", "function-sport-basketball-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Basketball.Player();
        }
        [NativeFunction("Position", "Produces a position in basketball.", "Sport.Basketball", "function-sport-basketball-Position.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Position(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Basketball.Position();
        }
        [NativeFunction("Team", "Produces the name of a basketball team.", "Sport.Basketball", "function-sport-basketball-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Basketball.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportChess
    {
        #warning No implementation defined for method federation
        [NativeFunction("Opening", "Produces the name of a chess opening.", "Sport.Chess", "function-sport-chess-Opening.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Opening(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Chess.Opening();
        }
        [NativeFunction("Player", "Produces the name of a chess player name.", "Sport.Chess", "function-sport-chess-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Chess.Player();
        }
        #warning No implementation defined for method rating
        [NativeFunction("Title", "Produces a chess title.", "Sport.Chess", "function-sport-chess-Title.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Title(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Chess.Title();
        }
        [NativeFunction("Tournament", "", "Sport.Chess", "function-sport-chess-Tournament.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Tournament(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Chess.Tournament();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportEsport
    {
        [NativeFunction("Event", "Produces the name of an eSports event.", "Sport.Esport", "function-sport-esport-Event.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Event(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Esport.Event();
        }
        [NativeFunction("Game", "Produces the name of a game played as an eSport.", "Sport.Esport", "function-sport-esport-Game.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Game(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Esport.Game();
        }
        [NativeFunction("League", "Produces the name of an eSports league.", "Sport.Esport", "function-sport-esport-League.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string League(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Esport.League();
        }
        [NativeFunction("Player", "Produces the name of a professional eSports player.", "Sport.Esport", "function-sport-esport-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Esport.Player();
        }
        [NativeFunction("Team", "Produces the name of an eSports team.", "Sport.Esport", "function-sport-esport-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Esport.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportFootball
    {
        [NativeFunction("Coach", "Produces the name of a football coach.", "Sport.Football", "function-sport-football-Coach.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Coach(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Football.Coach();
        }
        [NativeFunction("Competition", "Produces a football competition.", "Sport.Football", "function-sport-football-Competition.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Competition(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Football.Competition();
        }
        [NativeFunction("Player", "Produces the name of a football player.", "Sport.Football", "function-sport-football-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Football.Player();
        }
        [NativeFunction("Position", "Produces a position in football.", "Sport.Football", "function-sport-football-Position.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Position(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Football.Position();
        }
        [NativeFunction("Team", "Produces the name of a football team.", "Sport.Football", "function-sport-football-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Football.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportMountaineering
    {
        [NativeFunction("Mountaineer", "Produces the name of a Mountaineer.", "Sport.Mountaineering", "function-sport-mountaineering-Mountaineer.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Mountaineer(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Mountaineering.Mountaineer();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportTeam
    {
        [NativeFunction("Creature", "Produces a team creature.", "Sport.Team", "function-sport-team-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Team.Creature();
        }
        [NativeFunction("Mascot", "Produces the name of a team mascot.", "Sport.Team", "function-sport-team-Mascot.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Mascot(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Team.Mascot();
        }
        [NativeFunction("Name", "Produces a team name from a state and a creature.", "Sport.Team", "function-sport-team-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Team.Name();
        }
        [NativeFunction("Sport", "Produces a team sport.", "Sport.Team", "function-sport-team-Sport.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Sport(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Team.Sport();
        }
        [NativeFunction("State", "Produces a team state.", "Sport.Team", "function-sport-team-State.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string State(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Team.State();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportVolleyball
    {
        [NativeFunction("Coach", "Produces the name of a volleyball coach.", "Sport.Volleyball", "function-sport-volleyball-Coach.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Coach(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Volleyball.Coach();
        }
        [NativeFunction("Formation", "Produces a formation in volleyball.", "Sport.Volleyball", "function-sport-volleyball-Formation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Formation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Volleyball.Formation();
        }
        [NativeFunction("Player", "Produces the name of a volleyball player.", "Sport.Volleyball", "function-sport-volleyball-Player.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Player(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Volleyball.Player();
        }
        [NativeFunction("Position", "Produces a position in volleyball.", "Sport.Volleyball", "function-sport-volleyball-Position.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Position(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Volleyball.Position();
        }
        [NativeFunction("Team", "Produces the name of a volleyball team.", "Sport.Volleyball", "function-sport-volleyball-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.Volleyball.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterSportWorldCup
    {
        [NativeFunction("City", "Produces a city name hosting the World Cup match.", "Sport.WorldCup", "function-sport-worldcup-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WorldCup.City();
        }
        [NativeFunction("Group", "Produces a random national team name from a group.", "Sport.WorldCup", "function-sport-worldcup-Group.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Group(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("group", "", IsOptional = true, OptionalDesc = "'group_A'", Default = "group_A")] string group
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WorldCup.Group(group);
        }
        [NativeFunction("Roster", "Produces a random name from national team roster.", "Sport.WorldCup", "function-sport-worldcup-Roster.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Roster(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("country", "", IsOptional = true, OptionalDesc = "'Egypt'", Default = "Egypt")] string country
            , [ArgumentProperty("type", "", IsOptional = true, OptionalDesc = "'coach'", Default = "coach")] string type
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WorldCup.Roster(country, type);
        }
        [NativeFunction("Stadium", "Produces the name of a stadium that has hosted a World Cup match.", "Sport.WorldCup", "function-sport-worldcup-Stadium.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Stadium(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WorldCup.Stadium();
        }
        [NativeFunction("Team", "Produces a national team name.", "Sport.WorldCup", "function-sport-worldcup-Team.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Team(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Sport.WorldCup.Team();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThings
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThingsCamera
    {
        [NativeFunction("Brand", "Produces a brand of a camera.", "Things.Camera", "function-things-camera-Brand.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Brand(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Camera.Brand();
        }
        [NativeFunction("BrandWithModel", "Produces a brand with model.", "Things.Camera", "function-things-camera-BrandWithModel.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BrandWithModel(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Camera.BrandWithModel();
        }
        [NativeFunction("Model", "Produces a model of camera.", "Things.Camera", "function-things-camera-Model.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Model(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Camera.Model();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThingsDrone
    {
        [NativeFunction("BatteryCapacity", "Returns the drone battery capacity.", "Things.Drone", "function-things-drone-BatteryCapacity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BatteryCapacity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.BatteryCapacity();
        }
        [NativeFunction("BatteryType", "Returns the battery type.", "Things.Drone", "function-things-drone-BatteryType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BatteryType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.BatteryType();
        }
        [NativeFunction("BatteryVoltage", "Returns battery voltage.", "Things.Drone", "function-things-drone-BatteryVoltage.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BatteryVoltage(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.BatteryVoltage();
        }
        [NativeFunction("BatteryWeight", "Returns total battery weight in grams.", "Things.Drone", "function-things-drone-BatteryWeight.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BatteryWeight(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.BatteryWeight();
        }
        [NativeFunction("ChargingTemperature", "Returns charging temperature for battery in Fahrenheit.", "Things.Drone", "function-things-drone-ChargingTemperature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ChargingTemperature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.ChargingTemperature();
        }
        [NativeFunction("FlightTime", "Returns max flight time for drone in optimal conditions.", "Things.Drone", "function-things-drone-FlightTime.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FlightTime(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.FlightTime();
        }
        [NativeFunction("Iso", "Returns camera ISO range for drone.", "Things.Drone", "function-things-drone-Iso.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Iso(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.Iso();
        }
        [NativeFunction("MaxAltitude", "Returns max altitude drone can go above sea level in meters.", "Things.Drone", "function-things-drone-MaxAltitude.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxAltitude(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxAltitude();
        }
        [NativeFunction("MaxAngularVelocity", "Returns max angular velocity of drone in degrees/s.", "Things.Drone", "function-things-drone-MaxAngularVelocity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxAngularVelocity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxAngularVelocity();
        }
        [NativeFunction("MaxAscentSpeed", "Returns maximum ascent speed for drone in m/s.", "Things.Drone", "function-things-drone-MaxAscentSpeed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxAscentSpeed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxAscentSpeed();
        }
        [NativeFunction("MaxChargingPower", "Returns max chargin power required for battery.", "Things.Drone", "function-things-drone-MaxChargingPower.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxChargingPower(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxChargingPower();
        }
        [NativeFunction("MaxDescentSpeed", "Returns maximum descent speed for drone in m/s.", "Things.Drone", "function-things-drone-MaxDescentSpeed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxDescentSpeed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxDescentSpeed();
        }
        [NativeFunction("MaxFlightDistance", "Returns how far drone can go in optimal condition when full charged in meters.", "Things.Drone", "function-things-drone-MaxFlightDistance.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxFlightDistance(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxFlightDistance();
        }
        [NativeFunction("MaxResolution", "Returns max camera resolution in MP\".\n                            <p>Returns max camera resolution in MP“</p>", "Things.Drone", "function-things-drone-MaxResolution.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxResolution(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxResolution();
        }
        [NativeFunction("MaxShutterSpeed", "Returns max shutter speed for camera.", "Things.Drone", "function-things-drone-MaxShutterSpeed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxShutterSpeed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxShutterSpeed();
        }
        [NativeFunction("MaxSpeed", "Returns max horizontal speed by drone in m/s.", "Things.Drone", "function-things-drone-MaxSpeed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxSpeed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxSpeed();
        }
        [NativeFunction("MaxTiltAngle", "Returns max tilt angle drone can go in degrees.", "Things.Drone", "function-things-drone-MaxTiltAngle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxTiltAngle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxTiltAngle();
        }
        [NativeFunction("MaxWindResistance", "Returns max wind resistance by drone in m/s.", "Things.Drone", "function-things-drone-MaxWindResistance.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MaxWindResistance(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MaxWindResistance();
        }
        [NativeFunction("MinShutterSpeed", "Returns min shutter speed for camera.", "Things.Drone", "function-things-drone-MinShutterSpeed.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string MinShutterSpeed(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.MinShutterSpeed();
        }
        [NativeFunction("Name", "Returns random drone name with company.", "Things.Drone", "function-things-drone-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.Name();
        }
        [NativeFunction("OperatingTemperature", "Returns operating temperature for drone in Fahrenheit.", "Things.Drone", "function-things-drone-OperatingTemperature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string OperatingTemperature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.OperatingTemperature();
        }
        [NativeFunction("PhotoFormat", "Returns photo format for drone.", "Things.Drone", "function-things-drone-PhotoFormat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PhotoFormat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.PhotoFormat();
        }
        [NativeFunction("ShutterSpeedRange", "Returns max and min shutter speed for camera.", "Things.Drone", "function-things-drone-ShutterSpeedRange.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string ShutterSpeedRange(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.ShutterSpeedRange();
        }
        [NativeFunction("VideoFormat", "Returns video format.", "Things.Drone", "function-things-drone-VideoFormat.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string VideoFormat(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.VideoFormat();
        }
        [NativeFunction("Weight", "Returns total drone weight in grams.", "Things.Drone", "function-things-drone-Weight.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Weight(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Drone.Weight();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThingsHobby
    {
        [NativeFunction("Activity", "Retrieves a typical hobby activity.", "Things.Hobby", "function-things-hobby-Activity.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Activity(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Hobby.Activity();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThingsHouse
    {
        [NativeFunction("Furniture", "Produces the name of a piece of furniture.", "Things.House", "function-things-house-Furniture.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Furniture(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.House.Furniture();
        }
        [NativeFunction("Room", "Produces the name of a room in a house.", "Things.House", "function-things-house-Room.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Room(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.House.Room();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterThingsVehicle
    {
        [NativeFunction("CarOptions", "Produces a random list of car options.", "Things.Vehicle", "function-things-vehicle-CarOptions.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static List<string> CarOptions(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.CarOptions();
        }
        [NativeFunction("CarType", "Produces a random car type.", "Things.Vehicle", "function-things-vehicle-CarType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CarType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.CarType();
        }
        [NativeFunction("Color", "Produces a random vehicle color.", "Things.Vehicle", "function-things-vehicle-Color.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Color(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Color();
        }
        [NativeFunction("Doors", "Produces a random vehicle door count.", "Things.Vehicle", "function-things-vehicle-Doors.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static long Doors(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Doors();
        }
        [NativeFunction("DriveType", "Produces a random vehicle drive type.", "Things.Vehicle", "function-things-vehicle-DriveType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string DriveType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.DriveType();
        }
        [NativeFunction("Engine", "Produces a random engine cylinder count.", "Things.Vehicle", "function-things-vehicle-Engine.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Engine(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Engine();
        }
        [NativeFunction("FuelType", "Produces a random vehicle fuel type.", "Things.Vehicle", "function-things-vehicle-FuelType.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string FuelType(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.FuelType();
        }
        [NativeFunction("LicensePlate", "Produces a random license plate number.", "Things.Vehicle", "function-things-vehicle-LicensePlate.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string LicensePlate(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("stateAbbreviation", "", IsOptional = true, OptionalDesc = "''", Default = "")] string stateAbbreviation
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.LicensePlate(stateAbbreviation);
        }
        [NativeFunction("Make", "Produces a random vehicle make.", "Things.Vehicle", "function-things-vehicle-Make.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Make(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Make();
        }
        #warning No implementation defined for method make_and_model
        [NativeFunction("Manufacture", "Produces a random vehicle manufacturer.", "Things.Vehicle", "function-things-vehicle-Manufacture.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Manufacture(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Manufacture();
        }
        #warning No implementation defined for method mileage
        [NativeFunction("Model", "Produces a random vehicle model.", "Things.Vehicle", "function-things-vehicle-Model.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Model(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("makeOfModel", "", IsOptional = true, OptionalDesc = "''", Default = "")] string makeOfModel
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Model(makeOfModel);
        }
        #warning Failed processing method singapore_checksum : method has no name or return type.
        #warning No implementation defined for method singapore_license_plate
        [NativeFunction("StandardSpecs", "Produces a random list of standard specs.", "Things.Vehicle", "function-things-vehicle-StandardSpecs.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static List<string> StandardSpecs(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.StandardSpecs();
        }
        [NativeFunction("Style", "Produces a random vehicle style.", "Things.Vehicle", "function-things-vehicle-Style.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Style(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Style();
        }
        [NativeFunction("Transmission", "Produces a random vehicle transmission.", "Things.Vehicle", "function-things-vehicle-Transmission.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Transmission(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Transmission();
        }
        [NativeFunction("Version", "Produces a car version.", "Things.Vehicle", "function-things-vehicle-Version.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Version(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Things.Vehicle.Version();
        }
        #warning No implementation defined for method vin
        #warning No implementation defined for method year
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTravel
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTravelAirport
    {
        [NativeFunction("Iata", "Produces random Airport by IATA code and takes arguments for size and region.\n                                \n\n                                <p>Faker::Travel::Airport.iata(size: ‘large’, region: ‘united_states’) =&gt; “LAX”</p>", "Travel.Airport", "function-travel-airport-Iata.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Iata(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("size", "")] string size
            , [ArgumentProperty("region", "")] string region
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Travel.Airport.Iata(size, region);
        }
        [NativeFunction("Name", "Produces random Airport by name and takes arguments for size and region.\n                                \n\n                                <p>Faker::Travel::Airport.name(size: ‘large’, region: ‘united_states’) =&gt; “Los Angeles International Airport”</p>", "Travel.Airport", "function-travel-airport-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("size", "")] string size
            , [ArgumentProperty("region", "")] string region
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Travel.Airport.Name(size, region);
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTravelTrainStation
    {
        #warning No implementation defined for method fill_missing_inputs_with_samples
        [NativeFunction("Name", "Produces random Train Station by name and takes optional arguments for region and type.\n                                \n\n                                <p>Faker::Travel::TrainStation.name(region: ‘united_kingdom’, type: ‘metro’) =&gt; “Brockley” Faker::Travel::TrainStation.name(type: ‘railway’) =&gt; “Düsseldorf Hauptbahnhof” Faker::Travel::TrainStation.name(region: ‘spain’) =&gt; “Santa Eulàlia”</p>", "Travel.TrainStation", "function-travel-trainstation-Name.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Name(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("region", "")] string region
            , [ArgumentProperty("type", "", IsOptional = true, OptionalDesc = "nil")] string? type
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Travel.TrainStation.Name(region, type);
        }
        #warning No implementation defined for method validate_arguments
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShows
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsAquaTeenHungerForce
    {
        [NativeFunction("Character", "Produces a character from Aqua Teen Hunger Force.", "TvShows.AquaTeenHungerForce", "function-tvshows-aquateenhungerforce-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.AquaTeenHungerForce.Character();
        }
        [NativeFunction("Quote", "Produces a perl of great ATHF wisdom.", "TvShows.AquaTeenHungerForce", "function-tvshows-aquateenhungerforce-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.AquaTeenHungerForce.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsArcher
    {
        [NativeFunction("Character", "Produces a character from Archer.", "TvShows.Archer", "function-tvshows-archer-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Archer.Character();
        }
        [NativeFunction("Location", "Produces a location from Archer.", "TvShows.Archer", "function-tvshows-archer-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Archer.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Archer.", "TvShows.Archer", "function-tvshows-archer-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Archer.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsBigBangTheory
    {
        [NativeFunction("Character", "Produces a character from Big Bang Theory.", "TvShows.BigBangTheory", "function-tvshows-bigbangtheory-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BigBangTheory.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Bing Bang Theory.", "TvShows.BigBangTheory", "function-tvshows-bigbangtheory-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BigBangTheory.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsBojackHorseman
    {
        [NativeFunction("Character", "Produces a character from BoJack Horseman.", "TvShows.BojackHorseman", "function-tvshows-bojackhorseman-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BojackHorseman.Character();
        }
        [NativeFunction("Quote", "Produces a quote from BoJack Horseman.", "TvShows.BojackHorseman", "function-tvshows-bojackhorseman-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BojackHorseman.Quote();
        }
        [NativeFunction("TongueTwister", "Produces a tongue twister from BoJack Horseman.", "TvShows.BojackHorseman", "function-tvshows-bojackhorseman-TongueTwister.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TongueTwister(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BojackHorseman.TongueTwister();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsBreakingBad
    {
        [NativeFunction("Character", "Produces the name of a character from Breaking Bad.", "TvShows.BreakingBad", "function-tvshows-breakingbad-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BreakingBad.Character();
        }
        [NativeFunction("Episode", "Produces the name of an episode from Breaking Bad.", "TvShows.BreakingBad", "function-tvshows-breakingbad-Episode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Episode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BreakingBad.Episode();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsBrooklynNineNine
    {
        [NativeFunction("Character", "Produces a character from Brooklyn Nine Nine.", "TvShows.BrooklynNineNine", "function-tvshows-brooklynninenine-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BrooklynNineNine.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Brooklyn Nine Nine.", "TvShows.BrooklynNineNine", "function-tvshows-brooklynninenine-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.BrooklynNineNine.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsBuffy
    {
        [NativeFunction("Actor", "Produces a actor from Buffy the Vampire Slayer.", "TvShows.Buffy", "function-tvshows-buffy-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Buffy.Actor();
        }
        [NativeFunction("BigBad", "Produces a big bad from Buffy the Vampire Slayer.", "TvShows.Buffy", "function-tvshows-buffy-BigBad.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string BigBad(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Buffy.BigBad();
        }
        [NativeFunction("Character", "Produces a character from Buffy the Vampire Slayer.", "TvShows.Buffy", "function-tvshows-buffy-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Buffy.Character();
        }
        [NativeFunction("Episode", "Produces an episode from Buffy the Vampire Slayer.", "TvShows.Buffy", "function-tvshows-buffy-Episode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Episode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Buffy.Episode();
        }
        [NativeFunction("Quote", "Produces a quote from Buffy the Vampire Slayer.", "TvShows.Buffy", "function-tvshows-buffy-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Buffy.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsCommunity
    {
        [NativeFunction("Characters", "Produces a character from Community.", "TvShows.Community", "function-tvshows-community-Characters.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Characters(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Community.Characters();
        }
        [NativeFunction("Quotes", "Produces a quote from Community.", "TvShows.Community", "function-tvshows-community-Quotes.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quotes(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Community.Quotes();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsDrWho
    {
        [NativeFunction("Actor", "Produces an actor from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.Actor();
        }
        [NativeFunction("CatchPhrase", "Produces a catch phrase from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-CatchPhrase.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CatchPhrase(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.CatchPhrase();
        }
        [NativeFunction("Character", "Produces a character from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.Quote();
        }
        [NativeFunction("Specie", "Produces a species from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-Specie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Specie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.Specie();
        }
        [NativeFunction("TheDoctor", "Produces an iteration of The Doctor from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-TheDoctor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string TheDoctor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.TheDoctor();
        }
        [NativeFunction("Villain", "Produces a villain from Doctor Who.", "TvShows.DrWho", "function-tvshows-drwho-Villain.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Villain(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DrWho.Villain();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsDumbAndDumber
    {
        [NativeFunction("Actor", "Produces an actor from Dumb and Dumber.", "TvShows.DumbAndDumber", "function-tvshows-dumbanddumber-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DumbAndDumber.Actor();
        }
        [NativeFunction("Character", "Produces a character from Dumb and Dumber.", "TvShows.DumbAndDumber", "function-tvshows-dumbanddumber-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DumbAndDumber.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Dumb and Dumber.", "TvShows.DumbAndDumber", "function-tvshows-dumbanddumber-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.DumbAndDumber.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsFamilyGuy
    {
        [NativeFunction("Character", "Produces a character from Family Guy.", "TvShows.FamilyGuy", "function-tvshows-familyguy-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FamilyGuy.Character();
        }
        [NativeFunction("Location", "Produces a location from Family Guy.", "TvShows.FamilyGuy", "function-tvshows-familyguy-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FamilyGuy.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Family Guy.", "TvShows.FamilyGuy", "function-tvshows-familyguy-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FamilyGuy.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsFinalSpace
    {
        [NativeFunction("Character", "Produces a character from Final Space.", "TvShows.FinalSpace", "function-tvshows-finalspace-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FinalSpace.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Final Space.", "TvShows.FinalSpace", "function-tvshows-finalspace-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FinalSpace.Quote();
        }
        [NativeFunction("Vehicle", "Produces a vehicle from Final Space.", "TvShows.FinalSpace", "function-tvshows-finalspace-Vehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.FinalSpace.Vehicle();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsFriends
    {
        [NativeFunction("Character", "Produces a character from Friends.", "TvShows.Friends", "function-tvshows-friends-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Friends.Character();
        }
        [NativeFunction("Location", "Produces a location from Friends.", "TvShows.Friends", "function-tvshows-friends-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Friends.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Friends.", "TvShows.Friends", "function-tvshows-friends-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Friends.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsFuturama
    {
        [NativeFunction("Character", "Produces a character from Futurama.", "TvShows.Futurama", "function-tvshows-futurama-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Futurama.Character();
        }
        [NativeFunction("HermesCatchphrase", "Produces a catchphrase from Hermes Conrad.", "TvShows.Futurama", "function-tvshows-futurama-HermesCatchphrase.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HermesCatchphrase(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Futurama.HermesCatchphrase();
        }
        [NativeFunction("Location", "Produces a location from Futurama.", "TvShows.Futurama", "function-tvshows-futurama-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Futurama.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Futurama.", "TvShows.Futurama", "function-tvshows-futurama-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Futurama.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsGameOfThrones
    {
        [NativeFunction("Character", "Produces a character from Game of Thrones.", "TvShows.GameOfThrones", "function-tvshows-gameofthrones-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.GameOfThrones.Character();
        }
        [NativeFunction("City", "Produces a city from Game of Thrones.", "TvShows.GameOfThrones", "function-tvshows-gameofthrones-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.GameOfThrones.City();
        }
        [NativeFunction("Dragon", "Produces a dragon from Game of Thrones.", "TvShows.GameOfThrones", "function-tvshows-gameofthrones-Dragon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Dragon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.GameOfThrones.Dragon();
        }
        [NativeFunction("House", "Produces a house from Game of Thrones.", "TvShows.GameOfThrones", "function-tvshows-gameofthrones-House.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string House(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.GameOfThrones.House();
        }
        [NativeFunction("Quote", "Produces a quote from Game of Thrones.", "TvShows.GameOfThrones", "function-tvshows-gameofthrones-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.GameOfThrones.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsHeyArnold
    {
        [NativeFunction("Character", "Produces a character from Hey Arnold!.", "TvShows.HeyArnold", "function-tvshows-heyarnold-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HeyArnold.Character();
        }
        [NativeFunction("Location", "Produces a location from Hey Arnold!.", "TvShows.HeyArnold", "function-tvshows-heyarnold-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HeyArnold.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Hey Arnold!.", "TvShows.HeyArnold", "function-tvshows-heyarnold-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HeyArnold.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsHowIMetYourMother
    {
        [NativeFunction("CatchPhrase", "Produces a catch phrase from How I Met Your Mother.", "TvShows.HowIMetYourMother", "function-tvshows-howimetyourmother-CatchPhrase.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string CatchPhrase(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HowIMetYourMother.CatchPhrase();
        }
        [NativeFunction("Character", "Produces a character from How I Met Your Mother.", "TvShows.HowIMetYourMother", "function-tvshows-howimetyourmother-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HowIMetYourMother.Character();
        }
        [NativeFunction("HighFive", "Produces a high five from How I Met Your Mother.", "TvShows.HowIMetYourMother", "function-tvshows-howimetyourmother-HighFive.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string HighFive(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HowIMetYourMother.HighFive();
        }
        [NativeFunction("Quote", "Produces a quote from How I Met Your Mother.", "TvShows.HowIMetYourMother", "function-tvshows-howimetyourmother-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.HowIMetYourMother.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsMichaelScott
    {
        [NativeFunction("Quote", "Produces a quote from Michael Scott.", "TvShows.MichaelScott", "function-tvshows-michaelscott-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.MichaelScott.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsNewGirl
    {
        [NativeFunction("Character", "Produces a character from New Girl.", "TvShows.NewGirl", "function-tvshows-newgirl-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.NewGirl.Character();
        }
        [NativeFunction("Quote", "Produces a quote from New Girl.", "TvShows.NewGirl", "function-tvshows-newgirl-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.NewGirl.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsParksAndRec
    {
        [NativeFunction("Character", "Produces a character from Parks and Recreation.", "TvShows.ParksAndRec", "function-tvshows-parksandrec-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.ParksAndRec.Character();
        }
        [NativeFunction("City", "Produces a city from Parks and Recreation.", "TvShows.ParksAndRec", "function-tvshows-parksandrec-City.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string City(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.ParksAndRec.City();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsRickAndMorty
    {
        [NativeFunction("Character", "Produces a character from Rick and Morty.", "TvShows.RickAndMorty", "function-tvshows-rickandmorty-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.RickAndMorty.Character();
        }
        [NativeFunction("Location", "Produces a location from Rick and Morty.", "TvShows.RickAndMorty", "function-tvshows-rickandmorty-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.RickAndMorty.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Rick and Morty.", "TvShows.RickAndMorty", "function-tvshows-rickandmorty-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.RickAndMorty.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsRuPaul
    {
        [NativeFunction("Queen", "Produces a queen from RuPaul's Drag Race.", "TvShows.RuPaul", "function-tvshows-rupaul-Queen.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Queen(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.RuPaul.Queen();
        }
        [NativeFunction("Quote", "Produces a quote from RuPaul's Drag Race.", "TvShows.RuPaul", "function-tvshows-rupaul-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.RuPaul.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSeinfeld
    {
        [NativeFunction("Business", "Produces a business from Seinfeld.", "TvShows.Seinfeld", "function-tvshows-seinfeld-Business.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Business(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Seinfeld.Business();
        }
        [NativeFunction("Character", "Produces a character from Seinfeld.", "TvShows.Seinfeld", "function-tvshows-seinfeld-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Seinfeld.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Seinfeld.", "TvShows.Seinfeld", "function-tvshows-seinfeld-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Seinfeld.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSiliconValley
    {
        [NativeFunction("App", "Produces an app from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-App.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string App(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.App();
        }
        [NativeFunction("Character", "Produces a character from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Character();
        }
        [NativeFunction("Company", "Produces a company from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Company.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Company(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Company();
        }
        [NativeFunction("Email", "Produces an email address from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Email.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Email(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Email();
        }
        [NativeFunction("Invention", "Produces an invention from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Invention.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Invention(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Invention();
        }
        [NativeFunction("Motto", "Produces a motto from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Motto.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Motto(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Motto();
        }
        [NativeFunction("Quote", "Produces a quote from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Quote();
        }
        [NativeFunction("Url", "Produces a URL from Silicon Valley.", "TvShows.SiliconValley", "function-tvshows-siliconvalley-Url.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Url(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SiliconValley.Url();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSimpsons
    {
        [NativeFunction("Character", "Produces a character from The Simpsons.", "TvShows.Simpsons", "function-tvshows-simpsons-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Simpsons.Character();
        }
        [NativeFunction("EpisodeTitle", "Produces an episode title from The Simpsons.", "TvShows.Simpsons", "function-tvshows-simpsons-EpisodeTitle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string EpisodeTitle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Simpsons.EpisodeTitle();
        }
        [NativeFunction("Location", "Produces a location from The Simpsons.", "TvShows.Simpsons", "function-tvshows-simpsons-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Simpsons.Location();
        }
        [NativeFunction("Quote", "Produces a quote from The Simpsons.", "TvShows.Simpsons", "function-tvshows-simpsons-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Simpsons.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSouthPark
    {
        [NativeFunction("Character", "Produces a character from South Park.", "TvShows.SouthPark", "function-tvshows-southpark-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SouthPark.Character();
        }
        [NativeFunction("EpisodeName", "Produces an episode name from South Park.", "TvShows.SouthPark", "function-tvshows-southpark-EpisodeName.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string EpisodeName(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SouthPark.EpisodeName();
        }
        [NativeFunction("Quote", "Produces a quote from South Park.", "TvShows.SouthPark", "function-tvshows-southpark-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.SouthPark.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSpongebob
    {
        [NativeFunction("Character", "Produces a character from Spongebob.", "TvShows.Spongebob", "function-tvshows-spongebob-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Spongebob.Character();
        }
        [NativeFunction("Episode", "Produces an episode from Spongebob.", "TvShows.Spongebob", "function-tvshows-spongebob-Episode.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Episode(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Spongebob.Episode();
        }
        [NativeFunction("Quote", "Produces a quote from Spongebob.", "TvShows.Spongebob", "function-tvshows-spongebob-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Spongebob.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsStargate
    {
        [NativeFunction("Character", "Produces a character from Stargate.", "TvShows.Stargate", "function-tvshows-stargate-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Stargate.Character();
        }
        [NativeFunction("Planet", "Produces a planet from Stargate.", "TvShows.Stargate", "function-tvshows-stargate-Planet.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Planet(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Stargate.Planet();
        }
        [NativeFunction("Quote", "Produces a quote from Stargate.", "TvShows.Stargate", "function-tvshows-stargate-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Stargate.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsStarTrek
    {
        [NativeFunction("Character", "Produces a character from Star Trek.", "TvShows.StarTrek", "function-tvshows-startrek-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StarTrek.Character();
        }
        [NativeFunction("Location", "Produces a location from Star Trek.", "TvShows.StarTrek", "function-tvshows-startrek-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StarTrek.Location();
        }
        [NativeFunction("Specie", "Produces a species from Star Trek.", "TvShows.StarTrek", "function-tvshows-startrek-Specie.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Specie(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StarTrek.Specie();
        }
        [NativeFunction("Villain", "Produces a villain from Star Trek.", "TvShows.StarTrek", "function-tvshows-startrek-Villain.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Villain(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StarTrek.Villain();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsStrangerThings
    {
        [NativeFunction("Character", "Produces a quote from Stranger Things.", "TvShows.StrangerThings", "function-tvshows-strangerthings-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StrangerThings.Character();
        }
        [NativeFunction("Quote", "Produces a character from Stranger Things.", "TvShows.StrangerThings", "function-tvshows-strangerthings-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.StrangerThings.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSuits
    {
        [NativeFunction("Character", "Produces a character from Suits.", "TvShows.Suits", "function-tvshows-suits-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Suits.Character();
        }
        [NativeFunction("Quote", "Produces a quote from Suits.", "TvShows.Suits", "function-tvshows-suits-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Suits.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsSupernatural
    {
        [NativeFunction("Character", "Produces the name of a character from Supernatural.", "TvShows.Supernatural", "function-tvshows-supernatural-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Supernatural.Character();
        }
        [NativeFunction("Creature", "Produces the name of a hunted creature.", "TvShows.Supernatural", "function-tvshows-supernatural-Creature.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Creature(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Supernatural.Creature();
        }
        [NativeFunction("Weapon", "Produces the name of a weapon used by the hunters.", "TvShows.Supernatural", "function-tvshows-supernatural-Weapon.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Weapon(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.Supernatural.Weapon();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTheExpanse
    {
        [NativeFunction("Character", "Produces a character from The Expanse.", "TvShows.TheExpanse", "function-tvshows-theexpanse-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheExpanse.Character();
        }
        [NativeFunction("Location", "Produces a location from The Expanse.", "TvShows.TheExpanse", "function-tvshows-theexpanse-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheExpanse.Location();
        }
        [NativeFunction("Quote", "Produces a quote from The Expanse.", "TvShows.TheExpanse", "function-tvshows-theexpanse-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheExpanse.Quote();
        }
        [NativeFunction("Ship", "Produces a ship from The Expanse.", "TvShows.TheExpanse", "function-tvshows-theexpanse-Ship.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ship(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheExpanse.Ship();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTheFreshPrinceOfBelAir
    {
        [NativeFunction("Actor", "Produces a actor from The Fresh Prince of Bel-Air.", "TvShows.TheFreshPrinceOfBelAir", "function-tvshows-thefreshprinceofbelair-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheFreshPrinceOfBelAir.Actor();
        }
        [NativeFunction("Character", "Produces a character from The Fresh Prince of Bel-Air.", "TvShows.TheFreshPrinceOfBelAir", "function-tvshows-thefreshprinceofbelair-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheFreshPrinceOfBelAir.Character();
        }
        [NativeFunction("Quote", "Produces a quote from The Fresh Prince of Bel-Air.", "TvShows.TheFreshPrinceOfBelAir", "function-tvshows-thefreshprinceofbelair-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheFreshPrinceOfBelAir.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTheITCrowd
    {
        [NativeFunction("Actor", "Produces an actor from The IT Crowd.", "TvShows.TheITCrowd", "function-tvshows-theitcrowd-Actor.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Actor(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheITCrowd.Actor();
        }
        [NativeFunction("Character", "Produces a character from The IT Crowd.", "TvShows.TheITCrowd", "function-tvshows-theitcrowd-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheITCrowd.Character();
        }
        [NativeFunction("Email", "Produces an email from The IT Crowd.", "TvShows.TheITCrowd", "function-tvshows-theitcrowd-Email.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Email(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheITCrowd.Email();
        }
        [NativeFunction("Quote", "Produces a quote from The IT Crowd.", "TvShows.TheITCrowd", "function-tvshows-theitcrowd-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheITCrowd.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTheOffice
    {
        [NativeFunction("Character", "Produces a character from The Office.", "TvShows.TheOffice", "function-tvshows-theoffice-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheOffice.Character();
        }
        [NativeFunction("Quote", "Produces a quote from The Office.", "TvShows.TheOffice", "function-tvshows-theoffice-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheOffice.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTheThickOfIt
    {
        [NativeFunction("Character", "Produces a character from The Thick of It.", "TvShows.TheThickOfIt", "function-tvshows-thethickofit-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheThickOfIt.Character();
        }
        [NativeFunction("Department", "Produces a department from The Thick of It.", "TvShows.TheThickOfIt", "function-tvshows-thethickofit-Department.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Department(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheThickOfIt.Department();
        }
        [NativeFunction("Position", "Produces a position from The Thick of It.", "TvShows.TheThickOfIt", "function-tvshows-thethickofit-Position.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Position(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TheThickOfIt.Position();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsTwinPeaks
    {
        [NativeFunction("Character", "Produces a character from Twin Peaks.", "TvShows.TwinPeaks", "function-tvshows-twinpeaks-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TwinPeaks.Character();
        }
        [NativeFunction("Location", "Produces a location from Twin Peaks.", "TvShows.TwinPeaks", "function-tvshows-twinpeaks-Location.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Location(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TwinPeaks.Location();
        }
        [NativeFunction("Quote", "Produces a quote from Twin Peaks.", "TvShows.TwinPeaks", "function-tvshows-twinpeaks-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.TwinPeaks.Quote();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTvShowsVentureBros
    {
        [NativeFunction("Character", "Produces a character from The Venture Bros.", "TvShows.VentureBros", "function-tvshows-venturebros-Character.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Character(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.VentureBros.Character();
        }
        [NativeFunction("Organization", "Produces an organization from The Venture Bros.", "TvShows.VentureBros", "function-tvshows-venturebros-Organization.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Organization(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.VentureBros.Organization();
        }
        [NativeFunction("Quote", "Produces a quote from The Venture Bros.", "TvShows.VentureBros", "function-tvshows-venturebros-Quote.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Quote(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.VentureBros.Quote();
        }
        [NativeFunction("Vehicle", "Produces a vehicle from The Venture Bros.", "TvShows.VentureBros", "function-tvshows-venturebros-Vehicle.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Vehicle(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).TvShows.VentureBros.Vehicle();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterTypes
    {
        #warning No implementation defined for method character
        #warning No implementation defined for method complex_rb_hash
        #warning No implementation defined for method random_complex_type
        #warning No implementation defined for method random_type
        #warning No implementation defined for method rb_array
        #warning No implementation defined for method rb_hash
        #warning No implementation defined for method rb_integer
        #warning No implementation defined for method rb_string
        #warning Failed processing method titleize : method has no name or return type.
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWords
    {
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWordsAdjective
    {
        [NativeFunction("Negative", "Produces a negative adjective.", "Words.Adjective", "function-words-adjective-Negative.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Negative(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Adjective.Negative();
        }
        [NativeFunction("Positive", "Produces a positive adjective.", "Words.Adjective", "function-words-adjective-Positive.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Positive(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Adjective.Positive();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWordsEmotion
    {
        [NativeFunction("Adjective", "Produces an emotion adjective.", "Words.Emotion", "function-words-emotion-Adjective.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Adjective(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Emotion.Adjective();
        }
        [NativeFunction("Noun", "Produces an emotion noun.", "Words.Emotion", "function-words-emotion-Noun.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Noun(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Emotion.Noun();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWordsHacker
    {
        [NativeFunction("Abbreviation", "Short technical abbreviations.", "Words.Hacker", "function-words-hacker-Abbreviation.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Abbreviation(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.Abbreviation();
        }
        [NativeFunction("Adjective", "Hacker-centric adjectives.", "Words.Hacker", "function-words-hacker-Adjective.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Adjective(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.Adjective();
        }
        [NativeFunction("Ingverb", "Produces a verb that ends with '-ing'.", "Words.Hacker", "function-words-hacker-Ingverb.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Ingverb(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.Ingverb();
        }
        [NativeFunction("Noun", "Only the best hacker-related nouns.", "Words.Hacker", "function-words-hacker-Noun.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Noun(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.Noun();
        }
        [NativeFunction("SaySomethingSmart", "Produces something smart.", "Words.Hacker", "function-words-hacker-SaySomethingSmart.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SaySomethingSmart(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.SaySomethingSmart();
        }
        [NativeFunction("Verb", "Actions that hackers take.", "Words.Hacker", "function-words-hacker-Verb.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Verb(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Hacker.Verb();
        }
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWordsHipster
    {
        #warning No implementation defined for method paragraph
        #warning No implementation defined for method paragraph_by_chars
        #warning No implementation defined for method paragraphs
        #warning No implementation defined for method sentence
        #warning No implementation defined for method sentences
        #warning No implementation defined for method word
        #warning No implementation defined for method words
    }
    
    [GeneratedCode("Faker Code Generator", "1.0.0.0")]
    [NativeContainer]
    public partial class FakerAdapterWordsVerb
    {
        [NativeFunction("Base", "Produces the base form of a random verb.", "Words.Verb", "function-words-verb-Base.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Base(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Verb.Base();
        }
        [NativeFunction("IngForm", "Produces a random verb in the .ing form.", "Words.Verb", "function-words-verb-IngForm.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string IngForm(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Verb.IngForm();
        }
        [NativeFunction("Past", "Produces a random verb in past tense.", "Words.Verb", "function-words-verb-Past.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string Past(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Verb.Past();
        }
        [NativeFunction("PastParticiple", "Produces a random verb in past participle.", "Words.Verb", "function-words-verb-PastParticiple.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string PastParticiple(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Verb.PastParticiple();
        }
        [NativeFunction("SimplePresent", "Produces a random verb in simple present.", "Words.Verb", "function-words-verb-SimplePresent.png", AccessorType.Method)]
        [return: ArgumentProperty("Value", "")]
        public static string SimplePresent(
              [ArgumentProperty("context", "internal use")] IEvaluationContext context
            , [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale)
        {
            return context.GetFakerInstance(locale).Words.Verb.SimplePresent();
        }
    }
    
}
