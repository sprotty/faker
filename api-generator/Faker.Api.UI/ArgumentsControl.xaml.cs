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
    /// Interaction logic for ArgumentsControl.xaml
    /// </summary>
    public partial class ArgumentsControl : UserControl
    {
        public ArgumentsControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ArgumentsProperty = DependencyProperty.Register(nameof(Arguments), typeof(ObservableCollection<Argument>), typeof(ArgumentsControl));
        public ObservableCollection<Argument> Arguments
        {
            get => (ObservableCollection<Argument>)GetValue(ArgumentsProperty);
            set => SetValue(ArgumentsProperty, value);
        }

        public static readonly DependencyProperty CurrentPlatformProperty = DependencyProperty.Register(nameof(CurrentPlatform), typeof(string), typeof(ArgumentsControl));
        public string CurrentPlatform
        {
            get => (string)GetValue(CurrentPlatformProperty);
            set => SetValue(CurrentPlatformProperty, value);
        }

        public static readonly DependencyProperty AllTypesProperty = DependencyProperty.Register(nameof(AllTypes), typeof(string[]), typeof(ArgumentsControl));
        public string[] AllTypes
        {
            get => (string[])GetValue(AllTypesProperty);
            set => SetValue(AllTypesProperty, value);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var argument = new Argument();
            if (ArgumentEditorWindow.Edit(CurrentPlatform, AllTypes, argument))
                this.Arguments.Add(argument);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            ArgumentEditorWindow.Edit(CurrentPlatform, AllTypes, (Argument)ArgumentsList.SelectedValue);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Arguments.Remove((Argument)ArgumentsList.SelectedValue);
        }

        private void ArgumentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ArgumentEditorWindow.Edit(CurrentPlatform, AllTypes, (Argument)ArgumentsList.SelectedValue);
        }
    }
}
