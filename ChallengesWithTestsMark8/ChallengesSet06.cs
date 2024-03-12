using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            if (ignoreCase)
            {return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));}

            else{return words.Contains(word);}
        }
        public bool IsPrimeNumber(int num)
        {
            if (num <= 0) return false;
            if (num == 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            
            
            var isPrime = (int)Math.Sqrt(num);
            for(int i = 3; i <= isPrime; i+=2)
                if (num % i==0)return false;
            
            return true;



        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar  = str[i];
                bool isUnique = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if(i != j && str[j] == currentChar) { isUnique = false; break; }
                }
                if (isUnique) return i;
            }return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);



        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || elements.Count == 0 || n <=0)
            {
                return new double[0];
            }

            
            List<double> numbers = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    numbers.Add(elements[i]);
                }
            }

            return numbers.ToArray();
        }
    }
}
