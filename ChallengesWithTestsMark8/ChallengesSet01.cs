using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        //PASSED///////////////////////////////////////////////////////////////////////////
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //PASSED///////////////////////////////////////////////////////////////////////
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        //PASSED//////////////////////////////////////////////////////////////////////
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        //PASSED//////////////////////////////////////////////////////////////////////
        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else { return number1; }
        }

        //PASSED//////////////////////////////////////////////////////////////////////
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        //PASSED//////////////////////////////////////////////////////////////////////
        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return "Hello!";
            }
        }

        //PASSED/////////////////////////////////////////////////////////////////////////
        public string GetHey()
        {
            return "HEY!";
        }
    }
}
