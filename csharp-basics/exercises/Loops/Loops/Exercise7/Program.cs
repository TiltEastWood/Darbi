using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int diceRoll = dice.Next(1, 6);
            int points = 0;

            bool cont = true;

            while (cont == true)
            {
                Console.WriteLine("You rolled " + diceRoll);
                points = points + diceRoll;
                if (diceRoll == 1)
                {
                    cont = false;
                    points = 0;
                    break;
                }
                Console.WriteLine("Roll again?");
                cont = bool.Parse(Console.ReadLine());

                diceRoll = dice.Next(1, 6);

            }
            Console.WriteLine("You got points " + points);
            
            
        }

    }
}
