using lab5_WPF.Model;
using lab5_WPF.ViewModel;
using System.Collections.Generic;

namespace lab5_WPF.Converter
{
    public static class ViewModelToModel
    {
        public static DataModel ToDataViewModel(DataViewModel viewModel)
        {
            List<Case> cases = new List<Case>();
            List<Client> clients = new List<Client>();
            List<Manager> managers = new List<Manager>();

            foreach (CaseViewModel c in viewModel.Cases)
                cases.Add(c.getMyCase());
            foreach (var cl in viewModel.Clients)
                clients.Add(cl.getMyClient());
            foreach (var m in viewModel.Managers)
                managers.Add(m.getMyManager());

            return new DataModel() { Cases = cases, Clients = clients, Managers = managers };
        }
    }
}
