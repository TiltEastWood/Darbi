using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Student : Person
    {
        private double gpa;

        public Student(double gpa, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            this.gpa = gpa;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("This student has a gpa of: " + gpa);
        }
    }
}
