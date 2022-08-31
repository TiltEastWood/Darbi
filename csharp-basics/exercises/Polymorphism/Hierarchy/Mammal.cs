using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Mammal : Animal
    {
        public virtual string livingRegion { get; set; }

        public Mammal(string livingRegion, string animalName, string animalType, double animalWeight) : base(animalName, animalType, animalWeight)
        {
            this.livingRegion = livingRegion;
        }
    }
}
