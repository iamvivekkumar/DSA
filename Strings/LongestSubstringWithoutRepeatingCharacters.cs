using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        //Longest Substring Without Repeating Characters
        //Given a string s, find the length of the longest substring without repeating characters.

        //Example 1:
        //Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.

        //Example 2:
        //Input: s = "bbbbb"
        //Output: 1
        //Explanation: The answer is "b", with the length of 1.

        //Example 3:
        //Input: s = "pwwkew"
        //Output: 3
        //Explanation: The answer is "wke", with the length of 3.
        //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        public int LengthOfLongestSubstring(string s)
        {
            //Input: s = "pwwkew"
            //Output: 3
            //Explanation: The answer is "wke", with the length of 3.

            Dictionary<char, int> dict = new Dictionary<char, int>();
            int longestSubStringCount = 0;
            int left = 0;
            int right = 0;

            while (right < s.Length)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left = Math.Max(left, dict[s[right]]);
                }

                dict[s[right]] = right + 1;
                longestSubStringCount = Math.Max(longestSubStringCount, (right - left) + 1);
                right++;
            }

            return longestSubStringCount;

        }
    }
}
