using System;
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
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
