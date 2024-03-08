using System.Collections;
using System.Diagnostics;
using System.Resources;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FakerNet
{
    internal class YamlFileLoader
    {
        private static Dictionary<string, Dictionary<object, object>?> _yamlFileCache = new Dictionary<string, Dictionary<object, object>?>();

        static YamlFileLoader()
        {
            const string resHdr = "FakerNet.Resources.";
            const string resExt = ".yml";

            foreach (string resourceName in typeof(YamlFileLoader).Assembly.GetManifestResourceNames())
            {
                if (resourceName.StartsWith(resHdr) && resourceName.EndsWith(".yml"))
                {
                    string filename = resourceName.Substring(resHdr.Length, resourceName.Length - (resHdr.Length + resExt.Length)).Replace(".", "/") + resExt;
                    _yamlFileCache.Add(filename, null);
                }
            }

#if DEBUG
            #region Generate code for DataFiles.cs
            //StringBuilder dataFileRedirects = new StringBuilder();
            //dataFileRedirects.AppendLine("private static EnFile[] FILES_WITH_A_DIFFERENT_PATH = new[] {");

            //foreach (string resourceName in typeof(YamlFileLoader).Assembly.GetManifestResourceNames())
            //{
            //    if (resourceName.StartsWith(resHdr) && resourceName.EndsWith(".yml"))
            //    {
            //        string filename = resourceName.Substring(resHdr.Length, resourceName.Length - (resHdr.Length + resExt.Length)).Replace(".", "/") + resExt;
            //        if (filename.Contains("/"))
            //        {
            //            using (var yamlTextReader = OpenYamlResourceFile(filename))
            //            {
            //                if (yamlTextReader != null)
            //                {
            //                    Debug.WriteLine($"Loaded : {filename}");
            //                    var deserializer = new DeserializerBuilder()
            //                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
            //                        .Build();
            //                    var yamlFileData = deserializer.Deserialize<Dictionary<object, object>>(yamlTextReader);
            //                    Dictionary<object, object>? locale = yamlFileData.First().Value as Dictionary<object, object>;
            //                    Dictionary<object, object>? faker = locale?["faker"] as Dictionary<object, object>;
            //                    string? group = faker?.First().Key as string;

            //                    string filenameGroup = filename.Substring(0, filename.Length - resExt.Length);
            //                    filenameGroup = filenameGroup.Substring(filenameGroup.LastIndexOf('/') + 1);
            //                    if (filenameGroup != group)
            //                        dataFileRedirects.AppendLine($"    new EnFile(\"{filename}\", \"{group}\"),");
            //                }
            //            }
            //        }
            //    }
            //}
            //dataFileRedirects.AppendLine("};");
            //Debug.WriteLine(dataFileRedirects);
            #endregion
#endif
        }
        public bool ContainsYamlResourceFile(string path)
        {
            return _yamlFileCache.ContainsKey(path);
        }

        public Dictionary<object, object>? LoadYamlResourceFile(string path)
        {
            // does not exist
            if (_yamlFileCache.TryGetValue(path, out Dictionary<object, object>? yamlFileData) == false)
                return null;

            // exists but not loaded
            if (yamlFileData == null)
            {
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
            }

            _yamlFileCache[path] = yamlFileData;
            return yamlFileData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceName">i.e. "MyCompany.MyProduct.MyFile.txt"</param>
        /// <returns></returns>
        private static TextReader? OpenYamlResourceFile(string resourceName)
        {
            resourceName = "FakerNet/Resources/" + resourceName;
            resourceName = resourceName.Replace("/", ".");
            Stream? stream = typeof(YamlFileLoader).Assembly.GetManifestResourceStream(resourceName);
            return stream == null ? null : new StreamReader(stream);
        }
    }
}