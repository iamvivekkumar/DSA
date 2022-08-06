using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class LongestCommonPrefix
    {
        //Longest Common Prefix
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".

        //Example 1:
        //Input: strs = ["flower", "flow", "flight"]
        //Output: "fl"

        //Example 2:
        //Input: strs = ["dog", "racecar", "car"]
        //Output: ""
        //Explanation: There is no common prefix among the input strings.

        public string GetLongestCommonPrefix(string[] strs)
        {
            string res = "";
            int minLength = strs[0].Length;

            for (int i = 0; i < strs.Length; i++)
            {
                minLength = Math.Min(minLength, strs[i].Length);
            }

            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"
            bool flag = true;
            char ch = ' ';
            for (int i = 0; i < minLength; i++)
            {
                ch = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (ch != strs[j][i])
                    {
                        return res;
                    }
                }

                res += ch;
            }

            return res;

        }
    }
}
