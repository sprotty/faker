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
    public partial class ImplementationEditorWindow : Window
    {
        public ImplementationEditorWindow()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AllPlatformsProperty = DependencyProperty.Register(nameof(AllPlatforms), typeof(string[]), typeof(ImplementationEditorWindow));
        public string?[] AllPlatforms
        {
            get => (string?[])GetValue(AllPlatformsProperty);
            set => SetValue(AllPlatformsProperty, value);
        }


        public static bool Edit(string?[] platforms, Implementation implementation, bool allowPlatformChange)
        {
            var frm = new ImplementationEditorWindow();
            frm.DataContext = new Implementation(implementation);
            frm.PlatformCmb.IsReadOnly = allowPlatformChange = false;
            frm.AllPlatforms = platforms;
            if (frm.ShowDialog() != true)
                return false;
            implementation.CopyFrom(frm.Implementation);
            return true;
        }

        private Implementation Implementation => (Implementation)this.DataContext;

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void PlatformCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
