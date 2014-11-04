using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            disemvoweler("hello there");
            Console.ReadKey();
        }
        static void disemvoweler(string input)
        {
            string vowel = "";
            string other = "";

            for (int i = 0; i < input.Length; i++)
            {
                char[] charsToTrim = { ' ' };
                string letter = input[i].ToString().ToLower();
                if ("aeiou".Contains(letter))
                {
                    vowel = vowel + letter;
                }
                else if (letter == " ")
                {
                    input.Trim(charsToTrim);
                }

                else { other = other + letter; }




            }
            Console.WriteLine("Original Sentence: " + input);
            Console.WriteLine("Disemvoweled Sentence: " + other);
            Console.WriteLine("Vowels Removed: " + vowel);

        }
       
    }
}

