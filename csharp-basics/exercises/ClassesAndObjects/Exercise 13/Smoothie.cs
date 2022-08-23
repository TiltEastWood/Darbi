using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Smoothie
    {
        private string[] Ingredients;
        private double Cost;
        Dictionary<string, double> Prices = new Dictionary<string, double>()
        {
            {"Strawberries", 1.50 },
            {"Banana", 0.50 },
            {"Mango", 2.50 },
            {"Blueberries", 1.00 },
            {"Raspberries", 1.00 },
            {"Apple", 1.75 },
            {"Pineapple", 3.50 }
        };

        public Smoothie(string[] Ingredients)
        {
            this.Ingredients = Ingredients;
        }
        public void GetCost()
        {
            double cost = 0;

            foreach (string item in Ingredients)
            {
                cost = cost + Prices[item];
            }
            Console.WriteLine(cost);
            Cost = cost;
        }
        public void GetPrice()
        {
            double price = 0;

            price = Cost + (Cost * 1.5);

            Console.WriteLine(price);
        }
        public void GetName()
        {
            string name = "";

            if (Ingredients.Length > 1)
            {
                foreach (string item in Ingredients)
                {
                    if(item == "Strawberries")
                    {
                        name += ("Strawberry ");
                    }
                    else if (item == "Blueberries")
                    {
                        name += "Blueberry ";
                    }
                    else if (item == "Raspberries")
                    {
                        name += "Raspberry ";
                    }
                    else
                    {
                        name += (item + " ");
                    }
                }
                name += "fusion";
            }
            else
            {
                name += Ingredients[0] + " smoothie";
            }                      
            Console.WriteLine(name);
        }
    }
}
