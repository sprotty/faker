using System;
using System.Collections;
using System.Collections.Generic;
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
    /// The base class for all generators
    /// Provides some basic Faker methods, and some internal methods 
    /// for resolving expressions and fetching values
    /// </summary>
    public class GeneratorBase
    {
        private static readonly Regex EXPRESSION_PATTERN = new Regex("#\\{([a-z0-9A-Z_.]+)\\s?((?:,?'([^']+)')*)\\}", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_ARGUMENTS_PATTERN = new Regex("(?:'(.*?)')", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_JAVA_TO_YML_NAME_PATTERN = new Regex("([A-Z])", RegexOptions.Compiled);


        protected GeneratorBase(Faker faker)
        {
            Faker = faker;
        }

        protected Random Random => Faker.Random;
        protected CultureInfo Locale => Faker.Locale;

        #region Faker Common Methods
        /// <summary>
        /// Returns a string with the '#' characters in the parameter replaced with random digits between 0-9 inclusive.
        /// </summary>
        /// <param name="numberString"></param>
        /// <example>
        /// The string "ABC##EFG" could be replaced with a string like "ABC99EFG".</example>
        /// <returns></returns>
        [FakerMethod("numerify")]
        public string Numerify(string numberString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] == '#')
                {
                    sb.Append(Faker.Random.NextInt32(10));
                }
                else
                {
                    sb.Append(numberString[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns a string with the '?' characters in the parameter replaced with random alphabetic characters.
        /// </summary>
        /// <param name="letterString"></param>
        /// <example>
        /// The string "12??34" could be replaced with a string like "12AB34".
        /// <returns></returns>
        [FakerMethod("letterify")]
        public string Letterify(string letterString)
        {
            return Letterify(letterString, false);
        }

        /// <summary>
        /// Returns a string with the '?' characters in the parameter replaced with random alphabetic characters.
        /// </summary>
        /// <param name="letterString"></param>
        /// <param name="isUpper"
        /// <example>
        /// The string "12??34" could be replaced with a string like "12AB34".
        /// <returns></returns>
        [FakerMethod("letterify")]
        public string Letterify(string letterString, bool isUpper)
        {
            int baseChar = isUpper ? 65 : 97;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < letterString.Length; i++)
            {
                if (letterString[i] == '?')
                {
                    sb.Append((char)(baseChar + Faker.Random.NextInt32(26))); // a-z
                }
                else
                {
                    sb.Append(letterString[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Applies both a <see cref="Numerify(string)"/> and <see cref="Letterify(string)"/> to the string <paramref name="text"/>.
        /// </summary>
        /// <param name="text">The target string</param>
        [FakerMethod("bothify")]
        public string Bothify(string text)
        {
            return Letterify(Numerify(text));
        }

        /// <summary>
        /// Applies both a <see cref="Numerify(string)"/> and <see cref="Letterify(string)"/> to the string <paramref name="text"/>.
        /// </summary>
        /// <param name="text">The target string</param>
        [FakerMethod("bothify")]
        public string Bothify(string text, bool isUpper)
        {
            return Letterify(Numerify(text), isUpper);
        }


        /// <summary>
        /// Generates a string that matches the given regular expression.
        /// </summary>
        /// <param name="regex"></param>
        /// <returns></returns>
        [FakerMethod("regexify")]
        public string Regexify(string regex)
        {
            var regexBuilder = new Fare.Xeger(regex, Faker.Random);
            string expr = regexBuilder.Generate();
            return expr;
        }

        /// <summary>
        /// Translates the text using I8n
        /// </summary>
        [FakerMethod("translate")]
        public string Translate(string str)
        {
            return str; // TODO
        }

        /// <summary>
        /// Creates a random Integer number within the specified range
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [FakerMethod("random_integer")]
        public string RandomIntegerAsString(IntegerRange rng)
        {
            return RandomExtensions.NextInt64(Faker.Random, rng.Min, rng.Max).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Creates a random floating point number within the specified range
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [FakerMethod("random_float")]
        public string RandomFloatAsString(FloatRange rng)
        {
            return Faker.Random.NextDouble(rng.Min, rng.Max).ToString("R");
        }
        /// <summary>
        /// Gets a sequence of hex chars
        /// </summary>
        /// <param name="length">the number of chars (typically an even number)</param>
        /// <param name="lower">true for lower case, false for upper case</param>
        /// <returns>RandomHex(4, false) = F8A0</returns>
        [FakerMethod("random_hex")]
        public string RandomHex(long length, bool lower = true)
        {
            var seq = Faker.Random.NextHex((int)length);
            seq = lower ? seq.ToLower() : seq.ToUpper();
            return seq;
        }
        #endregion

        internal Faker Faker { get; }

        /// <summary>
        /// Gets a faker object in the 'en' locale.
        /// </summary>
        internal Faker FakerEn => Faker.FakerEn;

        #region EvaluateExpression
        public string EvaluateExpression(string expression) => EvaluateExpression(expression, this);

        /// <summary>
        /// processes a expression in the style #{X.y} using the current objects as the 'current' location
        /// within the yml file(or the { @link Faker}
        /// object hierarchy as it were).
        ///      #{Address.streetName} would get resolved to {@link Faker#address()}'s {@link Address#streetName()}
        ///      #{address.street} would get resolved to the YAML > locale: faker: address: street:
        ///      Combinations are supported as well: "#{x} #{y}"
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <example>
        /// The following are valid expressions:
        ///     #{regexify '(a|b){2,3}'}
        ///     #{regexify '\\.\\*\\?\\+'}
        ///     #{bothify '????','false'}
        ///     #{Name.first_name} #{Name.first_name} #{Name.last_name}
        ///     #{number.number_between '1','10'}
        /// </example>
        /// <remarks>
        /// Recursive templates are supported.  if "#{x}" resolves to "#{Address.streetName}" then "#{x}" resolves to
        /// {@link Faker#address()}'s {@link Address#streetName()}.
        public string EvaluateExpression(string expression, object current)
        {
            MatchCollection matches;
            string result = expression;

            do
            {
                matches = EXPRESSION_PATTERN.Matches(result);

                foreach (Match match in matches)
                {
                    string escapedDirective = match.Groups[0].Value;
                    string directive = match.Groups[1].Value;
                    string arguments = match.Groups[2].Value;
                    var argsMatcher = EXPRESSION_ARGUMENTS_PATTERN.Matches(arguments);
                    List<string> args = new List<string>();
                    foreach (Match argMatch in argsMatcher)
                    {
                        string argExpr = argMatch.Groups[1].Value;
                        string argValue = EvaluateExpression(argExpr, current);
                        args.Add(argValue);
                    }

                    // resolve the expression and reprocess it to handle recursive templates
                    string? resolved = EvaluateExpression(directive, args, current/*, root*/);
                    if (resolved == null)
                    {
                        throw new InvalidOperationException("Unable to resolve " + escapedDirective + " directive.");
                    }

                    resolved = EvaluateExpression(resolved, current/*, root*/);
                    result = result.ReplaceFirst(escapedDirective, resolved);
                }
            } while (matches.Count > 0);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="methodArgs"></param>
        /// <param name="current"></param>
        /// <param name="root"></param>
        /// <returns>null if unable to resolve</returns>
        /// <remarks>
        /// Search Order
        /// <ul>
        /// <li>Search for methods on the current object</li>
        /// <li>local keys in Yaml File</li>
        /// <li>Search for methods on faker child objects</li>
        /// <li>Search for keys in yaml file by transforming object reference to yaml reference</li>
        /// </ul>
        /// </remarks>
        private string? EvaluateExpression(string expression, List<string> methodArgs, object current)
        {
            //            throw new TodoException();
            // name.name (resolve locally)
            // Name.first_name (resolve to faker.name().firstName())
            string simpleDirective = IsDotDirective(expression) || current == null
                                        ? expression
                                        : ClassNameToYamlName(current) + "." + expression;

            string? resolved = null;
            // resolve method references on CURRENT object like #{number_between '1','10'} on Number or
            // #{ssn_valid} on IdNumber
            if (!IsDotDirective(expression))
            {
                resolved = Faker.EvaluateUsingMethod(current, expression, methodArgs);
            }

            // simple fetch of a value from the yaml file. the directive may have been mutated
            // such that if the current yaml object is car: and directive is #{wheel} then
            // car.wheel will be looked up in the YAML file.
            if (resolved == null)
            {
                resolved = Faker.TryFetchYamlValue(simpleDirective);
            }

            // resolve method references on faker object like #{regexify '[a-z]'}
            if (resolved == null && !IsDotDirective(expression))
            {
                resolved = Faker.EvaluateUsingMethod(this, expression, methodArgs);
            }

            // Resolve Faker Object method references like #{ClassName.method_name}
            if (resolved == null && IsDotDirective(expression))
            {
                resolved = Faker.ResolveFakerObjectAndMethod(expression, methodArgs);
            }

            // last ditch effort.  Due to Ruby's dynamic nature, something like 'Address.street_title' will resolve
            // because 'street_title' is a dynamic method on the Address object.  We can't do this in Java so we go
            // through the normal resolution above, but if we will can't resolve it, we once again do a 'safeFetch' as we
            // did first but FIRST we change the Object reference Class.method_name with a yml style internal refernce ->
            // class.method_name (lowercase)
            if (resolved == null && IsDotDirective(expression))
            {
                resolved = Faker.TryFetchYamlValue(NativeNameToYamlName(simpleDirective));
            }

            return resolved;
        }
        #endregion

        #region Resolve
        public string ResolveYamlValue(string keyExpression) => ResolveYamlValue(keyExpression, this);

        /// <summary>
        /// Resolves a key to an entry in the YAML files
        /// Any expressions within the key are resolved first, then the key is looked up.
        /// </summary>
        /// <param name="keyExpression">An expression that represents a key within the YAML files</param>
        /// <param name="current"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        /// <example>
        ///     address.full_address
        ///     address.country_by_name.#{String.lower 'US'}
        /// </example>
        /// <exception cref="InvalidOperationException"></exception>
        public string ResolveYamlValue(string keyExpression, object current)
        {
            string resolvedKey = EvaluateExpression(keyExpression, current);

            string expression = Faker.FetchYamlValue(resolvedKey);

            return EvaluateExpression(expression, current/*, root*/);
        }
        #endregion

        //#region Fetch
        //public Dictionary<object, object> FetchYamlMap(string key)=>_faker.FetchYamlMap(key);
        //public List<object> FetchYamlList(string key)=>_faker.FetchYamlList(key);
        //public bool TryFetchYamlValue(string key, [NotNullWhen(true)] out string? result, [NotNullWhen(false)] out Exception? e) => _faker.TryFetchYamlValue(key, out result, out e);
        //public string? TryFetchYamlValue(string key)=>_faker.TryFetchYamlValue(key);
        //public string FetchYamlValue(string key) => _faker.FetchYamlValue(key);
        //#endregion

        #region Helpers
        /// <summary>
        /// Creates a random array of bytes 
        /// A helper function not exposed to the evaluation engine (used direclty by native functions)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        protected byte[] CreateRandomBytes(int minLen, int maxLen)
        {
            int len = Faker.Random.NextInt32(minLen, maxLen);
            byte[] bytes = new byte[len];
            Faker.Random.NextBytes(bytes);
            return bytes;
        }




        private bool IsDotDirective(string directive)
        {
            return directive.Contains(".");
        }

        /// <summary>
        /// Gets a yaml style name from the classname of the supplied object (PhoneNumber => phone_number)
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private string ClassNameToYamlName(object current)
        {
            var genAttr = current.GetType().GetCustomAttribute<FakerGeneratorAttribute>();
            if (genAttr == null)
                throw new InvalidOperationException($"The class {current.GetType().Name} should have a {nameof(FakerGeneratorAttribute)} attribute");

            return genAttr.YamlName;
        }

        /// <summary>
        /// a yaml style name like 'phone_number' from a java style name like 'PhoneNumber'
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private string NativeNameToYamlName(string expression)
        {
            string result = EXPRESSION_JAVA_TO_YML_NAME_PATTERN.Replace(expression, "_$1");
            return result.Substring(1).ToLower();
        }
        #endregion
    }
}
