using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Faker.Api.UI
{
    /// <summary>
    /// Interaction logic for ExamplesControl.xaml
    /// </summary>
    public partial class ExamplesControl : UserControl
    {
        public ExamplesControl()
        {
            InitializeComponent();
            ExamplesList.Items.Filter = (o) => o is Example ex && (ex.Platform == null || ex.Platform == CurrentPlatform);
        }

        public static readonly DependencyProperty ExamplesProperty = DependencyProperty.Register(nameof(Examples), typeof(ObservableCollection<Example>), typeof(ExamplesControl));
        public ObservableCollection<Example> Examples
        {
            get => (ObservableCollection<Example>)GetValue(ExamplesProperty);
            set => SetValue(ExamplesProperty, value);
        }

        public static readonly DependencyProperty CurrentPlatformProperty = DependencyProperty.Register(nameof(CurrentPlatform), typeof(string), typeof(ExamplesControl));
        public string CurrentPlatform
        {
            get => (string)GetValue(CurrentPlatformProperty);
            set => SetValue(CurrentPlatformProperty, value);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var example = new Example();
            if (ExampleEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, example, true))
                this.Examples.Add(example);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            ExampleEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, (Example)ExamplesList.SelectedValue, true);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Examples.Remove((Example)ExamplesList.SelectedValue);
        }

        private void ExamplesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ExampleEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, (Example)ExamplesList.SelectedValue, true);
        }
    }
}
