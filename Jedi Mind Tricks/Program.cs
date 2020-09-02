using System;
using System.Collections.Generic;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Patrick", 25); // Adds me to the dictionary
            people.Add("Karin", 41); // Adds Karin to the dictionary
            
            Console.WriteLine("Patrick : {0}",people.ContainsKey("Patrick")); // Displays that i am in the dictionary with a true value
            foreach (KeyValuePair<string, int> folks in people)
            {
                Console.WriteLine("{0} : {1}", folks.Key, folks.Value);
            }

            Console.WriteLine("\n \n");
            
            Dictionary<string, bool> characters = new Dictionary<string, bool>() // a different Dictionary for the assigment
            
            {
            
                {"Luke", true }, // Makes Luke in the dictionary and gives him the value true
            
                {"Han", false }, // Makes Han in the dictionary and gives him the value false
            
                {"Chewbacca", false } // Makes Chewbacca in the dictionary and gives him the value false
            
            };
            
            characters.Remove("Han"); // Removes Han from the dictionary
            
            
            
            foreach (KeyValuePair<string, bool> OutHan in characters)
            
            {
            
                Console.WriteLine("{0} : {1}", OutHan.Key, OutHan.Value);
            
            }

        }
    }

}
