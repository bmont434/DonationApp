using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Project

{
    public class Donor
    {
        public Donor(string First, string Last, double Amount, string Address, string State, int Zip, string Date)
        {
            this.First = First;
            this.Last = Last;
            this.Amount = Amount;
            this.Address = Address;
            this.Zip = Zip;
            this.State = State;
            this.Date = Date;
        }

        public Donor() { }

        public string First { get; set; }

        public string Last { get; set; }

        public double Amount { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public string Date { get; set; }
    }
}
