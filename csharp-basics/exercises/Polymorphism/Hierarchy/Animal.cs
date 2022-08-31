using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Animal
    {
        string animalName;
        string animalType;
        double animalWeight;
        int foodEaten;

        public Animal (string animalName, string animalType, double animalWeight)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
        }

        public virtual void MakeAnimalSound()
        {
       
        }

        public void Eat(Food food)
        {
            foodEaten += food.quantity;
        }
        
        public void Display()
        {
            Console.WriteLine(animalName + " " + "ate this much: " + foodEaten + " " + animalWeight + "kg" + " " + animalType);
        }
    }
}
