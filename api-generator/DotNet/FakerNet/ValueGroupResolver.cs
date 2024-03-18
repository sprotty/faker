using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    [DebuggerDisplay("{GetType().Name,nq} {Locale.Name}")]
    public class ValueGroupResolver : IValueResolver
    {

        private List< YamlValueResolver> fakeValuesList = new List<YamlValueResolver>();

        internal ValueGroupResolver(YamlFileLoader yamlLoader, CultureInfo locale)
        {
            Locale = locale;

            foreach (EnFile file in EnFile.AllFiles)
            {
                string yamlFilename = locale.Name + "/" + file.YamlFilename;
                if (yamlLoader.ContainsYamlResourceFile(yamlFilename))
                {
                    fakeValuesList.Add(new YamlValueResolver(yamlLoader, locale, yamlFilename, file.Category));
                }
            }
        }

        public CultureInfo Locale { get; }

        //public void add(YamlValueResolver fakeValues)
        //{
        //    fakeValuesList.Add(fakeValues);
        //}

        public Dictionary<object, object>? this[string key]
        {
            get
            {
                Dictionary<object, object>? result = null;
                foreach (YamlValueResolver fakeValues in fakeValuesList)
                {
                    //if (string.IsNullOrWhiteSpace(fakeValues.FakerCategory) || fakeValues.FakerCategory == key)
                    {
                        if (result != null)
                        {
                            Dictionary<object, object>? newResult = fakeValues[key];
                            if (newResult != null)
                                newResult.ToList().ForEach(x => result[x.Key] = x.Value);
                        }
                        else
                        {
                            result = fakeValues[key];
                        }
                    }
                }
                return result;
            }
        }
    }
}
