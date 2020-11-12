using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public Address()
        {
            StreetNumber = 0;
            StreetName = "";
            State = "";
            City = "";
            Zipcode = 0;
        }

        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            streetnumber = StreetNumber;
            streetname = StreetName;
            state = State;
            city = City;
            zipcode = Zipcode;
        }

        public override string ToString()
        {
            return $"{StreetNumber} {StreetName}, {City}, {State}, {Zipcode}";
        }
    }
}
