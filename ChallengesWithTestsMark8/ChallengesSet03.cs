using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) //WORKS
        {
            for (int i = 0; i < vals.Length; i++)
            {
                
                if (!vals[i])
                {
                    return true;
            
                }
                           
            }
            return false;


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) //WORKS
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
                
            }
            return (sum & 1) == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password) //WORKS
        {
            if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) 
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val) //WORKS
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val) //WORKS
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor) //8/9 //WORKS
        {
            if(divisor == 0) { return 0; }//was missing, have to remember nulls and 0s
            else return dividend / divisor;

            //decimal test = dividend / divisor;

            //return Decimal.Divide(dividend, divisor);
            //**********************8/9 working 

            //return test;
        }

        public int LastMinusFirst(int[] nums) //WORKS
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddList = new List<int>();
            
            for (int i = 0; i < 100; i++)
            {
               if(i % 2 != 0)
                {
                    oddList.Add(i);
                }

            }
            return oddList.ToArray();



            //throw new NotImplementedException();
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
