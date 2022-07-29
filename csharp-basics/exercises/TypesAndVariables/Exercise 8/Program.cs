using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write minutes: ");
            int time = Convert.ToInt32(Console.ReadLine());
            var year = 60 * 24 * 365;
            var days = 60 * 24;
            var years = time / year;
            var remiainingTime = time % year;
            var remainingDay = remiainingTime / days;
            Console.WriteLine(years);
            Console.WriteLine(remainingDay);
        }
    }
}
