using System;
using System.Linq;
using System.Collections.Generic;

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
