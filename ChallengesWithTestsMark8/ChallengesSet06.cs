using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;
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
            int max = 0;
            int currentCount = 1;
            
            for(int i = 0; i < numbers.Count() - 1; i++) 
            {
                if (numbers[i] == numbers[i + 1]) 
                {
                    currentCount++;  
                }
                else {
                    if (currentCount > max) 
                    {
                        max = currentCount;
                        currentCount = 1;
                    }
                    currentCount = 1;
                    
                }
                
            }
            if (currentCount > max) max = currentCount;
            return max;
        }
            public double[] GetEveryNthElement(List<double> elements, int n) //DONE!
        {
            List<double> result = new List<double>();
            if (elements == null) { return result.ToArray(); }
            if (n <= 0) return result.ToArray();
            if (n==1) { return elements.ToArray(); }
            for (int i = n; i <= elements.Count; i+=n) 
            {
                result.Add(elements[i-1]);
            }
            return result.ToArray();    
        }
    }
}
