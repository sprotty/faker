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
    /// <summary>
    /// Resolves values from YAML Files
    /// </summary>
    [DebuggerDisplay("YAML Resolver {_locale.Name,nq} ({_path,nq} {_filename,nq})")]
    public class YamlValueResolver : IValueResolver
    {
        private YamlFileLoader _yamlLoader;
        private CultureInfo _locale;
        private string _filename;
        private string _path;
        private Dictionary<object, object>? _values;

        internal YamlValueResolver(YamlFileLoader yamlLoader, CultureInfo locale)
            : this(yamlLoader, locale, getFilename(locale), getFilename(locale))
        {
        }
        internal YamlValueResolver(YamlFileLoader yamlLoader, CultureInfo locale, string filename, string path)
        {
            this._yamlLoader = yamlLoader;
            this._locale = locale;
            this._filename = filename;
            this._path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        private static string getFilename(CultureInfo locale)
        {
            StringBuilder filename = new StringBuilder(language(locale));
            if (string.IsNullOrWhiteSpace(locale.GetCountry()) == false)
                filename.Append("-").Append(locale.GetCountry());
            return filename.ToString();
        }

        /// <summary>
        /// If you new up a locale with "he", it gets converted to "iw" which is old.
        /// This addresses that unfortunate condition.
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private static string language(CultureInfo l)
        {
            if (l.GetLanguage() == "iw")
            {
                return "he";
            }
            return l.GetLanguage();
        }


        public Dictionary<object, object>? LoadValuesFromYaml()
        {
            string pathWithLocaleAndFilename = "/" + _locale.GetLanguage() + "/" + this._filename;
            string pathWithFilename = "/" + _filename + ".yml";
            string pathWithLocale = "/" + _locale.GetLanguage() + ".yml";

            Dictionary<object, object>? valuesMap = null;
            string[] paths = new[] { pathWithLocaleAndFilename, pathWithFilename, pathWithLocale };
            foreach (string path in paths)
            {
                valuesMap = _yamlLoader.LoadYamlResourceFile(path);
                if (valuesMap != null)
                    break;
            }

            if (valuesMap == null)
                return new Dictionary<object, object>();

            if (valuesMap.TryGetValue(_locale.GetLanguage(), out var localeBasedResult) == false || localeBasedResult is not Dictionary<object, object> localeBased)
            {
                if (valuesMap.TryGetValue(_filename, out localeBasedResult) == true && localeBasedResult is Dictionary<object, object> filenameBased)
                    localeBased = filenameBased;
                else
                    throw new InvalidOperationException("Could not find what we expected in the YML file");
            }
            return (Dictionary<object, object>)localeBased["faker"];
        }



        internal bool SupportsPath(string path)
        {
            return this._path == path; //string.Compare(this._path, path, true) == 0; // the names we get from the YAML are inconsistent.
        }

        #region IValueResolver Implementation
        public Dictionary<object, object>? this[string key]
        {
            get
            {
                if (_values == null)
                    _values = LoadValuesFromYaml();
                if (_values?.TryGetValue(key, out var map) == true && map is Dictionary<object, object> dic)
                    return dic;

                return null;
            }
        }
        #endregion
    }
}
