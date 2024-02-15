using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_Hafsa
{
    public class Mascot : Person
    {
        public string Color { get; set; }

        public Mascot(string name, int id, string color) : base(name, id)
        {
            Color = color;
        }

        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, Color: {Color}";
        }
    }
}
