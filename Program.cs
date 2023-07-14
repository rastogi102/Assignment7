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

            // Prompt the user to enter an element to check if it exists in the ArrayList
            Console.Write("Enter an element to check if it exists in the ArrayList: ");
            string elementToCheck = Console.ReadLine();

            // Check if the ArrayList contains the user-entered element
            bool containsElement = fruits.Contains(elementToCheck);
            Console.WriteLine("Does the ArrayList contain '{0}'? {1}", elementToCheck, containsElement);
            Console.WriteLine();

            // Prompt the user to enter an element and the position to insert it in the ArrayList
            Console.Write("Enter an element to insert in the ArrayList: ");
            string elementToInsert = Console.ReadLine();
            Console.Write("Enter the position to insert the element (0 - {0}): ", fruits.Count);
            int positionToInsert = int.Parse(Console.ReadLine());

            // Insert the user-entered element at the specified position in the ArrayList
            fruits.Insert(positionToInsert, elementToInsert);

            // Prompt the user to enter an element to remove from the ArrayList
            Console.Write("Enter an element to remove from the ArrayList: ");
            string elementToRemove = Console.ReadLine();

            // Remove the user-entered element from the ArrayList
            fruits.Remove(elementToRemove);

            // Print all the elements in the ArrayList
            Console.WriteLine("\nElements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
