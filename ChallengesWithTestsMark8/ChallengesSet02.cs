﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {  
                return 0; 
            }
            if (!numbers.Any())
            {
                return 0;
            }


            double min = numbers.Min();
            double max = numbers.Max();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
           
            
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers != null)
            
            foreach(int n in numbers)
            {
                sum += n;
            }
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           int count = 0;
           for (int i = 1; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }


          
            return count;
        }
    }
}
