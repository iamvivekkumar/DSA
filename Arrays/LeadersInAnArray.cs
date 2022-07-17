using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    //Leaders in an array
    //    Given an array A of positive integers.Your task is to find the leaders in the array.An element of array is leader
    //    if it is greater than or equal to all the elements to its right side. The rightmost element is always a leader.

    //Example 1:
    //Input:
    //n = 6
    //A[] = { 16,17,4,3,5,2}
    //Output: 17 5 2
    //Explanation: The first leader is 17 
    //as it is greater than all the elements
    //to its right.Similarly, the next
    //leader is 5. The right most element 
    //is always a leader so it is also
    //included.



    //Example 2:

    //Input:
    //n = 5
    //A[] = { 1,2,3,4,0}
    //Output: 4 0


    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function leader() which takes array A and n as input parameters and
    //returns an array of leaders in order of their appearance.

    //Expected Time Complexity: O(n)
    //Expected Auxiliary Space: O(n)
    public class LeadersInAnArray
    {
        public int[] Leaders(int[] arr, int n)
        {
            //A[] = { 16,17,4,3,5,2}
            //Output: 17 5 2
            int max = arr[n - 1];
            List<int> leaders = new List<int>();
            leaders.Insert(0, arr[n - 1]);

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    leaders.Insert(0, arr[i]);
                }

            }

            return leaders.ToArray();
        }
    }
}
