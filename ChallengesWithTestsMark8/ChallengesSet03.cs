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
                if(val == false)
                    return true;
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {return false;}
            int sum = numbers.Sum();
            if (sum % 2 !=0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && 
                password.Any(char.IsLower) && 
                password.Any(char.IsDigit))
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
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
                decimal sum = dividend / divisor;
            return sum;
           
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums[nums.Length - 1];
            var first = nums[0];
            var sum = last - first;
            return sum;

        }

        public int[] GetOddsBelow100()
        {
            int [] odds = new int[50];
            var n = 1;
            for (int i = 0; i < odds.Length; i++)
            {
                odds[i] = n;
                n += 2;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
          for (int i = 0; i < words.Length; i++)
          {
                words[i] = words[i].ToUpper();

          }
        }
    }
}
