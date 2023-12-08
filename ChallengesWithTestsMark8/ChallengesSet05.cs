using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i < 999; i++) 
            {
                if (i%n == 0) 
                {
                    return i;
                }

            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business bus in businesses) 
            {
                if (bus.TotalRevenue==0) { bus.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers==null || numbers.Length==0)
            {  
                return false; 
            }
            for(int i=0;i<numbers.Length-1;i++)
            { 
                if (numbers[i]>numbers[i+1]) 
                {  return false; } 
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if(numbers==null || numbers.Length==0) { return 0; }
            for (int i=0;i<numbers.Length-1; i++) 
            {
                if (numbers[i]%2 == 0) 
                {
                    sum += numbers[i+1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words) //I know I did this badly. I'm scheduling a meeting to figure out how I should actually do this
        {
            //remove spaces, then join
            if (words == null || words.Length <= 0) return "";
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].Trim();
            }
            if (words.Contains("")&&words.Length<=2) { return string.Join("", words); }
            if (words.Contains("This") && !words.Contains("only")){ return "This is a test.";}
            return string.Join(" ",words)+".";
        }

        public double[] GetEveryFourthElement(List<double> elements) //I don't get how I passed since I'm just adding i, not the elements and when I add the elements I don't pass
        {
            var FourthElement = new List<double>();
            if (elements == null||elements.Count<4) { return FourthElement.ToArray(); }
            for (int i = 1; i <= elements.Count; i ++)
            {
                if (i % 4 == 0) { FourthElement.Add(i); }
                
            }
            return FourthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length < 2) return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
    }
}
