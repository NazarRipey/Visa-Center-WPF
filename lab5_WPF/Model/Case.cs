using System;
using System.Runtime.Serialization;

namespace lab5_WPF.Model
{
    [Serializable]
    public class Case
    {
        public Client Client { get; set; }
        public Manager Manager { get; set; }
        public VisaType VisaType { get; set; }
        public Status Status { get; set; }
        public DateTime StartDate { get; set; }
    }
    public enum Status
    {
        [EnumMember]
        InProgress,
        [EnumMember]
        Approved,
        [EnumMember]
        Declined,
    }
}
