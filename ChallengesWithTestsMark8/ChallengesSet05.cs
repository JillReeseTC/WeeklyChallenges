using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0) { return n; }
            do
            {
               startNumber++;
               
            } while (!(startNumber % n == 0));
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
           foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }

            var start = numbers[0];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (start <= numbers[i])
                {
                    start = numbers[i];
                }
                else
                {
                    return false;
                }
            }
            return true;
            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }

            List<int> followers = new List<int>();
            var itsEven = -1;
            for (var i = 0; i < numbers.Length; i++)
            {          
                if (itsEven == i - 1 && i != 0) 
                {
                    followers.Add(numbers[i]);
                }
                if (numbers[i] % 2 == 0)
                {
                    itsEven = i;
                }
            }
            return followers.Sum(x => x);
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }

            var sentence = "";
            for (var i = 0; i < words.Length;i++)
            {
                var set = false;
              
                if (words[i] == "Hello" && i == 0)
                {
                    sentence = "Hello, ";
                    set = true;
                }
                //Get rid of white space
                if (words[i].Contains(" "))
                {
                    char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                    var myString = words[i];
                    var newString = "";
                    for (var q = 0; q < words[i].Length; q++)
                    {
                        for (var lett = 0; lett < letters.Length; lett++)
                        {
                            if (myString[q] == letters[lett])
                            {
                                newString = newString + myString[q];
                            }
                        }
                    }
                    //var myString = string.Concat(words[i].Where(c => !Char.IsWhiteSpace(c)));
                    if (newString != "" && i != words.Length - 1)
                    { 
                        sentence = sentence + myString + " ";
                        set = true;
                    }  
                    if (newString == "")
                    {
                        set = true;
                    }
                }

                //Add a space after the word unless it's the last word or the sentence is blank.
                if (words[i] != "" && set == false && i == words.Length - 1)
                {
                    sentence = sentence + words[i];
                }
                else
                {
                    sentence = sentence + words[i] + " ";
                }
                // End the sentence with a period, if there is a sentence.
                if (i == words.Length - 1 && sentence != "")
                {
                    sentence = sentence + ".";
                }
            }
            
            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] result = new double[0];
            if (elements == null || elements.Count == 0 || elements.Count < 4)
            {
                return result;
            }

            List<double> result2 = new List<double>();

            for (var i = 3; i < elements.Count; i += 4)
            {
                result2.Add(elements[i]);
            }
            return result2.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0 || nums.Length < 2) { return false; }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (!(i == j))
                    {  
                        if (targetNumber == nums[i] + nums[j]) { return true; }
                    }
                }
            }
            return false;
        }
    }
}