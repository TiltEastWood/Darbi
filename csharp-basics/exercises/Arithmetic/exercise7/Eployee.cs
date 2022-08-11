using System;

namespace exercise7
{
    public class Employee
    {
        public int hours;
        public double payRate;
        public string name;
        public double wage;
        public void Display()
        {
            Console.WriteLine($"Employee Name {name} Pay Rate {payRate} Wage {wage}");
        }
    }
}
