using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class AddTwoNumbersRepresentedByLinkedLists
    {
        //Given two decimal numbers represented by two linked lists of size N and M respectively.The task is to return a linked list that represents the sum of these two numbers.

        //For example, the number 190 will be represented by the linked list, 1->9->0->null, similarly 25 by 2->5->null. Sum of these two numbers is 190 + 25 = 215, which will be represented by 2->1->5->null. You are required to return the head of the linked list 2->1->5->null.

        //Example 1:

        //Input:
        //N = 2
        //valueN[] = {4,5}
        //M = 3
        //valueM[] = {3,4,5}
        //Output: 3 9 0  
        //Explanation: For the given two linked
        //list(4 5) and(3 4 5), after adding
        //the two linked list resultant linked
        //list will be(3 9 0).
        //Example 2:

        //Input:
        //N = 2
        //valueN[] = {6,3}
        //M = 1
        //valueM[] = {7}
        //Output: 7 0
        //Explanation: For the given two linked
        //list(6 3) and(7), after adding the
        //two linked list resultant linked list
        //will be(7 0).

        public static ListNode addTwoLists(ListNode first, ListNode second)
        {
            // valueN[] = { 4,5}
            ////valueM[] = {3,4,5}
            ////Output: 3 9 0 

            //Two way
            //1) Carry wise (Reverse and then add one by one and then again reverse the link list )
            //2) Get number and and then split
            first = ReverseLinkList(first);
            second = ReverseLinkList(second);

            int carry = 0;

            ListNode result = null;

            while (first != null || second != null || carry != 0)
            {
                int firstDigit = 0;
                int secondDigit = 0;

                if (first != null)
                {
                    firstDigit = first.val;
                    first = first.next;
                }

                if (second != null)
                {
                    secondDigit = second.val;
                    second = second.next;
                }

                var sum = firstDigit + secondDigit + carry;

                carry = sum / 10;

                //to save reverse
                var newNode = new ListNode(sum % 10);
                newNode.next = result;
                result = newNode;
            }

            return result;

            //int firstNumber = 0;
            //int secondNumber = 0;

            //ListNode resultListNode = new ListNode(-1);
            //var curr = resultListNode;

            //while (first != null)
            //{
            //    firstNumber = firstNumber * 10 + first.val;
            //    first = first.next;
            //}

            //while (second != null)
            //{
            //    secondNumber = secondNumber * 10 + second.val;
            //    second = second.next;
            //}

            //int finalSum = firstNumber + secondNumber;

            //while (finalSum > 0)
            //{
            //    int digit = finalSum % 10;
            //    curr.next = new ListNode(digit);
            //    curr = curr.next;

            //    finalSum = finalSum / 10;
            //}

            //var finalLinkList = ReverseLinkList(resultListNode.next);

            //return finalLinkList;

        }

        static ListNode ReverseLinkList(ListNode root)
        {
            ListNode newNode = null;
            var curr = root;

            while (curr != null)
            {
                var temp = curr.next;

                curr.next = newNode;
                newNode = curr;

                curr = temp;
            }
            return newNode;
        }

        //static void Main(string[] args)
        //{
        //    ListNode first = new ListNode(4);
        //    first.next = new ListNode(5);

        //    ListNode second = new ListNode(3);
        //    second.next = new ListNode(4);
        //    second.next.next = new ListNode(5);

        //    var res = addTwoLists(first, second);

        //}
    }
}
