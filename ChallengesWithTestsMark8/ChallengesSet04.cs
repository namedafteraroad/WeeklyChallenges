using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else { sum -= num; }
            }return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string shortString = str1;

            if (str2.Length < shortString.Length)
            {
                shortString = str2;
            }

            if (str3.Length < shortString.Length) 
            { 
                shortString = str3; 
            }

            if (str4.Length < shortString.Length) 
            { 
                shortString = str4; 
            }
            return shortString.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallNum = number1;
            if (number2 < smallNum) { smallNum = number2; }
            if (number3 < smallNum) { smallNum = number3; }
            if (number4 < smallNum) { smallNum = number4; }
            return smallNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Business business = new Business();
            business.Name = biz.Name;
            biz.Name = "TrueCoders";

            
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 +sideLength3>sideLength1) { return true; }
            else { return false; }
        }

        public bool IsStringANumber(string input)
        {
            bool stringNum = double.TryParse(input, out double number);
            return stringNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int notNull = 0;

            foreach (object obj in objs)
            {
                if (obj == null) isNull++;
                else notNull++;
            }return isNull > notNull;
        }

        public double AverageEvens(int[] numbers)
        {
            
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            
            var evens = numbers.Where(num => num % 2 == 0);
            double averageEven = evens.Any() ? evens.Average() : 0;
            return averageEven;

            




        }

        public int Factorial(int number)
        {
            if(number < 0) throw new ArgumentOutOfRangeException("number");
            if (number == 0) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
