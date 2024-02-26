using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            var numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
            };

            /* Create a list of type int
             * Name the list "evens"
             */
            var evens = new List<int>();
            
            /* Create another list of type int
             * Name the list "odds"
             */
            
            var odds = new List<int>();

             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */

            foreach (int x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens.Add(x);
                } else
                {
                    odds.Add(x);
                }
            };

            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            
            foreach (int y in evens)
            {
                Console.WriteLine(y);
            };

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            foreach (int z in odds)
            {
                Console.WriteLine(z);
            };
        }
    }
}
