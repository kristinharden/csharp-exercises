using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            

            Console.WriteLine("Hi! What's your name?");
            input = Console.ReadLine();
            

            Console.WriteLine("Hello " + input + "! It is nice to meet you!");
            Console.ReadLine();

        }
    }
}
