using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            int choice = GetMenu();
            switch (choice) 
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    return;
            }
            Console.ReadKey();
        }

        public static int GetMenu()
        {

            int userChoice;
            

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            var key = keyboard.KeyChar.ToString();
            userChoice = Convert.ToInt32(key);

            // validate input

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            decimal radius = 0;
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            decimal.TryParse(Console.ReadLine(), out radius);
            //todo


            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user
            
            

            // Get length
            Console.WriteLine("Enter length? ");
            decimal.TryParse(Console.ReadLine(), out length);
            //todo

            // Get width
            Console.WriteLine("Enter width? ");
            decimal.TryParse(Console.ReadLine(), out width);
            //todo

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user                       

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal.TryParse(Console.ReadLine(), out ground);
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            decimal.TryParse(Console.ReadLine(), out height);
            //todo
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
