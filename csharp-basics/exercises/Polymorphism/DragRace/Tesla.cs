using System;

namespace DragRace 
{
    public class Tesla : Car
    {
        private string Name;
        private int currentSpeed = 0;

        public Tesla(string name)
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
            return currentSpeed.ToString() + " " + Name;
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}