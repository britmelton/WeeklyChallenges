using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n)+1) * n;
       
        }
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            for(int i = 1; i < numbers.Length;  i++)
            {
                if(numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;

            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i -1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            var containsAWord = false;

            foreach (var word in words)
            {
                if(!string.IsNullOrWhiteSpace(word))
                {
                    containsAWord = true;
                    break;
                }
            }
            if (!containsAWord)
            {
                return "";
            }
   
            
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    sentence += word.Trim() + " ";
                }
            }
         
            return sentence.TrimEnd() + ".";

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (elements == null)
            {
                var empty = new double[0];
                return empty;
            }

            for (int i = 3; i < elements.Count; i+=4)
            {              
                    result.Add(elements[i]);               
            }
        
            return result.ToArray();
            
                
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {

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

     
    

