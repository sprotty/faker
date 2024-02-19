// Ignore Spelling: Numerify Letterify Regexify yml yaml bothify

using Serilog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FakerNet
{

    /// <summary>
    /// Provides utility methods for generating fake strings, such as names, phone
    /// numbers, addresses. generate random strings with given patterns
    /// </summary>
    public partial class Faker
    {
        internal RandomService randomService;
        private static readonly Regex EXPRESSION_PATTERN = new Regex("#\\{([a-z0-9A-Z_.]+)\\s?((?:,?'([^']+)')*)\\}", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_ARGUMENTS_PATTERN = new Regex("(?:'(.*?)')", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_JAVA_TO_YML_NAME_PATTERN = new Regex("([A-Z])", RegexOptions.Compiled);

        internal ILogger _log = Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        internal ReadOnlyCollection<FakeValuesInterface> _fakeValuesList;
        //private Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>> _methodLookup = new Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>>();
        //private Dictionary<Type, Dictionary<string, PropertyInfo>> _propertyLookup = new Dictionary<Type, Dictionary<string, PropertyInfo>>();
        public RandomService random()
        {
            return this.randomService;
        }

        //private Aviation aviation;
        //private Lorem lorem;
        //private Music music;
        //private Number number;
        //private Internet internet;
        //private PhoneNumber phoneNumber;
        //private Pokemon pokemon;
        //private Address address;
        //private Business business;
        //private Book book;
        //private ChuckNorris chuckNorris;
        //private Color color;
        //private Commerce commerce;
        //private Country country;
        //private Currency currency;
        //private Company company;
        //private Crypto crypto;
        //private IdNumber idNumber;
        //private Hacker hacker;
        //private Options options;
        //private Code code;
        //private Coin coin;
        //private Finance finance;
        //private Food food;
        //private GameOfThrones gameOfThrones;
        //private Gender gender;
        //private DateAndTime dateAndTime;
        //private Demographic demographic;
        //private Dog dog;
        //private Educator educator;
        //private ElderScrolls elderScrolls;
        //private Shakespeare shakespeare;
        //private SlackEmoji slackEmoji;
        //private Space space;
        //private Superhero superhero;
        //private Bool _bool;
        //private Team team;
        //private Beer beer;
        //private University university;
        //private Cat cat;
        //private File file;
        //private Stock stock;
        //private LordOfTheRings lordOfTheRings;
        //private Zelda zelda;
        //private HarryPotter harryPotter;
        //private RockBand rockBand;
        //private Esports esports;
        //private Friends friends;
        //private Hipster hipster;
        //private Job job;
        //private TwinPeaks twinPeaks;
        //private RickAndMorty rickAndMorty;
        //private Yoda yoda;
        //private Matz matz;
        //private Witcher witcher;
        //private DragonBall dragonBall;
        //private FunnyName funnyName;
        //private HitchhikersGuideToTheGalaxy hitchhikersGuideToTheGalaxy;
        //private Hobbit hobbit;
        //private HowIMetYourMother howIMetYourMother;
        //private LeagueOfLegends leagueOfLegends;
        //private Overwatch overwatch;
        //private Robin robin;
        //private StarTrek starTrek;
        //private Weather weather;
        //private Lebowski lebowski;
        //private Medical medical;
        //private Animal animal;
        //private BackToTheFuture backToTheFuture;
        //private PrincessBride princessBride;
        //private Buffy buffy;
        //private Relationships relationships;
        //private Nation nation;
        //private Dune dune;
        //private AquaTeenHungerForce aquaTeenHungerForce;
        //private ProgrammingLanguage programmingLanguage;
        //private Kaamelott kaamelott;
        //private Photography photography;
        //private StarCraft starCraft;
        //private BojackHorseman bojackHorseman;
        //private Disease disease;
        //private Basketball basketball;
        //private Barcode barcode;
        //private Sip sip;
        //private EnglandFootBall englandfootball;
        //private Mountain mountain;

        #region Constructor
        public Faker()
        : this(UtilityMethods.EnglishCulture)
        {

        }

        public Faker(CultureInfo locale)
            : this(locale, (Random)null)
        {

        }

        public Faker(Random random)
            : this(UtilityMethods.EnglishCulture, random)
        {

        }

        public Faker(CultureInfo locale, Random random)
            : this(locale, new RandomService(random))
        {

        }

        #region Init
        /// <summary>
        /// Loads all the YAML files for the given locale
        /// Analysis of the YAML files is done on demand
        /// </summary>
        /// <param name="locale">The locale to load the YAML files for</param>
        /// <param name="randomService"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <remarks>
        /// Resolves YAML file using the most specific path first based on language and country code.
        ///     'en_US' would resolve in the following order:
        ///         /en-US.yml
        ///         /en.yml
        /// The search is case-insensitive, so the following will all resolve correctly.Also, either a hyphen or
        /// an underscore can be used when constructing a <see cref="CultureInfo"/>
        /// instance.This is legacy behaviour and not condoned, but it will work.
        /// </remarks>
        [MemberNotNull(nameof(_fakeValuesList))]
        [MemberNotNull(nameof(Locale))]
        private void Init(CultureInfo locale)
        {
            if (locale == null) throw new ArgumentNullException("locale is required");
            //if (locale.Name == "es-AR")
            //    Debug.WriteLine("Local : " + locale.Name);
            try
            {
                var r = new RegionInfo(locale.LCID);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException("The culture must be associated with a region (i.e. 'en-GB')", nameof(locale), ae);
            }

            //locale = normalizeLocale(locale);

            CultureInfo[] locales = locale.GetLocaleChain();
            List<FakeValuesInterface> all = new List<FakeValuesInterface>(locales.Length);

            foreach (CultureInfo l in locales)
            {
                bool isEnglish = l.Equals(UtilityMethods.EnglishCulture);
                if (isEnglish)
                {
                    FakeValuesGrouping fakeValuesGrouping = new FakeValuesGrouping();
                    foreach (EnFile file in EnFile.AllFiles)
                    {
                        fakeValuesGrouping.add(new FakeValues(l, file.getFile(), file.getPath()));
                    }
                    all.Add(fakeValuesGrouping);
                }
                else
                {
                    all.Add(new FakeValues(l));
                }
            }

            this.Locale = locale;
            this._fakeValuesList = all.AsReadOnly();
        }
        #endregion
        #endregion

        public CultureInfo Locale { get; private set; }

        #region Exported Methods
        

        /**
         * Generates a string that matches the given regular expression.
         */
        [FakerMethod("lower")]
        public string Lower(string str)
        {
            return str.ToLower();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [FakerMethod("random_float")]
        public string RandomFloatAsString(FloatRange rng)
        {
            return randomService.nextDouble(rng.Min, rng.Max).ToString("R");
        }
        #endregion


 







        //       /// <summary>
        //       /// Given a regular expression, attempt to generate a string
        //       /// </summary>
        //       /// <param name=""></param>
        //       /// <returns></returns>
        //       /// that would match it.  This is a rather simple implementation,
        //       /// so don't be shocked if it blows up on you in a spectacular fashion.
        //       ///
        //       /// It does not handle ., *, unbounded ranges such as {1,},
        //       /// extensions such as (?=), character classes, some abbreviations
        //       /// for character classes, and nested parentheses.
        //       ///
        //       /// I told you it was simple. :) It's also probably dog-slow,
        //       /// so you shouldn't use it.
        //       ///
        //       /// It will take a regex like this:
        //       ///
        //       /// /^[A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}$/
        //       ///
        //       /// and generate a string like this:
        //       ///
        //       /// "U3V  3TP"
        //       ///
        //       protected string regexify(string reg)
        //       {
        //           //    reg = reg.source if reg.respond_to ? (: source) # Handle either a Regexp or a String that looks like a Regexp
        //           //reg
        //           //      .gsub(% r{ ^/?\^?}, '').gsub(% r{\$?/?$}, '') # Ditch the anchors
        //           //  .gsub(/\{ (\d +)\}/, '{\1,\1}').gsub('?', '{0,1}') # All {2} become {2,2} and ? become {0,1}
        //           //  .gsub(/ (\[[^\]] +\])\{ (\d +),(\d +)\}/) { | _match | Regexp.last_match(1) * sample(Array(Range.new(Regexp.last_match(2).to_i, Regexp.last_match(3).to_i))) }                # [12]{1,2} becomes [12] or [12][12]
        //           //  .gsub(/ (\([^)]+\))\{ (\d +),(\d +)\}/) { | _match | Regexp.last_match(1) * sample(Array(Range.new(Regexp.last_match(2).to_i, Regexp.last_match(3).to_i))) }                 # (12|34){1,2} becomes (12|34) or (12|34)(12|34)
        //           //  .gsub(/ (\\?.)\{ (\d +),(\d +)\}/) { | _match | Regexp.last_match(1) * sample(Array(Range.new(Regexp.last_match(2).to_i, Regexp.last_match(3).to_i))) }                      # A{1,2} becomes A or AA or \d{3} becomes \d\d\d
        //           //  .gsub(/\((.*?)\) /) { | match | sample(match.gsub(/ [()] /, '').split('|')) } # (this|that) becomes 'this' or 'that'
        //           //  .gsub(/\[([^\]] +)\]/) { | match | match.gsub(/ (\w -\w) /) { | range | sample(Array(Range.new(*range.split('-')))) } } # All A-Z inside of [] become C (or X, or whatever)
        //           //  .gsub(/\[([^\]] +)\]/) { | _match | sample(Regexp.last_match(1).chars) } # All [ABC] become B (or A or C)
        //           //  .gsub('\d') { | _match | sample(Numbers) }
        //           //  .gsub('\w') { | _match | sample(Letters) }
        //           throw new TodoException();
        //       }

        //       /// <summary>
        //       /// Helper for the common approach of grabbing a translation
        //       /// with an array of values and selecting one of them.
        //       /// </summary>
        //       /// <param name=""></param>
        //       /// <returns></returns>
        //       internal string fetch(string key)
        //       {
        //           var fetched = sample(translate("faker.#{key}"));
        //           if (isSlashDelimitedRegex(fetched))
        //               fetched = regexify(fetched);
        //           return fetched;
        //       }


        //       internal string sample(List<string> list)
        //       {
        //           return this.randomService.Item(list);
        //       }
        //       internal List<string> sample(List<string> list, int num)
        //       {
        //           throw new NotImplementedException();
        //           //    if list.respond_to ? (: sample)
        //           //      if num
        //           //    list.sample(num, random: Faker::Config.random)
        //           //  else
        //           //            list.sample(random: Faker::Config.random)
        //           //  end
        //           //else
        //           //        list
        //           //      end
        //       }


        //       /// <summary>
        //       /// Call I18n.translate with our configured locale if no locale is specified
        //       /// </summary>
        //       /// <param name=""></param>
        //       /// <param name="opts"></param>
        //       /// <returns></returns>
        //       protected string[] translate(params string[] args/*, ** opts*/)
        //       {
        //           // see I18n.load_path += Dir[File.join(mydir, 'locales', '**/*.yml')]
        //           // Think this loads the yml files as sources into I18n
        //           // Maybe use I18Next.Net - will probably have to write a YML backend for it

        //           return args


        //           //            opts[:locale] ||= Faker::Config.locale
        //           //        opts[:raise] = true
        //           //I18n.translate(*args, **opts)
        //           //      rescue I18n::MissingTranslationData
        //           //        opts[:locale] = :en

        //           //# Super-simple fallback -- fallback to en if the
        //           //# translation was missing.  If the translation isn't
        //           //# in en either, then it will raise again.
        //           //        disable_enforce_available_locales do
        //           //                I18n.translate(*args, **opts)
        //           //        end
        //       }
        //       protected string translate(string arg/*, ** opts*/)
        //       {
        //           // see I18n.load_path += Dir[File.join(mydir, 'locales', '**/*.yml')]
        //           // Think this loads the yml files as sources into I18n
        //           // Maybe use I18Next.Net - will probably have to write a YML backend for it

        //           return arg


        //           //            opts[:locale] ||= Faker::Config.locale
        //           //        opts[:raise] = true
        //           //I18n.translate(*args, **opts)
        //           //      rescue I18n::MissingTranslationData
        //           //        opts[:locale] = :en

        //           //# Super-simple fallback -- fallback to en if the
        //           //# translation was missing.  If the translation isn't
        //           //# in en either, then it will raise again.
        //           //        disable_enforce_available_locales do
        //           //                I18n.translate(*args, **opts)
        //           //        end
        //       }

        //       /**
        //* @param expression input expression
        //* @return true if s is non null and is a slash delimited regex (ex. {@code /[ab]/})
        //*/
        //       private bool isSlashDelimitedRegex(string expression)
        //       {
        //           return expression != null && expression.StartsWith("/") && expression.EndsWith("/");
        //       }

        ///**
        // * Constructs Faker instance with provided {@link CultureInfo}.
        // *
        // * @param locale - {@link CultureInfo}
        // * @return {@link Faker#Faker(CultureInfo)}
        // */
        //public static Faker instance(CultureInfo locale)
        //{
        //    return new Faker(locale);
        //}

        ///**
        // * Constructs Faker instance with provided {@link Random}.
        // *
        // * @param random - {@link Random}
        // * @return {@link Faker#Faker(Random)}
        // */
        //public static Faker instance(Random random)
        //{
        //    return new Faker(random);
        //}

        ///**
        // * Constructs Faker instance with provided {@link CultureInfo} and {@link Random}.
        // *
        // * @param locale - {@link CultureInfo}
        // * @param random - {@link Random}
        // * @return {@link Faker#Faker(CultureInfo, Random)}
        // */
        //public static Faker instance(CultureInfo locale, Random random)
        //{
        //    return new Faker(locale, random);
        //}

        ///**
        // * Constructs Faker instance with default argument.
        // *
        // * @return {@link Faker#Faker()}
        // */
        //public static Faker instance()
        //{
        //    return new Faker();
        //}






        //internal FakeValuesService fakeValuesService { get; }

    }
}
