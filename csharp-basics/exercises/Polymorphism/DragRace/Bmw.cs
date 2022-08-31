using System;
using System.Xml.Linq;

namespace DragRace
{
    public class Bmw : Car
    {
        string Name { get; set; }
        private int currentSpeed = 0;

        public Bmw(string name)
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
            return currentSpeed.ToString()+ " " +Name;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}