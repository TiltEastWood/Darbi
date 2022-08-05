
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;
            finalPosition = CalculateFinalPosition(fallingTime, initialPosition, initialVelocity, gravity);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        static double CalculateFinalPosition(double fallingTime, double initialPosition, double initialVelocity, double gravity)
        {
            double result = 0;
            result = gravity * Math.Pow(fallingTime, 2) / 2  + initialVelocity * fallingTime + initialPosition;
            return result;
        }
    }
}
