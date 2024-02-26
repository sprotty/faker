// Ignore Spelling: Numerify Letterify Regexify yml yaml bothify

using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
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
        private YamlFileLoader _yamlFileCache = new YamlFileLoader();
        private ReadOnlyCollection<IValueResolver> _fakeValuesList;
        private Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>> _methodLookup = new Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>>();
        private Dictionary<Type, Dictionary<string, PropertyInfo>> _propertyLookup = new Dictionary<Type, Dictionary<string, PropertyInfo>>();
        private Faker? _fakerEn = null;

        #region Constructor
        public Faker()
        : this(CultureInfo.CurrentCulture)
        {

        }

        public Faker(CultureInfo locale)
            : this(locale, new Random())
        {

        }

        public Faker(Random random)
            : this(CultureInfo.CurrentCulture, random)
        {

        }
        private Faker(Faker faker)
            : this(CultureInfo.CurrentCulture, faker.Random)
        {
            this._yamlFileCache = faker._yamlFileCache;
            this._fakeValuesList = new ReadOnlyCollection<IValueResolver>(faker._fakeValuesList.TakeLast(1).ToList());
            this._methodLookup = faker._methodLookup;
            this._propertyLookup = faker._propertyLookup;
            this.Locale = UtilityMethods.EnglishCulture;
            this.Logger = faker.Logger;
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
            List<IValueResolver> all = new List<IValueResolver>(locales.Length);

            foreach (CultureInfo l in locales)
            {
                bool isEnglish = l.Equals(UtilityMethods.EnglishCulture);
                if (isEnglish)
                {
                    ValueGroupResolver fakeValuesGrouping = new ValueGroupResolver();
                    foreach (EnFile file in EnFile.AllFiles)
                    {
                        fakeValuesGrouping.add(new YamlValueResolver(_yamlFileCache, l, file.getFile(), file.getPath()));
                    }
                    all.Add(fakeValuesGrouping);
                }
                else
                {
                    all.Add(new YamlValueResolver(_yamlFileCache, l));
                }
            }

            this.Locale = locale;
            this._fakeValuesList = all.AsReadOnly();
        }
        #endregion
        #endregion

        public CultureInfo Locale { get; private set; }
        internal Random Random { get; set; }
        internal ILogger Logger = Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        /// <summary>
        /// Gets a faker instance in the 'en' locale.
        /// </summary>
        public Faker FakerEn
        {
            get
            {
                if (_fakerEn == null)
                {
                    if (this._fakeValuesList.Count == 1)
                        _fakerEn = this;
                    else
                        _fakerEn = new Faker(this);
                }

                return _fakerEn;
            }
        }

        #region Fetch
        /// <summary>
        /// Safely fetches a key.
        /// If the value is null, it will return an empty string.
        /// If it is a list, it will assume it is a list of strings and select a random value from it.
        /// If the retrieved value is an slash encoded regular expression such as <code>/[a-b]/</code> then the regex will be converted to a regexify expression and returned(ex. <code>#regexify '[a-b]'</code>)
        /// otherwise it will just return the value as a string.
        /// </summary>
        /// <param name="key">the key to fetch from the YML structure.</param>
        /// <returns></returns>
        public Dictionary<object, object> FetchYamlMap(string key)
        {
            Object? o = this.FetchYamlObject(key);
            if (o is not Dictionary<object, object> map)
                throw new InvalidOperationException($"Could not fetch the list '{key}' for locale {Locale.Name}.");
            return map;
        }

        /// <summary>
        /// Safely fetches a key.
        /// If the value is null, it will return an empty string.
        /// If it is a list, it will assume it is a list of strings and select a random value from it.
        /// If the retrieved value is an slash encoded regular expression such as <code>/[a-b]/</code> then the regex will be converted to a regexify expression and returned(ex. <code>#regexify '[a-b]'</code>)
        /// otherwise it will just return the value as a string.
        /// </summary>
        /// <param name="key">the key to fetch from the YML structure.</param>
        /// <returns></returns>
        public List<object> FetchYamlList(string key)
        {
            Object? o = this.FetchYamlObject(key);
            if (o is not List<object> list)
                throw new InvalidOperationException($"Could not fetch the list '{key}' for locale {Locale.Name}.");
            return list;
        }

        /// <summary>
        /// Safely fetches a key.
        /// If the value is null, it will return an empty string.
        /// If it is a list, it will assume it is a list of strings and select a random value from it.
        /// If the retrieved value is an slash encoded regular expression such as <code>/[a-b]/</code> then the regex will be converted to a regexify expression and returned(ex. <code>#regexify '[a-b]'</code>)
        /// otherwise it will just return the value as a string.
        /// </summary>
        /// <param name="key">the key to fetch from the YML structure.</param>
        /// <returns></returns>
        public bool TryFetchYamlValue(string key, [NotNullWhen(true)] out string? result, [NotNullWhen(false)] out Exception? e)
        {
            Object? o = this.FetchYamlObject(key);
            if (o == null)
            {
                result = null;
                e = new InvalidOperationException($"The YAML key '{key}' could not be found (locale {Locale.Name}).");
                return false;
            }
            else if (o is List<object> values)
            {
                if (values.Count == 0)
                {
                    result = null;
                    e = new InvalidOperationException($"The YAML key '{key}' contained an empty list (locale {Locale.Name}).");
                    return false;
                }
                else
                {
                    result = (string)values[this.Random.NextInt32(values.Count)];
                    e = null;
                    return true;
                }
            }
            else if (isSlashDelimitedRegex(o.ToString()!))
            {
                result = $"#{{regexify '{trimRegexSlashesAndEscape(o.ToString()!)}'}}";
                e = null;
                return true;
            }
            else
            {
                result = (string)o;
                e = null;
                return true;
            }
        }
        public string? TryFetchYamlValue(string key)
        {
            if (TryFetchYamlValue(key, out var result, out var e) == false)
                return null;
            else
                return result;
        }
        public string FetchYamlValue(string key)
        {
            if (TryFetchYamlValue(key, out var result, out var e) == false)
                throw e;
            else
                return result;
        }

        #region FetchYamlObject
        /// <summary>
        /// Return the object selected by the key from yaml file.
        /// </summary>
        /// <param name="key">key key contains path to an object. Path segment is separated by dot.E.g.name.first_name</param>
        /// <returns></returns>
        private Object? FetchYamlObject(string key)
        {
            string[] path = key.Split('\\', '.');

            Object? result = null;
            foreach (IValueResolver fakeValuesInterface in this._fakeValuesList)
            {
                Object? currentValue = fakeValuesInterface;
                for (int p = 0; currentValue != null && p < path.Length; p++)
                {
                    string currentPath = path[p];
                    if (currentValue is Dictionary<object, object> map)
                    {
                        map.TryGetValue(currentPath, out currentValue);
                    }
                    else if (currentValue is IValueResolver values)
                    {
                        currentValue = values[currentPath];
                    }
                    else
                    {
                        Debug.Fail("Not sure what it is...");
                    }
                }
                result = currentValue;
                if (result != null && (result is not IList lst || lst.Count > 0))
                {
                    break;
                }
            }
            return result;
        }
        #endregion

        /// <summary>
        /// true if s is non null and is a slash delimited regex(ex. <code> / [ab] /</code>)
        /// </summary>
        /// <param name="expression">expression input expression</param>
        /// <returns></returns>
        private bool isSlashDelimitedRegex(string expression)
        {
            return expression != null && expression.StartsWith("/") && expression.EndsWith("/");
        }


        /// <summary>
        /// Given a {@code slashDelimitedRegex} such as {@code /[ab]/}, removes the slashes and returns only {@code [ab]}
        /// Also escapes the expression (' becomes \')
        /// </summary>
        /// <param name="slashDelimitedRegex">a non null slash delimited regex (ex. {@code /[ab]/})</param>
        /// <returns>the regex without the slashes (ex. {@code [ab]})</returns>
        private string trimRegexSlashesAndEscape(string slashDelimitedRegex)
        {
            return slashDelimitedRegex.Substring(1, slashDelimitedRegex.Length - 2).Replace("\'", "\\\'");
        }
        #endregion


        #region BuildInvokableNativeMember
        /// <summary>
        /// Finds the native method that can be called to  an accessor by name ignoring case.
        /// </summary>
        /// <param name="targetObject">The object to call the method on.</param>
        /// <param name="rubyMethodName">
        /// Finds a function called <paramref name="rubyMethodName"/> on the object <paramref name="targetObject"/>.
        /// Uses the <see cref="FakerMethodAttribute.FakerMethodName"/> to match the function name.
        /// </param>
        /// <param name="methodArgs">
        /// The arguments to pass to the method (these are cast to the appropriate type for the method). 
        /// They MUST be literals, expressions are NOT supported.
        /// </param>
        /// <returns>null if the method could not be resolved</returns>
        private IInvokableNativeMember? BuildInvokableNativeMember(Object targetObject, string rubyMethodName, List<string> methodArgs)
        {
            Logger.Information($"Find accessor named {rubyMethodName} on {targetObject.GetType().Name} with {methodArgs.Count} args");

            if (_methodLookup.TryGetValue(targetObject.GetType(), out var methodMap) == false)
            {
                methodMap = new();

                foreach (MethodInfo m in targetObject.GetType().GetMethods())
                {
                    var fakerMethodAttr = m.GetCustomAttribute<FakerMethodAttribute>();
                    if (fakerMethodAttr != null)
                    {
                        int minArgs = m.GetParameters().Length - m.GetParameters().Reverse().Count(a => a.HasDefaultValue);
                        for (int i = minArgs; i <= m.GetParameters().Length; i++)
                            methodMap.Add(new(fakerMethodAttr.FakerMethodName, i), m);
                    }
                }
                _methodLookup[targetObject.GetType()] = methodMap;
            }

            if (_propertyLookup.TryGetValue(targetObject.GetType(), out var propertyMap) == false)
            {
                propertyMap = new();

                foreach (PropertyInfo p in targetObject.GetType().GetProperties())
                {
                    var fakerMethodAttr = p.GetCustomAttribute<FakerMethodAttribute>();
                    if (fakerMethodAttr != null)
                        propertyMap.Add(fakerMethodAttr.FakerMethodName, p);
                }

                _propertyLookup[targetObject.GetType()] = propertyMap;
            }

            if (methodMap.TryGetValue(new(rubyMethodName, methodArgs.Count), out var method))
            {
                List<Object?>? coercedArguments = CoerceArguments(method, methodArgs);
                if (coercedArguments == null)
                    Logger.Warning($"FAILED to Coerce arguments for method {targetObject.GetType().Name}.{rubyMethodName}({string.Join(", ", method.GetParameters().Zip(methodArgs).Select(z => $"{z.First.Name} = {z.Second}"))})");
                else
                    return new InvokableNativeMethod(method, coercedArguments.ToArray());
            }
            else if (propertyMap.TryGetValue(rubyMethodName, out var propertyInfo))
            {
                Debug.Assert(methodArgs.Count == 0);
                return new InvokableNativeProperty(propertyInfo);
            }

            Logger.Information($"FAILED to Method/Property '{rubyMethodName}' on '{targetObject.GetType().Name}' with {methodArgs.Count} args");
            return null;

            //if (name.Contains("_"))
            //{
            //    return accessor(onObject, name.Replace("_", ""), args);
            //}
            //return null;
        }
        #endregion

        #region CoerceArguments
        // <summary>
        /// Coerce arguments in <em>args</em> into the appropriate types (if possible) for the parameter arguments to<em> accessor</em>.
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="args"></param>
        /// <returns>array of coerced values if successful, null otherwise</returns>
        /// <exception cref="Exception">Exception if unable to coerce</exception>
        private List<Object?>? CoerceArguments(MethodInfo accessor, List<string> args)
        {
            List<Object?> coerced = new List<Object?>();
            for (int iTargetParam = 0; iTargetParam < accessor.GetParameters().Length; iTargetParam++)
            {
                var currentParam = accessor.GetParameters()[iTargetParam];
                Type toType = currentParam.ParameterType;
                try
                {
                    if (args.Count <= iTargetParam)
                    {
                        if (accessor.GetParameters()[iTargetParam].HasDefaultValue == false)
                            throw new InvalidOperationException($"The method {accessor.Name} requires {accessor.GetParameters().Length}, but only {args.Count} have been supplied. The missing arguments require values.");
                        else
                            coerced.Add(accessor.GetParameters()[iTargetParam].DefaultValue);
                    }
                    else if (toType.IsEnum)
                    {
                        coerced.Add(Enum.Parse(toType, args[iTargetParam]));
                        //                    Method method = toType.getMethod("valueOf", string.class );
                        //        string enumArg = args.get(i).substring(args.get(i).indexOf(".") + 1);
                        //    Object coercedArg = method.invoke(null, enumArg);
                        //    coerced.add(coercedArg);
                    }
                    else if (toType == typeof(string))
                    {
                        coerced.Add(args[iTargetParam]);
                    }
                    else
                    {
                        var parseMethod = toType.GetMethod("Parse", new Type[] { typeof(string) });//, BindingFlags.Static | BindingFlags.Public);
                        if (parseMethod != null)
                        {
                            coerced.Add(parseMethod.Invoke(null, new[] { args[iTargetParam] }));
                        }
                        else
                        {
                            Logger.Warning("Unable to coerce '{args[i]}' to {toType.Name} via {toType.Name}.Parse(...)");
                        }
                        //            Constructor<?> ctor = toType.getConstructor(string.class);
                        //        Object coercedArgument = ctor.newInstance(args.get(i));
                        //coerced.add(coercedArgument);
                    }
                }
                catch (Exception e)
                {
                    Logger.Warning($"Unable to coerce '{args[iTargetParam]}' to {toType.Name}.", e);
                    return null;
                }
            }
            return coerced;
        }
        #endregion

        #region ResolveFakerObjectAndMethod
        /// <summary>
        /// Accepts a <see cref="Faker"/> instance and a name.firstName style 'key' which is resolved to the return value of:
        ///     <see cref="Faker.Name"/>'s <see cref="NameGenerator.FirstName"/> method.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <exception cref="Exception">if there's a problem invoking the method or it doesn't exist.</exception>
        internal string? ResolveFakerObjectAndMethod(string key, List<string> args)
        {
            string[] classAndMethod = key.Split('.');
            // wrong number of parts to be a [class name].[method]
            if (classAndMethod.Length != 2)
                return null;

            //try
            //{
            string fakerMethodName = classAndMethod[0].Replace("_", "");
            List<string> arguments = new List<string>();
            IInvokableNativeMember? fakerAccessor = BuildInvokableNativeMember(this, fakerMethodName, arguments);
            if (fakerAccessor == null)
            {
                Logger.Warning($"Can't find top level faker object named {fakerMethodName}.");
                return null;
            }
            Object? objectWithMethodToInvoke = fakerAccessor.Invoke(this);
            string nestedMethodName = classAndMethod[1];//.Replace("_", "");
            IInvokableNativeMember? accessor = BuildInvokableNativeMember(objectWithMethodToInvoke, nestedMethodName, args);
            if (accessor == null)
            {
                Logger.Information($"Failed to find method on {objectWithMethodToInvoke.GetType().Name} called '{nestedMethodName}'.");
                return null;
            }

            return accessor.Invoke(objectWithMethodToInvoke)?.ToString();
            //}
            //catch (Exception e)
            //{
            //    _log.Error($"Failed to evaluate expression '{key}'.", e);
            //    return null;
            //}
        }
        #endregion

        #region EvaluateUsingMethod
        /// <summary>
        /// Given a directive like 'firstName', attempts to resolve it to a method..
        /// </summary>
        /// <param name="targetObject"></param>
        /// <param name="rubyMethodName"></param>
        /// <param name="methodArgs">The parameter arguments. Represented as strings regardless of the target type, they may need evaluating or casting.</param>
        /// <returns>
        /// Returns null if the directive is nested (i.e. has a '.') or the method doesn't 
        /// exist on the <paramref name="targetObject"/> object.
        /// </returns>
        /// <example>
        /// For example if <paramref name="targetObject"/> is an instance of <see cref="NameGenerator"/> then 
        /// this method would return <see cref="NameGenerator.FirstName"/>
        /// </example>
        internal string? EvaluateUsingMethod(Object? targetObject, string rubyMethodName, List<string> methodArgs)
        {
            if (targetObject == null)
            {
                return null;
            }
            try
            {
                IInvokableNativeMember? method = BuildInvokableNativeMember(targetObject, rubyMethodName, methodArgs);
                return (method == null)
                        ? null
                        : (string?)method.Invoke(targetObject);
            }
            catch (Exception e)
            {
                Logger.Error($"Can't call {rubyMethodName} on {targetObject}", e);
                return null;
            }
        }
        #endregion


        #region interface IInvokableNativeMember
        private interface IInvokableNativeMember { object? Invoke(Object on); }

        /**
         * simple wrapper class around an accessor and a list of coerced arguments.
         * this is useful as we get to find the method and coerce the arguments in one
         * shot, returning both when successful.  This saves us from doing it more than once (coercing args).
         */
        private class InvokableNativeMethod : IInvokableNativeMember
        {
            private MethodInfo _method;
            private Object?[] _coercedArgs;

            public InvokableNativeMethod(MethodInfo m, Object?[] coercedArgs)
            {
                this._method = m ?? throw new ArgumentNullException("method cannot be null");
                this._coercedArgs = coercedArgs ?? throw new ArgumentNullException("coerced arguments cannot be null");
            }

            public object? Invoke(Object on)
            {
                return _method.Invoke(on, _coercedArgs);
            }
        }
        private class InvokableNativeProperty : IInvokableNativeMember
        {
            private PropertyInfo _property;

            public InvokableNativeProperty(PropertyInfo p)
            {
                this._property = p ?? throw new ArgumentNullException("method cannot be null");
            }

            public object? Invoke(Object on)
            {
                return _property.GetValue(on);
            }
        }
        #endregion


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
    }
}
