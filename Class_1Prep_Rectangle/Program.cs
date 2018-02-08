using System;

namespace Class_1Prep_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string length_in;
            string width_in;
            double length;
            double width;
            double area;

            Console.WriteLine("What is the length of your rectangle? (Please provide numbers only.)");
            length_in = Console.ReadLine();
            length = double.Parse(length_in);

            Console.WriteLine("What is the width of your rectangle? (Please provide numbers only.)");
            width_in = Console.ReadLine();
            width = double.Parse(width_in);

            area = length * width;
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
