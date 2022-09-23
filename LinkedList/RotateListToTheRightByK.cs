using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class RotateListToTheRightByK
    {
        //Rotate List
        //Given the head of a linked list, rotate the list to the right by k places.

        //Input: head = [1,2,3,4,5], k = 2
        //Output: [4,5,1,2,3]

        //Input: head = [0,1,2], k = 4
        //Output: [2,0,1]

        public ListNode RotateRight(ListNode head, int k)
        {

            if (k == 0 || head == null)
            {
                return head;
            }
            //1,2,3
            int len = 1;
            ListNode curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
                len++;
            }

            //Circlular linklist
            curr.next = head;

            k = k % len;
            k = len - k;

            //cut
            while (k > 0)
            {
                curr = curr.next;
                k--;
            }

            head = curr.next;
            curr.next = null;

            return head;
        }
    }
}
