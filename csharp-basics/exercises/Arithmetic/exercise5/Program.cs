using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
                int guessNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == guessNumber)
                {
                    Console.WriteLine("You are right!");
                    return;
                }
                else if (randomNumber < guessNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else if (randomNumber > guessNumber)
                {
                    Console.WriteLine("Too low.");
                }
            }
            
        }
    }
}
