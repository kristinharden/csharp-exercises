using System;

namespace Class1Prep_MPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string miles_in;
            string gas_in;
            double miles;
            double gas;
            double mpg;

            Console.WriteLine("How many miles have you driven? (Please provide numbers only.)");
            miles_in = Console.ReadLine();
            miles = double.Parse(miles_in);

            Console.WriteLine("How many gallons of gas have you used? (Please provide numbers only.)");
            gas_in = Console.ReadLine();
            gas = double.Parse(gas_in);

            mpg = miles / gas;
            Console.WriteLine("Your average miles per gallon is: " + mpg);
            Console.ReadLine();

        }
    }
}
