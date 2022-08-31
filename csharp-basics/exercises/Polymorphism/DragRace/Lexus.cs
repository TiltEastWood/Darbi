using System;

namespace DragRace
{
    public class Lexus : Boost
    {
        private string Name;
        private int currentSpeed = 0;

        public Lexus(string name)
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

        public void UseNitrousOxideEngine() 
        {
            currentSpeed++;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}