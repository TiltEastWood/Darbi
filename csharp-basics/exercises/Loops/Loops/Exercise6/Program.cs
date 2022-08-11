using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number (Max value 100): ");
            int input = Convert.ToInt32(Console.ReadLine());

            int number = 1;

            for (int x = 0; x < 5; x++)
            {
                for (int i = 0; i < (input / 5); i++)
                { 
                    if (number % 3 == 0)
                    {
                        Console.Write("Fizz ");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.Write("Buzz ");
                    }
                    else
                    {
                        Console.Write((number) + " ");
                    }
                    number++;
                }
                Console.WriteLine();
            }

        }
        
    }
}
