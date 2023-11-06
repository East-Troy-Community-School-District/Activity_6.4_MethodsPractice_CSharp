/*
 * Average Method
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an array to hold the appropriate amount of numbers
            int length;
            Console.Write("How many numbers would you like to enter >> ");
            length = Convert.ToInt32(Console.ReadLine());
            int[] userNumbers = new int[length];

            // Populates the array
            for(int i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Enter a number >> ");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculates the average of the array
            Console.WriteLine("The average of the numbers is " + CalculateAverage(userNumbers));
        }

        /// <summary>
        /// Calculates the average of the numbers in the passed array.
        /// </summary>
        /// <param name="numbers">Represents a list of numbers.</param>
        /// <returns>The average of the numbers.</returns>
        private static double CalculateAverage(int[] numbers)
        {
            double total = 0, average;
            foreach(int number in numbers)
            {
                total += number;
            }
            average = total / numbers.Length;
            return average;
        }
    }
}
