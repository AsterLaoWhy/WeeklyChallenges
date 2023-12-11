using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            if (ignoreCase)
            {
                foreach (string word2 in words)
                {
                    if (word2 == null) return false;
                    if (word2.ToLower() == word) { return true; }
                }

            }
            return words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;

        }

        public int IndexOfLastUniqueLetter(string str) // I straight up don't understand why my previous solution didn't work
        {
            return str.IndexOf(
                       str.Distinct()
                               .Reverse()
                               .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                               .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int size = numbers.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + numbers[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
    }
}
