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
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            var key = keyboard.KeyChar.ToString();
            userChoice = Convert.ToInt32(key);
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            decimal radius = 0;
            Console.WriteLine("What is the circle's radius? ");
            decimal.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;
            Console.WriteLine("Enter length? ");
            decimal.TryParse(Console.ReadLine(), out length);
            Console.WriteLine("Enter width? ");
            decimal.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal.TryParse(Console.ReadLine(), out ground);
            Console.WriteLine("Enter triangle's height? ");
            decimal.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
