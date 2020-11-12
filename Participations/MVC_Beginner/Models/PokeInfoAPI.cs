using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokeInfoAPI
    {
        public int height { get; set; }
        public int weight { get; set; }
        public Sprites sprites { get; set; }
 
    }

    public class Sprites
    {
        public string front_default { get; set; }
    }
}