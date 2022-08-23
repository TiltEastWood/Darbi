using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();

            for (int i = 0; i < 70; i++)
            {
                fuelGauge.addFuel();
            }
            fuelGauge.showFuel();

            Odometer odometer = new Odometer(fuelGauge);

            bool result = true;

            while (result == true)
            {
                result = odometer.addMilage();
                odometer.showMilage();
            }
        }
    }
}
