using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var output =startNumber % n;
            return startNumber + (n - output);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue <= 0)
                {
                    bus.Name = "CLOSED";
                    
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
           if(numbers == null || numbers.Length == 0) {  return false; }
            
            var arrTest = numbers.Length - 1;
            if (arrTest < 1) { return true; }
            var i = 0;
            while (i < arrTest && numbers[i] <= numbers[i + 1]) { i++; }
            return i == arrTest;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                return 0;

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return string.Empty;
            words = Array.FindAll(words, s => !string.IsNullOrWhiteSpace(s));
            if (words == null || words.Length == 0) return string.Empty;
            for (int i = 0; i < words.Length; i++)
            {

                words[i] = words[i].Trim();
            }

            string sentence = string.Join(" ", words);
            sentence += ".";

            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (null == elements ) return new double[0] ;
            for (int i = 3; i < elements.Count; i+=4)
            {
                result.Add(elements[i]);
            }return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            Array.Sort(nums);

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == targetNumber) 
                {
                    return true;

                }
                else if (sum < targetNumber) { left++;}
                else { right--; }
            }return false;
        }
    }
}
