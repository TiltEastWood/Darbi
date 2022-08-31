using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        string breed;
        public Cat(string breed, string livingRegion, string animalName, string animalType, double animalWeight) : base(livingRegion, animalName, animalType, animalWeight)
        {
            this.breed = breed;
        }
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Meow.");
        }
    }
}
