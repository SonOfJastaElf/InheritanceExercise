using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var heron = new Bird();

            heron.ActiveTime = "Day";
            heron.Diet = "Fish";
            heron.Environment = "Marshes";
            heron.Wingspan = 65.93;
            heron.FeatherColor = "Blue";
            heron.DoesItFly = true;
            heron.Noise = "Honk";

            var copperhead = new Reptile();

            copperhead.Skin = "Scaly";
            copperhead.ActiveTime = "Night";
            copperhead.Diet = "Rodents";
            copperhead.Environment = "Woods";
            copperhead.IsVenomous = true;
            copperhead.HasLegs = false;
            copperhead.ScaleColor = "Copper";
            copperhead.RegrowsItsTail = false;
        }
    }
}
