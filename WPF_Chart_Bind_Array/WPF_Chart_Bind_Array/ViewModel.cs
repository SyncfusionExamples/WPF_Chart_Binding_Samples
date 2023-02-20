using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_Array
{
    public class ViewModel
    {
        public ViewModel()
        {
            var date = new DateTime(2015, 1, 1);

            Data = new ObservableCollection<Model>();

            Data.Add(new Model(date.AddMonths(1), new double[] { 698, 948 }));
            Data.Add(new Model(date.AddMonths(2),  new double[] { 903, 1203 }));
            Data.Add(new Model(date.AddMonths(3),  new double[] { 807, 1107 }));
            Data.Add(new Model(date.AddMonths(4),  new double[] { 1058, 1408 }));
            Data.Add(new Model(date.AddMonths(5), new double[] { 954, 1154}));
        }

        public ObservableCollection<Model> Data { get; set; }
    }
}
