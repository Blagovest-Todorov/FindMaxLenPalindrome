using System;

namespace PalindromeLongest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write an sequence of letters whithout intervals inside");
            string letters = Console.ReadLine();

            int maxLen = 0;
            // check all single letter central points
            for (int i = 1; i < letters.Length; i++)
            {
                maxLen = Math.Max(maxLen, PalindromeLen(letters, i, i));
            }
            //check all double letter central points
            for (int c = 1; c < letters.Length - 1; c++)
            {
                maxLen = Math.Max(maxLen, PalindromeLen(letters, c, c + 1));
            }

            Console.WriteLine(maxLen);
        }

        static int PalindromeLen(string letters , int leftIdx, int rightIdx) 
        {
            
            while (leftIdx > 0 && rightIdx < letters.Length
                && letters[leftIdx] == letters[rightIdx])
            {
                leftIdx--;
                rightIdx++;
            }

            return rightIdx - leftIdx - 1; //this is the length of polidrome
        }
    }

}
