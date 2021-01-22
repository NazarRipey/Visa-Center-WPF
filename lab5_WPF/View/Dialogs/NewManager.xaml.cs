using System.Windows;

namespace lab5_WPF.View.Dialogs
{
    /// <summary>
    /// Interaction logic for NewManager.xaml
    /// </summary>
    public partial class NewManager : Window
    {
        public NewManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string MName { get { return ManagerName.Text; } }
        public string Rating { get { return ManagerRating.Text; } }
    }
}
