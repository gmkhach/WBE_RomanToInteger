/**
 * Write a function that accepts a Roman numeral string, and returns the int value of that roman numeral.
 * Assume the string is correctly formatted, and the number will be 0 < n < 40
 * ie: "IV" should return 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a roman numeral between I and XLIX included\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    // Write an input validation block here.
                    Console.WriteLine("\nEquivalent Integer: " + RomanNumeralToInt(input));
                    Console.Write("\nPress Enter to try another string...");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
            } while (true);
        }

        static int RomanNumeralToInt(string input)
        {
            int number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'X':
                    case 'x':
                        number += 10;
                        break;
                    case 'L':
                    case 'l':
                        number = 40;
                        break;
                    case 'I':
                    case 'i':
                        number += 1;
                        break;
                    case 'V':
                    case 'v':
                        number += number != 0 && number % 10 > 0 ? 3 : 5;  
                        break;
                }
            }
            return number;
        }
    }
}
