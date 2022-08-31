using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Persian", "Latvia", "Stella", "Off-road", 4.2);
            Mouse mouse = new Mouse("Basement", "Artis", "fastMouse", 0.019);
            Tiger tiger = new Tiger("Africa", "Tigger", "slowTiger", 97.3);
            Zebra zebra = new Zebra("Africa", "Stripe", "happyZebra", 330);

            Meat steak = new Meat(2);
            Vegatable carrot = new Vegatable(4);

            cat.Eat(carrot);
            cat.Display();
            cat.MakeAnimalSound();
            mouse.Eat(carrot);
            mouse.Display();
            mouse.MakeAnimalSound();
            tiger.Eat(steak);
            tiger.Display();
            tiger.MakeAnimalSound();
            zebra.Eat(carrot);
            zebra.Display();
            zebra.MakeAnimalSound();
            
        }
    }
}