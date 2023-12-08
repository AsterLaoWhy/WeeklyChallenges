using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false) { return true; }
            }
            return false;
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false; }
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                { sum += number; }
            }
            if(sum%2 != 0) {  return true; }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
                {
                return true;
                }
            return false;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odd = new List<int>();
            for (int i = 1; i < 100; i+=2) 
            {
                odd.Add(i);
            }
            return odd.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words) //I realize there's a better way to do this after watching the solution video, but I couldn't 
                                                                     // figure it out as I was doing it
        {
            for (int i = 0;i<words.Length;i++)
                words[i] = words[i].ToUpper();
            return words;
        }
    }
}
