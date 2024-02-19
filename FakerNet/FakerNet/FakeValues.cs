using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FakerNet
{
    public class FakeValues : FakeValuesInterface
    {
        private CultureInfo _locale;
        private string _filename;
        private string _path;
        private Dictionary<object, object>? _values;

        internal FakeValues(CultureInfo locale)
            : this(locale, getFilename(locale), getFilename(locale))
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        private static string getFilename(CultureInfo locale)
        {
            StringBuilder filename = new StringBuilder(language(locale));
            //var r = new RegionInfo(locale.LCID);

            if (string.IsNullOrWhiteSpace(locale.GetCountry()) == false)
            {
                filename.Append("-").Append(locale.GetCountry());
            }
            return filename.ToString();
        }

        /**
         * If you new up a locale with "he", it gets converted to "iw" which is old.
         * This addresses that unfortunate condition.
         */
        private static string language(CultureInfo l)
        {
            if (l.GetLanguage() == "iw")
            {
                return "he";
            }
            return l.GetLanguage();
        }

        internal FakeValues(CultureInfo locale, string filename, string path)
        {
            this._locale = locale;
            this._filename = filename;
            this._path = path;
        }

        public Dictionary<object, object>? this[string key]
        {
            get
            {
                if (_values == null)
                    _values = loadValues();
                if (_values?.TryGetValue(key, out var map) == true && map is Dictionary<object, object> dic)
                    return dic;

                return null;
            }
        }
        private Dictionary<object, object>? loadValues()
        {
            TextReader? stream = null;
            try
            {
                //throw new TodoException();
                string pathWithLocaleAndFilename = "/" + _locale.GetLanguage() + "/" + this._filename;
                string pathWithFilename = "/" + _filename + ".yml";
                string pathWithLocale = "/" + _locale.GetLanguage() + ".yml";

                string[] paths = new[] { pathWithLocaleAndFilename, pathWithFilename, pathWithLocale };
                foreach (string path in paths)
                {
                    stream = FindResourceTextFile(path);
                    if (stream != null)
                    {
                        break;
                    }
                }

                if (stream == null)
                {
                    return new Dictionary<object, object>();
                }

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                Dictionary<object, object> valuesMap = deserializer.Deserialize<Dictionary<object, object>>(stream);
                if (valuesMap.TryGetValue(_locale.GetLanguage(), out var localeBasedResult) == false || localeBasedResult is not Dictionary<object, object> localeBased)
                {
                    if (valuesMap.TryGetValue(_filename, out localeBasedResult) == true && localeBasedResult is Dictionary<object, object> filenameBased)
                        localeBased = filenameBased;
                    else
                        throw new InvalidOperationException("Could not find what we expected in the YML file");
                }
                return (Dictionary<object, object>)localeBased["faker"];
            }
            finally
            {
                stream?.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceName">i.e. "MyCompany.MyProduct.MyFile.txt"</param>
        /// <returns></returns>
        private TextReader? FindResourceTextFile(string resourceName)
        {
            resourceName = "FakerNet/Resources" + resourceName;
            resourceName = resourceName.Replace("/", ".");
            Stream? stream = GetType().Assembly.GetManifestResourceStream(resourceName);
            return stream == null ? null : new StreamReader(stream);
            //        if (stream == null) th
            //        }

            //        Stream streamOnClass = getClass().getResourceAsStream(filename);
            //if (streamOnClass != null)
            //{
            //    return streamOnClass;
            //}
            //return getClass().getClassLoader().getResourceAsStream(filename);
        }

        internal bool SupportsPath(string path)
        {
            return this._path == path;
        }
    }
}
