using System;
using System.Collections.Generic;

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
    class Program
    {
        static void wagecalculator(Employee employee)
        {
            if (employee.hours <= 40)
            {
                employee.wage = employee.hours * employee.payRate;
            }
            else
            {
                employee.wage = 40 * employee.payRate;
                double overtimeRate = employee.payRate * 1.5;
                int overtimeHours = employee.hours - 40;
                double overtimeWage = overtimeHours * overtimeRate;
                employee.wage = employee.wage + overtimeWage;
            }
        }
        static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>()
           {
               new Employee(){ name = "Employee 1", hours = 35, payRate = 7.50 },
               new Employee(){ name = "Employee 2", hours = 47, payRate = 8.20 },
               new Employee(){ name = "Employee 3", hours = 73, payRate = 10.00 }
           };
            foreach (Employee employee in employees)
            {
                wagecalculator(employee);
            }
            foreach (Employee employee in employees)
            {
                employee.Display();
            }
        }
    }
}
