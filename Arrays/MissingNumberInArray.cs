using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Missing number in array
    //    Given an array of size N-1 such that it only contains distinct integers in the range of 1 to N.Find the missing element.

    //Example 1:

    //Input:
    //N = 5
    //A[] = { 1,2,3,5}
    //    Output: 4
    //Example 2:

    //Input:
    //N = 10
    //A[] = {6,1,2,8,3,4,7,10,5}
    //Output: 9

    //Your Task :
    //You don't need to read input or print anything. Complete the function MissingNumber() that takes array and N as input  parameters and returns the value of the missing number.


    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)
    public static class MissingNumberInArray
    {
        //Input:
        //N = 10
        //A[] = {6,1,2,8,3,4,7,10,5}
        //Output: 9
        public static int MissingNumber(int[] arr)
        {
            //int n = arr.Length;
            //int n_elements_sum = (n + 1) * (n + 2) / 2;

            int totalSequencialSum = 0;
            int arrSum = 0;
            int i;
            for (i = 1; i <= arr.Length; i++)
            {
                totalSequencialSum += i;
                arrSum += arr[i-1];
            }

            totalSequencialSum += i;

            return totalSequencialSum - arrSum;
        }
    }
}
