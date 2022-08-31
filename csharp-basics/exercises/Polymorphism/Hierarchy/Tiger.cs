using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Tiger : Felime
    {
        public Tiger(string livingRegion, string animalName, string animalType, double animalWeight) : base(livingRegion, animalName, animalType, animalWeight)
        {

        }
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Roar.");
        }
    }
}
