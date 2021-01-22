using System.Windows;

namespace lab5_WPF.View.Dialogs
{
    /// <summary>
    /// Interaction logic for NewClient.xaml
    /// </summary>
    public partial class NewClient : Window
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string CName { get { return ClientName.Text; } }
        public string City { get { return ClientCity.Text; } }
        public string Email { get { return ClientEmail.Text; } }
    }
}
