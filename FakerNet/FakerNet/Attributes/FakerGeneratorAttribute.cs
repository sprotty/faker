namespace FakerNet
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FakerGeneratorAttribute : Attribute
    {
        public FakerGeneratorAttribute(string fakerGeneratorName )
        {
            this.FakerGeneratorName = fakerGeneratorName.ToLower();
        }
        public string FakerGeneratorName { get; }
    }

}
