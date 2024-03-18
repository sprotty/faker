using FakerNet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Faker.Api.UI
{
    public class NullVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class NotNullVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Visible: Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class IsNullOrWhiteSpaceVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrWhiteSpace(value?.ToString()) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class EqualsVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return object.Equals(value, parameter) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ImplementationDataDescConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (object.Equals(values[0], "Native"))
                return $"Native {values[1]} Code (Leave empty if the function is implemented explicitly in the code)";
            else if (object.Equals(values[0], "Expression"))
                return $"A Faker expression (i.e. \"#{{random_float '-180..180'}}\")";
            else if (object.Equals(values[0], "Resolve"))
                return $"A reference to a YAML entry (i.e. \"address.building_number\")";
            else
                return "Data";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class AllowableImplementationTypesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? new string[] { "Resolve", "Expression" } : new string[] { "Resolve", "Expression", "Native" };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class NotEqualsVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return object.Equals(value, parameter) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class IsNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class IsNotNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class DisplayTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString().Trim().Replace("\n", "\\n").Replace("\r", "\\r") ?? "<none>";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class DescriptionConverter : IMultiValueConverter
    {
        IList<DescriptionModel>? _descriptions;
        private string? _platform;

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string? platform = values[0] as string;
            if (values[1] is IList<DescriptionModel> descriptions)
            {
                _descriptions = descriptions;
                _platform = platform;
                var desc = descriptions.FirstOrDefault(t => t.Platform == platform);// ?? descriptions.FirstOrDefault(t => string.IsNullOrWhiteSpace(t.Platform));
                return desc?.Text ?? "";
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Debug.Assert(_descriptions != null && _platform != null);
            string text = (string)value;

            var entry = _descriptions.FirstOrDefault(t => (t.Platform ?? FakerModel.AllPlatformsLiteral) == _platform);
            if (entry == null && string.IsNullOrWhiteSpace(text) == false)
            {
                // create entry
                _descriptions.Add(new DescriptionModel() { Platform = _platform, Text = text });
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                // remove entry
                _descriptions.Remove(entry);
            }
            else
            {
                // update entry
                entry.Text = text;
            }

            return new object[]
            {
                Binding.DoNothing,
                Binding.DoNothing
            };
        }
    }

    public class AllTypesConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is ObservableCollection<TypeModel> types &&
                values[1] is ObservableCollection<EnumModel> enums)
            {
                List<string> allTypes = new List<string>();
                allTypes.Add("String");
                allTypes.Add("Integer");
                allTypes.Add("Float");
                allTypes.Add("Boolean");
                allTypes.Add("Binary");
                //allTypes.Add("IntegerRange");
                allTypes.Add("DoubleRange");
                allTypes.AddRange(types.Select(t => t.Name));
                allTypes.AddRange(enums.Select(t => t.Name));
                return allTypes.ToArray();
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



    public class SampleDataConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var fakerClassPath = values[0] as string;
                var implType = values[1] as string;
                var data = values[2] as string;
                var charSubst = values[3] as bool? ?? false;
                var digitSubs = values[4] as bool? ?? false;
                var translate = values[5] as bool? ?? false;

                if (string.IsNullOrWhiteSpace(data))
                {
                    return "No expression to evaluate";
                }
                else if (implType == "Native")
                {
                    return "Can not execute native methods";
                }

                StringBuilder sb = new StringBuilder();

                AppendLocaleSet(CultureInfo.CurrentCulture);
                AppendLocaleSet(new CultureInfo("fr-FR"));
                AppendLocaleSet(new CultureInfo("en-UK"));
                AppendLocaleSet(new CultureInfo("en-US"));
                AppendLocaleSet(new CultureInfo("ja-JP"));

                void AppendLocaleSet(CultureInfo locale)
                {
                    var faker = new FakerNet.Faker(locale);
                    GeneratorBase? generator = null;
                    object? generatorContainer = faker;
                    foreach (var genName in fakerClassPath.Split('/'))
                    {
                        generator = (GeneratorBase)generatorContainer
                            .GetType()
                            .GetProperties()
                            .First(p => p.PropertyType.GetCustomAttribute<FakerGeneratorAttribute>()?.FakerGeneratorName == genName).GetValue(generatorContainer);
                        generatorContainer = generator;
                    }
                    //var localeInst = new MySampleFakerGen();
                    sb.AppendLine();
                    sb.AppendLine($"Locale ({faker.Locale.Name})");
                    for (int i = 0; i < 5; i++)
                        sb.AppendLine(GetFakerValue(generator, implType, data, charSubst, digitSubs, translate));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return $"Error:\n{ex.Message}";
            }
        }

        private string GetFakerValue(GeneratorBase generatorInstance, string implType, string data, bool charSubst, bool digitSubs, bool translate)
        {
            try
            {
                string value;
                object? yamlContext = null;

                if (implType == "Resolve")
                {
                    value = generatorInstance.ResolveYamlValue(data, generatorInstance, ref yamlContext);
                }
                else if (implType == "Expression")
                {
                    value = generatorInstance.EvaluateExpression(data, generatorInstance, yamlContext);
                }
                else
                {
                    return $"Unknown type {implType}";
                }

                if (charSubst == true)
                    value = generatorInstance.Letterify(value);
                if (digitSubs == true)
                    value = generatorInstance.Numerify(value);
                if (translate == true)
                    value = generatorInstance.Translate(value);
                return value.ToString();
            }
            catch (Exception ex)
            {
                return $"Error:\n{ex.Message}";
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        //[FakerNet.FakerGenerator("tester")]
        //private class MySampleFakerGen : FakerNet.GeneratorBase
        //{
        //    public MySampleFakerGen(FakerNet.Faker faker) : base(faker)
        //    {
        //    }
        //}
    }

    public class GetClassPathConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is TreeView treeView)
            {
                ClassModel? cls = values[1] as ClassModel;
                if (cls == null)
                    return "";

                var tvi = treeView.ItemContainerGenerator.ContainerFromItemRecursive(cls) as TreeViewItem;
                if (tvi != null && treeView.ItemContainerGenerator.ItemFromContainer(GetSelectedTreeViewItemParent(tvi)) is ClassModel parentCls)
                    return parentCls.Name + "/" + cls.Name;
                else
                    return cls.Name;
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        public ItemsControl GetSelectedTreeViewItemParent(TreeViewItem item)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(item);
            while (!(parent is TreeViewItem || parent is TreeView))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return parent as ItemsControl;
        }

    }


    public class ClassColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool exclude)
            {
                if (exclude)
                    return Brushes.Gray;
                else
                    return Brushes.Black;
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();
    }

}
