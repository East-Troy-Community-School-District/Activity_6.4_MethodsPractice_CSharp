/*
 * Word Methods
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, letter;
            Console.Write("Enter a word >> ");
            word = Console.ReadLine();
            Console.Write("Enter a letter >> ");
            letter = Console.ReadLine();

            Console.WriteLine("The first letter of the word \"" 
                + word + "\" is \"" + FirstLetter(word) + "\"");
            Console.WriteLine("The last letter of the word \""
                + word + "\" is \"" + LastLetter(word) + "\"");

            if (ContainsLetter(word, letter))
            {
                Console.WriteLine("The word \"" + word 
                    + "\" does contain \"" + letter + "\"");
            }
            else
            {
                Console.WriteLine("The word \"" + word
                    + "\" does not contain \"" + letter + "\"");
            }
        }

        /// <summary>
        /// Returns the first letter of the word.
        /// </summary>
        /// <param name="word">A word as a string.</param>
        /// <returns>The first letter of the word as a string.</returns>
        public static string FirstLetter(string word)
        {
            return word.Substring(0, 1);
        }

        /// <summary>
        /// Returns the last letter of the word.
        /// </summary>
        /// <param name="word">A word as a string.</param>
        /// <returns>The last letter of the word as a string.</returns>
        public static string LastLetter(string word)
        {
            return word.Substring(word.Length - 1, 1);
        }

        /// <summary>
        /// Determines whether a letter is inside a word.
        /// </summary>
        /// <param name="word">The word to search.</param>
        /// <param name="letter">The letter to search for.</param>
        /// <returns>Returns true if the letter is in the word; otherwise, false.</returns>
        public static bool ContainsLetter(string word, string letter)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1) == letter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
