using lab5_WPF.Model;
using System;

namespace lab5_WPF.ViewModel
{
    public class CaseViewModel : BaseViewModel
    {
        private Case myCase;
        public CaseViewModel(Case myCase)
        {
            this.myCase = myCase;
        }
        public Case getMyCase()
        {
            return myCase;
        }

        public CaseViewModel()
        {
            myCase = new Case()
            {
                Client = new Client { Name = "Nazar Ripey", City = "Lviv", Email = "nripey1@gmail.com" },
                Manager = new Manager { Name = "Vasya Pupkin", Rating = 4.7 },
                VisaType = VisaType.Tourist,
                Status = Status.InProgress,
                StartDate = DateTime.Now
            };
        }
        public Client Client
        {
            get { return myCase.Client; }
            set
            {
                myCase.Client = value;
                OnPropertyChanged("Client");
            }
        }
        public Manager Manager
        {
            get { return myCase.Manager; }
            set
            {
                myCase.Manager = value;
                OnPropertyChanged("Manager");
            }
        }
        public VisaType VisaType
        {
            get { return myCase.VisaType; }
            set
            {
                myCase.VisaType = value;
                OnPropertyChanged("VisaType");
            }
        }
        public Status Status
        {
            get { return myCase.Status; }
            set
            {
                myCase.Status = value;
                OnPropertyChanged("Status");
            }
        }
        public DateTime StartDate
        {
            get { return myCase.StartDate; }
            set
            {
                myCase.StartDate = value;
                OnPropertyChanged("StartDate");
            }
        }
    }
}
