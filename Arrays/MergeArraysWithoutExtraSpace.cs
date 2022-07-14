using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Merge Without Extra Space
    //    Given two sorted arrays arr1[] and arr2[] of sizes n and m in non-decreasing order.Merge them in sorted order without using any extra space.Modify arr1 so that it contains the first N elements and modify arr2 so that it contains the last M elements.



    //Example 1:


    //Input: 
    //n = 4, arr1[] = [1 3 5 7]
    //m = 5, arr2[] = [0 2 6 8 9]
    //Output: 
    //arr1[] = [0 1 2 3]
    //arr2[] = [5 6 7 8 9]
    //Explanation:
    //After merging the two
    //non-decreasing arrays, we get,
    //0 1 2 3 5 6 7 8 9.
    //Example 2:


    //Input: 
    //n = 2, arr1[] = [10, 12]
    //m = 3, arr2[] = [5 18 20]
    //Output: 
    //arr1[] = [5 10]
    //arr2[] = [12 18 20]
    //Explanation:
    //After merging two sorted arrays
    //we get 5 10 12 18 20.



    //Your Task:
    //You don't need to read input or print anything. You only need to complete the function merge() that takes arr1, arr2, n and m as input parameters and modifies them in-place so that they look like the sorted merged array when concatenated.



    //Expected Time Complexity:  O((n+m) log(n+m))
    //Expected Auxilliary Space: O(1)
    public class MergeArraysWithoutExtraSpace
    {
        //        arr1[] = [1 3 5 7]
        //        arr2[] = [0 2 6 8 9]
        //        Output: 
        //        arr1[] = [0 1 2 3]
        //        arr2[] = [5 6 7 8 9]
        public static void MergeSortedArrays(int[] arr1, int[] arr2, int n, int m)
        {
            int i = n - 1;
            int j = 0;

            while (i >= 0 && j < m)
            {
                if (arr1[i] > arr2[j])
                {
                    var temp = arr1[i];
                    arr1[i] = arr2[j];
                    arr2[j] = temp;
                    i--; j++;
                }
                else
                {
                    break;
                }
            }

            Array.Sort(arr1);
            Array.Sort(arr2);
        }
    }
}
