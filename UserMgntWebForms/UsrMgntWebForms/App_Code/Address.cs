using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMgmtWebForms
{
    //in assign ment
    //create struct Price
    //double Basic
    //GST GST
    internal struct Address
    {
        public string Street;
        public string State;
        public string Country;
        public string Pincode;

        public Address(string strt,string stat,string ctry,string pin)
        {
            Street = strt;
            State = stat;
            Country = ctry;
            Pincode = pin;
        }
    }
}
