using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool IsVenomous { get; set; }
        public bool HasLegs { get; set; }
        public string ScaleColor { get; set; }
        public bool RegrowsItsTail { get; set; }
    }
}
