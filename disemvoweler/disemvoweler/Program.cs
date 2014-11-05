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
            disemvoweler("may the force be with you");
            Console.ReadKey();
        }
        static void disemvoweler(string input)
        {
            //sets containers for vowels
            //and the letters left over
            string vowel = "";
            string remainingLetters = "";
            //so long as we haven't reached the end of the sentence
            //the loop will keep going.
            for (int i = 0; i < input.Length; i++)
            {
                //this will be used later to remove spaces
                char[] charsToTrim = { ' ' };
                //this will take a letter from the sentence
                //lowercase it and make it a string to work with
                string letter = input[i].ToString().ToLower();
                // if the statement finds any of the included letters..
                if ("aeiou".Contains(letter))
                {
                    //it will add it to the vowel container
                    vowel = vowel + letter;
                }
                    //this is where the spaces get removed
                else if (letter == " ")
                {
                    input.Trim(charsToTrim);
                }
                    //everything that is left over will be put into
                    // the remainingLetters container
                else { remainingLetters = remainingLetters + letter; }




            }
            // Finally print out the results to the console
            Console.WriteLine("Original Sentence: " + input);
            Console.WriteLine("Disemvoweled Sentence: " + remainingLetters);
            Console.WriteLine("Vowels Removed: " + vowel);

        }
       
    }
}

