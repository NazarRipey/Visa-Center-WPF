using lab5_WPF.Converter;
using lab5_WPF.Model;
using lab5_WPF.ViewModel;
using System;
using System.Windows;

namespace lab5_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel model;
        private DataViewModel viewModel;
        public App()
        {
            model = DataModel.Load();
            viewModel = ModelToViewModel.ToDataViewModel(model);
            var window = new MainWindow() { DataContext = viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                model = ViewModelToModel.ToDataViewModel(viewModel);
                model.Save();
            }
            catch (Exception)
            {
                base.OnExit(null);
                throw;
            }
        }
    }
}
