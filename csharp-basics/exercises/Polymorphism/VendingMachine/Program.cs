using System;
using System.Text;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;
            VendingMachine vending = new VendingMachine("Venden");

            vending.AddProduct("Coca-Cola", new Money(0, 70), 4);
            vending.AddProduct("Sprite", new Money(0, 60), 7);
            vending.InsertCoin(new Money(1, 00));
            vending.InsertCoin(new Money(0,50));
            vending.InsertCoin(new Money(0,20));
            vending.InsertCoin(new Money(0,10));
            vending.BuyProduct(1);
            vending.UpdateProduct(1, "Coca-Cola", new Money(0, 50), 2);
            vending.BuyProduct(1);
            
            
        }
    }
}
