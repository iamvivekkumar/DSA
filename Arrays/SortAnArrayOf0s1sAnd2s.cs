using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Sort an array of 0s, 1s and 2s
    //    Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.


    //Example 1:

    //Input: 
    //N = 5
    //arr[]= { 0 2 1 2 0}
    //    Output:
    //0 0 1 2 2
    //Explanation:
    //0s 1s and 2s are segregated
    //into ascending order.
    //Example 2:

    //Input: 
    //N = 3
    //arr[] = { 0 1 0}
    //    Output:
    //0 0 1
    //Explanation:
    //0s 1s and 2s are segregated
    //into ascending order.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function sort012() that takes an array arr and N as input parameters and sorts the array in-place.


    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)
    public class SortAnArrayOf0s1sAnd2s
    {
        public static void Sort012WithLessTime(int[] arr)
        {
            //arr[]= { 0 2 1 2 0 }
            //Output: { 0 0 1 2 2 }
            int low = 0, mid = 0, high = arr.Length - 1;
            int temp = 0;

            while (mid < high)
            {
                switch (arr[mid])
                {
                    case 0:
                        temp = arr[low];
                        arr[low] = arr[mid];
                        arr[mid] = temp;
                        low++; mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = arr[mid];
                        arr[mid] = arr[high];
                        arr[high] = temp;
                        high--;
                        break;

                }
            }
        }

        public static void Sort012(int[] arr)
        {
            // N = 5
            //arr[]= { 0 2 1 2 0 }
            //Output:
            //0 0 1 2 2

            int zeros = 0;
            int ones = 0;
            int twos = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        zeros++;
                        break;
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                }
            }

            //update array
            int k = 0;
            while (zeros > 0)
            {
                arr[k] = 0;
                k++; zeros--;
            }
            while (ones > 0)
            {
                arr[k] = 1;
                k++; ones--;
            }
            while (twos > 0)
            {
                arr[k] = 2;
                k++; twos--;
            }

        }
    }
}
