using System;
using System.ComponentModel.DataAnnotations;

namespace lab5_WPF.Model
{
    [Serializable]
    public class Manager
    {
        public string Name { get; set; }

        [Range(0.0, 5.0)]
        public double Rating { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
