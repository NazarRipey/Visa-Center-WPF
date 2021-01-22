using lab5_WPF.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab5_WPF.Model
{
    [Serializable]
    public class DataModel
    {
        public static string filePath = "data.dat";
        public IEnumerable<Case> Cases { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Manager> Managers { get; set; }
        public DataModel()
        {
            var client = new Client { Name = "Nazar Ripey", City = "Lviv", Email = "nripey1@gmail.com" };
            var manager = new Manager { Name = "Vasya Pupkin", Rating = 4.7 };

            Clients = new List<Client> { client };
            Managers = new List<Manager> { manager };
            Cases = new List<Case>
            {
                new Case() {
                    Client = client,
                    Manager = manager,
                    VisaType = VisaType.Tourist,
                    Status = Status.InProgress,
                    StartDate = DateTime.Now
                }
            };
        }
        public static DataModel Load()
        {
            if (File.Exists(filePath))
            {
                return DataSerializer.Deserialize(filePath);
            }
            return new DataModel();
        }
        public void Save()
        {
            DataSerializer.Serialize(filePath, this);
        }
    }
}
