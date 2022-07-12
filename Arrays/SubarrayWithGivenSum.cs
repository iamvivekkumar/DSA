using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Subarray with given sum

    //    Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.

    //In case of multiple subarrays, return the subarray which comes first on moving from left to right.


    //Example 1:

    //Input:
    //N = 5, S = 12
    //A[] = { 1,2,3,7,5}
    //    Output: 2 4
    //Explanation: The sum of elements
    //from 2nd position to 4th position
    //is 12.


    //Example 2:

    //Input:
    //N = 10, S = 15
    //A[] = {1,2,3,4,5,6,7,8,9,10}
    //Output: 1 5
    //Explanation: The sum of elements 
    //from 1st position to 5th position
    //is 15.


    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function subarraySum() which takes arr, N and S as input parameters and returns a list containing the starting and ending positions of the first such occurring subarray from the left where sum equals to S. The two indexes in the list should be according to 1-based indexing. If no such subarray is found, return an array consisting only one element that is -1.



    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)

    class SubarrayWithGivenSum
    {
        public static List<int> SubarraySum(int[] arr, int n, int s)
        {
            // Input:  N = 5, S = 12
            // A[] = { 1, 2, 3, 7, 5 }
            // Output: 2 4

            int startingIndex = 0;
            int currentSum = 0;

            for (int i = 0; i < n; i++)
            {
                currentSum = currentSum + arr[i];

                while (currentSum > s && startingIndex < i)
                {
                    currentSum = currentSum - arr[startingIndex];
                    startingIndex++;
                }

                if (currentSum == s)
                {
                    return new List<int> { startingIndex + 1, i + 1 };
                }
            }

            return new List<int> { -1 };
        }
    }
}
