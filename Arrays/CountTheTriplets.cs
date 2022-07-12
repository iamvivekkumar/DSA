using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Count the triplets 
    //    Given an array of distinct integers.The task is to count all the triplets such that sum of two elements equals the third element.

    //Example 1:

    //Input:
    //N = 4
    //arr[] = { 1, 5, 3, 2}
    //    Output: 2
    //Explanation: There are 2 triplets: 
    //1 + 2 = 3 and 3 +2 = 5 
    //Example 2:

    //Input: 
    //N = 3
    //arr[] = {2, 3, 4}
    //Output: 0
    //Explanation: No such triplet exits
    //Your Task:  
    //You don't need to read input or print anything. Your task is to complete the function countTriplet() which takes the array arr[] and N as inputs and returns the triplet count

    //Expected Time Complexity: O(N2)
    //Expected Auxiliary Space: O(1)

    public class CountTheTriplets
    {
        public static int CountTriplet(int[] arr, int n)
        {
            //N = 4
            //arr[] = { 1, 5, 3, 2 }
            //arrSort = {1, 2, 3, 5}
            //Output: 2

            int count = 0;
            Array.Sort(arr);

            for (int i = n - 1; i > 1; i--)
            {
                int num = arr[i];
                int left = 0;
                int right = i - 1;
                while (left < right)
                {
                    if (num == arr[left] + arr[right])
                    {
                        count++;
                        left++;
                        right--;
                    }
                    else if (num > arr[left] + arr[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return count;
        }
    }
}
