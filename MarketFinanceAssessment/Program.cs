using System;
using System.Linq;

namespace MarketFinanceAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = new string[] { "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z" };
            var result1 = ArrayChallenge1(input1);


            var input2 = new int[] { 5, 6, 1, 2, 8, 9, 7 };
            var result2 = ArrayChallenge2(input2);

            Console.WriteLine(result2);

        }

        static int ArrayChallenge1(string[] strArray)
        {
            var teststring = strArray[0];

            var wordList = strArray[1].Split(',').ToList().OrderByDescending(a => a.Length);

            foreach (var word in wordList)
            {
                var teststringChars = teststring.ToList();
                var wordChars = word.ToList();

                //first we test each character of each word to make sure it exsist in the test string
                var testPasses = true;
                foreach (var character in wordChars)
                {
                    if (teststringChars.Contains(character))
                    {
                        //to handle duplicates we remove the character from the teststring
                        teststringChars.Remove(character);
                    }
                    else
                    {
                        //if a character is not in the test string then we fail the test
                        testPasses = false;
                        break;
                    }
                }

                if (testPasses)
                {
                    //if the test passes we return the count of the remaining teststrings
                    return teststringChars.Count();
                }


            }

            return -1;
        }


        public static int ArrayChallenge2(int[] arr)
        {
            var longestConsecutiveSubsequence = 0;

            var currentConsecutiveSubsequence = 0;
            for (int i = arr.Min(); i <= arr.Max(); i++)
            {
                if (arr.Contains(i))
                {
                    currentConsecutiveSubsequence++;

                    if (currentConsecutiveSubsequence > longestConsecutiveSubsequence)
                    {
                        longestConsecutiveSubsequence = currentConsecutiveSubsequence;
                    }
                }
                else
                {
                    currentConsecutiveSubsequence = 0;
                }
            }

            // code goes here  
            return longestConsecutiveSubsequence;

        }
    }
}
