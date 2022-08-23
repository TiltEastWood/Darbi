using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 14, 70.00);
            
            Product product2 = new Product("iPhone 5s", 3, 999.99);
            
            Product product3 = new Product("Epson EB-U05", 1, 440.46);
            
            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();

            product1.Changes();
            product2.Changes();
            product3.Changes();
        }
    }
}
