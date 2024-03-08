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
    [DebuggerDisplay("YAML Resolver {Locale.Name,nq} ({YamlFilename,nq})")]
    public class YamlValueResolver : IValueResolver
    {
        private YamlFileLoader _yamlLoader;
        private Dictionary<object, object>? _values;

        internal YamlValueResolver(YamlFileLoader yamlLoader, CultureInfo locale, string yamlFilename, string fakerCategory)
        {
            this._yamlLoader = yamlLoader;
            this.Locale = locale;
            this.YamlFilename = yamlFilename;
            this.FakerCategory = fakerCategory;
        }

        public CultureInfo Locale { get; }
        public string YamlFilename { get; }
        public string FakerCategory { get; }

        public Dictionary<object, object>? LoadValuesFromYaml()
        {
            Dictionary<object, object>? valuesMap = _yamlLoader.LoadYamlResourceFile(YamlFilename);

            if (valuesMap == null)
                return new Dictionary<object, object>();

            if (valuesMap.TryGetValue(Locale.Name, out var localeBasedResult) == false || localeBasedResult is not Dictionary<object, object> localeBased)
            {
                if (valuesMap.TryGetValue(YamlFilename, out localeBasedResult) == true && localeBasedResult is Dictionary<object, object> filenameBased)
                    localeBased = filenameBased;
                else
                    throw new InvalidOperationException("Could not find what we expected in the YML file");
            }
            return (Dictionary<object, object>)localeBased["faker"];
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
