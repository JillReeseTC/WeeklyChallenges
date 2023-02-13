using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            if (numbers.Length == 0 || numbers == null) return 0;

            for (var i = 0; i < numbers.Length; i++)
            //foreach (var i in numbers)
            {
                if (numbers[i] % 2 == 0)
                {
                     sum += numbers[i];
                    //sum += i;
                }
                else
                {
                     sum -= numbers[i];
                    //sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        { 
            int shortString;

            shortString = (str1.Length > str2.Length) ? str2.Length : str1.Length;
            shortString = (shortString > str3.Length) ? str3.Length : shortString;
            shortString = (shortString > str4.Length) ? str4.Length : shortString;

            return shortString;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallest = number1;
            smallest = (smallest > number2) ? number2 : smallest;
            smallest = (smallest > number3) ? number3 : smallest;
            smallest = (smallest > number4) ? number4 : smallest;

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var side1Yes = sideLength1 + sideLength2 > sideLength3;
            var side2Yes = sideLength1 + sideLength3 > sideLength2;
            var side3Yes = sideLength2 + sideLength3 > sideLength1;

            return side1Yes && side2Yes && side3Yes;
        }

        public bool IsStringANumber(string input)
        {
            var signed = -1;
            var j = -1;
            var oneDecimal = 'n';
            if (input == null || input == "") { return false; }

            //List of digits and . that could be in the number
            List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            if (input[0] == '+' || input[0] == '-')
            {
                signed = 1;
            }
            else
            {
                signed = 0;
            }

            for (j = signed; j < input.Length; j++)

            {
                if (char.IsDigit(input[j]) || input[j] == '.')
                {
                    continue;
                }
                else if (input[j] == '.')
                {
                    if (oneDecimal == 'y')
                    {
                        return false;
                    }
                    else
                    {
                        oneDecimal = 'y';
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullObj = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullObj++;
                }
            }
            return nullObj > objs.Length * .5;
        }

        public double AverageEvens(int[] numbers)
        {
            double answer = 0.0;
            //null check
            if (numbers == null || numbers.Length == 0) { return 0; }

            var evenOnes = numbers.Where(x => x % 2 == 0);
            
            //If there were no even values, don't divide by 0. Just return 0.
            if (evenOnes.Count() != 0)
            {
                answer = evenOnes.Average(x => x);
            }
            else
            {
                return 0;
            }

            return answer;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0) { return 1; }

            int answer = 1;

            for (var i = number; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
