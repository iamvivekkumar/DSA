using System.Globalization;
using System.IO;
using System.CodeDom.Compiler;
using System.Linq;
using System.Reflection;
using System.Text;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

class SinglyLinkedListElement
{
    public int data;
    public SinglyLinkedListElement next;

    public SinglyLinkedListElement(int elementData)
    {
        this.data = elementData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListElement head;
    public SinglyLinkedListElement tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertElement(int elementData)
    {
        SinglyLinkedListElement element = new SinglyLinkedListElement(elementData);

        if (this.head == null)
        {
            this.head = element;
        }
        else
        {
            this.tail.next = element;
        }

        this.tail = element;
    }
}

class DisplaySinglyLinkedList
{
    public static void DisplayList(SinglyLinkedListElement element, string sep, TextWriter textWriter)
    {
        while (element != null)
        {
            textWriter.Write(element.data);

            element = element.next;

            if (element != null)
            {
                textWriter.Write(sep);
            }
        }
    }
}


class Result
{
    /*
     * implement method/function with name 'checkPalindrome' below.
     *
     * The function is expected to return a value of type int.
     * The function accepts following parameters:
     * 1. a is of type SinglyLinkedList.
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListElement
     * {
     *     int data;
     *     SinglyLinkedListElement next;
     * }
     *
     */
    static SinglyLinkedListElement head;
    public static int checkPalindrome(SinglyLinkedList a)
    {
        //Write your code here
        head = a.head;
        return Rec(a.head);

        ////find median
        //SinglyLinkedListElement slow = head;
        //SinglyLinkedListElement fast = head;

        //while (fast != null && fast.next != null)
        //{
        //    slow = slow.next;
        //    fast = fast.next.next;
        //}

        //var rev = Reverse(slow);
        ////2,5

        //while (head != null && rev != null)
        //{
        //    if (head.data != rev.data)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        head = head.next;
        //        rev = rev.next;
        //    }
        //}

        //return 1;

    }
    public static SinglyLinkedListElement Reverse(SinglyLinkedListElement element)
    {
        SinglyLinkedListElement newHead = null;



        while (element != null)
        {
            var next = element.next;

            element.next = newHead;
            newHead = element;

            element = next;
        }

        return newHead;
    }


    public static int Rec(SinglyLinkedListElement element)
    {
        if (element == null)
        {
            return 1;
        }

        if (Rec(element.next) == 1 && head.data == element.data)
        {
            head = head.next;
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

//class Solution1
//{
//    public static void Main(string[] args)
//    {
//        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
//        var aItemsInput = new int[] { 2, 5, 7, 5, 2 };

//        foreach (var num in aItemsInput)
//        {
//            singlyLinkedList.InsertElement(num);
//        }

//        int outcome = Result.checkPalindrome(singlyLinkedList);

//        Console.WriteLine(outcome);
//    }
//}
