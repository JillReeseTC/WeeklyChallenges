using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return letters.Contains(c);
        }

        public bool CharacterIsNotALetter(char c)
        {
            //char[] letters = new char[52];
            char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var answer = false;

            for (var i = 0; i < letters.Length; i++)
            {
                if (c == letters[i])
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                };
            }
            return answer;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = 0;
            for (var i = 0; i < vals.Length; i++)
            {
                count++;
            }
            return (count % 2 == 0) ;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return !(num % 2 == 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0.0;

            var min = 0.0;
            var max = 0.0;
            var counter = 0;
            foreach (var item in numbers)
            {
                if (counter == 0)
                {
                    min = item;
                    max = item;
                }
                if (item < min) { min = item; }
                if (item > max) { max = item; }
                counter++;
            }
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var strLength = (str1.Length < str2.Length) ? str1.Length : str2.Length ;
            return strLength;
        }

        public int Sum(int[] numbers)
        {
            var answer = 0;
            if ((numbers == null) || (numbers.Length == 0)) return answer;

            for (var i = 0; i < numbers.Length; i++) 
            {
                answer += numbers[i];
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            var answer = 0;
            if ((numbers == null) || (numbers.Length == 0)) 
            {
                return answer;
            }
            List<int> evens = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }

            foreach (var item in evens)
            {
                answer += item;
            }

            if (answer % 2 == 0)
            {
                return answer;
            }
            else
            {
                return 0;
            }
                  
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var answer = 0;
            if ((numbers == null) || (numbers.Count == 0)) return false;

            foreach (var item in numbers)
            {
                answer += item;
            }
            return !(answer % 2 == 0) ; 
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long answer = 0;
            if (number < 0)
            {
                answer = 0;
                return answer;
            }

            for (var i = 1; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
