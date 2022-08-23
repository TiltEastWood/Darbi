using System;

namespace Exercise_3
{
    internal class Odometer
    {
        int milage = 0;
        FuelGauge fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            this.fuelGauge = fuelGauge;
        }

        public void showMilage()
        {
            Console.WriteLine("Kilometers: " + milage);

            fuelGauge.showFuel();
        }

        public bool addMilage()
        {
            if (milage > 999999)
            {
                milage = 0;
            }

            milage++;
            
            if (milage % 10 == 0)
            {
                fuelGauge.useFuel();
                
            }
            if (fuelGauge.getFuel() <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
