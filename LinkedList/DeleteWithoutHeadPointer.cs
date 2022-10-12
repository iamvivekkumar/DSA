﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class DeleteWithoutHeadPointer
    {
        //Delete without head pointer

        //You are given a pointer/ reference to the node which is to be deleted from the linked list of N nodes.The task is to delete the node. Pointer/ reference to head node is not given. 
        //Note: No head reference is given to you.It is guaranteed that the node to be deleted is not a tail node in the linked list.

        //Example 1:
        //Input:
        //N = 2
        //value[] = { 1,2}
        //node = 1
        //Output: 2
        //Explanation: After deleting 1 from the
        //linked list, we have remaining nodes
        //as 2.

        //Example 2:
        //Input:
        //N = 4
        //value[] = {10,20,4,30}
        //node = 20
        //Output: 10 4 30
        //Explanation: After deleting 20 from
        //the linked list, we have remaining
        //nodes as 10, 4 and 30.
        public void deleteNode(ListNode del)
        {
            del.val = del.next.val;
            del.next = del.next.next;
        }
    }
}
