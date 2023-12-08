using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers) 
            { if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> lengths = new List<int>();
            lengths.Add(str1.Length);
            lengths.Add(str2.Length);
            lengths.Add(str3.Length);
            lengths.Add(str4.Length);
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> smallNumber = new List<int>();
            smallNumber.Add(number1);
            smallNumber.Add(number2);
            smallNumber.Add(number3);
            smallNumber.Add(number4);
            return smallNumber.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name="TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1) { return true; }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double number1 = 0;
            bool canConvert = double.TryParse(input, out number1);
            if (canConvert) {  return true; }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs.Count(s => s != null)< objs.Count(s => s == null)) {  return true; }
            return false;

            
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double counter = 0;
            if (numbers == null) { return 0; }
            foreach(int number in numbers) 
            {
                if (number%2 == 0) { sum += number;counter++; }
            }
            if (sum==0) {  return 0; }
            return sum / counter;
        }

        public int Factorial(int number)
        {
            if (number<0) { throw new ArgumentOutOfRangeException(); }
            int factorial = 1;
            for(int i=number;i>0;i--) 
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
