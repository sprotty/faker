using Microsoft.Win32;
using NJsonSchema.CodeGeneration.CSharp;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Faker.Api.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string? _openFilename;
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(@"C:\SourceCode\faker\api-generator\faker_api_metadata.json"))
                OpenFile(@"C:\SourceCode\faker\api-generator\faker_api_metadata.json");
        }

        public string[] AllPlatforms { get; } = new string[] { "C#", "Ruby" };
        public string[] AllTypes { get; } = new string[] { "String", "Integer", "Float", "Boolean" };
        public Root? Faker => (Root)this.DataContext;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Menu_Open_Click(object sender, RoutedEventArgs e)
        {
            if (this._openFilename != null && MessageBox.Show("Changes to current project will be lost, Continue?", "Confirm", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
                return;

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Title = "Select the Faker API Meta data file";
            dlg.FileName = "faker_api_metadata.json";
            dlg.DefaultExt = ".json";
            dlg.Filter = "json (.json)|*.json|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
                OpenFile(dlg.FileName);
        }

        private void OpenFile(string filename)
        {
            using (var jtr = new FileStream(filename, FileMode.Open))
            {
                Root? jFaker = JsonSerializer.Deserialize<Root>(jtr, new JsonSerializerOptions() { ReadCommentHandling = JsonCommentHandling.Skip });
                this.DataContext = jFaker;
                this._openFilename = filename;
            }
        }

        private void Menu_Save_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null && _openFilename != null)
            {
                string json = JsonSerializer.Serialize<Root>((Root)this.DataContext, new JsonSerializerOptions()
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText(this._openFilename, json, Encoding.UTF8);
            }
        }
        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit? Unsaved changes will be lost.", "Confirm", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
                return;
            Close();
        }

        private void Menu_Validate_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (Faker == null)
            {
                errors.AppendLine($"Error : File not open");

            }
            else
            {
                foreach (var dupRootCls in Faker.Classes.GroupBy(c => c.Name).Where(g => g.Count() > 1))
                    errors.AppendLine($"Error : Duplicate class name '{dupRootCls.Key}'. {dupRootCls.Count()} classes share this name.");

                foreach (var cls in Faker.Classes)
                    ValidateClass("", cls);
            }

            errors.AppendLine("Complete.");
            string reportFilename = System.IO.Path.ChangeExtension(_openFilename, ".log")!;
            File.WriteAllText(reportFilename, errors.ToString());




            void ValidateClass(string clsParentPath, ClassElement clsEntry)
            {
                string clsQname = clsParentPath + clsEntry.Name;
                string clsPath = clsParentPath + clsEntry.Name + ".";

                if (clsEntry.Name.Length == 0 || !char.IsLetter(clsEntry.Name[0]) || !char.IsUpper(clsEntry.Name[0]) || clsEntry.Name.Any(c=>char.IsLetterOrDigit(c) == false))
                    errors.AppendLine($"Error : Class '{clsQname}'. The name '{clsEntry.Name}' should be CamelCase, it should start with a Capital, and contain only letters and numbers.");

                foreach (var dupSubCls in clsEntry.Classes.GroupBy(c => c.Name).Where(g => g.Count() > 1))
                    errors.AppendLine($"Error : Class '{clsQname}'. Contains duplicate sub class names, {dupSubCls.Count()} classes share the name {dupSubCls.Key}.");

                foreach (var dupMethods in clsEntry.Methods.GroupBy(c => new { c.Name, c.Arguments.Count }).Where(g => g.Count() > 1))
                    errors.AppendLine($"Error : Class '{clsQname}'. Contains duplicate methods, {dupMethods.Count()} methods have the name '{dupMethods.Key.Name}' and {dupMethods.Key.Count} arguments.");

                foreach (var method in clsEntry.Methods)
                {
                    string methodQname = clsPath + method.Name;

                    if (method.Name.Any(c => char.IsUpper(c)))
                        errors.AppendLine($"Error : Method '{methodQname}'. The name {method.Name} should be snake_case, it should NOT contain capitals.");

                    foreach(var arg in method.Arguments)
                    {
                        string argQName = $"{methodQname}({arg.Name})";

                        if (arg.Name.Any(c => char.IsUpper(c)))
                            errors.AppendLine($"Error : Argument '{argQName}'. The name {arg.Name} should be snake_case, it should NOT contain capitals.");
                    }
                }


                if (clsParentPath != "" && clsEntry.Classes.Any())
                {
                    errors.AppendLine($"Error : Class '{clsQname}'. Only expecting classes to be nested at 2 levels. The following are to deep and will be ignored {string.Join(", ", clsEntry.Classes.Select(c => $"'{clsParentPath}{c.Name}'"))}.");
                }
                else
                {
                    foreach (var clsChild in clsEntry.Classes)
                    {
                        ValidateClass(clsPath, clsChild);
                    }
                }
            }
        }

    }

    public class TestRoot : Root
    {
        public TestRoot()
        {
            using (var jtr = new FileStream(@"C:\SourceCode\faker\api-generator\faker_api_metadata.json", FileMode.Open))
            {
                var tmpRoot = JsonSerializer.Deserialize<Root>(jtr, new JsonSerializerOptions() { ReadCommentHandling = JsonCommentHandling.Skip });
                this.Classes = tmpRoot.Classes;
                this.Types = tmpRoot.Types;
            }
        }
    }




    //public class PlatformSetConverter : IMultiValueConverter
    //{
    //    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (values[0] is string platform &&
    //            values[1] is IList<DescriptionElement> descriptions)
    //        {
    //            return (string.IsNullOrWhiteSpace(platform) ? "Default" : platform) + (descriptions.Any(t => (t.Platform ?? "") == platform) ? "" : " (Use Default)");
    //        }
    //        else
    //        {
    //            return Binding.DoNothing;
    //        }
    //    }

    //    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}