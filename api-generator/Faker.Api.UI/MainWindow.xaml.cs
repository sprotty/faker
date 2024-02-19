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

                //var allClasses = jFaker.Classes.SelectMany(c => c.Classes).Union(jFaker.Classes);
                //var allMethods = allClasses.SelectMany(c => c.Methods);
                //var allImplementations = allClasses.SelectMany(c => c.Methods).SelectMany(m => m.Implementations);
                //var allArgs = allClasses.SelectMany(c => c.Methods).SelectMany(m => m.Arguments);
                //var allDesc = allArgs.SelectMany(i => i.Descriptions);
                //var allMehtodDesc = allMethods.SelectMany(i => i.Descriptions);
                //var allExamples = allMethods.SelectMany(i => i.Examples);

                //foreach (var example in allExamples)
                //{
                //    int indent = GetCommonIndent(example.Description, 4);
                //    if (indent > 0)
                //    {
                //        example.Description = RemoveCommonIndent(example.Description, indent, 4);
                //        while (example.Description.StartsWith('\n'))
                //            example.Description = example.Description.Substring(1);
                //        while (example.Description.EndsWith('\n'))
                //            example.Description = example.Description.Substring(0, example.Description.Length - 1);
                //    }
                //}

                //foreach (var example in allExamples)
                //{
                //    if (example.Code is null) continue;
                //    int indent = GetCommonIndent(example.Code, 4);
                //    if (indent > 0)
                //    {
                //        example.Code = RemoveCommonIndent(example.Code, indent, 4);
                //        while (example.Code.StartsWith('\n'))
                //            example.Code = example.Code.Substring(1);
                //        while (example.Code.EndsWith('\n'))
                //            example.Code = example.Code.Substring(0, example.Code.Length - 1);
                //    }
                //}

                //foreach (var desc in allMehtodDesc)
                //{
                //    int indent = GetCommonIndent(desc.Text, 4);
                //    if (indent > 0)
                //    {
                //        desc.Text = RemoveCommonIndent(desc.Text, indent, 4);
                //        while (desc.Text.StartsWith('\n'))
                //            desc.Text = desc.Text.Substring(1);
                //        while (desc.Text.EndsWith('\n'))
                //            desc.Text = desc.Text.Substring(0, desc.Text.Length - 1);
                //    }
                //}

                //foreach (var desc in allDesc)
                //{
                //    int indent = GetCommonIndent(desc.Text, 4);
                //    if (indent > 0)
                //    {
                //        desc.Text = RemoveCommonIndent(desc.Text, indent, 4);
                //        while (desc.Text.StartsWith('\n'))
                //            desc.Text = desc.Text.Substring(1);
                //        while (desc.Text.EndsWith('\n'))
                //            desc.Text = desc.Text.Substring(0, desc.Text.Length - 1);
                //    }
                //}
                //var allNativeImpls = allImplementations.Where(i => i.Type == "Native" && string.IsNullOrWhiteSpace(i.Data?.Trim()) == false);
                //var allNativeImplsWithNoTarget = allImplementations.Where(i => i.Type == "Native" && string.IsNullOrWhiteSpace(i.Data?.Trim()) == false && string.IsNullOrWhiteSpace(i.InternalPlatform));
                //foreach (var impl in allNativeImpls)
                //{
                //    var data = impl.Data.Split("/n");
                //    var newData = string.Join("\n", data.Select(l => l.Trim()));
                //    if (newData.StartsWith("\"") && newData.EndsWith("\""))
                //    {
                //        impl.Type = "Expression";
                //        newData = newData.Substring(1, newData.Length - 2);
                //    }
                //    impl.Data = newData;
                //}

                //foreach (var impl in allNativeImplsWithNoTarget)
                //    impl.Platform = "Ruby";

            }

            //string TrimEx(string? str)
            //{
            //    if (str == null || str == string.Empty)
            //        return string.Empty;

            //    int startPos = 0;
            //    int endPos = 0;
            //    for (startPos = 0; startPos < str.Length; startPos++)
            //    {
            //        if (!char.IsWhiteSpace(str[startPos]))
            //        {
            //            break;
            //        }
            //    }
            //    for (endPos = str.Length - 1; endPos > startPos; endPos--)
            //    {
            //        if (!char.IsWhiteSpace(str[endPos]))
            //        {
            //            break;
            //        }
            //    }
            //    if (startPos == 0 && endPos == str.Length)
            //        return str;
            //    else if (startPos > endPos)
            //        return string.Empty;
            //    else
            //        return str.Substring(startPos, (endPos + 1) - startPos);
            //}
        }

        //#region GetCommonIndent
        ///// <summary>
        ///// works out the max number of whitespace positions that exist on every line (with content)
        ///// </summary>
        ///// <param name="txt"></param>
        ///// <param name="tabWidth"></param>
        ///// <returns></returns>
        //public static int GetCommonIndent(string txt, int tabWidth)
        //{
        //    if (string.IsNullOrEmpty(txt))
        //        return 0;

        //    StringBuilder output = new StringBuilder();
        //    int maxLeadingWhitespace = int.MaxValue;
        //    int thisLineLeadingWhitespace = 0;
        //    bool nonWhitespaceEncountered = false;

        //    foreach (var c in txt)
        //    {
        //        switch (c)
        //        {
        //            case ' ':
        //                if (nonWhitespaceEncountered == false)
        //                    thisLineLeadingWhitespace++;
        //                break;
        //            case '\t':
        //                if (nonWhitespaceEncountered == false)
        //                {
        //                    int spacesToAdd = tabWidth - (thisLineLeadingWhitespace % tabWidth);
        //                    thisLineLeadingWhitespace += spacesToAdd;
        //                }
        //                break;

        //            case '\n':
        //                if (nonWhitespaceEncountered)
        //                {
        //                    maxLeadingWhitespace = Math.Min(thisLineLeadingWhitespace, maxLeadingWhitespace);
        //                }
        //                thisLineLeadingWhitespace = 0;
        //                nonWhitespaceEncountered = false;
        //                break;

        //            default:
        //                nonWhitespaceEncountered = true;
        //                break;
        //        }
        //    }
        //    if (nonWhitespaceEncountered)
        //        maxLeadingWhitespace = Math.Min(thisLineLeadingWhitespace, maxLeadingWhitespace);
        //    if (maxLeadingWhitespace == int.MaxValue)
        //        maxLeadingWhitespace = 0;
        //    return maxLeadingWhitespace;
        //}
        //#endregion

        //#region RemoveCommonIndent
        ///// <summary>
        ///// Takes of any c
        ///// </summary>
        ///// <param name="txt"></param>
        ///// <param name="tabWidth"></param>
        ///// <returns></returns>
        //public static string RemoveCommonIndent(string txt, int whitespaceCharsToRemove, int tabWidth)
        //{
        //    if (string.IsNullOrEmpty(txt))
        //        return "";

        //    StringBuilder output = new StringBuilder();
        //    int spacesToRemove = whitespaceCharsToRemove;
        //    bool nonWhitespaceEncountered = false;
        //    int colPos = 0;
        //    StringBuilder sb = new StringBuilder(txt.Length);

        //    foreach (var c in txt)
        //    {
        //        switch (c)
        //        {
        //            case ' ':
        //                colPos++;
        //                if (nonWhitespaceEncountered == false && spacesToRemove-- > 0)
        //                    continue; // skip space

        //                break;
        //            case '\t':
        //                int spacesForTab = tabWidth - (colPos % tabWidth);

        //                if (nonWhitespaceEncountered || spacesToRemove <= 0)
        //                    break;

        //                spacesToRemove -= spacesForTab;
        //                if (spacesToRemove < 0)
        //                    sb.Append(' ', -spacesToRemove);
        //                continue;

        //            case '\n':
        //                colPos = 0;
        //                spacesToRemove = whitespaceCharsToRemove;
        //                nonWhitespaceEncountered = false;
        //                break;

        //            default:
        //                nonWhitespaceEncountered = true;
        //                break;
        //        }

        //        sb.Append(c);
        //    }
        //    return sb.ToString();
        //}
        //#endregion

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

                if (clsEntry.Name.Length == 0 || !char.IsLetter(clsEntry.Name[0]) || !char.IsUpper(clsEntry.Name[0]) || clsEntry.Name.Any(c => char.IsLetterOrDigit(c) == false))
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

                    foreach (var arg in method.Arguments)
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