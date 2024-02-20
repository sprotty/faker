using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        protected readonly Faker _faker;

        protected GeneratorBase(Faker faker)
        {
            _faker = faker;
        }

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
                    sb.Append(_faker.Random.NextInt32(10));
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
            int baseChar = (isUpper) ? 65 : 97;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < letterString.Length; i++)
            {
                if (letterString[i] == '?')
                {
                    sb.Append((char)(baseChar + _faker.Random.NextInt32(26))); // a-z
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
            var regexBuilder = new Fare.Xeger(regex, _faker.Random);
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
            return RandomExtensions.NextInt64(_faker.Random, rng.Min, rng.Max).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Creates a random floating point number within the specified range
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [FakerMethod("random_float")]
        public string RandomFloatAsString(FloatRange rng)
        {
            return _faker.Random.NextDouble(rng.Min, rng.Max).ToString("R");
        }
        #endregion


        #region Expression
        //    /**
        //* 
        //* <p>
        //* The following are valid expressions:
        //* <ul>
        //* </ul>
        //*
        //* @param expression (see examples above)
        //* @return the evaluated string expression
        //* @throws RuntimeException if unable to evaluate the expression
        //*/]
        /// <summary>
        /// Allows the evaluation of native methods within the YAML expressions.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <example>
        ///     #{regexify '(a|b){2,3}'}
        ///     #{regexify '\\.\\*\\?\\+'}
        ///     #{bothify '????','false'}
        ///     #{Name.first_name} #{Name.first_name} #{Name.last_name}
        ///     #{number.number_between '1','10'}
        /// </example>
        //public string Expression(string expression, Object current)
        //{
        //    return this.resolveExpression(expression, null, this);
        //}

        /**
         * <p>processes a expression in the style #{X.y} using the current objects as the 'current' location
         * within the yml file (or the {@link Faker} object hierarchy as it were).
         * </p>
         * <p>
         * #{Address.streetName} would get resolved to {@link Faker#address()}'s {@link Address#streetName()}
         * </p>
         * <p>
         * #{address.street} would get resolved to the YAML > locale: faker: address: street:
         * </p>
         * <p>
         * Combinations are supported as well: "#{x} #{y}"
         * </p>
         * <p>
         * Recursive templates are supported.  if "#{x}" resolves to "#{Address.streetName}" then "#{x}" resolves to
         * {@link Faker#address()}'s {@link Address#streetName()}.
         * </p>
         */
        public string Expression(string expression, Object current/*, Faker root*/)
        {
            var matches = EXPRESSION_PATTERN.Matches(expression);

            string result = expression;
            foreach (Match match in matches)
            {
                //throw new TodoException();
                string escapedDirective = match.Groups[0].Value;
                string directive = match.Groups[1].Value;
                string arguments = match.Groups[2].Value;
                var argsMatcher = EXPRESSION_ARGUMENTS_PATTERN.Matches(arguments);
                List<string> args = new List<string>();
                foreach (Match argMatch in argsMatcher)
                {
                    args.Add(argMatch.Groups[1].Value);
                }

                // resolve the expression and reprocess it to handle recursive templates
                string? resolved = resolveExpression(directive, args, current/*, root*/);
                if (resolved == null)
                {
                    throw new InvalidOperationException("Unable to resolve " + escapedDirective + " directive.");
                }

                resolved = Expression(resolved, current/*, root*/);
                result = result.ReplaceFirst(escapedDirective, resolved);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directive"></param>
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
        private string? resolveExpression(string directive, List<string> methodArgs, Object current/*, Faker root*/)
        {
            //            throw new TodoException();
            // name.name (resolve locally)
            // Name.first_name (resolve to faker.name().firstName())
            string simpleDirective = (IsDotDirective(directive) || current == null)
                                        ? directive
                                        : classNameToYamlName(current) + "." + directive;

            string? resolved = null;
            // resolve method references on CURRENT object like #{number_between '1','10'} on Number or
            // #{ssn_valid} on IdNumber
            if (!IsDotDirective(directive))
            {
                resolved = _faker.EvaluateUsingMethod(current, directive, methodArgs);
            }

            // simple fetch of a value from the yaml file. the directive may have been mutated
            // such that if the current yaml object is car: and directive is #{wheel} then
            // car.wheel will be looked up in the YAML file.
            if (resolved == null)
            {
                resolved = _faker.SafeFetch(simpleDirective, null);
            }

            // resolve method references on faker object like #{regexify '[a-z]'}
            if (resolved == null && !IsDotDirective(directive))
            {
                resolved = _faker.EvaluateUsingMethod(this, directive, methodArgs);
            }

            // Resolve Faker Object method references like #{ClassName.method_name}
            if (resolved == null && IsDotDirective(directive))
            {
                resolved = _faker.ResolveFakerObjectAndMethod(directive, methodArgs);
            }

            // last ditch effort.  Due to Ruby's dynamic nature, something like 'Address.street_title' will resolve
            // because 'street_title' is a dynamic method on the Address object.  We can't do this in Java so we go
            // through the normal resolution above, but if we will can't resolve it, we once again do a 'safeFetch' as we
            // did first but FIRST we change the Object reference Class.method_name with a yml style internal refernce ->
            // class.method_name (lowercase)
            if (resolved == null && IsDotDirective(directive))
            {
                resolved = _faker.SafeFetch(javaNameToYamlName(simpleDirective), null);
            }

            return resolved;
        }
        #endregion



        #region Resolve
        public string Resolve(string key, Object current)
        {
            return this.resolve(key, current/*, this*/);
        }

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
        ///     address.country_by_name.#{lower 'US'}
        /// </example>
        /// <exception cref="InvalidOperationException"></exception>
        public string resolve(string keyExpression, Object current/*, Faker root*/)
        {
            string resolvedKey = Expression(keyExpression, current/*, root*/);

            string? expression = _faker.SafeFetch(resolvedKey, null);
            if (expression == null)
            {
                throw new InvalidOperationException(keyExpression + " resulted in null expression");
            }

            return Expression(expression, current/*, root*/);
        }
        #endregion

        #region Helpers



        private bool IsDotDirective(string directive)
        {
            return directive.Contains(".");
        }

        /**
         * @return a yaml style name from the classname of the supplied object (PhoneNumber => phone_number)
         */
        private string classNameToYamlName(Object current)
        {
            var genAttr = current.GetType().GetCustomAttribute<FakerGeneratorAttribute>();
            if (genAttr == null)
                throw new InvalidOperationException($"The class {current.GetType().Name} should have a {nameof(FakerGeneratorAttribute)} attribute");

            return genAttr.FakerGeneratorName;
        }

        /**
         * @return a yaml style name like 'phone_number' from a java style name like 'PhoneNumber'
         */
        private string javaNameToYamlName(string expression)
        {
            string result = EXPRESSION_JAVA_TO_YML_NAME_PATTERN.Replace(expression, "_$1");
            return result.Substring(1).ToLower();
        }
        #endregion








        //private string stringZ(Object obj) { return (obj == null) ? null : obj.ToString(); }


        //       /**
        //* @return a proper {@link CultureInfo} instance with language and country code set regardless of how
        //* it was instantiated.  new CultureInfo("pt-br") will be normalized to a locale constructed
        //* with new CultureInfo("pt","BR").
        //*/
        //       private CultureInfo normalizeLocale(CultureInfo locale)
        //       {
        //           return locale;
        //           //string[] parts = locale.Name.Split('-', '_');
        //           //if (parts.Length == 1)
        //           //{
        //           //    return new CultureInfo(parts[0]);
        //           //}
        //           //else
        //           //{
        //           //    return new CultureInfo(parts[0], parts[1]);
        //           //}
        //       }

    }
}
