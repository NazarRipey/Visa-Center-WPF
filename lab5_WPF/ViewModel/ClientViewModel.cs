using lab5_WPF.Model;

namespace lab5_WPF.ViewModel
{
    public class ClientViewModel : BaseViewModel
    {
        private Client client;
        public ClientViewModel(Client client)
        {
            this.client = client;
        }
        public Client getMyClient()
        {
            return client;
        }

        public string Name
        {
            get { return client.Name; }
            set
            {
                client.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string City
        {
            get
            {
                if (string.IsNullOrEmpty(client.City))
                    return "not specified";
                return client.City;
            }
            set
            {
                client.City = value;
                OnPropertyChanged("City");
            }
        }
        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(client.Email))
                    return "not specified";
                return client.Email;
            }
            set
            {
                client.Email = value;
                OnPropertyChanged("Email");
            }
        }
        public override string ToString()
        {
            return client.ToString();
        }
    }
}
