using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class ReverseWordsInString
    {
        //Reverse Words in a String
        //Given an input string s, reverse the order of the words.
        //A word is defined as a sequence of non-space characters.The words in s will be separated by at least one space.
        //Return a string of the words in reverse order concatenated by a single space.
        //Note that s may contain leading or trailing spaces or multiple spaces between two words.The returned string should only have a single space separating the words. Do not include any extra spaces.

        //Example 1:
        //Input: s = "the sky is blue"
        //Output: "blue is sky the"

        //Example 2:
        //Input: s = "  hello world  "
        //Output: "world hello"
        //Explanation: Your reversed string should not contain leading or trailing spaces.

        //Example 3:
        //Input: s = "a good   example"
        //Output: "example good a"
        //Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

        public string ReverseWords(string s)
        {
            //Input: s = "the sky is blue"
            //Output: "blue is sky the"
            string result = ""; ;

            int n = s.Length;
            int i = 0;
            int j = 0;

            while (i < n)
            {
                while (i < n && s[i] == ' ')
                {
                    i++;
                }
                if (i >= n)
                {
                    break;
                }

                j = i + 1;

                while (j < n && s[j] != ' ')
                {
                    j++;
                }

                string word = s.Substring(i, j - i);

                if (result != "")
                {
                    result = word + " " + result;
                }
                else
                {
                    result = word;
                }

                i = j + 1;

            }

            return result;

        }

    }
}
