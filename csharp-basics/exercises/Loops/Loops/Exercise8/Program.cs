using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number 1 - 7 to make pryamid: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    Console.Write('/');
                }   
                for (int k = 0; k < 24 ; k++)
                {
                    Console.Write(@"\");
                }
            }
            Console.WriteLine();
            for (int j = 0; j < userInput; j++)
            {
                for (int k = 0; k < 20; k++)
                {
                    Console.Write('/');
                }
                for (int n = 0; n < 8; n++)
                {
                    Console.Write('*');
                }
                for (int n = 0; n < 20; n++)
                {
                    Console.Write(@"\");
                }
            }
            Console.WriteLine();
            for (var i = 0; i < userInput; i++)
            {
                for (int k = 0; k < 16; k++)
                {
                    Console.Write('/');
                }
                for (int n = 0; n < 16; n++)
                {
                    Console.Write('*');
                }
                for (int n = 0; n < 16; n++)
                {
                    Console.Write(@"\");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < userInput; i++)
            {
                for (int k = 0; k < 12; k++)
                {
                    Console.Write('/');
                }
                for (int n = 0; n < 24; n++)
                {
                    Console.Write('*');
                }
                for (int n = 0; n < 12; n++)
                {
                    Console.Write(@"\");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < userInput; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Console.Write('/');
                }
                for (int n = 0; n < 32; n++)
                {
                    Console.Write('*');
                }
                for (int n = 0; n < 8; n++)
                {
                    Console.Write(@"\");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < userInput; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write('/');
                }
                for (int n = 0; n < 40; n++)
                {
                    Console.Write('*');
                }
                for (int n = 0; n < 4; n++)
                {
                    Console.Write(@"\");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < userInput; i++)
            {
                for (int n = 0; n < 48; n++)
                {
                    Console.Write('*');
                }
            }
        }
    }
}
