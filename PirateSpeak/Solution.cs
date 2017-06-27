using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string AlphabetizeString(string input)
        {
            char[] a = input.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }

        public List<string> GetPossibleWords(string jumble, List<string> dictionary)
        {
            List<string> result = new List<string>();

            // Sort jumble string alphabetically
            string alphabetizedJumble = AlphabetizeString(jumble);

            // Alphabetize and compare each string in string[] dictionary
            foreach(var item in dictionary)
            {
                string alphabetized = AlphabetizeString(item);

                if (alphabetized == alphabetizedJumble)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}