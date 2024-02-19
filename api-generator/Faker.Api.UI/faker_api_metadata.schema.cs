/// Generated with https://app.quicktype.io/
/// 

namespace Faker.Api
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Diagnostics.CodeAnalysis;

    public class FakerModel : INotifyPropertyChanged
    {
        public const string AllPlatformsLiteral = "All Platforms";

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public partial class Root : FakerModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("types")]
        public virtual ObservableCollection<TypeElement> Types { get; set; } = new ObservableCollection<TypeElement>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("classes")]
        public virtual ObservableCollection<ClassElement> Classes { get; set; } = new ObservableCollection<ClassElement>();
    }

    public partial class ClassElement : FakerModel
    {
        private string _name = "";

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions")]
        public virtual ObservableCollection<DescriptionElement> Descriptions { get; set; } = new ObservableCollection<DescriptionElement>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("methods")]
        public virtual ObservableCollection<Method> Methods { get; set; } = new ObservableCollection<Method>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("classes")]
        public virtual ObservableCollection<ClassElement> Classes { get; set; } = new ObservableCollection<ClassElement>();
    }

    public partial class DescriptionElement : FakerModel
    {
        private string? _platform;
        private string _text = "";

        public DescriptionElement()
        {
        }
        public DescriptionElement(DescriptionElement src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(DescriptionElement src)
        {
            this.InternalPlatform = src.InternalPlatform;
            this.Text = src.Text;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform")]
        public virtual string? InternalPlatform { get => _platform; set { _platform = value; OnPropertyChanged(); } }

        [JsonIgnore]
        public virtual string Platform
        {
            get => _platform ?? FakerModel.AllPlatformsLiteral;
            set { InternalPlatform = (value == FakerModel.AllPlatformsLiteral) ? null : value; }
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("text")]
        [DefaultValue("")]
        public virtual string Text { get => _text; set { _text = value; OnPropertyChanged(); } }
    }

    public partial class Method : FakerModel
    {
        private string _name = "";
        private string _returnType = "String";
        private string _returnDesc = "";
        /// <summary>
        /// The name of the function as it is used internally (snake case). Plaform implementaions
        /// can convert these to suit there convensions.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions")]
        public virtual ObservableCollection<DescriptionElement> Descriptions { get; set; } = new ObservableCollection<DescriptionElement>();

        /// <summary>
        /// The return type of the function. String, Integer, Float, Boolean, or something defined in
        /// types
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("return_type")]
        public virtual string ReturnType { get => _returnType; set { _returnType = value; OnPropertyChanged(); } }

        /// <summary>
        /// The description of the return value
        /// types
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("return_desc")]
        public virtual string ReturnDesc { get => _returnDesc; set { _returnDesc = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates the method is used internally, but is not part of the interface.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hidden")]
        public virtual bool? Hidden { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("arguments")]
        public virtual ObservableCollection<Argument> Arguments { get; set; } = new ObservableCollection<Argument>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("examples")]
        public virtual ObservableCollection<Example> Examples { get; set; } = new ObservableCollection<Example>();


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("implementations")]
        public virtual ObservableCollection<Implementation> Implementations { get; set; } = new ObservableCollection<Implementation>();


    }

    public partial class Argument : FakerModel
    {
        private string _name = "";
        private string _type = "Native";
        private string? _default;

        public Argument()
        {
        }
        public Argument(Argument src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(Argument src)
        {
            this.Name = src.Name;
            this.Type = src.Type;
            this.Default = src.Default;
            this.Descriptions.Clear();
            foreach(var desc in src.Descriptions)
                this.Descriptions.Add(new DescriptionElement(desc));
        }

        /// <summary>
        /// The name (snake case) of the argument (may appear in the implmentation, so platform
        /// implementations should take this into account when renaming it to suit naming
        /// convensions).
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("type")]
        public virtual string Type { get => _type; set { _type = value; OnPropertyChanged(); } }

        /// <summary>
        /// The default value of the argument if not explicitly specified.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("default")]
        public virtual string? Default { get => _default; set { _default = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("descriptions")]
        public virtual ObservableCollection<DescriptionElement> Descriptions { get; set; } = new ObservableCollection<DescriptionElement>();


    }

    public partial class Example : FakerModel
    {
        private string? _platform;
        private string? _code;
        private string? _description;

        public Example()
        {
        }
        public Example(Example src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(Example src)
        {
            this.Code = src.Code;
            this.Description = src.Description;
            this.InternalPlatform = src.InternalPlatform;
        }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform")]
        public virtual string? InternalPlatform { get => _platform; set { _platform = value; OnPropertyChanged(); } }

        [JsonIgnore]
        public virtual string Platform
        {
            get => _platform ?? FakerModel.AllPlatformsLiteral;
            set { InternalPlatform = (value == FakerModel.AllPlatformsLiteral) ? null : value; }
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("description")]
        public virtual string? Description { get => _description; set { _description = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("code")]
        public virtual string? Code { get => _code; set { _code = value; OnPropertyChanged(); } }
    }
    public partial class Implementation : FakerModel
    {
        private string? _platform = null;
        private string? _type = "Resolve";
        private string? _data = null;
        private bool? _charSubst;
        private bool? _digitSubst;
        private bool? _translate;

        public Implementation()
        {
        }
        public Implementation(Implementation src)
        {
            CopyFrom(src);
        }
        public void CopyFrom(Implementation src)
        {
            InternalPlatform = src.InternalPlatform;
            Type = src.Type;
            Data = src.Data;
            CharSubst = src.CharSubst;
            DigitSubst = src.DigitSubst;
            Translate = src.Translate;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("platform")]
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
        [JsonPropertyName("type")]
        public virtual string Type { get => _type; set { _type = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates if character substitutions will be applied to the evaluated value (? becomes
        /// [A-Z|a-z])
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("charSubst")]
        public virtual bool? CharSubst { get => _charSubst; set { _charSubst = value; OnPropertyChanged(); } }


        /// <summary>
        /// Indicates if numeric substitutions will be applied to the evaluated value (# becomes [0-9])
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("digitSubst")]
        public virtual bool? DigitSubst { get => _digitSubst; set { _digitSubst = value; OnPropertyChanged(); } }


        /// <summary>
        /// Indicates if ther evaluated expression should be translated
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("translate")]
        public virtual bool? Translate { get => _translate; set { _translate = value; OnPropertyChanged(); } }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("data")]
        public virtual string? Data { get => _data; set { _data = value; OnPropertyChanged(); } }

    }

    public partial class TypeElement : FakerModel
    {
        private string _name = "";

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public virtual string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
    }
}
