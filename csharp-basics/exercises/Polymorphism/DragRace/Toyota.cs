using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class Toyota : Boost
    {
        private string Name;
        private int currentSpeed = 0;

        public Toyota(string name)
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
        public void UseNitrousOxideEngine()
        {
            currentSpeed++;
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
