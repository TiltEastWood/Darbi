using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachine : IVendingMachine
    {
        public readonly string[] AcceptedMoney = { "0,10 €", "0,20 €", "0,50 €", "1,0 €", "2,0 €" };
        public string Manufacturer { get; }
        public bool HasProducts { get; set; }
        public Money Amount { get; set; }
        public Product[] Products { get; set; }

        public VendingMachine(string Manufacturer)
        {
            HasProducts = false;
            this.Manufacturer = Manufacturer;
            Amount = new Money(0, 0);
            Products = new Product[10];

        }

        public Money InsertCoin(Money amount)
        {
            
            if (AcceptedMoney.Contains(amount.ToString()))
            {
                Amount = Amount.AddFunds(amount);
                Console.WriteLine("You have this amount: " + Amount);
                return Amount;
            }
            Console.WriteLine("VendingMachine accept only " + String.Join(" ", AcceptedMoney) + "Coins");
            
            return Amount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Available = count;

            Console.WriteLine(name + " " + price + " " + count);

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == null)
                {
                    Products[i] = product;
                    HasProducts = true;
                    return true;
                }
            }
            return false;
        }

        public Money ReturnMoney()
        {
            if(Amount.NumericValue() == 0)
            {
                return Amount;
            }
            var amountToReturn = Amount.NumericValue();
            //Amount = new Money();
            Console.WriteLine(Amount.ToString() + " returned");
            return Amount;
            
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            Products[productNumber - 1].Name = name;
            if (price != null)
            {
                Products[productNumber - 1].Price = (Money)price;
            }
            Products[productNumber - 1].Available = amount;
            return true;
        }

        public bool BuyProduct(int index)
        {
            var price = Products[index - 1].Price.NumericValue();
            var balance = Amount.NumericValue();

            if (Products[index - 1].Available < 1)
            {
                Console.WriteLine("Sorry, that product is unavailable");
                return false;
            }
            if (price > balance)
            {
                Console.WriteLine("You cannot afford that");
                return false;
            }

            Products[index - 1].Available += -1;
            Amount = Amount.RemoveFunds(Products[index - 1].Price);
            Console.WriteLine($"Enjoy your {Products[index - 1].Name}");
            ReturnMoney();
            
            return true;
        }
        
        


    }
}
