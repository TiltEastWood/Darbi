using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number you want out of 20 random numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] numbers = new int[20];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 20);
            }
            Console.WriteLine(numbers[num]);
        }
    }
}
