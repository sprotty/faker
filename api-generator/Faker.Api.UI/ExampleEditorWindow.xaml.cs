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
    public partial class ExampleEditorWindow : Window
    {
        public ExampleEditorWindow()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AllPlatformsProperty = DependencyProperty.Register(nameof(AllPlatforms), typeof(string[]), typeof(ExampleEditorWindow));
        public string?[] AllPlatforms
        {
            get => (string?[])GetValue(AllPlatformsProperty);
            set => SetValue(AllPlatformsProperty, value);
        }
        public static bool Edit(string?[] platforms, ExampleModel example, bool allowPlatformChange)
        {
            var frm = new ExampleEditorWindow();
            frm.DataContext = new ExampleModel(example);
            frm.PlatformCmb.IsReadOnly = allowPlatformChange = false;
            frm.AllPlatforms = platforms;
            if (frm.ShowDialog() != true)
                return false;
            example.CopyFrom((ExampleModel)frm.DataContext);
            return true;
        }

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
