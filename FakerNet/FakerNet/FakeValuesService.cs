//using Serilog;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.Globalization;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace FakerNet
//{

//    public class FakeValuesService
//    {


//        /**
//         * <p>
//         * Resolves YAML file using the most specific path first based on language and country code.
//         * 'en_US' would resolve in the following order:
//         * <ol>
//         * <li>/en-US.yml</li>
//         * <li>/en.yml</li>
//         * </ol>
//         * The search is case-insensitive, so the following will all resolve correctly.  Also, either a hyphen or
//         * an underscore can be used when constructing a {@link Locale} instance.  This is legacy behavior and not
//         * condoned, but it will work.
//         * <ul>
//         * <li>EN_US</li>
//         * <li>En-Us</li>
//         * <li>eN_uS</li>
//         * </ul>
//         * </p>
//         *
//         * @param locale
//         * @param randomService
//         */
//        public FakeValuesService(CultureInfo locale, RandomService randomService)
//        {
//            //if (locale == null)
//            //{
//            //    throw new ArgumentException("locale is required");
//            //}
//            //this.randomService = randomService;
//            //locale = normalizeLocale(locale);

//            //CultureInfo[] locales = localeChain(locale);
//            //List<FakeValuesInterface> all = new List<FakeValuesInterface>(locales.Length);

//            //foreach (CultureInfo l in locales)
//            //{
//            //    bool isEnglish = l.Equals(UtilityMethods.EnglishCulture);
//            //    if (isEnglish)
//            //    {
//            //        FakeValuesGrouping fakeValuesGrouping = new FakeValuesGrouping();
//            //        foreach (EnFile file in EnFile.AllFiles)
//            //        {
//            //            fakeValuesGrouping.add(new FakeValues(l, file.getFile(), file.getPath()));
//            //        }
//            //        all.Add(fakeValuesGrouping);
//            //    }
//            //    else
//            //    {
//            //        all.Add(new FakeValues(l));
//            //    }
//            //}

//            //this.fakeValuesList = all.AsReadOnly();
//        }

////        /**
////         * Convert the specified locale into a chain of locales used for message resolution. For example:
////         * <p>
////         * {@link CultureInfo#FRANCE} (fr_FR) -> [ fr_FR, anotherTest, en ]
////         *
////         * @return a list of {@link CultureInfo} instances
////         */
////        protected CultureInfo[] localeChain(CultureInfo from)
////        {
////            if (UtilityMethods.EnglishCulture.Equals(from))
////            {
////                return new[] { UtilityMethods.EnglishCulture };
////            }
//////            throw new TodoException("Test");
////            CultureInfo normalized = normalizeLocale(from);

////            List<CultureInfo> chain = new List<CultureInfo>(3);
////            chain.Add(normalized);
////            if (normalized.GetCountry() != "" &&
////                UtilityMethods.EnglishCulture.GetLanguage() != normalized.GetLanguage())
////            {
////                chain.Add(new CultureInfo(normalized.GetLanguage()));
////            }
////            chain.Add(UtilityMethods.EnglishCulture); // default
////            return chain.ToArray();
////        }



     

//        ///**
//        // * Returns a string with the '#' characters in the parameter replaced with random digits between 0-9 inclusive.
//        // * <p/>
//        // * For example, the string "ABC##EFG" could be replaced with a string like "ABC99EFG".
//        // *
//        // * @param numberString
//        // * @return
//        // */
//        //public string numerify(string numberString)
//        //{
//        //    StringBuilder sb = new StringBuilder();
//        //    for (int i = 0; i < numberString.Length; i++)
//        //    {
//        //        if (numberString[i] == '#')
//        //        {
//        //            sb.Append(randomService.nextInt(10));
//        //        }
//        //        else
//        //        {
//        //            sb.Append(numberString[i]);
//        //        }
//        //    }

//        //    return sb.ToString();
//        //}

//        ///**
//        // * Applies both a {@link #numerify(string)} and a {@link #letterify(string)}
//        // * over the incoming string.
//        // *
//        // * @param string
//        // * @return
//        // */
//        //public string bothify(string text)
//        //{
//        //    return letterify(numerify(text));
//        //}

//        ///**
//        // * Applies both a {@link #numerify(string)} and a {@link #letterify(string, bool)}
//        // * over the incoming string.
//        // *
//        // * @param string
//        // * @param isUpper
//        // * @return
//        // */
//        //public string bothify(string text, bool isUpper)
//        //{
//        //    return letterify(numerify(text), isUpper);
//        //}

//        ///**
//        // * Generates a string that matches the given regular expression.
//        // */
//        //public string regexify(string regex)
//        //{
//        //    //Generex generex = new Generex(regex);
//        //    //generex.setSeed(randomService.nextLong());
//        //    //return generex.random();
//        //}

//        ///**
//        // * Returns a string with the '?' characters in the parameter replaced with random alphabetic
//        // * characters.
//        // * <p/>
//        // * For example, the string "12??34" could be replaced with a string like "12AB34".
//        // *
//        // * @param letterString
//        // * @return
//        // */
//        //public string letterify(string letterString)
//        //{
//        //    return this.letterify(letterString, false);
//        //}

//        ///**
//        // * Returns a string with the '?' characters in the parameter replaced with random alphabetic
//        // * characters.
//        // * <p/>
//        // * For example, the string "12??34" could be replaced with a string like "12AB34".
//        // *
//        // * @param letterString
//        // * @param isUpper      specifies whether or not letters should be upper case
//        // * @return
//        // */
//        //public string letterify(string letterString, bool isUpper)
//        //{
//        //    return letterHelper((isUpper) ? 65 : 97, letterString); // from ascii table
//        //}

//        //private string letterHelper(int baseChar, string letterString)
//        //{
//        //    StringBuilder sb = new StringBuilder();
//        //    for (int i = 0; i < letterString.Length; i++)
//        //    {
//        //        if (letterString[i] == '?')
//        //        {
//        //            sb.Append((char)(baseChar + randomService.nextInt(26))); // a-z
//        //        }
//        //        else
//        //        {
//        //            sb.Append(letterString[i]);
//        //        }
//        //    }

//        //    return sb.ToString();
//        //}



//        ///**
//        // * resolves an expression using the current faker.
//        // *
//        // * @param expression
//        // * @param faker
//        // * @return
//        // */
//        //public string expression(string expression, Faker faker)
//        //{
//        //    return resolveExpression(expression, null, faker);
//        //}

        

   


      




 

//    }
//}