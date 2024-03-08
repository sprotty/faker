using Microsoft.Win32;
using NJsonSchema.CodeGeneration.CSharp;
using System.Collections.ObjectModel;
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

            MultiBinding multiBinding = new MultiBinding();
            multiBinding.Converter = new AllTypesConverter();
            multiBinding.Bindings.Add(new Binding(nameof(Root.Types)) { });
            multiBinding.Bindings.Add(new Binding(nameof(Root.Enums)) { });
            this.SetBinding(MainWindow.AllTypesProperty, multiBinding);
            //            < !--< Window.AllTypes >
            //    < MultiBinding Converter = "{StaticResource AllTypesConverter}" Mode = "OneWay" >
            //        < Binding Path = "Enums" Mode = "OneWay" />
            //        < Binding Path = "Types" Mode = "OneWay" />
            //    </ MultiBinding >
            //</ Window.AllTypes > -->
        }

        public static readonly DependencyProperty AllTypesProperty = DependencyProperty.Register(nameof(AllTypes), typeof(string[]), typeof(MainWindow), new FrameworkPropertyMetadata(new string[0]));
        public string[] AllTypes
        {
            get => (string[])GetValue(AllTypesProperty);
            set => SetValue(AllTypesProperty, value);
        }

        public string[] AllPlatforms { get; } = new string[] { "C#", "Ruby" };
        //public string[] AllTypes { get; } = new string[] { "String", "Integer", "Float", "Boolean" };
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

        private void Sort<TSource, TKey>(ObservableCollection<TSource> source, Func<TSource, TKey> keySelector)
        {
            var orderedList = source.OrderBy(keySelector).ToList();
            source.Clear();
            foreach (var item in orderedList)
                source.Add(item);
        }

        private void OpenFile(string filename)
        {
            using (var jtr = new FileStream(filename, FileMode.Open))
            {
                Root? jFaker = JsonSerializer.Deserialize<Root>(jtr, new JsonSerializerOptions() { ReadCommentHandling = JsonCommentHandling.Skip });
                this.DataContext = jFaker;
                this._openFilename = filename;

                // sort the classes and methods
                Sort(jFaker.Classes, c => c.Name);
                foreach (var cls in jFaker.Classes)
                {
                    Sort(cls.Methods, m => m.Name);
                    Sort(cls.Classes, c => c.Name);
                    foreach (var subCls in cls.Classes)
                    {
                        Sort(subCls.Methods, m => m.Name);
                    }
                }

                var allClasses = jFaker.Classes.SelectMany(c => c.Classes).Union(jFaker.Classes);
                var allMethods = allClasses.SelectMany(c => c.Methods);
                var allImplementations = allClasses.SelectMany(c => c.Methods).SelectMany(m => m.Implementations);
                var allArgs = allClasses.SelectMany(c => c.Methods).SelectMany(m => m.Arguments);
                var allArgDescs = allArgs.SelectMany(i => i.Descriptions);
                var allDesc = allArgs.SelectMany(i => i.Descriptions);
                var allMehtodDesc = allMethods.SelectMany(i => i.Descriptions);
                var allExamples = allMethods.SelectMany(i => i.Examples);

                //using (var jtrOld = new FileStream(@"C:\SourceCode\faker\api-generator\faker_api_metadata - Copy.json", FileMode.Open))
                //{
                //    Root? jFakerOld = JsonSerializer.Deserialize<Root>(jtrOld, new JsonSerializerOptions() { ReadCommentHandling = JsonCommentHandling.Skip });
                //    foreach (var cls in jFakerOld.Classes.Where(c => c.Classes.Any()))
                //    {

                //        foreach (var clsInner in cls.Classes)
                //        {
                //            Debug.WriteLine($"Class {clsInner.Name} = {cls.Name}.{clsInner.Name}");

                //            var newCls = allClasses.SingleOrDefault(c => c.Name == clsInner.Name);
                //            if (newCls == null)
                //                Debug.WriteLine($"Failed to find {clsInner.Name}");
                //            else
                //                newCls.RubyQualifiedName = $"{cls.Name}.{clsInner.Name}";

                //        }
                //    }
                //    Debug.WriteLine("Done");
                //}
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

                foreach (var desc in allDesc)
                {
                    int indent = Utilities.GetCommonIndent(desc.Text, 4);
                    if (indent > 0)
                    {
                        desc.Text = Utilities.RemoveCommonIndent(desc.Text, indent, 4);
                        while (desc.Text.StartsWith('\n'))
                            desc.Text = desc.Text.Substring(1);
                        while (desc.Text.EndsWith('\n'))
                            desc.Text = desc.Text.Substring(0, desc.Text.Length - 1);
                    }
                    if (desc.Text.StartsWith('\n'))
                        desc.Text = desc.Text.TrimStart();
                    if (desc.Text.EndsWith('\n'))
                        desc.Text = desc.Text.TrimEnd();
                    if (desc.Text.Split('\n').Length == 1)
                        desc.Text = desc.Text.Trim();
                    string firstLine = desc.Text.Split('\n')[0].Trim();
                    if (firstLine.EndsWith("."))
                        firstLine = firstLine.Substring(0, firstLine.Length - 1);
                    if (desc.Text.Contains($"<p>{firstLine}</p>"))
                        desc.Text = desc.Text.Replace($"<p>{firstLine}</p>", "");
                    if (desc.Text.StartsWith("<p>") && desc.Text.EndsWith("</p>") && desc.Text.IndexOf("<p>", "<p>".Length) == -1)
                        desc.Text = desc.Text.Substring("<p>".Length, desc.Text.Length - "</p><p>".Length).Trim();
                    desc.Text = desc.Text.Trim();
                }
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

        //#re

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
                GenerateCode();
            }
        }
        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit? Unsaved changes will be lost.", "Confirm", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
                return;
            Close();
        }

        private void Menu_Generate_Click(object sender, RoutedEventArgs e)
        {
            GenerateCode();
        }
        private void GenerateCode()
        {
            ProcessStartInfo spiFakerGen = new ProcessStartInfo("node", @"C:\SourceCode\faker\api-generator\DotNet\GenerateApi.js")
            {
                WorkingDirectory = @"C:\SourceCode\faker\api-generator\DotNet"
            };
            ProcessStartInfo spiFakerNUnit = new ProcessStartInfo("node", @"C:\SourceCode\faker\api-generator\DotNet\GenerateNUnit.js")
            {
                WorkingDirectory = @"C:\SourceCode\faker\api-generator\DotNet"
            };
            ProcessStartInfo spiSgAdapter = new ProcessStartInfo("node", @"C:\SourceCode\faker\api-generator\DotNet\GenerateSgApi.js")
            {
                WorkingDirectory = @"C:\SourceCode\faker\api-generator\DotNet"
            };

            Process.Start(spiFakerGen);
            Process.Start(spiFakerNUnit);
            Process.Start(spiSgAdapter);
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

        private void MethodsMenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            if (this.ClassTree.SelectedItem is ClassElement parentClass)
            {
                MethodModel methodToAdd = new MethodModel()
                {
                    Name = "new_method",
                    ReturnType = "String",
                };
                parentClass.Methods.Add(methodToAdd);
            }
        }
        private void MethodsMenuItem_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.MethodList.SelectedItem is MethodModel methodToDelete && this.ClassTree.SelectedItem is ClassElement parentClass)
            {
                parentClass.Methods.Remove(methodToDelete);
            }

        }

        #region Nasty Drag & Drop code
        private void ClassTree_Drop(object sender, DragEventArgs e)
        {
            var screenPos = e.GetPosition(this.ClassTree); ;
            var sourceCls = (ClassElement)e.Data.GetData("inadt");
            var targetCls = GetItemAtLocation<ClassElement>(screenPos);
            if (targetCls == null)
                return;

            // remove it from where it was
            if (GetParentClass(sourceCls) == null)
                this.Faker?.Classes.Remove(sourceCls);
            else
                GetParentClass(sourceCls)?.Classes.Remove(sourceCls);

            // add it to where we dropped it
            targetCls.Classes.Add(sourceCls);
        }

        public ClassElement? GetParentClass(ClassElement cls)
        {
            if (this.Faker == null || this.Faker.Classes.Contains(cls))
                return null;
            return this.Faker.Classes.FirstOrDefault(c => c.Classes.Contains(cls));
        }

        T GetItemAtLocation<T>(Point location)
        {
            T foundItem = default(T);
            HitTestResult hitTestResults = VisualTreeHelper.HitTest(ClassTree, location);

            if (hitTestResults.VisualHit is FrameworkElement)
            {
                object dataObject = (hitTestResults.VisualHit as FrameworkElement).DataContext;

                if (dataObject is T)
                {
                    foundItem = (T)dataObject;
                }
            }

            return foundItem;
        }
        private void ClassTree_DragOver(object sender, DragEventArgs e)
        {
            var screenPos = e.GetPosition(this.ClassTree);
            var sourceCls = (ClassElement)e.Data.GetData("inadt");
            var targetCls = GetItemAtLocation<ClassElement>(screenPos);
            if (GetParentClass(targetCls) != null || targetCls == sourceCls)
                e.Effects = DragDropEffects.None;
            else
                e.Effects = DragDropEffects.Move;
            e.Handled = true;
        }

        Point _startPoint;
        bool _IsDragging = false;

        void ClassTree_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed ||
                e.RightButton == MouseButtonState.Pressed && !_IsDragging)
            {
                Point position = e.GetPosition(null);
                if (Math.Abs(position.X - _startPoint.X) >
                        SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(position.Y - _startPoint.Y) >
                        SystemParameters.MinimumVerticalDragDistance)
                {
                    StartDrag(e);
                }
            }
        }

        void ClassTree_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(null);
        }

        private void StartDrag(MouseEventArgs e)
        {
            ClassElement cls = (ClassElement)this.ClassTree.SelectedValue;
            if (cls == null || cls.Classes.Count > 0)
                return;

            _IsDragging = true;
            DataObject data = null;
            data = new DataObject("inadt", cls);

            if (data != null)
            {
                DragDropEffects dde = DragDropEffects.Move;
                if (e.RightButton == MouseButtonState.Pressed)
                {
                    dde = DragDropEffects.All;
                }
                DragDropEffects de = DragDrop.DoDragDrop(this.ClassTree, data, dde);
            }
            _IsDragging = false;
        }
        #endregion
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