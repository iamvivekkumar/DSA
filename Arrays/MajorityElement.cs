using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class MajorityElement
    {
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

        //Example 1:
        //Input: nums = [3, 2, 3]
        //Output: 3

        //Example 2:
        //Input: nums = [2, 2, 1, 1, 1, 2, 2]
        //Output: 2

        public static int GetMajorityElement(int[] nums)
        {
            //Input: nums = [2, 2, 1, 1, 1, 2, 2]
            //Output: 2

            //Input: [2,2,1,1, 1, 2, 2]
            // Output:2
            int count = 0;//1,2,1,0,1,0,1
            int majorityValue = 0;//2,2,2,2,1,1,2           

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    majorityValue = nums[i];
                }

                if (majorityValue == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return majorityValue;
        }
    }
}
