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
    public partial class ImplementationsControl : UserControl
    {
        public ImplementationsControl()
        {
            InitializeComponent();
            ImplementationsList.Items.Filter = (o) => o is ImplementationModel ex && (ex.Platform == FakerModel.AllPlatformsLiteral || ex.Platform == CurrentPlatform);
        }

        public static readonly DependencyProperty ClassProperty = DependencyProperty.Register(nameof(ClassPath), typeof(string), typeof(ImplementationsControl), new PropertyMetadata(""));
        public string ClassPath
        {
            get => (string)GetValue(ClassProperty);
            set => SetValue(ClassProperty, value);
        }

        public static readonly DependencyProperty ImplementationsProperty = DependencyProperty.Register(nameof(Implementations), typeof(ObservableCollection<ImplementationModel>), typeof(ImplementationsControl));
        public ObservableCollection<ImplementationModel> Implementations
        {
            get => (ObservableCollection<ImplementationModel>)GetValue(ImplementationsProperty);
            set => SetValue(ImplementationsProperty, value);
        }

        public static readonly DependencyProperty CurrentPlatformProperty = DependencyProperty.Register(nameof(CurrentPlatform), typeof(string), typeof(ImplementationsControl));
        public string CurrentPlatform
        {
            get => (string)GetValue(CurrentPlatformProperty);
            set => SetValue(CurrentPlatformProperty, value);
        }

        private void AddBnt_Click(object sender, RoutedEventArgs e)
        {
            var implementation = new ImplementationModel();
            implementation.InternalPlatform = CurrentPlatform;
            implementation.Type = "Native";
            if (ImplementationEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, ClassPath, implementation, true))
                this.Implementations.Add(implementation);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            ImplementationEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, ClassPath, (ImplementationModel)ImplementationsList.SelectedValue, true);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Implementations.Remove((ImplementationModel)ImplementationsList.SelectedValue);
        }

        private void ImplementationsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ImplementationsList.SelectedValue != null)
                ImplementationEditorWindow.Edit(new string?[] { FakerModel.AllPlatformsLiteral, CurrentPlatform }, ClassPath, (ImplementationModel)ImplementationsList.SelectedValue, true);
        }
    }
}
