using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Classes
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipcode)
        {
            name = Name;
            address = Address;
            zipcode = ZipCode;
        }

        public override string ToString()
        {
            string form = $"{Name} lives at {Address} with Zip Code {ZipCode}.";
            return form;
        }

    }
}
