using System.Diagnostics;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FakerNet
{
    internal class YamlFileLoader
    {
        private static Dictionary<string, Dictionary<object, object>?> _yamlFileCache = new Dictionary<string, Dictionary<object, object>?>();

        public Dictionary<object, object>? LoadYamlResourceFile(string path)
        {
            lock (_yamlFileCache)
            {
                if (_yamlFileCache.TryGetValue(path, out Dictionary<object, object>? yamlFileData))
                    return yamlFileData;

                using (var yamlTextReader = OpenYamlResourceFile(path))
                {
                    if (yamlTextReader != null)
                    {
                        Debug.WriteLine($"Loaded : {path}");
                        var deserializer = new DeserializerBuilder()
                            .WithNamingConvention(CamelCaseNamingConvention.Instance)
                            .Build();
                        yamlFileData = deserializer.Deserialize<Dictionary<object, object>>(yamlTextReader);
                    }
                }

                _yamlFileCache[path] = yamlFileData;
                return yamlFileData;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceName">i.e. "MyCompany.MyProduct.MyFile.txt"</param>
        /// <returns></returns>
        private TextReader? OpenYamlResourceFile(string resourceName)
        {
            resourceName = "FakerNet/Resources" + resourceName;
            resourceName = resourceName.Replace("/", ".");
            Stream? stream = GetType().Assembly.GetManifestResourceStream(resourceName);
            return stream == null ? null : new StreamReader(stream);
        }
    }
}