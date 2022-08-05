using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(centuryFromYear(year) + " century");
        }
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
