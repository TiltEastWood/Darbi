using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Audi Audi_A6 = new Audi("Audi_A6");
            Bmw BMW_E34 = new Bmw("Bmw e34");
            Lexus Lexus_IS300 = new Lexus("Lexus_Is300");
            Subaru Impreza = new Subaru("Subaru Impreza");
            Toyota Supra = new Toyota("Toyota Supra");

            cars.Add(Audi_A6);
            cars.Add(Lexus_IS300);
            cars.Add(BMW_E34);
            cars.Add(Impreza);
            cars.Add(Supra);

            for(int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    DragRace(cars, true);
                }
                else
                {
                    DragRace(cars, false);
                }
            }
            PrintResults(cars);
        }

        public static void DragRace(List<Car> dragCars, bool boost)
        {
            for (int i = 0; i < dragCars.Count; i++)
            {
                dragCars[i].SpeedUp();
                
                if (dragCars[i] is Boost && boost == true)
                {
                    Boost b = (Boost)dragCars[i];
                    b.UseNitrousOxideEngine();                   
                }
                Console.WriteLine(dragCars[i].ShowCurrentSpeed());
            }
        }

        public static void PrintResults(List<Car> cars)
        {
            int speed = 0;
            Car fastest = null;
            foreach (Car car in cars)
            {
                int speed2 = Int32.Parse(car.ShowCurrentSpeed().Split(" ")[0]);

                if(speed2 > speed)
                {
                    speed = speed2;
                    fastest = car;
                }
            }
            Console.WriteLine(fastest.ShowCurrentSpeed());
        }
    }
}