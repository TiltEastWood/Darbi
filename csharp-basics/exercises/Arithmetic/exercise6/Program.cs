using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            for (int x = 0; x < 10; x++)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.Write("CozaWoza ");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.Write("Coza ");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.Write("Loza ");
                    }
                    else if (number % 7 == 0)
                    {
                        Console.Write("Woza ");
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
