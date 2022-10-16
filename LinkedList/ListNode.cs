using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }

    public class FlatteningListNode
    {
        public int data;
        public FlatteningListNode next;
        public FlatteningListNode bottom;
        public FlatteningListNode(int data = 0, FlatteningListNode next = null, FlatteningListNode bottom = null)
        {
            this.data = data;
            this.next = next;
            this.bottom = bottom;
        }

    }

    class MultilevelListNode
    {
        public int data;
        public MultilevelListNode next, child;

        public MultilevelListNode(int d)
        {
            data = d;
            next = child = null;
        }
    }
}
