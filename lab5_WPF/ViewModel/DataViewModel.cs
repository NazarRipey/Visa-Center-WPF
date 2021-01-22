using lab5_WPF.Model;
using lab5_WPF.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace lab5_WPF.ViewModel
{
    public class DataViewModel : DependencyObject, INotifyPropertyChanged
    {
        public ObservableCollection<CaseViewModel> Cases { get; set; }
        public ObservableCollection<ClientViewModel> Clients { get; set; }
        public ObservableCollection<ManagerViewModel> Managers { get; set; }

        private string visibileControl = "Cases";

        public Command SetControlVisibility { get; set; }
        public Command Decide { get; set; }
        public Command AddManagerCommand { get; set; }
        public Command AddClientCommand { get; set; }
        public Command AddCaseCommand { get; set; }

        private static readonly DependencyProperty selectedCaseProperty;

        public event PropertyChangedEventHandler PropertyChanged;

        static DataViewModel()
        {
            selectedCaseProperty = DependencyProperty.Register("SelectedCase", typeof(CaseViewModel),
                typeof(DataGrid));
        }

        public List<VisaType> VisaTypes { get; set; }

        public DataViewModel()
        {
            VisaTypes = new List<VisaType>();
            VisaTypes.Add(VisaType.Business);
            VisaTypes.Add(VisaType.Tourist);
            VisaTypes.Add(VisaType.Work);

            SetControlVisibility = new Command(ControlVisibility);
            Decide = new Command(MakeDecision, obj => SelectedCase != null);
            AddManagerCommand = new Command(AddManager);
            AddClientCommand = new Command(AddClient);
            AddCaseCommand = new Command(AddCase);
        }
        public void AddCase(object arg)
        {
            NewCase newCaseDialog = new NewCase() { DataContext = this };
            if (newCaseDialog.ShowDialog() == true)
            {
                Cases.Add(new CaseViewModel()
                {
                    Client = newCaseDialog.NClient.getMyClient(),
                    Manager = newCaseDialog.NManager.getMyManager(),
                    VisaType = newCaseDialog.NVisaType,
                    Status = Status.InProgress,
                    StartDate = DateTime.Now
                });
            }
        }
        public void AddManager(object arg)
        {
            NewManager newManagerDialog = new NewManager();
            if (newManagerDialog.ShowDialog() == true)
            {
                double rating = Double.Parse(newManagerDialog.Rating.Replace('.', ','));

                Managers.Add(new ManagerViewModel(new Model.Manager() { Name = newManagerDialog.MName, Rating = rating }));
            }
        }
        public void AddClient(object arg)
        {
            NewClient newClientDialog = new NewClient();
            if (newClientDialog.ShowDialog() == true)
            {
                Clients.Add(new ClientViewModel(new Model.Client()
                {
                    Name = newClientDialog.CName,
                    City = newClientDialog.City,
                    Email = newClientDialog.Email
                }));
            }
        }
        public void MakeDecision(object arg)
        {
            Random random = new Random();
            MediaPlayer mediaPlayer = new MediaPlayer();

            if (random.NextDouble() < 0.6)
            {
                SelectedCase.Status = Model.Status.Approved;
                mediaPlayer.Open(new Uri(@"..\..\..\Sounds\success.mp3", UriKind.Relative));
            }
            else
            {
                SelectedCase.Status = Model.Status.Declined;
                mediaPlayer.Open(new Uri(@"..\..\..\Sounds\denied.mp3", UriKind.Relative));
            }

            mediaPlayer.Play();
        }
        public void ControlVisibility(object arg)
        {
            VisibleControl = arg.ToString();


        }
        public CaseViewModel SelectedCase
        {
            get
            {
                return (CaseViewModel)GetValue(selectedCaseProperty);
            }
            set
            {
                SetValue(selectedCaseProperty, value);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string VisibleControl
        {
            get { return visibileControl; }
            set
            {
                visibileControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
    }
}
