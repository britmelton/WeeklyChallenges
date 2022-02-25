using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var n = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    n += number;
                }
                if (number % 2 != 0)
                {
                    n -= number;
                }
            }
            return n;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strLengths = new string[] { str1, str2, str3, str4 };
            int shortestString = strLengths.Min(y => y.Length);
            return shortestString;  
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
             int [] numbers = new int[] {number1, number2, number3, number4};
            int smallestNumber = numbers.Min();
            return smallestNumber;    
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        { 
            biz.Name = "TrueCoders";
           
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
           var isNumber = double.TryParse(input, out double num);
           return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            int count = objs.Count(x => x == null);
            var count2 = objs.Count(x => x != null);
            if (count > count2)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = new List<double>();
            if (numbers == null)
                return 0;
         
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);  
                }
            }
       
            if (evens.Count == 0)
                return 0;

            return evens.Average();
        }

        public int Factorial(int number)
        {
           if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
