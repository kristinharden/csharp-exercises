using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Class2PrepEvenNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> inputNumbers = new List<int>();
            int inputNumber;
            int newNumber;
            List<int> evenNumbers = new List<int>();
            
            Console.WriteLine("Enter a number to add to the list or hit ENTER again to finish:");
                        
            do
            {
                inputNumber = int.Parse(Console.ReadLine());
                inputNumbers.Add(inputNumber);
            }
            while (inputNumber != null);
            */

            List<int> inputNumbers = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            List<int> evenNumbers = new List<int>();

            foreach (int number in inputNumbers)
            {
                
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
                        
            Console.ReadLine();
        }
    }
}
