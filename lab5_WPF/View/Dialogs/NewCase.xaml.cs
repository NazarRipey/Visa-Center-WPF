using lab5_WPF.Model;
using lab5_WPF.ViewModel;
using System.Windows;

namespace lab5_WPF.View.Dialogs
{
    /// <summary>
    /// Interaction logic for NewCase.xaml
    /// </summary>
    public partial class NewCase : Window
    {
        public NewCase()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public ClientViewModel NClient { get { return (ClientViewModel)Client.SelectedItem; } }
        public ManagerViewModel NManager { get { return (ManagerViewModel)Manager.SelectedItem; } }
        public VisaType NVisaType { get { return (VisaType)VisaType.SelectedItem; } }
    }
}
