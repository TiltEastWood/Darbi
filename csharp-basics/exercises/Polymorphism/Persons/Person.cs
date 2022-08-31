using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        protected int id;

        public Person(string firstName, string lastName, string address, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine("Persons first name is " + firstName);
            Console.WriteLine("Persons last name is " + lastName);
            Console.WriteLine("Persons adress is : " + address);
            Console.WriteLine("Persons id is: " + id);
        }
    } 
}
