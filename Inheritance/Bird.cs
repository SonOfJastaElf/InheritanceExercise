using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Skin = "Feathery";
        }

        public double Wingspan { get; set; }
        public string FeatherColor { get; set; }
        public bool DoesItFly { get; set; }
        public string Noise { get; set; } 
    }
}
