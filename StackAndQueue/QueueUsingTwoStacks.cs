using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.StackAndQueue
{
    public class QueueUsingTwoStacks
    {
        //Queue using two Stacks
        //        Implement a Queue using 2 stacks s1 and s2.
        //A Query Q is of 2 Types
        //(i) 1 x (a query of this type means  pushing 'x' into the queue)
        //(ii) 2   (a query of this type means to pop element from queue and print the poped element)

        //Example 1:

        //Input:
        //5
        //1 2 1 3 2 1 4 2

        //Output: 
        //2 3

        //Explanation: 
        //In the first testcase
        //1 2 the queue will be { 2}
        //1 3 the queue will be { 2 3}
        //2   poped element will be 2 the queue
        //    will be { 3}
        //1 4 the queue will be { 3 4}
        //2   poped element will be 3.
        //Example 2:

        //Input:
        //4
        //1 2 2 2 1 4

        //Output: 
        //2 -1

        //Explanation: 
        //In the second testcase 
        //1 2 the queue will be { 2}
        //2   poped element will be 2 and
        //    then the queue will be empty
        //2   the queue is empty and hence -1
        //1 4 the queue will be { 4}.

        Stack<int> st1 = new Stack<int>();
        Stack<int> st2 = new Stack<int>();

        //Queue - FIFO
        //Stack - LILO
        public void Push(int x)
        {
            st1.Push(x);
        }

        public int Pop()
        {
            if (st2.Count > 0)
            {
                return st2.Pop();
            }
            else
            {
                while (st1.Count > 0)
                {
                    st2.Push(st1.Pop());
                }

                if (st2.Count > 0)
                {
                    return st2.Pop();
                }
                else
                {
                    return -1;
                }
            }
        }

        public int Pop1()
        {
            int res = -1;
            while (st1.Count > 0)
            {
                st2.Push(st1.Pop());
            }

            if (st2.Count > 0)
            {
                res = st2.Pop();
            }

            while (st2.Count > 0)
            {
                st1.Push(st2.Pop());
            }

            return res;
        }
    }
}
