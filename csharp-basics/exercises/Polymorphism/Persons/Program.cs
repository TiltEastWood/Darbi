using System;
using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(3.9, "Markuss", "Sloka", "Jaunsudrabina 3", 1);
            Employee employee = new Employee("Mechanic", "Gints", "Kuznecovs", "Tauku iela 1", 2);

            student.Display();
            employee.Display();
        }
    }
}