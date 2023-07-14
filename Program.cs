using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList and add elements to it
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements: " + fruits.Count);
            Console.WriteLine();

            // Check if the ArrayList contains the element "date"
            bool containsDate = fruits.Contains("date");
            Console.WriteLine("Does the ArrayList contain 'date'? " + containsDate);
            Console.WriteLine();

            // Insert the element "fig" at the second position in the ArrayList
            fruits.Insert(1, "fig");

            // Remove the element "banana" from the ArrayList
            fruits.Remove("banana");

            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
