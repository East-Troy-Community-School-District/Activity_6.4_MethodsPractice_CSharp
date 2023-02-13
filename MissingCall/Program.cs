/*
 * Missing Call
 * 2/13/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingCall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add your code here!

        }

        /// <summary>
        /// Displays a rectangle made of asterisks with the given height 
        /// and width to the console.
        /// </summary>
        /// <param name="height">Represents the height of the rectangle.</param>
        /// <param name="width">Represents the width of the rectangle.</param>
        private static void DisplayRectangle(int height, int width)
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
