﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Reverse array in groups 

    //    Given an array arr[] of positive integers of size N.Reverse every sub-array group of size K.



    //Example 1:

    //Input:
    //N = 5, K = 3
    //arr[] = { 1,2,3,4,5}
    //    Output: 3 2 1 5 4
    //Explanation: First group consists of elements
    //1, 2, 3. Second group consists of 4,5.


    //Example 2:

    //Input:
    //N = 4, K = 3
    //arr[] = {5,6,8,9}
    //Output: 8 6 5 9



    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function reverseInGroups() which takes the array, N and K as input parameters and modifies the array in-place. 



    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)
    public static class ReverseArrayInGroups
    {
        public static void ReverseInGroups(int[] arr, int n, int k)
        {
            //N = 5, K = 3
            //arr[] = { 1, 2, 3, 4, 5 }
            //Output: 3 2 1 5 4

            for (int i = 0; i < n; i = i + k)
            {
                int left = i;
                int right = left + k - 1;
                if (right > n-1)
                {
                    right = n - 1;
                }

                int temp;
                while (left < right)
                {
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            
        }
    }
}
