using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_JSON_Data
{
    public class Model
    {
        public DateTime Date { get; set; }
        public decimal CapacityUsed { get; set; }
        public decimal CapacityAvailable { get; set; }
        public decimal OverCapacity { get; set; }
        public decimal TotalHours { get; set; }
    }
}
