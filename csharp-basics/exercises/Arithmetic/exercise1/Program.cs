using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 0;
            int Number2 = 0;
            Console.WriteLine("Write first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            if (Number1 == 15 && Number2 == 15)
            {
                Console.WriteLine("True");

            }
            else if (summOrDiff(Number1, Number2) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static bool summOrDiff(int num1, int num2)
        {
            bool result = false;
            if (num1 + num2 == 15)
            {
                result = true;
            }else if (num1 - num2 == 15 || num2 - num1 == 15)
            {
                result = true;
            }
                
                return result;
        }
    }
}
