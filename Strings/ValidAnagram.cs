using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    //Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.



    //Example 1:

    //Input: s = "anagram", t = "nagaram"
    //Output: true
    //Example 2:

    //Input: s = "rat", t = "car"
    //Output: false
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            if (s.Length != t.Length)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]] += 1;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]) && dict[t[i]] > 0)
                {
                    dict[t[i]] -= 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
