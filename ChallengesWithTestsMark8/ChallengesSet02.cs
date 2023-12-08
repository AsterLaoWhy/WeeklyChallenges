using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) //When I did letters, it didn't pass but when I look at non-letters it does. Not sure why. 
        {
            string nonLetters = "0123456789`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?\u2222";
            foreach (char letter in nonLetters) 
            {
                if (c == letter) 
                    {
                    return false;
                    }
            }
            return true;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length%2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null||numbers.Count()==0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (int number in numbers) 
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                { sum += number; }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false; }
            foreach (int number in numbers)
            {
                 sum += number;
            }
            if (sum % 2 == 0)
            { return false; }
            return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var OddsBelowSum = 0;
            for (long i = number-1; i >= 0; i--)
            {
                if(i%2 !=0) { OddsBelowSum++; }
            }
            return OddsBelowSum;
        }
    }
}
