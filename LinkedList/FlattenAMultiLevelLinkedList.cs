using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class FlattenAMultiLevelLinkedList
    {
        static void FlattenList(MultilevelListNode node)
        {
            var head = node;
            var curr = head;
            var tail = node;

            while (tail.next != null)
            {
                tail = tail.next;
            }

            while (curr != tail)
            {
                if (curr.child != null)
                {
                    tail.next = curr.child;
                    var temp = curr.child;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    tail = temp;
                }

                curr = curr.next;
            }

        }
        static void Main(string[] args)
        {
            var head = CreateList();
            FlattenList(head);

        }

        static MultilevelListNode CreateList(int[] arr, int n)
        {
            MultilevelListNode node = null;
            MultilevelListNode p = null;

            int i;
            for (i = 0; i < n; ++i)
            {
                if (node == null)
                {
                    node = p = new MultilevelListNode(arr[i]);
                }
                else
                {
                    p.next = new MultilevelListNode(arr[i]);
                    p = p.next;
                }
                p.next = p.child = null;
            }
            return node;
        }
        static MultilevelListNode CreateList()
        {
            //10 - 5 - 12 - 7  -  11
            //|
            //4 - 20 - 13   17 - 6
            //    |    |     |
            //    2    16    9 - 8
            //         |     |
            //         3    19 - 15
            int[] arr1 = new int[] { 10, 5, 12, 7, 11 };
            int[] arr2 = new int[] { 4, 20, 13 };
            int[] arr3 = new int[] { 17, 6 };
            int[] arr4 = new int[] { 9, 8 };
            int[] arr5 = new int[] { 19, 15 };
            int[] arr6 = new int[] { 2 };
            int[] arr7 = new int[] { 16 };
            int[] arr8 = new int[] { 3 };

            /* create 8 linked lists */
            MultilevelListNode head1 = CreateList(arr1, arr1.Length);
            MultilevelListNode head2 = CreateList(arr2, arr2.Length);
            MultilevelListNode head3 = CreateList(arr3, arr3.Length);
            MultilevelListNode head4 = CreateList(arr4, arr4.Length);
            MultilevelListNode head5 = CreateList(arr5, arr5.Length);
            MultilevelListNode head6 = CreateList(arr6, arr6.Length);
            MultilevelListNode head7 = CreateList(arr7, arr7.Length);
            MultilevelListNode head8 = CreateList(arr8, arr8.Length);

            /* modify child pointers to
            create the list shown above */
            head1.child = head2;
            head1.next.next.next.child = head3;
            head3.child = head4;
            head4.child = head5;
            head2.next.child = head6;
            head2.next.next.child = head7;
            head7.child = head8;

            /* Return head pointer of first
            linked list. Note that all nodes
             are reachable from head1 */
            return head1;
        }
    }
}
