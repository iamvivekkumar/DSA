using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.

    //Given a string s, return true if it is a palindrome, or false otherwise.



    //Example 1:

    //Input: s = "A man, a plan, a canal: Panama"
    //Output: true
    //Explanation: "amanaplanacanalpanama" is a palindrome.
    //Example 2:

    //Input: s = "race a car"
    //Output: false
    //Explanation: "raceacar" is not a palindrome.
    //Example 3:

    //Input: s = " "
    //Output: true
    //Explanation: s is an empty string "" after removing non-alphanumeric characters.
    //Since an empty string reads the same forward and backward, it is a palindrome.
    public class ValidPalindrome
    {
        //Input: s = "race a car"
        //Output: false
        public static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            string str = s.ToLower();
            while (i < j)
            {
                if (!char.IsLetterOrDigit(str[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(str[j]))
                {
                    j--;
                    continue;
                }
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;j--;
            }

            return true;
        }
    }
}
