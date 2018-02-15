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
            List<string> words = new List<string> { "Horn", "went", "beep", "engine", "purred", "friendliest", "sound", "you", "ever", "heard",
            "Little", "blue", "truck", "went", "down", "the", "road", "beep", "said", "blue", "to", "a", "big", "green", "toad", "croak"};
            int wordLength;
                        
            foreach (string word in words)
            {
                wordLength = word.Length;

                if (wordLength == 5);
                {
                    Console.WriteLine(word);
                    Console.WriteLine(wordLength);
                }
            }

            Console.ReadLine();
        }
    }
}