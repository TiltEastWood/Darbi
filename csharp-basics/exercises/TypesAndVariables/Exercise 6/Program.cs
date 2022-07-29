using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write fourth number");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            int sumAllnumbers = firstNumber + secondNumber + thirdNumber + fourthNumber;
            Console.WriteLine("Sum of all numbers is: " + sumAllnumbers);
        }
    }
}
