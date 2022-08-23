using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[] { "Banana" });
            Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });

            s1.GetCost();
            s1.GetPrice();
            s1.GetName();

            s2.GetCost();
            s2.GetPrice();
            s2.GetName();
        }
    }
}
