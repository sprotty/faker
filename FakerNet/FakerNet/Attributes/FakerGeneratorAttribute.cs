using System.Text.RegularExpressions;

namespace FakerNet
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FakerGeneratorAttribute : Attribute
    {
        private static Regex s_ExprToSnakeCase = new Regex("([A-Z])");

        public FakerGeneratorAttribute(string fakerGeneratorName )
        {
            this.FakerGeneratorName = fakerGeneratorName;
            this.YamlName = s_ExprToSnakeCase.Replace(fakerGeneratorName, "_$1")
                        .Substring(1)
                        .ToLower();
        }
        public string FakerGeneratorName { get; }
        public string YamlName { get; }
    }

}
