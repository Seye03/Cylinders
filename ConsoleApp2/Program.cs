using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is a simple program to accept inputs from the User
             i.e the Height and Radius of a cylinder and then compute
             the volume of surface area of a cylinder based on those
             values */

            //Print a greeting message
            Console.WriteLine("Welcome to the Cyllinder Calculator");
            
            // Declaring the variables for height and radius
            double height;
            double radius;
            
            // Obtaining the values from the user
            Console.WriteLine("Enter the height of the cylinder: ");
            string userHeight = Console.ReadLine();

            Console.WriteLine("Enter the radius of the cylinder: ");
            string userRadius = Console.ReadLine();

            // Assigning the values to the variables height and radius
            height = Convert.ToDouble(userHeight);
            radius = Convert.ToDouble(userRadius);

            // Calculating the volume of the cylinder
            double volume = (22 / 7) * (radius * radius) * height;
            Console.WriteLine($"The volume of the cylinder is {volume}");

            //Calculating the surface aarea of the cylinder
            double surfaceArea = (2 * (22 / 7)) * (radius + height);
            Console.WriteLine($"The surface area of the cylinder is {surfaceArea}");



        }
    }
}
