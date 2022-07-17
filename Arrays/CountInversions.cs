using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Count Inversions
    //    Given an array of integers.Find the Inversion Count in the array.

    //Inversion Count: For an array, inversion count indicates how far (or close) the array is from being sorted.If array is already sorted then the inversion count is 0. If an array is sorted in the reverse order then the inversion count is the maximum. 
    //Formally, two elements a[i] and a[j] form an inversion if a[i] > a[j] and i<j.


    //Example 1:


    //Input: N = 5, arr[] = { 2, 4, 1, 3, 5}
    //    Output: 3
    //Explanation: The sequence 2, 4, 1, 3, 5 
    //has three inversions(2, 1), (4, 1), (4, 3).
    //Example 2:

    //Input: N = 5
    //arr[] = {2, 3, 4, 5, 6}
    //Output: 0
    //Explanation: As the sequence is already
    //sorted so there is no inversion count.
    //Example 3:

    //Input: N = 3, arr[] = { 10, 10, 10}
    //Output: 0
    //Explanation: As all the elements of array 
    //are same, so there is no inversion count.
    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function inversionCount() which takes the array arr[] and the size of the array as inputs and returns the inversion count of the given array.

    //Expected Time Complexity: O(NLogN).
    //Expected Auxiliary Space: O(N).
    public class CountInversions
    {
        //Input: N = 5,
        //arr[] = {2, 4, 1, 3, 5}
        //Output: 3
        public long InversionCount(long[] arr, long n)
        {
            long[] tempArr = new long[n];
            long inversions = MergeSort(arr, tempArr, 0, arr.Length - 1);
            return inversions;
        }

        public long MergeSort(long[] arr, long[] tempArr, int left, int right)
        {
            long inversions = 0;

            if (left < right)
            {
                int mid = left + (right - left) / 2;

                inversions += MergeSort(arr, tempArr, left, mid);
                inversions += MergeSort(arr, tempArr, mid + 1, right);

                inversions += MergedArray(arr, tempArr, left, mid, right);
            }

            return inversions;
        }

        public long MergedArray(long[] arr, long[] tempArr, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            long inversions = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    tempArr[k] = arr[i];
                    i++;

                }
                else
                {
                    tempArr[k] = arr[j];
                    j++;
                    inversions += mid - i + 1;
                }
                k++;
            }

            while (j <= right)
            {
                tempArr[k] = arr[j];
                j++; k++;
            }

            while (i <= mid)
            {
                tempArr[k] = arr[i];
                i++; k++;
            }

            for (k = left; k <= right; k++)
            {
                arr[k] = tempArr[k];
            }

            return inversions;
        }

    }
}
