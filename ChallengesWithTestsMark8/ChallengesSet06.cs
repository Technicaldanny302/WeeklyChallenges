using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsword = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if(ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsword = lc.Contains(word);
            }

            if(ignoreCase == false)
            {
                containsword = words.Contains(word);
            }
            return containsword;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            if(num >= 0)
            {
                if(num % 2 != 0 & num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            if((num == 2) || (num == 3))
            {
                isPrime = true;
            }

            if(num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j] & i != j)
                    {
                        uIndex = false;
                    }
                }

                if(uIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(var i  = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for(var j = i + 1 ; j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            if(elements == null || n <= 0 ||  elements.Count == 0)
            {
                return nthElement.ToArray();
            }

            for(var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
    }
}
