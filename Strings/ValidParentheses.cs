using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Strings
{
    public class ValidParentheses
    {
        //Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.


        //Example 1:
        //Input: s = "()"
        //Output: true

        //Example 2:
        //Input: s = "()[]{}"
        //Output: true

        //Example 3:
        //Input: s = "(]"
        //Output: false
        public bool IsValid(string s)
        {
            Dictionary<char, char> parentheses = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (parentheses.ContainsKey(s[i]))
                {
                    stack.Push(parentheses[s[i]]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var value = stack.Pop();

                    if (value != s[i])
                    {
                        return false;
                    }

                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsValid2(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in s.ToCharArray())
                if (item == '(' || item == '[' || item == '{')
                    stack.Push(')');
                else if (stack.Count == 0 || stack.Pop() != item)
                    return false;

            return stack.Count == 0;
        }
    }
}