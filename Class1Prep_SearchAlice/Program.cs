using System;

namespace Class1Prep_SearchAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string search_input;
            string quote;
            
            quote = "alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister " +
                "was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book,' thought alice 'without pictures or conversation?'";

            Console.WriteLine("What would you like to search for?");
            search_input = Console.ReadLine();

            if (quote.Contains(search_input.ToLower())) 
                           
            {
                Console.WriteLine("We found '" + search_input + "' in our text.");
            }
            else
            {
                Console.WriteLine("We cannot find '" + search_input + "' in our text.");
            }

            Console.ReadLine();


            













        }
    }
}
