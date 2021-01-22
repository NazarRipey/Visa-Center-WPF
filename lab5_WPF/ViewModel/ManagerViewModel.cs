using lab5_WPF.Model;

namespace lab5_WPF.ViewModel
{
    public class ManagerViewModel : BaseViewModel
    {
        private Manager manager;
        public ManagerViewModel(Manager manager)
        {
            this.manager = manager;
        }
        public Manager getMyManager()
        {
            return manager;
        }
        public string Name
        {
            get { return manager.Name; }
            set
            {
                manager.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Rating
        {
            get { return manager.Rating; }
            set
            {
                manager.Rating = value;
                OnPropertyChanged("Rating");
            }
        }
        public override string ToString()
        {
            return manager.ToString();
        }
    }
}
