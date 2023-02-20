using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_IEnumerable
{
    public class Patient
    {
        public Patient(string currentName, double currentHeight)
        {
            Name = currentName;
            Height = currentHeight;
        }

        public string Name { get; set; }

        public double Height { get; set; }
    }
}
