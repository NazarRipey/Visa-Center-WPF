using System.Runtime.Serialization;

namespace lab5_WPF.Model
{
    public enum VisaType
    {
        [EnumMember]
        Business,
        [EnumMember]
        Tourist,
        [EnumMember]
        Work,
    }
}
