using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON___Pokemon
{
    class PokeInfoAPI
    {
        public int height { get; set; }
        public int weight { get; set; }
        public Sprites sprites { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }

        public Versions versions { get; set; }
    }

    public class Versions
    {
        public Generationi generationi {get;set;}
    }

    public class Generationi
    {
        public Yellow yellow { get; set; }
    }

    public class Yellow
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
