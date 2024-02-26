using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

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
    public class IsNullOrWhiteSpaceVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return  string.IsNullOrWhiteSpace( value?.ToString()) ? Visibility.Collapsed : Visibility.Visible;
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
        IList<DescriptionElement>? _descriptions;
        private string? _platform;

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string? platform = values[0] as string;
            if (values[1] is IList<DescriptionElement> descriptions)
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
                _descriptions.Add(new DescriptionElement() { Platform = _platform, Text = text });
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

    public class AllTypesConverter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is ObservableCollection<TypeElement> types &&
                values[1] is ObservableCollection<EnumElement> enums)
            {
                List<string> allTypes = new List<string>();
                allTypes.Add("String");
                allTypes.Add("Integer");
                allTypes.Add("Float");
                allTypes.Add("Boolean");
                allTypes.Add("IntegerRange");
                allTypes.Add("DoubleRange");
                allTypes.AddRange(types.Select(t=>t.Name));
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

}
