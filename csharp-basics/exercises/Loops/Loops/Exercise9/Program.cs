using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            int dice1 = rnd.Next(1, 7);
            int points = 0;
            int cont = 0;

            Console.WriteLine("Desired sum: 9");

            while(cont != 9)
            {
                points = dice + dice1;
                Console.WriteLine(dice + " and " + dice1 + " = " + points);
                
                if (points == 9)
                {
                    break;
                }
                dice = rnd.Next(1, 7);
                dice1 = rnd.Next(1, 7);
            }
            
        }
    }
}
