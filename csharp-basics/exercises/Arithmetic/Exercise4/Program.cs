using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int fact = 1;
            int number;

            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            if (number <= 10)
            {
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);  
            }
            else if (number > 10)
            {
                Console.WriteLine("The number is too high!");
            }
        }
    }
}
