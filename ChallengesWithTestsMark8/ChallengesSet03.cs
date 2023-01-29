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
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            char value = val => IList<char>.First<char>;
            char answer = value;

            return answer;
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();

            for (var i = 1 ; i <= 100; i++)
            {
                if (!(i % 2 == 0))
                {
                    nums.Add(i);
                }
            }
            int count = nums.Count;

            int[] myOdds = new int[count];

            foreach (var item in nums)
            {
                for (var j = 0; j < count; j++)
                {
                    myOdds[j] = item;
                }
            }
            return myOdds;
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
