using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Zebra : Mammal
    {
        public Zebra(string livingRegion, string animalName, string animalType, double animalWeight) : base(livingRegion, animalName, animalType, animalWeight)
        {
        }
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Barks.");
        }
    }
}
