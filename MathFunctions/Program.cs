/*
 * Math Functions
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Power(3, 2));
            Console.WriteLine();

            int userNumber;
            long result;
            Console.Write("Enter a number >> ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            result = Factorial(userNumber);
            Console.WriteLine(userNumber + "! = " + result);
        }

        /// <summary>
        /// The Power method calculates x to the power of n.
        /// </summary>
        /// <param name="x">Represents the base.</param>
        /// <param name="n">Represents the exponent or power.</param>
        /// <returns>x to the power of n.</returns>
        private static double Power(double x, int n)
        {
            double power = 1;
            for(int i = 0; i < n; i++)
            {
                power *= x;
            }
            return power;
        }

        /// <summary>
        /// The Factorial method calculates the product of all the positive
        /// integers less than or equal to n.
        /// </summary>
        /// <param name="n">Represents the the base, must be a positive integer.</param>
        /// <returns>The factorial of n (i.e., n!).</returns>
        private static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
