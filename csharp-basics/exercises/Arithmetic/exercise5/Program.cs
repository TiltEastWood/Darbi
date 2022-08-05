using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 100);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
                int GuessNumber = Convert.ToInt32(Console.ReadLine());
                if (RandomNumber == GuessNumber)
                {
                    Console.WriteLine("You are right!");
                    return;
                }
                else if (RandomNumber < GuessNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else if (RandomNumber > GuessNumber)
                {
                    Console.WriteLine("Too low.");
                }
            }
            
        }
    }
}
