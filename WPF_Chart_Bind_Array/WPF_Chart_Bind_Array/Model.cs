using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_Array
{
    public class Model
    {
        private DateTime month;

        public DateTime Month
        {
            get { return month; }
            set { month = value; }
        }

        private double[] saleCount;

        public double[] SaleCount
        {
            get { return saleCount; }
            set { saleCount = value; }
        }

        public Model(DateTime actualMonth, double[] actualSaleCount)
        {
            month = actualMonth;
            saleCount = actualSaleCount;
        }
    }
}
