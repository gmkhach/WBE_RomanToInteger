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
                    Console.Write("Enter a roman numeral\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine("\nEquivalent Integer: " + RomanNumeralToInt(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int RomanNumeralToInt(string input)
        {
            int digits = 0;
            int tens = 0;
            int hundreds = 0;
            int thousands = 0;
            string rDigits = "";
            string rTens = "";
            string rHundreds = "";
            string[] romanDigits = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] romanTens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] romanHundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            for (int i = 0; i < input.Length; i++)
            {
                if (rDigits != "" && input[i] == 'X')
                {
                    rDigits += input[i];
                }
                else if (rTens != "" && input[i] == 'C' )
                {
                    rTens += input[i];
                }
                else if (rHundreds !="" && input[i] == 'M')
                {
                    rHundreds += input[i];
                }
                else if (input[i] == 'I' || input[i] == 'V')
                {
                    rDigits += input[i];
                }
                else if (input[i] == 'X' || input[i] == 'L')
                {
                    rTens += input[i];
                }
                else if (input[i] == 'C' || input[i] == 'D')
                {
                    rHundreds += input[i];
                }
            }
            if (romanDigits.Contains(rDigits))
            {
                digits = Array.IndexOf(romanDigits, rDigits);
            }
            if (romanTens.Contains(rTens))
            {
                tens = Array.IndexOf(romanTens, rTens);
            }
            if (romanHundreds.Contains(rHundreds))
            {
                hundreds = Array.IndexOf(romanHundreds, rHundreds);
            }
            return thousands * 1000 + hundreds * 100 + tens * 10 + digits ;
        }
    }
}
