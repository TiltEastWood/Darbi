using System;


namespace Exercise_3
{
    internal class FuelGauge
    {
        private int fuel = 0;

        public void showFuel()
        {
            Console.WriteLine("Fuel level: " + fuel);
        }
        public void addFuel()
        {
            if (fuel < 70)
            {
                fuel++;
            }
            
        }

        public void useFuel()
        {
            if (fuel > 0)
            {
                fuel--;
            }
        }

        public int getFuel()
        {
            return fuel;
        }

    }


}
