using System;
using System.Linq;
using System.Collections.Generic;

//using System.Collections.Generic.IEnumerable;

/* Challenge - Even Numbers
 * 
 *  RULES: 
 *  1. NO FOREACH
 *  2. NO DO/WHILE
 *  3. NO DO
 *  4. NO WHILE
 *  5. Must be able to handle exceptions
 *  6. Must be able to pass all tests.
 *  7. List must return in order from least to greatest.
 * 
 * Task - 
 *  1. Write a method named evenNums() 
 *     with the parameter <Integer :: max >
 *  
 *  2. The Method must Return a collection of 
 *      integers containing all even numbers
 *      from 0 to <Integer :: max >
 *  
 *  Workflow:
 *  1. Ask the user for their Input.
 *  
 *  2. Throw the Input into the function as an argument.
 *  
 *  3. Iterate all numbers (from 0 to max).
 *  
 *  4. Check if each number is even.
 *  
 *  5. Push all even numbers into a Collection and return said Collection.
 *  
 * 
 * Extra:
 *  1. Create a function with no return 
 *      called eachEven
 *      
 *  2. Have it display each Index of the 
 *      collection using only a For Loop. 
 *      Print out each result to the Terminal.
 *      
 *  Extra Workflow:
 *  6. Write a new function
 *  
 *  7. Iterate Across the Collection and print each value.
*/


namespace EvenNums
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            input = getInput(input);
            List<int> numList = evenNums(input);

            for (var i = 0; i < numList.Count; i++)
            {
                Console.WriteLine($"Collection Index at {i} is: {numList[i]}");
            }
        }

        // Return Method is a Collection of Integers
        static List<int> evenNums(int max)
        {
            List<int> evenCollection = new List<int>();

            // Iterate across the Collection and add
            for (int i = 0; max >i; max--)
            {
                if(max % 2 == 0)
                {
                    evenCollection.Add(max);
                }
            }

            return evenCollection;
        }


        // Grabs User Input
        static int getInput(int userInput)
        {
            Console.WriteLine("Please Input a Number.");

            // Type Check for TypeOf int no exception handling.
            while (Int32.TryParse(Console.ReadLine(), out userInput) && userInput < 1)
            {
                Console.WriteLine("Please Input a Proper Number Greater than 0.");
            }

            // Always returns an int.
            return userInput;
        }
    }
}
