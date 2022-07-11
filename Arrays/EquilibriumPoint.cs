using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Equilibrium Point 
    //    Given an array A of n positive numbers.The task is to find the first Equilibium Point in the array. 
    //Equilibrium Point in an array is a position such that the sum of elements before it is equal to the sum of elements after it.

    //Note: Retun the index of Equilibrium point. (1-based index)

    //Example 1:

    //Input: 
    //n = 5 
    //A[] = {1,3,5,2,2}
    //Output: 3
    //Explanation: For second test case 
    //equilibrium point is at position 3 
    //as elements before it (1+3) =
    //elements after it(2+2). 


    //Example 2:

    //Input:
    //n = 1
    //A[] = { 1}
    //Output: 1
    //Explanation:
    //Since its the only element hence
    //its the only equilibrium point.


    //Your Task:
    //The task is to complete the function equilibriumPoint() which takes the array and n as input parameters and returns the point of equilibrium. Return -1 if no such point exists.

    //Expected Time Complexity: O(n)
    //Expected Auxiliary Space: O(1)
    public class EquilibriumPoint
    {
        public static int GetEquilibriumPoint(int[] arr)
        {
            // arr = {1,2,5,2,2}
            int totalSum = 0;
            int leftSum = 0;
            int rightSum = 0;
            int ep = -1;

            if (arr.Length == 1)
            {
                return 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }

            for (int i = 1; i < arr.Length; i++)
            {
                leftSum += arr[i - 1];
                rightSum = totalSum - leftSum - arr[i];

                if (leftSum == rightSum)
                {
                    return i + 1;
                }
            }

            return ep;
        }
    }
}
