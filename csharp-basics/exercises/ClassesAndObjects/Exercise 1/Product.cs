using System;

namespace Exercise_1
{
    internal class Product
    {
        private string _name;
        private int _amountAtStart;
        private double _priceAtStart;

        public Product(string name, int amountAtStart, double priceAtStart)
        {
            this._name = name;
            this._amountAtStart = amountAtStart;
            this._priceAtStart = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine(_name + ", price " + _priceAtStart + " EUR, amount " + _amountAtStart + " units");
        }

        public void Changes()
        {
            Console.WriteLine("Write a new amount: ");
            int newAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a new price: ");
            double newPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(_name + ", price " + newPrice + " EUR, amount " + newAmount + " units");
        }
    }
}
