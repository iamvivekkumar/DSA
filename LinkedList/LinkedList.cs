using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.LinkedList
{
    public class LinkedList
    {
        public ListNode Head { get; set; }
        public int Size { get; set; }
        public LinkedList()
        {
            this.Size = 0;
            this.Head = null;
        }

        public void AddAtHead(int val)
        {
            ListNode newHead = new ListNode(val);
            newHead.next = Head;
            Head = newHead;
            Size++;
        }
    }
}
