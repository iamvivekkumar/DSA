using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class PairwiseSwapElementsOfLinkedList
    {
        //Pairwise swap elements of a linked list
        //Given a singly linked list of size N.The task is to swap elements in the linked list pairwise.
        //For example, if the input list is 1 2 3 4, the resulting list after swaps will be 2 1 4 3.
        //Note: You need to swap the nodes, not only the data. If only data is swapped then driver will print -1.

        //Example 1:

        //Input:
        //LinkedList: 1->2->2->4->5->6->7->8
        //Output: 2 1 4 2 6 5 8 7
        //Explanation: After swapping each pair
        //considering (1,2), (2, 4), (5, 6).. so
        //on as pairs, we get 2, 1, 4, 2, 6, 5,
        //8, 7 as a new linked list.


        //Example 2:

        //Input:
        //LinkedList: 1->3->4->7->9->10->1
        //Output: 3 1 7 4 10 9 1
        //Explanation: After swapping each pair
        //considering (1,3), (4, 7), (9, 10).. so
        //on as pairs, we get 3, 1, 7, 4, 10, 9,
        //1 as a new linked list.

        public static ListNode PairwiseSwap(ListNode head)
        {
            //LinkedList: 1->2->2->4->5->6->7->8
            //Output: 2 1 4 2 6 5 8 7

            var curr = head;

            while(curr != null && curr.next != null)
            {
                var temp = curr.next.next;
                var next = curr.next;

                curr.next = temp;
                next.next = curr;

                curr = temp;

               
            }

            //No change of value
            //while(curr != null && curr.next != null)
            //{
            //    var temp = curr.val;
            //    curr.val = curr.next.val;
            //    curr.next.val = temp;

            //    curr = curr.next.next;
            //}

            return head;

        }

        //static void Main(string[] args)
        //{
        //    ListNode first = new ListNode(1);
        //    first.next = new ListNode(2);
        //    first.next.next = new ListNode(3);
        //    first.next.next.next = new ListNode(4);
        //    first.next.next.next.next = new ListNode(5);
        //    first.next.next.next.next.next = new ListNode(6);
        //    first.next.next.next.next.next.next = new ListNode(7);
        //    first.next.next.next.next.next.next.next = new ListNode(8);

        //    var res = PairwiseSwap(first);

        //}
    }
}
