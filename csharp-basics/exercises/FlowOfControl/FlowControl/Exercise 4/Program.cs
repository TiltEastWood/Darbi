using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press number form 1 - 7");
            var userInput = Convert.ToInt32(Console.ReadLine());
            PrintDayInWord(userInput);
        }
        public static void PrintDayInWord(int userInput)
        {
            if (userInput == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (userInput == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
