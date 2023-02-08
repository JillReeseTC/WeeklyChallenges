using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           if (vals == null ) return false;

            var answer = false;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false) { answer = true; }
            }
            return answer;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var answer = 0;
            if (numbers == null) return false;
           
            List<int> odds = new List<int>();

            foreach (var item in numbers)
            {
                if (!(item % 2 == 0))
                {
                    odds.Add(item);
                }
            }

            foreach (var item2 in odds)
            {
                answer += item2;
            }

            if (!(answer % 2 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            char answer = val[0];
            return answer;
        }

        public char GetLastLetterOfString(string val)
        {
            var lastOne = val.Last();
            return lastOne;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal answer = 0.0m;

            if (divisor != 0)
            {
                answer = dividend / divisor;
            }
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            var answer = nums.Last() - nums.First();
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();

            for (var i = 0 ; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    nums.Add(i);
                }
            }

            var ints = nums.ToArray();
            return ints;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
