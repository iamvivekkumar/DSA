using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class Reverse
    {
        //Reverse Linked List
        //Given the head of a singly linked list, reverse the list, and return the reversed list.

        //Input: head = [1,2,3,4,5]
        //Output: [5,4,3,2,1]

        //Input: head = [1,2]
        //Output: [2,1]

        //Input: head = []
        //Output: []

        public ListNode ReverseList(ListNode head)
        {
            // 1,2,3,4,5,null        
            //5,4,3,2,1,null   

            ListNode newHead = null;

            while (head != null)
            {
                ListNode next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }

            return newHead;
        }
    }
}
