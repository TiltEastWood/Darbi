namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _fuelLiters;
        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _fuelLiters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _fuelLiters += liters;
        }
    }
}
