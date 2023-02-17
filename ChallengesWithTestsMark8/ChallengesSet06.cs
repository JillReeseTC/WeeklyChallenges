using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {           
            //null check
            if (words == null) {  return false; }
            var answer = false;
            if (ignoreCase)
            {
                foreach (string piece in words)
                {
                    if (piece == null)
                    {
                        continue;
                    }
                    else
                    {
                        answer = piece.ToLower().Contains(word.ToLower());
                        if (answer) return answer;
                    }
                }
            }
            else
            {
                foreach (string piece in words)
                {
                    if (piece == null)
                    {
                        continue;
                    }
                    else
                    {
                        answer = piece.Contains(word);
                        if (answer) return answer;
                    }
                }
            }
            return answer;
        }

        public bool IsPrimeNumber(int num)
        {
            //The easy cases
            if (num <= 1) { return false; }
            if (num == 2) { return true; }
            if (num % 2 == 0) { return false;}

            //Test all of odd numbers above 3
            for (var i = 3; i <= num; i += 2) 
            {
                if (i == num)
                {
                        return true;
                }
                if (num % i == 0) 
                { 
                    return false; 
                }
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //null and empty string check
            if (str == null || str == "") return -1;

            //Build a list to hold the unique values in the string
            List<char> uniqueValues = new List<char>();
            char letter = ' ';
            char unique = ' ';
            Dictionary<char, int> distinctValues = new Dictionary<char, int>();
            for (var i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    letter = str[i];
                    distinctValues.Add(str[i], 1);
                }
                else if (letter == str[i] && i != 0)
                {
                    letter = str[i];
                    distinctValues[str[i]] += 1;
                }
                else
                {
                    if (distinctValues.ContainsKey(str[i]))
                    {
                        distinctValues[str[i]] += 1;
                    }
                    else
                    {
                        distinctValues.Add(str[i], 1);
                    }
                    letter = str[i];
                }
            }

            foreach (var item in distinctValues) 
            {
                if (item.Value == 1) 
                { 
                    uniqueValues.Add(item.Key); 
                }
            }
            
            //Now loop through the str from the back and the first unique is the last one
            for (var i = str.Length -1; i >=0; i--)
            {
                foreach (var thing in uniqueValues)
                {
                    if (str[i] == thing) return i;
                } 
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;
            var maxcount = 0;
            int num = -1;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    num = numbers[i];
                    count++;
                }
                else if (num == numbers[i] && i != 0)
                {
                    num = numbers[i];
                    count++;
                }
                else
                {
                    num = numbers[i];
                    if (count > maxcount)
                    {
                        maxcount = count;
                    }
                    count = 1;
                }
            }
            if (count > maxcount) { maxcount = count; }
            return maxcount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] nullCheck = new double[0];
            //null check
            if (elements == null || elements.Count == 0 || n < 1) return nullCheck;

            List<double> allNth = new List<double>();
            var counter = 1;
            foreach (var element in elements)
            {
                if (counter % n == 0)
                {
                    allNth.Add(element);
                }
                counter++;
            }

            return allNth.ToArray();
        }
    }
}
