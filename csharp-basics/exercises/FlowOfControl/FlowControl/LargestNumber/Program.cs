using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    Console.WriteLine("First number is the lagerst of three.");
                }
                else
                {
                    Console.WriteLine("Third number is the largest of three.");
                }
            }
            else if (input2 > input3)
            {
                Console.WriteLine("Second number is the largest of three.");
            }
            else
            {
                Console.WriteLine("Third number is the lagrest of three.");
            }
            Console.ReadKey();
        }
    }
}
