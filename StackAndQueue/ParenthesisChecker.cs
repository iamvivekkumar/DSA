using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackAndQueue
{
    public class ParenthesisChecker
    {
        //Parenthesis Checker
        // Given an expression string x.Examine whether the pairs and the orders of “{“,”}”,”(“,”)”,”[“,”]” are correct in exp.
        //For example, the function should return 'true' for exp = “[()]{}{[()()] ()
        //}” and 'false' for exp = “[(])”.

        //Example 1:

        //Input:
        //{ ([])}
        //Output:
        //true
        //Explanation:
        //{ ( [ ]) }. Same colored brackets can form 
        //balaced pairs, with 0 number of 
        //unbalanced bracket.
        //Example 2:

        //Input:
        //()
        //Output:
        //true
        //Explanation:
        //().Same bracket can form balanced pairs,
        //and here only 1 type of bracket is 
        //present and in balanced way.
        //Example 3:

        //Input:
        //([]
        //Output:
        //false
        //Explanation:
        //([].Here square bracket is balanced but 
        //the small bracket is not balanced and 
        //Hence , the output will be unbalanced.

        public bool Ispar(string s)
        {
            //“{“,”}”,”(“,”)”,”[“,”]”
            // ([]
            // )
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();

            dict.Add('{', '}');
            dict.Add('(', ')');
            dict.Add('[', ']');

            foreach (var p in s)
            {
                if (!dict.ContainsKey(p))
                {
                    if(stack.Count == 0 || stack.Pop() != p)
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(dict[p]);
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;

        }
    }
}
