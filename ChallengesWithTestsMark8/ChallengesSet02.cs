using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           var alphabet = "abcdefghijklmnopqrstuvwxyz";
           string d = c.ToString().ToLower();

            foreach (char letter in alphabet)
            {
                if (letter.ToString() == d)
                    
                   return true;             
            }
            return false;

            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)           
        {
            return vals.Length % 2 == 0; //? true : false;
            /* if (vals.Length % 2 == 0)
             {
             return true;
             }    

             return false;*/

            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
            
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            return false;

            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            else
            return numbers.Min() + numbers.Max();
            
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            return str1.Length < str2.Length ? str1.Length : str2.Length;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
           int sum = 0; 
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            
                if(numbers[i] % 2 == 0)
                
                    sum += numbers[i];
                    
            return sum;


            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {   int sum = 0;    
            if(numbers == null)
            
                return false;
            
            for (int i = 0; i < numbers.Count; i++)
               
                sum += numbers[i];
                    if (sum % 2 != 0)
                        return true;
                    if(sum % 2 == 0)
                        return false;
                
           return false;
                

            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long result = number / 2;
            if (result <= 0)
                return 0;
            else
            return result;
           
        
            
            
            //throw new NotImplementedException();
        }
    }
}
