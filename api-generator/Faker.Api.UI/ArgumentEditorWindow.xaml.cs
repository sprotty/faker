using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Faker.Api.UI
{
    /// <summary>
    /// Interaction logic for ExampleEditorWindow.xaml
    /// </summary>
    public partial class ArgumentEditorWindow : Window
    {
        public ArgumentEditorWindow()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AllPlatformsProperty = DependencyProperty.Register(nameof(AllPlatforms), typeof(string[]), typeof(ArgumentEditorWindow));
        public string[] AllPlatforms
        {
            get => (string[])GetValue(AllPlatformsProperty);
            set => SetValue(AllPlatformsProperty, value);
        }

        public static readonly DependencyProperty AllTypesProperty = DependencyProperty.Register(nameof(AllTypes), typeof(string[]), typeof(ArgumentEditorWindow));
        public string[] AllTypes
        {
            get => (string[])GetValue(AllTypesProperty);
            set => SetValue(AllTypesProperty, value);
        }


        public static readonly DependencyProperty CurrentPlatformProperty = DependencyProperty.Register(nameof(CurrentPlatform), typeof(string), typeof(ArgumentEditorWindow));
        public string CurrentPlatform
        {
            get => (string)GetValue(CurrentPlatformProperty);
            set => SetValue(CurrentPlatformProperty, value);
        }




        public static bool Edit(string currentPlatform, string[] allTypes, ArgumentModel argument)
        {
            var frm = new ArgumentEditorWindow();
            frm.DataContext = new ArgumentModel(argument);
            frm.AllPlatforms = new string[] { FakerModel.AllPlatformsLiteral, currentPlatform }; ;
            frm.AllTypes = allTypes;
            frm.CurrentPlatform = currentPlatform;
            if (frm.ShowDialog() != true)
                return false;
            argument.CopyFrom(frm.Argument);
            return true;
        }

        private ArgumentModel Argument => (ArgumentModel)this.DataContext;

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
