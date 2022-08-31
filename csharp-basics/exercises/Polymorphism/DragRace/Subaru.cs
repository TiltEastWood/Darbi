using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class Subaru : Car
    {
        private string Name;
        private int currentSpeed = 0;

        public Subaru(string name)
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
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
