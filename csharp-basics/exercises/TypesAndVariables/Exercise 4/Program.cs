using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What year did your born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My name is " + name + " and I was born in " + yearBorn);
         }
    }
}
