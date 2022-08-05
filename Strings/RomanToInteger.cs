using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class RomanToInteger
    {
        //Roman to Integer
        //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        //Symbol Value
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000

        //Example 1:
        //Input: s = "III"
        //Output: 3
        //Explanation: III = 3.

        //Example 2:
        //Input: s = "LVIII"
        //Output: 58
        //Explanation: L = 50, V= 5, III = 3.

        //Example 3:
        //Input: s = "MCMXCIV"
        //Output: 1994
        //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
        public int RomanToInt(string s)
        {
            Dictionary<char, int> valuesConverter = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int intNum = valuesConverter[s[s.Length - 1]];
            //Input: s = "MCMXCIV"
            //Output: 1994

            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (valuesConverter[s[i]] < valuesConverter[s[i + 1]])
                {
                    intNum = intNum - valuesConverter[s[i]];
                }
                else
                {
                    intNum = intNum + valuesConverter[s[i]];
                }
            }

            return intNum;

        }
    }
}
