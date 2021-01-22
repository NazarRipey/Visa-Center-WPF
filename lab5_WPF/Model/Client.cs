using System;
using System.ComponentModel.DataAnnotations;

namespace lab5_WPF.Model
{
    [Serializable]
    public class Client
    {
        public string Name { get; set; }
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
