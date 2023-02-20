using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_IEnumerable
{
    public class PatientViewModel
    {
        public PatientViewModel()
        {
            PatientData = new ObservableCollection<Patient>();

            PatientData.Add(new Patient("Johnson Godwin", 176));
            PatientData.Add(new Patient("Peter Jackman", 163.3));
            PatientData.Add(new Patient("James Oliver", 177));
            PatientData.Add(new Patient("Richard Joseph", 168.5));
            PatientData.Add(new Patient("Robert George", 178));
            PatientData.Add(new Patient("Kevin", 165.3));
            PatientData.Add(new Patient("Alvin", 175.3));

            PatientDetails = new Dictionary<string, double>();
            PatientDetails.Add("Johnson Godwin", 176);
            PatientDetails.Add("Peter Jackman", 163.3);
            PatientDetails.Add("James Oliver", 177);
            PatientDetails.Add("Richard Joseph", 168.5);
            PatientDetails.Add("Robert George", 178);
            PatientDetails.Add("Kevin", 165.3);
            PatientDetails.Add("Alvin", 175.3);
        }

        public ObservableCollection<Patient> PatientData
        {
            get;
            set;
        }

        public Dictionary<string,double> PatientDetails
        {
            get;
            set;
        }
    }
}
