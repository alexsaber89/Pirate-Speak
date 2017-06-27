using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using CodingChallenge.PirateSpeak;

namespace UnitTestProject1
{
    [TestClass]
    public class GetPossibleWordsTests
    {
        [TestMethod]
        public void should_return_multiple_correct_words()
        {
            string jumble = "ortsp";

            List<string> possibleWords = new List<string>
            {
                "sport",
                "parrot",
                "ports",
                "matey"
            };

            List<string> expected = new List<string>
            {
                "sport",
                "ports"
            };

            List<string> actual = new Solution().GetPossibleWords(jumble, possibleWords);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void should_return_one_correct_word_if_only_one_correct_word_provided()
        {
            string jumble = "trisf";

            List<string> possibleWords = new List<string>
            {
                "first"
            };

            List<string> expected = new List<string>
            {
                "first"
            };

            List<string> actual = new Solution().GetPossibleWords(jumble, possibleWords);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void should_return_empty_list_if_no_possible_correct_word()
        {
            string jumble = "oob";

            List<string> possibleWords = new List<string>
            {
                "bob",
                "baobob"
            };

            List<string> expected = new List<string>
            {
            };

            List<string> actual = new Solution().GetPossibleWords(jumble, possibleWords);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void should_only_return_correct_word()
        {
            string jumble = "ainstuomn";

            List<string> possibleWords = new List<string>
            {
                "mountains",
                "hills",
                "mesa"
            };

            List<string> expected = new List<string>
            {
                "mountains"
            };

            List<string> actual = new Solution().GetPossibleWords(jumble, possibleWords);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void should_return_any_correct_words_regardless_of_letter_order()
        {
            string jumble = "oopl";

            List<string> possibleWords = new List<string>
            {
                "donkey",
                "pool",
                "horse",
                "loop"
            };

            List<string> expected = new List<string>
            {
                "pool",
                "loop"
            };

            List<string> actual = new Solution().GetPossibleWords(jumble, possibleWords);

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
