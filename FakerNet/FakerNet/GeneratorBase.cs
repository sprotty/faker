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
    public class GeneratorBase
    {
        private static readonly Regex EXPRESSION_PATTERN = new Regex("#\\{([a-z0-9A-Z_.]+)\\s?((?:,?'([^']+)')*)\\}", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_ARGUMENTS_PATTERN = new Regex("(?:'(.*?)')", RegexOptions.Compiled);
        private static readonly Regex EXPRESSION_JAVA_TO_YML_NAME_PATTERN = new Regex("([A-Z])", RegexOptions.Compiled);
        protected readonly Faker _faker;
        private Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>> _methodLookup = new Dictionary<Type, Dictionary<Tuple<string, int>, MethodInfo>>();
        private Dictionary<Type, Dictionary<string, PropertyInfo>> _propertyLookup = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

        protected GeneratorBase(Faker faker)
        {
            _faker = faker;
        }

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
                    sb.Append(_faker.randomService.nextInt(10));
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
                    sb.Append((char)(baseChar + _faker.randomService.nextInt(26))); // a-z
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
        public string bothify(string text)
        {
            return Letterify(Numerify(text));
        }

        /// <summary>
        /// Applies both a <see cref="Numerify(string)"/> and <see cref="Letterify(string)"/> to the string <paramref name="text"/>.
        /// </summary>
        /// <param name="text">The target string</param>
        [FakerMethod("bothify")]
        public string bothify(string text, bool isUpper)
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
            var regexBuilder = new Fare.Xeger(regex, _faker.randomService.Random);
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
                string resolved = resolveExpression(directive, args, current/*, root*/);
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
                resolved = EvaluateUsingMethod(current, directive, methodArgs);
            }

            // simple fetch of a value from the yaml file. the directive may have been mutated
            // such that if the current yaml object is car: and directive is #{wheel} then
            // car.wheel will be looked up in the YAML file.
            if (resolved == null)
            {
                resolved = safeFetch(simpleDirective, null);
            }

            // resolve method references on faker object like #{regexify '[a-z]'}
            if (resolved == null && !IsDotDirective(directive))
            {
                resolved = EvaluateUsingMethod(this, directive, methodArgs);
            }

            // Resolve Faker Object method references like #{ClassName.method_name}
            if (resolved == null && IsDotDirective(directive))
            {
                resolved = resolveFakerObjectAndMethod(this._faker, directive, methodArgs);
            }

            // last ditch effort.  Due to Ruby's dynamic nature, something like 'Address.street_title' will resolve
            // because 'street_title' is a dynamic method on the Address object.  We can't do this in Java so we go
            // through the normal resolution above, but if we will can't resolve it, we once again do a 'safeFetch' as we
            // did first but FIRST we change the Object reference Class.method_name with a yml style internal refernce ->
            // class.method_name (lowercase)
            if (resolved == null && IsDotDirective(directive))
            {
                resolved = safeFetch(javaNameToYamlName(simpleDirective), null);
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

            string? expression = safeFetch(resolvedKey, null);
            if (expression == null)
            {
                throw new InvalidOperationException(keyExpression + " resulted in null expression");
            }

            return Expression(expression, current/*, root*/);
        }



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
        private string? EvaluateUsingMethod(Object? targetObject, string rubyMethodName, List<string> methodArgs)
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
                _faker._log.Error($"Can't call {rubyMethodName} on {targetObject}", e);
                return null;
            }
        }

        /**
  * Accepts a {@link Faker} instance and a name.firstName style 'key' which is resolved to the return value of:
  * {@link Faker#name()}'s {@link Name#firstName()} method.
  *
  * @throws RuntimeException if there's a problem invoking the method or it doesn't exist.
  */
        private string? resolveFakerObjectAndMethod(Faker faker, string key, List<string> args)
        {
            string[] classAndMethod = key.Split('.');
            Debug.Assert(classAndMethod.Length == 2, "Expecting 2 parts, object.method");

            //try
            //{
            string fakerMethodName = classAndMethod[0].Replace("_", "");
            List<string> arguments = new List<string>();
            IInvokableNativeMember? fakerAccessor = BuildInvokableNativeMember(faker, fakerMethodName, arguments);
            if (fakerAccessor == null)
            {
                _faker._log.Warning($"Can't find top level faker object named {fakerMethodName}.");
                return null;
            }
            Object? objectWithMethodToInvoke = fakerAccessor.Invoke(faker);
            string nestedMethodName = classAndMethod[1];//.Replace("_", "");
            IInvokableNativeMember? accessor = BuildInvokableNativeMember(objectWithMethodToInvoke, nestedMethodName, args);
            if (accessor == null)
            {
                _faker._log.Information($"Failed to find method on {objectWithMethodToInvoke.GetType().Name} called '{nestedMethodName}'.");
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
            _faker._log.Information($"Find accessor named {rubyMethodName} on {targetObject.GetType().Name} with {methodArgs.Count} args");

            if (_methodLookup.TryGetValue(targetObject.GetType(), out var methodMap) == false)
            {
                methodMap = new();

                foreach (MethodInfo m in targetObject.GetType().GetMethods())
                {
                    var fakerMethodAttr = m.GetCustomAttribute<FakerMethodAttribute>();
                    if (fakerMethodAttr != null)
                        methodMap.Add(new(fakerMethodAttr.FakerMethodName, m.GetParameters().Length), m);
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
                List<Object> coercedArguments = CoerceArguments(method, methodArgs);
                if (coercedArguments == null)
                    _faker._log.Warning($"FAILED to Coerce arguments for method {targetObject.GetType().Name}.{rubyMethodName}({string.Join(", ", method.GetParameters().Zip(methodArgs).Select(z => $"{z.First.Name} = {z.Second}"))})");
                else
                    return new InvokableNativeMethod(method, coercedArguments.ToArray());
            }
            else if (propertyMap.TryGetValue(rubyMethodName, out var propertyInfo))
            {
                Debug.Assert(methodArgs.Count == 0);
                return new InvokableNativeProperty(propertyInfo);
            }

            _faker._log.Information($"FAILED to Method/Property '{rubyMethodName}' on '{targetObject.GetType().Name}' with {methodArgs.Count} args");
            return null;

            //if (name.Contains("_"))
            //{
            //    return accessor(onObject, name.Replace("_", ""), args);
            //}
            //return null;
        }
        #endregion


        /**
         * Coerce arguments in <em>args</em> into the appropriate types (if possible) for the parameter arguments
         * to <em>accessor</em>.
         *
         * @return array of coerced values if successful, null otherwise
         * @throws Exception if unable to coerce
         */
        private List<Object>? CoerceArguments(MethodInfo accessor, List<string> args)
        {
            List<Object> coerced = new List<Object>();
            for (int i = 0; i < accessor.GetParameters().Length; i++)
            {
                var currentParam = accessor.GetParameters()[i];
                Type toType = currentParam.ParameterType;
                try
                {
                    if (toType.IsEnum)
                    {
                        coerced.Add(Enum.Parse(toType, args[i]));
                        //                    Method method = toType.getMethod("valueOf", string.class );
                        //        string enumArg = args.get(i).substring(args.get(i).indexOf(".") + 1);
                        //    Object coercedArg = method.invoke(null, enumArg);
                        //    coerced.add(coercedArg);
                    }
                    else if (toType == typeof(string))
                    {
                        coerced.Add(args[i]);
                    }
                    else
                    {
                        var parseMethod = toType.GetMethod("Parse", BindingFlags.Static | BindingFlags.Public);
                        if (parseMethod != null)
                        {
                            coerced.Add(parseMethod.Invoke(null, new[] { args[i] }));
                        }
                        else
                        {
                            _faker._log.Warning("Unable to coerce '{args[i]}' to {toType.Name} via {toType.Name}.Parse(...)");
                        }
                        //            Constructor<?> ctor = toType.getConstructor(string.class);
                        //        Object coercedArgument = ctor.newInstance(args.get(i));
                        //coerced.add(coercedArgument);
                    }
                }
                catch (Exception e)
                {
                    _faker._log.Warning($"Unable to coerce '{args[i]}' to {toType.Name}.", e);
                    return null;
                }
            }
            return coerced;
        }

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

        #region Helpers

        /**
       * @param expression input expression
       * @return true if s is non null and is a slash delimited regex (ex. {@code /[ab]/})
       */
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

        private interface IInvokableNativeMember { object? Invoke(Object on); }

        /**
         * simple wrapper class around an accessor and a list of coerced arguments.
         * this is useful as we get to find the method and coerce the arguments in one
         * shot, returning both when successful.  This saves us from doing it more than once (coercing args).
         */
        private class InvokableNativeMethod : IInvokableNativeMember
        {
            private MethodInfo _method;
            private Object[] _coercedArgs;

            public InvokableNativeMethod(MethodInfo m, Object[] coercedArgs)
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


        #region Fetch
        //  /**
        //* Fetch a random value from an array item specified by the key
        //*
        //* @param key
        //* @return
        //*/
        //  public Object fetch(string key)
        //  {
        //      throw new TodoException();
        //      //List<Object> valuesArray = (List)fetchObject(key);
        //      //return valuesArray == null ? null : valuesArray.get(randomService.nextInt(valuesArray.size()));
        //  }

        //  /**
        //   * Same as {@link #fetch(string)} except this casts the result into a string.
        //   *
        //   * @param key
        //   * @return
        //   */
        //  public string? fetchString(string key)
        //  {
        //      return (string?)fetch(key);
        //  }

        /**
         * Safely fetches a key.
         * <p>
         * If the value is null, it will return an empty string.
         * <p>
         * If it is a list, it will assume it is a list of strings and select a random value from it.
         * <p>
         * If the retrieved value is an slash encoded regular expression such as {@code /[a-b]/} then
         * the regex will be converted to a regexify expression and returned (ex. {@code #regexify '[a-b]'})
         * <p>
         * Otherwise it will just return the value as a string.
         *
         * @param key           the key to fetch from the YML structure.
         * @param defaultIfNull the value to return if the fetched value is null
         * @return see above
         */
        public string? safeFetch(string key, string? defaultIfNull)
        {
            Object? o = fetchObject(key);
            if (o == null)
                return defaultIfNull;
            //throw new TodoException();
            if (o is List<object> values)
            {
                if (values.Count == 0)
                {
                    return defaultIfNull;
                }
                return (string)values[_faker.randomService.nextInt(values.Count)];
            }
            else if (isSlashDelimitedRegex(o.ToString()))
            {
                return $"#{{regexify '{trimRegexSlashesAndEscape(o.ToString())}'}}";
            }
            else
            {
                return (string)o;
            }
        }

        /**
         * Return the object selected by the key from yaml file.
         *
         * @param key key contains path to an object. Path segment is separated by
         *            dot. E.g. name.first_name
         * @return
         */
        public Object? fetchObject(string key)
        {
            string[] path = key.Split('\\', '.');

            Object? result = null;
            foreach (FakeValuesInterface fakeValuesInterface in _faker._fakeValuesList)
            {
                Object? currentValue = fakeValuesInterface;
                for (int p = 0; currentValue != null && p < path.Length; p++)
                {
                    string currentPath = path[p];
                    if (currentValue is Dictionary<object, object> map)
                    {
                        map.TryGetValue(currentPath, out currentValue);
                    }
                    else if (currentValue is FakeValuesInterface values)
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
    }
}
