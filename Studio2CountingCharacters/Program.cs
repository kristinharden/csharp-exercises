using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charactersDict = new Dictionary<char, int>();
                        
            Console.WriteLine("Hi! Let's count characters. What is your phrase?");
            string input = Console.ReadLine();

            foreach (char character in input)
            {
                if (charactersDict.ContainsKey(character))
                {
                    int number = charactersDict[character];
                    //int increaseNumber = ++number;
                    charactersDict[character] = ++number; //increaseNumber;
                }
                else
                {
                    int number = 0;
                    charactersDict.Add(character, number);
                }
            }
            foreach (KeyValuePair<char, int> kvp in charactersDict)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
        }

    }
}










/*            {
                bool there = charactersDict.ContainsKey(character);
                if (there = false)
                {
                    int number = 0;
                    charactersDict.Add(character, number);
                    
                }
                else
                {
                    int number = charactersDict[character];
                    charactersDict[character] = number++;
                }               
            }
            foreach (KeyValuePair<char, int> kvp in charactersDict)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
        }

    }
}*/
