using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());
            
            if (input > 0) 
            {
                
                if (input < 0) 
                {
                    input *= -1;
                }
                var lenght = input.ToString().Length;

                if (input >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (lenght == 2) 
                    {
                        digits = 2;
                    } 
                    else if (lenght == 3) 
                    {
                        digits = 3;
                    } 
                    else if (lenght == 4) 
                    {
                        digits = 4;
                    } 
                    else if (lenght == 5) 
                    {
                        digits = 5;
                    } 
                    else if (lenght == 6) 
                    {
                        digits = 6;
                    } 
                    else if (lenght == 7) 
                    {
                        digits = 7;
                    } 
                    else if (lenght == 8) 
                    {
                        digits = 8;
                    } 
                    else if (lenght == 9) 
                    {
                        digits = 9;
                    } 
                    else if (lenght == 10) 
                    {
                        digits = 10;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
