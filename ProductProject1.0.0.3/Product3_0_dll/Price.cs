using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_dll
{
    public struct Price
    {
        public double basicPrice;
        private double Gst;
        public Price(double bPrice, double gst)
        {
            basicPrice = bPrice;
            Gst = gst;

        }
        public double getTaxPrice()
        {
            return  basicPrice * Gst / 100;
        }
       

    }
}
