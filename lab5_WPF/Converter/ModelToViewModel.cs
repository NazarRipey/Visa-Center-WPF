using lab5_WPF.Model;
using lab5_WPF.ViewModel;
using System.Collections.ObjectModel;

namespace lab5_WPF.Converter
{
    public static class ModelToViewModel
    {
        public static DataViewModel ToDataViewModel(DataModel model)
        {
            ObservableCollection<CaseViewModel> caseViewModels = new ObservableCollection<CaseViewModel>();
            ObservableCollection<ClientViewModel> clientViewModels = new ObservableCollection<ClientViewModel>();
            ObservableCollection<ManagerViewModel> managerViewModels = new ObservableCollection<ManagerViewModel>();

            foreach (var c in model.Cases)
                caseViewModels.Add(new CaseViewModel(c));

            foreach (var cl in model.Clients)
                clientViewModels.Add(new ClientViewModel(cl));

            foreach (var m in model.Managers)
                managerViewModels.Add(new ManagerViewModel(m));

            return new DataViewModel() { Cases = caseViewModels, Managers = managerViewModels, Clients = clientViewModels };
        }
    }
}
