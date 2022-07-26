using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 5000);
            Console.WriteLine(randomnumber);
            CheckOddEven(randomnumber);
            Console.WriteLine("Bye!");
        }

        static void CheckOddEven(int number)
        {
            int randomnumber = number;

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            
        }
    }
}
