using System;

namespace AreaStudio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string radius_input;
            double radius;
            double area;
            double pi;                ;

            Console.WriteLine("What is the radius of your circle?");
            radius_input = Console.ReadLine();
            radius = double.Parse(radius_input);


            if (radius <= 0)
            {
                Console.WriteLine("Sorry, we can't calculate the area of a negative number or zero.");             
            }
            else
            {
                pi = 3.14;
                area = pi * radius * radius;

                Console.WriteLine("The area of your circle is: " + area);                
            }

            Console.ReadLine();

        }
    }
}
