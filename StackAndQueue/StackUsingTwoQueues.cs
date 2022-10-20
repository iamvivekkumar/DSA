using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackAndQueue
{
    public class StackUsingTwoQueues
    {
        //Implement a Stack using two queues q1 and q2.

        //Example 1:

        //Input:
        //push(2)
        //push(3)
        //pop()
        //push(4)
        //pop()
        //Output: 3 4
        //Explanation:
        //push(2) the stack will be {2}
        //    push(3) the stack will be {2 3}
        //    pop()   poped element will be 3 the
        //            stack will be {2}
        //    push(4) the stack will be {2 4}
        //    pop()   poped element will be 4  
        //Example 2:

        //Input:
        //push(2)
        //pop()
        //pop()
        //push(3)
        //Output: 2 -1

        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        //Queue - FIFO
        //Stack - LIFO

        //Complete the functions
        public void Push(int x)
        {
            //Add in q2
            //q1 -> q2
            //q2 -> q1
            q2.Enqueue(x);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
        }

        public void BetterPush(int x)
        {
            q1.Enqueue(x);
            int count = q1.Count;   
            
            for (int i = 0; i < count - 1 ; i++)
            {
                q1.Enqueue(q1.Dequeue());
            }

        }

        public int Pop()
        {
            if (q1.Count > 0)
            {
                return q1.Dequeue();
            }

            return -1;
        }

        //static void Main()
        //{
        //    StackUsingTwoQueues obj = new StackUsingTwoQueues();
        //    obj.Push(1);
        //    obj.Push(2);
        //    var t1 = obj.Pop();
        //    var t2 = obj.Pop();
        //}

    }
}
