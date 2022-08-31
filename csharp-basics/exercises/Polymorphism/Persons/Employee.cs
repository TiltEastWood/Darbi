using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Employee : Person
    {
        private string jobTitle;

        public Employee(string jobTitle, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            this.jobTitle = jobTitle;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("This Employee works as " + jobTitle);
        }
    }
}
