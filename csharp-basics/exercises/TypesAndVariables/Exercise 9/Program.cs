using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your distance(Meters): ");
            double distanceInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write hours: ");
            double hoursInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write minutes: ");
            double minutesInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write seconds: ");
            double secondsInput = Convert.ToDouble(Console.ReadLine());

            var totalseconds = 60 * 60 * hoursInput + minutesInput * 60 + secondsInput;
            double totalHours = hoursInput + minutesInput / 60 + secondsInput / 60 / 60;
            double metersPerSecond = distanceInput / totalseconds;
            double distanceKM = ConvertKm(distanceInput);
            double kilometersPerHour = distanceKM / totalHours;
            var distanceMiles = ConvertMiles(distanceKM);
            var milesPerHour = distanceMiles / totalHours;

            Console.WriteLine("Your speed in meters/second is {0:F8}" , metersPerSecond);
            Console.WriteLine("Your speed in km/h is {0:F8}" , kilometersPerHour);
            Console.WriteLine("Your speed in miles/h is {0:F8} " , milesPerHour);
        }
        static double ConvertKm(double distanceInput)
        {
            double kilometers = distanceInput / 1000;
            return kilometers;
        }
        static double ConvertMiles(double distanceKM)
        {
            double miles = distanceKM * 0.621371;
            return miles;
        }
    }
}
