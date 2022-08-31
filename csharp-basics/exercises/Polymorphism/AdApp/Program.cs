using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign(" Advert");
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200, true));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, 10, 14));
            c.AddAdvert(new TVAd(50000, 1000, 30, 14, 20));
            Console.WriteLine(c);
        }
    }
}