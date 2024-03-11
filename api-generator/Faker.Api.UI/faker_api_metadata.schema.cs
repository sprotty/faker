/// Generated with https://app.quicktype.io/
/// 

namespace Faker.Api
{
    using Faker.Api.UI;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text.Json.Serialization;

    public class FakerModel : INotifyPropertyChanged
    {
        public const string AllPlatformsLiteral = "All Platforms";

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public partial class RootModel : FakerModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enums"), JsonPropertyOrder(0)]
        public virtual ObservableCollection<EnumModel> Enums { get; set; } = new ObservableCollection<EnumModel>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("types"), JsonPropertyOrder(1)]
        public virtual ObservableCollection<TypeModel> Types { get; set; } = new ObservableCollection<TypeModel>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("classes"), JsonPropertyOrder(2)]
        public virtual ObservableCollection<ClassModel> Classes { get; set; } = new ObservableCollection<ClassModel>();
    }

    public partial class ClassModel : FakerModel
    {
        private string _name = "";
        private string? _rubyQualifiedName;
        private bool _excludeCs = false;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        /// <summary>
        /// The name this is known by in the ruby code 
        /// If not present then its Faker::[Name]
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ruby_qualified_name"), JsonPropertyOrder(1)]
        public virtual string? RubyQualifiedName { get => _rubyQualifiedName; set { _rubyQualifiedName = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions"), JsonPropertyOrder(2)]
        public virtual ObservableCollection<DescriptionModel> Descriptions { get; set; } = new ObservableCollection<DescriptionModel>();

        /// <summary>
        /// Ignores the whole class in C#
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("exclude_cs"), JsonPropertyOrder(3)]
        public virtual bool ExcludeCs { get => _excludeCs; set { _excludeCs = value; OnPropertyChanged(); } }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("methods"), JsonPropertyOrder(10)]
        public virtual ObservableCollection<MethodModel> Methods { get; set; } = new ObservableCollection<MethodModel>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("classes"), JsonPropertyOrder(11)]
        public virtual ObservableCollection<ClassModel> Classes { get; set; } = new ObservableCollection<ClassModel>();
    }

    public partial class DescriptionModel : FakerModel
    {
        private string? _platform;
        private string _text = "";

        public DescriptionModel()
        {
        }
        public DescriptionModel(DescriptionModel src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(DescriptionModel src)
        {
            this.InternalPlatform = src.InternalPlatform;
            this.Text = src.Text;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform"), JsonPropertyOrder(0)]
        public virtual string? InternalPlatform { get => _platform; set { _platform = value; OnPropertyChanged(); } }

        [JsonIgnore]
        public virtual string Platform
        {
            get => _platform ?? FakerModel.AllPlatformsLiteral;
            set { InternalPlatform = (value == FakerModel.AllPlatformsLiteral) ? null : value; }
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("text"), JsonPropertyOrder(1)]
        public virtual string Text { get => _text; set { _text = value; OnPropertyChanged(); } }
    }

    public partial class MethodModel : FakerModel
    {
        private string _name = "";
        private string _returnType = "String";
        private string _returnDesc = "";
        private bool? _usesLocale = true;
        private string? _versionIntroduced;
        private string? _ltTdgMethodName;
        private bool _private = false;
        private bool _excludeCs = false;

        /// <summary>
        /// The name of the function as it is used internally (snake case). Plaform implementaions
        /// can convert these to suit there convensions.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions"), JsonPropertyOrder(2)]
        public virtual ObservableCollection<DescriptionModel> Descriptions { get; set; } = new ObservableCollection<DescriptionModel>();

        /// <summary>
        /// The return type of the function. String, Integer, Float, Boolean, or something defined in
        /// types
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("return_type"), JsonPropertyOrder(3)]
        public virtual string ReturnType { get => _returnType; set { _returnType = value; OnPropertyChanged(); } }

        /// <summary>
        /// The description of the return value
        /// types
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("return_desc"), JsonPropertyOrder(4)]
        public virtual string ReturnDesc { get => _returnDesc; set { _returnDesc = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates the method is used internally, but is not part of the interface.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("private"), JsonPropertyOrder(5)]
        public virtual bool Private { get => _private; set { _private = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("version_introduced"), JsonPropertyOrder(6)]
        public virtual string? VersionIntroduced { get => _versionIntroduced; set { _versionIntroduced = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates the method is used internally, but is not part of the interface.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("usesLocale"), JsonPropertyOrder(7)]
        [Browsable(false)]  
        public virtual bool? UsesLocaleInternal { get => _usesLocale==true?null: _usesLocale; set { _usesLocale = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual bool UsesLocale { get => _usesLocale??true; set { _usesLocale = value; OnPropertyChanged(); } }

        /// <summary>
        /// Ignores the method in C#
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("exclude_cs"), JsonPropertyOrder(3)]
        public virtual bool ExcludeCs { get => _excludeCs; set { _excludeCs = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("arguments"), JsonPropertyOrder(100)]
        public virtual ObservableCollection<ArgumentModel> Arguments { get; set; } = new ObservableCollection<ArgumentModel>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("examples"), JsonPropertyOrder(101)]
        public virtual ObservableCollection<ExampleModel> Examples { get; set; } = new ObservableCollection<ExampleModel>();


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("implementations"), JsonPropertyOrder(102)]
        public virtual ObservableCollection<ImplementationModel> Implementations { get; set; } = new ObservableCollection<ImplementationModel>();

        /// <summary>
        /// The name of the function in Liquid Technologies - Test Data Generator
        /// if null then the <see cref="Name"/> is used
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("lttdg_name"), JsonPropertyOrder(103)]
        public virtual string? LtTdgMethodName { get => _ltTdgMethodName; set { _ltTdgMethodName = value; OnPropertyChanged(); } }

    }

    public partial class ArgumentModel : FakerModel
    {
        private string _name = "";
        private string _type = "Native";
        private string? _default;
        private string? _defaultValueDesc = null;

        public ArgumentModel()
        {
        }
        public ArgumentModel(ArgumentModel src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(ArgumentModel src)
        {
            this.Name = src.Name;
            this.Type = src.Type;
            this.Default = src.Default;
            this.DefaultValueDesc = src.DefaultValueDesc;
            this.Descriptions.Clear();
            foreach (var desc in src.Descriptions)
                this.Descriptions.Add(new DescriptionModel(desc));
        }

        /// <summary>
        /// The name (snake case) of the argument (may appear in the implmentation, so platform
        /// implementations should take this into account when renaming it to suit naming
        /// convensions).
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("type"), JsonPropertyOrder(1)]
        public virtual string Type { get => _type; set { _type = value; OnPropertyChanged(); } }

        /// <summary>
        /// The default value of the argument if not explicitly specified.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("default"), JsonPropertyOrder(2)]
        public virtual string? Default { get => _default; set { _default = value; OnPropertyChanged(); } }

        /// <summary>
        /// A description of the value used if the property is not set (i.e. defaulted)
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("default_value_desc"), JsonPropertyOrder(3)]
        public virtual string? DefaultValueDesc { get => _defaultValueDesc; set { _defaultValueDesc = value; OnPropertyChanged(); } }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions"), JsonPropertyOrder(4)]
        public virtual ObservableCollection<DescriptionModel> Descriptions { get; set; } = new ObservableCollection<DescriptionModel>();


    }

    public partial class ExampleModel : FakerModel
    {
        private string? _platform;
        private string? _code;
        private string? _description;

        public ExampleModel()
        {
        }
        public ExampleModel(ExampleModel src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(ExampleModel src)
        {
            this.Code = src.Code;
            this.Description = src.Description;
            this.InternalPlatform = src.InternalPlatform;
        }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform"), JsonPropertyOrder(0)]
        public virtual string? InternalPlatform { get => _platform; set { _platform = value; OnPropertyChanged(); } }

        [JsonIgnore]
        public virtual string Platform
        {
            get => _platform ?? FakerModel.AllPlatformsLiteral;
            set { InternalPlatform = (value == FakerModel.AllPlatformsLiteral) ? null : value; }
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("description"), JsonPropertyOrder(1)]
        public virtual string? Description { get => _description; set { _description = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("code"), JsonPropertyOrder(2)]
        public virtual string? Code { get => _code; set { _code = value; OnPropertyChanged(); } }
    }
    public partial class ImplementationModel : FakerModel
    {
        private string? _platform = null;
        private string? _type = "Resolve";
        private string? _data = null;
        private bool? _charSubst;
        private bool? _digitSubst;
        private bool? _translate;

        public ImplementationModel()
        {
        }
        public ImplementationModel(ImplementationModel src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(ImplementationModel src)
        {
            InternalPlatform = src.InternalPlatform;
            Type = src.Type;
            Data = src.Data;
            CharSubst = src.CharSubst;
            DigitSubst = src.DigitSubst;
            Translate = src.Translate;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform"), JsonPropertyOrder(0)]
        public virtual string? InternalPlatform
        {
            get => _platform; set
            {
                _platform = value;
                if (this.InternalPlatform == null && this.Type == "Native")
                    this.Type = "Resolve";
                OnPropertyChanged();
                OnPropertyChanged(nameof(Platform));
            }
        }

        [JsonIgnore]
        public virtual string Platform
        {
            get => _platform ?? FakerModel.AllPlatformsLiteral;
            set { InternalPlatform = (value == FakerModel.AllPlatformsLiteral) ? null : value; }
        }


        /// <summary>
        /// How the method is implemented.
        /// Expression
        ///     An expression that will be evaluated directly (i.e. #{random_float '-180..180'})
        /// Resolve 
        ///     The value is resolved from the YAML files.
        /// Native 
        ///     The function has a native implementation (platform must be set, translate,
        ///     digiSubst, charSubst are ignored. If data is set it is assumed to be the native
        ///     implementation. If data is not set then the function must be implemented within the code).
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("type"), JsonPropertyOrder(1)]
        public virtual string Type { get => _type; set { _type = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates if character substitutions will be applied to the evaluated value (? becomes
        /// [A-Z|a-z])
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("charSubst"), JsonPropertyOrder(2)]
        public virtual bool? CharSubst { get => _charSubst; set { _charSubst = value; OnPropertyChanged(); } }


        /// <summary>
        /// Indicates if numeric substitutions will be applied to the evaluated value (# becomes [0-9])
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("digitSubst"), JsonPropertyOrder(3)]
        public virtual bool? DigitSubst { get => _digitSubst; set { _digitSubst = value; OnPropertyChanged(); } }


        /// <summary>
        /// Indicates if ther evaluated expression should be translated
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("translate"), JsonPropertyOrder(4)]
        public virtual bool? Translate { get => _translate; set { _translate = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("data"), JsonPropertyOrder(5)]
        public virtual string? Data
        {
            get => _data; set
            {
                string indentedText = (value??"").Replace("\r\n", "\n");
                int indent = Utilities.GetCommonIndent(indentedText, 4);
                if (indent > 0)
                {
                    indentedText = Utilities.RemoveCommonIndent(indentedText, indent, 4);
                    while (indentedText.StartsWith('\n'))
                        indentedText = indentedText.Substring(1);
                    while (indentedText.EndsWith('\n'))
                        indentedText = indentedText.Substring(0, indentedText.Length - 1);
                }

                _data = indentedText; 
                OnPropertyChanged();
            }
        }

    }

    public partial class TypeModel : FakerModel
    {
        private string _name = "";

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    }

    public partial class EnumModel : FakerModel
    {
        private string _name = "";

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("values"), JsonPropertyOrder(1)]
        public virtual ObservableCollection<EnumValueModel> Values { get; set; } = new ObservableCollection<EnumValueModel>();
    }

    public partial class EnumValueModel : FakerModel
    {
        private string _name = "";
        private string _description = "";

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("description"), JsonPropertyOrder(1)]
        public virtual string Descriptions { get => _description; set { _description = value; OnPropertyChanged(); } }
    }

}
