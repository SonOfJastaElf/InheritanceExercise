using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today, we'll look at two different sorts of animals: birds and reptiles.");
            Console.WriteLine("For each kind, we'll look at one example.  First up, birds.  Here's one for you: the heron");

            var heron = new Bird();

            heron.ActiveTime = "Day";
            heron.Diet = "Fish";
            heron.Environment = "Marshes";
            heron.Wingspan = 65.93;
            heron.FeatherColor = "Blue";
            heron.DoesItFly = true;
            heron.Noise = "Honk";

            Console.WriteLine($"Herons usually come out during the {heron.ActiveTime} and feed on {heron.Diet}, among other things, while roaming the {heron.Environment}.");
            Console.WriteLine($"They have wings {heron.Wingspan} inches long, and some of them have {heron.FeatherColor} feathers.");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("And now to take a look at a reptile, specifically a snake they call the Copperhead.");

            var copperhead = new Reptile();

            copperhead.Skin = "Scaly";
            copperhead.ActiveTime = "Night";
            copperhead.Diet = "Rodents";
            copperhead.Environment = "Woods";
            copperhead.IsVenomous = true;
            copperhead.HasLegs = false;
            copperhead.ScaleColor = "Copper";
            copperhead.HasScales = true;

            Console.WriteLine($"Like many reptiles, the Copperhead has {copperhead.Skin} skin of a {copperhead.ScaleColor} color, hence the name.");
            Console.WriteLine($"They usually come out at {copperhead.ActiveTime} and subsists primarily on {copperhead.Diet} and sometimes makes its home in the {copperhead.Environment}");
        }
    }
}
