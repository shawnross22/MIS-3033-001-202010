using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Classes_2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        public string GetAisle()
        {
            string aisle = $"{Manufacturer[0]}{Price}";
            return aisle;
        }

        public override string ToString()
        {
            return "{" + Manufacturer + "} - {" + Name + "}"; 
        }
    }
}
