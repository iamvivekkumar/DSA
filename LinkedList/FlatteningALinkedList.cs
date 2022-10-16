using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class FlatteningALinkedList
    {
        //Flattening a Linked List
        //Given a Linked List of size N, where every node represents a sub-linked-list and contains two pointers:
        //(i) a next pointer to the next node,
        //(ii) a bottom pointer to a linked list where this node is head.
        //Each of the sub-linked-list is in sorted order.
        //Flatten the Link List such that all the nodes appear in a single level while maintaining the sorted order. 
        //Note: The flattened list will be printed using the bottom pointer instead of next pointer.For more clearity have a look at the printList() function in the driver code.
        //        Input:
        //5 -> 10 -> 19 -> 28
        //|     |     |     | 
        //7     20    22   35
        //|           |     | 
        //8          50    40
        //|                 | 
        //30               45
        //Output:  5-> 7-> 8- > 10 -> 19-> 20->
        //22-> 28-> 30-> 35-> 40-> 45-> 50.
        //Explanation:
        //The resultant linked lists has every
        //node in a single level.
        //(Note: | represents the bottom pointer.)
        //Expected Time Complexity: O(N* M)
        //Expected Auxiliary Space: O(1)
        public static FlatteningListNode Flatten(FlatteningListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            head.next = Flatten(head.next);

            head = MergeLinkList(head, head.next);

            return head;
        }
        public static FlatteningListNode MergeLinkList(FlatteningListNode L1, FlatteningListNode L2)
        {
            if (L1 == null)
            {
                return L2;
            }
            if (L2 == null)
            {
                return L1;
            }
            var temp = new FlatteningListNode(-1);
            var res = temp;

            while (L1 != null && L2 != null)
            {
                if (L1.data < L2.data)
                {
                    temp.bottom = L1;
                    L1 = L1.bottom;
                }
                else
                {
                    temp.bottom = L2;
                    L2 = L2.bottom;
                }

                temp = temp.bottom;
            }

            if (L1 == null)
            {
                temp.bottom = L2;
            }
            else
            {
                temp.bottom = L1;
            }

            return res.bottom;

        }

        //static void Main(string[] args)
        //{
        //    //5-> 10-> 19-> 28
        //    //|    |    |    |
        //    //7    20   22  35
        //    //|          |   |
        //    //8         50   40
        //    //Output: 5-> 7-> 8 - > 10-> 19-> 20->
        //    //22-> 28-> 30-> 35-> 40
        //    FlatteningListNode head = new FlatteningListNode(5);
        //    head.bottom = new FlatteningListNode(7);
        //    head.bottom.bottom = new FlatteningListNode(8);

        //    head.next = new FlatteningListNode(10);
        //    head.next.bottom = new FlatteningListNode(20);

        //    head.next.next = new FlatteningListNode(19);
        //    head.next.next.bottom = new FlatteningListNode(22);
        //    head.next.next.bottom.bottom = new FlatteningListNode(50);

        //    head.next.next.next = new FlatteningListNode(28);
        //    head.next.next.next.bottom = new FlatteningListNode(35);
        //    head.next.next.next.bottom.bottom = new FlatteningListNode(40);


        //    var res = Flatten(head);

        //    while(res != null)
        //    {
        //        Console.Write(res.data);
        //        Console.Write("->");
        //        res = res.bottom;
        //    }
        //}

    }
}
