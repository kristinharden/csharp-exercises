using System;

namespace TestingJunk
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello World";
            foreach (char c in msg)
            {
                Console.WriteLine(c);
                Console.ReadLine();

            }
        }
    }
}
