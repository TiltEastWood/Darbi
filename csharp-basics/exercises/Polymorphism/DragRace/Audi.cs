using System;

namespace DragRace
{
    public class Audi : Car
    {
        private string Name;
        private int currentSpeed = 0;

        public Audi(string name)
        {
            Name = name;
        }

        public void SpeedUp() 
        {
            currentSpeed++;
        }

        public void SlowDown() 
        {
            currentSpeed--;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString()+" "+Name;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}