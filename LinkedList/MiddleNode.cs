using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    //Finding middle element in a linked list
    //Given a singly linked list of N nodes.
    //The task is to find the middle of the linked list. For example, if the linked list is
    //1-> 2->3->4->5, then the middle node of the list is 3.
    //If there are two middle nodes(in case, when N is even), print the second middle element.
    //For example, if the linked list given is 1->2->3->4->5->6, then the middle node of the list is 4.

    //Example 1:
    //Input:
    //LinkedList: 1->2->3->4->5
    //Output: 3 
    //Explanation: 
    //Middle of linked list is 3.

    //Example 2:
    //Input:
    //LinkedList: 2->4->6->7->5->1
    //Output: 7 
    //Explanation: 
    //Middle of linked list is 7.
    //Your Task:
    //The task is to complete the function getMiddle() which takes a head reference as the only argument and should return the data at the middle node of the linked list.

    //Expected Time Complexity: O(N).
    //Expected Auxiliary Space: O(1).    

    public class MiddleNode
    {
        public ListNode MiddleNode1(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
